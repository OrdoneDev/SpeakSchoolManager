namespace CadastroFuncionario
{
    partial class FormHistoricosFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistoricosFuncionario));
            this.group_HistoricoFuncionario = new System.Windows.Forms.GroupBox();
            this.btn_FiltrarNome = new System.Windows.Forms.Button();
            this.btn_FiltrarId = new System.Windows.Forms.Button();
            this.cmb_Nome = new System.Windows.Forms.ComboBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.msk_IdFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.dgv_HistoricoFuncionario = new System.Windows.Forms.DataGridView();
            this.idHistoricoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historicoFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_EscolaDataSet8 = new CadastroFuncionario.DB_EscolaDataSet8();
            this.historicoFuncionarioTableAdapter = new CadastroFuncionario.DB_EscolaDataSet8TableAdapters.HistoricoFuncionarioTableAdapter();
            this.btn_MostrarTodos = new System.Windows.Forms.Button();
            this.group_HistoricoFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HistoricoFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoFuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // group_HistoricoFuncionario
            // 
            this.group_HistoricoFuncionario.Controls.Add(this.btn_MostrarTodos);
            this.group_HistoricoFuncionario.Controls.Add(this.btn_FiltrarNome);
            this.group_HistoricoFuncionario.Controls.Add(this.btn_FiltrarId);
            this.group_HistoricoFuncionario.Controls.Add(this.cmb_Nome);
            this.group_HistoricoFuncionario.Controls.Add(this.lbl_Nome);
            this.group_HistoricoFuncionario.Controls.Add(this.lbl_Id);
            this.group_HistoricoFuncionario.Controls.Add(this.msk_IdFuncionario);
            this.group_HistoricoFuncionario.Controls.Add(this.dgv_HistoricoFuncionario);
            resources.ApplyResources(this.group_HistoricoFuncionario, "group_HistoricoFuncionario");
            this.group_HistoricoFuncionario.Name = "group_HistoricoFuncionario";
            this.group_HistoricoFuncionario.TabStop = false;
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
            // msk_IdFuncionario
            // 
            resources.ApplyResources(this.msk_IdFuncionario, "msk_IdFuncionario");
            this.msk_IdFuncionario.Name = "msk_IdFuncionario";
            // 
            // dgv_HistoricoFuncionario
            // 
            this.dgv_HistoricoFuncionario.AllowUserToAddRows = false;
            this.dgv_HistoricoFuncionario.AllowUserToDeleteRows = false;
            this.dgv_HistoricoFuncionario.AutoGenerateColumns = false;
            this.dgv_HistoricoFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HistoricoFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HistoricoFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHistoricoDataGridViewTextBoxColumn,
            this.idFuncionarioDataGridViewTextBoxColumn,
            this.fotoDataGridViewImageColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dgv_HistoricoFuncionario.DataSource = this.historicoFuncionarioBindingSource;
            resources.ApplyResources(this.dgv_HistoricoFuncionario, "dgv_HistoricoFuncionario");
            this.dgv_HistoricoFuncionario.Name = "dgv_HistoricoFuncionario";
            this.dgv_HistoricoFuncionario.ReadOnly = true;
            this.dgv_HistoricoFuncionario.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HistoricoFuncionario_CellMouseEnter);
            this.dgv_HistoricoFuncionario.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HistoricoFuncionario_CellMouseLeave);
            // 
            // idHistoricoDataGridViewTextBoxColumn
            // 
            this.idHistoricoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idHistoricoDataGridViewTextBoxColumn.DataPropertyName = "Id_Historico";
            resources.ApplyResources(this.idHistoricoDataGridViewTextBoxColumn, "idHistoricoDataGridViewTextBoxColumn");
            this.idHistoricoDataGridViewTextBoxColumn.Name = "idHistoricoDataGridViewTextBoxColumn";
            this.idHistoricoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idFuncionarioDataGridViewTextBoxColumn
            // 
            this.idFuncionarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "Id_Funcionario";
            resources.ApplyResources(this.idFuncionarioDataGridViewTextBoxColumn, "idFuncionarioDataGridViewTextBoxColumn");
            this.idFuncionarioDataGridViewTextBoxColumn.Name = "idFuncionarioDataGridViewTextBoxColumn";
            this.idFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
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
            // historicoFuncionarioBindingSource
            // 
            this.historicoFuncionarioBindingSource.DataMember = "HistoricoFuncionario";
            this.historicoFuncionarioBindingSource.DataSource = this.dB_EscolaDataSet8;
            // 
            // dB_EscolaDataSet8
            // 
            this.dB_EscolaDataSet8.DataSetName = "DB_EscolaDataSet8";
            this.dB_EscolaDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historicoFuncionarioTableAdapter
            // 
            this.historicoFuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // btn_MostrarTodos
            // 
            resources.ApplyResources(this.btn_MostrarTodos, "btn_MostrarTodos");
            this.btn_MostrarTodos.Name = "btn_MostrarTodos";
            this.btn_MostrarTodos.UseVisualStyleBackColor = true;
            this.btn_MostrarTodos.Click += new System.EventHandler(this.btn_MostrarTodos_Click);
            // 
            // FormHistoricosFuncionario
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.group_HistoricoFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormHistoricosFuncionario";
            this.Load += new System.EventHandler(this.FormHistoricosFuncionario_Load);
            this.group_HistoricoFuncionario.ResumeLayout(false);
            this.group_HistoricoFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HistoricoFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoFuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_HistoricoFuncionario;
        private System.Windows.Forms.DataGridView dgv_HistoricoFuncionario;
        private System.Windows.Forms.Button btn_FiltrarNome;
        private System.Windows.Forms.Button btn_FiltrarId;
        private System.Windows.Forms.ComboBox cmb_Nome;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.MaskedTextBox msk_IdFuncionario;
        private DB_EscolaDataSet8 dB_EscolaDataSet8;
        private System.Windows.Forms.BindingSource historicoFuncionarioBindingSource;
        private DB_EscolaDataSet8TableAdapters.HistoricoFuncionarioTableAdapter historicoFuncionarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHistoricoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_MostrarTodos;
    }
}