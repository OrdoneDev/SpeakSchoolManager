namespace CadastroFuncionario
{
    partial class FormTabelaAlunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabelaAlunos));
            this.group_TabelaAlunos = new System.Windows.Forms.GroupBox();
            this.btn_FiltrarNome = new System.Windows.Forms.Button();
            this.cmb_Nome = new System.Windows.Forms.ComboBox();
            this.btn_FiltrarId = new System.Windows.Forms.Button();
            this.msk_Id = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.dgv_Alunos = new System.Windows.Forms.DataGridView();
            this.idAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idResponsavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEnderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusAlunoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.dDDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historicoEscolarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_EscolaDataSet10 = new CadastroFuncionario.DB_EscolaDataSet10();
            this.alunosTableAdapter = new CadastroFuncionario.DB_EscolaDataSet10TableAdapters.AlunosTableAdapter();
            this.btn_MostrarTodos = new System.Windows.Forms.Button();
            this.group_TabelaAlunos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // group_TabelaAlunos
            // 
            this.group_TabelaAlunos.Controls.Add(this.btn_MostrarTodos);
            this.group_TabelaAlunos.Controls.Add(this.btn_FiltrarNome);
            this.group_TabelaAlunos.Controls.Add(this.cmb_Nome);
            this.group_TabelaAlunos.Controls.Add(this.btn_FiltrarId);
            this.group_TabelaAlunos.Controls.Add(this.msk_Id);
            this.group_TabelaAlunos.Controls.Add(this.lbl_Nome);
            this.group_TabelaAlunos.Controls.Add(this.lbl_Id);
            this.group_TabelaAlunos.Controls.Add(this.dgv_Alunos);
            resources.ApplyResources(this.group_TabelaAlunos, "group_TabelaAlunos");
            this.group_TabelaAlunos.Name = "group_TabelaAlunos";
            this.group_TabelaAlunos.TabStop = false;
            // 
            // btn_FiltrarNome
            // 
            resources.ApplyResources(this.btn_FiltrarNome, "btn_FiltrarNome");
            this.btn_FiltrarNome.Name = "btn_FiltrarNome";
            this.btn_FiltrarNome.UseVisualStyleBackColor = true;
            this.btn_FiltrarNome.Click += new System.EventHandler(this.btn_FiltrarNome_Click);
            // 
            // cmb_Nome
            // 
            this.cmb_Nome.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_Nome, "cmb_Nome");
            this.cmb_Nome.Name = "cmb_Nome";
            this.cmb_Nome.SelectedValueChanged += new System.EventHandler(this.cmb_Nome_SelectedValueChanged);
            this.cmb_Nome.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_Nome_PreviewKeyDown);
            // 
            // btn_FiltrarId
            // 
            resources.ApplyResources(this.btn_FiltrarId, "btn_FiltrarId");
            this.btn_FiltrarId.Name = "btn_FiltrarId";
            this.btn_FiltrarId.UseVisualStyleBackColor = true;
            this.btn_FiltrarId.Click += new System.EventHandler(this.btn_FiltrarId_Click);
            // 
            // msk_Id
            // 
            resources.ApplyResources(this.msk_Id, "msk_Id");
            this.msk_Id.Name = "msk_Id";
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
            // dgv_Alunos
            // 
            this.dgv_Alunos.AllowUserToAddRows = false;
            this.dgv_Alunos.AutoGenerateColumns = false;
            this.dgv_Alunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Alunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlunoDataGridViewTextBoxColumn,
            this.idResponsavelDataGridViewTextBoxColumn,
            this.idEnderecoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.estadoCivilDataGridViewTextBoxColumn,
            this.rGDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.statusAlunoDataGridViewCheckBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.fotoDataGridViewImageColumn,
            this.dDDDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.historicoEscolarDataGridViewTextBoxColumn,
            this.complementoDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn});
            this.dgv_Alunos.DataSource = this.alunosBindingSource;
            resources.ApplyResources(this.dgv_Alunos, "dgv_Alunos");
            this.dgv_Alunos.Name = "dgv_Alunos";
            this.dgv_Alunos.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Alunos_CellMouseEnter);
            this.dgv_Alunos.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Alunos_CellMouseLeave);
            // 
            // idAlunoDataGridViewTextBoxColumn
            // 
            this.idAlunoDataGridViewTextBoxColumn.DataPropertyName = "Id_Aluno";
            resources.ApplyResources(this.idAlunoDataGridViewTextBoxColumn, "idAlunoDataGridViewTextBoxColumn");
            this.idAlunoDataGridViewTextBoxColumn.Name = "idAlunoDataGridViewTextBoxColumn";
            this.idAlunoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idResponsavelDataGridViewTextBoxColumn
            // 
            this.idResponsavelDataGridViewTextBoxColumn.DataPropertyName = "Id_Responsavel";
            resources.ApplyResources(this.idResponsavelDataGridViewTextBoxColumn, "idResponsavelDataGridViewTextBoxColumn");
            this.idResponsavelDataGridViewTextBoxColumn.Name = "idResponsavelDataGridViewTextBoxColumn";
            // 
            // idEnderecoDataGridViewTextBoxColumn
            // 
            this.idEnderecoDataGridViewTextBoxColumn.DataPropertyName = "Id_Endereco";
            resources.ApplyResources(this.idEnderecoDataGridViewTextBoxColumn, "idEnderecoDataGridViewTextBoxColumn");
            this.idEnderecoDataGridViewTextBoxColumn.Name = "idEnderecoDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            resources.ApplyResources(this.nomeDataGridViewTextBoxColumn, "nomeDataGridViewTextBoxColumn");
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento";
            resources.ApplyResources(this.dataNascimentoDataGridViewTextBoxColumn, "dataNascimentoDataGridViewTextBoxColumn");
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            resources.ApplyResources(this.sexoDataGridViewTextBoxColumn, "sexoDataGridViewTextBoxColumn");
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            // 
            // estadoCivilDataGridViewTextBoxColumn
            // 
            this.estadoCivilDataGridViewTextBoxColumn.DataPropertyName = "Estado_Civil";
            resources.ApplyResources(this.estadoCivilDataGridViewTextBoxColumn, "estadoCivilDataGridViewTextBoxColumn");
            this.estadoCivilDataGridViewTextBoxColumn.Name = "estadoCivilDataGridViewTextBoxColumn";
            // 
            // rGDataGridViewTextBoxColumn
            // 
            this.rGDataGridViewTextBoxColumn.DataPropertyName = "RG";
            resources.ApplyResources(this.rGDataGridViewTextBoxColumn, "rGDataGridViewTextBoxColumn");
            this.rGDataGridViewTextBoxColumn.Name = "rGDataGridViewTextBoxColumn";
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            resources.ApplyResources(this.cPFDataGridViewTextBoxColumn, "cPFDataGridViewTextBoxColumn");
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            // 
            // statusAlunoDataGridViewCheckBoxColumn
            // 
            this.statusAlunoDataGridViewCheckBoxColumn.DataPropertyName = "Status_Aluno";
            resources.ApplyResources(this.statusAlunoDataGridViewCheckBoxColumn, "statusAlunoDataGridViewCheckBoxColumn");
            this.statusAlunoDataGridViewCheckBoxColumn.Name = "statusAlunoDataGridViewCheckBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            resources.ApplyResources(this.emailDataGridViewTextBoxColumn, "emailDataGridViewTextBoxColumn");
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // fotoDataGridViewImageColumn
            // 
            this.fotoDataGridViewImageColumn.DataPropertyName = "Foto";
            resources.ApplyResources(this.fotoDataGridViewImageColumn, "fotoDataGridViewImageColumn");
            this.fotoDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.fotoDataGridViewImageColumn.Name = "fotoDataGridViewImageColumn";
            // 
            // dDDDataGridViewTextBoxColumn
            // 
            this.dDDDataGridViewTextBoxColumn.DataPropertyName = "DDD";
            resources.ApplyResources(this.dDDDataGridViewTextBoxColumn, "dDDDataGridViewTextBoxColumn");
            this.dDDDataGridViewTextBoxColumn.Name = "dDDDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            resources.ApplyResources(this.telefoneDataGridViewTextBoxColumn, "telefoneDataGridViewTextBoxColumn");
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // historicoEscolarDataGridViewTextBoxColumn
            // 
            this.historicoEscolarDataGridViewTextBoxColumn.DataPropertyName = "Historico_Escolar";
            resources.ApplyResources(this.historicoEscolarDataGridViewTextBoxColumn, "historicoEscolarDataGridViewTextBoxColumn");
            this.historicoEscolarDataGridViewTextBoxColumn.Name = "historicoEscolarDataGridViewTextBoxColumn";
            // 
            // complementoDataGridViewTextBoxColumn
            // 
            this.complementoDataGridViewTextBoxColumn.DataPropertyName = "Complemento";
            resources.ApplyResources(this.complementoDataGridViewTextBoxColumn, "complementoDataGridViewTextBoxColumn");
            this.complementoDataGridViewTextBoxColumn.Name = "complementoDataGridViewTextBoxColumn";
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            resources.ApplyResources(this.numeroDataGridViewTextBoxColumn, "numeroDataGridViewTextBoxColumn");
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            // 
            // alunosBindingSource
            // 
            this.alunosBindingSource.DataMember = "Alunos";
            this.alunosBindingSource.DataSource = this.dB_EscolaDataSet10;
            // 
            // dB_EscolaDataSet10
            // 
            this.dB_EscolaDataSet10.DataSetName = "DB_EscolaDataSet10";
            this.dB_EscolaDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alunosTableAdapter
            // 
            this.alunosTableAdapter.ClearBeforeFill = true;
            // 
            // btn_MostrarTodos
            // 
            resources.ApplyResources(this.btn_MostrarTodos, "btn_MostrarTodos");
            this.btn_MostrarTodos.Name = "btn_MostrarTodos";
            this.btn_MostrarTodos.UseVisualStyleBackColor = true;
            this.btn_MostrarTodos.Click += new System.EventHandler(this.btn_MostrarTodos_Click);
            // 
            // FormTabelaAlunos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.group_TabelaAlunos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormTabelaAlunos";
            this.Load += new System.EventHandler(this.FormTabelaAlunos_Load);
            this.group_TabelaAlunos.ResumeLayout(false);
            this.group_TabelaAlunos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_TabelaAlunos;
        private System.Windows.Forms.Button btn_FiltrarNome;
        private System.Windows.Forms.ComboBox cmb_Nome;
        private System.Windows.Forms.Button btn_FiltrarId;
        private System.Windows.Forms.MaskedTextBox msk_Id;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.DataGridView dgv_Alunos;
        private DB_EscolaDataSet10 dB_EscolaDataSet10;
        private System.Windows.Forms.BindingSource alunosBindingSource;
        private DB_EscolaDataSet10TableAdapters.AlunosTableAdapter alunosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idResponsavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEnderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusAlunoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historicoEscolarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_MostrarTodos;
    }
}