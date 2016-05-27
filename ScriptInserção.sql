Use DB_Escola
go

Insert into SysProtected.Endereco values 
	('São Paulo', 'Campos do Jordão', '12460-000', 'Vila Nair', 'João Andreolli'),
	('Sao Paulo', 'Campos do Jordao', '12460-000', 'Vila Eliza', 'Rua Friburgo'),
	('São Paulo', 'Campos do Jordão', '12460-000', 'Brancas Nuvens', 'Rua Genko Sakane'),
	('São Paulo', 'Campos do Jordão', '12460-000', 'Vila 1', 'Rua 1'),
	('São Paulo', 'Campos do Jordão', '12460-000', 'Vila 1', 'Rua 2'),
	('São Paulo', 'Campos do Jordão', '12460-000', 'Vila 2', 'Rua 3'),
	('São Paulo', 'Campos do Jordão', '12460-000', 'Vila 2', 'Rua 4'),
	('São Paulo', 'Campos do Jordão', '12460-000', 'Vila 3', 'Rua 5'),
	('São Paulo', 'Campos do Jordão', '12460-000', 'Vila 3', 'Rua 6'),
	('São Paulo', 'Campos do Jordão', '12460-000', 'Vila 4', 'Rua 1'),
	('São Paulo', 'Campos do Jordão', '12460-000', 'Vila 4', 'Rua 2'),
	('São Paulo', 'Campos do Jordão', '12460-000', 'Vila 5', 'Rua 3'),
	('São Paulo', 'Campos do Jordão', '12460-000', 'Vila 6', 'Rua 4'),
	('São Paulo', 'Campos do Jordão', '12460-000', 'Bairro 7', 'Rua 5')
go

Select * from SysProtected.Endereco
go

delete from SysProtected.Endereco where Id_Endereco = 16

Declare @img1 as varbinary(max)

Set @img1 = (Select * from openrowset(bulk N'D:\Eu.jpg', single_blob) as imagem)

Insert into SysProtected.Funcionarios values
	(1,
	'David Christian Dias Ordone',
	'1994-01-01',
	'M', 
	'Solteiro', 
	'13.120.287-3',
	'094.632.189-20', 
	'Ativo', 
	'david9108@hotmail.com', 
	null, 
	'012', 
	'997040012', 
	'0',
	'Ensino Médio Completo', 
	'Administrador', 
	30000, 
	'Casa', 
	'416'),

	(3, 'Secretario1', '1990-08-20', 'M', 'Solteiro', '12.123.213-2',
	'031.234.123-12', 'Ativo', 'secretario1@speakschool.com', null, '012', '9971234567', '1',
	'Ensino Médio Completo', 'Secretario', 1600, 'Casa', '123'),
	(4, 'Secretario2', '1991-08-20', 'F', 'Solteiro', '34.125.233-3',
	'111.222.333-44', 'Ativo', 'secretario2@speakschool.com', null, '012', '9972345678', '2',
	'Ensino Médio Completo', 'Secretario', 1600, 'Apartamento', '210'),
	(5, 'Professor1', '1992-08-20', 'M', 'Solteiro', '33.312.222-2',
	'777.665.444-33', 'Ativo', 'professor1@speakschool.com', null, '012', '9973456789', '1',
	'Ensino Superior Completo', 'Professor Ingles', 2000, 'Casa', '1'),
	(6, 'Professor2', '1993-08-20', 'F', 'Solteiro', '12.345.123-1',
	'534.533.122-27', 'Ativo', 'professor2@speakschool.com', null, '012', '9886131929', '3',
	'Ensino Superior Completo', 'Professor Ingles', 2000, 'Casa', '2'),
	(7, 'Faixineiro1', '1990-02-20', 'M', 'Solteiro', '15.234.532-4',
	'038.741.234-12', 'Ativo', null, null, '012', '9975432345', '1',
	'Ensino Médio Incompleto', 'Faixineiro', 1200, 'Casa', '171'),
	(8, 'Faixineiro2', '1987-07-23', 'F', 'Solteiro', '22.111.333-2',
	'123.444.231-23', 'Desativo', null, null, '012', '9987643213', '1',
	'Ensino Fundamental Completo', 'Faixineiro', 1200, 'Casa', '222')
