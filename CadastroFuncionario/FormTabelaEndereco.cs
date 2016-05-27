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
    public partial class FormTabelaEndereco : Form
    {
        public FormTabelaEndereco()
        {
            InitializeComponent();
        }

        private void FormTabelaEndereco_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_EscolaDataSet3.Endereco' table. You can move, or remove it, as needed.
            this.enderecoTableAdapter.Fill(this.dB_EscolaDataSet3.Endereco);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
