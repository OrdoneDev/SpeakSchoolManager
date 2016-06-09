namespace CadastroFuncionario
{
    partial class FormHistoricoFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistoricoFuncionario));
            this.group_HistoricoFuncionario = new System.Windows.Forms.GroupBox();
            this.cmb_NomeFuncionario = new System.Windows.Forms.ComboBox();
            this.txb_HistoricoFuncionario = new System.Windows.Forms.RichTextBox();
            this.lbl_HistoricoFuncionario = new System.Windows.Forms.Label();
            this.lbl_IdFuncionario = new System.Windows.Forms.Label();
            this.lbl_NomeFuncionario = new System.Windows.Forms.Label();
            this.msk_IdFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.lbl_DataHistoricoFuncionario = new System.Windows.Forms.Label();
            this.dte_DataHistoricoFuncionario = new System.Windows.Forms.DateTimePicker();
            this.btn_SalvarHistoricoFuncionario = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.group_HistoricoFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_HistoricoFuncionario
            // 
            this.group_HistoricoFuncionario.Controls.Add(this.cmb_NomeFuncionario);
            this.group_HistoricoFuncionario.Controls.Add(this.txb_HistoricoFuncionario);
            this.group_HistoricoFuncionario.Controls.Add(this.lbl_HistoricoFuncionario);
            this.group_HistoricoFuncionario.Controls.Add(this.lbl_IdFuncionario);
            this.group_HistoricoFuncionario.Controls.Add(this.lbl_NomeFuncionario);
            this.group_HistoricoFuncionario.Controls.Add(this.msk_IdFuncionario);
            this.group_HistoricoFuncionario.Controls.Add(this.lbl_DataHistoricoFuncionario);
            this.group_HistoricoFuncionario.Controls.Add(this.dte_DataHistoricoFuncionario);
            resources.ApplyResources(this.group_HistoricoFuncionario, "group_HistoricoFuncionario");
            this.group_HistoricoFuncionario.Name = "group_HistoricoFuncionario";
            this.group_HistoricoFuncionario.TabStop = false;
            // 
            // cmb_NomeFuncionario
            // 
            this.cmb_NomeFuncionario.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_NomeFuncionario, "cmb_NomeFuncionario");
            this.cmb_NomeFuncionario.Name = "cmb_NomeFuncionario";
            this.cmb_NomeFuncionario.SelectedValueChanged += new System.EventHandler(this.cmb_NomeFuncionario_SelectedValueChanged);
            this.cmb_NomeFuncionario.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_NomeFuncionario_PreviewKeyDown);
            // 
            // txb_HistoricoFuncionario
            // 
            resources.ApplyResources(this.txb_HistoricoFuncionario, "txb_HistoricoFuncionario");
            this.txb_HistoricoFuncionario.Name = "txb_HistoricoFuncionario";
            // 
            // lbl_HistoricoFuncionario
            // 
            resources.ApplyResources(this.lbl_HistoricoFuncionario, "lbl_HistoricoFuncionario");
            this.lbl_HistoricoFuncionario.Name = "lbl_HistoricoFuncionario";
            // 
            // lbl_IdFuncionario
            // 
            resources.ApplyResources(this.lbl_IdFuncionario, "lbl_IdFuncionario");
            this.lbl_IdFuncionario.Name = "lbl_IdFuncionario";
            this.lbl_IdFuncionario.Tag = "0";
            // 
            // lbl_NomeFuncionario
            // 
            resources.ApplyResources(this.lbl_NomeFuncionario, "lbl_NomeFuncionario");
            this.lbl_NomeFuncionario.Name = "lbl_NomeFuncionario";
            // 
            // msk_IdFuncionario
            // 
            resources.ApplyResources(this.msk_IdFuncionario, "msk_IdFuncionario");
            this.msk_IdFuncionario.Name = "msk_IdFuncionario";
            this.msk_IdFuncionario.Tag = "";
            this.msk_IdFuncionario.TextChanged += new System.EventHandler(this.msk_IdFuncionario_TextChanged);
            // 
            // lbl_DataHistoricoFuncionario
            // 
            resources.ApplyResources(this.lbl_DataHistoricoFuncionario, "lbl_DataHistoricoFuncionario");
            this.lbl_DataHistoricoFuncionario.Name = "lbl_DataHistoricoFuncionario";
            // 
            // dte_DataHistoricoFuncionario
            // 
            resources.ApplyResources(this.dte_DataHistoricoFuncionario, "dte_DataHistoricoFuncionario");
            this.dte_DataHistoricoFuncionario.Name = "dte_DataHistoricoFuncionario";
            // 
            // btn_SalvarHistoricoFuncionario
            // 
            resources.ApplyResources(this.btn_SalvarHistoricoFuncionario, "btn_SalvarHistoricoFuncionario");
            this.btn_SalvarHistoricoFuncionario.Name = "btn_SalvarHistoricoFuncionario";
            this.btn_SalvarHistoricoFuncionario.UseVisualStyleBackColor = true;
            this.btn_SalvarHistoricoFuncionario.Click += new System.EventHandler(this.btn_SalvarHistoricoFuncionario_Click);
            // 
            // btn_Cancelar
            // 
            resources.ApplyResources(this.btn_Cancelar, "btn_Cancelar");
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // FormHistoricoFuncionario
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_SalvarHistoricoFuncionario);
            this.Controls.Add(this.group_HistoricoFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHistoricoFuncionario";
            this.group_HistoricoFuncionario.ResumeLayout(false);
            this.group_HistoricoFuncionario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_HistoricoFuncionario;
        private System.Windows.Forms.Label lbl_DataHistoricoFuncionario;
        private System.Windows.Forms.DateTimePicker dte_DataHistoricoFuncionario;
        private System.Windows.Forms.RichTextBox txb_HistoricoFuncionario;
        private System.Windows.Forms.Label lbl_HistoricoFuncionario;
        private System.Windows.Forms.Label lbl_IdFuncionario;
        private System.Windows.Forms.Label lbl_NomeFuncionario;
        private System.Windows.Forms.MaskedTextBox msk_IdFuncionario;
        private System.Windows.Forms.Button btn_SalvarHistoricoFuncionario;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.ComboBox cmb_NomeFuncionario;
    }
}