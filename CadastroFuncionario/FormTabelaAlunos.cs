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
        DataSet ds;
        
        public FormTabelaAlunos()
        {
            InitializeComponent();
            this.form = new FormFotoInscricao();
        }

        private void carregaDados()
        {
            string strCon = "Data Source=.\\MSSQLSERVER2012; Initial Catalog=DB_Escola; Trusted_Connection=Yes;";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string sql = "SELECT * FROM SysProtected.Alunos";

            // O dataAdapter é responsável pela representacao fisica do banco
            SqlDataAdapter da = new SqlDataAdapter(sql, con);

            // O objeto ds é global, ele representa uma cópia da tabela na memoria
            ds = new DataSet();

            // O 'da' (tabela 'fisica') esta preenchendo o 'ds' (tabela na memoria) com a
            // tabela chamada 'tabela'.
            da.Fill(ds);

            // mostra os dados no dataGridView (dgv) vinculando o dataSet ao dgv
            dgv_Alunos.DataSource = ds.Tables[0];

            con.Close();

            dgv_Alunos.Refresh();
        }

        private void updateDados()
        {
            SqlDataAdapter da;
            try
            {
                string strCon = "Data Source=.\\MSSQLSERVER2012; Initial Catalog=DB_Escola; Trusted_Connection=Yes;";
                SqlConnection con = new SqlConnection(strCon);
                string sql = "SELECT * FROM SysProtected.Alunos";

                // O dataAdapter é responsável pela representacao fisica do banco
                da = new SqlDataAdapter(sql, con);
                con.Open();

                // Cria o código do update dentro do Adapter
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);

                // O 'da' (tabela 'fisica') esta atualizando os dados a partir do 'ds'.
                da.Update(ds);
            }
            catch (Exception)
            {
                MessageBox.Show("No sistema há vinculos com este dado que deseja remover. Porfavor remova os dados vinculados e retorne a este procedimento!");
            }
            ds.Reset();
        }

        private void FormTabelaAlunos_Load(object sender, EventArgs e)
        {
            carregaDados();
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
            dgv_Alunos.Rows[GerenciaBanco.getFiltro(msk_Id.Text, "Id_Aluno", "SysProtected.Alunos", "Id_Aluno") - 1].Selected = true;
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
            dgv_Alunos.Rows[GerenciaBanco.getFiltro(cmb_Nome.Text, "Nome", "SysProtected.Alunos", "Id_Aluno") - 1].Selected = true;
        }

        private void btn_SalvarAlteracoes_Click(object sender, EventArgs e)
        {
            updateDados();
            carregaDados();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
