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
    public partial class FormCadastroTurma : Form
    {
        public static DateTime Data;
        
        public FormCadastroTurma()
        {
            InitializeComponent();
        }

        private bool VerificaCamposCadastroTurma()
        {
            if (!ValidaCampos.ValidaCamposGroup(group_CadastroTurma))
                return false;

            if (!ValidaCampos.ValidaOpcoesCmb(cmb_SalaTurma, "sala"))
                return false;

            return true;
        }

        private void msk_IdIdioma_TextChanged(object sender, EventArgs e)
        {
            string NomeIdioma;
            if (msk_IdIdioma.Text.Length == 4)
            {
                NomeIdioma = GerenciaBanco.getNome(msk_IdIdioma.Text, "Idiomas", "Id_Idioma");

                if (NomeIdioma.Length > 0)
                {
                    cmb_NomeIdioma.Text = NomeIdioma;
                }
            }
            else
            {
                cmb_NomeIdioma.Text = "";
            }
        }

        private void msk_IdEscala_TextChanged(object sender, EventArgs e)
        {
            string[] Funcionario;
            if (msk_IdEscala.Text.Length == 4)
            {
                Funcionario = GerenciaBanco.getEscalaFuncionario(int.Parse(msk_IdEscala.Text)).ToArray();

                if (Funcionario.Length > 0)
                {
                    cmb_NomeFuncionario.Text = Funcionario[0];
                    lbl_ValorHoraEntrada.Text = Funcionario[1];
                    lbl_ValorHoraSaida.Text = Funcionario[2];
                }
            }
            else
            {
                cmb_NomeFuncionario.Text = "";
                lbl_ValorHoraEntrada.Text = "";
                lbl_ValorHoraSaida.Text = "";
            }
        }

        private void btn_SalvarTurma_Click(object sender, EventArgs e)
        {
            if (!VerificaCamposCadastroTurma())
                return;
            
            if (GerenciaBanco.CadastrarTurma(int.Parse(msk_IdIdioma.Text), int.Parse(msk_IdEscala.Text),
            int.Parse(cmb_SalaTurma.Text), Data, lbl_ValorHoraEntrada.Text, lbl_ValorHoraSaida.Text))
            {
                MessageBox.Show("Turma cadastrada com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possível cadastrar uma turma!");
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
