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
    public partial class FormCadastroPlanos : Form
    {
        public FormCadastroPlanos()
        {
            InitializeComponent();
        }

        private bool VerificaCamposCadastroPlano()
        {
            if (!ValidaCampos.ValidaCamposGroup(group_CadastroPlano))
                return false;

            if (int.Parse(msk_NumeroAulas.Text) > 255)
            {
                MessageBox.Show("O número de aulas deve ser menor que 255");
                return false;
            }

            return true;
        }

        private void cmb_NomeIdioma_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_NomeIdioma, "DISTINCT TOP 5 Nome", "Nome", e, "Idiomas");
        }

        private void cmb_NomeIdioma_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void btn_SalvarPlano_Click(object sender, EventArgs e)
        {
            int Id_Idioma = 0;

            if (!VerificaCamposCadastroPlano())
                return;

            Id_Idioma = GerenciaBanco.getId_Idioma(cmb_NomeIdioma.Text, txb_DescricaoIdioma.Text);

            if (Id_Idioma == 0)
                Id_Idioma = GerenciaBanco.CadastrarIdioma(Id_Idioma, cmb_NomeIdioma.Text, txb_DescricaoIdioma.Text);

            if (!GerenciaBanco.VerificaPlano(Id_Idioma, cmb_NomePlano.Text))
            {
                MessageBox.Show("Houve uma duplicação de planos!");
                return;
            }

            if (GerenciaBanco.CadastrarPlano(Id_Idioma, cmb_NomePlano.Text, msk_NumeroAulas.Text, msk_ValorPlano.Text))
            {
                MessageBox.Show("Plano cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Houve um erro no ato de cadastrar o plano!");
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}