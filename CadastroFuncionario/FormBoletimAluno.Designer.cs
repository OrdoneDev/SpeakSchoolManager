namespace CadastroFuncionario
{
    partial class FormBoletimAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBoletimAluno));
            this.group_BoletimAluno = new System.Windows.Forms.GroupBox();
            this.lbl_IdAluno = new System.Windows.Forms.Label();
            this.msk_IdAluno = new System.Windows.Forms.MaskedTextBox();
            this.lbl_NomeAluno = new System.Windows.Forms.Label();
            this.cmb_NomeAluno = new System.Windows.Forms.ComboBox();
            this.dgv_BoletimAluno = new System.Windows.Forms.DataGridView();
            this.btn_ConsultarBoletim = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_SalvarAlteracoes = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_BoletimAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BoletimAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // group_BoletimAluno
            // 
            resources.ApplyResources(this.group_BoletimAluno, "group_BoletimAluno");
            this.group_BoletimAluno.Controls.Add(this.lbl_IdAluno);
            this.group_BoletimAluno.Controls.Add(this.msk_IdAluno);
            this.group_BoletimAluno.Controls.Add(this.lbl_NomeAluno);
            this.group_BoletimAluno.Controls.Add(this.cmb_NomeAluno);
            this.group_BoletimAluno.Controls.Add(this.dgv_BoletimAluno);
            this.group_BoletimAluno.Controls.Add(this.btn_ConsultarBoletim);
            this.group_BoletimAluno.Name = "group_BoletimAluno";
            this.group_BoletimAluno.TabStop = false;
            this.group_BoletimAluno.Tag = "0";
            // 
            // lbl_IdAluno
            // 
            resources.ApplyResources(this.lbl_IdAluno, "lbl_IdAluno");
            this.lbl_IdAluno.Name = "lbl_IdAluno";
            this.lbl_IdAluno.Tag = "0";
            // 
            // msk_IdAluno
            // 
            resources.ApplyResources(this.msk_IdAluno, "msk_IdAluno");
            this.msk_IdAluno.Name = "msk_IdAluno";
            this.msk_IdAluno.TextChanged += new System.EventHandler(this.msk_IdAluno_TextChanged);
            // 
            // lbl_NomeAluno
            // 
            resources.ApplyResources(this.lbl_NomeAluno, "lbl_NomeAluno");
            this.lbl_NomeAluno.Name = "lbl_NomeAluno";
            this.lbl_NomeAluno.Tag = "0";
            // 
            // cmb_NomeAluno
            // 
            this.cmb_NomeAluno.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_NomeAluno.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_NomeAluno.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_NomeAluno, "cmb_NomeAluno");
            this.cmb_NomeAluno.Name = "cmb_NomeAluno";
            this.cmb_NomeAluno.SelectedValueChanged += new System.EventHandler(this.cmb_NomeAluno_SelectedValueChanged);
            this.cmb_NomeAluno.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_NomeAluno_PreviewKeyDown);
            // 
            // dgv_BoletimAluno
            // 
            this.dgv_BoletimAluno.AllowUserToAddRows = false;
            this.dgv_BoletimAluno.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dgv_BoletimAluno, "dgv_BoletimAluno");
            this.dgv_BoletimAluno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BoletimAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BoletimAluno.MultiSelect = false;
            this.dgv_BoletimAluno.Name = "dgv_BoletimAluno";
            this.dgv_BoletimAluno.Tag = "0";
            this.dgv_BoletimAluno.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dgv_BoletimAluno_CellParsing);
            this.dgv_BoletimAluno.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_BoletimAluno_DataError);
            // 
            // btn_ConsultarBoletim
            // 
            resources.ApplyResources(this.btn_ConsultarBoletim, "btn_ConsultarBoletim");
            this.btn_ConsultarBoletim.Name = "btn_ConsultarBoletim";
            this.btn_ConsultarBoletim.Tag = "0";
            this.btn_ConsultarBoletim.UseVisualStyleBackColor = true;
            this.btn_ConsultarBoletim.Click += new System.EventHandler(this.btn_ConsultarBoletim_Click);
            // 
            // btn_Cancelar
            // 
            resources.ApplyResources(this.btn_Cancelar, "btn_Cancelar");
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_SalvarAlteracoes
            // 
            resources.ApplyResources(this.btn_SalvarAlteracoes, "btn_SalvarAlteracoes");
            this.btn_SalvarAlteracoes.Name = "btn_SalvarAlteracoes";
            this.btn_SalvarAlteracoes.UseVisualStyleBackColor = true;
            this.btn_SalvarAlteracoes.Click += new System.EventHandler(this.btn_SalvarAlteracoes_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id_Boletim";
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            // 
            // mediaDataGridViewTextBoxColumn
            // 
            this.mediaDataGridViewTextBoxColumn.DataPropertyName = "Media";
            resources.ApplyResources(this.mediaDataGridViewTextBoxColumn, "mediaDataGridViewTextBoxColumn");
            this.mediaDataGridViewTextBoxColumn.Name = "mediaDataGridViewTextBoxColumn";
            this.mediaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Id_Boletim";
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            // 
            // FormBoletimAluno
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_SalvarAlteracoes);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.group_BoletimAluno);
            this.MinimizeBox = false;
            this.Name = "FormBoletimAluno";
            this.Load += new System.EventHandler(this.FormBoletimAluno_Load);
            this.group_BoletimAluno.ResumeLayout(false);
            this.group_BoletimAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BoletimAluno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_BoletimAluno;
        private System.Windows.Forms.Button btn_ConsultarBoletim;
        private System.Windows.Forms.Label lbl_IdAluno;
        private System.Windows.Forms.MaskedTextBox msk_IdAluno;
        private System.Windows.Forms.Label lbl_NomeAluno;
        private System.Windows.Forms.ComboBox cmb_NomeAluno;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_SalvarAlteracoes;
        private System.Windows.Forms.DataGridView dgv_BoletimAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}