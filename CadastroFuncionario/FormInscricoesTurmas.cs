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
    public partial class FormInscricoesTurmas : Form
    {
        public FormInscricoesTurmas()
        {
            InitializeComponent();
        }

        private bool VerificaCamposInscricoesTurmas()
        {
            if (!ValidaCampos.ValidaCamposGroup(group_InscricoesTurmas))
                return false;

            return true;
        }

        private void FormInscricoesTurmas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_EscolaDataSet.InscricoesTurmas' table. You can move, or remove it, as needed.
            this.inscricoesTurmasTableAdapter.Fill(this.dB_EscolaDataSet.InscricoesTurmas);

        }

        private void msk_IdTurma_TextChanged(object sender, EventArgs e)
        {
            string[] Turma;
            if (msk_IdTurma.Text.Length == 4)
            {
                Turma = GerenciaBanco.getTurma(int.Parse(msk_IdTurma.Text)).ToArray();

                if (Turma.Length > 0)
                {
                    lbl_NomeCurso.Text = Turma[0];
                    lbl_NomeProfessor.Text = Turma[1];
                    lbl_NSala.Text = Turma[2];
                    lbl_HoraEntrada.Text = Turma[3];
                    lbl_HoraSaida.Text = Turma[4];
                }
            }
            else
            {
                lbl_NomeCurso.Text = "";
                lbl_NomeProfessor.Text = "";
                lbl_NSala.Text = "";
                lbl_HoraEntrada.Text = "";
                lbl_HoraSaida.Text = "";
            }
        }

        private void btn_SalvarVinculo_Click(object sender, EventArgs e)
        {
            int[] Ids_Inscricao = new int[dgv_Alunos.RowCount];
            int[] Ids_InscricaoFalse = new int[dgv_Alunos.RowCount];
            bool Cadastrar = false;
            bool Atualizar = false;

            if (!VerificaCamposInscricoesTurmas())
                return;

            for (int i = 0; i < dgv_Alunos.RowCount; ++i)
            {
                if (dgv_Alunos.Rows[i].Cells[5].Value.ToString() == "True")
                {
                    Cadastrar = true;
                    Ids_Inscricao[i] = int.Parse(dgv_Alunos.Rows[i].Cells[0].Value.ToString());
                }
                else
                {
                    Atualizar = true;
                    Ids_InscricaoFalse[i] = int.Parse(dgv_Alunos.Rows[i].Cells[0].Value.ToString());
                }
            }


            if (Cadastrar)
            {
                GerenciaBanco.CadastrarInscricoesTurma(Ids_Inscricao, int.Parse(msk_IdTurma.Text));
            }

            if (Atualizar)
            {
                GerenciaBanco.AtualizaInscricoesTurma(Ids_InscricaoFalse, int.Parse(msk_IdTurma.Text));
            }

            if (Cadastrar || Atualizar)
                MessageBox.Show("Agora o aluno está vinculado a uma turma!");
            else
                MessageBox.Show("Não foi possível vincular o aluno a uma turma!");

            this.inscricoesTurmasTableAdapter.Fill(this.dB_EscolaDataSet.InscricoesTurmas);
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
