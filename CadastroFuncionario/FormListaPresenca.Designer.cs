namespace CadastroFuncionario
{
    partial class FormListaPresenca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaPresenca));
            this.group_ListaPresenca = new System.Windows.Forms.GroupBox();
            this.dtp_DataAula = new System.Windows.Forms.DateTimePicker();
            this.lbl_DataAula = new System.Windows.Forms.Label();
            this.lbl_Professor = new System.Windows.Forms.Label();
            this.lbl_Sala = new System.Windows.Forms.Label();
            this.btn_ConsultarLista = new System.Windows.Forms.Button();
            this.lbl_IdTurma = new System.Windows.Forms.Label();
            this.msk_IdTurma = new System.Windows.Forms.MaskedTextBox();
            this.dgv_ListaPresenca = new System.Windows.Forms.DataGridView();
            this.idPresencaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nºChamadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDoAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presençaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.diaDaAulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.códigoDaTurmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.númeroDaSalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDoProfessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaPresencaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_EscolaDataSet1 = new CadastroFuncionario.DB_EscolaDataSet1();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_SalvarLista = new System.Windows.Forms.Button();
            this.listaPresencaTableAdapter = new CadastroFuncionario.DB_EscolaDataSet1TableAdapters.ListaPresencaTableAdapter();
            this.group_ListaPresenca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaPresenca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPresencaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // group_ListaPresenca
            // 
            resources.ApplyResources(this.group_ListaPresenca, "group_ListaPresenca");
            this.group_ListaPresenca.Controls.Add(this.dtp_DataAula);
            this.group_ListaPresenca.Controls.Add(this.lbl_DataAula);
            this.group_ListaPresenca.Controls.Add(this.lbl_Professor);
            this.group_ListaPresenca.Controls.Add(this.lbl_Sala);
            this.group_ListaPresenca.Controls.Add(this.btn_ConsultarLista);
            this.group_ListaPresenca.Controls.Add(this.lbl_IdTurma);
            this.group_ListaPresenca.Controls.Add(this.msk_IdTurma);
            this.group_ListaPresenca.Controls.Add(this.dgv_ListaPresenca);
            this.group_ListaPresenca.Name = "group_ListaPresenca";
            this.group_ListaPresenca.TabStop = false;
            // 
            // dtp_DataAula
            // 
            this.dtp_DataAula.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtp_DataAula, "dtp_DataAula");
            this.dtp_DataAula.Name = "dtp_DataAula";
            // 
            // lbl_DataAula
            // 
            resources.ApplyResources(this.lbl_DataAula, "lbl_DataAula");
            this.lbl_DataAula.Name = "lbl_DataAula";
            // 
            // lbl_Professor
            // 
            resources.ApplyResources(this.lbl_Professor, "lbl_Professor");
            this.lbl_Professor.Name = "lbl_Professor";
            this.lbl_Professor.Tag = "0";
            // 
            // lbl_Sala
            // 
            resources.ApplyResources(this.lbl_Sala, "lbl_Sala");
            this.lbl_Sala.Name = "lbl_Sala";
            this.lbl_Sala.Tag = "0";
            // 
            // btn_ConsultarLista
            // 
            resources.ApplyResources(this.btn_ConsultarLista, "btn_ConsultarLista");
            this.btn_ConsultarLista.Name = "btn_ConsultarLista";
            this.btn_ConsultarLista.Tag = "0";
            this.btn_ConsultarLista.UseVisualStyleBackColor = true;
            this.btn_ConsultarLista.Click += new System.EventHandler(this.btn_ConsultarLista_Click);
            // 
            // lbl_IdTurma
            // 
            resources.ApplyResources(this.lbl_IdTurma, "lbl_IdTurma");
            this.lbl_IdTurma.Name = "lbl_IdTurma";
            // 
            // msk_IdTurma
            // 
            resources.ApplyResources(this.msk_IdTurma, "msk_IdTurma");
            this.msk_IdTurma.Name = "msk_IdTurma";
            this.msk_IdTurma.TextChanged += new System.EventHandler(this.msk_IdTurma_TextChanged);
            // 
            // dgv_ListaPresenca
            // 
            this.dgv_ListaPresenca.AllowUserToAddRows = false;
            this.dgv_ListaPresenca.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dgv_ListaPresenca, "dgv_ListaPresenca");
            this.dgv_ListaPresenca.AutoGenerateColumns = false;
            this.dgv_ListaPresenca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ListaPresenca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaPresenca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPresencaDataGridViewTextBoxColumn,
            this.nºChamadaDataGridViewTextBoxColumn,
            this.nomeDoAlunoDataGridViewTextBoxColumn,
            this.presençaDataGridViewCheckBoxColumn,
            this.diaDaAulaDataGridViewTextBoxColumn,
            this.códigoDaTurmaDataGridViewTextBoxColumn,
            this.númeroDaSalaDataGridViewTextBoxColumn,
            this.nomeDoProfessorDataGridViewTextBoxColumn,
            this.cursoDataGridViewTextBoxColumn});
            this.dgv_ListaPresenca.DataSource = this.listaPresencaBindingSource;
            this.dgv_ListaPresenca.Name = "dgv_ListaPresenca";
            this.dgv_ListaPresenca.Tag = "0";
            // 
            // idPresencaDataGridViewTextBoxColumn
            // 
            this.idPresencaDataGridViewTextBoxColumn.DataPropertyName = "Id_Presenca";
            resources.ApplyResources(this.idPresencaDataGridViewTextBoxColumn, "idPresencaDataGridViewTextBoxColumn");
            this.idPresencaDataGridViewTextBoxColumn.Name = "idPresencaDataGridViewTextBoxColumn";
            this.idPresencaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nºChamadaDataGridViewTextBoxColumn
            // 
            this.nºChamadaDataGridViewTextBoxColumn.DataPropertyName = "Nº chamada";
            resources.ApplyResources(this.nºChamadaDataGridViewTextBoxColumn, "nºChamadaDataGridViewTextBoxColumn");
            this.nºChamadaDataGridViewTextBoxColumn.Name = "nºChamadaDataGridViewTextBoxColumn";
            this.nºChamadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDoAlunoDataGridViewTextBoxColumn
            // 
            this.nomeDoAlunoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomeDoAlunoDataGridViewTextBoxColumn.DataPropertyName = "Nome do aluno";
            resources.ApplyResources(this.nomeDoAlunoDataGridViewTextBoxColumn, "nomeDoAlunoDataGridViewTextBoxColumn");
            this.nomeDoAlunoDataGridViewTextBoxColumn.Name = "nomeDoAlunoDataGridViewTextBoxColumn";
            this.nomeDoAlunoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // presençaDataGridViewCheckBoxColumn
            // 
            this.presençaDataGridViewCheckBoxColumn.DataPropertyName = "Presença";
            resources.ApplyResources(this.presençaDataGridViewCheckBoxColumn, "presençaDataGridViewCheckBoxColumn");
            this.presençaDataGridViewCheckBoxColumn.Name = "presençaDataGridViewCheckBoxColumn";
            // 
            // diaDaAulaDataGridViewTextBoxColumn
            // 
            this.diaDaAulaDataGridViewTextBoxColumn.DataPropertyName = "Dia da aula";
            resources.ApplyResources(this.diaDaAulaDataGridViewTextBoxColumn, "diaDaAulaDataGridViewTextBoxColumn");
            this.diaDaAulaDataGridViewTextBoxColumn.Name = "diaDaAulaDataGridViewTextBoxColumn";
            this.diaDaAulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // códigoDaTurmaDataGridViewTextBoxColumn
            // 
            this.códigoDaTurmaDataGridViewTextBoxColumn.DataPropertyName = "Código da turma";
            resources.ApplyResources(this.códigoDaTurmaDataGridViewTextBoxColumn, "códigoDaTurmaDataGridViewTextBoxColumn");
            this.códigoDaTurmaDataGridViewTextBoxColumn.Name = "códigoDaTurmaDataGridViewTextBoxColumn";
            this.códigoDaTurmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // númeroDaSalaDataGridViewTextBoxColumn
            // 
            this.númeroDaSalaDataGridViewTextBoxColumn.DataPropertyName = "Número da sala";
            resources.ApplyResources(this.númeroDaSalaDataGridViewTextBoxColumn, "númeroDaSalaDataGridViewTextBoxColumn");
            this.númeroDaSalaDataGridViewTextBoxColumn.Name = "númeroDaSalaDataGridViewTextBoxColumn";
            this.númeroDaSalaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDoProfessorDataGridViewTextBoxColumn
            // 
            this.nomeDoProfessorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomeDoProfessorDataGridViewTextBoxColumn.DataPropertyName = "Nome do professor";
            resources.ApplyResources(this.nomeDoProfessorDataGridViewTextBoxColumn, "nomeDoProfessorDataGridViewTextBoxColumn");
            this.nomeDoProfessorDataGridViewTextBoxColumn.Name = "nomeDoProfessorDataGridViewTextBoxColumn";
            this.nomeDoProfessorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cursoDataGridViewTextBoxColumn
            // 
            this.cursoDataGridViewTextBoxColumn.DataPropertyName = "Curso";
            resources.ApplyResources(this.cursoDataGridViewTextBoxColumn, "cursoDataGridViewTextBoxColumn");
            this.cursoDataGridViewTextBoxColumn.Name = "cursoDataGridViewTextBoxColumn";
            this.cursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // listaPresencaBindingSource
            // 
            this.listaPresencaBindingSource.DataMember = "ListaPresenca";
            this.listaPresencaBindingSource.DataSource = this.dB_EscolaDataSet1;
            // 
            // dB_EscolaDataSet1
            // 
            this.dB_EscolaDataSet1.DataSetName = "DB_EscolaDataSet1";
            this.dB_EscolaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Cancelar
            // 
            resources.ApplyResources(this.btn_Cancelar, "btn_Cancelar");
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_SalvarLista
            // 
            resources.ApplyResources(this.btn_SalvarLista, "btn_SalvarLista");
            this.btn_SalvarLista.Name = "btn_SalvarLista";
            this.btn_SalvarLista.UseVisualStyleBackColor = true;
            this.btn_SalvarLista.Click += new System.EventHandler(this.btn_SalvarLista_Click);
            // 
            // listaPresencaTableAdapter
            // 
            this.listaPresencaTableAdapter.ClearBeforeFill = true;
            // 
            // FormListaPresenca
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_SalvarLista);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.group_ListaPresenca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormListaPresenca";
            this.group_ListaPresenca.ResumeLayout(false);
            this.group_ListaPresenca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaPresenca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPresencaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_ListaPresenca;
        private System.Windows.Forms.Label lbl_Professor;
        private System.Windows.Forms.Label lbl_Sala;
        private System.Windows.Forms.Button btn_ConsultarLista;
        private System.Windows.Forms.Label lbl_IdTurma;
        private System.Windows.Forms.MaskedTextBox msk_IdTurma;
        private System.Windows.Forms.DataGridView dgv_ListaPresenca;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_SalvarLista;
        private System.Windows.Forms.DateTimePicker dtp_DataAula;
        private System.Windows.Forms.Label lbl_DataAula;
        private DB_EscolaDataSet1 dB_EscolaDataSet1;
        private System.Windows.Forms.BindingSource listaPresencaBindingSource;
        private DB_EscolaDataSet1TableAdapters.ListaPresencaTableAdapter listaPresencaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPresencaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nºChamadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDoAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn presençaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDaAulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoDaTurmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn númeroDaSalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDoProfessorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoDataGridViewTextBoxColumn;
    }
}