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
            this.msk_IdEndereco = new System.Windows.Forms.MaskedTextBox();
            this.lbl_IdEndereco = new System.Windows.Forms.Label();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.group_Enderecos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Enderecos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // group_Enderecos
            // 
            this.group_Enderecos.Controls.Add(this.btn_Consultar);
            this.group_Enderecos.Controls.Add(this.lbl_IdEndereco);
            this.group_Enderecos.Controls.Add(this.msk_IdEndereco);
            this.group_Enderecos.Controls.Add(this.dgv_Enderecos);
            resources.ApplyResources(this.group_Enderecos, "group_Enderecos");
            this.group_Enderecos.Name = "group_Enderecos";
            this.group_Enderecos.TabStop = false;
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
            // msk_IdEndereco
            // 
            resources.ApplyResources(this.msk_IdEndereco, "msk_IdEndereco");
            this.msk_IdEndereco.Name = "msk_IdEndereco";
            // 
            // lbl_IdEndereco
            // 
            resources.ApplyResources(this.lbl_IdEndereco, "lbl_IdEndereco");
            this.lbl_IdEndereco.Name = "lbl_IdEndereco";
            // 
            // btn_Consultar
            // 
            resources.ApplyResources(this.btn_Consultar, "btn_Consultar");
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.button1_Click);
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
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Label lbl_IdEndereco;
        private System.Windows.Forms.MaskedTextBox msk_IdEndereco;
    }
}