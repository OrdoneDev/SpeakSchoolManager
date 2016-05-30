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
    public partial class FormHistoricoAluno : Form
    {
        public FormHistoricoAluno()
        {
            InitializeComponent();
        }

        private bool VerificaCamposCadastroHistoricoAluno()
        {
            if (!ValidaCampos.ValidaCamposGroup(group_HistoricoAluno))
                return false;

            return true;
        }

        private void msk_IdAluno_TextChanged(object sender, EventArgs e)
        {
            string NomeAluno;
            if (msk_IdAluno.Text.Length == 4)
            {
                NomeAluno = GerenciaBanco.getNome(msk_IdAluno.Text, "Alunos", "Id_Aluno");

                if (NomeAluno.Length > 0)
                {
                    cmb_NomeAluno.Text = NomeAluno;
                }
            }
            else
            {
                cmb_NomeAluno.Text = "";
            }
        }

        private void cmb_NomeAluno_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_NomeAluno, "TOP 5 Nome, Id_Aluno", "Nome", e, "SysProtected.Alunos");

            msk_IdAluno.Text = GerenciaBanco.Id_Aluno.ToString().PadLeft(4, '0');
        }

        private void cmb_NomeAluno_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void btn_SalvarHistoricoAluno_Click(object sender, EventArgs e)
        {
            DateTime dataHistorico;

            if (!VerificaCamposCadastroHistoricoAluno())
                return;

            dataHistorico = dte_DataHistoricoAluno.Value;

            if (GerenciaBanco.CadastrarHistorico(msk_IdAluno.Text, dataHistorico, txb_HistoricoAluno.Text,
                "Id_Aluno", "Historico_Aluno"))
            {
                MessageBox.Show("Histórico cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Foi encontrado um erro no cadastro de histórico");
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
