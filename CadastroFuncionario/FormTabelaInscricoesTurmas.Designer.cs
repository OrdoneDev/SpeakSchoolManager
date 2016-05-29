namespace CadastroFuncionario
{
    partial class FormTabelaInscricoesTurmas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabelaInscricoesTurmas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_TabelaInscricoesTurmas = new System.Windows.Forms.DataGridView();
            this.lbl_NomeAluno = new System.Windows.Forms.Label();
            this.cmb_NomeAluno = new System.Windows.Forms.ComboBox();
            this.btn_FiltrarAluno = new System.Windows.Forms.Button();
            this.lbl_NomeFuncionario = new System.Windows.Forms.Label();
            this.cmb_NomeFuncionario = new System.Windows.Forms.ComboBox();
            this.btn_FiltrarFuncionario = new System.Windows.Forms.Button();
            this.dB_EscolaDataSet14 = new CadastroFuncionario.DB_EscolaDataSet14();
            this.inscricoesTurmasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inscricoes_TurmasTableAdapter = new CadastroFuncionario.DB_EscolaDataSet14TableAdapters.Inscricoes_TurmasTableAdapter();
            this.idInscricaoTurmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idInscricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTurmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaInscricoesTurmas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricoesTurmasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_FiltrarFuncionario);
            this.groupBox1.Controls.Add(this.cmb_NomeFuncionario);
            this.groupBox1.Controls.Add(this.lbl_NomeFuncionario);
            this.groupBox1.Controls.Add(this.btn_FiltrarAluno);
            this.groupBox1.Controls.Add(this.cmb_NomeAluno);
            this.groupBox1.Controls.Add(this.lbl_NomeAluno);
            this.groupBox1.Controls.Add(this.dgv_TabelaInscricoesTurmas);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // dgv_TabelaInscricoesTurmas
            // 
            this.dgv_TabelaInscricoesTurmas.AllowUserToAddRows = false;
            this.dgv_TabelaInscricoesTurmas.AutoGenerateColumns = false;
            this.dgv_TabelaInscricoesTurmas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TabelaInscricoesTurmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TabelaInscricoesTurmas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInscricaoTurmaDataGridViewTextBoxColumn,
            this.idInscricaoDataGridViewTextBoxColumn,
            this.idTurmaDataGridViewTextBoxColumn});
            this.dgv_TabelaInscricoesTurmas.DataSource = this.inscricoesTurmasBindingSource;
            resources.ApplyResources(this.dgv_TabelaInscricoesTurmas, "dgv_TabelaInscricoesTurmas");
            this.dgv_TabelaInscricoesTurmas.Name = "dgv_TabelaInscricoesTurmas";
            // 
            // lbl_NomeAluno
            // 
            resources.ApplyResources(this.lbl_NomeAluno, "lbl_NomeAluno");
            this.lbl_NomeAluno.Name = "lbl_NomeAluno";
            // 
            // cmb_NomeAluno
            // 
            this.cmb_NomeAluno.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_NomeAluno, "cmb_NomeAluno");
            this.cmb_NomeAluno.Name = "cmb_NomeAluno";
            this.cmb_NomeAluno.SelectedValueChanged += new System.EventHandler(this.cmb_NomeAluno_SelectedValueChanged);
            this.cmb_NomeAluno.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_NomeAluno_PreviewKeyDown);
            // 
            // btn_FiltrarAluno
            // 
            resources.ApplyResources(this.btn_FiltrarAluno, "btn_FiltrarAluno");
            this.btn_FiltrarAluno.Name = "btn_FiltrarAluno";
            this.btn_FiltrarAluno.UseVisualStyleBackColor = true;
            this.btn_FiltrarAluno.Click += new System.EventHandler(this.btn_FiltrarAluno_Click);
            // 
            // lbl_NomeFuncionario
            // 
            resources.ApplyResources(this.lbl_NomeFuncionario, "lbl_NomeFuncionario");
            this.lbl_NomeFuncionario.Name = "lbl_NomeFuncionario";
            // 
            // cmb_NomeFuncionario
            // 
            this.cmb_NomeFuncionario.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_NomeFuncionario, "cmb_NomeFuncionario");
            this.cmb_NomeFuncionario.Name = "cmb_NomeFuncionario";
            this.cmb_NomeFuncionario.SelectedValueChanged += new System.EventHandler(this.cmb_NomeFuncionario_SelectedValueChanged);
            this.cmb_NomeFuncionario.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_NomeFuncionario_PreviewKeyDown);
            // 
            // btn_FiltrarFuncionario
            // 
            resources.ApplyResources(this.btn_FiltrarFuncionario, "btn_FiltrarFuncionario");
            this.btn_FiltrarFuncionario.Name = "btn_FiltrarFuncionario";
            this.btn_FiltrarFuncionario.UseVisualStyleBackColor = true;
            this.btn_FiltrarFuncionario.Click += new System.EventHandler(this.btn_FiltrarFuncionario_Click);
            // 
            // dB_EscolaDataSet14
            // 
            this.dB_EscolaDataSet14.DataSetName = "DB_EscolaDataSet14";
            this.dB_EscolaDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inscricoesTurmasBindingSource
            // 
            this.inscricoesTurmasBindingSource.DataMember = "Inscricoes_Turmas";
            this.inscricoesTurmasBindingSource.DataSource = this.dB_EscolaDataSet14;
            // 
            // inscricoes_TurmasTableAdapter
            // 
            this.inscricoes_TurmasTableAdapter.ClearBeforeFill = true;
            // 
            // idInscricaoTurmaDataGridViewTextBoxColumn
            // 
            this.idInscricaoTurmaDataGridViewTextBoxColumn.DataPropertyName = "Id_Inscricao_Turma";
            resources.ApplyResources(this.idInscricaoTurmaDataGridViewTextBoxColumn, "idInscricaoTurmaDataGridViewTextBoxColumn");
            this.idInscricaoTurmaDataGridViewTextBoxColumn.Name = "idInscricaoTurmaDataGridViewTextBoxColumn";
            this.idInscricaoTurmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idInscricaoDataGridViewTextBoxColumn
            // 
            this.idInscricaoDataGridViewTextBoxColumn.DataPropertyName = "Id_Inscricao";
            resources.ApplyResources(this.idInscricaoDataGridViewTextBoxColumn, "idInscricaoDataGridViewTextBoxColumn");
            this.idInscricaoDataGridViewTextBoxColumn.Name = "idInscricaoDataGridViewTextBoxColumn";
            // 
            // idTurmaDataGridViewTextBoxColumn
            // 
            this.idTurmaDataGridViewTextBoxColumn.DataPropertyName = "Id_Turma";
            resources.ApplyResources(this.idTurmaDataGridViewTextBoxColumn, "idTurmaDataGridViewTextBoxColumn");
            this.idTurmaDataGridViewTextBoxColumn.Name = "idTurmaDataGridViewTextBoxColumn";
            // 
            // FormTabelaInscricoesTurmas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormTabelaInscricoesTurmas";
            this.Load += new System.EventHandler(this.FormTabelaInscricoesTurmas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaInscricoesTurmas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricoesTurmasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_FiltrarFuncionario;
        private System.Windows.Forms.ComboBox cmb_NomeFuncionario;
        private System.Windows.Forms.Label lbl_NomeFuncionario;
        private System.Windows.Forms.Button btn_FiltrarAluno;
        private System.Windows.Forms.ComboBox cmb_NomeAluno;
        private System.Windows.Forms.Label lbl_NomeAluno;
        private DB_EscolaDataSet14 dB_EscolaDataSet14;
        private System.Windows.Forms.BindingSource inscricoesTurmasBindingSource;
        private DB_EscolaDataSet14TableAdapters.Inscricoes_TurmasTableAdapter inscricoes_TurmasTableAdapter;
        private System.Windows.Forms.DataGridView dgv_TabelaInscricoesTurmas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInscricaoTurmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInscricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTurmaDataGridViewTextBoxColumn;
    }
}