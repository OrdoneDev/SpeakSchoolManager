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
            dgv_TabelaListaPresenca.DataSource = GerenciaBanco.carregaDados("Lista_Presenca", "Id_Presenca as 'Código da lista de presença', " +
            "Id_Inscricao_Turma as 'Código da inscrição turma', Chamada, Data").Tables[0];
        }

        private void dgv_TabelaListaPresenca_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            dgv_TabelaListaPresenca.RefreshEdit();
            MessageBox.Show("O valor fornecido a esta celula está invalido!");
        }

        private void cmb_NomeAluno_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_NomeAluno, "TOP 5 Nome", "Nome", e, "SysProtected.Alunos");
        }

        private void cmb_NomeAluno_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void cmb_NomeProfessor_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_NomeProfessor, "TOP 5 Nome", "Nome", e, "SysProtected.Funcionarios");
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

            if (GerenciaBanco.getFiltro(cmb_NomeAluno.Text, "[Nome do aluno]", "ListaPresencaFiltro", "Id_Presenca") != 0)
            {
                dgv_TabelaListaPresenca.Rows[GerenciaBanco.getFiltro(cmb_NomeAluno.Text, "[Nome do aluno]", "ListaPresencaFiltro", "Id_Presenca") - 1].Selected = true;
            }
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

            if (GerenciaBanco.getFiltro(cmb_NomeProfessor.Text, "[Nome do professor]", "ListaPresencaFiltro", "Id_Presenca") != 0)
            {
                dgv_TabelaListaPresenca.Rows[GerenciaBanco.getFiltro(cmb_NomeProfessor.Text, "[Nome do professor]", "ListaPresencaFiltro", "Id_Presenca") - 1].Selected = true;
            }
        }

        private void btn_SalvarAlteracoes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja salvar as alterações?", "Salvar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GerenciaBanco.updateDados("Lista_Presenca", "Id_Presenca as 'Código da lista de presença', " +
            "Id_Inscricao_Turma as 'Código da inscrição turma', Chamada, Data");
            }

            dgv_TabelaListaPresenca.DataSource = GerenciaBanco.carregaDados("Lista_Presenca", "Id_Presenca as 'Código da lista de presença', " +
            "Id_Inscricao_Turma as 'Código da inscrição turma', Chamada, Data").Tables[0];
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
