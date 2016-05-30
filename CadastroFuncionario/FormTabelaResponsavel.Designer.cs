namespace CadastroFuncionario
{
    partial class FormTabelaResponsavel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabelaResponsavel));
            this.btn_FiltrarCPF = new System.Windows.Forms.Button();
            this.msk_CPF = new System.Windows.Forms.MaskedTextBox();
            this.btn_FiltrarNome = new System.Windows.Forms.Button();
            this.cmb_Nome = new System.Windows.Forms.ComboBox();
            this.btn_FiltrarId = new System.Windows.Forms.Button();
            this.msk_Id = new System.Windows.Forms.MaskedTextBox();
            this.lbl_CPF = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.group_TabelaResponsaveis = new System.Windows.Forms.GroupBox();
            this.dgv_Responsaveis = new System.Windows.Forms.DataGridView();
            this.idResponsavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEnderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsavelAlunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_EscolaDataSet7 = new CadastroFuncionario.DB_EscolaDataSet7();
            this.responsavel_AlunoTableAdapter = new CadastroFuncionario.DB_EscolaDataSet7TableAdapters.Responsavel_AlunoTableAdapter();
            this.btn_MostrarTodos = new System.Windows.Forms.Button();
            this.group_TabelaResponsaveis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Responsaveis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelAlunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_FiltrarCPF
            // 
            resources.ApplyResources(this.btn_FiltrarCPF, "btn_FiltrarCPF");
            this.btn_FiltrarCPF.Name = "btn_FiltrarCPF";
            this.btn_FiltrarCPF.UseVisualStyleBackColor = true;
            this.btn_FiltrarCPF.Click += new System.EventHandler(this.btn_FiltrarCPF_Click);
            // 
            // msk_CPF
            // 
            resources.ApplyResources(this.msk_CPF, "msk_CPF");
            this.msk_CPF.Name = "msk_CPF";
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
            // lbl_CPF
            // 
            resources.ApplyResources(this.lbl_CPF, "lbl_CPF");
            this.lbl_CPF.Name = "lbl_CPF";
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
            // group_TabelaResponsaveis
            // 
            this.group_TabelaResponsaveis.Controls.Add(this.btn_MostrarTodos);
            this.group_TabelaResponsaveis.Controls.Add(this.btn_FiltrarCPF);
            this.group_TabelaResponsaveis.Controls.Add(this.msk_CPF);
            this.group_TabelaResponsaveis.Controls.Add(this.btn_FiltrarNome);
            this.group_TabelaResponsaveis.Controls.Add(this.cmb_Nome);
            this.group_TabelaResponsaveis.Controls.Add(this.btn_FiltrarId);
            this.group_TabelaResponsaveis.Controls.Add(this.msk_Id);
            this.group_TabelaResponsaveis.Controls.Add(this.lbl_CPF);
            this.group_TabelaResponsaveis.Controls.Add(this.lbl_Nome);
            this.group_TabelaResponsaveis.Controls.Add(this.lbl_Id);
            this.group_TabelaResponsaveis.Controls.Add(this.dgv_Responsaveis);
            resources.ApplyResources(this.group_TabelaResponsaveis, "group_TabelaResponsaveis");
            this.group_TabelaResponsaveis.Name = "group_TabelaResponsaveis";
            this.group_TabelaResponsaveis.TabStop = false;
            // 
            // dgv_Responsaveis
            // 
            this.dgv_Responsaveis.AllowUserToAddRows = false;
            this.dgv_Responsaveis.AutoGenerateColumns = false;
            this.dgv_Responsaveis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Responsaveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Responsaveis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idResponsavelDataGridViewTextBoxColumn,
            this.idEnderecoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.estadoCivilDataGridViewTextBoxColumn,
            this.rGDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dDDDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.complementoDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn});
            this.dgv_Responsaveis.DataSource = this.responsavelAlunoBindingSource;
            resources.ApplyResources(this.dgv_Responsaveis, "dgv_Responsaveis");
            this.dgv_Responsaveis.Name = "dgv_Responsaveis";
            // 
            // idResponsavelDataGridViewTextBoxColumn
            // 
            this.idResponsavelDataGridViewTextBoxColumn.DataPropertyName = "Id_Responsavel";
            resources.ApplyResources(this.idResponsavelDataGridViewTextBoxColumn, "idResponsavelDataGridViewTextBoxColumn");
            this.idResponsavelDataGridViewTextBoxColumn.Name = "idResponsavelDataGridViewTextBoxColumn";
            this.idResponsavelDataGridViewTextBoxColumn.ReadOnly = true;
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
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            resources.ApplyResources(this.emailDataGridViewTextBoxColumn, "emailDataGridViewTextBoxColumn");
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
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
            // responsavelAlunoBindingSource
            // 
            this.responsavelAlunoBindingSource.DataMember = "Responsavel_Aluno";
            this.responsavelAlunoBindingSource.DataSource = this.dB_EscolaDataSet7;
            // 
            // dB_EscolaDataSet7
            // 
            this.dB_EscolaDataSet7.DataSetName = "DB_EscolaDataSet7";
            this.dB_EscolaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // responsavel_AlunoTableAdapter
            // 
            this.responsavel_AlunoTableAdapter.ClearBeforeFill = true;
            // 
            // btn_MostrarTodos
            // 
            resources.ApplyResources(this.btn_MostrarTodos, "btn_MostrarTodos");
            this.btn_MostrarTodos.Name = "btn_MostrarTodos";
            this.btn_MostrarTodos.UseVisualStyleBackColor = true;
            this.btn_MostrarTodos.Click += new System.EventHandler(this.btn_MostrarTodos_Click);
            // 
            // FormTabelaResponsavel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.group_TabelaResponsaveis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormTabelaResponsavel";
            this.Load += new System.EventHandler(this.FormTabelaResponsavel_Load);
            this.group_TabelaResponsaveis.ResumeLayout(false);
            this.group_TabelaResponsaveis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Responsaveis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelAlunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_FiltrarCPF;
        private System.Windows.Forms.MaskedTextBox msk_CPF;
        private System.Windows.Forms.Button btn_FiltrarNome;
        private System.Windows.Forms.ComboBox cmb_Nome;
        private System.Windows.Forms.Button btn_FiltrarId;
        private System.Windows.Forms.MaskedTextBox msk_Id;
        private System.Windows.Forms.Label lbl_CPF;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.GroupBox group_TabelaResponsaveis;
        private System.Windows.Forms.DataGridView dgv_Responsaveis;
        private DB_EscolaDataSet7 dB_EscolaDataSet7;
        private System.Windows.Forms.BindingSource responsavelAlunoBindingSource;
        private DB_EscolaDataSet7TableAdapters.Responsavel_AlunoTableAdapter responsavel_AlunoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idResponsavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEnderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_MostrarTodos;
    }
}