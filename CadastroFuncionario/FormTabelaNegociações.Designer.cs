namespace CadastroFuncionario
{
    partial class FormTabelaNegociações
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabelaNegociações));
            this.group_TabelaNegociacoes = new System.Windows.Forms.GroupBox();
            this.cmb_Plano = new System.Windows.Forms.ComboBox();
            this.lbl_Plano = new System.Windows.Forms.Label();
            this.btn_FiltrarPlano = new System.Windows.Forms.Button();
            this.btn_FiltrarAluno = new System.Windows.Forms.Button();
            this.cmb_NomeAluno = new System.Windows.Forms.ComboBox();
            this.lbl_NomeAluno = new System.Windows.Forms.Label();
            this.dgv_TabelaNegociacoes = new System.Windows.Forms.DataGridView();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_SalvarAlteracoes = new System.Windows.Forms.Button();
            this.group_TabelaNegociacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaNegociacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // group_TabelaNegociacoes
            // 
            this.group_TabelaNegociacoes.Controls.Add(this.cmb_Plano);
            this.group_TabelaNegociacoes.Controls.Add(this.lbl_Plano);
            this.group_TabelaNegociacoes.Controls.Add(this.btn_FiltrarPlano);
            this.group_TabelaNegociacoes.Controls.Add(this.btn_FiltrarAluno);
            this.group_TabelaNegociacoes.Controls.Add(this.cmb_NomeAluno);
            this.group_TabelaNegociacoes.Controls.Add(this.lbl_NomeAluno);
            this.group_TabelaNegociacoes.Controls.Add(this.dgv_TabelaNegociacoes);
            resources.ApplyResources(this.group_TabelaNegociacoes, "group_TabelaNegociacoes");
            this.group_TabelaNegociacoes.Name = "group_TabelaNegociacoes";
            this.group_TabelaNegociacoes.TabStop = false;
            // 
            // cmb_Plano
            // 
            this.cmb_Plano.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_Plano, "cmb_Plano");
            this.cmb_Plano.Name = "cmb_Plano";
            this.cmb_Plano.SelectedValueChanged += new System.EventHandler(this.cmb_Plano_SelectedValueChanged);
            this.cmb_Plano.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_Plano_PreviewKeyDown);
            // 
            // lbl_Plano
            // 
            resources.ApplyResources(this.lbl_Plano, "lbl_Plano");
            this.lbl_Plano.Name = "lbl_Plano";
            // 
            // btn_FiltrarPlano
            // 
            resources.ApplyResources(this.btn_FiltrarPlano, "btn_FiltrarPlano");
            this.btn_FiltrarPlano.Name = "btn_FiltrarPlano";
            this.btn_FiltrarPlano.UseVisualStyleBackColor = true;
            this.btn_FiltrarPlano.Click += new System.EventHandler(this.btn_FiltrarPlano_Click);
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
            // dgv_TabelaNegociacoes
            // 
            this.dgv_TabelaNegociacoes.AllowUserToAddRows = false;
            this.dgv_TabelaNegociacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TabelaNegociacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgv_TabelaNegociacoes, "dgv_TabelaNegociacoes");
            this.dgv_TabelaNegociacoes.Name = "dgv_TabelaNegociacoes";
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
            // FormTabelaNegociações
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_SalvarAlteracoes);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.group_TabelaNegociacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormTabelaNegociações";
            this.Load += new System.EventHandler(this.FormTabelaNegociações_Load);
            this.group_TabelaNegociacoes.ResumeLayout(false);
            this.group_TabelaNegociacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaNegociacoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_TabelaNegociacoes;
        private System.Windows.Forms.ComboBox cmb_Plano;
        private System.Windows.Forms.Label lbl_Plano;
        private System.Windows.Forms.Button btn_FiltrarPlano;
        private System.Windows.Forms.Button btn_FiltrarAluno;
        private System.Windows.Forms.ComboBox cmb_NomeAluno;
        private System.Windows.Forms.Label lbl_NomeAluno;
        private System.Windows.Forms.DataGridView dgv_TabelaNegociacoes;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_SalvarAlteracoes;
    }
}