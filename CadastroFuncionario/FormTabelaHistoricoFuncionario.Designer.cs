namespace CadastroFuncionario
{
    partial class FormTabelaHistoricoFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabelaHistoricoFuncionario));
            this.btn_SalvarAlteracoes = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.group_TabelaHistoricoFuncionario = new System.Windows.Forms.GroupBox();
            this.btn_FiltrarFuncionario = new System.Windows.Forms.Button();
            this.cmb_NomeFuncionario = new System.Windows.Forms.ComboBox();
            this.lbl_NomeFuncionario = new System.Windows.Forms.Label();
            this.dgv_TabelaHistoricoFuncionario = new System.Windows.Forms.DataGridView();
            this.group_TabelaHistoricoFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaHistoricoFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SalvarAlteracoes
            // 
            resources.ApplyResources(this.btn_SalvarAlteracoes, "btn_SalvarAlteracoes");
            this.btn_SalvarAlteracoes.Name = "btn_SalvarAlteracoes";
            this.btn_SalvarAlteracoes.UseVisualStyleBackColor = true;
            this.btn_SalvarAlteracoes.Click += new System.EventHandler(this.btn_SalvarAlteracoes_Click);
            // 
            // btn_Cancelar
            // 
            resources.ApplyResources(this.btn_Cancelar, "btn_Cancelar");
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // group_TabelaHistoricoFuncionario
            // 
            this.group_TabelaHistoricoFuncionario.Controls.Add(this.btn_FiltrarFuncionario);
            this.group_TabelaHistoricoFuncionario.Controls.Add(this.cmb_NomeFuncionario);
            this.group_TabelaHistoricoFuncionario.Controls.Add(this.lbl_NomeFuncionario);
            this.group_TabelaHistoricoFuncionario.Controls.Add(this.dgv_TabelaHistoricoFuncionario);
            resources.ApplyResources(this.group_TabelaHistoricoFuncionario, "group_TabelaHistoricoFuncionario");
            this.group_TabelaHistoricoFuncionario.Name = "group_TabelaHistoricoFuncionario";
            this.group_TabelaHistoricoFuncionario.TabStop = false;
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
            // dgv_TabelaHistoricoFuncionario
            // 
            this.dgv_TabelaHistoricoFuncionario.AllowUserToAddRows = false;
            this.dgv_TabelaHistoricoFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TabelaHistoricoFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgv_TabelaHistoricoFuncionario, "dgv_TabelaHistoricoFuncionario");
            this.dgv_TabelaHistoricoFuncionario.MultiSelect = false;
            this.dgv_TabelaHistoricoFuncionario.Name = "dgv_TabelaHistoricoFuncionario";
            this.dgv_TabelaHistoricoFuncionario.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_TabelaHistoricoFuncionario_DataError);
            // 
            // FormTabelaHistoricoFuncionario
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_SalvarAlteracoes);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.group_TabelaHistoricoFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormTabelaHistoricoFuncionario";
            this.Load += new System.EventHandler(this.FormTabelaHistoricoFuncionario_Load);
            this.group_TabelaHistoricoFuncionario.ResumeLayout(false);
            this.group_TabelaHistoricoFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaHistoricoFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SalvarAlteracoes;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.GroupBox group_TabelaHistoricoFuncionario;
        private System.Windows.Forms.Button btn_FiltrarFuncionario;
        private System.Windows.Forms.ComboBox cmb_NomeFuncionario;
        private System.Windows.Forms.Label lbl_NomeFuncionario;
        private System.Windows.Forms.DataGridView dgv_TabelaHistoricoFuncionario;
    }
}