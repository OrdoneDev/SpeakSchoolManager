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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCaixa));
            this.group_Caixa = new System.Windows.Forms.GroupBox();
            this.dgv_Caixa = new System.Windows.Forms.DataGridView();
            this.valorTotalPagoDeMensalidadesDeAlunosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalPagoAosFuncionáriosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caixaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_EscolaDataSet3 = new CadastroFuncionario.DB_EscolaDataSet3();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.caixaTableAdapter = new CadastroFuncionario.DB_EscolaDataSet3TableAdapters.CaixaTableAdapter();
            this.dtp_Data = new System.Windows.Forms.DateTimePicker();
            this.btn_Mes = new System.Windows.Forms.Button();
            this.btn_Total = new System.Windows.Forms.Button();
            this.lbl_Mes = new System.Windows.Forms.Label();
            this.group_Caixa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Caixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caixaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // group_Caixa
            // 
            this.group_Caixa.Controls.Add(this.lbl_Mes);
            this.group_Caixa.Controls.Add(this.btn_Total);
            this.group_Caixa.Controls.Add(this.btn_Mes);
            this.group_Caixa.Controls.Add(this.dtp_Data);
            this.group_Caixa.Controls.Add(this.dgv_Caixa);
            resources.ApplyResources(this.group_Caixa, "group_Caixa");
            this.group_Caixa.Name = "group_Caixa";
            this.group_Caixa.TabStop = false;
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
            // valorTotalPagoDeMensalidadesDeAlunosDataGridViewTextBoxColumn
            // 
            this.valorTotalPagoDeMensalidadesDeAlunosDataGridViewTextBoxColumn.DataPropertyName = "Valor total pago de mensalidades de alunos";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.valorTotalPagoDeMensalidadesDeAlunosDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.valorTotalPagoDeMensalidadesDeAlunosDataGridViewTextBoxColumn, "valorTotalPagoDeMensalidadesDeAlunosDataGridViewTextBoxColumn");
            this.valorTotalPagoDeMensalidadesDeAlunosDataGridViewTextBoxColumn.Name = "valorTotalPagoDeMensalidadesDeAlunosDataGridViewTextBoxColumn";
            this.valorTotalPagoDeMensalidadesDeAlunosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorTotalPagoAosFuncionáriosDataGridViewTextBoxColumn
            // 
            this.valorTotalPagoAosFuncionáriosDataGridViewTextBoxColumn.DataPropertyName = "Valor total pago aos funcionários";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.valorTotalPagoAosFuncionáriosDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.valorTotalPagoAosFuncionáriosDataGridViewTextBoxColumn, "valorTotalPagoAosFuncionáriosDataGridViewTextBoxColumn");
            this.valorTotalPagoAosFuncionáriosDataGridViewTextBoxColumn.Name = "valorTotalPagoAosFuncionáriosDataGridViewTextBoxColumn";
            this.valorTotalPagoAosFuncionáriosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // caixaBindingSource
            // 
            this.caixaBindingSource.DataMember = "Caixa";
            this.caixaBindingSource.DataSource = this.dB_EscolaDataSet3;
            // 
            // dB_EscolaDataSet3
            // 
            this.dB_EscolaDataSet3.DataSetName = "DB_EscolaDataSet3";
            this.dB_EscolaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Cancelar
            // 
            resources.ApplyResources(this.btn_Cancelar, "btn_Cancelar");
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // caixaTableAdapter
            // 
            this.caixaTableAdapter.ClearBeforeFill = true;
            // 
            // dtp_Data
            // 
            this.dtp_Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtp_Data, "dtp_Data");
            this.dtp_Data.Name = "dtp_Data";
            // 
            // btn_Mes
            // 
            resources.ApplyResources(this.btn_Mes, "btn_Mes");
            this.btn_Mes.Name = "btn_Mes";
            this.btn_Mes.UseVisualStyleBackColor = true;
            this.btn_Mes.Click += new System.EventHandler(this.btn_Mes_Click);
            // 
            // btn_Total
            // 
            resources.ApplyResources(this.btn_Total, "btn_Total");
            this.btn_Total.Name = "btn_Total";
            this.btn_Total.UseVisualStyleBackColor = true;
            this.btn_Total.Click += new System.EventHandler(this.btn_Total_Click);
            // 
            // lbl_Mes
            // 
            resources.ApplyResources(this.lbl_Mes, "lbl_Mes");
            this.lbl_Mes.Name = "lbl_Mes";
            // 
            // FormCaixa
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.group_Caixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCaixa";
            this.Load += new System.EventHandler(this.FormCaixa_Load);
            this.group_Caixa.ResumeLayout(false);
            this.group_Caixa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Caixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caixaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet3)).EndInit();
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
        private System.Windows.Forms.Label lbl_Mes;
        private System.Windows.Forms.Button btn_Total;
        private System.Windows.Forms.Button btn_Mes;
        private System.Windows.Forms.DateTimePicker dtp_Data;
    }
}