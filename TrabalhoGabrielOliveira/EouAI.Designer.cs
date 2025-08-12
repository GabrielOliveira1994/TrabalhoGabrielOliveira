namespace TrabalhoGabrielOliveira
{
    partial class EouAI
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
            this.BtnEditora = new System.Windows.Forms.Button();
            this.BtnIndependente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnEditora
            // 
            this.BtnEditora.Location = new System.Drawing.Point(275, 68);
            this.BtnEditora.Name = "BtnEditora";
            this.BtnEditora.Size = new System.Drawing.Size(177, 68);
            this.BtnEditora.TabIndex = 0;
            this.BtnEditora.Text = "Editora";
            this.BtnEditora.UseVisualStyleBackColor = true;
            this.BtnEditora.Click += new System.EventHandler(this.BtnEditora_Click);
            // 
            // BtnIndependente
            // 
            this.BtnIndependente.Location = new System.Drawing.Point(275, 201);
            this.BtnIndependente.Name = "BtnIndependente";
            this.BtnIndependente.Size = new System.Drawing.Size(172, 59);
            this.BtnIndependente.TabIndex = 1;
            this.BtnIndependente.Text = "Autor Independente";
            this.BtnIndependente.UseVisualStyleBackColor = true;
            // 
            // EouAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnIndependente);
            this.Controls.Add(this.BtnEditora);
            this.Name = "EouAI";
            this.Text = "EouAI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnEditora;
        private System.Windows.Forms.Button BtnIndependente;
    }
}