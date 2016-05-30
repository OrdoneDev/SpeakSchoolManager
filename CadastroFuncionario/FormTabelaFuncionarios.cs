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
    public partial class FormTabelaFuncionarios : Form
    {
        FormFotoInscricao form;
        
        public FormTabelaFuncionarios()
        {
            InitializeComponent();
            this.form = new FormFotoInscricao();
        }

        private void FormTabelaFuncionarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_EscolaDataSet6.Funcionarios' table. You can move, or remove it, as needed.
            this.funcionariosTableAdapter.Fill(this.dB_EscolaDataSet6.Funcionarios);
        }

        private void dgv_Funcionarios_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10 && e.RowIndex >= 0)
            {

                this.form.set_foto((Bitmap)dgv_Funcionarios.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue);
                form.Location = new Point(Form.MousePosition.X + 10, (Form.MousePosition.Y));
                this.form.Show();
            }
        }

        private void dgv_Funcionarios_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.form.Hide();
        }

        private void cmb_Nome_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_Nome, "TOP 5 Nome", "Nome", e, "SysProtected.Funcionarios");
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

            dgv_Funcionarios.DataSource = GerenciaBanco.getFiltro(msk_Id.Text, "Id_Funcionario", "SysProtected.Funcionarios");
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

            dgv_Funcionarios.DataSource = GerenciaBanco.getFiltro(cmb_Nome.Text, "Nome", "SysProtected.Funcionarios");
        }

        private void btn_FiltrarCPF_Click(object sender, EventArgs e)
        {
            if (msk_CPF.Text.Trim().Length != 14)
            {
                MessageBox.Show("Preencha o campo CPF!");
                msk_CPF.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            msk_CPF.BackColor = System.Drawing.Color.White;

            dgv_Funcionarios.DataSource = GerenciaBanco.getFiltro(msk_CPF.Text, "CPF", "SysProtected.Funcionarios");
        }

        private void btn_FIltrarCargo_Click(object sender, EventArgs e)
        {
            if (!ValidaCampos.ValidaOpcoesCmb(cmb_Cargo, "cargo"))
            {
                cmb_Cargo.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            msk_CPF.BackColor = System.Drawing.Color.White;

            dgv_Funcionarios.DataSource = GerenciaBanco.getFiltro(cmb_Cargo.Text, "Cargo", "SysProtected.Funcionarios");
        }
    }
}
