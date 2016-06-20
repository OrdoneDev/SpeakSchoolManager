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
    public partial class FormTabelaNegociações : Form
    {
        int Permissao;

        public FormTabelaNegociações(int TagP)
        {
            InitializeComponent();
            Permissao = TagP;
        }

        private void FormTabelaNegociações_Load(object sender, EventArgs e)
        {
            dgv_TabelaNegociacoes.DataSource = GerenciaBanco.carregaDados("Negociacao", "Id_Negociacao as 'Código da negocição', Id_Financeiro as 'Código do financeiro', " +
            "Id_Aluno as 'Código do aluno', Id_Plano as 'Código do plano', Parcelas as 'Nº de parcelas', Situacao").Tables[0];

            if (Permissao != 1)
                dgv_TabelaNegociacoes.AllowUserToDeleteRows = false;
        }

        private void dgv_TabelaNegociacoes_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            dgv_TabelaNegociacoes.RefreshEdit();
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

        private void cmb_Plano_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_Plano, "TOP 5 Nome", "Nome", e, "SysProtected.Planos");
        }

        private void cmb_Plano_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void btn_FiltrarAluno_Click(object sender, EventArgs e)
        {
            if (cmb_NomeAluno.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo nome!");
                cmb_NomeAluno.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            cmb_NomeAluno.BackColor = System.Drawing.Color.White;

            int Y = GerenciaBanco.getFiltro(cmb_NomeAluno.Text, "[Nome do aluno]", "NegociacaoAlunoFiltro", "Id_Negociacao");
            if (Y != 0)
            {
                int N = dgv_TabelaNegociacoes.RowCount;
                for (int I = 0; I < N; ++I)
                {
                    if (int.Parse(dgv_TabelaNegociacoes.Rows[I].Cells[0].Value.ToString()) == Y)
                    {
                        dgv_TabelaNegociacoes.Rows[I].Selected = true;
                    }
                }
            }
        }

        private void btn_FiltrarPlano_Click(object sender, EventArgs e)
        {
            if (cmb_Plano.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo plano!");
                cmb_Plano.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            cmb_Plano.BackColor = System.Drawing.Color.White;

            int Y = GerenciaBanco.getFiltro(cmb_Plano.Text, "[Nome do plano]", "NegociacaoAlunoFiltro", "Id_Negociacao");
            if (Y != 0)
            {
                int N = dgv_TabelaNegociacoes.RowCount;
                for (int I = 0; I < N; ++I)
                {
                    if (int.Parse(dgv_TabelaNegociacoes.Rows[I].Cells[0].Value.ToString()) == Y)
                    {
                        dgv_TabelaNegociacoes.Rows[I].Selected = true;
                    }
                }
            }
        }

        private void btn_SalvarAlteracoes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja salvar as alterações?", "Salvar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GerenciaBanco.updateDados("Negociacao", "Id_Negociacao as 'Código da negocição', Id_Financeiro as 'Código do financeiro', " +
            "Id_Aluno as 'Código do aluno', Id_Plano as 'Código do plano', Parcelas as 'Nº de parcelas', Situacao");
            }

            dgv_TabelaNegociacoes.DataSource = GerenciaBanco.carregaDados("Negociacao", "Id_Negociacao as 'Código da negocição', Id_Financeiro as 'Código do financeiro', " +
            "Id_Aluno as 'Código do aluno', Id_Plano as 'Código do plano', Parcelas as 'Nº de parcelas', Situacao").Tables[0];
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
