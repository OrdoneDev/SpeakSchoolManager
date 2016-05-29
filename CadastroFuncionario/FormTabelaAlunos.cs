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
    public partial class FormTabelaAlunos : Form
    {
        FormFotoInscricao form;
        
        public FormTabelaAlunos()
        {
            InitializeComponent();
            this.form = new FormFotoInscricao();
        }

        private void FormTabelaAlunos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_EscolaDataSet10.Alunos' table. You can move, or remove it, as needed.
            this.alunosTableAdapter.Fill(this.dB_EscolaDataSet10.Alunos);
        }

        private void dgv_Alunos_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11 && e.RowIndex >= 0)
            {
                this.form.set_foto((Bitmap)dgv_Alunos.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue);
                form.Location = new Point(Form.MousePosition.X + 10, (Form.MousePosition.Y));
                this.form.Show();
            }
        }

        private void dgv_Alunos_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.form.Hide();
        }

        private void cmb_Nome_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_Nome, "TOP 5 Nome", "Nome", e, "Alunos");
        }

        private void cmb_Nome_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void btn_FiltrarId_Click(object sender, EventArgs e)
        {
            if (msk_Id.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo de id!");
                msk_Id.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            msk_Id.BackColor = System.Drawing.Color.White;

            dgv_Alunos.DataSource = GerenciaBanco.getFiltro(msk_Id.Text, "Id_Aluno", "SysProtected.Alunos");
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

            dgv_Alunos.DataSource = GerenciaBanco.getFiltro(cmb_Nome.Text, "Nome", "SysProtected.Alunos");
        }
    }
}
