namespace CadastroFuncionario
{
    partial class FormTabelaFinanceiros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabelaFinanceiros));
            this.group_TabelaFinanceiro = new System.Windows.Forms.GroupBox();
            this.btn_FiltrarNome = new System.Windows.Forms.Button();
            this.cmb_Nome = new System.Windows.Forms.ComboBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.dgv_TabelaFinanceiros = new System.Windows.Forms.DataGridView();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_SalvarAlteracoes = new System.Windows.Forms.Button();
            this.group_TabelaFinanceiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaFinanceiros)).BeginInit();
            this.SuspendLayout();
            // 
            // group_TabelaFinanceiro
            // 
            this.group_TabelaFinanceiro.Controls.Add(this.btn_FiltrarNome);
            this.group_TabelaFinanceiro.Controls.Add(this.cmb_Nome);
            this.group_TabelaFinanceiro.Controls.Add(this.lbl_Nome);
            this.group_TabelaFinanceiro.Controls.Add(this.dgv_TabelaFinanceiros);
            resources.ApplyResources(this.group_TabelaFinanceiro, "group_TabelaFinanceiro");
            this.group_TabelaFinanceiro.Name = "group_TabelaFinanceiro";
            this.group_TabelaFinanceiro.TabStop = false;
            // 
            // btn_FiltrarNome
            // 
            resources.ApplyResources(this.btn_FiltrarNome, "btn_FiltrarNome");
            this.btn_FiltrarNome.Name = "btn_FiltrarNome";
            this.btn_FiltrarNome.UseVisualStyleBackColor = true;
            this.btn_FiltrarNome.Click += new System.EventHandler(this.btn_FiltrarNome_Click);
            // 
            // cmb_Nome
            // 
            this.cmb_Nome.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_Nome, "cmb_Nome");
            this.cmb_Nome.Name = "cmb_Nome";
            this.cmb_Nome.SelectedValueChanged += new System.EventHandler(this.cmb_Nome_SelectedValueChanged);
            this.cmb_Nome.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_Nome_PreviewKeyDown);
            // 
            // lbl_Nome
            // 
            resources.ApplyResources(this.lbl_Nome, "lbl_Nome");
            this.lbl_Nome.Name = "lbl_Nome";
            // 
            // dgv_TabelaFinanceiros
            // 
            this.dgv_TabelaFinanceiros.AllowUserToAddRows = false;
            this.dgv_TabelaFinanceiros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgv_TabelaFinanceiros, "dgv_TabelaFinanceiros");
            this.dgv_TabelaFinanceiros.MultiSelect = false;
            this.dgv_TabelaFinanceiros.Name = "dgv_TabelaFinanceiros";
            this.dgv_TabelaFinanceiros.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_TabelaFinanceiros_DataError);
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
            // FormTabelaFinanceiros
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_SalvarAlteracoes);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.group_TabelaFinanceiro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormTabelaFinanceiros";
            this.Load += new System.EventHandler(this.FormTabelaFinanceiros_Load);
            this.group_TabelaFinanceiro.ResumeLayout(false);
            this.group_TabelaFinanceiro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaFinanceiros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_TabelaFinanceiro;
        private System.Windows.Forms.DataGridView dgv_TabelaFinanceiros;
        private System.Windows.Forms.Button btn_FiltrarNome;
        private System.Windows.Forms.ComboBox cmb_Nome;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_SalvarAlteracoes;
    }
}