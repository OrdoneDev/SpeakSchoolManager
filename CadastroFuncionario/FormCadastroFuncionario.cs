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
    public partial class FormCadastroFuncionario : Form
    {
        OpenFileDialog openFile = new OpenFileDialog();

        public FormCadastroFuncionario()
        {
            InitializeComponent();
        }

        private bool VerificaCamposCadastroFuncionario()
        {
            if (!ValidaCampos.ValidaCamposGroup(group_Funcionario))
                return false;

            ValidaCampos.CompletaNull(txt_EmailFuncionario);

            ValidaCampos.CompletaNull(msk_FilhosFuncionario);

            ValidaCampos.CompletaNull(txt_FotoFuncionario);

            ValidaCampos.CompletaNull(txt_ComplementoFuncionario);

            if (!ValidaCampos.ValidaOpcoesCmb(cmb_SexoFuncionario, "sexo"))
                return false;

            if (!ValidaCampos.ValidaOpcoesCmb(cmb_GrauEscolaridadeFuncionario, "grau de escolaridade"))
                return false;

            if (!ValidaCampos.ValidaOpcoesCmb(cmb_EstadoCivilFuncionario, "estado civil"))
                return false;

            if (!ValidaCampos.ValidaOpcoesCmb(cmb_CargoFuncionario, "cargo"))
                return false;
            
            return true;
        }

        private void cmb_EstadoFuncionario_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_EstadoFuncionario, "DISTINCT TOP 5 Estado", "Estado", e, "SysProtected.Endereco");
        }

        private void cmb_EstadoFuncionario_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void cmb_CidadeFuncionario_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_CidadeFuncionario, "DISTINCT TOP 5 Cidade", "Cidade", e, "SysProtected.Endereco");
        }

        private void cmb_CidadeFuncionario_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void cmb_BairroFuncionario_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_BairroFuncionario, "DISTINCT TOP 5 Bairro", "Bairro", e, "SysProtected.Endereco");
        }

        private void cmb_BairroFuncionario_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void cmb_RuaFuncionario_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_RuaFuncionario, "DISTINCT TOP 5 Nome_Rua", "Nome_Rua", e, "SysProtected.Endereco");
        }

        private void cmb_RuaFuncionario_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void msk_CepFuncionario_TextChanged(object sender, EventArgs e)
        {
            string[] Endereco;
            if (msk_CepFuncionario.Text.Length == 9)
            {
                Endereco = GerenciaBanco.getListaCEP(msk_CepFuncionario.Text).ToArray();

                if (Endereco.Length > 0)
                {
                    cmb_EstadoFuncionario.Text = Endereco[0];
                    cmb_CidadeFuncionario.Text = Endereco[1];
                }
            }
        }

        private void txt_FotoFuncionario_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (txt_FotoFuncionario.Text != openFile.FileName)
                pic_Funcionario.Image = null;
        }

        private void btn_AbrirFotoFuncionario_Click(object sender, EventArgs e)
        {
            openFile.Filter = "Arquivos de imagem(*.jpg)|*.jpg| Arquivos de imagem(*.jpge)|*.jpge";
            openFile.InitialDirectory = @"c:\";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txt_FotoFuncionario.Text = openFile.FileName;
                pic_Funcionario.Image = new Bitmap(openFile.FileName);
            }
        }

        private void btn_EfetuarCadastroFuncionario_Click(object sender, EventArgs e)
        {
            FormCadastroFinanceiroFuncionario form = new FormCadastroFinanceiroFuncionario();
            DateTime dataNascimento;
            int Id_Endereco = 0;

            if (!VerificaCamposCadastroFuncionario())
                return;

            if (!ValidaCampos.ValidaCPF(msk_CpfFuncionario.Text))
            {
                MessageBox.Show("CPF Invalido!");
                return;
            }
            
            if (!ValidaCampos.ValidaCep(msk_CepFuncionario.Text))
            {
                MessageBox.Show("CEP Invalido!");
                return;
            }

            if (!GerenciaBanco.VerificaFuncionario(msk_RgFuncionario.Text, msk_CpfFuncionario.Text))
            {
                MessageBox.Show("Houve uma duplicação no campo de RG ou CPF do funcionário!");
                return;
            }

            Id_Endereco = GerenciaBanco.getId_Endereco(msk_CepFuncionario.Text, cmb_BairroFuncionario.Text, cmb_RuaFuncionario.Text, Id_Endereco);

            if (Id_Endereco == 0)
            {
                Id_Endereco = GerenciaBanco.CadastrarEndereco(cmb_EstadoFuncionario.Text, cmb_CidadeFuncionario.Text,
                msk_CepFuncionario.Text, cmb_BairroFuncionario.Text, cmb_RuaFuncionario.Text, Id_Endereco);
            }

            form.ShowDialog();

            if (!ValidaCampos.Continua)
                return;

            dataNascimento = dte_DataNascimentoFuncionario.Value.Date;

            if (GerenciaBanco.CadastrarFuncionario(Id_Endereco, txt_NomeFuncionario.Text, dataNascimento,
                char.Parse(cmb_SexoFuncionario.Text), cmb_EstadoCivilFuncionario.Text, msk_RgFuncionario.Text,
                msk_CpfFuncionario.Text, txt_EmailFuncionario.Text, txt_FotoFuncionario.Text, msk_DddFuncionario.Text,
                msk_TelefoneFuncionario.Text, short.Parse(msk_FilhosFuncionario.Text), cmb_GrauEscolaridadeFuncionario.Text,
                cmb_CargoFuncionario.Text, float.Parse(msk_SalarioFuncionario.Text), txt_ComplementoFuncionario.Text,
                msk_NumeroFuncionario.Text))
            {
                MessageBox.Show("Usuario cadastrado com sucesso!");
                GerenciaBanco.CadastrarFinanceiro(ValidaCampos.banco, ValidaCampos.agencia, ValidaCampos.conta, ValidaCampos.dataDeposito);
            }
            else
            {
                MessageBox.Show("Foi encontrado algum erro no ato de cadastrar usuario!");
            }
        }

        private void btn_CancelarCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
