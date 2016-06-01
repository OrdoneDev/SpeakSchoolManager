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
    public partial class FormTabelaHistoricoAluno : Form
    {
        public FormTabelaHistoricoAluno()
        {
            InitializeComponent();
        }

        private void FormTabelaHistoricoAluno_Load(object sender, EventArgs e)
        {
            dgv_TabelaHistoricoAluno.DataSource = GerenciaBanco.carregaDados("Historico_Aluno", "Id_Historico as 'Código do histórico', " +
            "Id_Aluno as 'Código do aluno', Data, Descricao").Tables[0];
        }

        private void cmb_NomeAluno_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_NomeAluno, "TOP 5 Nome", "Nome", e, "SysProtected.Alunos");
        }

        private void cmb_NomeAluno_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void btn_FiltrarAluno_Click(object sender, EventArgs e)
        {
            int N = 0;
            int[] X = new int[dgv_TabelaHistoricoAluno.RowCount];
            int i = 0;
            if (cmb_NomeAluno.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo nome!");
                cmb_NomeAluno.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            cmb_NomeAluno.BackColor = System.Drawing.Color.White;

            N = GerenciaBanco.getFiltro(cmb_NomeAluno.Text, "Nome", "SysProtected.Alunos", "Id_Aluno");

            if (N > 0)
            {
                foreach (int Y in X)
                {
                    if (dgv_TabelaHistoricoAluno.Rows[i].Cells[1].Value.ToString() == N.ToString())
                    {
                        dgv_TabelaHistoricoAluno.Rows[i].Selected = true;
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
                GerenciaBanco.updateDados("Historico_Aluno", "Id_Historico as 'Código do histórico', " +
                "Id_Aluno as 'Código do aluno', Data, Descricao");
            }
            dgv_TabelaHistoricoAluno.DataSource = GerenciaBanco.carregaDados("Historico_Aluno", "Id_Historico as 'Código do histórico', " +
            "Id_Aluno as 'Código do aluno', Data, Descricao").Tables[0];
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
