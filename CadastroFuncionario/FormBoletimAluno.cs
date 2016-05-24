using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroFuncionario
{
    public partial class FormBoletimAluno : Form
    {
        int Id_Inscricao;
        float Nota1, Nota2;
        short Numero_Faltas;

        public FormBoletimAluno()
        {
            InitializeComponent();
        }

        private bool VerificaCamposBoletimAluno()
        {
            if (!ValidaCampos.ValidaCamposGroup(group_BoletimAluno))
                return false;
            return true;
        }

        private void FormBoletimAluno_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_EscolaDataSet2.AllBoletim' table. You can move, or remove it, as needed.
            this.allBoletimTableAdapter.Fill(this.dB_EscolaDataSet2.AllBoletim);
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
            ValidaCampos.GetLista(cmb_NomeAluno, "TOP 5 Nome, Id_Aluno", "Nome", e, "Alunos");

            msk_IdAluno.Text = GerenciaBanco.Id_Aluno.ToString().PadLeft(4, '0');
        }

        private void cmb_NomeAluno_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void dgv_BoletimAluno_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            Regex Valida = new Regex(@"(^[0-9]{1}\.[0-9]{1})|(^[0-9]0{1})|(^[0-9]{1})");

            if (!Valida.IsMatch(e.Value.ToString()))
            {
                dgv_BoletimAluno.RefreshEdit();
                MessageBox.Show("Insira valores númericos entre 0 e 10!");
            }
        }

        private void dgv_BoletimAluno_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        } 

        private void btn_ConsultarBoletim_Click(object sender, EventArgs e)
        {
            if (!VerificaCamposBoletimAluno())
                return;

            dgv_BoletimAluno.DataSource = GerenciaBanco.getBoletim(int.Parse(msk_IdAluno.Text));
        }

        private void btn_SalvarAlteracoes_Click(object sender, EventArgs e)
        {
            if (!VerificaCamposBoletimAluno())
                return;

            Id_Inscricao = Convert.ToInt32(dgv_BoletimAluno.CurrentRow.Cells[0].Value);

            if (dgv_BoletimAluno.CurrentRow.Cells[5].Value.ToString().Length > 0)
                Nota1 = float.Parse(dgv_BoletimAluno.CurrentRow.Cells[5].Value.ToString());
            else
                Nota1 = 0;

            if (Nota1 > 10 || Nota1 < 0)
            {
                MessageBox.Show("A nota da primeira prova deve ser maior que 0 e menor que 10!");
                dgv_BoletimAluno.CurrentRow.Cells[5].Value = 0;
                return;
            }

            if (dgv_BoletimAluno.CurrentRow.Cells[6].Value.ToString().Length > 0)
                Nota2 = float.Parse(dgv_BoletimAluno.CurrentRow.Cells[6].Value.ToString());
            else
                Nota2 = 0;

            if (Nota2 > 10 || Nota2 < 0)
            {
                MessageBox.Show("A nota da segunda prova deve ser maior que 0 e menor que 10!");
                dgv_BoletimAluno.CurrentRow.Cells[6].Value = 0;
                return;
            }

            if (dgv_BoletimAluno.CurrentRow.Cells[8].Value.ToString().Length > 0)
                Numero_Faltas = short.Parse(dgv_BoletimAluno.CurrentRow.Cells[8].Value.ToString());
            else
                Numero_Faltas = 0;

            if (GerenciaBanco.AtualizaBoletim(Id_Inscricao, Nota1, Nota2, Numero_Faltas))
            {
                MessageBox.Show("O boletim foi atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possível atualizar os dados do boletim!");
            }

            dgv_BoletimAluno.DataSource = GerenciaBanco.getBoletim(int.Parse(msk_IdAluno.Text));
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
