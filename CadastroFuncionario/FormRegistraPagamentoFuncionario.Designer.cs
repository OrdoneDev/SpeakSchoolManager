namespace CadastroFuncionario
{
    partial class FormRegistraPagamentoFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistraPagamentoFuncionario));
            this.group_RegistraPagamentoFuncionario = new System.Windows.Forms.GroupBox();
            this.lbl_SalarioFuncionario = new System.Windows.Forms.Label();
            this.lbl_DataPagamento = new System.Windows.Forms.Label();
            this.dtp_DataPagamento = new System.Windows.Forms.DateTimePicker();
            this.cmb_NomeFuncionario = new System.Windows.Forms.ComboBox();
            this.lbl_NomeFuncionario = new System.Windows.Forms.Label();
            this.lbl_IdFuncionario = new System.Windows.Forms.Label();
            this.msk_IdFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_RegistrarPagamento = new System.Windows.Forms.Button();
            this.group_RegistraPagamentoFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_RegistraPagamentoFuncionario
            // 
            this.group_RegistraPagamentoFuncionario.Controls.Add(this.lbl_SalarioFuncionario);
            this.group_RegistraPagamentoFuncionario.Controls.Add(this.lbl_DataPagamento);
            this.group_RegistraPagamentoFuncionario.Controls.Add(this.dtp_DataPagamento);
            this.group_RegistraPagamentoFuncionario.Controls.Add(this.cmb_NomeFuncionario);
            this.group_RegistraPagamentoFuncionario.Controls.Add(this.lbl_NomeFuncionario);
            this.group_RegistraPagamentoFuncionario.Controls.Add(this.lbl_IdFuncionario);
            this.group_RegistraPagamentoFuncionario.Controls.Add(this.msk_IdFuncionario);
            resources.ApplyResources(this.group_RegistraPagamentoFuncionario, "group_RegistraPagamentoFuncionario");
            this.group_RegistraPagamentoFuncionario.Name = "group_RegistraPagamentoFuncionario";
            this.group_RegistraPagamentoFuncionario.TabStop = false;
            // 
            // lbl_SalarioFuncionario
            // 
            resources.ApplyResources(this.lbl_SalarioFuncionario, "lbl_SalarioFuncionario");
            this.lbl_SalarioFuncionario.Name = "lbl_SalarioFuncionario";
            this.lbl_SalarioFuncionario.Tag = "0";
            // 
            // lbl_DataPagamento
            // 
            resources.ApplyResources(this.lbl_DataPagamento, "lbl_DataPagamento");
            this.lbl_DataPagamento.Name = "lbl_DataPagamento";
            this.lbl_DataPagamento.Tag = "0";
            // 
            // dtp_DataPagamento
            // 
            this.dtp_DataPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtp_DataPagamento, "dtp_DataPagamento");
            this.dtp_DataPagamento.Name = "dtp_DataPagamento";
            // 
            // cmb_NomeFuncionario
            // 
            this.cmb_NomeFuncionario.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_NomeFuncionario, "cmb_NomeFuncionario");
            this.cmb_NomeFuncionario.Name = "cmb_NomeFuncionario";
            this.cmb_NomeFuncionario.SelectedValueChanged += new System.EventHandler(this.cmb_NomeFuncionario_SelectedValueChanged);
            this.cmb_NomeFuncionario.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_NomeFuncionario_PreviewKeyDown);
            // 
            // lbl_NomeFuncionario
            // 
            resources.ApplyResources(this.lbl_NomeFuncionario, "lbl_NomeFuncionario");
            this.lbl_NomeFuncionario.Name = "lbl_NomeFuncionario";
            this.lbl_NomeFuncionario.Tag = "0";
            // 
            // lbl_IdFuncionario
            // 
            resources.ApplyResources(this.lbl_IdFuncionario, "lbl_IdFuncionario");
            this.lbl_IdFuncionario.Name = "lbl_IdFuncionario";
            this.lbl_IdFuncionario.Tag = "0";
            // 
            // msk_IdFuncionario
            // 
            resources.ApplyResources(this.msk_IdFuncionario, "msk_IdFuncionario");
            this.msk_IdFuncionario.Name = "msk_IdFuncionario";
            this.msk_IdFuncionario.TextChanged += new System.EventHandler(this.msk_IdFuncionario_TextChanged);
            // 
            // btn_Cancelar
            // 
            resources.ApplyResources(this.btn_Cancelar, "btn_Cancelar");
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_RegistrarPagamento
            // 
            resources.ApplyResources(this.btn_RegistrarPagamento, "btn_RegistrarPagamento");
            this.btn_RegistrarPagamento.Name = "btn_RegistrarPagamento";
            this.btn_RegistrarPagamento.UseVisualStyleBackColor = true;
            this.btn_RegistrarPagamento.Click += new System.EventHandler(this.btn_RegistrarPagamento_Click);
            // 
            // FormRegistraPagamentoFuncionario
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_RegistrarPagamento);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.group_RegistraPagamentoFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegistraPagamentoFuncionario";
            this.group_RegistraPagamentoFuncionario.ResumeLayout(false);
            this.group_RegistraPagamentoFuncionario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_RegistraPagamentoFuncionario;
        private System.Windows.Forms.DateTimePicker dtp_DataPagamento;
        private System.Windows.Forms.ComboBox cmb_NomeFuncionario;
        private System.Windows.Forms.Label lbl_NomeFuncionario;
        private System.Windows.Forms.Label lbl_IdFuncionario;
        private System.Windows.Forms.MaskedTextBox msk_IdFuncionario;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_RegistrarPagamento;
        private System.Windows.Forms.Label lbl_DataPagamento;
        private System.Windows.Forms.Label lbl_SalarioFuncionario;
    }
}