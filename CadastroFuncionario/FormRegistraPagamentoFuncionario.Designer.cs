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
            this.group_RegistraPagamentoFuncionario = new System.Windows.Forms.GroupBox();
            this.lbl_DataPagamento = new System.Windows.Forms.Label();
            this.dtp_DataPagamento = new System.Windows.Forms.DateTimePicker();
            this.cmb_NomeFuncionario = new System.Windows.Forms.ComboBox();
            this.lbl_NomeFuncionario = new System.Windows.Forms.Label();
            this.lbl_IdFuncionario = new System.Windows.Forms.Label();
            this.msk_IdFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_RegistrarPagamento = new System.Windows.Forms.Button();
            this.lbl_SalarioFuncionario = new System.Windows.Forms.Label();
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
            this.group_RegistraPagamentoFuncionario.Location = new System.Drawing.Point(13, 13);
            this.group_RegistraPagamentoFuncionario.Name = "group_RegistraPagamentoFuncionario";
            this.group_RegistraPagamentoFuncionario.Size = new System.Drawing.Size(600, 61);
            this.group_RegistraPagamentoFuncionario.TabIndex = 0;
            this.group_RegistraPagamentoFuncionario.TabStop = false;
            this.group_RegistraPagamentoFuncionario.Text = "Pagamento de funcionário";
            // 
            // lbl_DataPagamento
            // 
            this.lbl_DataPagamento.AutoSize = true;
            this.lbl_DataPagamento.Location = new System.Drawing.Point(462, 28);
            this.lbl_DataPagamento.Name = "lbl_DataPagamento";
            this.lbl_DataPagamento.Size = new System.Drawing.Size(33, 13);
            this.lbl_DataPagamento.TabIndex = 5;
            this.lbl_DataPagamento.Tag = "0";
            this.lbl_DataPagamento.Text = "Data:";
            // 
            // dtp_DataPagamento
            // 
            this.dtp_DataPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DataPagamento.Location = new System.Drawing.Point(498, 26);
            this.dtp_DataPagamento.Name = "dtp_DataPagamento";
            this.dtp_DataPagamento.Size = new System.Drawing.Size(95, 20);
            this.dtp_DataPagamento.TabIndex = 4;
            // 
            // cmb_NomeFuncionario
            // 
            this.cmb_NomeFuncionario.FormattingEnabled = true;
            this.cmb_NomeFuncionario.Location = new System.Drawing.Point(164, 25);
            this.cmb_NomeFuncionario.MaxLength = 40;
            this.cmb_NomeFuncionario.Name = "cmb_NomeFuncionario";
            this.cmb_NomeFuncionario.Size = new System.Drawing.Size(191, 21);
            this.cmb_NomeFuncionario.TabIndex = 3;
            this.cmb_NomeFuncionario.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_NomeFuncionario_PreviewKeyDown);
            // 
            // lbl_NomeFuncionario
            // 
            this.lbl_NomeFuncionario.AutoSize = true;
            this.lbl_NomeFuncionario.Location = new System.Drawing.Point(123, 29);
            this.lbl_NomeFuncionario.Name = "lbl_NomeFuncionario";
            this.lbl_NomeFuncionario.Size = new System.Drawing.Size(38, 13);
            this.lbl_NomeFuncionario.TabIndex = 2;
            this.lbl_NomeFuncionario.Tag = "0";
            this.lbl_NomeFuncionario.Text = "Nome:";
            // 
            // lbl_IdFuncionario
            // 
            this.lbl_IdFuncionario.AutoSize = true;
            this.lbl_IdFuncionario.Location = new System.Drawing.Point(6, 29);
            this.lbl_IdFuncionario.Name = "lbl_IdFuncionario";
            this.lbl_IdFuncionario.Size = new System.Drawing.Size(74, 13);
            this.lbl_IdFuncionario.TabIndex = 1;
            this.lbl_IdFuncionario.Tag = "0";
            this.lbl_IdFuncionario.Text = "Id funcionário:";
            // 
            // msk_IdFuncionario
            // 
            this.msk_IdFuncionario.Location = new System.Drawing.Point(82, 26);
            this.msk_IdFuncionario.Mask = "0000";
            this.msk_IdFuncionario.Name = "msk_IdFuncionario";
            this.msk_IdFuncionario.Size = new System.Drawing.Size(32, 20);
            this.msk_IdFuncionario.TabIndex = 0;
            this.msk_IdFuncionario.TextChanged += new System.EventHandler(this.msk_IdFuncionario_TextChanged);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(538, 80);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_RegistrarPagamento
            // 
            this.btn_RegistrarPagamento.Location = new System.Drawing.Point(414, 80);
            this.btn_RegistrarPagamento.Name = "btn_RegistrarPagamento";
            this.btn_RegistrarPagamento.Size = new System.Drawing.Size(118, 23);
            this.btn_RegistrarPagamento.TabIndex = 2;
            this.btn_RegistrarPagamento.Text = "Registrar pagamento";
            this.btn_RegistrarPagamento.UseVisualStyleBackColor = true;
            this.btn_RegistrarPagamento.Click += new System.EventHandler(this.btn_RegistrarPagamento_Click);
            // 
            // lbl_SalarioFuncionario
            // 
            this.lbl_SalarioFuncionario.AutoSize = true;
            this.lbl_SalarioFuncionario.Location = new System.Drawing.Point(362, 29);
            this.lbl_SalarioFuncionario.Name = "lbl_SalarioFuncionario";
            this.lbl_SalarioFuncionario.Size = new System.Drawing.Size(0, 13);
            this.lbl_SalarioFuncionario.TabIndex = 6;
            this.lbl_SalarioFuncionario.Tag = "0";
            // 
            // FormRegistraPagamentoFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 113);
            this.Controls.Add(this.btn_RegistrarPagamento);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.group_RegistraPagamentoFuncionario);
            this.Name = "FormRegistraPagamentoFuncionario";
            this.Text = "Registrar pagamento de funcionário";
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