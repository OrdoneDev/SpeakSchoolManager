namespace CadastroFuncionario
{
    partial class FormCadastroFinanceiroEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroFinanceiroEmpresa));
            this.group_FinanceiroEmpresa = new System.Windows.Forms.GroupBox();
            this.txt_ContaEmpresa = new System.Windows.Forms.TextBox();
            this.txt_AgenciaEmpresa = new System.Windows.Forms.TextBox();
            this.cmb_BancoEmpresa = new System.Windows.Forms.ComboBox();
            this.lbl_conta = new System.Windows.Forms.Label();
            this.lbl_Agencia = new System.Windows.Forms.Label();
            this.lbl_Banco = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_SalvarFinanceiroEmpresa = new System.Windows.Forms.Button();
            this.group_FinanceiroEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_FinanceiroEmpresa
            // 
            this.group_FinanceiroEmpresa.Controls.Add(this.txt_ContaEmpresa);
            this.group_FinanceiroEmpresa.Controls.Add(this.txt_AgenciaEmpresa);
            this.group_FinanceiroEmpresa.Controls.Add(this.cmb_BancoEmpresa);
            this.group_FinanceiroEmpresa.Controls.Add(this.lbl_conta);
            this.group_FinanceiroEmpresa.Controls.Add(this.lbl_Agencia);
            this.group_FinanceiroEmpresa.Controls.Add(this.lbl_Banco);
            resources.ApplyResources(this.group_FinanceiroEmpresa, "group_FinanceiroEmpresa");
            this.group_FinanceiroEmpresa.Name = "group_FinanceiroEmpresa";
            this.group_FinanceiroEmpresa.TabStop = false;
            // 
            // txt_ContaEmpresa
            // 
            resources.ApplyResources(this.txt_ContaEmpresa, "txt_ContaEmpresa");
            this.txt_ContaEmpresa.Name = "txt_ContaEmpresa";
            // 
            // txt_AgenciaEmpresa
            // 
            resources.ApplyResources(this.txt_AgenciaEmpresa, "txt_AgenciaEmpresa");
            this.txt_AgenciaEmpresa.Name = "txt_AgenciaEmpresa";
            // 
            // cmb_BancoEmpresa
            // 
            this.cmb_BancoEmpresa.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_BancoEmpresa, "cmb_BancoEmpresa");
            this.cmb_BancoEmpresa.Name = "cmb_BancoEmpresa";
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
            // btn_Cancelar
            // 
            resources.ApplyResources(this.btn_Cancelar, "btn_Cancelar");
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_SalvarFinanceiroEmpresa
            // 
            resources.ApplyResources(this.btn_SalvarFinanceiroEmpresa, "btn_SalvarFinanceiroEmpresa");
            this.btn_SalvarFinanceiroEmpresa.Name = "btn_SalvarFinanceiroEmpresa";
            this.btn_SalvarFinanceiroEmpresa.UseVisualStyleBackColor = true;
            this.btn_SalvarFinanceiroEmpresa.Click += new System.EventHandler(this.btn_SalvarFinanceiroEmpresa_Click);
            // 
            // FormCadastroFinanceiroEmpresa
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btn_SalvarFinanceiroEmpresa);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.group_FinanceiroEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormCadastroFinanceiroEmpresa";
            this.group_FinanceiroEmpresa.ResumeLayout(false);
            this.group_FinanceiroEmpresa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_FinanceiroEmpresa;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_SalvarFinanceiroEmpresa;
        private System.Windows.Forms.TextBox txt_ContaEmpresa;
        private System.Windows.Forms.TextBox txt_AgenciaEmpresa;
        private System.Windows.Forms.ComboBox cmb_BancoEmpresa;
        private System.Windows.Forms.Label lbl_conta;
        private System.Windows.Forms.Label lbl_Agencia;
        private System.Windows.Forms.Label lbl_Banco;
    }
}