namespace CadastroFuncionario
{
    partial class FormInscricoesTurmas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInscricoesTurmas));
            this.group_InscricoesTurmas = new System.Windows.Forms.GroupBox();
            this.lbl_HoraSaida = new System.Windows.Forms.Label();
            this.lbl_HorarioSaida = new System.Windows.Forms.Label();
            this.lbl_HoraEntrada = new System.Windows.Forms.Label();
            this.lbl_HorarioEntrada = new System.Windows.Forms.Label();
            this.lbl_NSala = new System.Windows.Forms.Label();
            this.lbl_Sala = new System.Windows.Forms.Label();
            this.lbl_NomeProfessor = new System.Windows.Forms.Label();
            this.lbl_Professor = new System.Windows.Forms.Label();
            this.lbl_NomeCurso = new System.Windows.Forms.Label();
            this.lbl_Curso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.msk_IdTurma = new System.Windows.Forms.MaskedTextBox();
            this.dgv_Alunos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nomeDoAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planoContratadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vincularAlunoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.turmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscricoesTurmasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_EscolaDataSet = new CadastroFuncionario.DB_EscolaDataSet();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_SalvarVinculo = new System.Windows.Forms.Button();
            this.inscricoesTurmasTableAdapter = new CadastroFuncionario.DB_EscolaDataSetTableAdapters.InscricoesTurmasTableAdapter();
            this.group_InscricoesTurmas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricoesTurmasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // group_InscricoesTurmas
            // 
            this.group_InscricoesTurmas.Controls.Add(this.lbl_HoraSaida);
            this.group_InscricoesTurmas.Controls.Add(this.lbl_HorarioSaida);
            this.group_InscricoesTurmas.Controls.Add(this.lbl_HoraEntrada);
            this.group_InscricoesTurmas.Controls.Add(this.lbl_HorarioEntrada);
            this.group_InscricoesTurmas.Controls.Add(this.lbl_NSala);
            this.group_InscricoesTurmas.Controls.Add(this.lbl_Sala);
            this.group_InscricoesTurmas.Controls.Add(this.lbl_NomeProfessor);
            this.group_InscricoesTurmas.Controls.Add(this.lbl_Professor);
            this.group_InscricoesTurmas.Controls.Add(this.lbl_NomeCurso);
            this.group_InscricoesTurmas.Controls.Add(this.lbl_Curso);
            this.group_InscricoesTurmas.Controls.Add(this.label1);
            this.group_InscricoesTurmas.Controls.Add(this.msk_IdTurma);
            this.group_InscricoesTurmas.Controls.Add(this.dgv_Alunos);
            resources.ApplyResources(this.group_InscricoesTurmas, "group_InscricoesTurmas");
            this.group_InscricoesTurmas.Name = "group_InscricoesTurmas";
            this.group_InscricoesTurmas.TabStop = false;
            // 
            // lbl_HoraSaida
            // 
            resources.ApplyResources(this.lbl_HoraSaida, "lbl_HoraSaida");
            this.lbl_HoraSaida.Name = "lbl_HoraSaida";
            this.lbl_HoraSaida.Tag = "0";
            // 
            // lbl_HorarioSaida
            // 
            resources.ApplyResources(this.lbl_HorarioSaida, "lbl_HorarioSaida");
            this.lbl_HorarioSaida.Name = "lbl_HorarioSaida";
            this.lbl_HorarioSaida.Tag = "0";
            // 
            // lbl_HoraEntrada
            // 
            resources.ApplyResources(this.lbl_HoraEntrada, "lbl_HoraEntrada");
            this.lbl_HoraEntrada.Name = "lbl_HoraEntrada";
            this.lbl_HoraEntrada.Tag = "0";
            // 
            // lbl_HorarioEntrada
            // 
            resources.ApplyResources(this.lbl_HorarioEntrada, "lbl_HorarioEntrada");
            this.lbl_HorarioEntrada.Name = "lbl_HorarioEntrada";
            this.lbl_HorarioEntrada.Tag = "0";
            // 
            // lbl_NSala
            // 
            resources.ApplyResources(this.lbl_NSala, "lbl_NSala");
            this.lbl_NSala.Name = "lbl_NSala";
            this.lbl_NSala.Tag = "0";
            // 
            // lbl_Sala
            // 
            resources.ApplyResources(this.lbl_Sala, "lbl_Sala");
            this.lbl_Sala.Name = "lbl_Sala";
            this.lbl_Sala.Tag = "0";
            // 
            // lbl_NomeProfessor
            // 
            resources.ApplyResources(this.lbl_NomeProfessor, "lbl_NomeProfessor");
            this.lbl_NomeProfessor.Name = "lbl_NomeProfessor";
            this.lbl_NomeProfessor.Tag = "0";
            // 
            // lbl_Professor
            // 
            resources.ApplyResources(this.lbl_Professor, "lbl_Professor");
            this.lbl_Professor.Name = "lbl_Professor";
            this.lbl_Professor.Tag = "0";
            // 
            // lbl_NomeCurso
            // 
            resources.ApplyResources(this.lbl_NomeCurso, "lbl_NomeCurso");
            this.lbl_NomeCurso.Name = "lbl_NomeCurso";
            this.lbl_NomeCurso.Tag = "0";
            // 
            // lbl_Curso
            // 
            resources.ApplyResources(this.lbl_Curso, "lbl_Curso");
            this.lbl_Curso.Name = "lbl_Curso";
            this.lbl_Curso.Tag = "0";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Tag = "0";
            // 
            // msk_IdTurma
            // 
            resources.ApplyResources(this.msk_IdTurma, "msk_IdTurma");
            this.msk_IdTurma.Name = "msk_IdTurma";
            this.msk_IdTurma.Tag = "";
            this.msk_IdTurma.TextChanged += new System.EventHandler(this.msk_IdTurma_TextChanged);
            // 
            // dgv_Alunos
            // 
            this.dgv_Alunos.AllowUserToAddRows = false;
            this.dgv_Alunos.AllowUserToDeleteRows = false;
            this.dgv_Alunos.AutoGenerateColumns = false;
            this.dgv_Alunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Alunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.fotoDataGridViewImageColumn,
            this.nomeDoAlunoDataGridViewTextBoxColumn,
            this.cursoDataGridViewTextBoxColumn,
            this.planoContratadoDataGridViewTextBoxColumn,
            this.vincularAlunoDataGridViewCheckBoxColumn,
            this.turmaDataGridViewTextBoxColumn});
            this.dgv_Alunos.DataSource = this.inscricoesTurmasBindingSource;
            resources.ApplyResources(this.dgv_Alunos, "dgv_Alunos");
            this.dgv_Alunos.Name = "dgv_Alunos";
            this.dgv_Alunos.Tag = "0";
            this.dgv_Alunos.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Alunos_CellMouseEnter);
            this.dgv_Alunos.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Alunos_CellMouseLeave);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Código da inscrição";
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // fotoDataGridViewImageColumn
            // 
            this.fotoDataGridViewImageColumn.DataPropertyName = "Foto";
            resources.ApplyResources(this.fotoDataGridViewImageColumn, "fotoDataGridViewImageColumn");
            this.fotoDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.fotoDataGridViewImageColumn.Name = "fotoDataGridViewImageColumn";
            this.fotoDataGridViewImageColumn.ReadOnly = true;
            // 
            // nomeDoAlunoDataGridViewTextBoxColumn
            // 
            this.nomeDoAlunoDataGridViewTextBoxColumn.DataPropertyName = "Nome do aluno";
            resources.ApplyResources(this.nomeDoAlunoDataGridViewTextBoxColumn, "nomeDoAlunoDataGridViewTextBoxColumn");
            this.nomeDoAlunoDataGridViewTextBoxColumn.Name = "nomeDoAlunoDataGridViewTextBoxColumn";
            this.nomeDoAlunoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cursoDataGridViewTextBoxColumn
            // 
            this.cursoDataGridViewTextBoxColumn.DataPropertyName = "Curso";
            resources.ApplyResources(this.cursoDataGridViewTextBoxColumn, "cursoDataGridViewTextBoxColumn");
            this.cursoDataGridViewTextBoxColumn.Name = "cursoDataGridViewTextBoxColumn";
            this.cursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // planoContratadoDataGridViewTextBoxColumn
            // 
            this.planoContratadoDataGridViewTextBoxColumn.DataPropertyName = "Plano contratado";
            resources.ApplyResources(this.planoContratadoDataGridViewTextBoxColumn, "planoContratadoDataGridViewTextBoxColumn");
            this.planoContratadoDataGridViewTextBoxColumn.Name = "planoContratadoDataGridViewTextBoxColumn";
            this.planoContratadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vincularAlunoDataGridViewCheckBoxColumn
            // 
            this.vincularAlunoDataGridViewCheckBoxColumn.DataPropertyName = "Vincular aluno";
            resources.ApplyResources(this.vincularAlunoDataGridViewCheckBoxColumn, "vincularAlunoDataGridViewCheckBoxColumn");
            this.vincularAlunoDataGridViewCheckBoxColumn.Name = "vincularAlunoDataGridViewCheckBoxColumn";
            // 
            // turmaDataGridViewTextBoxColumn
            // 
            this.turmaDataGridViewTextBoxColumn.DataPropertyName = "Turma";
            resources.ApplyResources(this.turmaDataGridViewTextBoxColumn, "turmaDataGridViewTextBoxColumn");
            this.turmaDataGridViewTextBoxColumn.Name = "turmaDataGridViewTextBoxColumn";
            this.turmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inscricoesTurmasBindingSource
            // 
            this.inscricoesTurmasBindingSource.DataMember = "InscricoesTurmas";
            this.inscricoesTurmasBindingSource.DataSource = this.dB_EscolaDataSet;
            // 
            // dB_EscolaDataSet
            // 
            this.dB_EscolaDataSet.DataSetName = "DB_EscolaDataSet";
            this.dB_EscolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Cancelar
            // 
            resources.ApplyResources(this.btn_Cancelar, "btn_Cancelar");
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_SalvarVinculo
            // 
            resources.ApplyResources(this.btn_SalvarVinculo, "btn_SalvarVinculo");
            this.btn_SalvarVinculo.Name = "btn_SalvarVinculo";
            this.btn_SalvarVinculo.UseVisualStyleBackColor = true;
            this.btn_SalvarVinculo.Click += new System.EventHandler(this.btn_SalvarVinculo_Click);
            // 
            // inscricoesTurmasTableAdapter
            // 
            this.inscricoesTurmasTableAdapter.ClearBeforeFill = true;
            // 
            // FormInscricoesTurmas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_SalvarVinculo);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.group_InscricoesTurmas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormInscricoesTurmas";
            this.Load += new System.EventHandler(this.FormInscricoesTurmas_Load);
            this.group_InscricoesTurmas.ResumeLayout(false);
            this.group_InscricoesTurmas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricoesTurmasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EscolaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_InscricoesTurmas;
        private System.Windows.Forms.Label lbl_HoraSaida;
        private System.Windows.Forms.Label lbl_HorarioSaida;
        private System.Windows.Forms.Label lbl_HoraEntrada;
        private System.Windows.Forms.Label lbl_HorarioEntrada;
        private System.Windows.Forms.Label lbl_NSala;
        private System.Windows.Forms.Label lbl_Sala;
        private System.Windows.Forms.Label lbl_NomeProfessor;
        private System.Windows.Forms.Label lbl_Professor;
        private System.Windows.Forms.Label lbl_NomeCurso;
        private System.Windows.Forms.Label lbl_Curso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msk_IdTurma;
        private System.Windows.Forms.DataGridView dgv_Alunos;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_SalvarVinculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn fotoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDoAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planoContratadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vincularAlunoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turmaDataGridViewTextBoxColumn;
        private DB_EscolaDataSet dB_EscolaDataSet;
        private System.Windows.Forms.BindingSource inscricoesTurmasBindingSource;
        private DB_EscolaDataSetTableAdapters.InscricoesTurmasTableAdapter inscricoesTurmasTableAdapter;
    }
}