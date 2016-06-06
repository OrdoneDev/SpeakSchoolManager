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
    public partial class FormCadastroEscalas : Form
    {
        public FormCadastroEscalas()
        {
            InitializeComponent();
        }

        private bool VerificaCamposCadastroEscala()
        {
            if (!ValidaCampos.ValidaCamposGroup(group_CadastroEscala))
                return false;

            return true;
        }

        private void msk_IdFuncionario_TextChanged(object sender, EventArgs e)
        {
            string[] Funcionario;
            if (msk_IdFuncionario.Text.Length == 4)
            {
                Funcionario = GerenciaBanco.getInformacoesFuncionario(msk_IdFuncionario.Text).ToArray();

                if (Funcionario.Length > 0)
                {
                    cmb_NomeFuncionario.Text = Funcionario[0];
                    cmb_CargoFuncionario.Text = Funcionario[1];
                    GerenciaBanco.Cargo = Funcionario[1];
                }
            }
            else
            {
                cmb_NomeFuncionario.Text = "";
                cmb_CargoFuncionario.Text = "";
            }
        }

        private void cmb_NomeFuncionario_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ValidaCampos.GetLista(cmb_NomeFuncionario, "TOP 5 Nome, Id_Funcionario, Cargo", "Nome", e, "SysProtected.Funcionarios");

            msk_IdFuncionario.Text = GerenciaBanco.Id_Funcionario.ToString().PadLeft(4, '0');

            cmb_CargoFuncionario.Text = GerenciaBanco.Cargo.ToString();
        }

        private void cmb_NomeFuncionario_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidaCampos.Deleta = true;
        }

        private void btn_SalvarEscala_Click(object sender, EventArgs e)
        {
            DateTime Data_Historico;
            int Valida = 0;

            if (!VerificaCamposCadastroEscala())
                return;

            Data_Historico = dte_DataEscala.Value.Date;

            Valida = GerenciaBanco.VerificaEscala(Valida, int.Parse(msk_IdFuncionario.Text.ToString()), Data_Historico,
                     msk_HoraEntradaEscala.Text, msk_HoraSaidaFuncionario.Text);

            if (Valida == 0)
            {
                if (MessageBox.Show("Deseja efetuar o cadastro?", "Salvar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (cmb_CargoFuncionario.Text == GerenciaBanco.Cargo.ToString())
                    {
                        if (GerenciaBanco.CadastrarEscala(int.Parse(msk_IdFuncionario.Text.ToString()), Data_Historico,
                        msk_HoraEntradaEscala.Text, msk_HoraSaidaFuncionario.Text, txb_DescricaoEncargos.Text))
                        {
                            MessageBox.Show("Escala cadastrada com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível efetuar o cadastro da escala!");
                        }
                    }
                    else
                        MessageBox.Show("O funcionário informado esta cadastrado em outro cargo!");
                }
            }
            else
            {
                MessageBox.Show("Houve uma duplicação de escalas!");
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
