using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroFuncionario
{
    public partial class FormInscricoesTurmas : Form
    {
        FormFotoInscricao form;

        public FormInscricoesTurmas()
        {
            InitializeComponent();
            this.form = new FormFotoInscricao();
        }

        private void FormInscricoesTurmas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_EscolaDataSet.InscricoesTurmas' table. You can move, or remove it, as needed.
            this.inscricoesTurmasTableAdapter.Fill(this.dB_EscolaDataSet.InscricoesTurmas);
        }

        private void dgv_Alunos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            dgv_Alunos.RefreshEdit();
            MessageBox.Show("Insira o código da turma para vincular o aluno a uma turma!");
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

        private void dgv_Alunos_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {

                this.form.set_foto((Bitmap)dgv_Alunos.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue);
                form.Location = new Point(Form.MousePosition.X + 10, (Form.MousePosition.Y));
                this.form.Show();
            }
        }

        private void dgv_Alunos_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.form.Hide();
        }

        private void btn_MostarTodos_Click(object sender, EventArgs e)
        {
            this.inscricoesTurmasTableAdapter.Fill(this.dB_EscolaDataSet.InscricoesTurmas);
        }

        private void btn_MostrarVinculados_Click(object sender, EventArgs e)
        {
            this.inscricoesTurmasTableAdapter.FillAllVinculos(this.dB_EscolaDataSet.InscricoesTurmas);
        }

        private void btn_MostrarNaoVinculados_Click(object sender, EventArgs e)
        {
            this.inscricoesTurmasTableAdapter.FillAllNaoVinculados(this.dB_EscolaDataSet.InscricoesTurmas);
        }

        private void btn_SalvarVinculo_Click(object sender, EventArgs e)
        {
            int[] Ids_Inscricao = new int[dgv_Alunos.RowCount];
            int[] Turmas = new int[dgv_Alunos.RowCount];
            int[] TurmasAlteracoes = new int[dgv_Alunos.RowCount];
            int[] Ids_InscricaoFalse = new int[dgv_Alunos.RowCount];
            bool Cadastrar = false;
            bool Atualizar = false;

            if (MessageBox.Show("Deseja salvar os vinculos?", "Salvar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < dgv_Alunos.RowCount; ++i)
                {
                    if (dgv_Alunos.Rows[i].Cells[5].Value.ToString() == "True" && dgv_Alunos.Rows[i].Cells[6].Value.ToString().Trim().Length != 0)
                    {
                        Cadastrar = true;
                        Ids_Inscricao[i] = int.Parse(dgv_Alunos.Rows[i].Cells[0].Value.ToString());
                        Turmas[i] = int.Parse(dgv_Alunos.Rows[i].Cells[6].Value.ToString());
                    }
                    else
                    {
                        Atualizar = true;
                        Ids_InscricaoFalse[i] = int.Parse(dgv_Alunos.Rows[i].Cells[0].Value.ToString());

                        if (dgv_Alunos.Rows[i].Cells[6].Value.ToString().Trim().Length != 0)
                            TurmasAlteracoes[i] = int.Parse(dgv_Alunos.Rows[i].Cells[6].Value.ToString());
                    }
                }


                if (Cadastrar)
                {
                    GerenciaBanco.CadastrarInscricoesTurma(Ids_Inscricao, Turmas);
                }

                if (Atualizar)
                {
                    GerenciaBanco.AtualizaInscricoesTurma(Ids_InscricaoFalse, TurmasAlteracoes);
                }

                if (Cadastrar || Atualizar)
                    MessageBox.Show("Agora o aluno está vinculado a uma turma!");
                else
                    MessageBox.Show("Não foi possível vincular o aluno a uma turma!");
            }
            this.inscricoesTurmasTableAdapter.Fill(this.dB_EscolaDataSet.InscricoesTurmas);
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
