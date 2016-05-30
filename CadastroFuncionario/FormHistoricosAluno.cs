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
    public partial class FormHistoricosAluno : Form
    {
        FormFotoInscricao form;

        public FormHistoricosAluno()
        {
            InitializeComponent();
            this.form = new FormFotoInscricao();
        }

        private void FormHistoricosAluno_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_EscolaDataSet9.HistoricoAluno' table. You can move, or remove it, as needed.
            this.historicoAlunoTableAdapter.Fill(this.dB_EscolaDataSet9.HistoricoAluno);
        }

        private void dgv_HistoricoAluno_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {

                this.form.set_foto((Bitmap)dgv_HistoricoAluno.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue);
                form.Location = new Point(Form.MousePosition.X + 10, (Form.MousePosition.Y));
                this.form.Show();
            }
        }

        private void dgv_HistoricoAluno_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.form.Hide();
        }

        private void cmb_Nome_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_Nome, "TOP 5 Nome, Id_Aluno", "Nome", e, "SysProtected.Alunos");
        }

        private void cmb_Nome_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void btn_FiltrarId_Click(object sender, EventArgs e)
        {
            if (msk_IdAluno.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo de id!");
                msk_IdAluno.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            msk_IdAluno.BackColor = System.Drawing.Color.White;

            dgv_HistoricoAluno.DataSource = GerenciaBanco.getFiltro(msk_IdAluno.Text, "Id_Aluno", "HistoricoAluno");
        }

        private void btn_FiltrarNome_Click(object sender, EventArgs e)
        {
            if (cmb_Nome.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo nome!");
                cmb_Nome.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            cmb_Nome.BackColor = System.Drawing.Color.White;

            dgv_HistoricoAluno.DataSource = GerenciaBanco.getFiltro(cmb_Nome.Text, "Nome", "HistoricoAluno");
        }
    }
}
