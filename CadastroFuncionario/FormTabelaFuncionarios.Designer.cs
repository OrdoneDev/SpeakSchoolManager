namespace CadastroFuncionario
{
    partial class FormTabelaFuncionarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabelaFuncionarios));
            this.group_TabelaFuncionarios = new System.Windows.Forms.GroupBox();
            this.btn_FIltrarCargo = new System.Windows.Forms.Button();
            this.cmb_Cargo = new System.Windows.Forms.ComboBox();
            this.btn_FiltrarCPF = new System.Windows.Forms.Button();
            this.msk_CPF = new System.Windows.Forms.MaskedTextBox();
            this.btn_FiltrarNome = new System.Windows.Forms.Button();
            this.cmb_Nome = new System.Windows.Forms.ComboBox();
            this.btn_FiltrarId = new System.Windows.Forms.Button();
            this.msk_Id = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Cargo = new System.Windows.Forms.Label();
            this.lbl_CPF = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.dgv_Funcionarios = new System.Windows.Forms.DataGridView();
            this.idFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEnderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.dDDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeFilhosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historicoEscolarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_EscolaDataSet6 = new CadastroFuncionario.DB_EscolaDataSet6();
            this.funcionariosTableAdapter = new CadastroFuncionario.DB_EscolaDataSet6TableAdapters.FuncionariosTableAdapter();
            this.btn_MostrarTodos = new System.Windows.Forms.Button();
            this.group_TabelaFuncionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Funcionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // group_TabelaFuncionarios
            // 
            this.group_TabelaFuncionarios.Controls.Add(this.btn_MostrarTodos);
            this.group_TabelaFuncionarios.Controls.Add(this.btn_FIltrarCargo);
            this.group_TabelaFuncionarios.Controls.Add(this.cmb_Cargo);
            this.group_TabelaFuncionarios.Controls.Add(this.btn_FiltrarCPF);
            this.group_TabelaFuncionarios.Controls.Add(this.msk_CPF);
            this.group_TabelaFuncionarios.Controls.Add(this.btn_FiltrarNome);
            this.group_TabelaFuncionarios.Controls.Add(this.cmb_Nome);
            this.group_TabelaFuncionarios.Controls.Add(this.btn_FiltrarId);
            this.group_TabelaFuncionarios.Controls.Add(this.msk_Id);
            this.group_TabelaFuncionarios.Controls.Add(this.lbl_Cargo);
            this.group_TabelaFuncionarios.Controls.Add(this.lbl_CPF);
            this.group_TabelaFuncionarios.Controls.Add(this.lbl_Nome);
            this.group_TabelaFuncionarios.Controls.Add(this.lbl_Id);
            this.group_TabelaFuncionarios.Controls.Add(this.dgv_Funcionarios);
            resources.ApplyResources(this.group_TabelaFuncionarios, "group_TabelaFuncionarios");
            this.group_TabelaFuncionarios.Name = "group_TabelaFuncionarios";
            this.group_TabelaFuncionarios.TabStop = false;
            // 
            // btn_FIltrarCargo
            // 
            resources.ApplyResources(this.btn_FIltrarCargo, "btn_FIltrarCargo");
            this.btn_FIltrarCargo.Name = "btn_FIltrarCargo";
            this.btn_FIltrarCargo.UseVisualStyleBackColor = true;
            this.btn_FIltrarCargo.Click += new System.EventHandler(this.btn_FIltrarCargo_Click);
            // 
            // cmb_Cargo
            // 
            this.cmb_Cargo.FormattingEnabled = true;
            this.cmb_Cargo.Items.AddRange(new object[] {
            resources.GetString("cmb_Cargo.Items"),
            resources.GetString("cmb_Cargo.Items1"),
            resources.GetString("cmb_Cargo.Items2"),
            resources.GetString("cmb_Cargo.Items3")});
            resources.ApplyResources(this.cmb_Cargo, "cmb_Cargo");
            this.cmb_Cargo.Name = "cmb_Cargo";
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
            // lbl_Cargo
            // 
            resources.ApplyResources(this.lbl_Cargo, "lbl_Cargo");
            this.lbl_Cargo.Name = "lbl_Cargo";
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
            // dgv_Funcionarios
            // 
            this.dgv_Funcionarios.AllowUserToAddRows = false;
            this.dgv_Funcionarios.AutoGenerateColumns = false;
            this.dgv_Funcionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Funcionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFuncionarioDataGridViewTextBoxColumn,
            this.idEnderecoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.estadoCivilDataGridViewTextBoxColumn,
            this.rGDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.statusFuncionarioDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.fotoDataGridViewImageColumn,
            this.dDDDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.quantidadeFilhosDataGridViewTextBoxColumn,
            this.historicoEscolarDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn,
            this.salarioDataGridViewTextBoxColumn,
            this.complementoDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn});
            this.dgv_Funcionarios.DataSource = this.funcionariosBindingSource;
            resources.ApplyResources(this.dgv_Funcionarios, "dgv_Funcionarios");
            this.dgv_Funcionarios.Name = "dgv_Funcionarios";
            this.dgv_Funcionarios.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Funcionarios_CellMouseEnter);
            this.dgv_Funcionarios.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Funcionarios_CellMouseLeave);
            // 
            // idFuncionarioDataGridViewTextBoxColumn
            // 
            this.idFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "Id_Funcionario";
            resources.ApplyResources(this.idFuncionarioDataGridViewTextBoxColumn, "idFuncionarioDataGridViewTextBoxColumn");
            this.idFuncionarioDataGridViewTextBoxColumn.Name = "idFuncionarioDataGridViewTextBoxColumn";
            this.idFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
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
            // statusFuncionarioDataGridViewTextBoxColumn
            // 
            this.statusFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "Status_Funcionario";
            resources.ApplyResources(this.statusFuncionarioDataGridViewTextBoxColumn, "statusFuncionarioDataGridViewTextBoxColumn");
            this.statusFuncionarioDataGridViewTextBoxColumn.Name = "statusFuncionarioDataGridViewTextBoxColumn";
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
            // quantidadeFilhosDataGridViewTextBoxColumn
            // 
            this.quantidadeFilhosDataGridViewTextBoxColumn.DataPropertyName = "Quantidade_Filhos";
            resources.ApplyResources(this.quantidadeFilhosDataGridViewTextBoxColumn, "quantidadeFilhosDataGridViewTextBoxColumn");
            this.quantidadeFilhosDataGridViewTextBoxColumn.Name = "quantidadeFilhosDataGridViewTextBoxColumn";
            // 
            // historicoEscolarDataGridViewTextBoxColumn
            // 
            this.historicoEscolarDataGridViewTextBoxColumn.DataPropertyName = "Historico_Escolar";
            resources.ApplyResources(this.historicoEscolarDataGridViewTextBoxColumn, "historicoEscolarDataGridViewTextBoxColumn");
            this.historicoEscolarDataGridViewTextBoxColumn.Name = "historicoEscolarDataGridViewTextBoxColumn";
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
            resources.ApplyResources(this.cargoDataGridViewTextBoxColumn, "cargoDataGridViewTextBoxColumn");
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            this.salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.salarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.salarioDataGridViewTextBoxColumn, "salarioDataGridViewTextBoxColumn");
            this.salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
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
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "Funcionarios";
            this.funcionariosBindingSource.DataSource = this.dB_EscolaDataSet6;
            // 
            // dB_EscolaDataSet6
            // 
            this.dB_EscolaDataSet6.DataSetName = "DB_EscolaDataSet6";
            this.dB_EscolaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // btn_MostrarTodos
            // 
            resources.ApplyResources(this.btn_MostrarTodos, "btn_MostrarTodos");
            this.btn_MostrarTodos.Name = "btn_MostrarTodos";
            this.btn_MostrarTodos.UseVisualStyleBackColor = true;
            this.btn_MostrarTodos.Click += new System.EventHandler(this.btn_MostrarTodos_Click);
            // 
            // FormTabelaFuncionarios
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.group_TabelaFuncionarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormTabelaFuncionarios";
            this.Load += new System.EventHandler(this.FormTabelaFuncionarios_Load);
            this.group_TabelaFuncionarios.ResumeLayout(false);
            this.group_TabelaFuncionarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Funcionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_TabelaFuncionarios;
        private System.Windows.Forms.DataGridView dgv_Funcionarios;
        private DB_EscolaDataSet6 dB_EscolaDataSet6;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private DB_EscolaDataSet6TableAdapters.FuncionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.Label lbl_Cargo;
        private System.Windows.Forms.Label lbl_CPF;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Button btn_FiltrarNome;
        private System.Windows.Forms.ComboBox cmb_Nome;
        private System.Windows.Forms.Button btn_FiltrarId;
        private System.Windows.Forms.MaskedTextBox msk_Id;
        private System.Windows.Forms.MaskedTextBox msk_CPF;
        private System.Windows.Forms.Button btn_FiltrarCPF;
        private System.Windows.Forms.Button btn_FIltrarCargo;
        private System.Windows.Forms.ComboBox cmb_Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEnderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeFilhosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historicoEscolarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_MostrarTodos;
    }
}