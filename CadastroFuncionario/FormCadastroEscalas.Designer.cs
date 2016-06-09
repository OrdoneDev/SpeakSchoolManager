namespace CadastroFuncionario
{
    partial class FormCadastroEscalas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroEscalas));
            this.group_CadastroEscala = new System.Windows.Forms.GroupBox();
            this.msk_IdFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.cmb_CargoFuncionario = new System.Windows.Forms.ComboBox();
            this.lbl_CargoFuncionario = new System.Windows.Forms.Label();
            this.lbl_DescricaoEncargos = new System.Windows.Forms.Label();
            this.lbl_HoraSaidaEscala = new System.Windows.Forms.Label();
            this.lbl_HoraEntradaEscala = new System.Windows.Forms.Label();
            this.lbl_DataEscala = new System.Windows.Forms.Label();
            this.lbl_NomeFuncionario = new System.Windows.Forms.Label();
            this.lbl_IdFuncionario = new System.Windows.Forms.Label();
            this.txb_DescricaoEncargos = new System.Windows.Forms.RichTextBox();
            this.msk_HoraSaidaFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.msk_HoraEntradaEscala = new System.Windows.Forms.MaskedTextBox();
            this.dte_DataEscala = new System.Windows.Forms.DateTimePicker();
            this.cmb_NomeFuncionario = new System.Windows.Forms.ComboBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_SalvarEscala = new System.Windows.Forms.Button();
            this.group_CadastroEscala.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_CadastroEscala
            // 
            this.group_CadastroEscala.Controls.Add(this.msk_IdFuncionario);
            this.group_CadastroEscala.Controls.Add(this.cmb_CargoFuncionario);
            this.group_CadastroEscala.Controls.Add(this.lbl_CargoFuncionario);
            this.group_CadastroEscala.Controls.Add(this.lbl_DescricaoEncargos);
            this.group_CadastroEscala.Controls.Add(this.lbl_HoraSaidaEscala);
            this.group_CadastroEscala.Controls.Add(this.lbl_HoraEntradaEscala);
            this.group_CadastroEscala.Controls.Add(this.lbl_DataEscala);
            this.group_CadastroEscala.Controls.Add(this.lbl_NomeFuncionario);
            this.group_CadastroEscala.Controls.Add(this.lbl_IdFuncionario);
            this.group_CadastroEscala.Controls.Add(this.txb_DescricaoEncargos);
            this.group_CadastroEscala.Controls.Add(this.msk_HoraSaidaFuncionario);
            this.group_CadastroEscala.Controls.Add(this.msk_HoraEntradaEscala);
            this.group_CadastroEscala.Controls.Add(this.dte_DataEscala);
            this.group_CadastroEscala.Controls.Add(this.cmb_NomeFuncionario);
            resources.ApplyResources(this.group_CadastroEscala, "group_CadastroEscala");
            this.group_CadastroEscala.Name = "group_CadastroEscala";
            this.group_CadastroEscala.TabStop = false;
            this.group_CadastroEscala.Tag = "0";
            // 
            // msk_IdFuncionario
            // 
            resources.ApplyResources(this.msk_IdFuncionario, "msk_IdFuncionario");
            this.msk_IdFuncionario.Name = "msk_IdFuncionario";
            this.msk_IdFuncionario.Tag = "";
            this.msk_IdFuncionario.TextChanged += new System.EventHandler(this.msk_IdFuncionario_TextChanged);
            // 
            // cmb_CargoFuncionario
            // 
            this.cmb_CargoFuncionario.Items.AddRange(new object[] {
            resources.GetString("cmb_CargoFuncionario.Items"),
            resources.GetString("cmb_CargoFuncionario.Items1"),
            resources.GetString("cmb_CargoFuncionario.Items2"),
            resources.GetString("cmb_CargoFuncionario.Items3")});
            resources.ApplyResources(this.cmb_CargoFuncionario, "cmb_CargoFuncionario");
            this.cmb_CargoFuncionario.Name = "cmb_CargoFuncionario";
            this.cmb_CargoFuncionario.Tag = "";
            // 
            // lbl_CargoFuncionario
            // 
            resources.ApplyResources(this.lbl_CargoFuncionario, "lbl_CargoFuncionario");
            this.lbl_CargoFuncionario.Name = "lbl_CargoFuncionario";
            this.lbl_CargoFuncionario.Tag = "0";
            // 
            // lbl_DescricaoEncargos
            // 
            resources.ApplyResources(this.lbl_DescricaoEncargos, "lbl_DescricaoEncargos");
            this.lbl_DescricaoEncargos.Name = "lbl_DescricaoEncargos";
            this.lbl_DescricaoEncargos.Tag = "0";
            // 
            // lbl_HoraSaidaEscala
            // 
            resources.ApplyResources(this.lbl_HoraSaidaEscala, "lbl_HoraSaidaEscala");
            this.lbl_HoraSaidaEscala.Name = "lbl_HoraSaidaEscala";
            this.lbl_HoraSaidaEscala.Tag = "0";
            // 
            // lbl_HoraEntradaEscala
            // 
            resources.ApplyResources(this.lbl_HoraEntradaEscala, "lbl_HoraEntradaEscala");
            this.lbl_HoraEntradaEscala.Name = "lbl_HoraEntradaEscala";
            this.lbl_HoraEntradaEscala.Tag = "0";
            // 
            // lbl_DataEscala
            // 
            resources.ApplyResources(this.lbl_DataEscala, "lbl_DataEscala");
            this.lbl_DataEscala.Name = "lbl_DataEscala";
            this.lbl_DataEscala.Tag = "0";
            // 
            // lbl_NomeFuncionario
            // 
            resources.ApplyResources(this.lbl_NomeFuncionario, "lbl_NomeFuncionario");
            this.lbl_NomeFuncionario.Name = "lbl_NomeFuncionario";
            this.lbl_NomeFuncionario.Tag = "0";
            // 
            // lbl_IdFuncionario
            // 
            resources.ApplyResources(this.lbl_IdFuncionario, "lbl_IdFuncionario");
            this.lbl_IdFuncionario.Name = "lbl_IdFuncionario";
            this.lbl_IdFuncionario.Tag = "0";
            // 
            // txb_DescricaoEncargos
            // 
            resources.ApplyResources(this.txb_DescricaoEncargos, "txb_DescricaoEncargos");
            this.txb_DescricaoEncargos.Name = "txb_DescricaoEncargos";
            this.txb_DescricaoEncargos.Tag = "";
            // 
            // msk_HoraSaidaFuncionario
            // 
            resources.ApplyResources(this.msk_HoraSaidaFuncionario, "msk_HoraSaidaFuncionario");
            this.msk_HoraSaidaFuncionario.Name = "msk_HoraSaidaFuncionario";
            this.msk_HoraSaidaFuncionario.Tag = "";
            this.msk_HoraSaidaFuncionario.ValidatingType = typeof(System.DateTime);
            // 
            // msk_HoraEntradaEscala
            // 
            resources.ApplyResources(this.msk_HoraEntradaEscala, "msk_HoraEntradaEscala");
            this.msk_HoraEntradaEscala.Name = "msk_HoraEntradaEscala";
            this.msk_HoraEntradaEscala.Tag = "";
            this.msk_HoraEntradaEscala.ValidatingType = typeof(System.DateTime);
            // 
            // dte_DataEscala
            // 
            this.dte_DataEscala.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dte_DataEscala, "dte_DataEscala");
            this.dte_DataEscala.Name = "dte_DataEscala";
            this.dte_DataEscala.Tag = "";
            // 
            // cmb_NomeFuncionario
            // 
            this.cmb_NomeFuncionario.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_NomeFuncionario, "cmb_NomeFuncionario");
            this.cmb_NomeFuncionario.Name = "cmb_NomeFuncionario";
            this.cmb_NomeFuncionario.Tag = "";
            this.cmb_NomeFuncionario.SelectedValueChanged += new System.EventHandler(this.cmb_NomeFuncionario_SelectedValueChanged);
            this.cmb_NomeFuncionario.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_NomeFuncionario_PreviewKeyDown);
            // 
            // btn_Cancelar
            // 
            resources.ApplyResources(this.btn_Cancelar, "btn_Cancelar");
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Tag = "0";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_SalvarEscala
            // 
            resources.ApplyResources(this.btn_SalvarEscala, "btn_SalvarEscala");
            this.btn_SalvarEscala.Name = "btn_SalvarEscala";
            this.btn_SalvarEscala.Tag = "0";
            this.btn_SalvarEscala.UseVisualStyleBackColor = true;
            this.btn_SalvarEscala.Click += new System.EventHandler(this.btn_SalvarEscala_Click);
            // 
            // FormCadastroEscalas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_SalvarEscala);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.group_CadastroEscala);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroEscalas";
            this.group_CadastroEscala.ResumeLayout(false);
            this.group_CadastroEscala.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_CadastroEscala;
        private System.Windows.Forms.Label lbl_DescricaoEncargos;
        private System.Windows.Forms.Label lbl_HoraSaidaEscala;
        private System.Windows.Forms.Label lbl_HoraEntradaEscala;
        private System.Windows.Forms.Label lbl_DataEscala;
        private System.Windows.Forms.Label lbl_NomeFuncionario;
        private System.Windows.Forms.Label lbl_IdFuncionario;
        private System.Windows.Forms.RichTextBox txb_DescricaoEncargos;
        private System.Windows.Forms.MaskedTextBox msk_HoraSaidaFuncionario;
        private System.Windows.Forms.MaskedTextBox msk_HoraEntradaEscala;
        private System.Windows.Forms.DateTimePicker dte_DataEscala;
        private System.Windows.Forms.ComboBox cmb_NomeFuncionario;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_SalvarEscala;
        private System.Windows.Forms.ComboBox cmb_CargoFuncionario;
        private System.Windows.Forms.Label lbl_CargoFuncionario;
        private System.Windows.Forms.MaskedTextBox msk_IdFuncionario;
    }
}