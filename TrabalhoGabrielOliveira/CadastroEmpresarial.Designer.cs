namespace TrabalhoGabrielOliveira
{
    partial class CadastroEmpresarial
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
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PictureIcon = new System.Windows.Forms.PictureBox();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(528, 359);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 3;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(545, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(690, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Faça seu cadastro!";
            // 
            // PictureIcon
            // 
            this.PictureIcon.Location = new System.Drawing.Point(24, 12);
            this.PictureIcon.Name = "PictureIcon";
            this.PictureIcon.Size = new System.Drawing.Size(218, 124);
            this.PictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureIcon.TabIndex = 5;
            this.PictureIcon.TabStop = false;
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.FileName = "openFileDialog4";
            // 
            // CadastroEmpresarial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PictureIcon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.textBox1);
            this.Name = "CadastroEmpresarial";
            this.Text = "CadastroEmpresarial";
            ((System.ComponentModel.ISupportInitialize)(this.PictureIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PictureIcon;
        private System.Windows.Forms.OpenFileDialog openFileDialog4;
    }
}