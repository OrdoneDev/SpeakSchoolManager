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
    public partial class FormAdquirirCursoAluno : Form
    {
        public FormAdquirirCursoAluno()
        {
            InitializeComponent();
        }

        private bool VerificaCamposAdquirirCursoAluno()
        {
            if (!ValidaCampos.ValidaCamposGroup(group_ArquisicaoCurso))
                return false;

            return true;
        }

        private void msk_IdPlano_TextChanged(object sender, EventArgs e)
        {
            string NomePlano;
            if (msk_IdPlano.Text.Length == 4)
            {
                NomePlano = GerenciaBanco.getNome(msk_IdPlano.Text, "Planos", "Id_Plano");

                if (NomePlano.Length > 0)
                {
                    cmb_NomePlano.Text = NomePlano;
                }
            }
            else
            {
                cmb_NomePlano.Text = "";
            }
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

        private void cmb_NomePlano_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_NomePlano, "TOP 5 Nome, Id_Plano", "Nome", e, "SysProtected.Planos");

            msk_IdPlano.Text = GerenciaBanco.Id_Plano.ToString().PadLeft(4, '0');
        }

        private void cmb_NomePlano_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void btn_ConfirmarCompra_Click(object sender, EventArgs e)
        {
            string Plano, Aluno;
            byte Situacao = 0;
            int Id_Financeiro = 0;
            string[] Financeiro;

            if (!VerificaCamposAdquirirCursoAluno())
                return;

            Financeiro = GerenciaBanco.getFinanceiroEmpresa().ToArray();

            if (Financeiro.Length > 0)
                Id_Financeiro = int.Parse(Financeiro[3]);

            Plano = GerenciaBanco.getNome(msk_IdPlano.Text, "Planos", "Id_Plano");
            Aluno = GerenciaBanco.getNome(msk_IdAluno.Text, "Alunos", "Id_Aluno");

            if (Id_Financeiro == 0)
            {
                MessageBox.Show("Os dados financeiros da empresa não estão cadastrados, porfavor efetue o cadastro do financeiro da empresa!");
                return;
            }

            if (Plano.Length == 0)
            {
                MessageBox.Show("O plano informado não está cadastrado no sistema!");
                return;
            }

            if (Aluno.Length == 0)
            {
                MessageBox.Show("O aluno informado não está cadastrado no sistema!");
                return;
            }

            if (!GerenciaBanco.VerificaAquisicao(int.Parse(msk_IdAluno.Text), int.Parse(msk_IdPlano.Text)))
            {
                MessageBox.Show("Houve uma duplicação nas negociações!");
                return;
            }

            if (rdb_APagar.Checked)
            {
                Situacao = 0;
            }
            else if (rdb_Pago.Checked && cmb_Parcelas.Text == "1")
            {
                Situacao = 1;
            }

            if (GerenciaBanco.CadastrarAquisicaoCursoAluno(Id_Financeiro, int.Parse(msk_IdPlano.Text), int.Parse(msk_IdAluno.Text), short.Parse(cmb_Parcelas.Text), Situacao))
            {
                MessageBox.Show("O plano foi adquirido com sucesso!");
            }
            else
            {
                MessageBox.Show("Nâo foi possível efetuar a aquisição do plano para o aluno!");
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