go


Select F.Nome				as 'Nome do funcionário',
	F.Complemento,
	F.Numero,
	E.Estado,
	E.Cidade,
	E.CEP,
	E.Bairro,
	E.Nome_Rua					as 'Nome da rua'
from SysProtected.Funcionarios F 
INNER JOIN SysProtected.Endereco E
	on F.Id_Endereco = E.Id_Endereco
go

/*Insert into SysProtected.Historico_Funcionario values
	(1, Getdate( ), 'Foi admitido na empresa no dia de hoje'),
	(2, Getdate( ), 'Foi admitido na empresa no dia de hoje'),
	(3, Getdate( ), 'Foi admitido na empresa no dia de hoje'),
	(4, Getdate( ), 'Foi admitido na empresa no dia de hoje'),
	(5, Getdate( ), 'Foi admitido na empresa no dia de hoje'),
	(6, Getdate( ), 'Foi admitido na empresa no dia de hoje'),
	(7, Getdate( ), 'Foi admitido na empresa no dia de hoje')
go*/

select * from SysProtected.Historico_Funcionario

Select HF.Data		as 'Data do histórico',
	HF.Descricao	as 'Descrição do histórico',
	F.Nome					as 'Nome Funcionário' 
from SysProtected.Historico_Funcionario HF
INNER JOIN SysProtected.Funcionarios F
	on HF.Id_Funcionario = F.Id_Funcionario
go

Insert into SysProtected.Responsavel_Aluno values 
	(2, 'Ana Claudia Dias', '1975-06-26', 'F', 'Solteiro', '12.345.532-3', '014.416.349-75',
	'anacdias1234@hotmail.com', '012', '996420012', 'Casa', '116'),
	(9, 'Responsavel1', '1980-07-25', 'M', 'Solteiro', '23.123.333-5', '017.555.333-79',
	null, '012', '998311123', 'Casa', '111'),
	(10, 'Responsavel2', '1971-01-26', 'F', 'Solteiro', '45.556.664-2', '012.111.222-77',
	'responsavel2@hotmail.com', '012', '998221324', 'Casa', '7')
go

select * from SysProtected.Responsavel_Aluno

Select R.Nome			as 'Nome do responsável',
	R.Complemento,
	R.Numero,
	E.Estado,
	E.Cidade,
	E.CEP,
	E.Nome_Rua					as 'Nome da rua',
	E.Bairro
from SysProtected.Responsavel_Aluno R
INNER JOIN SysProtected.Endereco E
	on R.Id_Endereco = E.Id_Endereco
go

Declare	@img1 as varbinary(max)

Set @img1 = (Select * from openrowset(bulk N'D:\Ela.jpg', single_blob) as imagem)

Insert into SysProtected.Alunos values
	(1, 2, 'Gleizy Ketlen de Oliveira', '2002-01-06', 'F', 'Solteiro', '22.333.444-5',
	'999.333.222-32', 1, 'gecyko@gmail.com', @img1, '012', '996426838',
	'Ensino fundamental incompleto', 'Casa', '116'),
	(2,	9, 'Aluno1', '2001-01-06', 'F', 'Solteiro',
	'22.444.576-8', '777.123.456-87', 1, 'aluno1@gmail.com', null, '012', '997543322',
	'Ensino fundamental completo', 'Casa', '123'),
	(3,	10, 'Aluno2', '2000-02-05', 'F', 'Solteiro',
	'41.123.777-9', '654.555.777-89', 1, 'aluno2@gmail.com', null, '012', '996432211',
	'Ensino fundamental completo', 'Casa', '5'),
	(null,	11, 'Aluno3', '1997-01-06', 'M', 'Solteiro',
	'12.456.665-7', '112.333.478-99', 1, 'aluno3@gmail.com', null, '012', '995443322',
	'Ensino medio incompleto', 'Apartamento', '7'),
	(null,	12, 'Aluno4', '1996-01-06', 'M', 'Solteiro',
	'56.777.555-8', '888.222.222-43', 1, null, null, '012', '997889988',
	'Ensino medio completo', 'Apartamento', '116'),
	(null,	13, 'Aluno5', '1992-04-27', 'M', 'Solteiro',
	'33.111.111-1', '777.777.999-88', 1, 'aluno5@gmail.com', null, '012', '998332211',
	'Ensino medio completo', 'Apartamento', '3'),
	(null,	14, 'Aluno6', '1993-06-07', 'M', 'Solteiro',
	'22.333.314-5', '122.333.444-54', 0, null, null, '012', '998123444',
	'Ensino medio completo', 'Casa', '16')
