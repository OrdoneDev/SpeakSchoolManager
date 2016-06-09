namespace CadastroFuncionario
{
    partial class FormEditarInscricao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarInscricao));
            this.group_InscricaoAluno = new System.Windows.Forms.GroupBox();
            this.rdb_Inativo = new System.Windows.Forms.RadioButton();
            this.rdb_Ativo = new System.Windows.Forms.RadioButton();
            this.lbl_StatusAluno = new System.Windows.Forms.Label();
            this.dgv_InscricaoAluno = new System.Windows.Forms.DataGridView();
            this.códigoDaInscriçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.códigoDoAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDoAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.códigoDaNegociaçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDeInscricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDaInscriçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allInscricoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_EscolaDataSet5 = new CadastroFuncionario.DB_EscolaDataSet5();
            this.btn_ConsultarInscricao = new System.Windows.Forms.Button();
            this.lbl_NomeAluno = new System.Windows.Forms.Label();
            this.cmb_NomeAluno = new System.Windows.Forms.ComboBox();
            this.lbl_IdAluno = new System.Windows.Forms.Label();
            this.msk_IdAluno = new System.Windows.Forms.MaskedTextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_SalvarAlteracao = new System.Windows.Forms.Button();
            this.allInscricoesTableAdapter = new CadastroFuncionario.DB_EscolaDataSet5TableAdapters.AllInscricoesTableAdapter();
            this.group_InscricaoAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InscricaoAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allInscricoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // group_InscricaoAluno
            // 
            resources.ApplyResources(this.group_InscricaoAluno, "group_InscricaoAluno");
            this.group_InscricaoAluno.Controls.Add(this.rdb_Inativo);
            this.group_InscricaoAluno.Controls.Add(this.rdb_Ativo);
            this.group_InscricaoAluno.Controls.Add(this.lbl_StatusAluno);
            this.group_InscricaoAluno.Controls.Add(this.dgv_InscricaoAluno);
            this.group_InscricaoAluno.Controls.Add(this.btn_ConsultarInscricao);
            this.group_InscricaoAluno.Controls.Add(this.lbl_NomeAluno);
            this.group_InscricaoAluno.Controls.Add(this.cmb_NomeAluno);
            this.group_InscricaoAluno.Controls.Add(this.lbl_IdAluno);
            this.group_InscricaoAluno.Controls.Add(this.msk_IdAluno);
            this.group_InscricaoAluno.Name = "group_InscricaoAluno";
            this.group_InscricaoAluno.TabStop = false;
            // 
            // rdb_Inativo
            // 
            resources.ApplyResources(this.rdb_Inativo, "rdb_Inativo");
            this.rdb_Inativo.Name = "rdb_Inativo";
            this.rdb_Inativo.TabStop = true;
            this.rdb_Inativo.UseVisualStyleBackColor = true;
            // 
            // rdb_Ativo
            // 
            resources.ApplyResources(this.rdb_Ativo, "rdb_Ativo");
            this.rdb_Ativo.Name = "rdb_Ativo";
            this.rdb_Ativo.TabStop = true;
            this.rdb_Ativo.UseVisualStyleBackColor = true;
            // 
            // lbl_StatusAluno
            // 
            resources.ApplyResources(this.lbl_StatusAluno, "lbl_StatusAluno");
            this.lbl_StatusAluno.Name = "lbl_StatusAluno";
            // 
            // dgv_InscricaoAluno
            // 
            this.dgv_InscricaoAluno.AllowUserToAddRows = false;
            this.dgv_InscricaoAluno.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dgv_InscricaoAluno, "dgv_InscricaoAluno");
            this.dgv_InscricaoAluno.AutoGenerateColumns = false;
            this.dgv_InscricaoAluno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_InscricaoAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_InscricaoAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.códigoDaInscriçãoDataGridViewTextBoxColumn,
            this.códigoDoAlunoDataGridViewTextBoxColumn,
            this.nomeDoAlunoDataGridViewTextBoxColumn,
            this.códigoDaNegociaçãoDataGridViewTextBoxColumn,
            this.dataDeInscricaoDataGridViewTextBoxColumn,
            this.statusDaInscriçãoDataGridViewTextBoxColumn});
            this.dgv_InscricaoAluno.DataSource = this.allInscricoesBindingSource;
            this.dgv_InscricaoAluno.Name = "dgv_InscricaoAluno";
            this.dgv_InscricaoAluno.ReadOnly = true;
            this.dgv_InscricaoAluno.Tag = "0";
            this.dgv_InscricaoAluno.SelectionChanged += new System.EventHandler(this.dgv_InscricaoAluno_SelectionChanged);
            // 
            // códigoDaInscriçãoDataGridViewTextBoxColumn
            // 
            this.códigoDaInscriçãoDataGridViewTextBoxColumn.DataPropertyName = "Código da inscrição";
            resources.ApplyResources(this.códigoDaInscriçãoDataGridViewTextBoxColumn, "códigoDaInscriçãoDataGridViewTextBoxColumn");
            this.códigoDaInscriçãoDataGridViewTextBoxColumn.Name = "códigoDaInscriçãoDataGridViewTextBoxColumn";
            this.códigoDaInscriçãoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // códigoDoAlunoDataGridViewTextBoxColumn
            // 
            this.códigoDoAlunoDataGridViewTextBoxColumn.DataPropertyName = "Código do aluno";
            resources.ApplyResources(this.códigoDoAlunoDataGridViewTextBoxColumn, "códigoDoAlunoDataGridViewTextBoxColumn");
            this.códigoDoAlunoDataGridViewTextBoxColumn.Name = "códigoDoAlunoDataGridViewTextBoxColumn";
            this.códigoDoAlunoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDoAlunoDataGridViewTextBoxColumn
            // 
            this.nomeDoAlunoDataGridViewTextBoxColumn.DataPropertyName = "Nome do aluno";
            resources.ApplyResources(this.nomeDoAlunoDataGridViewTextBoxColumn, "nomeDoAlunoDataGridViewTextBoxColumn");
            this.nomeDoAlunoDataGridViewTextBoxColumn.Name = "nomeDoAlunoDataGridViewTextBoxColumn";
            this.nomeDoAlunoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // códigoDaNegociaçãoDataGridViewTextBoxColumn
            // 
            this.códigoDaNegociaçãoDataGridViewTextBoxColumn.DataPropertyName = "Código da negociação";
            resources.ApplyResources(this.códigoDaNegociaçãoDataGridViewTextBoxColumn, "códigoDaNegociaçãoDataGridViewTextBoxColumn");
            this.códigoDaNegociaçãoDataGridViewTextBoxColumn.Name = "códigoDaNegociaçãoDataGridViewTextBoxColumn";
            this.códigoDaNegociaçãoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDeInscricaoDataGridViewTextBoxColumn
            // 
            this.dataDeInscricaoDataGridViewTextBoxColumn.DataPropertyName = "Data de Inscricao";
            resources.ApplyResources(this.dataDeInscricaoDataGridViewTextBoxColumn, "dataDeInscricaoDataGridViewTextBoxColumn");
            this.dataDeInscricaoDataGridViewTextBoxColumn.Name = "dataDeInscricaoDataGridViewTextBoxColumn";
            this.dataDeInscricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDaInscriçãoDataGridViewTextBoxColumn
            // 
            this.statusDaInscriçãoDataGridViewTextBoxColumn.DataPropertyName = "Status da inscrição";
            resources.ApplyResources(this.statusDaInscriçãoDataGridViewTextBoxColumn, "statusDaInscriçãoDataGridViewTextBoxColumn");
            this.statusDaInscriçãoDataGridViewTextBoxColumn.Name = "statusDaInscriçãoDataGridViewTextBoxColumn";
            this.statusDaInscriçãoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // allInscricoesBindingSource
            // 
            this.allInscricoesBindingSource.DataMember = "AllInscricoes";
            this.allInscricoesBindingSource.DataSource = this.dB_EscolaDataSet5;
            // 
            // dB_EscolaDataSet5
            // 
            this.dB_EscolaDataSet5.DataSetName = "DB_EscolaDataSet5";
            this.dB_EscolaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_ConsultarInscricao
            // 
            resources.ApplyResources(this.btn_ConsultarInscricao, "btn_ConsultarInscricao");
            this.btn_ConsultarInscricao.Name = "btn_ConsultarInscricao";
            this.btn_ConsultarInscricao.UseVisualStyleBackColor = true;
            this.btn_ConsultarInscricao.Click += new System.EventHandler(this.btn_ConsultarInscricao_Click);
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
            // lbl_IdAluno
            // 
            resources.ApplyResources(this.lbl_IdAluno, "lbl_IdAluno");
            this.lbl_IdAluno.Name = "lbl_IdAluno";
            // 
            // msk_IdAluno
            // 
            resources.ApplyResources(this.msk_IdAluno, "msk_IdAluno");
            this.msk_IdAluno.Name = "msk_IdAluno";
            this.msk_IdAluno.TextChanged += new System.EventHandler(this.msk_IdAluno_TextChanged);
            // 
            // btn_Cancelar
            // 
            resources.ApplyResources(this.btn_Cancelar, "btn_Cancelar");
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_SalvarAlteracao
            // 
            resources.ApplyResources(this.btn_SalvarAlteracao, "btn_SalvarAlteracao");
            this.btn_SalvarAlteracao.Name = "btn_SalvarAlteracao";
            this.btn_SalvarAlteracao.UseVisualStyleBackColor = true;
            this.btn_SalvarAlteracao.Click += new System.EventHandler(this.btn_SalvarAlteracao_Click);
            // 
            // allInscricoesTableAdapter
            // 
            this.allInscricoesTableAdapter.ClearBeforeFill = true;
            // 
            // FormEditarInscricao
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_SalvarAlteracao);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.group_InscricaoAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormEditarInscricao";
            this.Load += new System.EventHandler(this.FormEditarInscricao_Load);
            this.group_InscricaoAluno.ResumeLayout(false);
            this.group_InscricaoAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InscricaoAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allInscricoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_InscricaoAluno;
        private System.Windows.Forms.RadioButton rdb_Inativo;
        private System.Windows.Forms.RadioButton rdb_Ativo;
        private System.Windows.Forms.Label lbl_StatusAluno;
        private System.Windows.Forms.DataGridView dgv_InscricaoAluno;
        private System.Windows.Forms.Button btn_ConsultarInscricao;
        private System.Windows.Forms.Label lbl_NomeAluno;
        private System.Windows.Forms.ComboBox cmb_NomeAluno;
        private System.Windows.Forms.Label lbl_IdAluno;
        private System.Windows.Forms.MaskedTextBox msk_IdAluno;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_SalvarAlteracao;
        private DB_EscolaDataSet5 dB_EscolaDataSet5;
        private System.Windows.Forms.BindingSource allInscricoesBindingSource;
        private DB_EscolaDataSet5TableAdapters.AllInscricoesTableAdapter allInscricoesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoDaInscriçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoDoAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDoAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoDaNegociaçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDeInscricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDaInscriçãoDataGridViewTextBoxColumn;
    }
}