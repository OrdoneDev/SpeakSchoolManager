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
        public int Tag = 0;

        public FormPrincipal()
        {
            InitializeComponent();

            Tag = GerenciaBanco.VerificaPermissao(Tag, "Funcionarios");

            if (Tag == 0)
                Tag = GerenciaBanco.VerificaPermissao(Tag, "Alunos");

            ValidaPermissoes(menuStrip1);

            if (Tag == 1)
                MessageBox.Show("Seja bem vindo diretor!");
            if (Tag == 2)
                MessageBox.Show("Seja bem vindo secretário!");
            if (Tag == 0)
                MessageBox.Show("Seja bem vindo professor!");
        }

        private void ValidaPermissoes(MenuStrip Menu)
        {
            foreach (ToolStripMenuItem control in Menu.Items)
            {
                if (control is ToolStripMenuItem)
                {
                    foreach (ToolStripMenuItem controles in control.DropDownItems)
                    { 
                        if (controles.Tag == "1" && Tag != 1)
                        {
                            controles.Enabled = false;
                        }
                        if (controles.Tag == "2" && Tag == 0)
                        {
                            controles.Enabled = false;
                        }
                        foreach (ToolStripMenuItem itens in controles.DropDownItems)
                        {
                            if (itens.Tag == "1" && Tag != 1)
                            {
                                itens.Enabled = false;
                            }
                            if (itens.Tag == "2" && Tag == 0)
                            {
                                itens.Enabled = false;
                            }
                        }
                    }
                }
            }
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

        private void registrarPagamentoFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistraPagamentoFuncionario form = new FormRegistraPagamentoFuncionario();
            form.MdiParent = this;
            form.Show();
        }

        private void enderecosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTabelaEndereco form = new FormTabelaEndereco();
            form.MdiParent = this;
            form.Show();
        }

        private void funcionariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormTabelaFuncionarios form = new FormTabelaFuncionarios();
            form.MdiParent = this;
            form.Show();
        }

        private void responsáveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTabelaResponsavel form = new FormTabelaResponsavel();
            form.MdiParent = this;
            form.Show();
        }

        private void históricosRegistradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistoricosFuncionario form = new FormHistoricosFuncionario();
            form.MdiParent = this;
            form.Show();
        }

        private void históricosRegistradosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormHistoricosAluno form = new FormHistoricosAluno();
            form.MdiParent = this;
            form.Show();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTabelaAlunos form = new FormTabelaAlunos();
            form.MdiParent = this;
            form.Show();
        }

        private void idiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTabelaIdiomas form = new FormTabelaIdiomas();
            form.MdiParent = this;
            form.Show();
        }

        private void planosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTabelaPlanos form = new FormTabelaPlanos();
            form.MdiParent = this;
            form.Show();
        }

        private void financeirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTabelaFinanceiros form = new FormTabelaFinanceiros();
            form.MdiParent = this;
            form.Show();
        }

        private void negociaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTabelaNegociações form = new FormTabelaNegociações();
            form.MdiParent = this;
            form.Show();
        }

        private void mensalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTabelaMensalidades form = new FormTabelaMensalidades();
            form.MdiParent = this;
            form.Show();
        }

        private void inscriçõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormTabelaInscricoes form = new FormTabelaInscricoes();
            form.MdiParent = this;
            form.Show();
        }

        private void boletinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTabelaBoletins form = new FormTabelaBoletins();
            form.MdiParent = this;
            form.Show();
        }

        private void escalasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTabelaEscalas form = new FormTabelaEscalas();
            form.MdiParent = this;
            form.Show();
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTabelaTurmas form = new FormTabelaTurmas();
            form.MdiParent = this;
            form.Show();
        }

        private void inscriçõesETurmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTabelaInscricoesTurmas form = new FormTabelaInscricoesTurmas();
            form.MdiParent = this;
            form.Show();
        }

        private void listaDePresençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTabelaListaPresenca form = new FormTabelaListaPresenca();
            form.MdiParent = this;
            form.Show();
        }
    }
}
