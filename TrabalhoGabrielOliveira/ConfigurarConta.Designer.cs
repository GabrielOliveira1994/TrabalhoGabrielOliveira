namespace TrabalhoGabrielOliveira
{
    partial class ConfigurarConta
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
            this.PictureIcon = new System.Windows.Forms.PictureBox();
            this.TextName2 = new System.Windows.Forms.TextBox();
            this.TextEmail2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureIcon
            // 
            this.PictureIcon.Location = new System.Drawing.Point(34, 35);
            this.PictureIcon.Name = "PictureIcon";
            this.PictureIcon.Size = new System.Drawing.Size(100, 50);
            this.PictureIcon.TabIndex = 0;
            this.PictureIcon.TabStop = false;
            // 
            // TextName2
            // 
            this.TextName2.Location = new System.Drawing.Point(203, 35);
            this.TextName2.Name = "TextName2";
            this.TextName2.Size = new System.Drawing.Size(100, 20);
            this.TextName2.TabIndex = 1;
            // 
            // TextEmail2
            // 
            this.TextEmail2.Location = new System.Drawing.Point(203, 74);
            this.TextEmail2.Name = "TextEmail2";
            this.TextEmail2.Size = new System.Drawing.Size(100, 20);
            this.TextEmail2.TabIndex = 2;
            // 
            // ConfigurarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextEmail2);
            this.Controls.Add(this.TextName2);
            this.Controls.Add(this.PictureIcon);
            this.Name = "ConfigurarConta";
            this.Text = "ConfigurarConta";
            this.Load += new System.EventHandler(this.ConfigurarConta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureIcon;
        private System.Windows.Forms.TextBox TextName2;
        private System.Windows.Forms.TextBox TextEmail2;
    }
}