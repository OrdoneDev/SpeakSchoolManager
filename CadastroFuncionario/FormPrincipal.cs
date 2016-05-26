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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void novoFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroFuncionario form = new FormCadastroFuncionario();
            form.MdiParent = this;
            form.Show();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistoricoFuncionario form = new FormHistoricoFuncionario();
            form.MdiParent = this;
            form.Show();
        }

        private void alunosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormCadastroAluno form = new FormCadastroAluno();
            form.MdiParent = this;
            form.Show();
        }

        private void reponsavelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroResponsavel form = new FormCadastroResponsavel();
            form.MdiParent = this;
            form.Show();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistoricoAluno form = new FormHistoricoAluno();
            form.MdiParent = this;
            form.Show();
        }

        private void novoPlanoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroPlanos form = new FormCadastroPlanos();
            form.MdiParent = this;
            form.Show();
        }

        private void financeiroEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroFinanceiroEmpresa form = new FormCadastroFinanceiroEmpresa();
            form.MdiParent = this;
            form.Show();
        }

        private void aquisiçãoDeCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdquirirCursoAluno form = new FormAdquirirCursoAluno();
            form.MdiParent = this;
            form.Show();
        }

        private void mensalidadesDoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMensalidadesAlunos form = new FormMensalidadesAlunos();
            form.MdiParent = this;
            form.Show();
        }

        private void inscriçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditarInscricao form = new FormEditarInscricao();
            form.MdiParent = this;
            form.Show();
        }

        private void boletimDoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBoletimAluno form = new FormBoletimAluno();
            form.MdiParent = this;
            form.Show();
        }

        private void novaEscalaDoFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroEscalas form = new FormCadastroEscalas();
            form.MdiParent = this;
            form.Show();
        }

        private void novaTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroTurma form = new FormCadastroTurma();
            form.MdiParent = this;
            form.Show();
        }

        private void vincularAuloATurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInscricoesTurmas form = new FormInscricoesTurmas();
            form.MdiParent = this;
            form.Show();
        }

        private void listaDeChamadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaPresenca form = new FormListaPresenca();
            form.MdiParent = this;
            form.Show();
        }
    }
}
