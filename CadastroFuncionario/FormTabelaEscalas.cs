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
    public partial class FormTabelaEscalas : Form
    {
        public FormTabelaEscalas()
        {
            InitializeComponent();
        }

        private void FormTabelaEscalas_Load(object sender, EventArgs e)
        {
            dgv_TabelaEscalas.DataSource = GerenciaBanco.carregaDados("Escalas").Tables[0];
        }

        private void cmb_NomeFuncionario_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_NomeFuncionario, "TOP 5 Nome", "Nome", e, "SysProtected.Funcionarios");
        }

        private void cmb_NomeFuncionario_SelectedValueChanged(object sender, EventArgs e)
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

            if (GerenciaBanco.getFiltro(cmb_NomeFuncionario.Text, "Nome", "EscalasFuncionarioFiltro", "Id_Escala") != 0)
            {
                dgv_TabelaEscalas.Rows[GerenciaBanco.getFiltro(cmb_NomeFuncionario.Text, "Nome", "EscalasFuncionarioFiltro", "Id_Escala") - 1].Selected = true;
            }
        }

        private void btn_SalvarAlteracoes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja salvar as alterações?", "Salvar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GerenciaBanco.updateDados("Escalas");
            }

            dgv_TabelaEscalas.DataSource = GerenciaBanco.carregaDados("Escalas").Tables[0];
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
