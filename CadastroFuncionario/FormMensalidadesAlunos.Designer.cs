namespace CadastroFuncionario
{
    partial class FormMensalidadesAlunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMensalidadesAlunos));
            this.group_MensalidadesAlunos = new System.Windows.Forms.GroupBox();
            this.rdb_APagar = new System.Windows.Forms.RadioButton();
            this.rdb_Pago = new System.Windows.Forms.RadioButton();
            this.lbl_Situacao = new System.Windows.Forms.Label();
            this.lbl_NomeAluno = new System.Windows.Forms.Label();
            this.lbl_IdAluno = new System.Windows.Forms.Label();
            this.cmb_NomeAluno = new System.Windows.Forms.ComboBox();
            this.msk_IdAluno = new System.Windows.Forms.MaskedTextBox();
            this.btn_ConsultarMensalidades = new System.Windows.Forms.Button();
            this.dgv_MensalidadesAluno = new System.Windows.Forms.DataGridView();
            this.códigoDaMensalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.códigoDoAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.númeroDaParcelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situaçãoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataDeVencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.númeroTotalDeParcelasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situaçãoTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allMensalidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_EscolaDataSet4 = new CadastroFuncionario.DB_EscolaDataSet4();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_SalvarAlteracao = new System.Windows.Forms.Button();
            this.allMensalidadesTableAdapter = new CadastroFuncionario.DB_EscolaDataSet4TableAdapters.AllMensalidadesTableAdapter();
            this.group_MensalidadesAlunos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MensalidadesAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allMensalidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // group_MensalidadesAlunos
            // 
            this.group_MensalidadesAlunos.Controls.Add(this.rdb_APagar);
            this.group_MensalidadesAlunos.Controls.Add(this.rdb_Pago);
            this.group_MensalidadesAlunos.Controls.Add(this.lbl_Situacao);
            this.group_MensalidadesAlunos.Controls.Add(this.lbl_NomeAluno);
            this.group_MensalidadesAlunos.Controls.Add(this.lbl_IdAluno);
            this.group_MensalidadesAlunos.Controls.Add(this.cmb_NomeAluno);
            this.group_MensalidadesAlunos.Controls.Add(this.msk_IdAluno);
            this.group_MensalidadesAlunos.Controls.Add(this.btn_ConsultarMensalidades);
            this.group_MensalidadesAlunos.Controls.Add(this.dgv_MensalidadesAluno);
            resources.ApplyResources(this.group_MensalidadesAlunos, "group_MensalidadesAlunos");
            this.group_MensalidadesAlunos.Name = "group_MensalidadesAlunos";
            this.group_MensalidadesAlunos.TabStop = false;
            // 
            // rdb_APagar
            // 
            resources.ApplyResources(this.rdb_APagar, "rdb_APagar");
            this.rdb_APagar.Name = "rdb_APagar";
            this.rdb_APagar.TabStop = true;
            this.rdb_APagar.Tag = "0";
            this.rdb_APagar.UseVisualStyleBackColor = true;
            // 
            // rdb_Pago
            // 
            resources.ApplyResources(this.rdb_Pago, "rdb_Pago");
            this.rdb_Pago.Name = "rdb_Pago";
            this.rdb_Pago.TabStop = true;
            this.rdb_Pago.Tag = "0";
            this.rdb_Pago.UseVisualStyleBackColor = true;
            // 
            // lbl_Situacao
            // 
            resources.ApplyResources(this.lbl_Situacao, "lbl_Situacao");
            this.lbl_Situacao.Name = "lbl_Situacao";
            this.lbl_Situacao.Tag = "0";
            // 
            // lbl_NomeAluno
            // 
            resources.ApplyResources(this.lbl_NomeAluno, "lbl_NomeAluno");
            this.lbl_NomeAluno.Name = "lbl_NomeAluno";
            this.lbl_NomeAluno.Tag = "0";
            // 
            // lbl_IdAluno
            // 
            resources.ApplyResources(this.lbl_IdAluno, "lbl_IdAluno");
            this.lbl_IdAluno.Name = "lbl_IdAluno";
            this.lbl_IdAluno.Tag = "0";
            // 
            // cmb_NomeAluno
            // 
            this.cmb_NomeAluno.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_NomeAluno, "cmb_NomeAluno");
            this.cmb_NomeAluno.Name = "cmb_NomeAluno";
            this.cmb_NomeAluno.SelectedValueChanged += new System.EventHandler(this.cmb_NomeAluno_SelectedValueChanged);
            this.cmb_NomeAluno.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_NomeAluno_PreviewKeyDown);
            // 
            // msk_IdAluno
            // 
            resources.ApplyResources(this.msk_IdAluno, "msk_IdAluno");
            this.msk_IdAluno.Name = "msk_IdAluno";
            this.msk_IdAluno.TextChanged += new System.EventHandler(this.msk_IdAluno_TextChanged);
            // 
            // btn_ConsultarMensalidades
            // 
            resources.ApplyResources(this.btn_ConsultarMensalidades, "btn_ConsultarMensalidades");
            this.btn_ConsultarMensalidades.Name = "btn_ConsultarMensalidades";
            this.btn_ConsultarMensalidades.Tag = "0";
            this.btn_ConsultarMensalidades.UseVisualStyleBackColor = true;
            this.btn_ConsultarMensalidades.Click += new System.EventHandler(this.btn_ConsultarMensalidades_Click);
            // 
            // dgv_MensalidadesAluno
            // 
            this.dgv_MensalidadesAluno.AllowUserToAddRows = false;
            this.dgv_MensalidadesAluno.AllowUserToDeleteRows = false;
            this.dgv_MensalidadesAluno.AutoGenerateColumns = false;
            this.dgv_MensalidadesAluno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_MensalidadesAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MensalidadesAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.códigoDaMensalidadeDataGridViewTextBoxColumn,
            this.códigoDoAlunoDataGridViewTextBoxColumn,
            this.númeroDaParcelaDataGridViewTextBoxColumn,
            this.situaçãoDataGridViewCheckBoxColumn,
            this.dataDeVencimentoDataGridViewTextBoxColumn,
            this.númeroTotalDeParcelasDataGridViewTextBoxColumn,
            this.situaçãoTotalDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn});
            this.dgv_MensalidadesAluno.DataSource = this.allMensalidadesBindingSource;
            resources.ApplyResources(this.dgv_MensalidadesAluno, "dgv_MensalidadesAluno");
            this.dgv_MensalidadesAluno.Name = "dgv_MensalidadesAluno";
            this.dgv_MensalidadesAluno.ReadOnly = true;
            this.dgv_MensalidadesAluno.Tag = "0";
            this.dgv_MensalidadesAluno.SelectionChanged += new System.EventHandler(this.dgv_MensalidadesAluno_SelectionChanged);
            // 
            // códigoDaMensalidadeDataGridViewTextBoxColumn
            // 
            this.códigoDaMensalidadeDataGridViewTextBoxColumn.DataPropertyName = "Código da mensalidade";
            resources.ApplyResources(this.códigoDaMensalidadeDataGridViewTextBoxColumn, "códigoDaMensalidadeDataGridViewTextBoxColumn");
            this.códigoDaMensalidadeDataGridViewTextBoxColumn.Name = "códigoDaMensalidadeDataGridViewTextBoxColumn";
            this.códigoDaMensalidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // códigoDoAlunoDataGridViewTextBoxColumn
            // 
            this.códigoDoAlunoDataGridViewTextBoxColumn.DataPropertyName = "Código do aluno";
            resources.ApplyResources(this.códigoDoAlunoDataGridViewTextBoxColumn, "códigoDoAlunoDataGridViewTextBoxColumn");
            this.códigoDoAlunoDataGridViewTextBoxColumn.Name = "códigoDoAlunoDataGridViewTextBoxColumn";
            this.códigoDoAlunoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // númeroDaParcelaDataGridViewTextBoxColumn
            // 
            this.númeroDaParcelaDataGridViewTextBoxColumn.DataPropertyName = "Número da parcela";
            resources.ApplyResources(this.númeroDaParcelaDataGridViewTextBoxColumn, "númeroDaParcelaDataGridViewTextBoxColumn");
            this.númeroDaParcelaDataGridViewTextBoxColumn.Name = "númeroDaParcelaDataGridViewTextBoxColumn";
            this.númeroDaParcelaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // situaçãoDataGridViewCheckBoxColumn
            // 
            this.situaçãoDataGridViewCheckBoxColumn.DataPropertyName = "Situação";
            resources.ApplyResources(this.situaçãoDataGridViewCheckBoxColumn, "situaçãoDataGridViewCheckBoxColumn");
            this.situaçãoDataGridViewCheckBoxColumn.Name = "situaçãoDataGridViewCheckBoxColumn";
            this.situaçãoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // dataDeVencimentoDataGridViewTextBoxColumn
            // 
            this.dataDeVencimentoDataGridViewTextBoxColumn.DataPropertyName = "Data de vencimento";
            resources.ApplyResources(this.dataDeVencimentoDataGridViewTextBoxColumn, "dataDeVencimentoDataGridViewTextBoxColumn");
            this.dataDeVencimentoDataGridViewTextBoxColumn.Name = "dataDeVencimentoDataGridViewTextBoxColumn";
            this.dataDeVencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // númeroTotalDeParcelasDataGridViewTextBoxColumn
            // 
            this.númeroTotalDeParcelasDataGridViewTextBoxColumn.DataPropertyName = "Número total de parcelas";
            resources.ApplyResources(this.númeroTotalDeParcelasDataGridViewTextBoxColumn, "númeroTotalDeParcelasDataGridViewTextBoxColumn");
            this.númeroTotalDeParcelasDataGridViewTextBoxColumn.Name = "númeroTotalDeParcelasDataGridViewTextBoxColumn";
            this.númeroTotalDeParcelasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // situaçãoTotalDataGridViewTextBoxColumn
            // 
            this.situaçãoTotalDataGridViewTextBoxColumn.DataPropertyName = "Situação total";
            resources.ApplyResources(this.situaçãoTotalDataGridViewTextBoxColumn, "situaçãoTotalDataGridViewTextBoxColumn");
            this.situaçãoTotalDataGridViewTextBoxColumn.Name = "situaçãoTotalDataGridViewTextBoxColumn";
            this.situaçãoTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            resources.ApplyResources(this.nomeDataGridViewTextBoxColumn, "nomeDataGridViewTextBoxColumn");
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // allMensalidadesBindingSource
            // 
            this.allMensalidadesBindingSource.DataMember = "AllMensalidades";
            this.allMensalidadesBindingSource.DataSource = this.dB_EscolaDataSet4;
            // 
            // dB_EscolaDataSet4
            // 
            this.dB_EscolaDataSet4.DataSetName = "DB_EscolaDataSet4";
            this.dB_EscolaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Cancelar
            // 
            resources.ApplyResources(this.btn_Cancelar, "btn_Cancelar");
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_SalvarAlteracao
            // 
            resources.ApplyResources(this.btn_SalvarAlteracao, "btn_SalvarAlteracao");
            this.btn_SalvarAlteracao.Name = "btn_SalvarAlteracao";
            this.btn_SalvarAlteracao.UseVisualStyleBackColor = true;
            this.btn_SalvarAlteracao.Click += new System.EventHandler(this.btn_SalvarAlteracao_Click);
            // 
            // allMensalidadesTableAdapter
            // 
            this.allMensalidadesTableAdapter.ClearBeforeFill = true;
            // 
            // FormMensalidadesAlunos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btn_SalvarAlteracao);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.group_MensalidadesAlunos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormMensalidadesAlunos";
            this.Load += new System.EventHandler(this.FormMensalidadesAlunos_Load);
            this.group_MensalidadesAlunos.ResumeLayout(false);
            this.group_MensalidadesAlunos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MensalidadesAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allMensalidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_MensalidadesAlunos;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_SalvarAlteracao;
        private System.Windows.Forms.DataGridView dgv_MensalidadesAluno;
        private System.Windows.Forms.Label lbl_NomeAluno;
        private System.Windows.Forms.Label lbl_IdAluno;
        private System.Windows.Forms.ComboBox cmb_NomeAluno;
        private System.Windows.Forms.MaskedTextBox msk_IdAluno;
        private System.Windows.Forms.Button btn_ConsultarMensalidades;
        private System.Windows.Forms.RadioButton rdb_APagar;
        private System.Windows.Forms.RadioButton rdb_Pago;
        private System.Windows.Forms.Label lbl_Situacao;
        private DB_EscolaDataSet4 dB_EscolaDataSet4;
        private System.Windows.Forms.BindingSource allMensalidadesBindingSource;
        private DB_EscolaDataSet4TableAdapters.AllMensalidadesTableAdapter allMensalidadesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoDaMensalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoDoAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn númeroDaParcelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn situaçãoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDeVencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn númeroTotalDeParcelasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situaçãoTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
    }
}