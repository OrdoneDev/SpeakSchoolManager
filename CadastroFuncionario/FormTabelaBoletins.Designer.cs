namespace CadastroFuncionario
{
    partial class FormTabelaBoletins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabelaBoletins));
            this.group_TabelaBoletins = new System.Windows.Forms.GroupBox();
            this.btn_FiltrarAluno = new System.Windows.Forms.Button();
            this.cmb_NomeAluno = new System.Windows.Forms.ComboBox();
            this.lbl_NomeAluno = new System.Windows.Forms.Label();
            this.dgv_TabelaBoletins = new System.Windows.Forms.DataGridView();
            this.idBoletimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idInscricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroFaltasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boletinsAlunoFiltroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.escola_PrincipalDataSet5 = new CadastroFuncionario.Escola_PrincipalDataSet5();
            this.boletinsAlunoFiltroTableAdapter = new CadastroFuncionario.Escola_PrincipalDataSet5TableAdapters.BoletinsAlunoFiltroTableAdapter();
            this.btn_MostrarTodos = new System.Windows.Forms.Button();
            this.group_TabelaBoletins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaBoletins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boletinsAlunoFiltroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escola_PrincipalDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // group_TabelaBoletins
            // 
            this.group_TabelaBoletins.Controls.Add(this.btn_MostrarTodos);
            this.group_TabelaBoletins.Controls.Add(this.btn_FiltrarAluno);
            this.group_TabelaBoletins.Controls.Add(this.cmb_NomeAluno);
            this.group_TabelaBoletins.Controls.Add(this.lbl_NomeAluno);
            this.group_TabelaBoletins.Controls.Add(this.dgv_TabelaBoletins);
            resources.ApplyResources(this.group_TabelaBoletins, "group_TabelaBoletins");
            this.group_TabelaBoletins.Name = "group_TabelaBoletins";
            this.group_TabelaBoletins.TabStop = false;
            // 
            // btn_FiltrarAluno
            // 
            resources.ApplyResources(this.btn_FiltrarAluno, "btn_FiltrarAluno");
            this.btn_FiltrarAluno.Name = "btn_FiltrarAluno";
            this.btn_FiltrarAluno.UseVisualStyleBackColor = true;
            this.btn_FiltrarAluno.Click += new System.EventHandler(this.btn_FiltrarAluno_Click);
            // 
            // cmb_NomeAluno
            // 
            this.cmb_NomeAluno.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_NomeAluno, "cmb_NomeAluno");
            this.cmb_NomeAluno.Name = "cmb_NomeAluno";
            this.cmb_NomeAluno.SelectedValueChanged += new System.EventHandler(this.cmb_NomeAluno_SelectedValueChanged);
            this.cmb_NomeAluno.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_NomeAluno_PreviewKeyDown);
            // 
            // lbl_NomeAluno
            // 
            resources.ApplyResources(this.lbl_NomeAluno, "lbl_NomeAluno");
            this.lbl_NomeAluno.Name = "lbl_NomeAluno";
            // 
            // dgv_TabelaBoletins
            // 
            this.dgv_TabelaBoletins.AllowUserToAddRows = false;
            this.dgv_TabelaBoletins.AutoGenerateColumns = false;
            this.dgv_TabelaBoletins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TabelaBoletins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TabelaBoletins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBoletimDataGridViewTextBoxColumn,
            this.idInscricaoDataGridViewTextBoxColumn,
            this.nota1DataGridViewTextBoxColumn,
            this.nota2DataGridViewTextBoxColumn,
            this.mediaDataGridViewTextBoxColumn,
            this.numeroFaltasDataGridViewTextBoxColumn});
            this.dgv_TabelaBoletins.DataSource = this.boletinsAlunoFiltroBindingSource;
            resources.ApplyResources(this.dgv_TabelaBoletins, "dgv_TabelaBoletins");
            this.dgv_TabelaBoletins.Name = "dgv_TabelaBoletins";
            // 
            // idBoletimDataGridViewTextBoxColumn
            // 
            this.idBoletimDataGridViewTextBoxColumn.DataPropertyName = "Id_Boletim";
            resources.ApplyResources(this.idBoletimDataGridViewTextBoxColumn, "idBoletimDataGridViewTextBoxColumn");
            this.idBoletimDataGridViewTextBoxColumn.Name = "idBoletimDataGridViewTextBoxColumn";
            this.idBoletimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idInscricaoDataGridViewTextBoxColumn
            // 
            this.idInscricaoDataGridViewTextBoxColumn.DataPropertyName = "Id_Inscricao";
            resources.ApplyResources(this.idInscricaoDataGridViewTextBoxColumn, "idInscricaoDataGridViewTextBoxColumn");
            this.idInscricaoDataGridViewTextBoxColumn.Name = "idInscricaoDataGridViewTextBoxColumn";
            // 
            // nota1DataGridViewTextBoxColumn
            // 
            this.nota1DataGridViewTextBoxColumn.DataPropertyName = "Nota1";
            resources.ApplyResources(this.nota1DataGridViewTextBoxColumn, "nota1DataGridViewTextBoxColumn");
            this.nota1DataGridViewTextBoxColumn.Name = "nota1DataGridViewTextBoxColumn";
            // 
            // nota2DataGridViewTextBoxColumn
            // 
            this.nota2DataGridViewTextBoxColumn.DataPropertyName = "Nota2";
            resources.ApplyResources(this.nota2DataGridViewTextBoxColumn, "nota2DataGridViewTextBoxColumn");
            this.nota2DataGridViewTextBoxColumn.Name = "nota2DataGridViewTextBoxColumn";
            // 
            // mediaDataGridViewTextBoxColumn
            // 
            this.mediaDataGridViewTextBoxColumn.DataPropertyName = "Media";
            resources.ApplyResources(this.mediaDataGridViewTextBoxColumn, "mediaDataGridViewTextBoxColumn");
            this.mediaDataGridViewTextBoxColumn.Name = "mediaDataGridViewTextBoxColumn";
            this.mediaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroFaltasDataGridViewTextBoxColumn
            // 
            this.numeroFaltasDataGridViewTextBoxColumn.DataPropertyName = "Numero_Faltas";
            resources.ApplyResources(this.numeroFaltasDataGridViewTextBoxColumn, "numeroFaltasDataGridViewTextBoxColumn");
            this.numeroFaltasDataGridViewTextBoxColumn.Name = "numeroFaltasDataGridViewTextBoxColumn";
            // 
            // boletinsAlunoFiltroBindingSource
            // 
            this.boletinsAlunoFiltroBindingSource.DataMember = "BoletinsAlunoFiltro";
            this.boletinsAlunoFiltroBindingSource.DataSource = this.escola_PrincipalDataSet5;
            // 
            // escola_PrincipalDataSet5
            // 
            this.escola_PrincipalDataSet5.DataSetName = "Escola_PrincipalDataSet5";
            this.escola_PrincipalDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boletinsAlunoFiltroTableAdapter
            // 
            this.boletinsAlunoFiltroTableAdapter.ClearBeforeFill = true;
            // 
            // btn_MostrarTodos
            // 
            resources.ApplyResources(this.btn_MostrarTodos, "btn_MostrarTodos");
            this.btn_MostrarTodos.Name = "btn_MostrarTodos";
            this.btn_MostrarTodos.UseVisualStyleBackColor = true;
            this.btn_MostrarTodos.Click += new System.EventHandler(this.btn_MostrarTodos_Click);
            // 
            // FormTabelaBoletins
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.group_TabelaBoletins);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormTabelaBoletins";
            this.Load += new System.EventHandler(this.FormTabelaBoletins_Load);
            this.group_TabelaBoletins.ResumeLayout(false);
            this.group_TabelaBoletins.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaBoletins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boletinsAlunoFiltroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escola_PrincipalDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_TabelaBoletins;
        private System.Windows.Forms.Button btn_FiltrarAluno;
        private System.Windows.Forms.ComboBox cmb_NomeAluno;
        private System.Windows.Forms.Label lbl_NomeAluno;
        private System.Windows.Forms.DataGridView dgv_TabelaBoletins;
        private Escola_PrincipalDataSet5 escola_PrincipalDataSet5;
        private System.Windows.Forms.BindingSource boletinsAlunoFiltroBindingSource;
        private Escola_PrincipalDataSet5TableAdapters.BoletinsAlunoFiltroTableAdapter boletinsAlunoFiltroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBoletimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInscricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroFaltasDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_MostrarTodos;
    }
}