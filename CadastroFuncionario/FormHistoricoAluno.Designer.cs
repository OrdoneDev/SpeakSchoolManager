namespace CadastroFuncionario
{
    partial class FormHistoricoAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistoricoAluno));
            this.group_HistoricoAluno = new System.Windows.Forms.GroupBox();
            this.cmb_NomeAluno = new System.Windows.Forms.ComboBox();
            this.txb_HistoricoAluno = new System.Windows.Forms.RichTextBox();
            this.lbl_HistoricoAluno = new System.Windows.Forms.Label();
            this.lbl_IdAluno = new System.Windows.Forms.Label();
            this.lbl_NomeAluno = new System.Windows.Forms.Label();
            this.msk_IdAluno = new System.Windows.Forms.MaskedTextBox();
            this.lbl_DataHistoricoAluno = new System.Windows.Forms.Label();
            this.dte_DataHistoricoAluno = new System.Windows.Forms.DateTimePicker();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_SalvarHistoricoAluno = new System.Windows.Forms.Button();
            this.group_HistoricoAluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_HistoricoAluno
            // 
            this.group_HistoricoAluno.Controls.Add(this.cmb_NomeAluno);
            this.group_HistoricoAluno.Controls.Add(this.txb_HistoricoAluno);
            this.group_HistoricoAluno.Controls.Add(this.lbl_HistoricoAluno);
            this.group_HistoricoAluno.Controls.Add(this.lbl_IdAluno);
            this.group_HistoricoAluno.Controls.Add(this.lbl_NomeAluno);
            this.group_HistoricoAluno.Controls.Add(this.msk_IdAluno);
            this.group_HistoricoAluno.Controls.Add(this.lbl_DataHistoricoAluno);
            this.group_HistoricoAluno.Controls.Add(this.dte_DataHistoricoAluno);
            resources.ApplyResources(this.group_HistoricoAluno, "group_HistoricoAluno");
            this.group_HistoricoAluno.Name = "group_HistoricoAluno";
            this.group_HistoricoAluno.TabStop = false;
            // 
            // cmb_NomeAluno
            // 
            this.cmb_NomeAluno.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_NomeAluno, "cmb_NomeAluno");
            this.cmb_NomeAluno.Name = "cmb_NomeAluno";
            this.cmb_NomeAluno.SelectedValueChanged += new System.EventHandler(this.cmb_NomeAluno_SelectedValueChanged);
            this.cmb_NomeAluno.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_NomeAluno_PreviewKeyDown);
            // 
            // txb_HistoricoAluno
            // 
            resources.ApplyResources(this.txb_HistoricoAluno, "txb_HistoricoAluno");
            this.txb_HistoricoAluno.Name = "txb_HistoricoAluno";
            // 
            // lbl_HistoricoAluno
            // 
            resources.ApplyResources(this.lbl_HistoricoAluno, "lbl_HistoricoAluno");
            this.lbl_HistoricoAluno.Name = "lbl_HistoricoAluno";
            // 
            // lbl_IdAluno
            // 
            resources.ApplyResources(this.lbl_IdAluno, "lbl_IdAluno");
            this.lbl_IdAluno.Name = "lbl_IdAluno";
            this.lbl_IdAluno.Tag = "0";
            // 
            // lbl_NomeAluno
            // 
            resources.ApplyResources(this.lbl_NomeAluno, "lbl_NomeAluno");
            this.lbl_NomeAluno.Name = "lbl_NomeAluno";
            // 
            // msk_IdAluno
            // 
            resources.ApplyResources(this.msk_IdAluno, "msk_IdAluno");
            this.msk_IdAluno.Name = "msk_IdAluno";
            this.msk_IdAluno.Tag = "";
            this.msk_IdAluno.TextChanged += new System.EventHandler(this.msk_IdAluno_TextChanged);
            // 
            // lbl_DataHistoricoAluno
            // 
            resources.ApplyResources(this.lbl_DataHistoricoAluno, "lbl_DataHistoricoAluno");
            this.lbl_DataHistoricoAluno.Name = "lbl_DataHistoricoAluno";
            // 
            // dte_DataHistoricoAluno
            // 
            resources.ApplyResources(this.dte_DataHistoricoAluno, "dte_DataHistoricoAluno");
            this.dte_DataHistoricoAluno.Name = "dte_DataHistoricoAluno";
            // 
            // btn_Cancelar
            // 
            resources.ApplyResources(this.btn_Cancelar, "btn_Cancelar");
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_SalvarHistoricoAluno
            // 
            resources.ApplyResources(this.btn_SalvarHistoricoAluno, "btn_SalvarHistoricoAluno");
            this.btn_SalvarHistoricoAluno.Name = "btn_SalvarHistoricoAluno";
            this.btn_SalvarHistoricoAluno.UseVisualStyleBackColor = true;
            this.btn_SalvarHistoricoAluno.Click += new System.EventHandler(this.btn_SalvarHistoricoAluno_Click);
            // 
            // FormHistoricoAluno
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_SalvarHistoricoAluno);
            this.Controls.Add(this.group_HistoricoAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormHistoricoAluno";
            this.group_HistoricoAluno.ResumeLayout(false);
            this.group_HistoricoAluno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_HistoricoAluno;
        private System.Windows.Forms.ComboBox cmb_NomeAluno;
        private System.Windows.Forms.RichTextBox txb_HistoricoAluno;
        private System.Windows.Forms.Label lbl_HistoricoAluno;
        private System.Windows.Forms.Label lbl_IdAluno;
        private System.Windows.Forms.Label lbl_NomeAluno;
        private System.Windows.Forms.MaskedTextBox msk_IdAluno;
        private System.Windows.Forms.Label lbl_DataHistoricoAluno;
        private System.Windows.Forms.DateTimePicker dte_DataHistoricoAluno;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_SalvarHistoricoAluno;
    }
}