go

Select * from SysProtected.Alunos
go

Select R.Nome			as 'Nome do responsável do aluno',
	R.DataNascimento	as 'Data de nascimento',
	R.Sexo				as 'Sexo do responsável',
	R.Estado_Civil		as 'Estado Civil',
	R.RG				as 'RG do responsável',
	R.CPF				as 'CPF do responsável',
	R.Email				as 'Email do responsável',
	R.DDD				as 'DDD do responsável',
	R.Telefone			as 'Telefone do responsável',
	R.Complemento		as 'Complemento do responsável',
	R.Numero			as 'Número da residência',
	A.Nome				as 'Nome do aluno',
	A.DataNascimento	as 'Data de nascimento',
	A.Sexo				as 'Sexo do aluno',
	A.Estado_Civil		as 'Estado Civil',
	A.RG				as 'RG do aluno',
	A.CPF				as 'CPF do aluno',
	case when A.Status_Aluno = 1 then 'Ativo' 
	else 'Inátivo' end 'Status do aluno',
	A.Email				as 'Email do aluno',
	A.DDD				as 'DDD do aluno',
	A.Telefone			as 'Telefone do aluno',
	A.Historico_Escolar	as 'Histórico escolar do aluno',
	A.Complemento		as 'Complemento do aluno',
	A.Numero			as 'Número da residência',
	E.Estado,
	E.Cidade,
	E.CEP,
	E.Bairro,
	E.Nome_Rua			as 'Nome da rua'
from SysProtected.Endereco E
INNER JOIN SysProtected.Responsavel_Aluno R
	on E.Id_Endereco = R.Id_Endereco 
INNER JOIN SysProtected.Alunos A
	on R.Id_Responsavel = A.Id_Responsavel
go

/*Insert into SysProtected.Historico_Aluno values
	(1, Getdate( ), 'Matriculou-se na escola no dia de hoje'),
	(2, Getdate( ), 'Matriculou-se na escola no dia de hoje'),
	(3, Getdate( ), 'Matriculou-se na escola no dia de hoje'),
	(4, Getdate( ), 'Matriculou-se na escola no dia de hoje'),
	(5, Getdate( ), 'Matriculou-se na escola no dia de hoje'),
	(6, Getdate( ), 'Matriculou-se na escola no dia de hoje'),
	(7, Getdate( ), 'Matriculou-se na escola no dia de hoje'),
	(7, Getdate( ), 'Foi desmatriculado da escola no dia de hoje')
go*/

Select H.Data			as 'Data do histórico',
	H.Descricao			as 'Descrição do histórico',
	A.Nome				as 'Nome do aluno'
from SysProtected.Historico_Aluno  H
INNER JOIN SysProtected.Alunos A
	on H.Id_Aluno = A.Id_Aluno
go

Insert into SysProtected.Idiomas values ('Ingles', 'Curso de ingles com foco em informática')
go

Select * from SysProtected.Idiomas
go

Select * from SysProtected.Planos

Insert into SysProtected.Planos values (1, 'Basico', 50, 15000)
go

Select I.Nome					as 'Curso',
	I.Descricao					as 'Descrição do idioma',
	P.Nome						as 'Nivel',
	P.Aulas_Previstas				as 'Aulas previstas',
	P.Valor						as 'Valor do curso'
from SysProtected.Idiomas I
INNER JOIN SysProtected.Planos P
	on I.Id_Idioma = P.Id_Idioma
go

Insert into SysProtected.Financeiro values (null, 'Banco do Brasil', 6676-1, 7600-7, '2016-01-01')
go

Select * from SysProtected.Financeiro
go

