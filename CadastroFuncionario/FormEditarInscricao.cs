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
    public partial class FormEditarInscricao : Form
    {
        public string Status;
        public int Id_Inscricao;

        public FormEditarInscricao()
        {
            InitializeComponent();
        }

        private bool VerificaCamposEditarInscricao()
        {
            if (!ValidaCampos.ValidaCamposGroup(group_InscricaoAluno))
                return false;
            return true;
        }

        private void FormEditarInscricao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_EscolaDataSet5.AllInscricoes' table. You can move, or remove it, as needed.
            this.allInscricoesTableAdapter.Fill(this.dB_EscolaDataSet5.AllInscricoes);
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

        private void dgv_InscricaoAluno_SelectionChanged(object sender, EventArgs e)
        {
            Status = (dgv_InscricaoAluno.CurrentRow.Cells[5].Value).ToString();
            Id_Inscricao = Convert.ToInt32(dgv_InscricaoAluno.CurrentRow.Cells[0].Value);

            if (Status == "Inátivo")
                rdb_Inativo.Checked = true;
            else
                rdb_Ativo.Checked = true;
        }

        private void btn_ConsultarInscricao_Click(object sender, EventArgs e)
        {
            if (!VerificaCamposEditarInscricao())
                return;

            dgv_InscricaoAluno.DataSource = GerenciaBanco.getInscricoes(int.Parse(msk_IdAluno.Text));
        }

        private void btn_SalvarAlteracao_Click(object sender, EventArgs e)
        {
            byte x;

            if (!VerificaCamposEditarInscricao())
                return;

            if (rdb_Inativo.Checked)
            {
                Status = "Inátivo";
                x = 0;
            }
            else
            {
                Status = "Ativo";
                x = 1;
            }

            if (GerenciaBanco.AtualizaInscricao(Id_Inscricao, x))
            {
                MessageBox.Show("Inscrição atualizada com sucesso!");
            }
            else
            {
                MessageBox.Show("Houve um erro na hora de atualizar a inscrição!");
            }

            dgv_InscricaoAluno.DataSource = GerenciaBanco.getInscricoes(int.Parse(msk_IdAluno.Text));
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
