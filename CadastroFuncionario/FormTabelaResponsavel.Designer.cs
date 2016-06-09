namespace CadastroFuncionario
{
    partial class FormTabelaResponsavel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabelaResponsavel));
            this.btn_FiltrarCPF = new System.Windows.Forms.Button();
            this.msk_CPF = new System.Windows.Forms.MaskedTextBox();
            this.btn_FiltrarNome = new System.Windows.Forms.Button();
            this.cmb_Nome = new System.Windows.Forms.ComboBox();
            this.btn_FiltrarId = new System.Windows.Forms.Button();
            this.msk_Id = new System.Windows.Forms.MaskedTextBox();
            this.lbl_CPF = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.group_TabelaResponsaveis = new System.Windows.Forms.GroupBox();
            this.dgv_Responsaveis = new System.Windows.Forms.DataGridView();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_SalvarAlteracoes = new System.Windows.Forms.Button();
            this.group_TabelaResponsaveis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Responsaveis)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_FiltrarCPF
            // 
            resources.ApplyResources(this.btn_FiltrarCPF, "btn_FiltrarCPF");
            this.btn_FiltrarCPF.Name = "btn_FiltrarCPF";
            this.btn_FiltrarCPF.UseVisualStyleBackColor = true;
            this.btn_FiltrarCPF.Click += new System.EventHandler(this.btn_FiltrarCPF_Click);
            // 
            // msk_CPF
            // 
            resources.ApplyResources(this.msk_CPF, "msk_CPF");
            this.msk_CPF.Name = "msk_CPF";
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
            // btn_FiltrarId
            // 
            resources.ApplyResources(this.btn_FiltrarId, "btn_FiltrarId");
            this.btn_FiltrarId.Name = "btn_FiltrarId";
            this.btn_FiltrarId.UseVisualStyleBackColor = true;
            this.btn_FiltrarId.Click += new System.EventHandler(this.btn_FiltrarId_Click);
            // 
            // msk_Id
            // 
            resources.ApplyResources(this.msk_Id, "msk_Id");
            this.msk_Id.Name = "msk_Id";
            // 
            // lbl_CPF
            // 
            resources.ApplyResources(this.lbl_CPF, "lbl_CPF");
            this.lbl_CPF.Name = "lbl_CPF";
            // 
            // lbl_Nome
            // 
            resources.ApplyResources(this.lbl_Nome, "lbl_Nome");
            this.lbl_Nome.Name = "lbl_Nome";
            // 
            // lbl_Id
            // 
            resources.ApplyResources(this.lbl_Id, "lbl_Id");
            this.lbl_Id.Name = "lbl_Id";
            // 
            // group_TabelaResponsaveis
            // 
            resources.ApplyResources(this.group_TabelaResponsaveis, "group_TabelaResponsaveis");
            this.group_TabelaResponsaveis.Controls.Add(this.btn_FiltrarCPF);
            this.group_TabelaResponsaveis.Controls.Add(this.msk_CPF);
            this.group_TabelaResponsaveis.Controls.Add(this.btn_FiltrarNome);
            this.group_TabelaResponsaveis.Controls.Add(this.cmb_Nome);
            this.group_TabelaResponsaveis.Controls.Add(this.btn_FiltrarId);
            this.group_TabelaResponsaveis.Controls.Add(this.msk_Id);
            this.group_TabelaResponsaveis.Controls.Add(this.lbl_CPF);
            this.group_TabelaResponsaveis.Controls.Add(this.lbl_Nome);
            this.group_TabelaResponsaveis.Controls.Add(this.lbl_Id);
            this.group_TabelaResponsaveis.Controls.Add(this.dgv_Responsaveis);
            this.group_TabelaResponsaveis.Name = "group_TabelaResponsaveis";
            this.group_TabelaResponsaveis.TabStop = false;
            // 
            // dgv_Responsaveis
            // 
            this.dgv_Responsaveis.AllowUserToAddRows = false;
            resources.ApplyResources(this.dgv_Responsaveis, "dgv_Responsaveis");
            this.dgv_Responsaveis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Responsaveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Responsaveis.MultiSelect = false;
            this.dgv_Responsaveis.Name = "dgv_Responsaveis";
            this.dgv_Responsaveis.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_Responsaveis_DataError);
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
            // FormTabelaResponsavel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_SalvarAlteracoes);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.group_TabelaResponsaveis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormTabelaResponsavel";
            this.Load += new System.EventHandler(this.FormTabelaResponsavel_Load);
            this.group_TabelaResponsaveis.ResumeLayout(false);
            this.group_TabelaResponsaveis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Responsaveis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_FiltrarCPF;
        private System.Windows.Forms.MaskedTextBox msk_CPF;
        private System.Windows.Forms.Button btn_FiltrarNome;
        private System.Windows.Forms.ComboBox cmb_Nome;
        private System.Windows.Forms.Button btn_FiltrarId;
        private System.Windows.Forms.MaskedTextBox msk_Id;
        private System.Windows.Forms.Label lbl_CPF;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.GroupBox group_TabelaResponsaveis;
        private System.Windows.Forms.DataGridView dgv_Responsaveis;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_SalvarAlteracoes;
    }
}