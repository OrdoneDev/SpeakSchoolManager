namespace CadastroFuncionario
{
    partial class FormHistoricosAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistoricosAluno));
            this.group_HistoricoAluno = new System.Windows.Forms.GroupBox();
            this.btn_FiltrarNome = new System.Windows.Forms.Button();
            this.btn_FiltrarId = new System.Windows.Forms.Button();
            this.cmb_Nome = new System.Windows.Forms.ComboBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.msk_IdAluno = new System.Windows.Forms.MaskedTextBox();
            this.dgv_HistoricoAluno = new System.Windows.Forms.DataGridView();
            this.idHistoricoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historicoAlunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_EscolaDataSet9 = new CadastroFuncionario.DB_EscolaDataSet9();
            this.historicoAlunoTableAdapter = new CadastroFuncionario.DB_EscolaDataSet9TableAdapters.HistoricoAlunoTableAdapter();
            this.group_HistoricoAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HistoricoAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoAlunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // group_HistoricoAluno
            // 
            this.group_HistoricoAluno.Controls.Add(this.btn_FiltrarNome);
            this.group_HistoricoAluno.Controls.Add(this.btn_FiltrarId);
            this.group_HistoricoAluno.Controls.Add(this.cmb_Nome);
            this.group_HistoricoAluno.Controls.Add(this.lbl_Nome);
            this.group_HistoricoAluno.Controls.Add(this.lbl_Id);
            this.group_HistoricoAluno.Controls.Add(this.msk_IdAluno);
            this.group_HistoricoAluno.Controls.Add(this.dgv_HistoricoAluno);
            resources.ApplyResources(this.group_HistoricoAluno, "group_HistoricoAluno");
            this.group_HistoricoAluno.Name = "group_HistoricoAluno";
            this.group_HistoricoAluno.TabStop = false;
            // 
            // btn_FiltrarNome
            // 
            resources.ApplyResources(this.btn_FiltrarNome, "btn_FiltrarNome");
            this.btn_FiltrarNome.Name = "btn_FiltrarNome";
            this.btn_FiltrarNome.UseVisualStyleBackColor = true;
            this.btn_FiltrarNome.Click += new System.EventHandler(this.btn_FiltrarNome_Click);
            // 
            // btn_FiltrarId
            // 
            resources.ApplyResources(this.btn_FiltrarId, "btn_FiltrarId");
            this.btn_FiltrarId.Name = "btn_FiltrarId";
            this.btn_FiltrarId.UseVisualStyleBackColor = true;
            this.btn_FiltrarId.Click += new System.EventHandler(this.btn_FiltrarId_Click);
            // 
            // cmb_Nome
            // 
            this.cmb_Nome.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_Nome, "cmb_Nome");
            this.cmb_Nome.Name = "cmb_Nome";
            this.cmb_Nome.SelectedValueChanged += new System.EventHandler(this.cmb_Nome_SelectedValueChanged);
            this.cmb_Nome.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_Nome_PreviewKeyDown);
            // 
            // lbl_Nome
            // 
            resources.ApplyResources(this.lbl_Nome, "lbl_Nome");
            this.lbl_Nome.Name = "lbl_Nome";
            // 
            // lbl_Id
            // 
            resources.ApplyResources(this.lbl_Id, "lbl_Id");
            this.lbl_Id.Name = "lbl_Id";
            // 
            // msk_IdAluno
            // 
            resources.ApplyResources(this.msk_IdAluno, "msk_IdAluno");
            this.msk_IdAluno.Name = "msk_IdAluno";
            // 
            // dgv_HistoricoAluno
            // 
            this.dgv_HistoricoAluno.AllowUserToAddRows = false;
            this.dgv_HistoricoAluno.AllowUserToDeleteRows = false;
            this.dgv_HistoricoAluno.AutoGenerateColumns = false;
            this.dgv_HistoricoAluno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HistoricoAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HistoricoAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHistoricoDataGridViewTextBoxColumn,
            this.idAlunoDataGridViewTextBoxColumn,
            this.fotoDataGridViewImageColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dgv_HistoricoAluno.DataSource = this.historicoAlunoBindingSource;
            resources.ApplyResources(this.dgv_HistoricoAluno, "dgv_HistoricoAluno");
            this.dgv_HistoricoAluno.Name = "dgv_HistoricoAluno";
            this.dgv_HistoricoAluno.ReadOnly = true;
            this.dgv_HistoricoAluno.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HistoricoAluno_CellMouseEnter);
            this.dgv_HistoricoAluno.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HistoricoAluno_CellMouseLeave);
            // 
            // idHistoricoDataGridViewTextBoxColumn
            // 
            this.idHistoricoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idHistoricoDataGridViewTextBoxColumn.DataPropertyName = "Id_Historico";
            resources.ApplyResources(this.idHistoricoDataGridViewTextBoxColumn, "idHistoricoDataGridViewTextBoxColumn");
            this.idHistoricoDataGridViewTextBoxColumn.Name = "idHistoricoDataGridViewTextBoxColumn";
            this.idHistoricoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idAlunoDataGridViewTextBoxColumn
            // 
            this.idAlunoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idAlunoDataGridViewTextBoxColumn.DataPropertyName = "Id_Aluno";
            resources.ApplyResources(this.idAlunoDataGridViewTextBoxColumn, "idAlunoDataGridViewTextBoxColumn");
            this.idAlunoDataGridViewTextBoxColumn.Name = "idAlunoDataGridViewTextBoxColumn";
            this.idAlunoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fotoDataGridViewImageColumn
            // 
            this.fotoDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fotoDataGridViewImageColumn.DataPropertyName = "Foto";
            resources.ApplyResources(this.fotoDataGridViewImageColumn, "fotoDataGridViewImageColumn");
            this.fotoDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.fotoDataGridViewImageColumn.Name = "fotoDataGridViewImageColumn";
            this.fotoDataGridViewImageColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            resources.ApplyResources(this.nomeDataGridViewTextBoxColumn, "nomeDataGridViewTextBoxColumn");
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            resources.ApplyResources(this.dataDataGridViewTextBoxColumn, "dataDataGridViewTextBoxColumn");
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            resources.ApplyResources(this.descricaoDataGridViewTextBoxColumn, "descricaoDataGridViewTextBoxColumn");
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // historicoAlunoBindingSource
            // 
            this.historicoAlunoBindingSource.DataMember = "HistoricoAluno";
            this.historicoAlunoBindingSource.DataSource = this.dB_EscolaDataSet9;
            // 
            // dB_EscolaDataSet9
            // 
            this.dB_EscolaDataSet9.DataSetName = "DB_EscolaDataSet9";
            this.dB_EscolaDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historicoAlunoTableAdapter
            // 
            this.historicoAlunoTableAdapter.ClearBeforeFill = true;
            // 
            // FormHistoricosAluno
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.group_HistoricoAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormHistoricosAluno";
            this.Load += new System.EventHandler(this.FormHistoricosAluno_Load);
            this.group_HistoricoAluno.ResumeLayout(false);
            this.group_HistoricoAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HistoricoAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoAlunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_HistoricoAluno;
        private System.Windows.Forms.Button btn_FiltrarNome;
        private System.Windows.Forms.Button btn_FiltrarId;
        private System.Windows.Forms.ComboBox cmb_Nome;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.MaskedTextBox msk_IdAluno;
        private System.Windows.Forms.DataGridView dgv_HistoricoAluno;
        private DB_EscolaDataSet9 dB_EscolaDataSet9;
        private System.Windows.Forms.BindingSource historicoAlunoBindingSource;
        private DB_EscolaDataSet9TableAdapters.HistoricoAlunoTableAdapter historicoAlunoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHistoricoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
    }
}