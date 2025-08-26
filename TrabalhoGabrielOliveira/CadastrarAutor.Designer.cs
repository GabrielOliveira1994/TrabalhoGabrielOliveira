namespace TrabalhoGabrielOliveira
{
    partial class CadastrarAutor
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
            this.TextAutor2 = new System.Windows.Forms.TextBox();
            this.TextBiografia = new System.Windows.Forms.TextBox();
            this.BtnSalvar2 = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.PictureFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // TextAutor2
            // 
            this.TextAutor2.Location = new System.Drawing.Point(28, 31);
            this.TextAutor2.Name = "TextAutor2";
            this.TextAutor2.Size = new System.Drawing.Size(340, 20);
            this.TextAutor2.TabIndex = 0;
            this.TextAutor2.Text = "Nome do Autor";
            this.TextAutor2.Click += new System.EventHandler(this.TextAutor2_Click);
            // 
            // TextBiografia
            // 
            this.TextBiografia.Location = new System.Drawing.Point(28, 74);
            this.TextBiografia.Multiline = true;
            this.TextBiografia.Name = "TextBiografia";
            this.TextBiografia.Size = new System.Drawing.Size(340, 215);
            this.TextBiografia.TabIndex = 1;
            this.TextBiografia.Text = "Breve Biografia do Autor";
            this.TextBiografia.Click += new System.EventHandler(this.TextBiografia_Click);
            // 
            // BtnSalvar2
            // 
            this.BtnSalvar2.Location = new System.Drawing.Point(700, 415);
            this.BtnSalvar2.Name = "BtnSalvar2";
            this.BtnSalvar2.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar2.TabIndex = 2;
            this.BtnSalvar2.Text = "Salvar";
            this.BtnSalvar2.UseVisualStyleBackColor = true;
            this.BtnSalvar2.Click += new System.EventHandler(this.BtnSalvar2_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            // 
            // PictureFoto
            // 
            this.PictureFoto.Location = new System.Drawing.Point(455, 52);
            this.PictureFoto.Name = "PictureFoto";
            this.PictureFoto.Size = new System.Drawing.Size(248, 237);
            this.PictureFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureFoto.TabIndex = 3;
            this.PictureFoto.TabStop = false;
            this.PictureFoto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CadastrarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PictureFoto);
            this.Controls.Add(this.BtnSalvar2);
            this.Controls.Add(this.TextBiografia);
            this.Controls.Add(this.TextAutor2);
            this.Name = "CadastrarAutor";
            this.Text = "CadastrarAutor";
            ((System.ComponentModel.ISupportInitialize)(this.PictureFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextAutor2;
        private System.Windows.Forms.TextBox TextBiografia;
        private System.Windows.Forms.Button BtnSalvar2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.PictureBox PictureFoto;
    }
}