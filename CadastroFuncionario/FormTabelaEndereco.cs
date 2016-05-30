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
    public partial class FormTabelaEndereco : Form
    {
        DataSet ds;

        public FormTabelaEndereco()
        {
            InitializeComponent();
        }

        private void carregaDados()
        {
            string strCon = "Data Source=.\\MSSQLSERVER2012; Initial Catalog=DB_Escola; Trusted_Connection=Yes;";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string sql = "SELECT * FROM SysProtected.Endereco";

            // O dataAdapter é responsável pela representacao fisica do banco
            SqlDataAdapter da = new SqlDataAdapter(sql, con);

            // O objeto ds é global, ele representa uma cópia da tabela na memoria
            ds = new DataSet();

            // O 'da' (tabela 'fisica') esta preenchendo o 'ds' (tabela na memoria) com a
            // tabela chamada 'tabela'.
            da.Fill(ds);

            // mostra os dados no dataGridView (dgv) vinculando o dataSet ao dgv
            dgv_Enderecos.DataSource = ds.Tables[0];

            con.Close();

            dgv_Enderecos.Refresh();
        }

        private void updateDados()
        {
            SqlDataAdapter da;
            try
            {
                string strCon = "Data Source=.\\MSSQLSERVER2012; Initial Catalog=DB_Escola; Trusted_Connection=Yes;";
                SqlConnection con = new SqlConnection(strCon);
                string sql = "SELECT * FROM SysProtected.Endereco";

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
                MessageBox.Show("No sistema há um usuario vinculado a este endereço que desejas excluir. Porfavor exclua primeiro o usuário e retorne a esta operação");
            }
            ds.Reset();
        }

        private void FormTabelaEndereco_Load(object sender, EventArgs e)
        {
            carregaDados();
        }

        private void cmb_Estado_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_Estado, "DISTINCT TOP 5 Estado", "Estado", e, "SysProtected.Endereco");
        }

        private void cmb_Estado_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void cmb_Cidade_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_Cidade, "DISTINCT TOP 5 Cidade", "Cidade", e, "SysProtected.Endereco");
        }

        private void cmb_Cidade_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void cmb_Bairro_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_Bairro, "DISTINCT TOP 5 Bairro", "Bairro", e, "SysProtected.Endereco");
        }

        private void cmb_Bairro_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void btn_FiltrarId_Click(object sender, EventArgs e)
        {
            if (msk_IdEndereco.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo de id!");
                msk_IdEndereco.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            msk_IdEndereco.BackColor = System.Drawing.Color.White;

            dgv_Enderecos.Rows[GerenciaBanco.getFiltro(msk_IdEndereco.Text, "Id_Endereco", "SysProtected.Endereco", "Id_Endereco") - 1].Selected = true;
        }

        private void btn_FiltrarEstado_Click(object sender, EventArgs e)
        {
            if (cmb_Estado.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo estado!");
                cmb_Estado.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            cmb_Estado.BackColor = System.Drawing.Color.White;
            dgv_Enderecos.Rows[GerenciaBanco.getFiltro(cmb_Estado.Text, "Estado", "SysProtected.Endereco", "Id_Endereco") - 1].Selected = true;
        }

        private void btn_FiltrarCidade_Click(object sender, EventArgs e)
        {
            if (cmb_Cidade.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo cidade!");
                cmb_Cidade.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            cmb_Cidade.BackColor = System.Drawing.Color.White;
            dgv_Enderecos.Rows[GerenciaBanco.getFiltro(cmb_Cidade.Text, "Cidade", "SysProtected.Endereco", "Id_Endereco") - 1].Selected = true;
        }

        private void btn_FiltrarBairro_Click(object sender, EventArgs e)
        {
            if (cmb_Bairro.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo bairro!");
                cmb_Bairro.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            cmb_Bairro.BackColor = System.Drawing.Color.White;
            dgv_Enderecos.Rows[GerenciaBanco.getFiltro(cmb_Bairro.Text, "Bairro", "SysProtected.Endereco", "Id_Endereco") - 1].Selected = true;
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
