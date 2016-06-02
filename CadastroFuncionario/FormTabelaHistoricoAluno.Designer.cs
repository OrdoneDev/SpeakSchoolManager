namespace CadastroFuncionario
{
    partial class FormTabelaHistoricoAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabelaHistoricoAluno));
            this.btn_SalvarAlteracoes = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.group_TabelaHistoricoAluno = new System.Windows.Forms.GroupBox();
            this.btn_FiltrarAluno = new System.Windows.Forms.Button();
            this.cmb_NomeAluno = new System.Windows.Forms.ComboBox();
            this.lbl_NomeAluno = new System.Windows.Forms.Label();
            this.dgv_TabelaHistoricoAluno = new System.Windows.Forms.DataGridView();
            this.group_TabelaHistoricoAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaHistoricoAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SalvarAlteracoes
            // 
            resources.ApplyResources(this.btn_SalvarAlteracoes, "btn_SalvarAlteracoes");
            this.btn_SalvarAlteracoes.Name = "btn_SalvarAlteracoes";
            this.btn_SalvarAlteracoes.UseVisualStyleBackColor = true;
            this.btn_SalvarAlteracoes.Click += new System.EventHandler(this.btn_SalvarAlteracoes_Click);
            // 
            // btn_Cancelar
            // 
            resources.ApplyResources(this.btn_Cancelar, "btn_Cancelar");
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // group_TabelaHistoricoAluno
            // 
            this.group_TabelaHistoricoAluno.Controls.Add(this.btn_FiltrarAluno);
            this.group_TabelaHistoricoAluno.Controls.Add(this.cmb_NomeAluno);
            this.group_TabelaHistoricoAluno.Controls.Add(this.lbl_NomeAluno);
            this.group_TabelaHistoricoAluno.Controls.Add(this.dgv_TabelaHistoricoAluno);
            resources.ApplyResources(this.group_TabelaHistoricoAluno, "group_TabelaHistoricoAluno");
            this.group_TabelaHistoricoAluno.Name = "group_TabelaHistoricoAluno";
            this.group_TabelaHistoricoAluno.TabStop = false;
            // 
            // btn_FiltrarAluno
            // 
            resources.ApplyResources(this.btn_FiltrarAluno, "btn_FiltrarAluno");
            this.btn_FiltrarAluno.Name = "btn_FiltrarAluno";
            this.btn_FiltrarAluno.UseVisualStyleBackColor = true;
            this.btn_FiltrarAluno.Click += new System.EventHandler(this.btn_FiltrarAluno_Click);
            // 
            // cmb_NomeAluno
            // 
            this.cmb_NomeAluno.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_NomeAluno, "cmb_NomeAluno");
            this.cmb_NomeAluno.Name = "cmb_NomeAluno";
            this.cmb_NomeAluno.SelectedValueChanged += new System.EventHandler(this.cmb_NomeAluno_SelectedValueChanged);
            this.cmb_NomeAluno.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_NomeAluno_PreviewKeyDown);
            // 
            // lbl_NomeAluno
            // 
            resources.ApplyResources(this.lbl_NomeAluno, "lbl_NomeAluno");
            this.lbl_NomeAluno.Name = "lbl_NomeAluno";
            // 
            // dgv_TabelaHistoricoAluno
            // 
            this.dgv_TabelaHistoricoAluno.AllowUserToAddRows = false;
            this.dgv_TabelaHistoricoAluno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TabelaHistoricoAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgv_TabelaHistoricoAluno, "dgv_TabelaHistoricoAluno");
            this.dgv_TabelaHistoricoAluno.MultiSelect = false;
            this.dgv_TabelaHistoricoAluno.Name = "dgv_TabelaHistoricoAluno";
            this.dgv_TabelaHistoricoAluno.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_TabelaHistoricoAluno_DataError);
            // 
            // FormTabelaHistoricoAluno
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_SalvarAlteracoes);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.group_TabelaHistoricoAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormTabelaHistoricoAluno";
            this.Load += new System.EventHandler(this.FormTabelaHistoricoAluno_Load);
            this.group_TabelaHistoricoAluno.ResumeLayout(false);
            this.group_TabelaHistoricoAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaHistoricoAluno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SalvarAlteracoes;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.GroupBox group_TabelaHistoricoAluno;
        private System.Windows.Forms.Button btn_FiltrarAluno;
        private System.Windows.Forms.ComboBox cmb_NomeAluno;
        private System.Windows.Forms.Label lbl_NomeAluno;
        private System.Windows.Forms.DataGridView dgv_TabelaHistoricoAluno;
    }
}