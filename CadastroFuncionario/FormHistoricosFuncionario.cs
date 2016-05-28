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
    public partial class FormHistoricosFuncionario : Form
    {
        public FormHistoricosFuncionario()
        {
            InitializeComponent();
        }

        private void FormHistoricosFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_EscolaDataSet8.HistoricoFuncionario' table. You can move, or remove it, as needed.
            this.historicoFuncionarioTableAdapter.Fill(this.dB_EscolaDataSet8.HistoricoFuncionario);
        }

        private void cmb_Nome_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_Nome, "TOP 5 Nome", "Nome", e, "Funcionarios");
        }

        private void cmb_Nome_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void btn_FiltrarId_Click(object sender, EventArgs e)
        {
            if (msk_IdFuncionario.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo de id!");
                msk_IdFuncionario.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            msk_IdFuncionario.BackColor = System.Drawing.Color.White;

            dgv_HistoricoFuncionario.DataSource = GerenciaBanco.getFiltro(msk_IdFuncionario.Text, "Id_Funcionario", "HistoricoFuncionario");
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

            dgv_HistoricoFuncionario.DataSource = GerenciaBanco.getFiltro(cmb_Nome.Text, "Nome", "HistoricoFuncionario");
        }
    }
}
