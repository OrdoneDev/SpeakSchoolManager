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
        int Permissao;

        public FormTabelaResponsavel(int TagP)
        {
            InitializeComponent();
            Permissao = TagP;
        }

        private void FormTabelaResponsavel_Load(object sender, EventArgs e)
        {
            dgv_Responsaveis.DataSource = GerenciaBanco.carregaDados("Responsavel_Aluno", "Id_Responsavel as 'Código do responsável', " +
            "Id_Endereco as 'Código do endereço', Nome, DataNascimento as 'Data de nascimento', Sexo, Estado_Civil as 'Estado civil', " +
            "RG, CPF, Email, DDD, Telefone, Complemento, Numero as 'Nº'").Tables[0];

            if (Permissao != 1)
                dgv_Responsaveis.AllowUserToDeleteRows = false;
        }

        private void dgv_Responsaveis_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            dgv_Responsaveis.RefreshEdit();
            MessageBox.Show("O valor fornecido a esta celula está invalido!");
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

            if (GerenciaBanco.getFiltro(msk_Id.Text, "Id_Responsavel", "SysProtected.Responsavel_Aluno", "Id_Responsavel") != 0)
            {
                dgv_Responsaveis.Rows[GerenciaBanco.getFiltro(msk_Id.Text, "Id_Responsavel", "SysProtected.Responsavel_Aluno", "Id_Responsavel") - 1].Selected = true;
            }
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

            if (GerenciaBanco.getFiltro(cmb_Nome.Text, "Nome", "SysProtected.Responsavel_Aluno", "Id_Responsavel") != 0)
            {
                dgv_Responsaveis.Rows[GerenciaBanco.getFiltro(cmb_Nome.Text, "Nome", "SysProtected.Responsavel_Aluno", "Id_Responsavel") - 1].Selected = true;
            }
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

            if (GerenciaBanco.getFiltro(msk_CPF.Text, "CPF", "SysProtected.Responsavel_Aluno", "Id_Responsavel") != 0)
            {
                dgv_Responsaveis.Rows[GerenciaBanco.getFiltro(msk_CPF.Text, "CPF", "SysProtected.Responsavel_Aluno", "Id_Responsavel") - 1].Selected = true;
            }
        }

        private void btn_SalvarAlteracoes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja salvar as alterações?", "Salvar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GerenciaBanco.updateDados("Responsavel_Aluno", "Id_Responsavel as 'Código do responsável', " +
            "Id_Endereco as 'Código do endereço', Nome, DataNascimento as 'Data de nascimento', Sexo, Estado_Civil as 'Estado civil', " +
            "RG, CPF, Email, DDD, Telefone, Complemento, Numero as 'Nº'");
            }

            dgv_Responsaveis.DataSource = GerenciaBanco.carregaDados("Responsavel_Aluno", "Id_Responsavel as 'Código do responsável', " +
            "Id_Endereco as 'Código do endereço', Nome, DataNascimento as 'Data de nascimento', Sexo, Estado_Civil as 'Estado civil', " +
            "RG, CPF, Email, DDD, Telefone, Complemento, Numero as 'Nº'").Tables[0];
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
