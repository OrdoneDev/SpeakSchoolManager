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
            this.group_ListaPresenca = new System.Windows.Forms.GroupBox();
            this.dtp_DataAula = new System.Windows.Forms.DateTimePicker();
            this.lbl_DataAula = new System.Windows.Forms.Label();
            this.lbl_Professor = new System.Windows.Forms.Label();
            this.lbl_Sala = new System.Windows.Forms.Label();
            this.btn_ConsultarLista = new System.Windows.Forms.Button();
            this.lbl_IdTurma = new System.Windows.Forms.Label();
            this.msk_IdTurma = new System.Windows.Forms.MaskedTextBox();
            this.dgv_ListaPresenca = new System.Windows.Forms.DataGridView();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_SalvarLista = new System.Windows.Forms.Button();
            this.dB_EscolaDataSet1 = new CadastroFuncionario.DB_EscolaDataSet1();
            this.listaPresencaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaPresencaTableAdapter = new CadastroFuncionario.DB_EscolaDataSet1TableAdapters.ListaPresencaTableAdapter();
            this.idPresencaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nºChamadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDoAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presençaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.diaDaAulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.códigoDaTurmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.númeroDaSalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDoProfessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_ListaPresenca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaPresenca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPresencaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // group_ListaPresenca
            // 
            this.group_ListaPresenca.Controls.Add(this.dtp_DataAula);
            this.group_ListaPresenca.Controls.Add(this.lbl_DataAula);
            this.group_ListaPresenca.Controls.Add(this.lbl_Professor);
            this.group_ListaPresenca.Controls.Add(this.lbl_Sala);
            this.group_ListaPresenca.Controls.Add(this.btn_ConsultarLista);
            this.group_ListaPresenca.Controls.Add(this.lbl_IdTurma);
            this.group_ListaPresenca.Controls.Add(this.msk_IdTurma);
            this.group_ListaPresenca.Controls.Add(this.dgv_ListaPresenca);
            this.group_ListaPresenca.Location = new System.Drawing.Point(13, 13);
            this.group_ListaPresenca.Name = "group_ListaPresenca";
            this.group_ListaPresenca.Size = new System.Drawing.Size(877, 365);
            this.group_ListaPresenca.TabIndex = 0;
            this.group_ListaPresenca.TabStop = false;
            this.group_ListaPresenca.Text = "Lista de chamada";
            // 
            // dtp_DataAula
            // 
            this.dtp_DataAula.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DataAula.Location = new System.Drawing.Point(134, 24);
            this.dtp_DataAula.Name = "dtp_DataAula";
            this.dtp_DataAula.Size = new System.Drawing.Size(98, 20);
            this.dtp_DataAula.TabIndex = 7;
            // 
            // lbl_DataAula
            // 
            this.lbl_DataAula.AutoSize = true;
            this.lbl_DataAula.Location = new System.Drawing.Point(95, 27);
            this.lbl_DataAula.Name = "lbl_DataAula";
            this.lbl_DataAula.Size = new System.Drawing.Size(33, 13);
            this.lbl_DataAula.TabIndex = 6;
            this.lbl_DataAula.Text = "Data:";
            // 
            // lbl_Professor
            // 
            this.lbl_Professor.AutoSize = true;
            this.lbl_Professor.Location = new System.Drawing.Point(330, 27);
            this.lbl_Professor.Name = "lbl_Professor";
            this.lbl_Professor.Size = new System.Drawing.Size(0, 13);
            this.lbl_Professor.TabIndex = 5;
            this.lbl_Professor.Tag = "0";
            // 
            // lbl_Sala
            // 
            this.lbl_Sala.AutoSize = true;
            this.lbl_Sala.Location = new System.Drawing.Point(259, 27);
            this.lbl_Sala.Name = "lbl_Sala";
            this.lbl_Sala.Size = new System.Drawing.Size(0, 13);
            this.lbl_Sala.TabIndex = 4;
            this.lbl_Sala.Tag = "0";
            // 
            // btn_ConsultarLista
            // 
            this.btn_ConsultarLista.Location = new System.Drawing.Point(572, 21);
            this.btn_ConsultarLista.Name = "btn_ConsultarLista";
            this.btn_ConsultarLista.Size = new System.Drawing.Size(75, 23);
            this.btn_ConsultarLista.TabIndex = 3;
            this.btn_ConsultarLista.Tag = "0";
            this.btn_ConsultarLista.Text = "Consultar";
            this.btn_ConsultarLista.UseVisualStyleBackColor = true;
            this.btn_ConsultarLista.Click += new System.EventHandler(this.btn_ConsultarLista_Click);
            // 
            // lbl_IdTurma
            // 
            this.lbl_IdTurma.AutoSize = true;
            this.lbl_IdTurma.Location = new System.Drawing.Point(7, 27);
            this.lbl_IdTurma.Name = "lbl_IdTurma";
            this.lbl_IdTurma.Size = new System.Drawing.Size(48, 13);
            this.lbl_IdTurma.TabIndex = 2;
            this.lbl_IdTurma.Text = "Id turma:";
            // 
            // msk_IdTurma
            // 
            this.msk_IdTurma.Location = new System.Drawing.Point(57, 24);
            this.msk_IdTurma.Mask = "0000";
            this.msk_IdTurma.Name = "msk_IdTurma";
            this.msk_IdTurma.Size = new System.Drawing.Size(32, 20);
            this.msk_IdTurma.TabIndex = 1;
            this.msk_IdTurma.TextChanged += new System.EventHandler(this.msk_IdTurma_TextChanged);
            // 
            // dgv_ListaPresenca
            // 
            this.dgv_ListaPresenca.AllowUserToAddRows = false;
            this.dgv_ListaPresenca.AllowUserToDeleteRows = false;
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
            this.dgv_ListaPresenca.Location = new System.Drawing.Point(7, 49);
            this.dgv_ListaPresenca.Name = "dgv_ListaPresenca";
            this.dgv_ListaPresenca.Size = new System.Drawing.Size(864, 305);
            this.dgv_ListaPresenca.TabIndex = 0;
            this.dgv_ListaPresenca.Tag = "0";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(815, 384);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_SalvarLista
            // 
            this.btn_SalvarLista.Location = new System.Drawing.Point(727, 384);
            this.btn_SalvarLista.Name = "btn_SalvarLista";
            this.btn_SalvarLista.Size = new System.Drawing.Size(82, 23);
            this.btn_SalvarLista.TabIndex = 2;
            this.btn_SalvarLista.Text = "Salvar lista";
            this.btn_SalvarLista.UseVisualStyleBackColor = true;
            this.btn_SalvarLista.Click += new System.EventHandler(this.btn_SalvarLista_Click);
            // 
            // dB_EscolaDataSet1
            // 
            this.dB_EscolaDataSet1.DataSetName = "DB_EscolaDataSet1";
            this.dB_EscolaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaPresencaBindingSource
            // 
            this.listaPresencaBindingSource.DataMember = "ListaPresenca";
            this.listaPresencaBindingSource.DataSource = this.dB_EscolaDataSet1;
            // 
            // listaPresencaTableAdapter
            // 
            this.listaPresencaTableAdapter.ClearBeforeFill = true;
            // 
            // idPresencaDataGridViewTextBoxColumn
            // 
            this.idPresencaDataGridViewTextBoxColumn.DataPropertyName = "Id_Presenca";
            this.idPresencaDataGridViewTextBoxColumn.HeaderText = "Id_Presenca";
            this.idPresencaDataGridViewTextBoxColumn.Name = "idPresencaDataGridViewTextBoxColumn";
            this.idPresencaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPresencaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nºChamadaDataGridViewTextBoxColumn
            // 
            this.nºChamadaDataGridViewTextBoxColumn.DataPropertyName = "Nº chamada";
            this.nºChamadaDataGridViewTextBoxColumn.HeaderText = "Nº chamada";
            this.nºChamadaDataGridViewTextBoxColumn.Name = "nºChamadaDataGridViewTextBoxColumn";
            this.nºChamadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDoAlunoDataGridViewTextBoxColumn
            // 
            this.nomeDoAlunoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomeDoAlunoDataGridViewTextBoxColumn.DataPropertyName = "Nome do aluno";
            this.nomeDoAlunoDataGridViewTextBoxColumn.HeaderText = "Nome do aluno";
            this.nomeDoAlunoDataGridViewTextBoxColumn.Name = "nomeDoAlunoDataGridViewTextBoxColumn";
            this.nomeDoAlunoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDoAlunoDataGridViewTextBoxColumn.Width = 96;
            // 
            // presençaDataGridViewCheckBoxColumn
            // 
            this.presençaDataGridViewCheckBoxColumn.DataPropertyName = "Presença";
            this.presençaDataGridViewCheckBoxColumn.HeaderText = "Presença";
            this.presençaDataGridViewCheckBoxColumn.Name = "presençaDataGridViewCheckBoxColumn";
            // 
            // diaDaAulaDataGridViewTextBoxColumn
            // 
            this.diaDaAulaDataGridViewTextBoxColumn.DataPropertyName = "Dia da aula";
            this.diaDaAulaDataGridViewTextBoxColumn.HeaderText = "Dia da aula";
            this.diaDaAulaDataGridViewTextBoxColumn.Name = "diaDaAulaDataGridViewTextBoxColumn";
            this.diaDaAulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // códigoDaTurmaDataGridViewTextBoxColumn
            // 
            this.códigoDaTurmaDataGridViewTextBoxColumn.DataPropertyName = "Código da turma";
            this.códigoDaTurmaDataGridViewTextBoxColumn.HeaderText = "Código da turma";
            this.códigoDaTurmaDataGridViewTextBoxColumn.Name = "códigoDaTurmaDataGridViewTextBoxColumn";
            this.códigoDaTurmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // númeroDaSalaDataGridViewTextBoxColumn
            // 
            this.númeroDaSalaDataGridViewTextBoxColumn.DataPropertyName = "Número da sala";
            this.númeroDaSalaDataGridViewTextBoxColumn.HeaderText = "Número da sala";
            this.númeroDaSalaDataGridViewTextBoxColumn.Name = "númeroDaSalaDataGridViewTextBoxColumn";
            this.númeroDaSalaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDoProfessorDataGridViewTextBoxColumn
            // 
            this.nomeDoProfessorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomeDoProfessorDataGridViewTextBoxColumn.DataPropertyName = "Nome do professor";
            this.nomeDoProfessorDataGridViewTextBoxColumn.HeaderText = "Nome do professor";
            this.nomeDoProfessorDataGridViewTextBoxColumn.Name = "nomeDoProfessorDataGridViewTextBoxColumn";
            this.nomeDoProfessorDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDoProfessorDataGridViewTextBoxColumn.Width = 111;
            // 
            // cursoDataGridViewTextBoxColumn
            // 
            this.cursoDataGridViewTextBoxColumn.DataPropertyName = "Curso";
            this.cursoDataGridViewTextBoxColumn.HeaderText = "Curso";
            this.cursoDataGridViewTextBoxColumn.Name = "cursoDataGridViewTextBoxColumn";
            this.cursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormListaPresenca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 415);
            this.Controls.Add(this.btn_SalvarLista);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.group_ListaPresenca);
            this.Name = "FormListaPresenca";
            this.Text = "Lista de chamada";
            this.group_ListaPresenca.ResumeLayout(false);
            this.group_ListaPresenca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaPresenca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPresencaBindingSource)).EndInit();
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