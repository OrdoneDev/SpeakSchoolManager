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
    public partial class FormTabelaResponsavel : Form
    {
        public FormTabelaResponsavel()
        {
            InitializeComponent();
        }

        private void FormTabelaResponsavel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_EscolaDataSet7.Responsavel_Aluno' table. You can move, or remove it, as needed.
            this.responsavel_AlunoTableAdapter.Fill(this.dB_EscolaDataSet7.Responsavel_Aluno);

        }

        private void cmb_Nome_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_Nome, "TOP 5 Nome", "Nome", e, "SysProtected.Responsavel_Aluno");
        }

        private void cmb_Nome_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void btn_FiltrarId_Click(object sender, EventArgs e)
        {
            if (msk_Id.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo de id!");
                msk_Id.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            msk_Id.BackColor = System.Drawing.Color.White;

            dgv_Responsaveis.DataSource = GerenciaBanco.getFiltro(msk_Id.Text, "Id_Responsavel", "SysProtected.Responsavel_Aluno");
        }

        private void btn_FiltrarNome_Click(object sender, EventArgs e)
        {
            if (cmb_Nome.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo nome!");
                cmb_Nome.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            cmb_Nome.BackColor = System.Drawing.Color.White;

            dgv_Responsaveis.DataSource = GerenciaBanco.getFiltro(cmb_Nome.Text, "Nome", "SysProtected.Responsavel_Aluno");
        }

        private void btn_FiltrarCPF_Click(object sender, EventArgs e)
        {
            if (msk_CPF.Text.Trim().Length != 14)
            {
                MessageBox.Show("Preencha o campo CPF!");
                msk_CPF.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            msk_CPF.BackColor = System.Drawing.Color.White;

            dgv_Responsaveis.DataSource = GerenciaBanco.getFiltro(msk_CPF.Text, "CPF", "SysProtected.Responsavel_Aluno");
        }
    }
}
