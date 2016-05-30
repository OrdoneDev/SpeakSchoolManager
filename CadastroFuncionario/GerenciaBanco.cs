using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroFuncionario
{
    class GerenciaBanco
    {
        static string strConexao = "Server=.\\MSSQLSERVER2012; Database=DB_Escola; Trusted_Connection=Yes;";
        public static int Id_Funcionario = 0;
        public static int Id_Aluno = 0;
        public static int Id_Plano = 0;
        public static int Id_Escala = 0;
        public static string Cargo = "";

        public static int CadastrarEndereco(string Estado, string Cidade, string CEP, string Bairro, string Nome_Rua, int Id_Endereco)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "Insert into SysProtected.Endereco (Estado, Cidade, CEP, Bairro, Nome_Rua) values (@Estado, @Cidade, @CEP, @Bairro, @Nome_Rua)";

                cmd.Parameters.Add(new SqlParameter("@Estado", Estado));
                cmd.Parameters.Add(new SqlParameter("@Cidade", Cidade));
                cmd.Parameters.Add(new SqlParameter("@CEP", CEP));
                cmd.Parameters.Add(new SqlParameter("@Bairro", Bairro));
                cmd.Parameters.Add(new SqlParameter("@Nome_Rua", Nome_Rua));

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                Id_Endereco = getUltimoEnderecoRegistrado(Id_Endereco);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return Id_Endereco;
        }

        public static bool CadastrarFuncionario(int Id_Endereco, string Nome, DateTime DataNascimento, char Sexo, string Estado_Civil,
                                            string RG, string CPF, string Email, string Foto, string DDD, string Telefone,
                                            short Quantidade_Filhos, string Historico_Escolar, string Cargo, float Salario,
                                            string Complemento, string Numero)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "EXEC CadastroFuncionario @Id_Endereco, @Nome, @DataNascimento, @Sexo, @Estado_Civil, " +
                "@RG, @CPF, @Email, @DDD, @Telefone, @Quantidade_Filhos, @Historico_Escolar, @Cargo, @Salario, " +
                "@Complemento, @Numero";

                cmd.Parameters.Add(new SqlParameter("@Id_Endereco", Id_Endereco));
                cmd.Parameters.Add(new SqlParameter("@Nome", Nome));
                SqlParameter dataParameter = new SqlParameter("@DataNascimento", SqlDbType.Date);
                dataParameter.Value = DataNascimento.Date;
                cmd.Parameters.Add(dataParameter);
                cmd.Parameters.Add(new SqlParameter("@Sexo", Sexo));
                cmd.Parameters.Add(new SqlParameter("@Estado_Civil", Estado_Civil));
                cmd.Parameters.Add(new SqlParameter("@RG", RG));
                cmd.Parameters.Add(new SqlParameter("@CPF", CPF));
                cmd.Parameters.Add(new SqlParameter("@Email", Email));
                cmd.Parameters.Add(new SqlParameter("@DDD", DDD));
                cmd.Parameters.Add(new SqlParameter("@Telefone", Telefone));
                cmd.Parameters.Add(new SqlParameter("@Quantidade_Filhos", Quantidade_Filhos));
                cmd.Parameters.Add(new SqlParameter("@Historico_Escolar", Historico_Escolar));
                cmd.Parameters.Add(new SqlParameter("@Cargo", Cargo));
                cmd.Parameters.Add(new SqlParameter("@Salario", Salario));
                cmd.Parameters.Add(new SqlParameter("@Complemento", Complemento));
                cmd.Parameters.Add(new SqlParameter("@Numero", Numero));

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conexao.Close();

                getUltimoFuncionarioRegistrado();

                if (Foto != "null")
                {
                    AtualizaFotoFuncionario(Foto);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexao.Close();
                return false;
            }
        }

        public static bool CadastrarResponsavel(int Id_Endereco, string Nome, DateTime DataNascimento, char Sexo, string Estado_Civil,
                                            string RG, string CPF, string Email, string DDD, string Telefone, string Complemento, string Numero)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "EXEC CadastroResponsavel @Id_Endereco, @Nome, @DataNascimento, @Sexo, @Estado_Civil, @RG, @CPF, " +
                "@Email, @DDD, @Telefone, @Complemento, @Numero";

                cmd.Parameters.Add(new SqlParameter("@Id_Endereco", Id_Endereco));
                cmd.Parameters.Add(new SqlParameter("@Nome", Nome));
                SqlParameter dataParameter = new SqlParameter("@DataNascimento", SqlDbType.Date);
                dataParameter.Value = DataNascimento.Date;
                cmd.Parameters.Add(dataParameter);
                cmd.Parameters.Add(new SqlParameter("@Sexo", Sexo));
                cmd.Parameters.Add(new SqlParameter("@Estado_Civil", Estado_Civil));
                cmd.Parameters.Add(new SqlParameter("@RG", RG));
                cmd.Parameters.Add(new SqlParameter("@CPF", CPF));
                cmd.Parameters.Add(new SqlParameter("@Email", Email));
                cmd.Parameters.Add(new SqlParameter("@DDD", DDD));
                cmd.Parameters.Add(new SqlParameter("@Telefone", Telefone));
                cmd.Parameters.Add(new SqlParameter("@Complemento", Complemento));
                cmd.Parameters.Add(new SqlParameter("@Numero", Numero));

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conexao.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexao.Close();
                return false;
            }
        }

        public static bool CadastrarAluno(int Id_Responsavel, int Id_Endereco, string Nome, DateTime DataNascimento, char Sexo, string Estado_Civil,
                                            string RG, string CPF, string Email, string Foto, string DDD, string Telefone,
                                            string Historico_Escolar, string Complemento, string Numero)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "EXEC CadastroAluno @Id_Responsavel, @Id_Endereco, @Nome, @DataNascimento, @Sexo, @Estado_Civil, " +
                "@RG, @CPF, @Email, @DDD, @Telefone, @Historico_Escolar, @Complemento, @Numero ";

                cmd.Parameters.Add(new SqlParameter("@Id_Responsavel", Id_Responsavel));   
                cmd.Parameters.Add(new SqlParameter("@Id_Endereco", Id_Endereco));
                cmd.Parameters.Add(new SqlParameter("@Nome", Nome));
                SqlParameter dataParameter = new SqlParameter("@DataNascimento", SqlDbType.Date);
                dataParameter.Value = DataNascimento.Date;
                cmd.Parameters.Add(dataParameter);
                cmd.Parameters.Add(new SqlParameter("@Sexo", Sexo));
                cmd.Parameters.Add(new SqlParameter("@Estado_Civil", Estado_Civil));
                cmd.Parameters.Add(new SqlParameter("@RG", RG));
                cmd.Parameters.Add(new SqlParameter("@CPF", CPF));
                cmd.Parameters.Add(new SqlParameter("@Email", Email));
                cmd.Parameters.Add(new SqlParameter("@DDD", DDD));
                cmd.Parameters.Add(new SqlParameter("@Telefone", Telefone));
                cmd.Parameters.Add(new SqlParameter("@Historico_Escolar", Historico_Escolar));
                cmd.Parameters.Add(new SqlParameter("@Complemento", Complemento));
                cmd.Parameters.Add(new SqlParameter("@Numero", Numero));

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conexao.Close();

                getUltimoAlunoRegistrado();

                if (Foto != "null")
                {
                    AtualizaFotoAluno(Foto);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexao.Close();
                return false;
            }
        }

        public static bool CadastrarHistorico(string Id, DateTime Data, string Descricao, string NomeId, string Tabela)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "Insert into SysProtected." + @Tabela + " (" + @NomeId + ", Data, Descricao) values (" + @Id + ", @Data, @Descricao)";

                cmd.Parameters.Add(new SqlParameter("@Tabela", Tabela));
                cmd.Parameters.Add(new SqlParameter("@NomeId", NomeId));
                cmd.Parameters.Add(new SqlParameter("@Id", Id));
                SqlParameter dataParameter = new SqlParameter("@Data", SqlDbType.DateTime);
                dataParameter.Value = Data;
                cmd.Parameters.Add(dataParameter);
                cmd.Parameters.Add(new SqlParameter("@Descricao", Descricao));

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
            return true;
        }

        public static int CadastrarIdioma(int Id_Idioma, string Nome, string Descricao)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "Insert into SysProtected.Idiomas (Nome, Descricao) values (@Nome, @Descricao)";

                cmd.Parameters.Add(new SqlParameter("@Nome", Nome));
                cmd.Parameters.Add(new SqlParameter("@Descricao", Descricao));
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                Id_Idioma = getUltimoIdiomaRegistrado(Id_Idioma);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return Id_Idioma;
        }

        public static bool CadastrarPlano(int Id_Idioma, string Nome, string Aulas_Previstas, string Valor)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "Insert into SysProtected.Planos (Id_Idioma, Nome, Aulas_Previstas, Valor) values (" + @Id_Idioma + ", @Nome, @Aulas_Previstas, @Valor)";
                cmd.Parameters.Add(new SqlParameter("@Id_Idioma", Id_Idioma));
                cmd.Parameters.Add(new SqlParameter("@Nome", Nome));
                cmd.Parameters.Add(new SqlParameter("@Aulas_Previstas", Aulas_Previstas));
                cmd.Parameters.Add(new SqlParameter("@Valor", Valor));
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
            return true;
        }

        public static void CadastrarFinanceiro(string Banco, int Agencia, int Conta, DateTime DataDeposito)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "Insert into SysProtected.Financeiro (Id_Funcionario, Banco, Agencia, Conta, Data)" +
                " values (" + @Id_Funcionario + ", @Banco, @Agencia, @Conta, @Data)";

                cmd.Parameters.Add(new SqlParameter("@Id_Funcionario", Id_Funcionario));
                cmd.Parameters.Add(new SqlParameter("@Banco", Banco));
                cmd.Parameters.Add(new SqlParameter("@Agencia", Agencia));
                cmd.Parameters.Add(new SqlParameter("@Conta", Conta));
                SqlParameter dataParameter = new SqlParameter("@Data", SqlDbType.Date);
                dataParameter.Value = DataDeposito.Date;
                cmd.Parameters.Add(dataParameter);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public static bool CadastrarFinanceiro(string Banco, int Agencia, int Conta)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;
            int Id_Financeiro = 0;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                Id_Financeiro = getFinanceiroEmpresa(Id_Financeiro);

                if (Id_Financeiro != 0)
                {
                    AtualizaFinanceiro(Id_Financeiro, Banco, Agencia, Conta);
                }
                else
                {
                    cmd.CommandText = "Insert into SysProtected.Financeiro (Banco, Agencia, Conta)" +
                                       " values (@Banco, @Agencia, @Conta)";

                    cmd.Parameters.Add(new SqlParameter("@Banco", Banco));
                    cmd.Parameters.Add(new SqlParameter("@Agencia", Agencia));
                    cmd.Parameters.Add(new SqlParameter("@Conta", Conta));
                }

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
            return true;
        }

        public static bool CadastrarEscala(int Id_Funcionario, DateTime Data, string Hora_Entrada, string Hora_Saida, string Descricao_Funcao)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "Insert into SysProtected.Escalas (Id_Funcionario, Data, Hora_Entrada, Hora_Saida, Descricao_Funcao) " +
                "values (@Id_Funcionario, @Data, @Hora_Entrada, @Hora_Saida, @Descricao_Funcao)";

                cmd.Parameters.Add(new SqlParameter("@Id_Funcionario", Id_Funcionario));
                SqlParameter dataParameter = new SqlParameter("@Data", SqlDbType.Date);
                dataParameter.Value = Data.Date;
                cmd.Parameters.Add(dataParameter);
                cmd.Parameters.Add(new SqlParameter("@Hora_Entrada", Hora_Entrada));
                cmd.Parameters.Add(new SqlParameter("@Hora_Saida", Hora_Saida));
                cmd.Parameters.Add(new SqlParameter("@Descricao_Funcao", Descricao_Funcao));

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexao.Close();
                return false;
            }

            return true;
        }
        
        public static bool CadastrarTurma(int Id_Plano, int Id_Escala, int Sala, DateTime Data, string Hora_Entrada, string Hora_Saida)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "Insert into SysProtected.Turmas (Id_Plano, Id_Escala, Sala, Data, Hora_Entrada, Hora_Saida) " +
                "values (@Id_Plano, @Id_Escala, @Sala, @Data, @Hora_Entrada, @Hora_Saida)";

                cmd.Parameters.Add(new SqlParameter("@Id_Plano", Id_Plano));
                cmd.Parameters.Add(new SqlParameter("@Id_Escala", Id_Escala));
                cmd.Parameters.Add(new SqlParameter("@Sala", Sala));
                SqlParameter dataParameter = new SqlParameter("@Data", SqlDbType.Date);
                dataParameter.Value = Data.Date;
                cmd.Parameters.Add(dataParameter);
                cmd.Parameters.Add(new SqlParameter("@Hora_Entrada", Hora_Entrada));
                cmd.Parameters.Add(new SqlParameter("@Hora_Saida", Hora_Saida));

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexao.Close();
                return false;
            }

            return true;
        }

        public static bool CadastrarAquisicaoCursoAluno(int Id_Financeiro, int Id_Plano, int Id_Aluno, short Parcelas, byte Situacao)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "Insert into SysProtected.Negociacao (Id_Financeiro, Id_Aluno, Id_Plano, Parcelas, Situacao) values (@Id_Financeiro, @Id_Aluno, @Id_Plano, @Parcelas, @Situacao)";

                cmd.Parameters.Add(new SqlParameter("@Id_Financeiro", Id_Financeiro));
                cmd.Parameters.Add(new SqlParameter("@Id_Aluno", Id_Aluno));
                cmd.Parameters.Add(new SqlParameter("@Id_Plano", Id_Plano));
                cmd.Parameters.Add(new SqlParameter("@Parcelas", Parcelas));
                cmd.Parameters.Add(new SqlParameter("@Situacao", Situacao));

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexao.Close();
                return false;
            }

            return true;
        }
        
        public static void CadastrarInscricoesTurma(int[] Id_Inscricao, int[] Id_Turma)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;
            int Id_Valida = 0;
            bool Continua = false;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                for (int i = 0; i < Id_Inscricao.Length; ++i)
                {
                    Id_Valida = 0;

                    if (Id_Inscricao[i] != 0)
                    {
                        Id_Valida = getInscricaoTurma(Id_Inscricao[i], Id_Turma[i], Id_Valida);

                        if (Id_Valida != 0)
                        {
                            Continua = getStatusInscricao(Id_Inscricao[i], Continua);

                            if (Continua)
                            {
                                Id_Inscricao[i] = AtualizaStatusInscricao(Id_Inscricao[i]);
                            }
                            else
                            {
                                Id_Inscricao[i] = 0;
                            }
                        }
                        Id_Turma[i] = getTurmaId(Id_Turma[i]);
                        if (Id_Inscricao[i] != 0 && Id_Turma[i] != 0)
                        {
                            cmd.CommandText = "Insert into SysProtected.Inscricoes_Turmas (Id_Inscricao, Id_Turma) values (@Id_Inscricao, @Id_Turma)";
                            cmd.Parameters.Add(new SqlParameter("@Id_Inscricao", Id_Inscricao[i]));
                            cmd.Parameters.Add(new SqlParameter("@Id_Turma", Id_Turma[i]));

                            cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();
                        }
                        cmd.Parameters.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return;
        }

        public static void CadastrarListaPresenca(int Id_Inscricao_Turma, DateTime Data)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "Insert into SysProtected.Lista_Presenca (Id_Inscricao_Turma, Chamada, Data) values (@Id_Inscricao_Turma, null, @Data)";

                cmd.Parameters.Add(new SqlParameter("@Id_Inscricao_Turma", Id_Inscricao_Turma));
                SqlParameter dataParameter = new SqlParameter("@Data", SqlDbType.Date);
                dataParameter.Value = Data.Date;
                cmd.Parameters.Add(dataParameter);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexao.Close();
                return;
            }

            return;
        }

        public static bool CadastrarPagamentoFuncionario(int Id_Financeiro, DateTime Data)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;
            int Numero_Parcela = 0;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                Numero_Parcela = getUltimaParcelaPaga(Id_Financeiro);
                Numero_Parcela++;

                cmd.CommandText = "Insert into SysProtected.Mensalidades (Id_Financeiro, Numero_Parcela, Situacao, Data) values (@Id_Financeiro, @Numero_Parcela, 1, @Data)";

                cmd.Parameters.Add(new SqlParameter("@Id_Financeiro", Id_Financeiro));
                cmd.Parameters.Add(new SqlParameter("@Numero_Parcela", Numero_Parcela));
                SqlParameter dataParameter = new SqlParameter("@Data", SqlDbType.Date);
                dataParameter.Value = Data.Date;
                cmd.Parameters.Add(dataParameter);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexao.Close();
                return false;
            }

            return true;
        }

        public static void AtualizaFotoFuncionario(string Foto)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "Declare @img1 as varbinary(max) Set @img1 = (Select * from openrowset(bulk N'" + @Foto +
                "', single_blob) as imagem) Update SysProtected.Funcionarios set Foto = @img1 where Id_Funcionario = @Id_Funcionario";

                cmd.Parameters.Add(new SqlParameter("@Foto", Foto));
                cmd.Parameters.Add(new SqlParameter("@Id_Funcionario", @Id_Funcionario));
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return;
        }

        public static void AtualizaFotoAluno(string Foto)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "Declare @img1 as varbinary(max) Set @img1 = (Select * from openrowset(bulk N'" + @Foto +
                "', single_blob) as imagem) Update SysProtected.Alunos set Foto = @img1 where Id_Aluno = @Id_Aluno";

                cmd.Parameters.Add(new SqlParameter("@Foto", Foto));
                cmd.Parameters.Add(new SqlParameter("@Id_Aluno", @Id_Aluno));
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return;
        }

        public static void AtualizaFinanceiro(int Id_Financeiro, string Banco, int Agencia, int Conta)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "Update SysProtected.Financeiro set Banco = @Banco, Agencia = @Agencia, Conta = @Conta where Id_Financeiro = @Id_Financeiro";
                cmd.Parameters.Add(new SqlParameter("@Id_Financeiro", Id_Financeiro));
                cmd.Parameters.Add(new SqlParameter("@Banco", Banco));
                cmd.Parameters.Add(new SqlParameter("@Agencia", Agencia));
                cmd.Parameters.Add(new SqlParameter("@Conta", Conta));

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return;
        }

        public static int AtualizaStatusInscricao(int Id_Inscricao)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "Update SysProtected.Inscricao set Status = 1 where Id_Inscricao = @Id_Inscricao";
                cmd.Parameters.Add(new SqlParameter("@Id_Inscricao", Id_Inscricao));

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            Id_Inscricao = 0;
            return Id_Inscricao;
        }

        public static bool AtualizaMensalidade(int Id_Mensalidade, byte Situacao)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "Update SysProtected.Mensalidades set Situacao = @Situacao where Id_Mensalidade = @Id_Mensalidade";

                cmd.Parameters.Add(new SqlParameter("@Id_Mensalidade", Id_Mensalidade));
                cmd.Parameters.Add(new SqlParameter("@Situacao", Situacao));

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
            return true;
        }

        public static bool AtualizaInscricao(int Id_Inscricao, byte Status)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "Update SysProtected.Inscricao set Status = @Status where Id_Inscricao = @Id_Inscricao";

                cmd.Parameters.Add(new SqlParameter("@Id_Inscricao", Id_Inscricao));
                cmd.Parameters.Add(new SqlParameter("@Status", Status));

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
            return true;
        }

        public static bool AtualizaBoletim(int Id_Inscricao, float Nota1, float Nota2, short Numero_Faltas)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "Update SysProtected.Boletim set Nota1 = @Nota1, Nota2 = @Nota2," +
                "Numero_Faltas = @Numero_Faltas where Id_Inscricao = @Id_Inscricao";

                cmd.Parameters.Add(new SqlParameter("@Id_Inscricao", Id_Inscricao));
                cmd.Parameters.Add(new SqlParameter("@Nota1", Nota1));
                cmd.Parameters.Add(new SqlParameter("@Nota2", Nota2));
                cmd.Parameters.Add(new SqlParameter("@Numero_Faltas", Numero_Faltas));

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
            return true;
        }

        public static void AtualizaInscricoesTurma(int[] Id_InscricaoFalse, int[] Id_Turma)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;
            int Id_Valida = 0;
            bool Continua = false;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                for (int i = 0; i < Id_InscricaoFalse.Length; ++i)
                {
                    if (Id_InscricaoFalse[i] != 0)
                    {
                        Id_Valida = getId_InscricaoAlteracao(Id_InscricaoFalse[i], Id_Turma[i], Id_Valida, Continua);

                        if (Id_Valida == 0)
                            Id_InscricaoFalse[i] = 0;
                        else
                            Continua = true;

                        if (Id_InscricaoFalse[i] != 0 && Continua)
                        {
                            cmd.CommandText = "Update SysProtected.Inscricao set Status = 0 where Id_Inscricao = @Id_Inscricao";

                            cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();
                        }
                        cmd.Parameters.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return;
        }

        public static void AtualizarListaPresenca(int Id_Presenca, byte Chamada)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "Update SysProtected.Lista_Presenca set Chamada = @Chamada where Id_Presenca = @Id_Presenca";

                cmd.Parameters.Add(new SqlParameter("@Id_Presenca", Id_Presenca));
                cmd.Parameters.Add(new SqlParameter("@Chamada", Chamada));

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return;
        }

        public static int VerificaPermissao(int Tag, string Tabela)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;
            SqlDataReader dr;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT * FROM SysProtected." + @Tabela;

                cmd.Parameters.Add(new SqlParameter("@Tabela", Tabela));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (@Tabela == "Funcionarios")
                        Tag = 1;
                    else if (@Tabela == "Alunos")
                        Tag = 2;
                }
            }
            catch (Exception)
            {
                Tag = 0;
            }
            finally
            {
                conexao.Close();
            }

            return Tag;
        }
        
        public static bool VerificaFuncionario(string RG, string CPF)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;
            SqlDataReader dr;
            int Id_Funcionario = 0;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT Id_Funcionario FROM SysProtected.Funcionarios WHERE RG = @RG or CPF = @CPF";

                cmd.Parameters.Add(new SqlParameter("@RG", RG));
                cmd.Parameters.Add(new SqlParameter("@CPF", CPF));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Id_Funcionario = (dr.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            if (Id_Funcionario != 0)
                return false;

            return true;
        }

        public static bool VerificaResponsavel(string RG, string CPF)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;
            SqlDataReader dr;
            int Id_Responsavel = 0;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT Id_Responsavel FROM SysProtected.Responsavel_Aluno WHERE RG = @RG or CPF = @CPF";

                cmd.Parameters.Add(new SqlParameter("@RG", RG));
                cmd.Parameters.Add(new SqlParameter("@CPF", CPF));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Id_Responsavel = (dr.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            if (Id_Responsavel != 0)
                return false;

            return true;
        }

        public static bool VerificaAluno(string Nome, DateTime DataNascimento, string Historico_Escolar, string Numero)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;
            SqlDataReader dr;
            int Id_Aluno = 0;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT Id_Aluno FROM SysProtected.Alunos WHERE Nome = @Nome and DataNascimento = " +
                "@DataNascimento and Historico_Escolar = @Historico_Escolar and Numero = @Numero";

                cmd.Parameters.Add(new SqlParameter("@Nome", Nome));
                SqlParameter dataParameter = new SqlParameter("@DataNascimento", SqlDbType.Date);
                dataParameter.Value = DataNascimento.Date;
                cmd.Parameters.Add(dataParameter);
                cmd.Parameters.Add(new SqlParameter("@Historico_Escolar", Historico_Escolar));
                cmd.Parameters.Add(new SqlParameter("@Numero", Numero));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Id_Aluno = (dr.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            if (Id_Aluno != 0)
                return false;

            return true;
        }

        public static bool VerificaPlano(int Id_Idioma, string Nome)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;
            SqlDataReader dr;
            int Id_Plano = 0;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT Id_Plano FROM SysProtected.Planos WHERE Id_Idioma = @Id_Idioma and Nome = @Nome";

                cmd.Parameters.Add(new SqlParameter("@Id_Idioma", Id_Idioma));
                cmd.Parameters.Add(new SqlParameter("@Nome", Nome));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Id_Plano = (dr.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            if (Id_Plano != 0)
                return false;

            return true;
        }

        public static bool VerificaFinanceiro(string Banco, int Agencia, int Conta)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;
            SqlDataReader dr;
            int Id_Financeiro = 0;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT Id_Financeiro FROM SysProtected.Financeiro WHERE Banco = @Banco and Agencia = @Agencia and Conta = @Conta";

                cmd.Parameters.Add(new SqlParameter("@Banco", Banco));
                cmd.Parameters.Add(new SqlParameter("@Agencia", Agencia));
                cmd.Parameters.Add(new SqlParameter("@Conta", Conta));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Id_Financeiro = (dr.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            if (Id_Financeiro != 0)
                return false;

            return true;
        }

        public static bool VerificaAquisicao(int Id_Aluno, int Id_Plano)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;
            SqlDataReader dr;
            int Id_Negociacao = 0;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT Id_Negociacao FROM SysProtected.Negociacao WHERE Id_Aluno = @Id_Aluno and Id_Plano = @Id_Plano";

                cmd.Parameters.Add(new SqlParameter("@Id_Aluno", Id_Aluno));
                cmd.Parameters.Add(new SqlParameter("@Id_Plano", Id_Plano));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Id_Negociacao = (dr.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            if (Id_Negociacao != 0)
                return false;

            return true;
        }

        public static int VerificaListaPresenca(int Id_Turma, DateTime Data)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;
            SqlDataReader dr;
            int Id_ListaPresenca = 0;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "select Id_Presenca from VerificarListaPresenca where Data = @Data and Id_Turma = @Id_Turma";

                cmd.Parameters.Add(new SqlParameter("@Id_Turma", Id_Turma));
                SqlParameter dataParameter = new SqlParameter("@Data", SqlDbType.Date);
                dataParameter.Value = Data.Date;
                cmd.Parameters.Add(dataParameter);

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Id_ListaPresenca = (dr.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return Id_ListaPresenca;
        }
        
        public static List<string> getFinanceiroEmpresa()
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;
            SqlDataReader dr;
            List<string> lista = new List<string>();

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT Banco, Agencia, Conta, Id_Financeiro FROM SysProtected.Financeiro WHERE Id_Funcionario is null and Data is null";

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr.GetString(0));
                    lista.Add(dr.GetInt32(1).ToString());
                    lista.Add(dr.GetInt32(2).ToString());
                    lista.Add(dr.GetInt32(3).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return lista;
        }

        public static int getId_Endereco(string CEP, string Bairro, string Nome_Rua, int Id_Endereco)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;
            SqlDataReader dr;
            
            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT Id_Endereco, Estado, Cidade, CEP, Bairro, Nome_Rua FROM SysProtected.Endereco WHERE " +
                "CEP = @CEP and Bairro = @Bairro and Nome_Rua = @Nome_Rua";

                cmd.Parameters.Add(new SqlParameter("@CEP", CEP));
                cmd.Parameters.Add(new SqlParameter("@Bairro", Bairro));
                cmd.Parameters.Add(new SqlParameter("@Nome_Rua", Nome_Rua));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Id_Endereco = (dr.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return Id_Endereco;
        }

        public static List<string> getId_Responsavel(string CPF_Responsavel)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;
            SqlDataReader dr;
            List<string> lista = new List<string>();

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT Id_Responsavel, Nome FROM SysProtected.Responsavel_Aluno WHERE CPF = @CPF";

                cmd.Parameters.Add(new SqlParameter("@CPF", CPF_Responsavel));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr.GetInt32(0).ToString());
                    lista.Add(dr.GetString(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return lista;
        }

        public static int getId_Idioma(string Nome_Idioma, string Descricao_Idioma)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;
            SqlDataReader dr;
            int Id_Idioma = 0;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT Id_Idioma FROM SysProtected.Idiomas WHERE Nome = @Nome_Idioma and Descricao = @Descricao_Idioma";

                cmd.Parameters.Add(new SqlParameter("@Nome_Idioma", Nome_Idioma));
                cmd.Parameters.Add(new SqlParameter("@Descricao_Idioma", Descricao_Idioma));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Id_Idioma = (dr.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return Id_Idioma;
        }

        public static string getNome(string Id, string Tabela, string TipoId)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;
            SqlDataReader dr;
            string Nome = "";

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT Nome FROM SysProtected." + @Tabela + " WHERE " + @TipoId + " = @Id";

                cmd.Parameters.Add(new SqlParameter("@Id", Id));
                cmd.Parameters.Add(new SqlParameter("@Tabela", Tabela));
                cmd.Parameters.Add(new SqlParameter("@TipoId", TipoId));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Nome = (dr.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return Nome;
        }

        public static List<string> getInformacoesPagamento(int Id_Funcionario)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;
            SqlDataReader dr;
            List<string> lista = new List<string>();

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT Nome, Salario, Id_Financeiro from PagamentoFuncionario WHERE Id_Funcionario = @Id_Funcionario";

                cmd.Parameters.Add(new SqlParameter("@Id_Funcionario", Id_Funcionario));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr.GetString(0));
                    lista.Add(dr.GetSqlMoney(1).ToString());
                    lista.Add(dr.GetInt32(2).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return lista;
        }

        public static List<string> getEscalaFuncionario(int Id_Escala)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;
            SqlDataReader dr;
            List<string> lista = new List<string>();

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Select Nome, Hora_Entrada, Hora_Saida, Data from EscalaFuncionario Where Id_Escala = @Id_Escala and (Cargo = 'Professor(a)' or Cargo = 'Cordenador(a)')";

                cmd.Parameters.Add(new SqlParameter("@Id_Escala", Id_Escala));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr.GetString(0));
                    lista.Add(dr.GetTimeSpan(1).ToString());
                    lista.Add(dr.GetTimeSpan(2).ToString());
                    FormCadastroTurma.Data = (dr.GetDateTime(3));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return lista;
        }

        public static List<string> getInformacoesFuncionario(string Id_Funcionario)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;
            SqlDataReader dr;
            List<string> lista = new List<string>();

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT Nome, Cargo FROM SysProtected.Funcionarios WHERE Id_Funcionario = @Id_Funcionario";

                cmd.Parameters.Add(new SqlParameter("@Id_Funcionario", Id_Funcionario));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr.GetString(0));
                    lista.Add(dr.GetString(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return lista;
        }
        
        public static List<string> getLista(string Parte_Nome, string Tipo1, string Tipo2, string Tabela)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;
            SqlDataReader dr;
            List<string> lista = new List<string>();

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT " + @Tipo1 + " FROM " + @Tabela + " WHERE "+ @Tipo2 +" LIKE @Parte_Nome";
                cmd.Parameters.Add(new SqlParameter("@Tipo1", Tipo1));
                cmd.Parameters.Add(new SqlParameter("@Tipo2", Tipo2));
                cmd.Parameters.Add(new SqlParameter("@Parte_Nome", Parte_Nome + "%"));
                cmd.Parameters.Add(new SqlParameter("@Tabela", Tabela));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr.GetString(0));
                    if (Tabela == "SysProtected.Funcionarios" && (@Tipo1 == "TOP 5 Nome, Id_Funcionario" || @Tipo1 == "TOP 5 Nome, Id_Funcionario, Cargo"))
                    {
                        Id_Funcionario = (dr.GetInt32(1));
                        if (@Tipo1 == "TOP 5 Nome, Id_Funcionario, Cargo")
                            Cargo = (dr.GetString(2));
                    }
                    if (Tabela == "SysProtected.Alunos" && @Tipo1 == "TOP 5 Nome, Id_Aluno")
                        Id_Aluno = (dr.GetInt32(1));
                    if (Tabela == "SysProtected.Planos" && @Tipo1 == "TOP 5 Nome, Id_Plano")
                        Id_Plano = (dr.GetInt32(1));
                    if (Tabela == "EscalaFuncionario")
                        Id_Escala = (dr.GetInt32(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return lista;
        }

        public static List<string> getListaCEP(string CEP)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;
            SqlDataReader dr;
            List<string> lista = new List<string>();

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT Estado, Cidade FROM SysProtected.Endereco WHERE CEP = @CEP";
                cmd.Parameters.Add(new SqlParameter("@CEP", CEP));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr.GetString(0));
                    lista.Add(dr.GetString(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return lista;
        }

        public static DataTable getMensalidades(int Id_Aluno)
        {
            DataTable dt = null;
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT * FROM AllMensalidades where [Código do aluno] = @Id_Aluno";

                cmd.Parameters.Add(new SqlParameter("@Id_Aluno", Id_Aluno));
                
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conexao.Close();
            }
            return dt;
        }

        public static DataTable getInscricoes(int Id_Aluno)
        {
            DataTable dt = null;
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "select * from AllInscricoes where [Código do aluno] = @Id_Aluno";

                cmd.Parameters.Add(new SqlParameter("@Id_Aluno", Id_Aluno));

                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conexao.Close();
            }
            return dt;
        }

        public static DataTable getBoletim(int Id_Aluno)
        {
            DataTable dt = null;
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "Select * from AllBoletim where [Código do aluno] = @Id_Aluno";

                cmd.Parameters.Add(new SqlParameter("@Id_Aluno", Id_Aluno));

                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conexao.Close();
            }
            return dt;
        }

        public static DataTable getListaPresenca(int Id_Turma)
        {
            DataTable dt = null;
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "Select * from ListaPresenca where [Código da turma] = @Id_Turma";

                cmd.Parameters.Add(new SqlParameter("@Id_Turma", Id_Turma));

                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conexao.Close();
            }
            return dt;
        }

        public static List<string> getTurma(int Id_Turma)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;
            SqlDataReader dr;
            List<string> lista = new List<string>();

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Select * from TurmaAluno where Id_Turma = @Id_Turma";
                cmd.Parameters.Add(new SqlParameter("@Id_Turma", Id_Turma));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr.GetString(1));
                    lista.Add(dr.GetString(2));
                    lista.Add(dr.GetValue(3).ToString());
                    lista.Add(dr.GetTimeSpan(4).ToString());
                    lista.Add(dr.GetTimeSpan(5).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return lista;
        }

        public static List<string> getAlunosTurma(int Id_Turma)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;
            SqlDataReader dr;
            List<string> lista = new List<string>();

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Select Id_Inscricao_Turma, Id_Turma from SysProtected.Inscricoes_Turmas where Id_Turma = @Id_Turma";
                cmd.Parameters.Add(new SqlParameter("@Id_Turma", Id_Turma));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr.GetInt32(0).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return lista;
        }

        public static int getUltimoEnderecoRegistrado(int Id_Endereco)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT TOP 1 Id_Endereco FROM SysProtected.Endereco ORDER BY Id_Endereco DESC";
                Id_Endereco = (int)(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return Id_Endereco;
        }

        public static void getUltimoFuncionarioRegistrado()
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT TOP 1 Id_Funcionario FROM SysProtected.Funcionarios ORDER BY Id_Funcionario DESC";
                Id_Funcionario = (int)(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return;
        }

        public static void getUltimoAlunoRegistrado()
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT TOP 1 Id_Aluno FROM SysProtected.Alunos ORDER BY Id_Aluno DESC";
                Id_Aluno = (int)(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return;
        }

        public static int getUltimoIdiomaRegistrado(int Id_Idioma)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT TOP 1 Id_Idioma FROM SysProtected.Idiomas ORDER BY Id_Idioma DESC";
                Id_Idioma = (int)(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return Id_Idioma;
        }

        public static int getFinanceiroEmpresa(int Id_Financeiro)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;
            SqlDataReader dr;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT Id_Financeiro FROM SysProtected.Financeiro WHERE Id_Funcionario is null and Data is null";
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Id_Financeiro = (dr.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return Id_Financeiro;
        }

        public static int getTurmaId(int Id_Turma)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;
            SqlDataReader dr;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "Select Id_Turma from SysProtected.Turmas where Id_Turma = @Id_Turma";
                cmd.Parameters.Add(new SqlParameter("@Id_Turma", Id_Turma));

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Id_Turma = (dr.GetInt32(0));
                }

                if (!dr.Read())
                    Id_Turma = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return Id_Turma;
        }

        public static int getInscricaoTurma(int Id_Inscricao, int Id_Turma, int Id_Valida)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;
            SqlDataReader dr;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "Select Id_Inscricao_Turma from SysProtected.Inscricoes_Turmas where Id_Inscricao = @Id_Inscricao and Id_Turma = @Id_Turma";
                cmd.Parameters.Add(new SqlParameter("@Id_Inscricao", Id_Inscricao));
                cmd.Parameters.Add(new SqlParameter("@Id_Turma", Id_Turma));

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Id_Valida = (dr.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return Id_Valida;
        }

        public static bool getStatusInscricao(int Id_Inscricao, bool Continua)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;
            SqlDataReader dr;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "Select Status from SysProtected.Inscricao where Id_Inscricao = @Id_Inscricao and Status = 0";
                cmd.Parameters.Add(new SqlParameter("@Id_Inscricao", Id_Inscricao));

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Continua = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return Continua;
        }

        public static int getId_InscricaoAlteracao(int Id_InscricaoFalse, int Id_Turma, int Id_Valida, bool Continua)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;
            SqlDataReader dr;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "Select Id_Inscricao_Turma from SysProtected.Inscricoes_Turmas where Id_Inscricao = @Id_Inscricao and Id_Turma = @Id_Turma";
                cmd.Parameters.Add(new SqlParameter("@Id_Inscricao", Id_InscricaoFalse));
                cmd.Parameters.Add(new SqlParameter("@Id_Turma", Id_Turma));

                dr = cmd.ExecuteReader();
                Id_Valida = 0;

                while (dr.Read())
                {
                    Id_Valida = (dr.GetInt32(0));
                    Continua = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return Id_Valida;
        }

        public static int getUltimaParcelaPaga(int Id_Financeiro)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT TOP 1 Numero_Parcela FROM SysProtected.Mensalidades where Id_Financeiro = @Id_Financeiro ORDER BY Numero_Parcela DESC";
                cmd.Parameters.Add(new SqlParameter("@Id_Financeiro", Id_Financeiro));

                Id_Financeiro = (int)(cmd.ExecuteScalar());
            }
            catch (Exception)
            {
                Id_Financeiro = 0;
            }
            finally
            {
                conexao.Close();
            }

            return Id_Financeiro;
        }

        public static DataTable getFiltro(string Filtro, string Campo, string Tabela)
        {
            DataTable dt = null;
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd;

            try
            {
                conexao.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT * FROM "+@Tabela+" where "+@Campo+" = @Filtro";

                cmd.Parameters.Add(new SqlParameter("@Campo", Campo));
                cmd.Parameters.Add(new SqlParameter("@Filtro", Filtro));
                cmd.Parameters.Add(new SqlParameter("@Tabela", Tabela));

                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conexao.Close();
            }
            return dt;
        }
    }
}