namespace CadastroFuncionario
{
    partial class FormTabelaEscalas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabelaEscalas));
            this.group_TabelaEscalas = new System.Windows.Forms.GroupBox();
            this.btn_FiltrarFuncionario = new System.Windows.Forms.Button();
            this.cmb_NomeFuncionario = new System.Windows.Forms.ComboBox();
            this.lbl_NomeFuncionario = new System.Windows.Forms.Label();
            this.dgv_TabelaEscalas = new System.Windows.Forms.DataGridView();
            this.idEscalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaSaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoFuncaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.escalasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_EscolaDataSet12 = new CadastroFuncionario.DB_EscolaDataSet12();
            this.escalasTableAdapter = new CadastroFuncionario.DB_EscolaDataSet12TableAdapters.EscalasTableAdapter();
            this.group_TabelaEscalas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaEscalas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escalasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // group_TabelaEscalas
            // 
            this.group_TabelaEscalas.Controls.Add(this.btn_FiltrarFuncionario);
            this.group_TabelaEscalas.Controls.Add(this.cmb_NomeFuncionario);
            this.group_TabelaEscalas.Controls.Add(this.lbl_NomeFuncionario);
            this.group_TabelaEscalas.Controls.Add(this.dgv_TabelaEscalas);
            resources.ApplyResources(this.group_TabelaEscalas, "group_TabelaEscalas");
            this.group_TabelaEscalas.Name = "group_TabelaEscalas";
            this.group_TabelaEscalas.TabStop = false;
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
            // dgv_TabelaEscalas
            // 
            this.dgv_TabelaEscalas.AllowUserToAddRows = false;
            this.dgv_TabelaEscalas.AutoGenerateColumns = false;
            this.dgv_TabelaEscalas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TabelaEscalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TabelaEscalas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEscalaDataGridViewTextBoxColumn,
            this.idFuncionarioDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.horaEntradaDataGridViewTextBoxColumn,
            this.horaSaidaDataGridViewTextBoxColumn,
            this.descricaoFuncaoDataGridViewTextBoxColumn});
            this.dgv_TabelaEscalas.DataSource = this.escalasBindingSource;
            resources.ApplyResources(this.dgv_TabelaEscalas, "dgv_TabelaEscalas");
            this.dgv_TabelaEscalas.Name = "dgv_TabelaEscalas";
            // 
            // idEscalaDataGridViewTextBoxColumn
            // 
            this.idEscalaDataGridViewTextBoxColumn.DataPropertyName = "Id_Escala";
            resources.ApplyResources(this.idEscalaDataGridViewTextBoxColumn, "idEscalaDataGridViewTextBoxColumn");
            this.idEscalaDataGridViewTextBoxColumn.Name = "idEscalaDataGridViewTextBoxColumn";
            this.idEscalaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idFuncionarioDataGridViewTextBoxColumn
            // 
            this.idFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "Id_Funcionario";
            resources.ApplyResources(this.idFuncionarioDataGridViewTextBoxColumn, "idFuncionarioDataGridViewTextBoxColumn");
            this.idFuncionarioDataGridViewTextBoxColumn.Name = "idFuncionarioDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            resources.ApplyResources(this.dataDataGridViewTextBoxColumn, "dataDataGridViewTextBoxColumn");
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // horaEntradaDataGridViewTextBoxColumn
            // 
            this.horaEntradaDataGridViewTextBoxColumn.DataPropertyName = "Hora_Entrada";
            resources.ApplyResources(this.horaEntradaDataGridViewTextBoxColumn, "horaEntradaDataGridViewTextBoxColumn");
            this.horaEntradaDataGridViewTextBoxColumn.Name = "horaEntradaDataGridViewTextBoxColumn";
            // 
            // horaSaidaDataGridViewTextBoxColumn
            // 
            this.horaSaidaDataGridViewTextBoxColumn.DataPropertyName = "Hora_Saida";
            resources.ApplyResources(this.horaSaidaDataGridViewTextBoxColumn, "horaSaidaDataGridViewTextBoxColumn");
            this.horaSaidaDataGridViewTextBoxColumn.Name = "horaSaidaDataGridViewTextBoxColumn";
            // 
            // descricaoFuncaoDataGridViewTextBoxColumn
            // 
            this.descricaoFuncaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao_Funcao";
            resources.ApplyResources(this.descricaoFuncaoDataGridViewTextBoxColumn, "descricaoFuncaoDataGridViewTextBoxColumn");
            this.descricaoFuncaoDataGridViewTextBoxColumn.Name = "descricaoFuncaoDataGridViewTextBoxColumn";
            // 
            // escalasBindingSource
            // 
            this.escalasBindingSource.DataMember = "Escalas";
            this.escalasBindingSource.DataSource = this.dB_EscolaDataSet12;
            // 
            // dB_EscolaDataSet12
            // 
            this.dB_EscolaDataSet12.DataSetName = "DB_EscolaDataSet12";
            this.dB_EscolaDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // escalasTableAdapter
            // 
            this.escalasTableAdapter.ClearBeforeFill = true;
            // 
            // FormTabelaEscalas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.group_TabelaEscalas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormTabelaEscalas";
            this.Load += new System.EventHandler(this.FormTabelaEscalas_Load);
            this.group_TabelaEscalas.ResumeLayout(false);
            this.group_TabelaEscalas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaEscalas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escalasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_TabelaEscalas;
        private System.Windows.Forms.Button btn_FiltrarFuncionario;
        private System.Windows.Forms.ComboBox cmb_NomeFuncionario;
        private System.Windows.Forms.Label lbl_NomeFuncionario;
        private System.Windows.Forms.DataGridView dgv_TabelaEscalas;
        private DB_EscolaDataSet12 dB_EscolaDataSet12;
        private System.Windows.Forms.BindingSource escalasBindingSource;
        private DB_EscolaDataSet12TableAdapters.EscalasTableAdapter escalasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEscalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaSaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoFuncaoDataGridViewTextBoxColumn;
    }
}