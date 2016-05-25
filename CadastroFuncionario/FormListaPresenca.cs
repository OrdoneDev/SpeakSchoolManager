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
    public partial class FormListaPresenca : Form
    {
        public FormListaPresenca()
        {
            InitializeComponent();
        }

        private bool VerificaCamposListaPresenca()
        {
            if (!ValidaCampos.ValidaCamposGroup(group_ListaPresenca))
                return false;

            return true;
        }

        private void msk_IdTurma_TextChanged(object sender, EventArgs e)
        {
            string[] Turma;
            if (msk_IdTurma.Text.Length == 4)
            {
                Turma = GerenciaBanco.getTurma(int.Parse(msk_IdTurma.Text)).ToArray();

                if (Turma.Length > 0)
                {
                    lbl_Professor.Text = "Professor: "+ Turma[1];
                    lbl_Sala.Text = "Sala: " +Turma[2];
                }
            }
            else
            {
                lbl_Professor.Text = "";
                lbl_Sala.Text = "";
            }
        }

        private void btn_ConsultarLista_Click(object sender, EventArgs e)
        {
            if (!VerificaCamposListaPresenca())
                return;


        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
