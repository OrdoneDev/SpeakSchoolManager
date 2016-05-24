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
    public partial class FormCadastroResponsavel : Form
    {
        public FormCadastroResponsavel()
        {
            InitializeComponent();
        }

        private bool VerificaCamposCadastroReponsavel()
        {
            if (!ValidaCampos.ValidaCamposGroup(group_Responsavel))
                return false;

            ValidaCampos.CompletaNull(txt_EmailResponsavel);

            ValidaCampos.CompletaNull(txt_ComplementoResponsavel);

            if (!ValidaCampos.ValidaOpcoesCmb(cmb_SexoResponsavel, "sexo"))
                return false;

            if (!ValidaCampos.ValidaOpcoesCmb(cmb_EstadoCivilResponsavel, "estado civil"))
                return false;

            return true;
        }

        private void cmb_EstadoResponsavel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_EstadoResponsavel, "DISTINCT TOP 5 Estado", "Estado", e, "Endereco");
        }

        private void cmb_EstadoResponsavel_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void cmb_CidadeResponsavel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_CidadeResponsavel, "DISTINCT TOP 5 Cidade", "Cidade", e, "Endereco");
        }

        private void cmb_CidadeResponsavel_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void cmb_BairroResponsavel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_BairroResponsavel, "DISTINCT TOP 5 Bairro", "Bairro", e, "Endereco");
        }

        private void cmb_BairroResponsavel_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void cmb_RuaResponsavel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_RuaResponsavel, "DISTINCT TOP 5 Nome_Rua", "Nome_Rua", e, "Endereco");
        }

        private void cmb_RuaResponsavel_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void msk_CepResponsavel_TextChanged(object sender, EventArgs e)
        {
            string[] Endereco;
            if (msk_CepResponsavel.Text.Length == 9)
            {
                Endereco = GerenciaBanco.getListaCEP(msk_CepResponsavel.Text).ToArray();
                if (Endereco.Length > 0)
                {
                    cmb_EstadoResponsavel.Text = Endereco[0];
                    cmb_CidadeResponsavel.Text = Endereco[1];
                }
            }
        }

        private void btn_EfetuarCadastroResponsavel_Click(object sender, EventArgs e)
        {
            DateTime dataNascimento;
            int Id_Endereco = 0;

            if (!VerificaCamposCadastroReponsavel())
                return;

            if (!ValidaCampos.ValidaCPF(msk_CpfResponsavel.Text))
            {
                MessageBox.Show("CPF Invalido!");
                return;
            }

            if (!ValidaCampos.ValidaCep(msk_CepResponsavel.Text))
            {
                MessageBox.Show("CEP Invalido!");
                return;
            }

            if (!GerenciaBanco.VerificaResponsavel(msk_RgResponsavel.Text, msk_CpfResponsavel.Text))
            {
                MessageBox.Show("Houve uma duplicação no campo de RG ou CPF do responsável!");
                return;
            }

            Id_Endereco = GerenciaBanco.getId_Endereco(msk_CepResponsavel.Text, cmb_BairroResponsavel.Text, cmb_RuaResponsavel.Text, Id_Endereco);

            if (Id_Endereco == 0)
            {
                Id_Endereco = GerenciaBanco.CadastrarEndereco(cmb_EstadoResponsavel.Text, cmb_CidadeResponsavel.Text,
                msk_CepResponsavel.Text, cmb_BairroResponsavel.Text, cmb_RuaResponsavel.Text, Id_Endereco);
            }

            dataNascimento = dte_DataNascimentoResponsavel.Value.Date;

            if (GerenciaBanco.CadastrarResponsavel(Id_Endereco, txt_NomeResponsavel.Text, dataNascimento,
                char.Parse(cmb_SexoResponsavel.Text), cmb_EstadoCivilResponsavel.Text, msk_RgResponsavel.Text,
                msk_CpfResponsavel.Text, txt_EmailResponsavel.Text, msk_DddResponsavel.Text,
                msk_TelefoneResponsavel.Text, txt_ComplementoResponsavel.Text, msk_NumeroResponsavel.Text))
            {
                MessageBox.Show("Usuario cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Foi encontrado algum erro no ato de cadastrar responsável!");
            }
        }

        private void btn_CancelarCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}