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
        int Permissao;

        public FormTabelaIdiomas(int TagP)
        {
            InitializeComponent();
            Permissao = TagP;
        }

        private void FormTabelaIdiomas_Load(object sender, EventArgs e)
        {
            dgv_TabelaIdiomas.DataSource = GerenciaBanco.carregaDados("Idiomas", "Id_Idioma as 'Código do idioma', Nome, Descricao").Tables[0];

            if (Permissao != 1)
                dgv_TabelaIdiomas.AllowUserToDeleteRows = false;
        }

        private void dgv_TabelaIdiomas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            dgv_TabelaIdiomas.RefreshEdit();
            MessageBox.Show("O valor fornecido a esta celula está invalido!");
        }

        private void btn_SalvarAlteracoes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja salvar as alterações?", "Salvar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GerenciaBanco.updateDados("Idiomas", "Id_Idioma as 'Código do idioma', Nome, Descricao");
            }

            dgv_TabelaIdiomas.DataSource = GerenciaBanco.carregaDados("Idiomas", "Id_Idioma as 'Código do idioma', Nome, Descricao").Tables[0];
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
