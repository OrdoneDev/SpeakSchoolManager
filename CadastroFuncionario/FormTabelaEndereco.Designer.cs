namespace CadastroFuncionario
{
    partial class FormTabelaEndereco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabelaEndereco));
            this.group_Enderecos = new System.Windows.Forms.GroupBox();
            this.btn_FiltrarBairro = new System.Windows.Forms.Button();
            this.cmb_Bairro = new System.Windows.Forms.ComboBox();
            this.lbl_Bairro = new System.Windows.Forms.Label();
            this.btn_FiltrarCidade = new System.Windows.Forms.Button();
            this.cmb_Cidade = new System.Windows.Forms.ComboBox();
            this.lbl_Cidade = new System.Windows.Forms.Label();
            this.btn_FiltrarEstado = new System.Windows.Forms.Button();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.cmb_Estado = new System.Windows.Forms.ComboBox();
            this.btn_FiltrarId = new System.Windows.Forms.Button();
            this.lbl_IdEndereco = new System.Windows.Forms.Label();
            this.msk_IdEndereco = new System.Windows.Forms.MaskedTextBox();
            this.dgv_Enderecos = new System.Windows.Forms.DataGridView();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_SalvarAlteracoes = new System.Windows.Forms.Button();
            this.group_Enderecos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Enderecos)).BeginInit();
            this.SuspendLayout();
            // 
            // group_Enderecos
            // 
            this.group_Enderecos.Controls.Add(this.btn_FiltrarBairro);
            this.group_Enderecos.Controls.Add(this.cmb_Bairro);
            this.group_Enderecos.Controls.Add(this.lbl_Bairro);
            this.group_Enderecos.Controls.Add(this.btn_FiltrarCidade);
            this.group_Enderecos.Controls.Add(this.cmb_Cidade);
            this.group_Enderecos.Controls.Add(this.lbl_Cidade);
            this.group_Enderecos.Controls.Add(this.btn_FiltrarEstado);
            this.group_Enderecos.Controls.Add(this.lbl_Estado);
            this.group_Enderecos.Controls.Add(this.cmb_Estado);
            this.group_Enderecos.Controls.Add(this.btn_FiltrarId);
            this.group_Enderecos.Controls.Add(this.lbl_IdEndereco);
            this.group_Enderecos.Controls.Add(this.msk_IdEndereco);
            this.group_Enderecos.Controls.Add(this.dgv_Enderecos);
            resources.ApplyResources(this.group_Enderecos, "group_Enderecos");
            this.group_Enderecos.Name = "group_Enderecos";
            this.group_Enderecos.TabStop = false;
            // 
            // btn_FiltrarBairro
            // 
            resources.ApplyResources(this.btn_FiltrarBairro, "btn_FiltrarBairro");
            this.btn_FiltrarBairro.Name = "btn_FiltrarBairro";
            this.btn_FiltrarBairro.UseVisualStyleBackColor = true;
            this.btn_FiltrarBairro.Click += new System.EventHandler(this.btn_FiltrarBairro_Click);
            // 
            // cmb_Bairro
            // 
            this.cmb_Bairro.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_Bairro, "cmb_Bairro");
            this.cmb_Bairro.Name = "cmb_Bairro";
            this.cmb_Bairro.SelectedValueChanged += new System.EventHandler(this.cmb_Bairro_SelectedValueChanged);
            this.cmb_Bairro.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_Bairro_PreviewKeyDown);
            // 
            // lbl_Bairro
            // 
            resources.ApplyResources(this.lbl_Bairro, "lbl_Bairro");
            this.lbl_Bairro.Name = "lbl_Bairro";
            // 
            // btn_FiltrarCidade
            // 
            resources.ApplyResources(this.btn_FiltrarCidade, "btn_FiltrarCidade");
            this.btn_FiltrarCidade.Name = "btn_FiltrarCidade";
            this.btn_FiltrarCidade.UseVisualStyleBackColor = true;
            this.btn_FiltrarCidade.Click += new System.EventHandler(this.btn_FiltrarCidade_Click);
            // 
            // cmb_Cidade
            // 
            this.cmb_Cidade.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_Cidade, "cmb_Cidade");
            this.cmb_Cidade.Name = "cmb_Cidade";
            this.cmb_Cidade.SelectedValueChanged += new System.EventHandler(this.cmb_Cidade_SelectedValueChanged);
            this.cmb_Cidade.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_Cidade_PreviewKeyDown);
            // 
            // lbl_Cidade
            // 
            resources.ApplyResources(this.lbl_Cidade, "lbl_Cidade");
            this.lbl_Cidade.Name = "lbl_Cidade";
            // 
            // btn_FiltrarEstado
            // 
            resources.ApplyResources(this.btn_FiltrarEstado, "btn_FiltrarEstado");
            this.btn_FiltrarEstado.Name = "btn_FiltrarEstado";
            this.btn_FiltrarEstado.UseVisualStyleBackColor = true;
            this.btn_FiltrarEstado.Click += new System.EventHandler(this.btn_FiltrarEstado_Click);
            // 
            // lbl_Estado
            // 
            resources.ApplyResources(this.lbl_Estado, "lbl_Estado");
            this.lbl_Estado.Name = "lbl_Estado";
            // 
            // cmb_Estado
            // 
            this.cmb_Estado.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_Estado, "cmb_Estado");
            this.cmb_Estado.Name = "cmb_Estado";
            this.cmb_Estado.SelectedValueChanged += new System.EventHandler(this.cmb_Estado_SelectedValueChanged);
            this.cmb_Estado.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_Estado_PreviewKeyDown);
            // 
            // btn_FiltrarId
            // 
            resources.ApplyResources(this.btn_FiltrarId, "btn_FiltrarId");
            this.btn_FiltrarId.Name = "btn_FiltrarId";
            this.btn_FiltrarId.UseVisualStyleBackColor = true;
            this.btn_FiltrarId.Click += new System.EventHandler(this.btn_FiltrarId_Click);
            // 
            // lbl_IdEndereco
            // 
            resources.ApplyResources(this.lbl_IdEndereco, "lbl_IdEndereco");
            this.lbl_IdEndereco.Name = "lbl_IdEndereco";
            // 
            // msk_IdEndereco
            // 
            resources.ApplyResources(this.msk_IdEndereco, "msk_IdEndereco");
            this.msk_IdEndereco.Name = "msk_IdEndereco";
            // 
            // dgv_Enderecos
            // 
            this.dgv_Enderecos.AllowUserToAddRows = false;
            this.dgv_Enderecos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Enderecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgv_Enderecos, "dgv_Enderecos");
            this.dgv_Enderecos.MultiSelect = false;
            this.dgv_Enderecos.Name = "dgv_Enderecos";
            this.dgv_Enderecos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_Enderecos_DataError);
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
            // FormTabelaEndereco
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_SalvarAlteracoes);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.group_Enderecos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormTabelaEndereco";
            this.Load += new System.EventHandler(this.FormTabelaEndereco_Load);
            this.group_Enderecos.ResumeLayout(false);
            this.group_Enderecos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Enderecos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_Enderecos;
        private System.Windows.Forms.DataGridView dgv_Enderecos;
        private System.Windows.Forms.Button btn_FiltrarId;
        private System.Windows.Forms.Label lbl_IdEndereco;
        private System.Windows.Forms.MaskedTextBox msk_IdEndereco;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.ComboBox cmb_Estado;
        private System.Windows.Forms.Button btn_FiltrarEstado;
        private System.Windows.Forms.Button btn_FiltrarCidade;
        private System.Windows.Forms.ComboBox cmb_Cidade;
        private System.Windows.Forms.Label lbl_Cidade;
        private System.Windows.Forms.Button btn_FiltrarBairro;
        private System.Windows.Forms.ComboBox cmb_Bairro;
        private System.Windows.Forms.Label lbl_Bairro;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_SalvarAlteracoes;
    }
}