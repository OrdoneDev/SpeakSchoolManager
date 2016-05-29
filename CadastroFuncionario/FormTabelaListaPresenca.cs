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
    public partial class FormTabelaListaPresenca : Form
    {
        public FormTabelaListaPresenca()
        {
            InitializeComponent();
        }

        private void FormTabelaListaPresenca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_EscolaDataSet15.Lista_Presenca' table. You can move, or remove it, as needed.
            this.lista_PresencaTableAdapter.Fill(this.dB_EscolaDataSet15.Lista_Presenca);
        }

        private void cmb_NomeAluno_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_NomeAluno, "TOP 5 Nome", "Nome", e, "Alunos");
        }

        private void cmb_NomeAluno_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void cmb_NomeProfessor_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_NomeProfessor, "TOP 5 Nome", "Nome", e, "Funcionarios");
        }

        private void cmb_NomeProfessor_SelectedValueChanged(object sender, EventArgs e)
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

            dgv_TabelaListaPresenca.DataSource = GerenciaBanco.getFiltro(cmb_NomeAluno.Text, "[Nome do aluno]", "ListaPresencaFiltro");
        }

        private void btn_FiltrarProfessor_Click(object sender, EventArgs e)
        {
            if (cmb_NomeProfessor.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo funcionário!");
                cmb_NomeProfessor.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            cmb_NomeProfessor.BackColor = System.Drawing.Color.White;

            dgv_TabelaListaPresenca.DataSource = GerenciaBanco.getFiltro(cmb_NomeProfessor.Text, "[Nome do professor]", "ListaPresencaFiltro");
        }
    }
}
