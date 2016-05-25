Create database DB_Escola
	on primary
		(name = 'Escola_Principal',
		 filename = 'D:\Escola\Escola_Principal.mdf',
		 size = 15 mb,
		 filegrowth = 15%),

	filegroup [FG1]
		(name = 'Escola_Data1_FG1',
		 filename = 'D:\Escola\Escola_Data1_FG1.ndf',
		 size = 5 mb,
		 filegrowth = 15%),

		(name = 'Escola_Data2_FG1',
		 filename = 'D:\Escola\Escola_Data2_FG1.ndf',
		 size = 5 mb,
		 filegrowth = 15%),
	
	filegroup [FG2]
		(name = 'Escola_Data3_FG2',
		 filename = 'D:\Escola\Escola_Data3_FG2.ndf',
		 size = 5 mb,
		 filegrowth = 15%)

	log on
		(name = 'Escola_Log',
		 filename = 'D:\Escola\Escola_Log.ldf',
		 size = 3 mb,
		 filegrowth = 10%)
	collate latin1_general_cs_as
go

Use DB_Escola
go

Create schema SysProtected authorization dbo
go
 
Create table SysProtected.Endereco (
	Id_Endereco			Int							Primary key		identity,
	Estado				Varchar(15)		not null,
	Cidade				Varchar(20)		not null,
	CEP					Char(10)		not null	Check (CEP like '[0-9][0-9][0-9][0-9][0-9]-[0-9][0-9][0-9]'),
	Bairro				Varchar(20)		not null,
	Nome_Rua			Varchar(40)		collate latin1_general_ci_ai	not null
)
go

Create unique index Unico_Endreco
   on SysProtected.Endereco (CEP, Nome_Rua, Bairro); 
go

Create table SysProtected.Funcionarios (
	Id_Funcionario		Int							Primary key		identity,
	Id_Endereco			Int				not null	Foreign key references SysProtected.Endereco (Id_Endereco),
	Nome				Varchar(40)		not null,
	DataNascimento		Date			not null	Check (datediff(year, DataNascimento, Getdate( )) > 18),
	Sexo				Char			not null,
	Estado_Civil		Varchar(13)		not null,
	RG					Varchar(12)					Unique check (RG like '[0-9][0-9].[0-9][0-9][0-9].[0-9][0-9][0-9]-[0-9X]'),
	CPF					Varchar(14)					Unique check (CPF like '[0-9][0-9][0-9].[0-9][0-9][0-9].[0-9][0-9][0-9]-[0-9][0-9]'),
	Status_Funcionario	Varchar(10)		not null,
	Email				Varchar(255)	null		Default ('Nome@speakschool.com.br'),
	Foto				Varbinary(MAX)	null,
	DDD					Varchar(5)		not null,			
	Telefone			Varchar(11)		not null,
	Quantidade_Filhos	Tinyint			null,
	Historico_Escolar	Varchar(40)		not null,
	Cargo				Varchar(20)		not null,
	Salario				Money			not null	Check (Salario >= 0),
	Complemento			Varchar(15)		null,
	Numero				Varchar(5)		not null
)
go

CREATE PROCEDURE CadastroFuncionario
	@Id_Endereco		int,
	@Nome				varchar(40),
	@DataNascimento		date,
	@Sexo				char,
	@Estado_Civil		varchar(13),
	@RG					varchar(12),
	@CPF				varchar(14),
	@Email				varchar(255),
	@DDD				varchar(5),
	@Telefone			varchar(11),
	@Quantidade_Filhos	tinyint,
	@Historico_Escolar	varchar(40),
	@Cargo				varchar(20),
	@Salario			money,
	@Complemento		varchar(15),
	@Numero				varchar(5)
