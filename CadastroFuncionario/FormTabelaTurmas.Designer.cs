namespace CadastroFuncionario
{
    partial class FormTabelaTurmas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabelaTurmas));
            this.group_TabelaTurmas = new System.Windows.Forms.GroupBox();
            this.btn_FiltrarPlano = new System.Windows.Forms.Button();
            this.cmb_NomePlano = new System.Windows.Forms.ComboBox();
            this.lbl_NomePlano = new System.Windows.Forms.Label();
            this.btn_FiltrarFuncionario = new System.Windows.Forms.Button();
            this.cmb_NomeFuncionario = new System.Windows.Forms.ComboBox();
            this.lbl_NomeFuncionario = new System.Windows.Forms.Label();
            this.dgv_TabelaTurmas = new System.Windows.Forms.DataGridView();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_SalvarAlteracoes = new System.Windows.Forms.Button();
            this.group_TabelaTurmas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaTurmas)).BeginInit();
            this.SuspendLayout();
            // 
            // group_TabelaTurmas
            // 
            this.group_TabelaTurmas.Controls.Add(this.btn_FiltrarPlano);
            this.group_TabelaTurmas.Controls.Add(this.cmb_NomePlano);
            this.group_TabelaTurmas.Controls.Add(this.lbl_NomePlano);
            this.group_TabelaTurmas.Controls.Add(this.btn_FiltrarFuncionario);
            this.group_TabelaTurmas.Controls.Add(this.cmb_NomeFuncionario);
            this.group_TabelaTurmas.Controls.Add(this.lbl_NomeFuncionario);
            this.group_TabelaTurmas.Controls.Add(this.dgv_TabelaTurmas);
            resources.ApplyResources(this.group_TabelaTurmas, "group_TabelaTurmas");
            this.group_TabelaTurmas.Name = "group_TabelaTurmas";
            this.group_TabelaTurmas.TabStop = false;
            // 
            // btn_FiltrarPlano
            // 
            resources.ApplyResources(this.btn_FiltrarPlano, "btn_FiltrarPlano");
            this.btn_FiltrarPlano.Name = "btn_FiltrarPlano";
            this.btn_FiltrarPlano.UseVisualStyleBackColor = true;
            this.btn_FiltrarPlano.Click += new System.EventHandler(this.btn_FiltrarPlano_Click);
            // 
            // cmb_NomePlano
            // 
            this.cmb_NomePlano.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_NomePlano, "cmb_NomePlano");
            this.cmb_NomePlano.Name = "cmb_NomePlano";
            this.cmb_NomePlano.SelectedValueChanged += new System.EventHandler(this.cmb_NomePlano_SelectedValueChanged);
            this.cmb_NomePlano.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_NomePlano_PreviewKeyDown);
            // 
            // lbl_NomePlano
            // 
            resources.ApplyResources(this.lbl_NomePlano, "lbl_NomePlano");
            this.lbl_NomePlano.Name = "lbl_NomePlano";
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
            // dgv_TabelaTurmas
            // 
            this.dgv_TabelaTurmas.AllowUserToAddRows = false;
            this.dgv_TabelaTurmas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TabelaTurmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgv_TabelaTurmas, "dgv_TabelaTurmas");
            this.dgv_TabelaTurmas.Name = "dgv_TabelaTurmas";
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
            // FormTabelaTurmas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_SalvarAlteracoes);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.group_TabelaTurmas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormTabelaTurmas";
            this.Load += new System.EventHandler(this.FormTabelaTurmas_Load);
            this.group_TabelaTurmas.ResumeLayout(false);
            this.group_TabelaTurmas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaTurmas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_TabelaTurmas;
        private System.Windows.Forms.Button btn_FiltrarPlano;
        private System.Windows.Forms.ComboBox cmb_NomePlano;
        private System.Windows.Forms.Label lbl_NomePlano;
        private System.Windows.Forms.Button btn_FiltrarFuncionario;
        private System.Windows.Forms.ComboBox cmb_NomeFuncionario;
        private System.Windows.Forms.Label lbl_NomeFuncionario;
        private System.Windows.Forms.DataGridView dgv_TabelaTurmas;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_SalvarAlteracoes;
    }
}