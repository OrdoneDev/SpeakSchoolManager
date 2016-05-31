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
            dgv_TabelaIdiomas.DataSource = GerenciaBanco.carregaDados("Idiomas").Tables[0];
        }

        private void btn_SalvarAlteracoes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja salvar as alterações?", "Salvar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GerenciaBanco.updateDados("Idiomas");
            }

            dgv_TabelaIdiomas.DataSource = GerenciaBanco.carregaDados("Idiomas").Tables[0];
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
