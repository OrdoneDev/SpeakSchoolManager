namespace CadastroFuncionario
{
    partial class FormTabelaIdiomas
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
            this.group_TabelaIdiomas = new System.Windows.Forms.GroupBox();
            this.dgv_TabelaIdiomas = new System.Windows.Forms.DataGridView();
            this.dB_EscolaDataSet11 = new CadastroFuncionario.DB_EscolaDataSet11();
            this.idiomasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idiomasTableAdapter1 = new CadastroFuncionario.DB_EscolaDataSet11TableAdapters.IdiomasTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_TabelaIdiomas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaIdiomas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idiomasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // group_TabelaIdiomas
            // 
            this.group_TabelaIdiomas.Controls.Add(this.dgv_TabelaIdiomas);
            this.group_TabelaIdiomas.Location = new System.Drawing.Point(13, 13);
            this.group_TabelaIdiomas.Name = "group_TabelaIdiomas";
            this.group_TabelaIdiomas.Size = new System.Drawing.Size(624, 250);
            this.group_TabelaIdiomas.TabIndex = 0;
            this.group_TabelaIdiomas.TabStop = false;
            this.group_TabelaIdiomas.Text = "Idiomas";
            // 
            // dgv_TabelaIdiomas
            // 
            this.dgv_TabelaIdiomas.AllowUserToAddRows = false;
            this.dgv_TabelaIdiomas.AutoGenerateColumns = false;
            this.dgv_TabelaIdiomas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TabelaIdiomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TabelaIdiomas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgv_TabelaIdiomas.DataSource = this.idiomasBindingSource;
            this.dgv_TabelaIdiomas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_TabelaIdiomas.Location = new System.Drawing.Point(3, 16);
            this.dgv_TabelaIdiomas.Name = "dgv_TabelaIdiomas";
            this.dgv_TabelaIdiomas.Size = new System.Drawing.Size(618, 231);
            this.dgv_TabelaIdiomas.TabIndex = 0;
            // 
            // dB_EscolaDataSet11
            // 
            this.dB_EscolaDataSet11.DataSetName = "DB_EscolaDataSet11";
            this.dB_EscolaDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idiomasBindingSource
            // 
            this.idiomasBindingSource.DataMember = "Idiomas";
            this.idiomasBindingSource.DataSource = this.dB_EscolaDataSet11;
            // 
            // idiomasTableAdapter1
            // 
            this.idiomasTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Idioma";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código do idioma";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // FormTabelaIdiomas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 275);
            this.Controls.Add(this.group_TabelaIdiomas);
            this.Name = "FormTabelaIdiomas";
            this.Text = "Tabela de idiomas";
            this.Load += new System.EventHandler(this.FormTabelaIdiomas_Load);
            this.group_TabelaIdiomas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaIdiomas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idiomasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_TabelaIdiomas;
        private System.Windows.Forms.DataGridView dgv_TabelaIdiomas;
        private DB_EscolaDataSet11 TabelaIdiomas;
        private DB_EscolaDataSet11TableAdapters.IdiomasTableAdapter idiomasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idIdiomaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private DB_EscolaDataSet11 dB_EscolaDataSet11;
        private System.Windows.Forms.BindingSource idiomasBindingSource;
        private DB_EscolaDataSet11TableAdapters.IdiomasTableAdapter idiomasTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}