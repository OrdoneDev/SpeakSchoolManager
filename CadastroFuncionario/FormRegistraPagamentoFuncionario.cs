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
    public partial class FormRegistraPagamentoFuncionario : Form
    {
        public int Id_Financeiro = 0;
        float Salario;

        public FormRegistraPagamentoFuncionario()
        {
            InitializeComponent();
        }

        private bool VerificaCamposPagamentoFuncionario()
        {
            if (!ValidaCampos.ValidaCamposGroup(group_RegistraPagamentoFuncionario))
                return false;
            return true;
        }

        private void msk_IdFuncionario_TextChanged(object sender, EventArgs e)
        {
            string[] InformacoesFuncionario;
            if (msk_IdFuncionario.Text.Length == 4)
            {
                InformacoesFuncionario = GerenciaBanco.getInformacoesPagamento(int.Parse(msk_IdFuncionario.Text)).ToArray();

                if (InformacoesFuncionario.Length > 0)
                {
                    cmb_NomeFuncionario.Text = InformacoesFuncionario[0];
                    lbl_SalarioFuncionario.Text = "Salario: " + InformacoesFuncionario[1];
                    Salario = float.Parse(InformacoesFuncionario[1]);
                    Id_Financeiro = int.Parse(InformacoesFuncionario[2]);
                }
            }
            else
            {
                cmb_NomeFuncionario.Text = "";
                lbl_SalarioFuncionario.Text = "";
                Salario = 0;
                Id_Financeiro = 0;
            }
        }

        private void cmb_NomeFuncionario_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_NomeFuncionario, "TOP 5 Nome, Id_Funcionario", "Nome", e, "SysProtected.Funcionarios");

            msk_IdFuncionario.Text = GerenciaBanco.Id_Funcionario.ToString().PadLeft(4, '0');
        }

        private void cmb_NomeFuncionario_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void btn_RegistrarPagamento_Click(object sender, EventArgs e)
        {
            DateTime Data;
            int Valida = 0;

            if (!VerificaCamposPagamentoFuncionario())
                return;
            if (MessageBox.Show("Deseja registrar o pagamento?", "Salvar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Data = dtp_DataPagamento.Value;

                Valida = GerenciaBanco.VerificaPagamentoFuncionario(Valida, Id_Financeiro, Data);

                if (Valida == 0)
                {
                    if (GerenciaBanco.CadastrarPagamentoFuncionario(Id_Financeiro, Data, Salario))
                    {
                        MessageBox.Show("Pagamento registrado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível registrar o pagamento do funcionário!");
                    }
                }
                else
                {
                    MessageBox.Show("No presente més já foi registrado o pagamento deste funcionário.");
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
