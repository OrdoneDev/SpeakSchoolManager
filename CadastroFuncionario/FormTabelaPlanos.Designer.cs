namespace CadastroFuncionario
{
    partial class FormTabelaPlanos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabelaPlanos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.group_TabelaPlanos = new System.Windows.Forms.GroupBox();
            this.btn_FiltrarIdioma = new System.Windows.Forms.Button();
            this.cmb_Idioma = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_TabelaPlanos = new System.Windows.Forms.DataGridView();
            this.idPlanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idIdiomaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDoPlanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aulasPrevistasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idiomasPlanosFiltroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.escola_PrincipalDataSet3 = new CadastroFuncionario.Escola_PrincipalDataSet3();
            this.idiomasPlanosFiltroTableAdapter = new CadastroFuncionario.Escola_PrincipalDataSet3TableAdapters.IdiomasPlanosFiltroTableAdapter();
            this.group_TabelaPlanos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaPlanos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idiomasPlanosFiltroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escola_PrincipalDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // group_TabelaPlanos
            // 
            this.group_TabelaPlanos.Controls.Add(this.btn_FiltrarIdioma);
            this.group_TabelaPlanos.Controls.Add(this.cmb_Idioma);
            this.group_TabelaPlanos.Controls.Add(this.label1);
            this.group_TabelaPlanos.Controls.Add(this.dgv_TabelaPlanos);
            resources.ApplyResources(this.group_TabelaPlanos, "group_TabelaPlanos");
            this.group_TabelaPlanos.Name = "group_TabelaPlanos";
            this.group_TabelaPlanos.TabStop = false;
            // 
            // btn_FiltrarIdioma
            // 
            resources.ApplyResources(this.btn_FiltrarIdioma, "btn_FiltrarIdioma");
            this.btn_FiltrarIdioma.Name = "btn_FiltrarIdioma";
            this.btn_FiltrarIdioma.UseVisualStyleBackColor = true;
            this.btn_FiltrarIdioma.Click += new System.EventHandler(this.btn_FiltrarIdioma_Click);
            // 
            // cmb_Idioma
            // 
            this.cmb_Idioma.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_Idioma, "cmb_Idioma");
            this.cmb_Idioma.Name = "cmb_Idioma";
            this.cmb_Idioma.SelectedValueChanged += new System.EventHandler(this.cmb_Idioma_SelectedValueChanged);
            this.cmb_Idioma.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_Idioma_PreviewKeyDown);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dgv_TabelaPlanos
            // 
            this.dgv_TabelaPlanos.AllowUserToAddRows = false;
            this.dgv_TabelaPlanos.AutoGenerateColumns = false;
            this.dgv_TabelaPlanos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TabelaPlanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TabelaPlanos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPlanoDataGridViewTextBoxColumn,
            this.idIdiomaDataGridViewTextBoxColumn,
            this.nomeDoPlanoDataGridViewTextBoxColumn,
            this.aulasPrevistasDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn});
            this.dgv_TabelaPlanos.DataSource = this.idiomasPlanosFiltroBindingSource;
            resources.ApplyResources(this.dgv_TabelaPlanos, "dgv_TabelaPlanos");
            this.dgv_TabelaPlanos.Name = "dgv_TabelaPlanos";
            // 
            // idPlanoDataGridViewTextBoxColumn
            // 
            this.idPlanoDataGridViewTextBoxColumn.DataPropertyName = "Id_Plano";
            resources.ApplyResources(this.idPlanoDataGridViewTextBoxColumn, "idPlanoDataGridViewTextBoxColumn");
            this.idPlanoDataGridViewTextBoxColumn.Name = "idPlanoDataGridViewTextBoxColumn";
            this.idPlanoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idIdiomaDataGridViewTextBoxColumn
            // 
            this.idIdiomaDataGridViewTextBoxColumn.DataPropertyName = "Id_Idioma";
            resources.ApplyResources(this.idIdiomaDataGridViewTextBoxColumn, "idIdiomaDataGridViewTextBoxColumn");
            this.idIdiomaDataGridViewTextBoxColumn.Name = "idIdiomaDataGridViewTextBoxColumn";
            // 
            // nomeDoPlanoDataGridViewTextBoxColumn
            // 
            this.nomeDoPlanoDataGridViewTextBoxColumn.DataPropertyName = "Nome do plano";
            resources.ApplyResources(this.nomeDoPlanoDataGridViewTextBoxColumn, "nomeDoPlanoDataGridViewTextBoxColumn");
            this.nomeDoPlanoDataGridViewTextBoxColumn.Name = "nomeDoPlanoDataGridViewTextBoxColumn";
            // 
            // aulasPrevistasDataGridViewTextBoxColumn
            // 
            this.aulasPrevistasDataGridViewTextBoxColumn.DataPropertyName = "Aulas_Previstas";
            resources.ApplyResources(this.aulasPrevistasDataGridViewTextBoxColumn, "aulasPrevistasDataGridViewTextBoxColumn");
            this.aulasPrevistasDataGridViewTextBoxColumn.Name = "aulasPrevistasDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.valorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.valorDataGridViewTextBoxColumn, "valorDataGridViewTextBoxColumn");
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // idiomasPlanosFiltroBindingSource
            // 
            this.idiomasPlanosFiltroBindingSource.DataMember = "IdiomasPlanosFiltro";
            this.idiomasPlanosFiltroBindingSource.DataSource = this.escola_PrincipalDataSet3;
            // 
            // escola_PrincipalDataSet3
            // 
            this.escola_PrincipalDataSet3.DataSetName = "Escola_PrincipalDataSet3";
            this.escola_PrincipalDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idiomasPlanosFiltroTableAdapter
            // 
            this.idiomasPlanosFiltroTableAdapter.ClearBeforeFill = true;
            // 
            // FormTabelaPlanos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.group_TabelaPlanos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormTabelaPlanos";
            this.Load += new System.EventHandler(this.FormTabelaPlanos_Load);
            this.group_TabelaPlanos.ResumeLayout(false);
            this.group_TabelaPlanos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaPlanos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idiomasPlanosFiltroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escola_PrincipalDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_TabelaPlanos;
        private System.Windows.Forms.Button btn_FiltrarIdioma;
        private System.Windows.Forms.ComboBox cmb_Idioma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_TabelaPlanos;
        private Escola_PrincipalDataSet3 escola_PrincipalDataSet3;
        private System.Windows.Forms.BindingSource idiomasPlanosFiltroBindingSource;
        private Escola_PrincipalDataSet3TableAdapters.IdiomasPlanosFiltroTableAdapter idiomasPlanosFiltroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idIdiomaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDoPlanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aulasPrevistasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
    }
}