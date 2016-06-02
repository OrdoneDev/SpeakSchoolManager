using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroFuncionario
{
    public partial class FormCadastroAluno : Form
    {
        OpenFileDialog openFile = new OpenFileDialog();
        private int Id_Responsavel = 0;

        public FormCadastroAluno()
        {
            InitializeComponent();
        }

        private bool VerificaCamposCadastroAluno()
        {
            if (!ValidaCampos.ValidaCamposGroup(group_Aluno))
                return false;

            ValidaCampos.CompletaNull(txt_EmailAluno);

            ValidaCampos.CompletaNull(txt_FotoAluno);

            ValidaCampos.CompletaNull(txt_ComplementoAluno);

            if (!ValidaCampos.ValidaOpcoesCmb(cmb_SexoAluno, "sexo"))
                return false;

            if (!ValidaCampos.ValidaOpcoesCmb(cmb_GrauEscolaridadeAluno, "grau de escolaridade"))
                return false;

            if (!ValidaCampos.ValidaOpcoesCmb(cmb_EstadoCivilAluno, "estado civil"))
                return false;

            return true;
        }

        private void cmb_EstadoAluno_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_EstadoAluno, "DISTINCT TOP 5 Estado", "Estado", e, "SysProtected.Endereco");
        }

        private void cmb_EstadoAluno_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void cmb_CidadeAluno_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_CidadeAluno, "DISTINCT TOP 5 Cidade", "Cidade", e, "SysProtected.Endereco");
        }

        private void cmb_CidadeAluno_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void cmb_BairroAluno_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_BairroAluno, "DISTINCT TOP 5 Bairro", "Bairro", e, "SysProtected.Endereco");
        }

        private void cmb_BairroAluno_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void cmb_RuaAluno_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_RuaAluno, "DISTINCT TOP 5 Nome_Rua", "Nome_Rua", e, "SysProtected.Endereco");
        }

        private void cmb_RuaAluno_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void msk_CepAluno_TextChanged(object sender, EventArgs e)
        {
            string[] Endereco;

            if (msk_CepAluno.Text.Length == 9)
            {
                Endereco = GerenciaBanco.getListaCEP(msk_CepAluno.Text).ToArray();

                if (Endereco.Length > 0)
                {
                    cmb_EstadoAluno.Text = Endereco[0];
                    cmb_CidadeAluno.Text = Endereco[1];
                }
            }
        }

        private void msk_CpfResponsavel_TextChanged(object sender, EventArgs e)
        {
            string[] lista;

            if (msk_CpfResponsavelAluno.Text.Length == 14)
            {
                lista = GerenciaBanco.getId_Responsavel(msk_CpfResponsavelAluno.Text).ToArray();

                if (lista.Length > 0)
                {
                    cmb_Responsavel.Text = lista[1];
                }
                else
                {
                    MessageBox.Show("Responsavel ainda não está cadastrado no sistema!");
                }
            }
            else
            {
                cmb_Responsavel.Text = "";
            }
        }

        private void dte_DataNascimentoAluno_ValueChanged(object sender, EventArgs e)
        {
            if ((DateTime.Now.Year - dte_DataNascimentoAluno.Value.Date.Year) < 18)
            {
                group_Responsavel.Visible = true;
            }
            else
            {
                group_Responsavel.Visible = false;
            }
        }

        private void txt_FotoAluno_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (txt_FotoAluno.Text != openFile.FileName)
                pic_Aluno.Image = null;
        }

        private void btn_AbrirFotoAluno_Click(object sender, EventArgs e)
        {           
            openFile.Filter = "Arquivos de imagem(*.jpg)|*.jpg| Arquivos de imagem(*.jpge|*.jpge";
            openFile.InitialDirectory = @"c:\";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txt_FotoAluno.Text = openFile.FileName;
                pic_Aluno.Image = new Bitmap(openFile.FileName);
            }
        }

        private void btn_EfetuarCadastroAluno_Click(object sender, EventArgs e)
        {
            DateTime dataNascimento;
            Image Foto = null;
            int Id_Endereco = 0;
            
            if (!VerificaCamposCadastroAluno())
                return;

            if (MessageBox.Show("Deseja efetuar o cadastro?", "Salvar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (group_Responsavel.Visible == true)
                    if (!ValidaCampos.ValidaCamposGroup(group_Responsavel))
                    {
                        MessageBox.Show("É necessário vincular este aluno a um responsável devido a sua idade!");
                        return;
                    }

                if (!ValidaCampos.ValidaCep(msk_CepAluno.Text))
                {
                    MessageBox.Show("CEP Invalido!");
                    return;
                }

                dataNascimento = dte_DataNascimentoAluno.Value.Date;

                if (!GerenciaBanco.VerificaAluno(txt_NomeAluno.Text, dataNascimento, cmb_GrauEscolaridadeAluno.Text, msk_NumeroAluno.Text))
                {
                    MessageBox.Show("Houve uma duplicação nos dados do aluno!");
                    return;
                }

                Id_Endereco = GerenciaBanco.getId_Endereco(msk_CepAluno.Text, cmb_BairroAluno.Text, cmb_RuaAluno.Text, Id_Endereco);

                if (Id_Endereco == 0)
                {
                    Id_Endereco = GerenciaBanco.CadastrarEndereco(cmb_EstadoAluno.Text, cmb_CidadeAluno.Text,
                    msk_CepAluno.Text, cmb_BairroAluno.Text, cmb_RuaAluno.Text, Id_Endereco);
                }

                if (group_Responsavel.Visible == true)
                {
                    string[] lista;
                    if (!ValidaCampos.ValidaCamposGroup(group_Responsavel))
                        return;

                    lista = GerenciaBanco.getId_Responsavel(msk_CpfResponsavelAluno.Text).ToArray();
                    Id_Responsavel = int.Parse(lista[0]);
                }

                if (pic_Aluno.Image != null)
                    Foto = pic_Aluno.Image;

                if (GerenciaBanco.CadastrarAluno(Id_Responsavel, Id_Endereco, txt_NomeAluno.Text, dataNascimento,
                char.Parse(cmb_SexoAluno.Text), cmb_EstadoAluno.Text, msk_RgAluno.Text, msk_CpfAluno.Text,
                txt_EmailAluno.Text, Foto, msk_DddAluno.Text, msk_TelefoneAluno.Text,
                cmb_GrauEscolaridadeAluno.Text, txt_ComplementoAluno.Text, msk_NumeroAluno.Text))
                {
                    MessageBox.Show("Usuario cadastrado com sucesso!");
                    Id_Responsavel = 0;
                }
                else
                {
                    MessageBox.Show("Foi encontrado algum erro no ato de cadastrar usuario!");
                }
            }
        }

        private void btn_CancelarCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
