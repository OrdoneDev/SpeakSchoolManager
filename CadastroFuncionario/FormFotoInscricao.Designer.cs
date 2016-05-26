namespace CadastroFuncionario
{
    partial class FormFotoInscricao
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
            this.pic_Foto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Foto
            // 
            this.pic_Foto.Location = new System.Drawing.Point(6, 6);
            this.pic_Foto.Name = "pic_Foto";
            this.pic_Foto.Size = new System.Drawing.Size(131, 162);
            this.pic_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Foto.TabIndex = 0;
            this.pic_Foto.TabStop = false;
            // 
            // FormFotoInscricao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(143, 175);
            this.Controls.Add(this.pic_Foto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFotoInscricao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormFotoInscricao";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Foto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Foto;
    }
}