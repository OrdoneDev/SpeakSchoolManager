namespace CadastroFuncionario
{
    partial class FormCadastroFinanceiroFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroFinanceiroFuncionario));
            this.group_CadastroFinanceiroFuncionario = new System.Windows.Forms.GroupBox();
            this.dte_DataDepositoFuncionario = new System.Windows.Forms.DateTimePicker();
            this.txt_ContaFuncionario = new System.Windows.Forms.TextBox();
            this.txt_AgenciaFuncionario = new System.Windows.Forms.TextBox();
            this.cmb_BancoFuncionario = new System.Windows.Forms.ComboBox();
            this.lbl_DataDeposito = new System.Windows.Forms.Label();
            this.lbl_conta = new System.Windows.Forms.Label();
            this.lbl_Agencia = new System.Windows.Forms.Label();
            this.lbl_Banco = new System.Windows.Forms.Label();
            this.btn_FinalizarCadastroFuncionario = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.group_CadastroFinanceiroFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_CadastroFinanceiroFuncionario
            // 
            this.group_CadastroFinanceiroFuncionario.BackColor = System.Drawing.SystemColors.Control;
            this.group_CadastroFinanceiroFuncionario.Controls.Add(this.dte_DataDepositoFuncionario);
            this.group_CadastroFinanceiroFuncionario.Controls.Add(this.txt_ContaFuncionario);
            this.group_CadastroFinanceiroFuncionario.Controls.Add(this.txt_AgenciaFuncionario);
            this.group_CadastroFinanceiroFuncionario.Controls.Add(this.cmb_BancoFuncionario);
            this.group_CadastroFinanceiroFuncionario.Controls.Add(this.lbl_DataDeposito);
            this.group_CadastroFinanceiroFuncionario.Controls.Add(this.lbl_conta);
            this.group_CadastroFinanceiroFuncionario.Controls.Add(this.lbl_Agencia);
            this.group_CadastroFinanceiroFuncionario.Controls.Add(this.lbl_Banco);
            resources.ApplyResources(this.group_CadastroFinanceiroFuncionario, "group_CadastroFinanceiroFuncionario");
            this.group_CadastroFinanceiroFuncionario.Name = "group_CadastroFinanceiroFuncionario";
            this.group_CadastroFinanceiroFuncionario.TabStop = false;
            // 
            // dte_DataDepositoFuncionario
            // 
            this.dte_DataDepositoFuncionario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dte_DataDepositoFuncionario, "dte_DataDepositoFuncionario");
            this.dte_DataDepositoFuncionario.Name = "dte_DataDepositoFuncionario";
            this.dte_DataDepositoFuncionario.Value = new System.DateTime(2016, 5, 30, 13, 50, 0, 0);
            // 
            // txt_ContaFuncionario
            // 
            resources.ApplyResources(this.txt_ContaFuncionario, "txt_ContaFuncionario");
            this.txt_ContaFuncionario.Name = "txt_ContaFuncionario";
            // 
            // txt_AgenciaFuncionario
            // 
            resources.ApplyResources(this.txt_AgenciaFuncionario, "txt_AgenciaFuncionario");
            this.txt_AgenciaFuncionario.Name = "txt_AgenciaFuncionario";
            // 
            // cmb_BancoFuncionario
            // 
            this.cmb_BancoFuncionario.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_BancoFuncionario, "cmb_BancoFuncionario");
            this.cmb_BancoFuncionario.Name = "cmb_BancoFuncionario";
            this.cmb_BancoFuncionario.SelectedValueChanged += new System.EventHandler(this.cmb_BancoFuncionario_SelectedValueChanged);
            this.cmb_BancoFuncionario.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_BancoFuncionario_PreviewKeyDown);
            // 
            // lbl_DataDeposito
            // 
            resources.ApplyResources(this.lbl_DataDeposito, "lbl_DataDeposito");
            this.lbl_DataDeposito.Name = "lbl_DataDeposito";
            // 
            // lbl_conta
            // 
            resources.ApplyResources(this.lbl_conta, "lbl_conta");
            this.lbl_conta.Name = "lbl_conta";
            // 
            // lbl_Agencia
            // 
            resources.ApplyResources(this.lbl_Agencia, "lbl_Agencia");
            this.lbl_Agencia.Name = "lbl_Agencia";
            // 
            // lbl_Banco
            // 
            resources.ApplyResources(this.lbl_Banco, "lbl_Banco");
            this.lbl_Banco.Name = "lbl_Banco";
            // 
            // btn_FinalizarCadastroFuncionario
            // 
            resources.ApplyResources(this.btn_FinalizarCadastroFuncionario, "btn_FinalizarCadastroFuncionario");
            this.btn_FinalizarCadastroFuncionario.Name = "btn_FinalizarCadastroFuncionario";
            this.btn_FinalizarCadastroFuncionario.UseVisualStyleBackColor = true;
            this.btn_FinalizarCadastroFuncionario.Click += new System.EventHandler(this.btn_FinalizarCadastroFuncionario_Click);
            // 
            // btn_Cancelar
            // 
            resources.ApplyResources(this.btn_Cancelar, "btn_Cancelar");
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // FormCadastroFinanceiroFuncionario
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_FinalizarCadastroFuncionario);
            this.Controls.Add(this.group_CadastroFinanceiroFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroFinanceiroFuncionario";
            this.group_CadastroFinanceiroFuncionario.ResumeLayout(false);
            this.group_CadastroFinanceiroFuncionario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_CadastroFinanceiroFuncionario;
        private System.Windows.Forms.DateTimePicker dte_DataDepositoFuncionario;
        private System.Windows.Forms.TextBox txt_ContaFuncionario;
        private System.Windows.Forms.TextBox txt_AgenciaFuncionario;
        private System.Windows.Forms.ComboBox cmb_BancoFuncionario;
        private System.Windows.Forms.Label lbl_DataDeposito;
        private System.Windows.Forms.Label lbl_conta;
        private System.Windows.Forms.Label lbl_Agencia;
        private System.Windows.Forms.Label lbl_Banco;
        private System.Windows.Forms.Button btn_FinalizarCadastroFuncionario;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}