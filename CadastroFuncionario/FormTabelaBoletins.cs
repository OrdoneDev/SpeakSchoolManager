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
    public partial class FormTabelaBoletins : Form
    {
        int Permissao;

        public FormTabelaBoletins(int TagP)
        {
            InitializeComponent();
            Permissao = TagP;
        }

        private void FormTabelaBoletins_Load(object sender, EventArgs e)
        {
            dgv_TabelaBoletins.DataSource = GerenciaBanco.carregaDados("Boletim", "Id_Boletim as 'Código do boletim', Id_Inscricao as 'Código da inscrição', " +
            "Nota1 as '1º Nota', Nota2 as '2º Nota', Media as 'Média', Numero_Faltas as 'Nº de faltas', Semestre").Tables[0];

            if (Permissao != 1)
                dgv_TabelaBoletins.AllowUserToDeleteRows = false;
        }

        private void dgv_TabelaBoletins_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            Regex Valida = new Regex(@"(^[0-9]{1}\.[0-9]{1})$|(^[0-9]0{1})$|(^[0-9]{1})$");

            if (!Valida.IsMatch(e.Value.ToString()) && (e.ColumnIndex == 2 || e.ColumnIndex == 3))
            {
                MessageBox.Show("Insira valores numéricos entre 0 e 10!");
                e.InheritedCellStyle = null;
            }
        }

        private void dgv_TabelaBoletins_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            dgv_TabelaBoletins.RefreshEdit();
        }

        private void cmb_NomeAluno_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_NomeAluno, "TOP 5 Nome", "Nome", e, "SysProtected.Alunos");
        }

        private void cmb_NomeAluno_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void btn_FiltrarAluno_Click(object sender, EventArgs e)
        {
            if (cmb_NomeAluno.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo aluno!");
                cmb_NomeAluno.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            cmb_NomeAluno.BackColor = System.Drawing.Color.White;

            if (GerenciaBanco.getFiltro(cmb_NomeAluno.Text, "Nome", "BoletinsAlunoFiltro", "Id_Inscricao") != 0)
            {
                dgv_TabelaBoletins.Rows[GerenciaBanco.getFiltro(cmb_NomeAluno.Text, "Nome", "BoletinsAlunoFiltro", "Id_Inscricao") - 1].Selected = true;
            }
        }

        private void btn_SalvarAlteracoes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja salvar as alterações?", "Salvar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GerenciaBanco.updateDados("Boletim", "Id_Boletim as 'Código do boletim', Id_Inscricao as 'Código da inscrição', " +
            "Nota1 as '1º Nota', Nota2 as '2º Nota', Media as 'Média', Numero_Faltas as 'Nº de faltas', Semestre");
            }

            dgv_TabelaBoletins.DataSource = GerenciaBanco.carregaDados("Boletim", "Id_Boletim as 'Código do boletim', Id_Inscricao as 'Código da inscrição', " +
            "Nota1 as '1º Nota', Nota2 as '2º Nota', Media as 'Média', Numero_Faltas as 'Nº de faltas', Semestre").Tables[0];
        }
    }
}
