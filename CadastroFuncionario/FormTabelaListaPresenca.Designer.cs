namespace CadastroFuncionario
{
    partial class FormTabelaListaPresenca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabelaListaPresenca));
            this.group_TabelaListaPresenca = new System.Windows.Forms.GroupBox();
            this.btn_FiltrarProfessor = new System.Windows.Forms.Button();
            this.cmb_NomeProfessor = new System.Windows.Forms.ComboBox();
            this.lbl_NomeProfessor = new System.Windows.Forms.Label();
            this.btn_FiltrarAluno = new System.Windows.Forms.Button();
            this.cmb_NomeAluno = new System.Windows.Forms.ComboBox();
            this.lbl_NomeAluno = new System.Windows.Forms.Label();
            this.dgv_TabelaListaPresenca = new System.Windows.Forms.DataGridView();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_SalvarAlteracoes = new System.Windows.Forms.Button();
            this.group_TabelaListaPresenca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaListaPresenca)).BeginInit();
            this.SuspendLayout();
            // 
            // group_TabelaListaPresenca
            // 
            resources.ApplyResources(this.group_TabelaListaPresenca, "group_TabelaListaPresenca");
            this.group_TabelaListaPresenca.Controls.Add(this.btn_FiltrarProfessor);
            this.group_TabelaListaPresenca.Controls.Add(this.cmb_NomeProfessor);
            this.group_TabelaListaPresenca.Controls.Add(this.lbl_NomeProfessor);
            this.group_TabelaListaPresenca.Controls.Add(this.btn_FiltrarAluno);
            this.group_TabelaListaPresenca.Controls.Add(this.cmb_NomeAluno);
            this.group_TabelaListaPresenca.Controls.Add(this.lbl_NomeAluno);
            this.group_TabelaListaPresenca.Controls.Add(this.dgv_TabelaListaPresenca);
            this.group_TabelaListaPresenca.Name = "group_TabelaListaPresenca";
            this.group_TabelaListaPresenca.TabStop = false;
            // 
            // btn_FiltrarProfessor
            // 
            resources.ApplyResources(this.btn_FiltrarProfessor, "btn_FiltrarProfessor");
            this.btn_FiltrarProfessor.Name = "btn_FiltrarProfessor";
            this.btn_FiltrarProfessor.UseVisualStyleBackColor = true;
            this.btn_FiltrarProfessor.Click += new System.EventHandler(this.btn_FiltrarProfessor_Click);
            // 
            // cmb_NomeProfessor
            // 
            this.cmb_NomeProfessor.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_NomeProfessor, "cmb_NomeProfessor");
            this.cmb_NomeProfessor.Name = "cmb_NomeProfessor";
            this.cmb_NomeProfessor.SelectedValueChanged += new System.EventHandler(this.cmb_NomeProfessor_SelectedValueChanged);
            this.cmb_NomeProfessor.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_NomeProfessor_PreviewKeyDown);
            // 
            // lbl_NomeProfessor
            // 
            resources.ApplyResources(this.lbl_NomeProfessor, "lbl_NomeProfessor");
            this.lbl_NomeProfessor.Name = "lbl_NomeProfessor";
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
            // dgv_TabelaListaPresenca
            // 
            this.dgv_TabelaListaPresenca.AllowUserToAddRows = false;
            resources.ApplyResources(this.dgv_TabelaListaPresenca, "dgv_TabelaListaPresenca");
            this.dgv_TabelaListaPresenca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TabelaListaPresenca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TabelaListaPresenca.MultiSelect = false;
            this.dgv_TabelaListaPresenca.Name = "dgv_TabelaListaPresenca";
            this.dgv_TabelaListaPresenca.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_TabelaListaPresenca_DataError);
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
            // FormTabelaListaPresenca
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_SalvarAlteracoes);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.group_TabelaListaPresenca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormTabelaListaPresenca";
            this.Load += new System.EventHandler(this.FormTabelaListaPresenca_Load);
            this.group_TabelaListaPresenca.ResumeLayout(false);
            this.group_TabelaListaPresenca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaListaPresenca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_TabelaListaPresenca;
        private System.Windows.Forms.Button btn_FiltrarProfessor;
        private System.Windows.Forms.ComboBox cmb_NomeProfessor;
        private System.Windows.Forms.Label lbl_NomeProfessor;
        private System.Windows.Forms.Button btn_FiltrarAluno;
        private System.Windows.Forms.ComboBox cmb_NomeAluno;
        private System.Windows.Forms.Label lbl_NomeAluno;
        private System.Windows.Forms.DataGridView dgv_TabelaListaPresenca;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_SalvarAlteracoes;
    }
}