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
    public partial class FormTabelaInscricoesTurmas : Form
    {
        public FormTabelaInscricoesTurmas()
        {
            InitializeComponent();
        }

        private void FormTabelaInscricoesTurmas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_EscolaDataSet14.Inscricoes_Turmas' table. You can move, or remove it, as needed.
            this.inscricoes_TurmasTableAdapter.Fill(this.dB_EscolaDataSet14.Inscricoes_Turmas);
        }

        private void cmb_NomeAluno_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_NomeAluno, "TOP 5 Nome", "Nome", e, "Alunos");
        }

        private void cmb_NomeAluno_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void cmb_NomeFuncionario_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_NomeFuncionario, "TOP 5 Nome", "Nome", e, "Funcionarios");
        }

        private void cmb_NomeFuncionario_SelectedValueChanged(object sender, EventArgs e)
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

            dgv_TabelaInscricoesTurmas.DataSource = GerenciaBanco.getFiltro(cmb_NomeAluno.Text, "[Nome do aluno]", "InscricoesTurmasFiltro");
        }

        private void btn_FiltrarFuncionario_Click(object sender, EventArgs e)
        {
            if (cmb_NomeFuncionario.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo nome!");
                cmb_NomeFuncionario.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            cmb_NomeFuncionario.BackColor = System.Drawing.Color.White;

            dgv_TabelaInscricoesTurmas.DataSource = GerenciaBanco.getFiltro(cmb_NomeFuncionario.Text, "[Nome do funcionário]", "InscricoesTurmasFiltro");
        }

        private void btn_MostrarTodos_Click(object sender, EventArgs e)
        {
            dgv_TabelaInscricoesTurmas.DataSource = GerenciaBanco.getFiltro("0", "0", "InscricoesTurmasFiltro");
        }
    }
}
