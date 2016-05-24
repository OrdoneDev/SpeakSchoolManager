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
    public partial class FormMensalidadesAlunos : Form
    {
        public string Situacao;
        public int Id_Mensalidade;

        public FormMensalidadesAlunos()
        {
            InitializeComponent();
        }

        private bool VerificaCamposMensalidadesAluno()
        {
            if (!ValidaCampos.ValidaCamposGroup(group_MensalidadesAlunos))
                return false;
            return true;
        }

        private void FormMensalidadesAlunos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_EscolaDataSet4.AllMensalidades' table. You can move, or remove it, as needed.
            this.allMensalidadesTableAdapter.Fill(this.dB_EscolaDataSet4.AllMensalidades);
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

        private void dgv_MensalidadesAluno_SelectionChanged(object sender, EventArgs e)
        {
            Situacao = (dgv_MensalidadesAluno.CurrentRow.Cells[6].Value).ToString();
            Id_Mensalidade = Convert.ToInt32(dgv_MensalidadesAluno.CurrentRow.Cells[0].Value);

            if (Situacao == "A receber")
                rdb_APagar.Checked = true;
            if (Situacao == "Pago")
                rdb_Pago.Checked = true;
        }

        private void btn_ConsultarMensalidades_Click(object sender, EventArgs e)
        {
            if (!VerificaCamposMensalidadesAluno())
                return;
            
            dgv_MensalidadesAluno.DataSource = GerenciaBanco.getMensalidades(int.Parse(msk_IdAluno.Text));
        }

        private void btn_SalvarAlteracao_Click(object sender, EventArgs e)
        {
            byte x;

            if (!VerificaCamposMensalidadesAluno())
                return;

            if (rdb_APagar.Checked)
            {
                Situacao = "A receber";
                x = 0;
            }
            else
            {
                Situacao = "Pago";
                x = 1;
            }

            if (GerenciaBanco.AtualizaMensalidade(Id_Mensalidade, x))
            {
                MessageBox.Show("Mensalidade atualizada com sucesso!");
            }
            else
            {
                MessageBox.Show("Houve um erro na hora de atualizar a mensalidade!");
            }

            dgv_MensalidadesAluno.DataSource = GerenciaBanco.getMensalidades(int.Parse(msk_IdAluno.Text));
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
