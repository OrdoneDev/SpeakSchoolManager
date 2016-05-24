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
    public partial class FormCadastroFinanceiroEmpresa : Form
    {
        public FormCadastroFinanceiroEmpresa()
        {
            string[] lista;

            InitializeComponent();

            lista = GerenciaBanco.getFinanceiroEmpresa().ToArray();

            if (lista.Length > 0)
            {
                cmb_BancoEmpresa.Text = lista[0];
                txt_AgenciaEmpresa.Text = lista[1];
                txt_ContaEmpresa.Text = lista[2];
            }
        }

        private bool VerificaCamposCadastroFinanceiroEmpresa()
        {
            if (!ValidaCampos.ValidaCamposGroup(group_FinanceiroEmpresa))
                return false;
            return true;
        }

        private void btn_SalvarFinanceiroEmpresa_Click(object sender, EventArgs e)
        {
            if (!VerificaCamposCadastroFinanceiroEmpresa())
                return;

            if (GerenciaBanco.CadastrarFinanceiro(cmb_BancoEmpresa.Text, int.Parse(txt_AgenciaEmpresa.Text),
                int.Parse(txt_ContaEmpresa.Text)))
            {
                MessageBox.Show("Financeiro Cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possivel efetuar o cadastro do financeiro!");
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
