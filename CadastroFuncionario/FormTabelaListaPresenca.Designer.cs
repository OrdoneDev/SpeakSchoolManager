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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabelaListaPresenca));
            this.group_TabelaListaPresenca = new System.Windows.Forms.GroupBox();
            this.btn_FiltrarProfessor = new System.Windows.Forms.Button();
            this.cmb_NomeProfessor = new System.Windows.Forms.ComboBox();
            this.lbl_NomeProfessor = new System.Windows.Forms.Label();
            this.btn_FiltrarAluno = new System.Windows.Forms.Button();
            this.cmb_NomeAluno = new System.Windows.Forms.ComboBox();
            this.lbl_NomeAluno = new System.Windows.Forms.Label();
            this.dgv_TabelaListaPresenca = new System.Windows.Forms.DataGridView();
            this.idPresencaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idInscricaoTurmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chamadaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaPresencaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_EscolaDataSet15 = new CadastroFuncionario.DB_EscolaDataSet15();
            this.lista_PresencaTableAdapter = new CadastroFuncionario.DB_EscolaDataSet15TableAdapters.Lista_PresencaTableAdapter();
            this.btn_MostrarTodos = new System.Windows.Forms.Button();
            this.group_TabelaListaPresenca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaListaPresenca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPresencaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet15)).BeginInit();
            this.SuspendLayout();
            // 
            // group_TabelaListaPresenca
            // 
            this.group_TabelaListaPresenca.Controls.Add(this.btn_MostrarTodos);
            this.group_TabelaListaPresenca.Controls.Add(this.btn_FiltrarProfessor);
            this.group_TabelaListaPresenca.Controls.Add(this.cmb_NomeProfessor);
            this.group_TabelaListaPresenca.Controls.Add(this.lbl_NomeProfessor);
            this.group_TabelaListaPresenca.Controls.Add(this.btn_FiltrarAluno);
            this.group_TabelaListaPresenca.Controls.Add(this.cmb_NomeAluno);
            this.group_TabelaListaPresenca.Controls.Add(this.lbl_NomeAluno);
            this.group_TabelaListaPresenca.Controls.Add(this.dgv_TabelaListaPresenca);
            resources.ApplyResources(this.group_TabelaListaPresenca, "group_TabelaListaPresenca");
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
            this.dgv_TabelaListaPresenca.AutoGenerateColumns = false;
            this.dgv_TabelaListaPresenca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TabelaListaPresenca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TabelaListaPresenca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPresencaDataGridViewTextBoxColumn,
            this.idInscricaoTurmaDataGridViewTextBoxColumn,
            this.chamadaDataGridViewCheckBoxColumn,
            this.dataDataGridViewTextBoxColumn});
            this.dgv_TabelaListaPresenca.DataSource = this.listaPresencaBindingSource;
            resources.ApplyResources(this.dgv_TabelaListaPresenca, "dgv_TabelaListaPresenca");
            this.dgv_TabelaListaPresenca.Name = "dgv_TabelaListaPresenca";
            // 
            // idPresencaDataGridViewTextBoxColumn
            // 
            this.idPresencaDataGridViewTextBoxColumn.DataPropertyName = "Id_Presenca";
            resources.ApplyResources(this.idPresencaDataGridViewTextBoxColumn, "idPresencaDataGridViewTextBoxColumn");
            this.idPresencaDataGridViewTextBoxColumn.Name = "idPresencaDataGridViewTextBoxColumn";
            this.idPresencaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idInscricaoTurmaDataGridViewTextBoxColumn
            // 
            this.idInscricaoTurmaDataGridViewTextBoxColumn.DataPropertyName = "Id_Inscricao_Turma";
            resources.ApplyResources(this.idInscricaoTurmaDataGridViewTextBoxColumn, "idInscricaoTurmaDataGridViewTextBoxColumn");
            this.idInscricaoTurmaDataGridViewTextBoxColumn.Name = "idInscricaoTurmaDataGridViewTextBoxColumn";
            // 
            // chamadaDataGridViewCheckBoxColumn
            // 
            this.chamadaDataGridViewCheckBoxColumn.DataPropertyName = "Chamada";
            resources.ApplyResources(this.chamadaDataGridViewCheckBoxColumn, "chamadaDataGridViewCheckBoxColumn");
            this.chamadaDataGridViewCheckBoxColumn.Name = "chamadaDataGridViewCheckBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            resources.ApplyResources(this.dataDataGridViewTextBoxColumn, "dataDataGridViewTextBoxColumn");
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // listaPresencaBindingSource
            // 
            this.listaPresencaBindingSource.DataMember = "Lista_Presenca";
            this.listaPresencaBindingSource.DataSource = this.dB_EscolaDataSet15;
            // 
            // dB_EscolaDataSet15
            // 
            this.dB_EscolaDataSet15.DataSetName = "DB_EscolaDataSet15";
            this.dB_EscolaDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lista_PresencaTableAdapter
            // 
            this.lista_PresencaTableAdapter.ClearBeforeFill = true;
            // 
            // btn_MostrarTodos
            // 
            resources.ApplyResources(this.btn_MostrarTodos, "btn_MostrarTodos");
            this.btn_MostrarTodos.Name = "btn_MostrarTodos";
            this.btn_MostrarTodos.UseVisualStyleBackColor = true;
            this.btn_MostrarTodos.Click += new System.EventHandler(this.btn_MostrarTodos_Click);
            // 
            // FormTabelaListaPresenca
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.group_TabelaListaPresenca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormTabelaListaPresenca";
            this.Load += new System.EventHandler(this.FormTabelaListaPresenca_Load);
            this.group_TabelaListaPresenca.ResumeLayout(false);
            this.group_TabelaListaPresenca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaListaPresenca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPresencaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet15)).EndInit();
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
        private DB_EscolaDataSet15 dB_EscolaDataSet15;
        private System.Windows.Forms.BindingSource listaPresencaBindingSource;
        private DB_EscolaDataSet15TableAdapters.Lista_PresencaTableAdapter lista_PresencaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPresencaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInscricaoTurmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chamadaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_MostrarTodos;
    }
}