SELECT Banco, Agencia, Conta FROM SysProtected.Financeiro WHERE Id_Funcionario is null and Data is null

Insert into SysProtected.Financeiro values 
	(1, 'Banco HSBC', 1243-0, 0563-40, '2016-04-30'),
	(2, 'Banco1', 1234-5, 1234-56, '2016-04-30'),
	(3, 'Banco2', 2345-6, 2345-67, '2016-04-30'),
	(4, 'Banco3', 3456-7, 3456-78, '2016-04-30'),
	(5, 'Banco4', 4567-8, 4567-89, '2016-04-30'),
	(6, 'Banco5', 5678-9, 5678-90, '2016-04-30'),
	(7, 'Banco6', 6789-0, 6789-01, '2016-04-30')
go

Select * from SysProtected.Financeiro

Select 	Fu.Nome					as 'Nome do Funcionário',
	Fi.Id_Financeiro		as 'Código do financeiro',
	Fi.Banco					as 'Banco para depósito',
	Fi.Agencia,
	Fi.Conta,
	Fi.Data					as 'Data para depósito'
from SysProtected.Financeiro Fi
INNER JOIN SysProtected.Funcionarios Fu
	on Fi.Id_Funcionario = Fu.Id_Funcionario
go

Insert into SysProtected.Negociacao values 
	(1, 1, 1, 5, 1),
	(1, 2, 1, 1, 1),
	(1, 3, 1, 1, 1),
	(1, 4, 1, 3, 0),
	(1, 5, 1, 3, 0),
	(1, 6, 1, 2, 0)
go

Select N.Id_Financeiro		as 'Código do financeiro',
	I.Nome						as 'Curso',
	P.Valor,
	N.Parcelas,
	case when N.Situacao = 1 then 'Pago' 
	else 'A receber' end 'Situação',
	A.Nome
from SysProtected.Idiomas I
INNER JOIN SysProtected.Planos P
	on I.Id_Idioma = P.Id_Idioma
INNER JOIN SysProtected.Negociacao N
	on P.Id_Plano = N.Id_Plano
INNER JOIN SysProtected.Alunos A
	on N.Id_Aluno = A.Id_Aluno
go

delete from SysProtected.Funcionarios where Id_Funcionario = 10
select * from SysProtected.Financeiro
Select * from SysProtected.Funcionarios
Select * from SysProtected.Mensalidades
Select * from SysProtected.Negociacao

Insert into SysProtected.Mensalidades values
	(1, 1, 1, 1, GETDATE( )),
	(1, 1, 2, 1, '2016-05-30'),
	(1, 1, 3, 1, '2016-06-30'),
	(1, 1, 4, 1, '2016-07-30'),
	(1, 1, 5, 1, '2016-08-30'),
	(1, 2, 1, 1, '2016-04-30'),
	(1, 3, 1, 1, '2016-04-30'),
	(1, 4, 1, 1, '2016-04-30'),
	(1, 4, 2, 0, '2016-05-30'),
	(1, 4, 3, 0, '2016-06-30'),
	(1, 5, 1, 1, '2016-04-30'),
	(1, 5, 2, 0, '2016-05-30'),
	(1, 5, 3, 0, '2016-06-30'),
	(1, 6, 1, 1, '2016-04-30'),
	(1, 6, 2, 0, '2016-05-30')
go

Select * from SysProtected.Mensalidades
Select * from SysProtected.Negociacao

Select M.Id_Mensalidade		as 'Código da mensalidade',
	M.Numero_Parcela		as 'Número da parcela',
	M.Situacao				as 'Situação',
	M.Data					as 'Data de vencimento',
	N.Parcelas				as 'Número total de parcelas',
	case when M.Situacao = 1 then 'Pago' 
	else 'A receber' end 'Situação total',
	A.Nome
from SysProtected.Mensalidades M
INNER JOIN SysProtected.Negociacao N
	on M.Id_Negociacao = N.Id_Negociacao
INNER JOIN SysProtected.Alunos A
	on N.Id_Aluno = A.Id_Aluno
go

SELECT Id_Negociacao, MAX(Numero_Parcela) as 'Parcela final', Situacao from SysProtected.Mensalidades
GROUP BY Id_Negociacao, Situacao


