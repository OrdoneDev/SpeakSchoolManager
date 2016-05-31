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
    public partial class FormCadastroFinanceiroFuncionario : Form
    {
        public FormCadastroFinanceiroFuncionario()
        {
            InitializeComponent();
        }

        private bool VerificaCamposCadastroFinanceiroFuncionario ()
        {
            if (!ValidaCampos.ValidaCamposGroup(group_CadastroFinanceiroFuncionario))
                return false;

            return true;
        }

        private void cmb_BancoFuncionario_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_BancoFuncionario, "DISTINCT TOP 5 Banco", "Banco", e, "SysProtected.Financeiro");
        }

        private void cmb_BancoFuncionario_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void btn_FinalizarCadastroFuncionario_Click(object sender, EventArgs e)
        {
            FormCadastroFuncionario form = new FormCadastroFuncionario();

            if (!VerificaCamposCadastroFinanceiroFuncionario())
                return;

            if (MessageBox.Show("Deseja concluir o cadastro?", "Salvar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (GerenciaBanco.VerificaFinanceiro(cmb_BancoFuncionario.Text, int.Parse(txt_AgenciaFuncionario.Text),
                    int.Parse(txt_ContaFuncionario.Text)))
                {
                    ValidaCampos.banco = cmb_BancoFuncionario.Text;
                    ValidaCampos.agencia = int.Parse(txt_AgenciaFuncionario.Text);
                    ValidaCampos.conta = int.Parse(txt_ContaFuncionario.Text);
                    ValidaCampos.dataDeposito = dte_DataDepositoFuncionario.Value.Date;
                    ValidaCampos.Continua = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Estes dados financeiro já estão cadastrados em outro funcionário!");
                    return;
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
