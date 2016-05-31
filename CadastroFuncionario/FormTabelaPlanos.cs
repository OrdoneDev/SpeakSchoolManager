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

        private void FormTabelaPlanos_Load(object sender, EventArgs e)
        {
            dgv_TabelaPlanos.DataSource = GerenciaBanco.carregaDados("Planos", "Id_Plano as 'Código do plano', Id_Idioma as 'Código do idioma', " +
            "Nome, Aulas_Previstas as 'Nº de aulas previstas', Valor").Tables[0];
        }

        private void cmb_Idioma_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_Idioma, "DISTINCT TOP 5 Nome", "Nome", e, "SysProtected.Idiomas");
        }

        private void cmb_Idioma_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
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

            if (GerenciaBanco.getFiltro(cmb_Idioma.Text, "[Nome do idioma]", "IdiomasPlanosFiltro", "Id_Plano") != 0)
            {
                dgv_TabelaPlanos.Rows[GerenciaBanco.getFiltro(cmb_Idioma.Text, "[Nome do idioma]", "IdiomasPlanosFiltro", "Id_Plano") - 1].Selected = true;
            }
        }

        private void btn_SalvarAlteracoes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja salvar as alterações?", "Salvar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GerenciaBanco.updateDados("Planos", "Id_Plano as 'Código do plano', Id_Idioma as 'Código do idioma', " +
                "Nome, Aulas_Previstas as 'Nº de aulas previstas', Valor");
            }

            dgv_TabelaPlanos.DataSource = GerenciaBanco.carregaDados("Planos", "Id_Plano as 'Código do plano', Id_Idioma as 'Código do idioma', " +
            "Nome, Aulas_Previstas as 'Nº de aulas previstas', Valor").Tables[0];
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