Update SysProtected.Negociacao set Situacao = 1 where Id_Negociacao = 1
Update SysProtected.Negociacao set Situacao = 1 where Id_Negociacao = 2
Update SysProtected.Negociacao set Situacao = 1 where Id_Negociacao = 3
go

Select * from SysProtected.Negociacao
go

Insert into SysProtected.Mensalidades values
	(2, null, 1, 1, Getdate( )),
	(3, null, 1, 1, Getdate( )),
	(4, null, 1, 1, Getdate( )),
	(5, null, 1, 1, Getdate( )),
	(6, null, 1, 1, Getdate( )),
	(7, null, 1, 0, Getdate( )),
	(8, null, 1, 0, Getdate( ))
go

Select M.Id_Financeiro		as 'Código do financeiro',
	M.Numero_Parcela		as 'Número do pagamento',
	case when M.Situacao = 1 then 'Pago' 
	else 'A receber' end 'Situação',
	M.Data					as 'Data para depósito',
	Fi.Banco,
	Fi.Agencia,
	Fi.Conta,
	Fu.Nome					as 'Nome do funcionário'
from SysProtected.Mensalidades  M
INNER JOIN SysProtected.Financeiro Fi
	on M.Id_Financeiro = Fi.Id_Financeiro
INNER JOIN SysProtected.Funcionarios Fu
	on Fi.Id_Funcionario = Fu.Id_Funcionario
go

Insert into SysProtected.Inscricao values
	(1, 1, Getdate(), 1),
	(2, 2, Getdate(), 1),
	(3, 3, Getdate(), 1),
	(4, 4, Getdate(), 1),
	(5, 5, Getdate(), 1),
	(6, 6, Getdate(), 1)
go

Select I.Id_Inscricao as 'Código da inscrição', 
A.Nome as 'Nome do aluno', 
I.Id_Negociacao as 'Código da negociação', 
I.Data as 'Data de Inscricao', 
case when I.Status = 1 then 'Ativo' 
else 'Inátivo' end 'Status da inscrição'
from SysProtected.Inscricao I INNER JOIN SysProtected.Alunos A
on I.Id_Aluno = A.Id_Aluno
go

Select I.Id_Inscricao			as 'Identificação da mastricula',
	A.Nome						as 'Nome do Aluno',
	case when A.Status_Aluno = 1 then 'Ativo' 
	else 'Inátivo' end 'Status do aluno',
	B.Nota1						as 'Prova 1',
	B.Nota2						as 'Prova 2',
	B.Media,
	B.Numero_Faltas				as 'Número de faltas'
from SysProtected.Inscricao I
INNER JOIN SysProtected.Alunos A
	on I.Id_Aluno = A.Id_Aluno
INNER JOIN SysProtected.Boletim B
	on I.Id_Inscricao = B.Id_Inscricao
go

Insert into SysProtected.Boletim values
	(1, null, null, null),
	(2, null, null, null),
	(3, null, null, null),
	(4, null, null, null),
	(5, null, null, null),
	(6, null, null, null)
go

Select * from SysProtected.Boletim
go

Update SysProtected.Boletim set Nota1 = 7 where Id_Boletim = 1
Update SysProtected.Boletim set Nota2 = 8 where Id_Boletim = 1
go

Select A.Nome						as 'Nome do aluno',
	case when A.Status_Aluno = 1 then 'Ativo' 
	else 'Inátivo' end 'Status do aluno',
	B.Nota1						as 'Prova 1',
	B.Nota2						as 'Prova 2',
	B.Media						as 'Media', 
	B.Numero_Faltas				as 'Faltas no semestre'
from SysProtected.Alunos A
INNER JOIN SysProtected.Inscricao I
	on A.Id_Aluno = I.Id_Aluno
INNER JOIN SysProtected.Boletim B
	on I.Id_Inscricao = B.Id_Inscricao	
go

select * from SysProtected.Boletim


