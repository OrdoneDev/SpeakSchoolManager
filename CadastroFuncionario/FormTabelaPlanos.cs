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
    public partial class FormTabelaPlanos : Form
    {
        public FormTabelaPlanos()
        {
            InitializeComponent();
        }

        private void cmb_Idioma_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_Idioma, "DISTINCT TOP 5 Nome", "Nome", e, "SysProtected.Idiomas");
        }

        private void cmb_Idioma_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void FormTabelaPlanos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'escola_PrincipalDataSet3.IdiomasPlanosFiltro' table. You can move, or remove it, as needed.
            this.idiomasPlanosFiltroTableAdapter.Fill(this.escola_PrincipalDataSet3.IdiomasPlanosFiltro);
        }

        private void btn_FiltrarIdioma_Click(object sender, EventArgs e)
        {
            if (cmb_Idioma.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo idioma!");
                cmb_Idioma.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            cmb_Idioma.BackColor = System.Drawing.Color.White;

            dgv_TabelaPlanos.DataSource = GerenciaBanco.getFiltro(cmb_Idioma.Text, "[Nome do idioma]", "IdiomasPlanosFiltro");
        }

        private void btn_MostrarTodos_Click(object sender, EventArgs e)
        {
            dgv_TabelaPlanos.DataSource = GerenciaBanco.getFiltro("0", "0", "IdiomasPlanosFiltro");
        }
    }
}
