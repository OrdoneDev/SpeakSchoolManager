using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroFuncionario
{
    class ValidaCampos
    {
        public static string banco;
        public static int agencia;
        public static int conta;
        public static DateTime dataDeposito;
        public static bool Continua = false;
        public static bool Deleta = false;

        public static bool ValidaCPF(string vrCPF)
        {
            bool igual = true;
            int[] numeros = new int[11];
            int soma = 0, resultado;
            string valor = vrCPF.Replace(".", "");
            valor = valor.Replace("-", "");

            if (valor.Length != 11)
                return false;

            for (int i = 1; i < 11 && igual; i++)
                if (valor[i] != valor[0])
                    igual = false;

            if (igual || valor == "12345678909")
                return false;

            for (int i = 0; i < 11; i++)
                numeros[i] = int.Parse(valor[i].ToString());

            for (int i = 0; i < 9; i++)
                soma += (10 - i) * numeros[i];

            resultado = soma % 11;
            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)
                    return false;
            }
            else if (numeros[9] != 11 - resultado)
                return false;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (11 - i) * numeros[i];

            resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                    return false;

            }
            else
                if (numeros[10] != 11 - resultado)
                    return false;

            return true;

        }

        public static bool ValidaCep(string cep)
        {
            if (cep.Length == 8)
            {
                cep = cep.Substring(0, 5) + "-" + cep.Substring(5, 3);
            }
            return System.Text.RegularExpressions.Regex.IsMatch(cep, ("[0-9]{5}-[0-9]{3}"));
        }

        public static bool ValidaCamposGroup(Control group)
        {
            bool x = true;
            string[] separators = { ",", ".", "(", ")", "-", "_", " ", ":" };
            foreach (Control control in group.Controls)
            {
                if (control is Control)
                {
                    if (control.Tag != "0" && control.Text.Trim().Split(separators, StringSplitOptions.RemoveEmptyEntries).Length == 0)
                    {
                        control.BackColor = System.Drawing.Color.LightGray;
                        x = false;
                    }
                    else if (control.BackColor == System.Drawing.Color.LightGray)
                        control.BackColor = System.Drawing.Color.White;
                }
            }

            if (!x)
                MessageBox.Show("Preencha os campos!");

            return x;
        }

        public static void CompletaNull(object obj)
        {
            if (obj is TextBox)
            {
                TextBox x = obj as TextBox;
                if (x.Text.Trim().Length == 0)
                {
                    x.Text = "null";
                }
            }
            if (obj is MaskedTextBox)
            {
                MaskedTextBox y = obj as MaskedTextBox;
                if (y.Text.Trim().Length == 0)
                {
                    y.Text = "0";
                }
            }

            if (obj is ComboBox)
            {
                ComboBox w = obj as ComboBox;
                if (w.Text.Trim().Length == 0)
                {
                    w.Text = "0";
                }
            }
        }

        public static bool ValidaOpcoesCmb(ComboBox control, string tipo)
        {
            bool x = false;
            foreach (string item in control.Items)
            {
                if (control.Text == item)
                {
                    x = true;
                    break;
                }
            }

            if (!x)
            {
                MessageBox.Show("Você deve escolher um(a) " + tipo + " disponível!");
                return false;
            }
            return true;
        }

        public static void GetLista(ComboBox control, string tipo1, string tipo2, PreviewKeyDownEventArgs e, string tabela)
        {
            string[] nomes;
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down || e.KeyData == Keys.Left || e.KeyData == Keys.Right || control.Text.Length == 0)
            {
                Deleta = false;
                return;
            }

            if (e.KeyCode == Keys.Back && Deleta)
                control.Text = "";

            if (e.KeyData == Keys.Enter)
                SendKeys.Send("{TAB}");

            nomes = GerenciaBanco.getLista(control.Text, tipo1, tipo2, tabela).ToArray();
            control.DroppedDown = nomes.Length > 0 ? true : false;
            control.Items.Clear();
            control.Items.AddRange(nomes);
            control.SelectionStart = control.Text.Length;
        }
    }
}
