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
    public partial class FormTabelaIdiomas : Form
    {
        public FormTabelaIdiomas()
        {
            InitializeComponent();
        }

        private void FormTabelaIdiomas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_EscolaDataSet11.Idiomas' table. You can move, or remove it, as needed.
            this.idiomasTableAdapter1.Fill(this.dB_EscolaDataSet11.Idiomas);
        }
    }
}
