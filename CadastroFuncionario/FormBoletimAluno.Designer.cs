namespace CadastroFuncionario
{
    partial class FormBoletimAluno
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
            this.group_BoletimAluno = new System.Windows.Forms.GroupBox();
            this.lbl_IdAluno = new System.Windows.Forms.Label();
            this.msk_IdAluno = new System.Windows.Forms.MaskedTextBox();
            this.lbl_NomeAluno = new System.Windows.Forms.Label();
            this.cmb_NomeAluno = new System.Windows.Forms.ComboBox();
            this.dgv_BoletimAluno = new System.Windows.Forms.DataGridView();
            this.códigoDaInscriçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.códigoDoAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDoAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDoAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prova1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prova2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faltasNoSemestreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allBoletimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_EscolaDataSet2 = new CadastroFuncionario.DB_EscolaDataSet2();
            this.btn_ConsultarBoletim = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_SalvarAlteracoes = new System.Windows.Forms.Button();
            this.allBoletimTableAdapter = new CadastroFuncionario.DB_EscolaDataSet2TableAdapters.AllBoletimTableAdapter();
            this.group_BoletimAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BoletimAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allBoletimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // group_BoletimAluno
            // 
            this.group_BoletimAluno.Controls.Add(this.lbl_IdAluno);
            this.group_BoletimAluno.Controls.Add(this.msk_IdAluno);
            this.group_BoletimAluno.Controls.Add(this.lbl_NomeAluno);
            this.group_BoletimAluno.Controls.Add(this.cmb_NomeAluno);
            this.group_BoletimAluno.Controls.Add(this.dgv_BoletimAluno);
            this.group_BoletimAluno.Controls.Add(this.btn_ConsultarBoletim);
            this.group_BoletimAluno.Location = new System.Drawing.Point(13, 13);
            this.group_BoletimAluno.Name = "group_BoletimAluno";
            this.group_BoletimAluno.Size = new System.Drawing.Size(776, 273);
            this.group_BoletimAluno.TabIndex = 0;
            this.group_BoletimAluno.TabStop = false;
            this.group_BoletimAluno.Tag = "0";
            this.group_BoletimAluno.Text = "Boletim do aluno";
            // 
            // lbl_IdAluno
            // 
            this.lbl_IdAluno.AutoSize = true;
            this.lbl_IdAluno.Location = new System.Drawing.Point(10, 23);
            this.lbl_IdAluno.Name = "lbl_IdAluno";
            this.lbl_IdAluno.Size = new System.Drawing.Size(48, 13);
            this.lbl_IdAluno.TabIndex = 2;
            this.lbl_IdAluno.Tag = "0";
            this.lbl_IdAluno.Text = "Id aluno:";
            // 
            // msk_IdAluno
            // 
            this.msk_IdAluno.Location = new System.Drawing.Point(62, 20);
            this.msk_IdAluno.Mask = "0000";
            this.msk_IdAluno.Name = "msk_IdAluno";
            this.msk_IdAluno.Size = new System.Drawing.Size(30, 20);
            this.msk_IdAluno.TabIndex = 1;
            this.msk_IdAluno.TextChanged += new System.EventHandler(this.msk_IdAluno_TextChanged);
            // 
            // lbl_NomeAluno
            // 
            this.lbl_NomeAluno.AutoSize = true;
            this.lbl_NomeAluno.Location = new System.Drawing.Point(242, 23);
            this.lbl_NomeAluno.Name = "lbl_NomeAluno";
            this.lbl_NomeAluno.Size = new System.Drawing.Size(67, 13);
            this.lbl_NomeAluno.TabIndex = 4;
            this.lbl_NomeAluno.Tag = "0";
            this.lbl_NomeAluno.Text = "Nome aluno:";
            // 
            // cmb_NomeAluno
            // 
            this.cmb_NomeAluno.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_NomeAluno.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_NomeAluno.FormattingEnabled = true;
            this.cmb_NomeAluno.Location = new System.Drawing.Point(315, 20);
            this.cmb_NomeAluno.MaxLength = 40;
            this.cmb_NomeAluno.Name = "cmb_NomeAluno";
            this.cmb_NomeAluno.Size = new System.Drawing.Size(196, 21);
            this.cmb_NomeAluno.TabIndex = 2;
            this.cmb_NomeAluno.SelectedValueChanged += new System.EventHandler(this.cmb_NomeAluno_SelectedValueChanged);
            this.cmb_NomeAluno.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_NomeAluno_PreviewKeyDown);
            // 
            // dgv_BoletimAluno
            // 
            this.dgv_BoletimAluno.AllowUserToAddRows = false;
            this.dgv_BoletimAluno.AllowUserToDeleteRows = false;
            this.dgv_BoletimAluno.AutoGenerateColumns = false;
            this.dgv_BoletimAluno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_BoletimAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BoletimAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.códigoDaInscriçãoDataGridViewTextBoxColumn,
            this.códigoDoAlunoDataGridViewTextBoxColumn,
            this.nomeDoAlunoDataGridViewTextBoxColumn,
            this.statusDoAlunoDataGridViewTextBoxColumn,
            this.cursoDataGridViewTextBoxColumn,
            this.prova1DataGridViewTextBoxColumn,
            this.prova2DataGridViewTextBoxColumn,
            this.mediaDataGridViewTextBoxColumn,
            this.faltasNoSemestreDataGridViewTextBoxColumn});
            this.dgv_BoletimAluno.DataSource = this.allBoletimBindingSource;
            this.dgv_BoletimAluno.Location = new System.Drawing.Point(7, 46);
            this.dgv_BoletimAluno.Name = "dgv_BoletimAluno";
            this.dgv_BoletimAluno.Size = new System.Drawing.Size(763, 218);
            this.dgv_BoletimAluno.TabIndex = 4;
            this.dgv_BoletimAluno.Tag = "0";
            this.dgv_BoletimAluno.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dgv_BoletimAluno_CellParsing);
            this.dgv_BoletimAluno.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_BoletimAluno_DataError);
            // 
            // códigoDaInscriçãoDataGridViewTextBoxColumn
            // 
            this.códigoDaInscriçãoDataGridViewTextBoxColumn.DataPropertyName = "Código da inscrição";
            this.códigoDaInscriçãoDataGridViewTextBoxColumn.Frozen = true;
            this.códigoDaInscriçãoDataGridViewTextBoxColumn.HeaderText = "Código da inscrição";
            this.códigoDaInscriçãoDataGridViewTextBoxColumn.Name = "códigoDaInscriçãoDataGridViewTextBoxColumn";
            this.códigoDaInscriçãoDataGridViewTextBoxColumn.ReadOnly = true;
            this.códigoDaInscriçãoDataGridViewTextBoxColumn.Width = 114;
            // 
            // códigoDoAlunoDataGridViewTextBoxColumn
            // 
            this.códigoDoAlunoDataGridViewTextBoxColumn.DataPropertyName = "Código do aluno";
            this.códigoDoAlunoDataGridViewTextBoxColumn.Frozen = true;
            this.códigoDoAlunoDataGridViewTextBoxColumn.HeaderText = "Código do aluno";
            this.códigoDoAlunoDataGridViewTextBoxColumn.Name = "códigoDoAlunoDataGridViewTextBoxColumn";
            this.códigoDoAlunoDataGridViewTextBoxColumn.ReadOnly = true;
            this.códigoDoAlunoDataGridViewTextBoxColumn.Width = 77;
            // 
            // nomeDoAlunoDataGridViewTextBoxColumn
            // 
            this.nomeDoAlunoDataGridViewTextBoxColumn.DataPropertyName = "Nome do aluno";
            this.nomeDoAlunoDataGridViewTextBoxColumn.Frozen = true;
            this.nomeDoAlunoDataGridViewTextBoxColumn.HeaderText = "Nome do aluno";
            this.nomeDoAlunoDataGridViewTextBoxColumn.Name = "nomeDoAlunoDataGridViewTextBoxColumn";
            this.nomeDoAlunoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDoAlunoDataGridViewTextBoxColumn.Width = 96;
            // 
            // statusDoAlunoDataGridViewTextBoxColumn
            // 
            this.statusDoAlunoDataGridViewTextBoxColumn.DataPropertyName = "Status do aluno";
            this.statusDoAlunoDataGridViewTextBoxColumn.Frozen = true;
            this.statusDoAlunoDataGridViewTextBoxColumn.HeaderText = "Status do aluno";
            this.statusDoAlunoDataGridViewTextBoxColumn.Name = "statusDoAlunoDataGridViewTextBoxColumn";
            this.statusDoAlunoDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDoAlunoDataGridViewTextBoxColumn.Width = 74;
            // 
            // cursoDataGridViewTextBoxColumn
            // 
            this.cursoDataGridViewTextBoxColumn.DataPropertyName = "Curso";
            this.cursoDataGridViewTextBoxColumn.Frozen = true;
            this.cursoDataGridViewTextBoxColumn.HeaderText = "Curso";
            this.cursoDataGridViewTextBoxColumn.Name = "cursoDataGridViewTextBoxColumn";
            this.cursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cursoDataGridViewTextBoxColumn.Width = 59;
            // 
            // prova1DataGridViewTextBoxColumn
            // 
            this.prova1DataGridViewTextBoxColumn.DataPropertyName = "Prova 1";
            this.prova1DataGridViewTextBoxColumn.Frozen = true;
            this.prova1DataGridViewTextBoxColumn.HeaderText = "Prova 1";
            this.prova1DataGridViewTextBoxColumn.MaxInputLength = 3;
            this.prova1DataGridViewTextBoxColumn.Name = "prova1DataGridViewTextBoxColumn";
            this.prova1DataGridViewTextBoxColumn.Width = 64;
            // 
            // prova2DataGridViewTextBoxColumn
            // 
            this.prova2DataGridViewTextBoxColumn.DataPropertyName = "Prova 2";
            this.prova2DataGridViewTextBoxColumn.Frozen = true;
            this.prova2DataGridViewTextBoxColumn.HeaderText = "Prova 2";
            this.prova2DataGridViewTextBoxColumn.MaxInputLength = 3;
            this.prova2DataGridViewTextBoxColumn.Name = "prova2DataGridViewTextBoxColumn";
            this.prova2DataGridViewTextBoxColumn.Width = 64;
            // 
            // mediaDataGridViewTextBoxColumn
            // 
            this.mediaDataGridViewTextBoxColumn.DataPropertyName = "Media";
            this.mediaDataGridViewTextBoxColumn.Frozen = true;
            this.mediaDataGridViewTextBoxColumn.HeaderText = "Media";
            this.mediaDataGridViewTextBoxColumn.Name = "mediaDataGridViewTextBoxColumn";
            this.mediaDataGridViewTextBoxColumn.ReadOnly = true;
            this.mediaDataGridViewTextBoxColumn.Width = 61;
            // 
            // faltasNoSemestreDataGridViewTextBoxColumn
            // 
            this.faltasNoSemestreDataGridViewTextBoxColumn.DataPropertyName = "Faltas no semestre";
            this.faltasNoSemestreDataGridViewTextBoxColumn.HeaderText = "Faltas no semestre";
            this.faltasNoSemestreDataGridViewTextBoxColumn.MaxInputLength = 2;
            this.faltasNoSemestreDataGridViewTextBoxColumn.Name = "faltasNoSemestreDataGridViewTextBoxColumn";
            this.faltasNoSemestreDataGridViewTextBoxColumn.Width = 110;
            // 
            // allBoletimBindingSource
            // 
            this.allBoletimBindingSource.DataMember = "AllBoletim";
            this.allBoletimBindingSource.DataSource = this.dB_EscolaDataSet2;
            // 
            // dB_EscolaDataSet2
            // 
            this.dB_EscolaDataSet2.DataSetName = "DB_EscolaDataSet2";
            this.dB_EscolaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_ConsultarBoletim
            // 
            this.btn_ConsultarBoletim.Location = new System.Drawing.Point(659, 18);
            this.btn_ConsultarBoletim.Name = "btn_ConsultarBoletim";
            this.btn_ConsultarBoletim.Size = new System.Drawing.Size(75, 23);
            this.btn_ConsultarBoletim.TabIndex = 3;
            this.btn_ConsultarBoletim.Tag = "0";
            this.btn_ConsultarBoletim.Text = "Consultar";
            this.btn_ConsultarBoletim.UseVisualStyleBackColor = true;
            this.btn_ConsultarBoletim.Click += new System.EventHandler(this.btn_ConsultarBoletim_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(708, 292);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_SalvarAlteracoes
            // 
            this.btn_SalvarAlteracoes.Location = new System.Drawing.Point(590, 292);
            this.btn_SalvarAlteracoes.Name = "btn_SalvarAlteracoes";
            this.btn_SalvarAlteracoes.Size = new System.Drawing.Size(112, 23);
            this.btn_SalvarAlteracoes.TabIndex = 5;
            this.btn_SalvarAlteracoes.Text = "Salvar alterações";
            this.btn_SalvarAlteracoes.UseVisualStyleBackColor = true;
            this.btn_SalvarAlteracoes.Click += new System.EventHandler(this.btn_SalvarAlteracoes_Click);
            // 
            // allBoletimTableAdapter
            // 
            this.allBoletimTableAdapter.ClearBeforeFill = true;
            // 
            // FormBoletimAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 328);
            this.Controls.Add(this.btn_SalvarAlteracoes);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.group_BoletimAluno);
            this.Name = "FormBoletimAluno";
            this.Text = "Boletim do aluno";
            this.Load += new System.EventHandler(this.FormBoletimAluno_Load);
            this.group_BoletimAluno.ResumeLayout(false);
            this.group_BoletimAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BoletimAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allBoletimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_BoletimAluno;
        private System.Windows.Forms.Button btn_ConsultarBoletim;
        private System.Windows.Forms.Label lbl_IdAluno;
        private System.Windows.Forms.MaskedTextBox msk_IdAluno;
        private System.Windows.Forms.Label lbl_NomeAluno;
        private System.Windows.Forms.ComboBox cmb_NomeAluno;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_SalvarAlteracoes;
        private System.Windows.Forms.DataGridView dgv_BoletimAluno;
        private DB_EscolaDataSet2 dB_EscolaDataSet2;
        private System.Windows.Forms.BindingSource allBoletimBindingSource;
        private DB_EscolaDataSet2TableAdapters.AllBoletimTableAdapter allBoletimTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoDaInscriçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoDoAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDoAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDoAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prova1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prova2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faltasNoSemestreDataGridViewTextBoxColumn;
    }
}