AS
	Insert into SysProtected.Funcionarios values 
	(
		@Id_Endereco,
		@Nome,
		@DataNascimento,
		@Sexo,
		@Estado_Civil,
		@RG,
		@CPF,
		'Ativo',
		@Email,
		null,
		@DDD,
		@Telefone,
		@Quantidade_Filhos,
		@Historico_Escolar,
		@Cargo,
		@Salario,
		@Complemento,
		@Numero
	)
GO

Create table SysProtected.Historico_Funcionario (
	Id_Historico		Int							Primary key		identity,
	Id_Funcionario		Int				not null	Foreign key references SysProtected.Funcionarios (Id_Funcionario),
	Data				DateTime		not null,
	Descricao			Varchar(800)	not null
)
go

Create trigger TGR_HistoricoFuncionariosAdmissao
on SysProtected.Funcionarios
after insert
as
begin
	declare @Id_Funcionario int;
	
	select @Id_Funcionario = Id_Funcionario from inserted;
	
	Insert into SysProtected.Historico_Funcionario values (@Id_Funcionario, Getdate( ), 'Foi admitido na empresa no dia de hoje')
end
go

Create trigger TGR_HistoricoFuncionariosModificaSituacao
on SysProtected.Funcionarios
after update
as
begin
	declare @Id_Funcionario int;
	declare @st_Funcionario varchar(10);

	if (UPDATE(Status_Funcionario))
	begin
		select @Id_Funcionario = Id_Funcionario, @st_Funcionario = Status_Funcionario FROM Inserted

		if(@st_funcionario = 'Inativo')
		begin
			Insert into SysProtected.Historico_Funcionario values (@Id_Funcionario, Getdate( ), 'Funcion�rio foi desligado da empresa no dia de hoje.')
		end
		else if (@st_Funcionario = 'Ativo')
		begin
			Insert into SysProtected.Historico_Funcionario values (@Id_Funcionario, Getdate( ), 'Foi readmitido na empresa no dia de hoje');
		end
	end
end
go

Create table SysProtected.Responsavel_Aluno (
	Id_Responsavel		Int							Primary key		identity,
	Id_Endereco			Int				not null	Foreign key references	SysProtected.Endereco (Id_Endereco),
	Nome				Varchar(40)		not null,
	DataNascimento		Date			not null	Check (datediff(year, DataNascimento, Getdate( )) > 18),
	Sexo				Char			not null,
	Estado_Civil		Varchar(13)		not null,
	RG					Varchar(12)					Unique check (RG like '[0-9][0-9].[0-9][0-9][0-9].[0-9][0-9][0-9]-[0-9X]'),
	CPF					Varchar(14)					Unique check (CPF like '[0-9][0-9][0-9].[0-9][0-9][0-9].[0-9][0-9][0-9]-[0-9][0-9]'),
	Email				Varchar(255)	null,
	DDD					Varchar(5)		not null,
	Telefone			Varchar(11)		not null,
	Complemento			Varchar(15)		null,
	Numero				Varchar(5)		not null
)
go

CREATE PROCEDURE CadastroResponsavel
	@Id_Endereco		int,
	@Nome				varchar(40),
	@DataNascimento		date,
	@Sexo				char,
	@Estado_Civil		varchar(13),
	@RG					varchar(12),
	@CPF				varchar(14),
	@Email				varchar(255),
	@DDD				varchar(5),
	@Telefone			varchar(11),
	@Complemento		varchar(15),
	@Numero				varchar(5)
AS
	Insert into SysProtected.Responsavel_Aluno values 
	(
		@Id_Endereco,
		@Nome,
		@DataNascimento,
		@Sexo,
		@Estado_Civil,
		@RG,
		@CPF,
		@Email,
		@DDD,
		@Telefone,
		@Complemento,
		@Numero
	)
GO

