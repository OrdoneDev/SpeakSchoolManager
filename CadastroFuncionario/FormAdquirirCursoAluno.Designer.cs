namespace CadastroFuncionario
{
    partial class FormAdquirirCursoAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdquirirCursoAluno));
            this.group_ArquisicaoCurso = new System.Windows.Forms.GroupBox();
            this.lbl_IdPlano = new System.Windows.Forms.Label();
            this.msk_IdPlano = new System.Windows.Forms.MaskedTextBox();
            this.lbl_NomePlano = new System.Windows.Forms.Label();
            this.cmb_NomePlano = new System.Windows.Forms.ComboBox();
            this.lbl_IdAluno = new System.Windows.Forms.Label();
            this.msk_IdAluno = new System.Windows.Forms.MaskedTextBox();
            this.lbl_NomeAluno = new System.Windows.Forms.Label();
            this.cmb_NomeAluno = new System.Windows.Forms.ComboBox();
            this.lbl_Parcelas = new System.Windows.Forms.Label();
            this.cmb_Parcelas = new System.Windows.Forms.ComboBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_ConfirmarCompra = new System.Windows.Forms.Button();
            this.group_ArquisicaoCurso.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_ArquisicaoCurso
            // 
            resources.ApplyResources(this.group_ArquisicaoCurso, "group_ArquisicaoCurso");
            this.group_ArquisicaoCurso.Controls.Add(this.lbl_IdPlano);
            this.group_ArquisicaoCurso.Controls.Add(this.msk_IdPlano);
            this.group_ArquisicaoCurso.Controls.Add(this.lbl_NomePlano);
            this.group_ArquisicaoCurso.Controls.Add(this.cmb_NomePlano);
            this.group_ArquisicaoCurso.Controls.Add(this.lbl_IdAluno);
            this.group_ArquisicaoCurso.Controls.Add(this.msk_IdAluno);
            this.group_ArquisicaoCurso.Controls.Add(this.lbl_NomeAluno);
            this.group_ArquisicaoCurso.Controls.Add(this.cmb_NomeAluno);
            this.group_ArquisicaoCurso.Controls.Add(this.lbl_Parcelas);
            this.group_ArquisicaoCurso.Controls.Add(this.cmb_Parcelas);
            this.group_ArquisicaoCurso.Name = "group_ArquisicaoCurso";
            this.group_ArquisicaoCurso.TabStop = false;
            // 
            // lbl_IdPlano
            // 
            resources.ApplyResources(this.lbl_IdPlano, "lbl_IdPlano");
            this.lbl_IdPlano.Name = "lbl_IdPlano";
            // 
            // msk_IdPlano
            // 
            resources.ApplyResources(this.msk_IdPlano, "msk_IdPlano");
            this.msk_IdPlano.Name = "msk_IdPlano";
            this.msk_IdPlano.TextChanged += new System.EventHandler(this.msk_IdPlano_TextChanged);
            // 
            // lbl_NomePlano
            // 
            resources.ApplyResources(this.lbl_NomePlano, "lbl_NomePlano");
            this.lbl_NomePlano.Name = "lbl_NomePlano";
            // 
            // cmb_NomePlano
            // 
            this.cmb_NomePlano.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_NomePlano, "cmb_NomePlano");
            this.cmb_NomePlano.Name = "cmb_NomePlano";
            this.cmb_NomePlano.SelectedValueChanged += new System.EventHandler(this.cmb_NomePlano_SelectedValueChanged);
            this.cmb_NomePlano.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_NomePlano_PreviewKeyDown);
            // 
            // lbl_IdAluno
            // 
            resources.ApplyResources(this.lbl_IdAluno, "lbl_IdAluno");
            this.lbl_IdAluno.Name = "lbl_IdAluno";
            // 
            // msk_IdAluno
            // 
            resources.ApplyResources(this.msk_IdAluno, "msk_IdAluno");
            this.msk_IdAluno.Name = "msk_IdAluno";
            this.msk_IdAluno.TextChanged += new System.EventHandler(this.msk_IdAluno_TextChanged);
            // 
            // lbl_NomeAluno
            // 
            resources.ApplyResources(this.lbl_NomeAluno, "lbl_NomeAluno");
            this.lbl_NomeAluno.Name = "lbl_NomeAluno";
            // 
            // cmb_NomeAluno
            // 
            this.cmb_NomeAluno.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_NomeAluno, "cmb_NomeAluno");
            this.cmb_NomeAluno.Name = "cmb_NomeAluno";
            this.cmb_NomeAluno.SelectedValueChanged += new System.EventHandler(this.cmb_NomeAluno_SelectedValueChanged);
            this.cmb_NomeAluno.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_NomeAluno_PreviewKeyDown);
            // 
            // lbl_Parcelas
            // 
            resources.ApplyResources(this.lbl_Parcelas, "lbl_Parcelas");
            this.lbl_Parcelas.Name = "lbl_Parcelas";
            // 
            // cmb_Parcelas
            // 
            this.cmb_Parcelas.FormattingEnabled = true;
            this.cmb_Parcelas.Items.AddRange(new object[] {
            resources.GetString("cmb_Parcelas.Items"),
            resources.GetString("cmb_Parcelas.Items1"),
            resources.GetString("cmb_Parcelas.Items2"),
            resources.GetString("cmb_Parcelas.Items3"),
            resources.GetString("cmb_Parcelas.Items4"),
            resources.GetString("cmb_Parcelas.Items5"),
            resources.GetString("cmb_Parcelas.Items6"),
            resources.GetString("cmb_Parcelas.Items7"),
            resources.GetString("cmb_Parcelas.Items8"),
            resources.GetString("cmb_Parcelas.Items9"),
            resources.GetString("cmb_Parcelas.Items10"),
            resources.GetString("cmb_Parcelas.Items11")});
            resources.ApplyResources(this.cmb_Parcelas, "cmb_Parcelas");
            this.cmb_Parcelas.Name = "cmb_Parcelas";
            // 
            // btn_Cancelar
            // 
            resources.ApplyResources(this.btn_Cancelar, "btn_Cancelar");
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_ConfirmarCompra
            // 
            resources.ApplyResources(this.btn_ConfirmarCompra, "btn_ConfirmarCompra");
            this.btn_ConfirmarCompra.Name = "btn_ConfirmarCompra";
            this.btn_ConfirmarCompra.UseVisualStyleBackColor = true;
            this.btn_ConfirmarCompra.Click += new System.EventHandler(this.btn_ConfirmarCompra_Click);
            // 
            // FormAdquirirCursoAluno
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btn_ConfirmarCompra);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.group_ArquisicaoCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdquirirCursoAluno";
            this.group_ArquisicaoCurso.ResumeLayout(false);
            this.group_ArquisicaoCurso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_ArquisicaoCurso;
        private System.Windows.Forms.Label lbl_Parcelas;
        private System.Windows.Forms.ComboBox cmb_Parcelas;
        private System.Windows.Forms.Label lbl_NomeAluno;
        private System.Windows.Forms.Label lbl_IdAluno;
        private System.Windows.Forms.Label lbl_NomePlano;
        private System.Windows.Forms.Label lbl_IdPlano;
        private System.Windows.Forms.ComboBox cmb_NomeAluno;
        private System.Windows.Forms.MaskedTextBox msk_IdAluno;
        private System.Windows.Forms.ComboBox cmb_NomePlano;
        private System.Windows.Forms.MaskedTextBox msk_IdPlano;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_ConfirmarCompra;
    }
}