Insert into SysProtected.Escalas values
	(1, Getdate(), '13:00', '17:00', 'Administrar a empresa'),
	(2, Getdate(), '07:00', '12:00', 'Administrar secretaria'),
	(3, Getdate(), '12:00', '17:00', 'Administrar secretaria'),
	(4, Getdate(), '07:00', '12:00', 'Ministrar aulas'),
	(5, Getdate(), '12:00', '17:00', 'Ministrar aulas'),
	(6, Getdate(), '07:00', '12:00', 'Cuidar da limpeza'),
	(7, Getdate(), '12:00', '17:00', 'Cuidar da limpeza')
go

Select E.Id_Escala				as 'Número de identificação da escala',
	E.Data,
	E.Hora_Entrada				as 'Hora de entrada',
	E.Hora_Saida					as 'Horario de saida',
	F.Nome					as 'Nome do funcionário'
from SysProtected.Escalas E
INNER JOIN SysProtected.Funcionarios F
	on E.Id_Funcionario = F.Id_Funcionario
go

Insert into SysProtected.Turmas values
	(1, 4, 7, Getdate(),'07:20', '11:40'),
	(1, 5, 7, Getdate(),'13:00', '16:50')
go

Select T.Id_Turma					as 'Número da turma', 
	E.Id_Escala					as 'Número da escala',
	T.Sala, 
	T.Data						as 'Dia da aula',
	T.Hora_Entrada				as 'Inicio da aula',
	T.Hora_Saida					as 'Fim da aula',
	E.Descricao_Funcao			as 'Descrição da função',
	F.Nome					as 'Nome do professor'
from SysProtected.Idiomas I
INNER JOIN SysProtected.Turmas T
	on I.Id_Idioma = T.Id_Idioma
INNER JOIN SysProtected.Escalas E
	on T.Id_Escala = E.Id_Escala 
INNER JOIN SysProtected.Funcionarios F
	on E.Id_Funcionario = F.Id_Funcionario
go

Insert into SysProtected.Inscricoes_Turmas values
	(1, 1),
	(2, 1),
	(3, 1),
	(4, 1),
	(5, 1),
	(6, 1)
go

Select IT.Id_Inscricao	as 'Número de identificação do aluno',
	IT.Id_Turma			as 'Número da turma',
	A.Nome						as 'Nome do aluno',
	B.Nota1						as 'Prova 1',
	B.Nota2						as 'Prova 2',
	B.Media,
	B.Numero_Faltas				as 'Quantidade de faltas'
from SysProtected.Inscricoes_Turmas IT
INNER JOIN SysProtected.Inscricao I
	on IT.Id_Inscricao = IT.Id_Inscricao
INNER JOIN SysProtected.Alunos A
	on I.Id_Aluno = A.Id_Aluno
INNER JOIN SysProtected.Boletim B
	on I.Id_Inscricao = B.Id_Inscricao
go

Insert into SysProtected.Lista_Presenca values
	(1, 1, Getdate()),
	(2, 1, Getdate()),
	(3, 1, Getdate()),
	(4, 1, Getdate()),
	(5, 0, Getdate()),
	(6, 0, Getdate())
go

Select L.Id_Presenca		as 'Número de chamada do aluno',
	A.Nome					as 'Nome do aluno',
	case when L.Chamada = 1 then 'Presente' 
	else 'Faltou' end 'Presença',
	L.Data					as 'Dia da aula',
	T.Sala					as 'Número da sala',
	F.Nome					as 'Nome do professor',
	P.Nome					as 'Curso'
from SysProtected.Funcionarios F
INNER JOIN SysProtected.Escalas E
	on F.Id_Funcionario = E.Id_Funcionario
INNER JOIN SysProtected.Turmas T
	on E.Id_Escala = T.Id_Escala
INNER JOIN SysProtected.Inscricoes_Turmas IT
	on T.Id_Turma = IT.Id_Turma
INNER JOIN SysProtected.Lista_Presenca L
	on IT.Id_Inscricao_Turma = L.Id_Inscricao_Turma
INNER JOIN SysProtected.Inscricao I
	on IT.Id_Inscricao = IT.Id_Inscricao
INNER JOIN SysProtected.Alunos A
	on I.Id_Aluno = A.Id_Aluno
INNER JOIN SysProtected.Planos P
	on T.Id_Plano = P.Id_Plano
go