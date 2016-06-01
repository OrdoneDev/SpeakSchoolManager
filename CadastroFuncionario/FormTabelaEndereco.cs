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
    public partial class FormTabelaEndereco : Form
    {
        public FormTabelaEndereco()
        {
            InitializeComponent();
        }

        private void FormTabelaEndereco_Load(object sender, EventArgs e)
        {
            dgv_Enderecos.DataSource = GerenciaBanco.carregaDados("Endereco", "Id_Endereco as 'Código do endereço', Estado, Cidade, " +
            "CEP, Bairro, Nome_Rua as 'Nome da rua'").Tables[0];
        }

        private void dgv_Enderecos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("O valor fornecido a esta celula está invalido!");
        }

        private void cmb_Estado_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_Estado, "DISTINCT TOP 5 Estado", "Estado", e, "SysProtected.Endereco");
        }

        private void cmb_Estado_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void cmb_Cidade_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_Cidade, "DISTINCT TOP 5 Cidade", "Cidade", e, "SysProtected.Endereco");
        }

        private void cmb_Cidade_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void cmb_Bairro_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_Bairro, "DISTINCT TOP 5 Bairro", "Bairro", e, "SysProtected.Endereco");
        }

        private void cmb_Bairro_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void btn_FiltrarId_Click(object sender, EventArgs e)
        {
            if (msk_IdEndereco.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo de id!");
                msk_IdEndereco.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            msk_IdEndereco.BackColor = System.Drawing.Color.White;

            if (GerenciaBanco.getFiltro(msk_IdEndereco.Text, "Id_Endereco", "SysProtected.Endereco", "Id_Endereco") != 0)
            {
                dgv_Enderecos.Rows[GerenciaBanco.getFiltro(msk_IdEndereco.Text, "Id_Endereco", "SysProtected.Endereco", "Id_Endereco") - 1].Selected = true;
            }
        }

        private void btn_FiltrarEstado_Click(object sender, EventArgs e)
        {
            if (cmb_Estado.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo estado!");
                cmb_Estado.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            cmb_Estado.BackColor = System.Drawing.Color.White;

            if (GerenciaBanco.getFiltro(cmb_Estado.Text, "Estado", "SysProtected.Endereco", "Id_Endereco") != 0)
            {
                dgv_Enderecos.Rows[GerenciaBanco.getFiltro(cmb_Estado.Text, "Estado", "SysProtected.Endereco", "Id_Endereco") - 1].Selected = true;
            }
        }

        private void btn_FiltrarCidade_Click(object sender, EventArgs e)
        {
            if (cmb_Cidade.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo cidade!");
                cmb_Cidade.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            cmb_Cidade.BackColor = System.Drawing.Color.White;

            if (GerenciaBanco.getFiltro(cmb_Cidade.Text, "Cidade", "SysProtected.Endereco", "Id_Endereco") != 0)
            {
                dgv_Enderecos.Rows[GerenciaBanco.getFiltro(cmb_Cidade.Text, "Cidade", "SysProtected.Endereco", "Id_Endereco") - 1].Selected = true;
            }
        }

        private void btn_FiltrarBairro_Click(object sender, EventArgs e)
        {
            if (cmb_Bairro.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo bairro!");
                cmb_Bairro.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            cmb_Bairro.BackColor = System.Drawing.Color.White;

            if (GerenciaBanco.getFiltro(cmb_Bairro.Text, "Bairro", "SysProtected.Endereco", "Id_Endereco") != 0)
            {
                dgv_Enderecos.Rows[GerenciaBanco.getFiltro(cmb_Bairro.Text, "Bairro", "SysProtected.Endereco", "Id_Endereco") - 1].Selected = true;
            }
        }

        private void btn_SalvarAlteracoes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja salvar as alterações?", "Salvar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GerenciaBanco.updateDados("Endereco", "Id_Endereco as 'Código do endereço', Estado, Cidade, " +
            "CEP, Bairro, Nome_Rua as 'Nome da rua'");
            }

            dgv_Enderecos.DataSource = GerenciaBanco.carregaDados("Endereco", "Id_Endereco as 'Código do endereço', Estado, Cidade, " +
            "CEP, Bairro, Nome_Rua as 'Nome da rua'").Tables[0];
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
