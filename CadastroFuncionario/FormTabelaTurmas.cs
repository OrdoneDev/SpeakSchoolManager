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
    public partial class FormTabelaTurmas : Form
    {
        public FormTabelaTurmas()
        {
            InitializeComponent();
        }

        private void FormTabelaTurmas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_EscolaDataSet13.Turmas' table. You can move, or remove it, as needed.
            this.turmasTableAdapter.Fill(this.dB_EscolaDataSet13.Turmas);

        }

        private void cmb_NomeFuncionario_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_NomeFuncionario, "TOP 5 Nome", "Nome", e, "SysProtected.Funcionarios");
        }

        private void cmb_NomeFuncionario_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void cmb_NomePlano_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_NomePlano, "DISTINCT TOP 5 Nome", "Nome", e, "SysProtected.Planos");
        }

        private void cmb_NomePlano_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void btn_FiltrarFuncionario_Click(object sender, EventArgs e)
        {
            if (cmb_NomeFuncionario.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo funcionário!");
                cmb_NomeFuncionario.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            cmb_NomeFuncionario.BackColor = System.Drawing.Color.White;

            dgv_TabelaTurmas.DataSource = GerenciaBanco.getFiltro(cmb_NomeFuncionario.Text, "[Nome do funcionário]", "TurmasFiltro");
        }

        private void btn_FiltrarPlano_Click(object sender, EventArgs e)
        {
            if (cmb_NomePlano.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo plano!");
                cmb_NomePlano.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            cmb_NomePlano.BackColor = System.Drawing.Color.White;

            dgv_TabelaTurmas.DataSource = GerenciaBanco.getFiltro(cmb_NomePlano.Text, "[Nome do plano]", "TurmasFiltro");
        }

        private void btn_MostrarTodos_Click(object sender, EventArgs e)
        {
            dgv_TabelaTurmas.DataSource = GerenciaBanco.getFiltro("0", "0", "TurmasFiltro");
        }
    }
}
