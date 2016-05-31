namespace CadastroFuncionario
{
    partial class FormTabelaFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabelaFuncionarios));
            this.group_TabelaFuncionarios = new System.Windows.Forms.GroupBox();
            this.btn_FIltrarCargo = new System.Windows.Forms.Button();
            this.cmb_Cargo = new System.Windows.Forms.ComboBox();
            this.btn_FiltrarCPF = new System.Windows.Forms.Button();
            this.msk_CPF = new System.Windows.Forms.MaskedTextBox();
            this.btn_FiltrarNome = new System.Windows.Forms.Button();
            this.cmb_Nome = new System.Windows.Forms.ComboBox();
            this.btn_FiltrarId = new System.Windows.Forms.Button();
            this.msk_Id = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Cargo = new System.Windows.Forms.Label();
            this.lbl_CPF = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.dgv_Funcionarios = new System.Windows.Forms.DataGridView();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_SalvarAlteracoes = new System.Windows.Forms.Button();
            this.group_TabelaFuncionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Funcionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // group_TabelaFuncionarios
            // 
            this.group_TabelaFuncionarios.Controls.Add(this.btn_FIltrarCargo);
            this.group_TabelaFuncionarios.Controls.Add(this.cmb_Cargo);
            this.group_TabelaFuncionarios.Controls.Add(this.btn_FiltrarCPF);
            this.group_TabelaFuncionarios.Controls.Add(this.msk_CPF);
            this.group_TabelaFuncionarios.Controls.Add(this.btn_FiltrarNome);
            this.group_TabelaFuncionarios.Controls.Add(this.cmb_Nome);
            this.group_TabelaFuncionarios.Controls.Add(this.btn_FiltrarId);
            this.group_TabelaFuncionarios.Controls.Add(this.msk_Id);
            this.group_TabelaFuncionarios.Controls.Add(this.lbl_Cargo);
            this.group_TabelaFuncionarios.Controls.Add(this.lbl_CPF);
            this.group_TabelaFuncionarios.Controls.Add(this.lbl_Nome);
            this.group_TabelaFuncionarios.Controls.Add(this.lbl_Id);
            this.group_TabelaFuncionarios.Controls.Add(this.dgv_Funcionarios);
            resources.ApplyResources(this.group_TabelaFuncionarios, "group_TabelaFuncionarios");
            this.group_TabelaFuncionarios.Name = "group_TabelaFuncionarios";
            this.group_TabelaFuncionarios.TabStop = false;
            // 
            // btn_FIltrarCargo
            // 
            resources.ApplyResources(this.btn_FIltrarCargo, "btn_FIltrarCargo");
            this.btn_FIltrarCargo.Name = "btn_FIltrarCargo";
            this.btn_FIltrarCargo.UseVisualStyleBackColor = true;
            this.btn_FIltrarCargo.Click += new System.EventHandler(this.btn_FIltrarCargo_Click);
            // 
            // cmb_Cargo
            // 
            this.cmb_Cargo.FormattingEnabled = true;
            this.cmb_Cargo.Items.AddRange(new object[] {
            resources.GetString("cmb_Cargo.Items"),
            resources.GetString("cmb_Cargo.Items1"),
            resources.GetString("cmb_Cargo.Items2"),
            resources.GetString("cmb_Cargo.Items3")});
            resources.ApplyResources(this.cmb_Cargo, "cmb_Cargo");
            this.cmb_Cargo.Name = "cmb_Cargo";
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
            // lbl_Cargo
            // 
            resources.ApplyResources(this.lbl_Cargo, "lbl_Cargo");
            this.lbl_Cargo.Name = "lbl_Cargo";
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
            // dgv_Funcionarios
            // 
            this.dgv_Funcionarios.AllowUserToAddRows = false;
            this.dgv_Funcionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgv_Funcionarios, "dgv_Funcionarios");
            this.dgv_Funcionarios.Name = "dgv_Funcionarios";
            this.dgv_Funcionarios.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Funcionarios_CellMouseEnter);
            this.dgv_Funcionarios.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Funcionarios_CellMouseLeave);
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
            // FormTabelaFuncionarios
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_SalvarAlteracoes);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.group_TabelaFuncionarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormTabelaFuncionarios";
            this.Load += new System.EventHandler(this.FormTabelaFuncionarios_Load);
            this.group_TabelaFuncionarios.ResumeLayout(false);
            this.group_TabelaFuncionarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Funcionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_TabelaFuncionarios;
        private System.Windows.Forms.DataGridView dgv_Funcionarios;
        private System.Windows.Forms.Label lbl_Cargo;
        private System.Windows.Forms.Label lbl_CPF;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Button btn_FiltrarNome;
        private System.Windows.Forms.ComboBox cmb_Nome;
        private System.Windows.Forms.Button btn_FiltrarId;
        private System.Windows.Forms.MaskedTextBox msk_Id;
        private System.Windows.Forms.MaskedTextBox msk_CPF;
        private System.Windows.Forms.Button btn_FiltrarCPF;
        private System.Windows.Forms.Button btn_FIltrarCargo;
        private System.Windows.Forms.ComboBox cmb_Cargo;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_SalvarAlteracoes;
    }
}