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
    public partial class FormTabelaBoletins : Form
    {
        public FormTabelaBoletins()
        {
            InitializeComponent();
        }

        private void FormTabelaBoletins_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'escola_PrincipalDataSet5.BoletinsAlunoFiltro' table. You can move, or remove it, as needed.
            this.boletinsAlunoFiltroTableAdapter.Fill(this.escola_PrincipalDataSet5.BoletinsAlunoFiltro);
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
            if (cmb_NomeAluno.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo aluno!");
                cmb_NomeAluno.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            cmb_NomeAluno.BackColor = System.Drawing.Color.White;

            dgv_TabelaBoletins.DataSource = GerenciaBanco.getFiltro(cmb_NomeAluno.Text, "Nome", "BoletinsAlunoFiltro");
        }

        private void btn_MostrarTodos_Click(object sender, EventArgs e)
        {
            dgv_TabelaBoletins.DataSource = GerenciaBanco.getFiltro("0", "0", "BoletinsAlunoFiltro");
        }
    }
}
