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
    public partial class FormGerarSemestre : Form
    {
        public FormGerarSemestre()
        {
            InitializeComponent();
        }

        private void FormGerarSemestre_Load(object sender, EventArgs e)
        {
            dgv_Inscricoes.DataSource = GerenciaBanco.carregaDados("Inscricao", "Id_Inscricao as 'Código da inscrição', " + 
            "Id_Aluno as 'Código do aluno', Id_Negociacao as 'Código da negociação', Data, Status").Tables[0];

            dgv_Inscricoes.Columns[0].ReadOnly = true;
            dgv_Inscricoes.Columns[1].ReadOnly = true;
            dgv_Inscricoes.Columns[2].ReadOnly = true;
            dgv_Inscricoes.Columns[3].ReadOnly = true;
            dgv_Inscricoes.Columns[4].ReadOnly = false;
        }

        private void cmb_NomeAluno_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_NomeAluno, "TOP 5 Nome", "Nome", e, "SysProtected.Alunos");
        }

        private void cmb_NomeAluno_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void btn_BuscarAluno_Click(object sender, EventArgs e)
        {
            if (cmb_NomeAluno.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo nome!");
                cmb_NomeAluno.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            cmb_NomeAluno.BackColor = System.Drawing.Color.White;

            if (GerenciaBanco.getFiltro(cmb_NomeAluno.Text, "Nome", "SysProtected.Alunos", "Id_Aluno") != 0)
            {
                dgv_Inscricoes.Rows[GerenciaBanco.getFiltro(cmb_NomeAluno.Text, "Nome", "SysProtected.Alunos", "Id_Aluno") - 1].Selected = true;
            }
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now.Date;

            foreach (DataGridViewRow linhas in dgv_Inscricoes.Rows)
            {
                if (linhas.Cells[4].Value.ToString() == "True")
                {
                    linhas.Cells[3].Value = data;
                }
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            int Id_Inscricao;

            Id_Inscricao = (int)dgv_Inscricoes.Rows[0].Cells[0].Value;

            if (MessageBox.Show("Deseja salvar as alterações?", "Salvar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dgv_Inscricoes.Rows[0].Cells[4].Value.ToString() == "True")
                {
                    GerenciaBanco.AtualizarPrimeiraInscricao(Id_Inscricao, DateTime.Now.Date);
                }

                GerenciaBanco.updateDados("Inscricao", "Id_Inscricao as 'Código da inscrição', " +
                "Id_Aluno as 'Código do aluno', Id_Negociacao as 'Código da negociação', Data, Status");

                MessageBox.Show("O novo semestre foi gerado com sucesso!");
            }

            dgv_Inscricoes.DataSource = GerenciaBanco.carregaDados("Inscricao", "Id_Inscricao as 'Código da inscrição', " +
            "Id_Aluno as 'Código do aluno', Id_Negociacao as 'Código da negociação', Data, Status").Tables[0];
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
