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
    public partial class FormHistoricoFuncionario : Form
    {
        public FormHistoricoFuncionario()
        {
            InitializeComponent();
        }

        private bool VerificaCamposCadastroHistoricoFuncionario()
        {
            if (!ValidaCampos.ValidaCamposGroup(group_HistoricoFuncionario))
                return false;

            return true;
        }

        private void msk_IdFuncionario_TextChanged(object sender, EventArgs e)
        {
            string NomeFuncionario;
            if (msk_IdFuncionario.Text.Length == 4)
            {
                NomeFuncionario = GerenciaBanco.getNome(msk_IdFuncionario.Text, "Funcionarios", "Id_Funcionario");

                if (NomeFuncionario.Length > 0)
                {
                    cmb_NomeFuncionario.Text = NomeFuncionario;
                }
            }
            else
            {
                cmb_NomeFuncionario.Text = "";
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

        private void btn_SalvarHistoricoFuncionario_Click(object sender, EventArgs e)
        {
            DateTime dataHistorico;

            if (!VerificaCamposCadastroHistoricoFuncionario())
                return;

            if (MessageBox.Show("Deseja salvar o histórico?", "Salvar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataHistorico = dte_DataHistoricoFuncionario.Value;

                if (GerenciaBanco.CadastrarHistorico(msk_IdFuncionario.Text, dataHistorico,
                    txb_HistoricoFuncionario.Text, "Id_Funcionario", "Historico_Funcionario"))
                {
                    MessageBox.Show("Histórico cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Foi encontrado um erro no cadastro de histórico!");
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
