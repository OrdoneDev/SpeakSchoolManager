using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroFuncionario
{
    public partial class FormTabelaBoletins : Form
    {
        public FormTabelaBoletins()
        {
            InitializeComponent();
        }

        private void FormTabelaBoletins_Load(object sender, EventArgs e)
        {
            dgv_TabelaBoletins.DataSource = GerenciaBanco.carregaDados("Boletim", "Id_Boletim as 'Código do boletim', Id_Inscricao as 'Código da inscrição', " +
            "Nota1 as '1º Nota', Nota2 as '2º Nota', Media, Numero_Faltas as 'Nº de faltas'").Tables[0];
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
            "Nota1 as '1º Nota', Nota2 as '2º Nota', Media, Numero_Faltas as 'Nº de faltas'");
            }

            dgv_TabelaBoletins.DataSource = GerenciaBanco.carregaDados("Boletim", "Id_Boletim as 'Código do boletim', Id_Inscricao as 'Código da inscrição', " +
            "Nota1 as '1º Nota', Nota2 as '2º Nota', Media, Numero_Faltas as 'Nº de faltas'").Tables[0];
        }
    }
}