Create table SysProtected.Alunos (
	Id_Aluno			Int							Primary key		identity,
	Id_Responsavel		Int				null		Foreign key	references SysProtected.Responsavel_Aluno (Id_Responsavel),
	Id_Endereco			Int				not null	Foreign key	references SysProtected.Endereco (Id_Endereco),
	Nome				Varchar(40)		not null,
	DataNascimento		Date			not null	Check (datediff(year, DataNascimento, Getdate( )) > 13),
	Sexo				Char			not null,
	Estado_Civil		Varchar(13)		null,
	RG					Varchar(12)		null		check (RG = null or RG like '[0-9][0-9].[0-9][0-9][0-9].[0-9][0-9][0-9]-[0-9X]'),
	CPF					Varchar(14)		null		check (CPF = null or CPF like '[0-9][0-9][0-9].[0-9][0-9][0-9].[0-9][0-9][0-9]-[0-9][0-9]'),
	Status_Aluno		bit				not null,
	Email				Varchar(255)	null,
	Foto				Varbinary(max)	null,
	DDD					Varchar(5)		not null,
	Telefone			Varchar(11)		not null,
	Historico_Escolar	Varchar(40)		not null,
	Complemento			Varchar(15)		null,
	Numero				Varchar(5)		not null,
)
go

Create unique index Alunos
   on SysProtected.Alunos (Nome, DataNascimento, Historico_Escolar, Numero); 
go

CREATE PROCEDURE CadastroAluno
	@Id_Responsavel		int,
	@Id_Endereco		int,
	@Nome				varchar(40),
	@DataNascimento		date,
	@Sexo				char,
	@Estado_Civil		varchar(13),
	@RG					varchar(12),
	@CPF				varchar(14),
	@Email				varchar(255),
	@DDD				varchar(5),
	@Telefone			varchar(11),
	@Historico_Escolar	varchar(40),
	@Complemento		varchar(15),
	@Numero				varchar(5)
AS
	if (@Id_Responsavel = 0)
	begin
		set @Id_Responsavel = null
	end
	Insert into SysProtected.Alunos values 
	(
		@Id_Responsavel,
		@Id_Endereco,
		@Nome,
		@DataNascimento,
		@Sexo,
		@Estado_Civil,
		@RG,
		@CPF,
		1,
		@Email,
		null,
		@DDD,
		@Telefone,
		@Historico_Escolar,
		@Complemento,
		@Numero
	)
GO


Create table SysProtected.Historico_Aluno (
	Id_Historico		Int				not null	Primary key		identity,
	Id_Aluno			Int				not null	Foreign key references SysProtected.Alunos (Id_Aluno),
	Data				DateTime		not null,
	Descricao			Varchar(800)	not null
)
go

Create trigger TGR_HistoricoAlunos
on SysProtected.Alunos
after insert
as
begin
	declare @Id_Aluno int;
	
	select @Id_Aluno = Id_Aluno from inserted;
	
	Insert into SysProtected.Historico_Aluno values (@Id_Aluno, Getdate( ), 'Matriculou-se na escola no dia de hoje')
end
go

Create trigger TGR_HistoricoAlunoModificaSituacao
on SysProtected.Alunos
after update
as
begin
	declare @Id_Aluno int;
	declare @st_Aluno varchar(10);

	if (UPDATE(Status_Aluno))
	begin
		select @Id_Aluno = Id_Aluno, @st_Aluno = Status_Aluno FROM Inserted

		if(@st_Aluno = 0)
		begin
			Insert into SysProtected.Historico_Aluno values (@Id_Aluno, Getdate( ), 'A matricula do aluno foi cancelada no dia de hoje.')
		end
		else if (@st_Aluno = 1)
		begin
			Insert into SysProtected.Historico_Aluno values (@Id_Aluno, Getdate( ), 'Aluno foi re-matriculado no dia de hoje.');
		end
	end
end
go

Create table SysProtected.Idiomas (
	Id_Idioma			Int							Primary key		identity,
	Nome				Varchar(40)		not null,
	Descricao			Varchar(255)	not null
)
go

Create unique index Unico_Idioma
   on SysProtected.Idiomas (Nome, Descricao); 
