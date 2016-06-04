namespace CadastroFuncionario
{
    partial class FormCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCaixa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.group_Caixa = new System.Windows.Forms.GroupBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.dgv_Caixa = new System.Windows.Forms.DataGridView();
            this.dB_EscolaDataSet3 = new CadastroFuncionario.DB_EscolaDataSet3();
            this.caixaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.caixaTableAdapter = new CadastroFuncionario.DB_EscolaDataSet3TableAdapters.CaixaTableAdapter();
            this.valorTotalPagoDeMensalidadesDeAlunosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalPagoAosFuncionáriosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_Caixa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Caixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caixaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // group_Caixa
            // 
            this.group_Caixa.Controls.Add(this.dgv_Caixa);
            resources.ApplyResources(this.group_Caixa, "group_Caixa");
            this.group_Caixa.Name = "group_Caixa";
            this.group_Caixa.TabStop = false;
            // 
            // btn_Cancelar
            // 
            resources.ApplyResources(this.btn_Cancelar, "btn_Cancelar");
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // dgv_Caixa
            // 
            this.dgv_Caixa.AllowUserToAddRows = false;
            this.dgv_Caixa.AllowUserToDeleteRows = false;
            this.dgv_Caixa.AutoGenerateColumns = false;
            this.dgv_Caixa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Caixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Caixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valorTotalPagoDeMensalidadesDeAlunosDataGridViewTextBoxColumn,
            this.valorTotalPagoAosFuncionáriosDataGridViewTextBoxColumn});
            this.dgv_Caixa.DataSource = this.caixaBindingSource;
            resources.ApplyResources(this.dgv_Caixa, "dgv_Caixa");
            this.dgv_Caixa.Name = "dgv_Caixa";
            this.dgv_Caixa.ReadOnly = true;
            // 
            // dB_EscolaDataSet3
            // 
            this.dB_EscolaDataSet3.DataSetName = "DB_EscolaDataSet3";
            this.dB_EscolaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // caixaBindingSource
            // 
            this.caixaBindingSource.DataMember = "Caixa";
            this.caixaBindingSource.DataSource = this.dB_EscolaDataSet3;
            // 
            // caixaTableAdapter
            // 
            this.caixaTableAdapter.ClearBeforeFill = true;
            // 
            // valorTotalPagoDeMensalidadesDeAlunosDataGridViewTextBoxColumn
            // 
            this.valorTotalPagoDeMensalidadesDeAlunosDataGridViewTextBoxColumn.DataPropertyName = "Valor total pago de mensalidades de alunos";
            dataGridViewCellStyle13.Format = "C2";
            dataGridViewCellStyle13.NullValue = null;
            this.valorTotalPagoDeMensalidadesDeAlunosDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            resources.ApplyResources(this.valorTotalPagoDeMensalidadesDeAlunosDataGridViewTextBoxColumn, "valorTotalPagoDeMensalidadesDeAlunosDataGridViewTextBoxColumn");
            this.valorTotalPagoDeMensalidadesDeAlunosDataGridViewTextBoxColumn.Name = "valorTotalPagoDeMensalidadesDeAlunosDataGridViewTextBoxColumn";
            this.valorTotalPagoDeMensalidadesDeAlunosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorTotalPagoAosFuncionáriosDataGridViewTextBoxColumn
            // 
            this.valorTotalPagoAosFuncionáriosDataGridViewTextBoxColumn.DataPropertyName = "Valor total pago aos funcionários";
            dataGridViewCellStyle14.Format = "C2";
            dataGridViewCellStyle14.NullValue = null;
            this.valorTotalPagoAosFuncionáriosDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            resources.ApplyResources(this.valorTotalPagoAosFuncionáriosDataGridViewTextBoxColumn, "valorTotalPagoAosFuncionáriosDataGridViewTextBoxColumn");
            this.valorTotalPagoAosFuncionáriosDataGridViewTextBoxColumn.Name = "valorTotalPagoAosFuncionáriosDataGridViewTextBoxColumn";
            this.valorTotalPagoAosFuncionáriosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormCaixa
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.group_Caixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormCaixa";
            this.Load += new System.EventHandler(this.FormCaixa_Load);
            this.group_Caixa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Caixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caixaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_Caixa;
        private System.Windows.Forms.DataGridView dgv_Caixa;
        private System.Windows.Forms.Button btn_Cancelar;
        private DB_EscolaDataSet3 dB_EscolaDataSet3;
        private System.Windows.Forms.BindingSource caixaBindingSource;
        private DB_EscolaDataSet3TableAdapters.CaixaTableAdapter caixaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalPagoDeMensalidadesDeAlunosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalPagoAosFuncionáriosDataGridViewTextBoxColumn;
    }
}