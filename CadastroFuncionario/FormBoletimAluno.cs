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
        bool Error = false;

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
            dgv_BoletimAluno.DataSource = GerenciaBanco.carregaDados("Boletim", "Id_Boletim as 'Código do boletim', Id_Inscricao as 'Código da inscrição', " +
            "Nota1 as '1º Nota', Nota2 as '2º Nota', Media as 'Média', Numero_Faltas as 'Nº de faltas'").Tables[0];

            dgv_BoletimAluno.Columns[0].ReadOnly = true;
            dgv_BoletimAluno.Columns[1].ReadOnly = true;
            dgv_BoletimAluno.Columns[4].ReadOnly = true;
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
            Regex Valida = new Regex(@"(^[0-9]{1}\.[0-9]{1})$|(^[0-9]0{1})$|(^[0-9]{1})$");
            
            if (!Valida.IsMatch(e.Value.ToString()) && (e.ColumnIndex == 2 || e.ColumnIndex == 3))
            {
                MessageBox.Show("Insira valores númericos entre 0 e 10!");
                e.InheritedCellStyle = null;
            }
        }

        private void dgv_BoletimAluno_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            dgv_BoletimAluno.RefreshEdit();
        } 

        private void btn_ConsultarBoletim_Click(object sender, EventArgs e)
        {
            if (!VerificaCamposBoletimAluno())
                return;

            if (GerenciaBanco.getBoletim(int.Parse(msk_IdAluno.Text)) != 0)
            {
                dgv_BoletimAluno.Rows[GerenciaBanco.getBoletim(int.Parse(msk_IdAluno.Text)) - 1].Selected = true;
            }
        }

        private void btn_SalvarAlteracoes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja salvar as alterações?", "Salvar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GerenciaBanco.updateDados("Boletim", "Id_Boletim as 'Código do boletim', Id_Inscricao as 'Código da inscrição', " +
            "Nota1 as '1º Nota', Nota2 as '2º Nota', Media as 'Média', Numero_Faltas as 'Nº de faltas'");
            }

            dgv_BoletimAluno.DataSource = GerenciaBanco.carregaDados("Boletim", "Id_Boletim as 'Código do boletim', Id_Inscricao as 'Código da inscrição', " +
            "Nota1 as '1º Nota', Nota2 as '2º Nota', Media as 'Média', Numero_Faltas as 'Nº de faltas'").Tables[0];
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
