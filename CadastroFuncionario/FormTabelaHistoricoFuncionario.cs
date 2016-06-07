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
    public partial class FormTabelaHistoricoFuncionario : Form
    {
        FormPrincipal Permissao = new FormPrincipal();

        public FormTabelaHistoricoFuncionario()
        {
            InitializeComponent();
        }

        private void FormTabelaHistoricoFuncionario_Load(object sender, EventArgs e)
        {
            dgv_TabelaHistoricoFuncionario.DataSource = GerenciaBanco.carregaDados("Historico_Funcionario", "Id_Historico as 'Código do histórico', " +
            "Id_Funcionario as 'Código do funcionário', Data, Descricao").Tables[0];

            if (Permissao.TagP != 1)
                dgv_TabelaHistoricoFuncionario.AllowUserToDeleteRows = false;
        }

        private void dgv_TabelaHistoricoFuncionario_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            dgv_TabelaHistoricoFuncionario.RefreshEdit();
            MessageBox.Show("O valor fornecido a esta celula está invalido!");
        }

        private void cmb_NomeFuncionario_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_NomeFuncionario, "TOP 5 Nome", "Nome", e, "SysProtected.Funcionarios");
        }

        private void cmb_NomeFuncionario_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void btn_FiltrarFuncionario_Click(object sender, EventArgs e)
        {
            int N = 0;
            int[] X = new int[dgv_TabelaHistoricoFuncionario.RowCount];
            int i = 0;
            if (cmb_NomeFuncionario.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo nome!");
                cmb_NomeFuncionario.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            cmb_NomeFuncionario.BackColor = System.Drawing.Color.White;

            N = GerenciaBanco.getFiltro(cmb_NomeFuncionario.Text, "Nome", "SysProtected.Funcionarios", "Id_Funcionario");

            if (N > 0)
            {
                foreach (int Y in X)
                {
                    if (dgv_TabelaHistoricoFuncionario.Rows[i].Cells[1].Value.ToString() == N.ToString())
                    {
                        dgv_TabelaHistoricoFuncionario.Rows[i].Selected = true;
                        break;
                    }
                    ++i;
                }
            }
        }

        private void btn_SalvarAlteracoes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja salvar as alterações?", "Salvar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GerenciaBanco.updateDados("Historico_Funcionario", "Id_Historico as 'Código do histórico', " +
                "Id_Funcionario as 'Código do funcionário', Data, Descricao");
            }
            dgv_TabelaHistoricoFuncionario.DataSource = GerenciaBanco.carregaDados("Historico_Funcionario", "Id_Historico as 'Código do histórico', " +
            "Id_Funcionario as 'Código do funcionário', Data, Descricao").Tables[0];
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
