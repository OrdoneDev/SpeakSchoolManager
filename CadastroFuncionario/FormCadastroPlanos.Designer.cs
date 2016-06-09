namespace CadastroFuncionario
{
    partial class FormCadastroPlanos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroPlanos));
            this.lbl_NomeIdioma = new System.Windows.Forms.Label();
            this.lbl_DescricaoIdioma = new System.Windows.Forms.Label();
            this.lbl_NomePlano = new System.Windows.Forms.Label();
            this.lbl_NumeroAulas = new System.Windows.Forms.Label();
            this.lbl_ValorPlano = new System.Windows.Forms.Label();
            this.group_CadastroPlano = new System.Windows.Forms.GroupBox();
            this.cmb_NomePlano = new System.Windows.Forms.ComboBox();
            this.cmb_NomeIdioma = new System.Windows.Forms.ComboBox();
            this.txb_DescricaoIdioma = new System.Windows.Forms.RichTextBox();
            this.msk_NumeroAulas = new System.Windows.Forms.MaskedTextBox();
            this.msk_ValorPlano = new System.Windows.Forms.MaskedTextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_SalvarPlano = new System.Windows.Forms.Button();
            this.group_CadastroPlano.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_NomeIdioma
            // 
            resources.ApplyResources(this.lbl_NomeIdioma, "lbl_NomeIdioma");
            this.lbl_NomeIdioma.Name = "lbl_NomeIdioma";
            // 
            // lbl_DescricaoIdioma
            // 
            resources.ApplyResources(this.lbl_DescricaoIdioma, "lbl_DescricaoIdioma");
            this.lbl_DescricaoIdioma.Name = "lbl_DescricaoIdioma";
            // 
            // lbl_NomePlano
            // 
            resources.ApplyResources(this.lbl_NomePlano, "lbl_NomePlano");
            this.lbl_NomePlano.Name = "lbl_NomePlano";
            // 
            // lbl_NumeroAulas
            // 
            resources.ApplyResources(this.lbl_NumeroAulas, "lbl_NumeroAulas");
            this.lbl_NumeroAulas.Name = "lbl_NumeroAulas";
            // 
            // lbl_ValorPlano
            // 
            resources.ApplyResources(this.lbl_ValorPlano, "lbl_ValorPlano");
            this.lbl_ValorPlano.Name = "lbl_ValorPlano";
            // 
            // group_CadastroPlano
            // 
            this.group_CadastroPlano.Controls.Add(this.cmb_NomePlano);
            this.group_CadastroPlano.Controls.Add(this.cmb_NomeIdioma);
            this.group_CadastroPlano.Controls.Add(this.txb_DescricaoIdioma);
            this.group_CadastroPlano.Controls.Add(this.msk_NumeroAulas);
            this.group_CadastroPlano.Controls.Add(this.msk_ValorPlano);
            this.group_CadastroPlano.Controls.Add(this.lbl_DescricaoIdioma);
            this.group_CadastroPlano.Controls.Add(this.lbl_ValorPlano);
            this.group_CadastroPlano.Controls.Add(this.lbl_NomeIdioma);
            this.group_CadastroPlano.Controls.Add(this.lbl_NumeroAulas);
            this.group_CadastroPlano.Controls.Add(this.lbl_NomePlano);
            resources.ApplyResources(this.group_CadastroPlano, "group_CadastroPlano");
            this.group_CadastroPlano.Name = "group_CadastroPlano";
            this.group_CadastroPlano.TabStop = false;
            // 
            // cmb_NomePlano
            // 
            this.cmb_NomePlano.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_NomePlano, "cmb_NomePlano");
            this.cmb_NomePlano.Name = "cmb_NomePlano";
            // 
            // cmb_NomeIdioma
            // 
            this.cmb_NomeIdioma.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_NomeIdioma, "cmb_NomeIdioma");
            this.cmb_NomeIdioma.Name = "cmb_NomeIdioma";
            this.cmb_NomeIdioma.SelectedValueChanged += new System.EventHandler(this.cmb_NomeIdioma_SelectedValueChanged);
            this.cmb_NomeIdioma.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_NomeIdioma_PreviewKeyDown);
            // 
            // txb_DescricaoIdioma
            // 
            resources.ApplyResources(this.txb_DescricaoIdioma, "txb_DescricaoIdioma");
            this.txb_DescricaoIdioma.Name = "txb_DescricaoIdioma";
            // 
            // msk_NumeroAulas
            // 
            resources.ApplyResources(this.msk_NumeroAulas, "msk_NumeroAulas");
            this.msk_NumeroAulas.Name = "msk_NumeroAulas";
            // 
            // msk_ValorPlano
            // 
            resources.ApplyResources(this.msk_ValorPlano, "msk_ValorPlano");
            this.msk_ValorPlano.Name = "msk_ValorPlano";
            // 
            // btn_Cancelar
            // 
            resources.ApplyResources(this.btn_Cancelar, "btn_Cancelar");
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_SalvarPlano
            // 
            resources.ApplyResources(this.btn_SalvarPlano, "btn_SalvarPlano");
            this.btn_SalvarPlano.Name = "btn_SalvarPlano";
            this.btn_SalvarPlano.UseVisualStyleBackColor = true;
            this.btn_SalvarPlano.Click += new System.EventHandler(this.btn_SalvarPlano_Click);
            // 
            // FormCadastroPlanos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btn_SalvarPlano);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.group_CadastroPlano);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroPlanos";
            this.group_CadastroPlano.ResumeLayout(false);
            this.group_CadastroPlano.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_NomeIdioma;
        private System.Windows.Forms.Label lbl_DescricaoIdioma;
        private System.Windows.Forms.Label lbl_NomePlano;
        private System.Windows.Forms.Label lbl_NumeroAulas;
        private System.Windows.Forms.Label lbl_ValorPlano;
        private System.Windows.Forms.GroupBox group_CadastroPlano;
        private System.Windows.Forms.RichTextBox txb_DescricaoIdioma;
        private System.Windows.Forms.MaskedTextBox msk_NumeroAulas;
        private System.Windows.Forms.MaskedTextBox msk_ValorPlano;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_SalvarPlano;
        private System.Windows.Forms.ComboBox cmb_NomePlano;
        private System.Windows.Forms.ComboBox cmb_NomeIdioma;
    }
}