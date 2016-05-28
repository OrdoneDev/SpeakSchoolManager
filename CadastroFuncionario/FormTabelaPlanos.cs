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
            ValidaCampos.GetLista(cmb_Idioma, "DISTINCT TOP 5 Nome", "Nome", e, "Idiomas");
        }

        private void cmb_Idioma_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void FormTabelaPlanos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_EscolaDataSet12.IdiomasPlanos' table. You can move, or remove it, as needed.
            this.idiomasPlanosTableAdapter.Fill(this.dB_EscolaDataSet12.IdiomasPlanos);
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

            dgv_TabelaPlanos.DataSource = GerenciaBanco.getFiltro(cmb_Idioma.Text, "[Nome do idioma]", "IdiomasPlanos");
        }
    }
}
