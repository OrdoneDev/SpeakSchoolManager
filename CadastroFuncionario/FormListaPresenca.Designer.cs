namespace CadastroFuncionario
{
    partial class FormListaPresenca
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
            this.group_ListaPresenca = new System.Windows.Forms.GroupBox();
            this.dgv_ListaPresenca = new System.Windows.Forms.DataGridView();
            this.msk_IdTurma = new System.Windows.Forms.MaskedTextBox();
            this.lbl_IdTurma = new System.Windows.Forms.Label();
            this.btn_ConsultarLista = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_SalvarLista = new System.Windows.Forms.Button();
            this.lbl_Sala = new System.Windows.Forms.Label();
            this.lbl_Professor = new System.Windows.Forms.Label();
            this.group_ListaPresenca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaPresenca)).BeginInit();
            this.SuspendLayout();
            // 
            // group_ListaPresenca
            // 
            this.group_ListaPresenca.Controls.Add(this.lbl_Professor);
            this.group_ListaPresenca.Controls.Add(this.lbl_Sala);
            this.group_ListaPresenca.Controls.Add(this.btn_ConsultarLista);
            this.group_ListaPresenca.Controls.Add(this.lbl_IdTurma);
            this.group_ListaPresenca.Controls.Add(this.msk_IdTurma);
            this.group_ListaPresenca.Controls.Add(this.dgv_ListaPresenca);
            this.group_ListaPresenca.Location = new System.Drawing.Point(13, 13);
            this.group_ListaPresenca.Name = "group_ListaPresenca";
            this.group_ListaPresenca.Size = new System.Drawing.Size(877, 365);
            this.group_ListaPresenca.TabIndex = 0;
            this.group_ListaPresenca.TabStop = false;
            this.group_ListaPresenca.Text = "Lista de chamada";
            // 
            // dgv_ListaPresenca
            // 
            this.dgv_ListaPresenca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ListaPresenca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaPresenca.Location = new System.Drawing.Point(7, 49);
            this.dgv_ListaPresenca.Name = "dgv_ListaPresenca";
            this.dgv_ListaPresenca.Size = new System.Drawing.Size(864, 305);
            this.dgv_ListaPresenca.TabIndex = 0;
            this.dgv_ListaPresenca.Tag = "0";
            // 
            // msk_IdTurma
            // 
            this.msk_IdTurma.Location = new System.Drawing.Point(57, 24);
            this.msk_IdTurma.Mask = "0000";
            this.msk_IdTurma.Name = "msk_IdTurma";
            this.msk_IdTurma.Size = new System.Drawing.Size(32, 20);
            this.msk_IdTurma.TabIndex = 1;
            this.msk_IdTurma.TextChanged += new System.EventHandler(this.msk_IdTurma_TextChanged);
            // 
            // lbl_IdTurma
            // 
            this.lbl_IdTurma.AutoSize = true;
            this.lbl_IdTurma.Location = new System.Drawing.Point(7, 27);
            this.lbl_IdTurma.Name = "lbl_IdTurma";
            this.lbl_IdTurma.Size = new System.Drawing.Size(48, 13);
            this.lbl_IdTurma.TabIndex = 2;
            this.lbl_IdTurma.Text = "Id turma:";
            // 
            // btn_ConsultarLista
            // 
            this.btn_ConsultarLista.Location = new System.Drawing.Point(425, 21);
            this.btn_ConsultarLista.Name = "btn_ConsultarLista";
            this.btn_ConsultarLista.Size = new System.Drawing.Size(75, 23);
            this.btn_ConsultarLista.TabIndex = 3;
            this.btn_ConsultarLista.Tag = "0";
            this.btn_ConsultarLista.Text = "Consultar";
            this.btn_ConsultarLista.UseVisualStyleBackColor = true;
            this.btn_ConsultarLista.Click += new System.EventHandler(this.btn_ConsultarLista_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(815, 384);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_SalvarLista
            // 
            this.btn_SalvarLista.Location = new System.Drawing.Point(727, 384);
            this.btn_SalvarLista.Name = "btn_SalvarLista";
            this.btn_SalvarLista.Size = new System.Drawing.Size(82, 23);
            this.btn_SalvarLista.TabIndex = 2;
            this.btn_SalvarLista.Text = "Salvar lista";
            this.btn_SalvarLista.UseVisualStyleBackColor = true;
            // 
            // lbl_Sala
            // 
            this.lbl_Sala.AutoSize = true;
            this.lbl_Sala.Location = new System.Drawing.Point(112, 27);
            this.lbl_Sala.Name = "lbl_Sala";
            this.lbl_Sala.Size = new System.Drawing.Size(0, 13);
            this.lbl_Sala.TabIndex = 4;
            this.lbl_Sala.Tag = "0";
            // 
            // lbl_Professor
            // 
            this.lbl_Professor.AutoSize = true;
            this.lbl_Professor.Location = new System.Drawing.Point(183, 27);
            this.lbl_Professor.Name = "lbl_Professor";
            this.lbl_Professor.Size = new System.Drawing.Size(0, 13);
            this.lbl_Professor.TabIndex = 5;
            this.lbl_Professor.Tag = "0";
            // 
            // FormListaPresenca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 415);
            this.Controls.Add(this.btn_SalvarLista);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.group_ListaPresenca);
            this.Name = "FormListaPresenca";
            this.Text = "Lista de chamada";
            this.group_ListaPresenca.ResumeLayout(false);
            this.group_ListaPresenca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaPresenca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_ListaPresenca;
        private System.Windows.Forms.Label lbl_Professor;
        private System.Windows.Forms.Label lbl_Sala;
        private System.Windows.Forms.Button btn_ConsultarLista;
        private System.Windows.Forms.Label lbl_IdTurma;
        private System.Windows.Forms.MaskedTextBox msk_IdTurma;
        private System.Windows.Forms.DataGridView dgv_ListaPresenca;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_SalvarLista;
    }
}