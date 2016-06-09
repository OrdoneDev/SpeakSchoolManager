namespace CadastroFuncionario
{
    partial class FormGerarSemestre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerarSemestre));
            this.group_Inscricoes = new System.Windows.Forms.GroupBox();
            this.dgv_Inscricoes = new System.Windows.Forms.DataGridView();
            this.btn_BuscarAluno = new System.Windows.Forms.Button();
            this.cmb_NomeAluno = new System.Windows.Forms.ComboBox();
            this.lbl_NomeAluno = new System.Windows.Forms.Label();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.group_Inscricoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inscricoes)).BeginInit();
            this.SuspendLayout();
            // 
            // group_Inscricoes
            // 
            resources.ApplyResources(this.group_Inscricoes, "group_Inscricoes");
            this.group_Inscricoes.Controls.Add(this.dgv_Inscricoes);
            this.group_Inscricoes.Controls.Add(this.btn_BuscarAluno);
            this.group_Inscricoes.Controls.Add(this.cmb_NomeAluno);
            this.group_Inscricoes.Controls.Add(this.lbl_NomeAluno);
            this.group_Inscricoes.Controls.Add(this.btn_Atualizar);
            this.group_Inscricoes.Name = "group_Inscricoes";
            this.group_Inscricoes.TabStop = false;
            // 
            // dgv_Inscricoes
            // 
            this.dgv_Inscricoes.AllowUserToAddRows = false;
            this.dgv_Inscricoes.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dgv_Inscricoes, "dgv_Inscricoes");
            this.dgv_Inscricoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Inscricoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Inscricoes.Name = "dgv_Inscricoes";
            this.dgv_Inscricoes.ReadOnly = true;
            // 
            // btn_BuscarAluno
            // 
            resources.ApplyResources(this.btn_BuscarAluno, "btn_BuscarAluno");
            this.btn_BuscarAluno.Name = "btn_BuscarAluno";
            this.btn_BuscarAluno.UseVisualStyleBackColor = true;
            this.btn_BuscarAluno.Click += new System.EventHandler(this.btn_BuscarAluno_Click);
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
            // btn_Atualizar
            // 
            resources.ApplyResources(this.btn_Atualizar, "btn_Atualizar");
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // btn_Cancelar
            // 
            resources.ApplyResources(this.btn_Cancelar, "btn_Cancelar");
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Salvar
            // 
            resources.ApplyResources(this.btn_Salvar, "btn_Salvar");
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // FormGerarSemestre
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.group_Inscricoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormGerarSemestre";
            this.Load += new System.EventHandler(this.FormGerarSemestre_Load);
            this.group_Inscricoes.ResumeLayout(false);
            this.group_Inscricoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inscricoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_Inscricoes;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_BuscarAluno;
        private System.Windows.Forms.ComboBox cmb_NomeAluno;
        private System.Windows.Forms.Label lbl_NomeAluno;
        private System.Windows.Forms.DataGridView dgv_Inscricoes;
    }
}