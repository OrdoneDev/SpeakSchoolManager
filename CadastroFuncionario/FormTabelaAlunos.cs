using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        int Permissao;
        
        public FormTabelaAlunos(int TagP)
        {
            InitializeComponent();
            this.form = new FormFotoInscricao();
            Permissao = TagP;
        }

        private void FormTabelaAlunos_Load(object sender, EventArgs e)
        {
            dgv_Alunos.DataSource = GerenciaBanco.carregaDados("Alunos", "Id_Aluno as 'Código do aluno', Id_Responsavel as 'Código do responsável', " +
            "Id_Endereco as 'Código do endereço', Nome, DataNascimento as 'Data de nascimento', Sexo, Estado_Civil as 'Estado civil', " +
            "RG, CPF, Status_Aluno as 'Status', Email, Foto, DDD, Telefone, Historico_Escolar as 'Histórico escolar', Complemento, Numero as 'Nº'").Tables[0];

            foreach (DataGridViewColumn column in dgv_Alunos.Columns)
            {
                if (column is DataGridViewImageColumn)
                {
                    (column as DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    (column as DataGridViewImageColumn).Description = "Zoomed";
                }

                if (Permissao != 1)
                    dgv_Alunos.AllowUserToDeleteRows = false;
            }
        }

        private void dgv_Alunos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            dgv_Alunos.RefreshEdit();
            MessageBox.Show("O valor fornecido a esta celula está invalido!");
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
            ValidaCampos.GetLista(cmb_Nome, "TOP 5 Nome", "Nome", e, "SysProtected.Alunos");
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

            if (GerenciaBanco.getFiltro(msk_Id.Text, "Id_Aluno", "SysProtected.Alunos", "Id_Aluno") != 0)
            {
                dgv_Alunos.Rows[GerenciaBanco.getFiltro(msk_Id.Text, "Id_Aluno", "SysProtected.Alunos", "Id_Aluno") - 1].Selected = true;
            }
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

            if (GerenciaBanco.getFiltro(cmb_Nome.Text, "Nome", "SysProtected.Alunos", "Id_Aluno") != 0)
            {
                dgv_Alunos.Rows[GerenciaBanco.getFiltro(cmb_Nome.Text, "Nome", "SysProtected.Alunos", "Id_Aluno") - 1].Selected = true;
            }
        }

        private void btn_SalvarAlteracoes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja salvar as alterações?", "Salvar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GerenciaBanco.updateDados("Alunos", "Id_Aluno as 'Código do aluno', Id_Responsavel as 'Código do responsável', " +
                "Id_Endereco as 'Código do endereço', Nome, DataNascimento as 'Data de nascimento', Sexo, Estado_Civil as 'Estado civil', " +
                "RG, CPF, Status_Aluno as 'Status', Email, Foto, DDD, Telefone, Historico_Escolar as 'Histórico escolar', Complemento, Numero as 'Nº'");
            }

            dgv_Alunos.DataSource = GerenciaBanco.carregaDados("Alunos", "Id_Aluno as 'Código do aluno', Id_Responsavel as 'Código do responsável', " +
            "Id_Endereco as 'Código do endereço', Nome, DataNascimento as 'Data de nascimento', Sexo, Estado_Civil as 'Estado civil', " +
            "RG, CPF, Status_Aluno as 'Status', Email, Foto, DDD, Telefone, Historico_Escolar as 'Histórico escolar', Complemento, Numero as 'Nº'").Tables[0];
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