go

Create table SysProtected.Planos (
	Id_Plano			Int							Primary key		identity,
	Id_Idioma			Int				not null	Foreign key	references SysProtected.Idiomas (Id_Idioma),
	Nome				Varchar(40)		not null,
	Aulas_Previstas		Tinyint			not null,
	Valor				Money			not null	Check (Valor >= 0)
)
go

Create unique index Unico_Plano
   on SysProtected.Planos (Id_Idioma, Nome); 
go

Create table SysProtected.Financeiro (
	Id_Financeiro		Int							Primary key		identity,
	Id_Funcionario		Int				null		Unique Foreign key references SysProtected.Funcionarios (Id_Funcionario),
	Banco				Varchar(20)		not null,
	Agencia				Int				not null,
	Conta				Int				not null,
	Data				Date			null
)
go

Create unique index Unico_Financeiro
   ON SysProtected.Financeiro (Banco, Agencia, Conta); 
go

Create table SysProtected.Negociacao (
	Id_Negociacao		Int							Primary key		identity,
	Id_Financeiro		Int				not null	Foreign key	references SysProtected.Financeiro (Id_Financeiro),
	Id_Aluno			Int				not null	Foreign key	references SysProtected.Alunos (Id_Aluno),
	Id_Plano			Int				not null	Foreign key	references SysProtected.Planos (Id_Plano),
	Parcelas			Tinyint			not null	Check (Parcelas <= 12 and Parcelas > 0),
	Situacao			bit				not null
)
go

Create unique index Unica_Negociacao
   on SysProtected.Negociacao (Id_Aluno, Id_Plano); 
go

Create trigger TGR_NegociacaoAluno
on SysProtected.Negociacao
after insert
as
begin
	declare @Id_Financeiro int;
	declare @Id_Negociacao int;
	declare @Parcelas int;
	declare @Data date;
	declare @I int;
	
	select @Id_Financeiro = Id_Financeiro from inserted;
	select @Id_Negociacao = Id_Negociacao from inserted;
	select @Parcelas = Parcelas from inserted;
	select @Data = GETDATE();
	select @I = 1;
	
	Insert into SysProtected.Mensalidades values (@Id_Financeiro, @Id_Negociacao, @I, 1, @Data);
	
	select @I = @I + 1;

	while (@Parcelas >= @I)
	begin
		select @Data = DATEADD(MONTH, 1, @Data);
		Insert into SysProtected.Mensalidades values (@Id_Financeiro, @Id_Negociacao, @I, 0, @Data);
		select @I = @I + 1;
	end
end
go

Create table SysProtected.Mensalidades (
	Id_Mensalidade		Int							Primary key		identity,
	Id_Financeiro		Int				null		Foreign key references SysProtected.Financeiro (Id_Financeiro),
	Id_Negociacao		Int				null		Foreign key	references SysProtected.Negociacao (Id_Negociacao),
	Numero_Parcela		Tinyint			not null	Check (Numero_Parcela > 0),
	Situacao			bit				not null,
	Data				Date			not null
)
go

Create unique index Unica_Negociacao_Mensalidades
   on SysProtected.Mensalidades (Id_Financeiro, Id_Negociacao, Numero_Parcela, Data);
go

CREATE VIEW AllMensalidades AS
	Select M.Id_Mensalidade as 'C�digo da mensalidade', A.Id_Aluno 'C�digo do aluno', M.Numero_Parcela
	as 'N�mero da parcela', M.Situacao as 'Situa��o', M.Data as 'Data de vencimento', N.Parcelas as
	'N�mero total de parcelas', case when M.Situacao = 1 then 'Pago' else 'A receber' end 'Situa��o total',
	A.Nome from SysProtected.Mensalidades M INNER JOIN SysProtected.Negociacao N	on M.Id_Negociacao = 
	N.Id_Negociacao INNER JOIN SysProtected.Alunos A on N.Id_Aluno = A.Id_Aluno
