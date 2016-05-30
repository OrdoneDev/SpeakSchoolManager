namespace CadastroFuncionario
{
    partial class FormTabelaTurmas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabelaTurmas));
            this.group_TabelaTurmas = new System.Windows.Forms.GroupBox();
            this.btn_FiltrarPlano = new System.Windows.Forms.Button();
            this.cmb_NomePlano = new System.Windows.Forms.ComboBox();
            this.lbl_NomePlano = new System.Windows.Forms.Label();
            this.btn_FiltrarFuncionario = new System.Windows.Forms.Button();
            this.cmb_NomeFuncionario = new System.Windows.Forms.ComboBox();
            this.lbl_NomeFuncionario = new System.Windows.Forms.Label();
            this.dgv_TabelaTurmas = new System.Windows.Forms.DataGridView();
            this.idTurmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEscalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaSaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turmasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_EscolaDataSet13 = new CadastroFuncionario.DB_EscolaDataSet13();
            this.turmasTableAdapter = new CadastroFuncionario.DB_EscolaDataSet13TableAdapters.TurmasTableAdapter();
            this.btn_MostrarTodos = new System.Windows.Forms.Button();
            this.group_TabelaTurmas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaTurmas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // group_TabelaTurmas
            // 
            this.group_TabelaTurmas.Controls.Add(this.btn_MostrarTodos);
            this.group_TabelaTurmas.Controls.Add(this.btn_FiltrarPlano);
            this.group_TabelaTurmas.Controls.Add(this.cmb_NomePlano);
            this.group_TabelaTurmas.Controls.Add(this.lbl_NomePlano);
            this.group_TabelaTurmas.Controls.Add(this.btn_FiltrarFuncionario);
            this.group_TabelaTurmas.Controls.Add(this.cmb_NomeFuncionario);
            this.group_TabelaTurmas.Controls.Add(this.lbl_NomeFuncionario);
            this.group_TabelaTurmas.Controls.Add(this.dgv_TabelaTurmas);
            resources.ApplyResources(this.group_TabelaTurmas, "group_TabelaTurmas");
            this.group_TabelaTurmas.Name = "group_TabelaTurmas";
            this.group_TabelaTurmas.TabStop = false;
            // 
            // btn_FiltrarPlano
            // 
            resources.ApplyResources(this.btn_FiltrarPlano, "btn_FiltrarPlano");
            this.btn_FiltrarPlano.Name = "btn_FiltrarPlano";
            this.btn_FiltrarPlano.UseVisualStyleBackColor = true;
            this.btn_FiltrarPlano.Click += new System.EventHandler(this.btn_FiltrarPlano_Click);
            // 
            // cmb_NomePlano
            // 
            this.cmb_NomePlano.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_NomePlano, "cmb_NomePlano");
            this.cmb_NomePlano.Name = "cmb_NomePlano";
            this.cmb_NomePlano.SelectedValueChanged += new System.EventHandler(this.cmb_NomePlano_SelectedValueChanged);
            this.cmb_NomePlano.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_NomePlano_PreviewKeyDown);
            // 
            // lbl_NomePlano
            // 
            resources.ApplyResources(this.lbl_NomePlano, "lbl_NomePlano");
            this.lbl_NomePlano.Name = "lbl_NomePlano";
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
            // dgv_TabelaTurmas
            // 
            this.dgv_TabelaTurmas.AllowUserToAddRows = false;
            this.dgv_TabelaTurmas.AutoGenerateColumns = false;
            this.dgv_TabelaTurmas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TabelaTurmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TabelaTurmas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTurmaDataGridViewTextBoxColumn,
            this.idPlanoDataGridViewTextBoxColumn,
            this.idEscalaDataGridViewTextBoxColumn,
            this.salaDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.horaEntradaDataGridViewTextBoxColumn,
            this.horaSaidaDataGridViewTextBoxColumn});
            this.dgv_TabelaTurmas.DataSource = this.turmasBindingSource;
            resources.ApplyResources(this.dgv_TabelaTurmas, "dgv_TabelaTurmas");
            this.dgv_TabelaTurmas.Name = "dgv_TabelaTurmas";
            // 
            // idTurmaDataGridViewTextBoxColumn
            // 
            this.idTurmaDataGridViewTextBoxColumn.DataPropertyName = "Id_Turma";
            resources.ApplyResources(this.idTurmaDataGridViewTextBoxColumn, "idTurmaDataGridViewTextBoxColumn");
            this.idTurmaDataGridViewTextBoxColumn.Name = "idTurmaDataGridViewTextBoxColumn";
            this.idTurmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPlanoDataGridViewTextBoxColumn
            // 
            this.idPlanoDataGridViewTextBoxColumn.DataPropertyName = "Id_Plano";
            resources.ApplyResources(this.idPlanoDataGridViewTextBoxColumn, "idPlanoDataGridViewTextBoxColumn");
            this.idPlanoDataGridViewTextBoxColumn.Name = "idPlanoDataGridViewTextBoxColumn";
            // 
            // idEscalaDataGridViewTextBoxColumn
            // 
            this.idEscalaDataGridViewTextBoxColumn.DataPropertyName = "Id_Escala";
            resources.ApplyResources(this.idEscalaDataGridViewTextBoxColumn, "idEscalaDataGridViewTextBoxColumn");
            this.idEscalaDataGridViewTextBoxColumn.Name = "idEscalaDataGridViewTextBoxColumn";
            // 
            // salaDataGridViewTextBoxColumn
            // 
            this.salaDataGridViewTextBoxColumn.DataPropertyName = "Sala";
            resources.ApplyResources(this.salaDataGridViewTextBoxColumn, "salaDataGridViewTextBoxColumn");
            this.salaDataGridViewTextBoxColumn.Name = "salaDataGridViewTextBoxColumn";
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
            // turmasBindingSource
            // 
            this.turmasBindingSource.DataMember = "Turmas";
            this.turmasBindingSource.DataSource = this.dB_EscolaDataSet13;
            // 
            // dB_EscolaDataSet13
            // 
            this.dB_EscolaDataSet13.DataSetName = "DB_EscolaDataSet13";
            this.dB_EscolaDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // turmasTableAdapter
            // 
            this.turmasTableAdapter.ClearBeforeFill = true;
            // 
            // btn_MostrarTodos
            // 
            resources.ApplyResources(this.btn_MostrarTodos, "btn_MostrarTodos");
            this.btn_MostrarTodos.Name = "btn_MostrarTodos";
            this.btn_MostrarTodos.UseVisualStyleBackColor = true;
            this.btn_MostrarTodos.Click += new System.EventHandler(this.btn_MostrarTodos_Click);
            // 
            // FormTabelaTurmas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.group_TabelaTurmas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormTabelaTurmas";
            this.Load += new System.EventHandler(this.FormTabelaTurmas_Load);
            this.group_TabelaTurmas.ResumeLayout(false);
            this.group_TabelaTurmas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaTurmas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet13)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_TabelaTurmas;
        private System.Windows.Forms.Button btn_FiltrarPlano;
        private System.Windows.Forms.ComboBox cmb_NomePlano;
        private System.Windows.Forms.Label lbl_NomePlano;
        private System.Windows.Forms.Button btn_FiltrarFuncionario;
        private System.Windows.Forms.ComboBox cmb_NomeFuncionario;
        private System.Windows.Forms.Label lbl_NomeFuncionario;
        private System.Windows.Forms.DataGridView dgv_TabelaTurmas;
        private DB_EscolaDataSet13 dB_EscolaDataSet13;
        private System.Windows.Forms.BindingSource turmasBindingSource;
        private DB_EscolaDataSet13TableAdapters.TurmasTableAdapter turmasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTurmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEscalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaSaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_MostrarTodos;
    }
}