namespace CadastroFuncionario
{
    partial class FormTabelaInscricoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabelaInscricoes));
            this.group_TabelaInscricoes = new System.Windows.Forms.GroupBox();
            this.btn_FiltrarAluno = new System.Windows.Forms.Button();
            this.cmb_NomeAluno = new System.Windows.Forms.ComboBox();
            this.lbl_NomeAluno = new System.Windows.Forms.Label();
            this.dgv_TabelaInscricoes = new System.Windows.Forms.DataGridView();
            this.idInscricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNegociacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.inscricaoAlunoFiltroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.escola_PrincipalDataSet2 = new CadastroFuncionario.Escola_PrincipalDataSet2();
            this.inscricaoAlunoFiltroTableAdapter = new CadastroFuncionario.Escola_PrincipalDataSet2TableAdapters.InscricaoAlunoFiltroTableAdapter();
            this.btn_MostrarTodos = new System.Windows.Forms.Button();
            this.group_TabelaInscricoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaInscricoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricaoAlunoFiltroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escola_PrincipalDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // group_TabelaInscricoes
            // 
            this.group_TabelaInscricoes.Controls.Add(this.btn_MostrarTodos);
            this.group_TabelaInscricoes.Controls.Add(this.btn_FiltrarAluno);
            this.group_TabelaInscricoes.Controls.Add(this.cmb_NomeAluno);
            this.group_TabelaInscricoes.Controls.Add(this.lbl_NomeAluno);
            this.group_TabelaInscricoes.Controls.Add(this.dgv_TabelaInscricoes);
            resources.ApplyResources(this.group_TabelaInscricoes, "group_TabelaInscricoes");
            this.group_TabelaInscricoes.Name = "group_TabelaInscricoes";
            this.group_TabelaInscricoes.TabStop = false;
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
            // dgv_TabelaInscricoes
            // 
            this.dgv_TabelaInscricoes.AllowUserToAddRows = false;
            this.dgv_TabelaInscricoes.AutoGenerateColumns = false;
            this.dgv_TabelaInscricoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TabelaInscricoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TabelaInscricoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInscricaoDataGridViewTextBoxColumn,
            this.idAlunoDataGridViewTextBoxColumn,
            this.idNegociacaoDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.dgv_TabelaInscricoes.DataSource = this.inscricaoAlunoFiltroBindingSource;
            resources.ApplyResources(this.dgv_TabelaInscricoes, "dgv_TabelaInscricoes");
            this.dgv_TabelaInscricoes.Name = "dgv_TabelaInscricoes";
            // 
            // idInscricaoDataGridViewTextBoxColumn
            // 
            this.idInscricaoDataGridViewTextBoxColumn.DataPropertyName = "Id_Inscricao";
            resources.ApplyResources(this.idInscricaoDataGridViewTextBoxColumn, "idInscricaoDataGridViewTextBoxColumn");
            this.idInscricaoDataGridViewTextBoxColumn.Name = "idInscricaoDataGridViewTextBoxColumn";
            this.idInscricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idAlunoDataGridViewTextBoxColumn
            // 
            this.idAlunoDataGridViewTextBoxColumn.DataPropertyName = "Id_Aluno";
            resources.ApplyResources(this.idAlunoDataGridViewTextBoxColumn, "idAlunoDataGridViewTextBoxColumn");
            this.idAlunoDataGridViewTextBoxColumn.Name = "idAlunoDataGridViewTextBoxColumn";
            // 
            // idNegociacaoDataGridViewTextBoxColumn
            // 
            this.idNegociacaoDataGridViewTextBoxColumn.DataPropertyName = "Id_Negociacao";
            resources.ApplyResources(this.idNegociacaoDataGridViewTextBoxColumn, "idNegociacaoDataGridViewTextBoxColumn");
            this.idNegociacaoDataGridViewTextBoxColumn.Name = "idNegociacaoDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            resources.ApplyResources(this.dataDataGridViewTextBoxColumn, "dataDataGridViewTextBoxColumn");
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            resources.ApplyResources(this.statusDataGridViewCheckBoxColumn, "statusDataGridViewCheckBoxColumn");
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            // 
            // inscricaoAlunoFiltroBindingSource
            // 
            this.inscricaoAlunoFiltroBindingSource.DataMember = "InscricaoAlunoFiltro";
            this.inscricaoAlunoFiltroBindingSource.DataSource = this.escola_PrincipalDataSet2;
            // 
            // escola_PrincipalDataSet2
            // 
            this.escola_PrincipalDataSet2.DataSetName = "Escola_PrincipalDataSet2";
            this.escola_PrincipalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inscricaoAlunoFiltroTableAdapter
            // 
            this.inscricaoAlunoFiltroTableAdapter.ClearBeforeFill = true;
            // 
            // btn_MostrarTodos
            // 
            resources.ApplyResources(this.btn_MostrarTodos, "btn_MostrarTodos");
            this.btn_MostrarTodos.Name = "btn_MostrarTodos";
            this.btn_MostrarTodos.UseVisualStyleBackColor = true;
            this.btn_MostrarTodos.Click += new System.EventHandler(this.btn_MostrarTodos_Click);
            // 
            // FormTabelaInscricoes
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.group_TabelaInscricoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormTabelaInscricoes";
            this.Load += new System.EventHandler(this.FormTabelaInscricoes_Load);
            this.group_TabelaInscricoes.ResumeLayout(false);
            this.group_TabelaInscricoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaInscricoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricaoAlunoFiltroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escola_PrincipalDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_TabelaInscricoes;
        private System.Windows.Forms.Button btn_FiltrarAluno;
        private System.Windows.Forms.ComboBox cmb_NomeAluno;
        private System.Windows.Forms.Label lbl_NomeAluno;
        private System.Windows.Forms.DataGridView dgv_TabelaInscricoes;
        private Escola_PrincipalDataSet2 escola_PrincipalDataSet2;
        private System.Windows.Forms.BindingSource inscricaoAlunoFiltroBindingSource;
        private Escola_PrincipalDataSet2TableAdapters.InscricaoAlunoFiltroTableAdapter inscricaoAlunoFiltroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInscricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNegociacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button btn_MostrarTodos;
    }
}