GO

Create trigger TGR_MensalidadeFinalPaga
on SysProtected.Mensalidades
after update
as
begin
	Declare @Situacao bit;
	Declare @Id_Negociacao int;
	Declare @I tinyint;
	Declare @X tinyint;
	Declare @true bit;
	
	Select @X = 1

	Select @Id_Negociacao = Id_Negociacao from inserted;

	Select @I = N.Parcelas from inserted M INNER JOIN SysProtected.Negociacao N
	on M.Id_Negociacao = N.Id_Negociacao
	where M.Id_Negociacao = @Id_Negociacao;

	while (@X < @I)
	begin
		Select @Situacao = M.Situacao from SysProtected.Mensalidades M where M.Id_Negociacao = @Id_Negociacao and M.Numero_Parcela = @X;
		if (@Situacao = 0)
		begin
			Select @true = 0;
			break;
		end
		Select @true = 1;
		Select @X = @X + 1;
	end
	
	if (@true = 0)
	begin
		Update SysProtected.Negociacao set Situacao = 0 where Id_Negociacao = @Id_Negociacao;
	end
	if (@true = 1)
	begin
		Update SysProtected.Negociacao set Situacao = 1 where Id_Negociacao = @Id_Negociacao;
	end
end
go

Create table SysProtected.Inscricao (
	Id_Inscricao		Int							Primary key		identity,
	Id_Aluno			Int				not null	Foreign key	references SysProtected.Alunos (Id_Aluno),	
	Id_Negociacao		Int				not null	Foreign key references SysProtected.Negociacao (Id_Negociacao),	
	Data				Date			not null,
	Status				bit				not null			
)
go


Create unique index Unica_Inscricao
   on SysProtected.Inscricao (Id_Aluno, Id_Negociacao);
go

CREATE VIEW AllInscricoes AS
	Select I.Id_Inscricao as 'C�digo da inscri��o', 
	A.Id_Aluno as 'C�digo do aluno',
	A.Nome as 'Nome do aluno', 
	I.Id_Negociacao as 'C�digo da negocia��o', 
	I.Data as 'Data de Inscricao', 
	case when I.Status = 1 then 'Ativo' 
	else 'In�tivo' end 'Status da inscri��o'
	from SysProtected.Inscricao I INNER JOIN SysProtected.Alunos A
	on I.Id_Aluno = A.Id_Aluno
go

Create trigger TGR_NegociacaoInscricaoAluno
on SysProtected.Negociacao
after insert
as
begin
	Declare @Id_Aluno int;
	Declare @Id_Negociacao int;

	Select @Id_Aluno = Id_Aluno from inserted;
	Select @Id_Negociacao = Id_Negociacao from inserted;

	Insert into SysProtected.Inscricao values (@Id_Aluno, @Id_Negociacao, GETDATE(), 0);
end
go

Create table SysProtected.Boletim (
	Id_Boletim			Int							Primary key		identity,
	Id_Inscricao		Int				not null	Foreign key references SysProtected.Inscricao (Id_Inscricao),
	Nota1				Float			null		Check (Nota1 > 0 and Nota1 < 11),
	Nota2				Float			null		Check (Nota2 > 0 and Nota2 < 11),
	Media											As ((Nota1 + Nota2) / 2),
	Numero_Faltas		Tinyint			null		Check (Numero_Faltas >= 0)
)
go

Create trigger TGR_InscricaoBoletimAluno
on SysProtected.Inscricao
after insert
as
begin
	Declare @Id_Inscricao int;

	Select @Id_Inscricao = Id_Inscricao from inserted;

	Insert into SysProtected.Boletim (Id_Inscricao, Nota1, Nota2, Numero_Faltas) values (@Id_Inscricao, null, null, null);
end
go

