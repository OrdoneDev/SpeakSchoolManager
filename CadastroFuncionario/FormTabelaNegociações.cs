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
    public partial class FormTabelaNegociações : Form
    {
        public FormTabelaNegociações()
        {
            InitializeComponent();
        }

        private void FormTabelaNegociações_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'escola_PrincipalDataSet.Negociacao' table. You can move, or remove it, as needed.
            this.negociacaoTableAdapter.Fill(this.escola_PrincipalDataSet.Negociacao);
        }

        private void cmb_NomeAluno_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_NomeAluno, "TOP 5 Nome", "Nome", e, "SysProtected.Alunos");
        }

        private void cmb_NomeAluno_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void cmb_Plano_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_Plano, "TOP 5 Nome", "Nome", e, "SysProtected.Planos");
        }

        private void cmb_Plano_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void btn_FiltrarAluno_Click(object sender, EventArgs e)
        {
            if (cmb_NomeAluno.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo nome!");
                cmb_NomeAluno.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            cmb_NomeAluno.BackColor = System.Drawing.Color.White;

            dgv_TabelaNegociacoes.DataSource = GerenciaBanco.getFiltro(cmb_NomeAluno.Text, "[Nome do aluno]", "NegociacaoAlunoFiltro");
        }

        private void btn_FiltrarPlano_Click(object sender, EventArgs e)
        {
            if (cmb_Plano.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo plano!");
                cmb_Plano.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            cmb_Plano.BackColor = System.Drawing.Color.White;

            dgv_TabelaNegociacoes.DataSource = GerenciaBanco.getFiltro(cmb_Plano.Text, "[Nome do plano]", "NegociacaoAlunoFiltro");
        }

        private void btn_MostrarTodos_Click(object sender, EventArgs e)
        {
            dgv_TabelaNegociacoes.DataSource = GerenciaBanco.getFiltro("0", "0", "NegociacaoAlunoFiltro");
        }
    }
}
