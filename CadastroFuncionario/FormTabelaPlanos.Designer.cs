namespace CadastroFuncionario
{
    partial class FormTabelaPlanos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabelaPlanos));
            this.group_TabelaPlanos = new System.Windows.Forms.GroupBox();
            this.btn_FiltrarIdioma = new System.Windows.Forms.Button();
            this.cmb_Idioma = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_TabelaPlanos = new System.Windows.Forms.DataGridView();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_SalvarAlteracoes = new System.Windows.Forms.Button();
            this.group_TabelaPlanos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaPlanos)).BeginInit();
            this.SuspendLayout();
            // 
            // group_TabelaPlanos
            // 
            this.group_TabelaPlanos.Controls.Add(this.btn_FiltrarIdioma);
            this.group_TabelaPlanos.Controls.Add(this.cmb_Idioma);
            this.group_TabelaPlanos.Controls.Add(this.label1);
            this.group_TabelaPlanos.Controls.Add(this.dgv_TabelaPlanos);
            resources.ApplyResources(this.group_TabelaPlanos, "group_TabelaPlanos");
            this.group_TabelaPlanos.Name = "group_TabelaPlanos";
            this.group_TabelaPlanos.TabStop = false;
            // 
            // btn_FiltrarIdioma
            // 
            resources.ApplyResources(this.btn_FiltrarIdioma, "btn_FiltrarIdioma");
            this.btn_FiltrarIdioma.Name = "btn_FiltrarIdioma";
            this.btn_FiltrarIdioma.UseVisualStyleBackColor = true;
            this.btn_FiltrarIdioma.Click += new System.EventHandler(this.btn_FiltrarIdioma_Click);
            // 
            // cmb_Idioma
            // 
            this.cmb_Idioma.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_Idioma, "cmb_Idioma");
            this.cmb_Idioma.Name = "cmb_Idioma";
            this.cmb_Idioma.SelectedValueChanged += new System.EventHandler(this.cmb_Idioma_SelectedValueChanged);
            this.cmb_Idioma.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_Idioma_PreviewKeyDown);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dgv_TabelaPlanos
            // 
            this.dgv_TabelaPlanos.AllowUserToAddRows = false;
            this.dgv_TabelaPlanos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TabelaPlanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgv_TabelaPlanos, "dgv_TabelaPlanos");
            this.dgv_TabelaPlanos.MultiSelect = false;
            this.dgv_TabelaPlanos.Name = "dgv_TabelaPlanos";
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
            // FormTabelaPlanos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_SalvarAlteracoes);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.group_TabelaPlanos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormTabelaPlanos";
            this.Load += new System.EventHandler(this.FormTabelaPlanos_Load);
            this.group_TabelaPlanos.ResumeLayout(false);
            this.group_TabelaPlanos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaPlanos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_TabelaPlanos;
        private System.Windows.Forms.Button btn_FiltrarIdioma;
        private System.Windows.Forms.ComboBox cmb_Idioma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_TabelaPlanos;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_SalvarAlteracoes;
    }
}