CREATE VIEW AllBoletim AS
	Select I.Id_Inscricao			as 'C�digo da inscri��o',
		A.Id_Aluno					as 'C�digo do aluno',
		A.Nome						as 'Nome do aluno',
		case when I.Status = 1 then 'Ativo' 
		else 'In�tivo' end 'Status do aluno',
		P.Nome						as 'Curso',
		B.Nota1						as 'Prova 1',
		B.Nota2						as 'Prova 2',
		B.Media						as 'Media', 
		B.Numero_Faltas				as 'Faltas no semestre'
	from SysProtected.Alunos A
	INNER JOIN SysProtected.Inscricao I
		on A.Id_Aluno = I.Id_Aluno
	INNER JOIN SysProtected.Boletim B
		on I.Id_Inscricao = B.Id_Inscricao
	INNER JOIN SysProtected.Negociacao N
		on I.Id_Negociacao = N.Id_Negociacao
	INNER JOIN SysProtected.Planos P
		on N.Id_Plano = P.Id_Plano
go

Create table SysProtected.Escalas (
	Id_Escala			Int							Primary key		identity,
	Id_Funcionario		Int				not null	Foreign key references SysProtected.Funcionarios (Id_Funcionario),
	Data				Date			not null,
	Hora_Entrada		Time			not null,
	Hora_Saida			Time			not null,
	Descricao_Funcao	Varchar(255)	not null,
)
go

Create unique index Unica_Escala
	on SysProtected.Escalas (Id_Funcionario, Data, Hora_Entrada, Hora_Saida);
go

CREATE VIEW EscalaFuncionario AS
	Select E.Id_Escala,
		F.Nome,
		F.Cargo,
		E.Hora_Entrada,
		E.Hora_Saida,
		E.Data
	from SysProtected.Escalas E
	INNER JOIN SysProtected.Funcionarios F
	on E.Id_Funcionario = F.Id_Funcionario
Go

Create table SysProtected.Turmas (
	Id_Turma			Int							Primary key		identity,
	Id_Plano			Int				not null	Foreign key references SysProtected.Planos (Id_Plano),
	Id_Escala			Int				not null	Foreign key references SysProtected.Escalas (Id_Escala),
	Sala				Tinyint			not null,
	Data				Date			not null,
	Hora_Entrada		Time			not null,
	Hora_Saida			Time			not null
)
go

Create unique index Unica_Turma
	on SysProtected.Turmas (Id_Plano, Id_Escala, Sala);
go

Create table SysProtected.Inscricoes_Turmas (
	Id_Inscricao_Turma	int							Primary key		identity,
	Id_Inscricao		int				not null	Foreign key references SysProtected.Inscricao (Id_Inscricao),
	Id_Turma			int				not null	Foreign key references SysProtected.Turmas (Id_Turma)
)
go

Create unique index Unica_Inscricao_Turma
	on SysProtected.Inscricoes_Turmas (Id_Inscricao, Id_Turma);
go

Create trigger TGR_InscricoesTurmas
on SysProtected.Inscricoes_Turmas
after insert
as
begin
	Declare @Id_Inscricao int;

	Select @Id_Inscricao = Id_Inscricao from inserted;

	Update SysProtected.Inscricao set Status = 1 where Id_Inscricao = @Id_Inscricao;
end
go	 

CREATE VIEW InscricoesTurmas AS
	Select	I.Id_Inscricao	as	'C�digo da inscri��o',
			A.Foto			as	'Foto',
			A.Nome			as	'Nome do aluno',
			Id.Nome			as	'Curso',
			P.Nome			as	'Plano contratado',
			I.Status		as	'Vincular aluno',
			IT.Id_Turma		as	'Turma'
	from SysProtected.Inscricoes_Turmas IT RIGHT JOIN SysProtected.Inscricao I
	on IT.Id_Inscricao = I.Id_Inscricao INNER JOIN SysProtected.Negociacao N
	on I.Id_Negociacao = N.Id_Negociacao INNER JOIN SysProtected.Planos P
	on N.Id_Plano = P.Id_Plano INNER JOIN SysProtected.Idiomas Id
	on P.Id_Idioma = Id.Id_Idioma INNER JOIN SysProtected.Alunos A
	on N.Id_Aluno = A.Id_Aluno
	go
