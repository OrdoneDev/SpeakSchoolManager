namespace CadastroFuncionario
{
    partial class FormTabelaMensalidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabelaMensalidades));
            this.group_TabelaMensalidades = new System.Windows.Forms.GroupBox();
            this.btn_FiltrarFuncionario = new System.Windows.Forms.Button();
            this.cmb_NomeFuncionario = new System.Windows.Forms.ComboBox();
            this.lbl_NomeFuncionario = new System.Windows.Forms.Label();
            this.btn_FiltrarAluno = new System.Windows.Forms.Button();
            this.cmb_NomeAluno = new System.Windows.Forms.ComboBox();
            this.lbl_NomeAluno = new System.Windows.Forms.Label();
            this.dgv_TabelaMensalidades = new System.Windows.Forms.DataGridView();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_SalvarAlteracoes = new System.Windows.Forms.Button();
            this.group_TabelaMensalidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaMensalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // group_TabelaMensalidades
            // 
            this.group_TabelaMensalidades.Controls.Add(this.btn_FiltrarFuncionario);
            this.group_TabelaMensalidades.Controls.Add(this.cmb_NomeFuncionario);
            this.group_TabelaMensalidades.Controls.Add(this.lbl_NomeFuncionario);
            this.group_TabelaMensalidades.Controls.Add(this.btn_FiltrarAluno);
            this.group_TabelaMensalidades.Controls.Add(this.cmb_NomeAluno);
            this.group_TabelaMensalidades.Controls.Add(this.lbl_NomeAluno);
            this.group_TabelaMensalidades.Controls.Add(this.dgv_TabelaMensalidades);
            resources.ApplyResources(this.group_TabelaMensalidades, "group_TabelaMensalidades");
            this.group_TabelaMensalidades.Name = "group_TabelaMensalidades";
            this.group_TabelaMensalidades.TabStop = false;
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
            // dgv_TabelaMensalidades
            // 
            this.dgv_TabelaMensalidades.AllowUserToAddRows = false;
            this.dgv_TabelaMensalidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TabelaMensalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgv_TabelaMensalidades, "dgv_TabelaMensalidades");
            this.dgv_TabelaMensalidades.MultiSelect = false;
            this.dgv_TabelaMensalidades.Name = "dgv_TabelaMensalidades";
            // 
            // btn_Cancelar
            // 
            resources.ApplyResources(this.btn_Cancelar, "btn_Cancelar");
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_SalvarAlteracoes
            // 
            resources.ApplyResources(this.btn_SalvarAlteracoes, "btn_SalvarAlteracoes");
            this.btn_SalvarAlteracoes.Name = "btn_SalvarAlteracoes";
            this.btn_SalvarAlteracoes.UseVisualStyleBackColor = true;
            this.btn_SalvarAlteracoes.Click += new System.EventHandler(this.btn_SalvarAlteracoes_Click);
            // 
            // FormTabelaMensalidades
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_SalvarAlteracoes);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.group_TabelaMensalidades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormTabelaMensalidades";
            this.Load += new System.EventHandler(this.FormTabelaMensalidades_Load);
            this.group_TabelaMensalidades.ResumeLayout(false);
            this.group_TabelaMensalidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaMensalidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_TabelaMensalidades;
        private System.Windows.Forms.Button btn_FiltrarFuncionario;
        private System.Windows.Forms.ComboBox cmb_NomeFuncionario;
        private System.Windows.Forms.Label lbl_NomeFuncionario;
        private System.Windows.Forms.Button btn_FiltrarAluno;
        private System.Windows.Forms.ComboBox cmb_NomeAluno;
        private System.Windows.Forms.Label lbl_NomeAluno;
        private System.Windows.Forms.DataGridView dgv_TabelaMensalidades;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_SalvarAlteracoes;
    }
}