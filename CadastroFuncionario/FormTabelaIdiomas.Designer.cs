namespace CadastroFuncionario
{
    partial class FormTabelaIdiomas
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
            this.group_TabelaIdiomas = new System.Windows.Forms.GroupBox();
            this.dgv_TabelaIdiomas = new System.Windows.Forms.DataGridView();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_SalvarAlteracoes = new System.Windows.Forms.Button();
            this.group_TabelaIdiomas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaIdiomas)).BeginInit();
            this.SuspendLayout();
            // 
            // group_TabelaIdiomas
            // 
            this.group_TabelaIdiomas.Controls.Add(this.dgv_TabelaIdiomas);
            this.group_TabelaIdiomas.Location = new System.Drawing.Point(13, 13);
            this.group_TabelaIdiomas.Name = "group_TabelaIdiomas";
            this.group_TabelaIdiomas.Size = new System.Drawing.Size(624, 250);
            this.group_TabelaIdiomas.TabIndex = 0;
            this.group_TabelaIdiomas.TabStop = false;
            this.group_TabelaIdiomas.Text = "Idiomas";
            // 
            // dgv_TabelaIdiomas
            // 
            this.dgv_TabelaIdiomas.AllowUserToAddRows = false;
            this.dgv_TabelaIdiomas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TabelaIdiomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TabelaIdiomas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_TabelaIdiomas.Location = new System.Drawing.Point(3, 16);
            this.dgv_TabelaIdiomas.MultiSelect = false;
            this.dgv_TabelaIdiomas.Name = "dgv_TabelaIdiomas";
            this.dgv_TabelaIdiomas.Size = new System.Drawing.Size(618, 231);
            this.dgv_TabelaIdiomas.TabIndex = 0;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(559, 269);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_SalvarAlteracoes
            // 
            this.btn_SalvarAlteracoes.Location = new System.Drawing.Point(442, 269);
            this.btn_SalvarAlteracoes.Name = "btn_SalvarAlteracoes";
            this.btn_SalvarAlteracoes.Size = new System.Drawing.Size(111, 23);
            this.btn_SalvarAlteracoes.TabIndex = 2;
            this.btn_SalvarAlteracoes.Text = "Salvar alterações";
            this.btn_SalvarAlteracoes.UseVisualStyleBackColor = true;
            this.btn_SalvarAlteracoes.Click += new System.EventHandler(this.btn_SalvarAlteracoes_Click);
            // 
            // FormTabelaIdiomas
            // 
            this.ClientSize = new System.Drawing.Size(649, 302);
            this.Controls.Add(this.btn_SalvarAlteracoes);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.group_TabelaIdiomas);
            this.Name = "FormTabelaIdiomas";
            this.Text = "Tabela de idiomas";
            this.Load += new System.EventHandler(this.FormTabelaIdiomas_Load);
            this.group_TabelaIdiomas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TabelaIdiomas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_TabelaIdiomas;
        private System.Windows.Forms.DataGridView dgv_TabelaIdiomas;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_SalvarAlteracoes;
    }
}