Go

CREATE VIEW TurmaAluno AS
	Select	T.Id_Turma,
			P.Nome			as	'Curso',
			F.Nome			as	'Professor',
			T.Sala			as	'Sala',
			T.Hora_Entrada	as	'Hora entrada',
			T.Hora_Saida	as	'Hora sa�da'
	from SysProtected.Planos P INNER JOIN SysProtected.Turmas T
	on P.Id_Plano = T.Id_Plano INNER JOIN SysProtected.Escalas E
	on T.Id_Escala = E.Id_Escala INNER JOIN SysProtected.Funcionarios F
	on E.Id_Funcionario = F.Id_Funcionario
	where F.Cargo = 'Professor(a)' or F.Cargo = 'Cordenador(a)'
GO

Create table SysProtected.Lista_Presenca (
	Id_Presenca			int							Primary key		identity,
	Id_Inscricao_Turma	int				not null	Foreign key references SysProtected.Inscricoes_Turmas,
	Chamada				bit				null,
	Data				date			null
)
go

Create unique index Unica_Lista_Presenca
	on SysProtected.Lista_Presenca (Id_Inscricao_Turma, Data);
go

CREATE USER [ANA\Diretor] FOR LOGIN [ANA\Diretor]
GO

ALTER ROLE [db_owner] ADD MEMBER [ANA\Diretor]
GO

CREATE USER [ANA\Professor] FOR LOGIN [ANA\Professor]
GO

CREATE USER [ANA\Secretario] FOR LOGIN [ANA\Secretario]
GO

GRANT INSERT ON [SysProtected].[Alunos] TO [ANA\Secretario]
GO

GRANT SELECT ON [SysProtected].[Alunos] TO [ANA\Secretario]
GO

GRANT UPDATE ON [SysProtected].[Alunos] TO [ANA\Secretario]
GO

GRANT SELECT ON [SysProtected].[Boletim] TO [ANA\Professor]
GO

GRANT UPDATE ON [SysProtected].[Boletim] TO [ANA\Professor]
GO

GRANT SELECT ON [SysProtected].[Boletim] TO [ANA\Secretario]
GO

GRANT INSERT ON [SysProtected].[Endereco] TO [ANA\Secretario]
GO

GRANT SELECT ON [SysProtected].[Endereco] TO [ANA\Secretario]
GO

GRANT UPDATE ON [SysProtected].[Endereco] TO [ANA\Secretario]
GO

GRANT SELECT ON [SysProtected].[Escalas] TO [ANA\Secretario]
GO

GRANT SELECT ON [SysProtected].[Financeiro] ([Id_Financeiro]) TO [ANA\Secretario]
GO

GRANT INSERT ON [SysProtected].[Historico_Aluno] TO [ANA\Professor]
GO

GRANT SELECT ON [SysProtected].[Historico_Aluno] TO [ANA\Professor]
GO

GRANT UPDATE ON [SysProtected].[Historico_Aluno] TO [ANA\Professor]
GO

GRANT INSERT ON [SysProtected].[Historico_Aluno] TO [ANA\Secretario]
GO

GRANT SELECT ON [SysProtected].[Historico_Aluno] TO [ANA\Secretario]
GO

GRANT SELECT ON [SysProtected].[Historico_Funcionario] TO [ANA\Secretario]
GO

GRANT INSERT ON [SysProtected].[Inscricao] TO [ANA\Secretario]
GO

GRANT SELECT ON [SysProtected].[Inscricao] TO [ANA\Secretario]
GO

GRANT UPDATE ON [SysProtected].[Inscricao] TO [ANA\Secretario]
GO

