namespace CadastroFuncionario
{
    partial class FormTabelaMensalidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabelaMensalidades));
            this.group_TabelaMensalidades = new System.Windows.Forms.GroupBox();
            this.btn_FiltrarFuncionario = new System.Windows.Forms.Button();
            this.cmb_NomeFuncionario = new System.Windows.Forms.ComboBox();
            this.lbl_NomeFuncionario = new System.Windows.Forms.Label();
            this.btn_FiltrarAluno = new System.Windows.Forms.Button();
            this.cmb_NomeAluno = new System.Windows.Forms.ComboBox();
            this.lbl_NomeAluno = new System.Windows.Forms.Label();
            this.dgv_TabelaMensalidades = new System.Windows.Forms.DataGridView();
            this.idMensalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFinanceiroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNegociacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroParcelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensalidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.escola_PrincipalDataSet1 = new CadastroFuncionario.Escola_PrincipalDataSet1();
            this.mensalidadesTableAdapter = new CadastroFuncionario.Escola_PrincipalDataSet1TableAdapters.MensalidadesTableAdapter();
            this.btn_MostrarTodos = new System.Windows.Forms.Button();
            this.group_TabelaMensalidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaMensalidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensalidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escola_PrincipalDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // group_TabelaMensalidades
            // 
            this.group_TabelaMensalidades.Controls.Add(this.btn_MostrarTodos);
            this.group_TabelaMensalidades.Controls.Add(this.btn_FiltrarFuncionario);
            this.group_TabelaMensalidades.Controls.Add(this.cmb_NomeFuncionario);
            this.group_TabelaMensalidades.Controls.Add(this.lbl_NomeFuncionario);
            this.group_TabelaMensalidades.Controls.Add(this.btn_FiltrarAluno);
            this.group_TabelaMensalidades.Controls.Add(this.cmb_NomeAluno);
            this.group_TabelaMensalidades.Controls.Add(this.lbl_NomeAluno);
            this.group_TabelaMensalidades.Controls.Add(this.dgv_TabelaMensalidades);
            resources.ApplyResources(this.group_TabelaMensalidades, "group_TabelaMensalidades");
            this.group_TabelaMensalidades.Name = "group_TabelaMensalidades";
            this.group_TabelaMensalidades.TabStop = false;
            // 
            // btn_FiltrarFuncionario
            // 
            resources.ApplyResources(this.btn_FiltrarFuncionario, "btn_FiltrarFuncionario");
            this.btn_FiltrarFuncionario.Name = "btn_FiltrarFuncionario";
            this.btn_FiltrarFuncionario.UseVisualStyleBackColor = true;
            this.btn_FiltrarFuncionario.Click += new System.EventHandler(this.btn_FiltrarFuncionario_Click);
            // 
            // cmb_NomeFuncionario
            // 
            this.cmb_NomeFuncionario.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_NomeFuncionario, "cmb_NomeFuncionario");
            this.cmb_NomeFuncionario.Name = "cmb_NomeFuncionario";
            this.cmb_NomeFuncionario.SelectedValueChanged += new System.EventHandler(this.cmb_NomeFuncionario_SelectedValueChanged);
            this.cmb_NomeFuncionario.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_NomeFuncionario_PreviewKeyDown);
            // 
            // lbl_NomeFuncionario
            // 
            resources.ApplyResources(this.lbl_NomeFuncionario, "lbl_NomeFuncionario");
            this.lbl_NomeFuncionario.Name = "lbl_NomeFuncionario";
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
            // dgv_TabelaMensalidades
            // 
            this.dgv_TabelaMensalidades.AllowUserToAddRows = false;
            this.dgv_TabelaMensalidades.AutoGenerateColumns = false;
            this.dgv_TabelaMensalidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TabelaMensalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TabelaMensalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMensalidadeDataGridViewTextBoxColumn,
            this.idFinanceiroDataGridViewTextBoxColumn,
            this.idNegociacaoDataGridViewTextBoxColumn,
            this.numeroParcelaDataGridViewTextBoxColumn,
            this.situacaoDataGridViewCheckBoxColumn,
            this.dataDataGridViewTextBoxColumn});
            this.dgv_TabelaMensalidades.DataSource = this.mensalidadesBindingSource;
            resources.ApplyResources(this.dgv_TabelaMensalidades, "dgv_TabelaMensalidades");
            this.dgv_TabelaMensalidades.Name = "dgv_TabelaMensalidades";
            // 
            // idMensalidadeDataGridViewTextBoxColumn
            // 
            this.idMensalidadeDataGridViewTextBoxColumn.DataPropertyName = "Id_Mensalidade";
            resources.ApplyResources(this.idMensalidadeDataGridViewTextBoxColumn, "idMensalidadeDataGridViewTextBoxColumn");
            this.idMensalidadeDataGridViewTextBoxColumn.Name = "idMensalidadeDataGridViewTextBoxColumn";
            this.idMensalidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idFinanceiroDataGridViewTextBoxColumn
            // 
            this.idFinanceiroDataGridViewTextBoxColumn.DataPropertyName = "Id_Financeiro";
            resources.ApplyResources(this.idFinanceiroDataGridViewTextBoxColumn, "idFinanceiroDataGridViewTextBoxColumn");
            this.idFinanceiroDataGridViewTextBoxColumn.Name = "idFinanceiroDataGridViewTextBoxColumn";
            // 
            // idNegociacaoDataGridViewTextBoxColumn
            // 
            this.idNegociacaoDataGridViewTextBoxColumn.DataPropertyName = "Id_Negociacao";
            resources.ApplyResources(this.idNegociacaoDataGridViewTextBoxColumn, "idNegociacaoDataGridViewTextBoxColumn");
            this.idNegociacaoDataGridViewTextBoxColumn.Name = "idNegociacaoDataGridViewTextBoxColumn";
            // 
            // numeroParcelaDataGridViewTextBoxColumn
            // 
            this.numeroParcelaDataGridViewTextBoxColumn.DataPropertyName = "Numero_Parcela";
            resources.ApplyResources(this.numeroParcelaDataGridViewTextBoxColumn, "numeroParcelaDataGridViewTextBoxColumn");
            this.numeroParcelaDataGridViewTextBoxColumn.Name = "numeroParcelaDataGridViewTextBoxColumn";
            // 
            // situacaoDataGridViewCheckBoxColumn
            // 
            this.situacaoDataGridViewCheckBoxColumn.DataPropertyName = "Situacao";
            resources.ApplyResources(this.situacaoDataGridViewCheckBoxColumn, "situacaoDataGridViewCheckBoxColumn");
            this.situacaoDataGridViewCheckBoxColumn.Name = "situacaoDataGridViewCheckBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            resources.ApplyResources(this.dataDataGridViewTextBoxColumn, "dataDataGridViewTextBoxColumn");
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // mensalidadesBindingSource
            // 
            this.mensalidadesBindingSource.DataMember = "Mensalidades";
            this.mensalidadesBindingSource.DataSource = this.escola_PrincipalDataSet1;
            // 
            // escola_PrincipalDataSet1
            // 
            this.escola_PrincipalDataSet1.DataSetName = "Escola_PrincipalDataSet1";
            this.escola_PrincipalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mensalidadesTableAdapter
            // 
            this.mensalidadesTableAdapter.ClearBeforeFill = true;
            // 
            // btn_MostrarTodos
            // 
            resources.ApplyResources(this.btn_MostrarTodos, "btn_MostrarTodos");
            this.btn_MostrarTodos.Name = "btn_MostrarTodos";
            this.btn_MostrarTodos.UseVisualStyleBackColor = true;
            this.btn_MostrarTodos.Click += new System.EventHandler(this.btn_MostrarTodos_Click);
            // 
            // FormTabelaMensalidades
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.group_TabelaMensalidades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormTabelaMensalidades";
            this.Load += new System.EventHandler(this.FormTabelaMensalidades_Load);
            this.group_TabelaMensalidades.ResumeLayout(false);
            this.group_TabelaMensalidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaMensalidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensalidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escola_PrincipalDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_TabelaMensalidades;
        private System.Windows.Forms.Button btn_FiltrarFuncionario;
        private System.Windows.Forms.ComboBox cmb_NomeFuncionario;
        private System.Windows.Forms.Label lbl_NomeFuncionario;
        private System.Windows.Forms.Button btn_FiltrarAluno;
        private System.Windows.Forms.ComboBox cmb_NomeAluno;
        private System.Windows.Forms.Label lbl_NomeAluno;
        private System.Windows.Forms.DataGridView dgv_TabelaMensalidades;
        private Escola_PrincipalDataSet1 escola_PrincipalDataSet1;
        private System.Windows.Forms.BindingSource mensalidadesBindingSource;
        private Escola_PrincipalDataSet1TableAdapters.MensalidadesTableAdapter mensalidadesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMensalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFinanceiroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNegociacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroParcelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn situacaoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_MostrarTodos;
    }
}