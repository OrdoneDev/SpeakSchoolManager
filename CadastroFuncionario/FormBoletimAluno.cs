using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            dgv_BoletimAluno.DataSource = GerenciaBanco.carregaDados("Boletim").Tables[0];
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

            dgv_BoletimAluno.Rows[GerenciaBanco.getBoletim(int.Parse(msk_IdAluno.Text)) - 1].Selected = true;
        }

        private void btn_SalvarAlteracoes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja salvar as alterações?", "Salvar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GerenciaBanco.updateDados("Boletim");
            }

            dgv_BoletimAluno.DataSource = GerenciaBanco.carregaDados("Boletim").Tables[0];
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