GRANT INSERT ON [SysProtected].[Inscricoes_Turmas] TO [ANA\Secretario]
GO

GRANT SELECT ON [SysProtected].[Inscricoes_Turmas] TO [ANA\Secretario]
GO

GRANT UPDATE ON [SysProtected].[Inscricoes_Turmas] TO [ANA\Secretario]
GO

GRANT INSERT ON [SysProtected].[Lista_Presenca] TO [ANA\Professor]
GO

GRANT SELECT ON [SysProtected].[Lista_Presenca] TO [ANA\Professor]
GO

GRANT UPDATE ON [SysProtected].[Lista_Presenca] TO [ANA\Professor]
GO

GRANT SELECT ON [SysProtected].[Lista_Presenca] TO [ANA\Secretario]
GO

GRANT INSERT ON [SysProtected].[Mensalidades] TO [ANA\Secretario]
GO

GRANT SELECT ON [SysProtected].[Mensalidades] TO [ANA\Secretario]
GO

GRANT UPDATE ON [SysProtected].[Mensalidades] TO [ANA\Secretario]
GO

GRANT INSERT ON [SysProtected].[Negociacao] TO [ANA\Secretario]
GO

GRANT SELECT ON [SysProtected].[Negociacao] TO [ANA\Secretario]
GO

GRANT UPDATE ON [SysProtected].[Negociacao] TO [ANA\Secretario]
GO

GRANT SELECT ON [SysProtected].[Responsavel_Aluno] TO [ANA\Professor]
GO

GRANT INSERT ON [SysProtected].[Responsavel_Aluno] TO [ANA\Secretario]
GO

GRANT SELECT ON [SysProtected].[Responsavel_Aluno] TO [ANA\Secretario]
GO

GRANT UPDATE ON [SysProtected].[Responsavel_Aluno] TO [ANA\Secretario]
GO

GRANT SELECT ON [SysProtected].[Turmas] TO [ANA\Professor]
GO

GRANT INSERT ON [SysProtected].[Turmas] TO [ANA\Secretario]
GO

GRANT SELECT ON [SysProtected].[Turmas] TO [ANA\Secretario]
GO

GRANT UPDATE ON [SysProtected].[Turmas] TO [ANA\Secretario]
GO

GRANT INSERT ON SCHEMA::[SysProtected] TO [ANA\Professor]
GO

GRANT SELECT ON SCHEMA::[SysProtected] TO [ANA\Professor]
GO

GRANT UPDATE ON SCHEMA::[SysProtected] TO [ANA\Professor]
GO

GRANT INSERT ON SCHEMA::[SysProtected] TO [ANA\Secretario]
GO

GRANT SELECT ON SCHEMA::[SysProtected] TO [ANA\Secretario]
GO

GRANT UPDATE ON SCHEMA::[SysProtected] TO [ANA\Secretario]
GO

GRANT SELECT ON [dbo].[AllBoletim] TO [ANA\Professor]
GO

GRANT UPDATE ON [dbo].[AllBoletim] TO [ANA\Professor]
GO

GRANT SELECT ON [dbo].[AllBoletim] TO [ANA\Secretario]
GO

GRANT SELECT ON [dbo].[AllInscricoes] TO [ANA\Professor]
GO

GRANT SELECT ON [dbo].[AllInscricoes] TO [ANA\Secretario]
GO

GRANT UPDATE ON [dbo].[AllInscricoes] TO [ANA\Secretario]
GO

GRANT SELECT ON [dbo].[AllMensalidades] TO [ANA\Secretario]
GO

GRANT UPDATE ON [dbo].[AllMensalidades] TO [ANA\Secretario]
GO

GRANT EXECUTE ON [dbo].[CadastroAluno] TO [ANA\Secretario]
GO

GRANT EXECUTE ON [dbo].[CadastroResponsavel] TO [ANA\Secretario]
GO