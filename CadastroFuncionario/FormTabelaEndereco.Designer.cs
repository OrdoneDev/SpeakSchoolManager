namespace CadastroFuncionario
{
    partial class FormTabelaEndereco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabelaEndereco));
            this.group_Enderecos = new System.Windows.Forms.GroupBox();
            this.btn_FiltrarBairro = new System.Windows.Forms.Button();
            this.cmb_Bairro = new System.Windows.Forms.ComboBox();
            this.lbl_Bairro = new System.Windows.Forms.Label();
            this.btn_FiltrarCidade = new System.Windows.Forms.Button();
            this.cmb_Cidade = new System.Windows.Forms.ComboBox();
            this.lbl_Cidade = new System.Windows.Forms.Label();
            this.btn_FiltrarEstado = new System.Windows.Forms.Button();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.cmb_Estado = new System.Windows.Forms.ComboBox();
            this.btn_FiltrarId = new System.Windows.Forms.Button();
            this.lbl_IdEndereco = new System.Windows.Forms.Label();
            this.msk_IdEndereco = new System.Windows.Forms.MaskedTextBox();
            this.dgv_Enderecos = new System.Windows.Forms.DataGridView();
            this.idEnderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeRuaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_EscolaDataSet3 = new CadastroFuncionario.DB_EscolaDataSet3();
            this.enderecoTableAdapter = new CadastroFuncionario.DB_EscolaDataSet3TableAdapters.EnderecoTableAdapter();
            this.btn_MostrarTodos = new System.Windows.Forms.Button();
            this.group_Enderecos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Enderecos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // group_Enderecos
            // 
            this.group_Enderecos.Controls.Add(this.btn_MostrarTodos);
            this.group_Enderecos.Controls.Add(this.btn_FiltrarBairro);
            this.group_Enderecos.Controls.Add(this.cmb_Bairro);
            this.group_Enderecos.Controls.Add(this.lbl_Bairro);
            this.group_Enderecos.Controls.Add(this.btn_FiltrarCidade);
            this.group_Enderecos.Controls.Add(this.cmb_Cidade);
            this.group_Enderecos.Controls.Add(this.lbl_Cidade);
            this.group_Enderecos.Controls.Add(this.btn_FiltrarEstado);
            this.group_Enderecos.Controls.Add(this.lbl_Estado);
            this.group_Enderecos.Controls.Add(this.cmb_Estado);
            this.group_Enderecos.Controls.Add(this.btn_FiltrarId);
            this.group_Enderecos.Controls.Add(this.lbl_IdEndereco);
            this.group_Enderecos.Controls.Add(this.msk_IdEndereco);
            this.group_Enderecos.Controls.Add(this.dgv_Enderecos);
            resources.ApplyResources(this.group_Enderecos, "group_Enderecos");
            this.group_Enderecos.Name = "group_Enderecos";
            this.group_Enderecos.TabStop = false;
            // 
            // btn_FiltrarBairro
            // 
            resources.ApplyResources(this.btn_FiltrarBairro, "btn_FiltrarBairro");
            this.btn_FiltrarBairro.Name = "btn_FiltrarBairro";
            this.btn_FiltrarBairro.UseVisualStyleBackColor = true;
            this.btn_FiltrarBairro.Click += new System.EventHandler(this.btn_FiltrarBairro_Click);
            // 
            // cmb_Bairro
            // 
            this.cmb_Bairro.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_Bairro, "cmb_Bairro");
            this.cmb_Bairro.Name = "cmb_Bairro";
            this.cmb_Bairro.SelectedValueChanged += new System.EventHandler(this.cmb_Bairro_SelectedValueChanged);
            this.cmb_Bairro.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_Bairro_PreviewKeyDown);
            // 
            // lbl_Bairro
            // 
            resources.ApplyResources(this.lbl_Bairro, "lbl_Bairro");
            this.lbl_Bairro.Name = "lbl_Bairro";
            // 
            // btn_FiltrarCidade
            // 
            resources.ApplyResources(this.btn_FiltrarCidade, "btn_FiltrarCidade");
            this.btn_FiltrarCidade.Name = "btn_FiltrarCidade";
            this.btn_FiltrarCidade.UseVisualStyleBackColor = true;
            this.btn_FiltrarCidade.Click += new System.EventHandler(this.btn_FiltrarCidade_Click);
            // 
            // cmb_Cidade
            // 
            this.cmb_Cidade.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_Cidade, "cmb_Cidade");
            this.cmb_Cidade.Name = "cmb_Cidade";
            this.cmb_Cidade.SelectedValueChanged += new System.EventHandler(this.cmb_Cidade_SelectedValueChanged);
            this.cmb_Cidade.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_Cidade_PreviewKeyDown);
            // 
            // lbl_Cidade
            // 
            resources.ApplyResources(this.lbl_Cidade, "lbl_Cidade");
            this.lbl_Cidade.Name = "lbl_Cidade";
            // 
            // btn_FiltrarEstado
            // 
            resources.ApplyResources(this.btn_FiltrarEstado, "btn_FiltrarEstado");
            this.btn_FiltrarEstado.Name = "btn_FiltrarEstado";
            this.btn_FiltrarEstado.UseVisualStyleBackColor = true;
            this.btn_FiltrarEstado.Click += new System.EventHandler(this.btn_FiltrarEstado_Click);
            // 
            // lbl_Estado
            // 
            resources.ApplyResources(this.lbl_Estado, "lbl_Estado");
            this.lbl_Estado.Name = "lbl_Estado";
            // 
            // cmb_Estado
            // 
            this.cmb_Estado.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_Estado, "cmb_Estado");
            this.cmb_Estado.Name = "cmb_Estado";
            this.cmb_Estado.SelectedValueChanged += new System.EventHandler(this.cmb_Estado_SelectedValueChanged);
            this.cmb_Estado.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_Estado_PreviewKeyDown);
            // 
            // btn_FiltrarId
            // 
            resources.ApplyResources(this.btn_FiltrarId, "btn_FiltrarId");
            this.btn_FiltrarId.Name = "btn_FiltrarId";
            this.btn_FiltrarId.UseVisualStyleBackColor = true;
            this.btn_FiltrarId.Click += new System.EventHandler(this.btn_FiltrarId_Click);
            // 
            // lbl_IdEndereco
            // 
            resources.ApplyResources(this.lbl_IdEndereco, "lbl_IdEndereco");
            this.lbl_IdEndereco.Name = "lbl_IdEndereco";
            // 
            // msk_IdEndereco
            // 
            resources.ApplyResources(this.msk_IdEndereco, "msk_IdEndereco");
            this.msk_IdEndereco.Name = "msk_IdEndereco";
            // 
            // dgv_Enderecos
            // 
            this.dgv_Enderecos.AllowUserToAddRows = false;
            this.dgv_Enderecos.AutoGenerateColumns = false;
            this.dgv_Enderecos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Enderecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Enderecos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEnderecoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.cEPDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.nomeRuaDataGridViewTextBoxColumn});
            this.dgv_Enderecos.DataSource = this.enderecoBindingSource;
            resources.ApplyResources(this.dgv_Enderecos, "dgv_Enderecos");
            this.dgv_Enderecos.Name = "dgv_Enderecos";
            // 
            // idEnderecoDataGridViewTextBoxColumn
            // 
            this.idEnderecoDataGridViewTextBoxColumn.DataPropertyName = "Id_Endereco";
            resources.ApplyResources(this.idEnderecoDataGridViewTextBoxColumn, "idEnderecoDataGridViewTextBoxColumn");
            this.idEnderecoDataGridViewTextBoxColumn.Name = "idEnderecoDataGridViewTextBoxColumn";
            this.idEnderecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            resources.ApplyResources(this.estadoDataGridViewTextBoxColumn, "estadoDataGridViewTextBoxColumn");
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            resources.ApplyResources(this.cidadeDataGridViewTextBoxColumn, "cidadeDataGridViewTextBoxColumn");
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            this.cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            resources.ApplyResources(this.cEPDataGridViewTextBoxColumn, "cEPDataGridViewTextBoxColumn");
            this.cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro";
            resources.ApplyResources(this.bairroDataGridViewTextBoxColumn, "bairroDataGridViewTextBoxColumn");
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            // 
            // nomeRuaDataGridViewTextBoxColumn
            // 
            this.nomeRuaDataGridViewTextBoxColumn.DataPropertyName = "Nome_Rua";
            resources.ApplyResources(this.nomeRuaDataGridViewTextBoxColumn, "nomeRuaDataGridViewTextBoxColumn");
            this.nomeRuaDataGridViewTextBoxColumn.Name = "nomeRuaDataGridViewTextBoxColumn";
            // 
            // enderecoBindingSource
            // 
            this.enderecoBindingSource.DataMember = "Endereco";
            this.enderecoBindingSource.DataSource = this.dB_EscolaDataSet3;
            // 
            // dB_EscolaDataSet3
            // 
            this.dB_EscolaDataSet3.DataSetName = "DB_EscolaDataSet3";
            this.dB_EscolaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enderecoTableAdapter
            // 
            this.enderecoTableAdapter.ClearBeforeFill = true;
            // 
            // btn_MostrarTodos
            // 
            resources.ApplyResources(this.btn_MostrarTodos, "btn_MostrarTodos");
            this.btn_MostrarTodos.Name = "btn_MostrarTodos";
            this.btn_MostrarTodos.UseVisualStyleBackColor = true;
            this.btn_MostrarTodos.Click += new System.EventHandler(this.btn_MostrarTodos_Click);
            // 
            // FormTabelaEndereco
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.group_Enderecos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormTabelaEndereco";
            this.Load += new System.EventHandler(this.FormTabelaEndereco_Load);
            this.group_Enderecos.ResumeLayout(false);
            this.group_Enderecos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Enderecos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_Enderecos;
        private System.Windows.Forms.DataGridView dgv_Enderecos;
        private DB_EscolaDataSet3 dB_EscolaDataSet3;
        private System.Windows.Forms.BindingSource enderecoBindingSource;
        private DB_EscolaDataSet3TableAdapters.EnderecoTableAdapter enderecoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEnderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeRuaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_FiltrarId;
        private System.Windows.Forms.Label lbl_IdEndereco;
        private System.Windows.Forms.MaskedTextBox msk_IdEndereco;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.ComboBox cmb_Estado;
        private System.Windows.Forms.Button btn_FiltrarEstado;
        private System.Windows.Forms.Button btn_FiltrarCidade;
        private System.Windows.Forms.ComboBox cmb_Cidade;
        private System.Windows.Forms.Label lbl_Cidade;
        private System.Windows.Forms.Button btn_FiltrarBairro;
        private System.Windows.Forms.ComboBox cmb_Bairro;
        private System.Windows.Forms.Label lbl_Bairro;
        private System.Windows.Forms.Button btn_MostrarTodos;
    }
}