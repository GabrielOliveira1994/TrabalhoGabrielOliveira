namespace TrabalhoGabrielOliveira
{
    partial class ConfigurarConta2
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
			this.SalvarConfiguração = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.TextTelefone = new System.Windows.Forms.TextBox();
			this.TextEmail2 = new System.Windows.Forms.TextBox();
			this.TextName2 = new System.Windows.Forms.TextBox();
			this.PictureIcon = new System.Windows.Forms.PictureBox();
			this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
			this.TextConfirmarSenha = new System.Windows.Forms.TextBox();
			this.TextSenha = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// SalvarConfiguração
			// 
			this.SalvarConfiguração.Location = new System.Drawing.Point(627, 384);
			this.SalvarConfiguração.Name = "SalvarConfiguração";
			this.SalvarConfiguração.Size = new System.Drawing.Size(75, 23);
			this.SalvarConfiguração.TabIndex = 17;
			this.SalvarConfiguração.Text = "Salvar";
			this.SalvarConfiguração.UseVisualStyleBackColor = true;
			this.SalvarConfiguração.Click += new System.EventHandler(this.SalvarConfiguração_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(613, 194);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 13);
			this.label1.TabIndex = 16;
			this.label1.Text = "Termine seu Cadastro";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(573, 43);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(182, 307);
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			// 
			// TextTelefone
			// 
			this.TextTelefone.Location = new System.Drawing.Point(45, 278);
			this.TextTelefone.Name = "TextTelefone";
			this.TextTelefone.Size = new System.Drawing.Size(218, 20);
			this.TextTelefone.TabIndex = 12;
			this.TextTelefone.Text = "Telefone";
			this.TextTelefone.Click += new System.EventHandler(this.TextTelefone_Click);
			// 
			// TextEmail2
			// 
			this.TextEmail2.Location = new System.Drawing.Point(45, 252);
			this.TextEmail2.Name = "TextEmail2";
			this.TextEmail2.Size = new System.Drawing.Size(218, 20);
			this.TextEmail2.TabIndex = 11;
			this.TextEmail2.Text = "E-Mail";
			this.TextEmail2.Click += new System.EventHandler(this.TextEmail2_Click);
			// 
			// TextName2
			// 
			this.TextName2.Location = new System.Drawing.Point(285, 43);
			this.TextName2.Name = "TextName2";
			this.TextName2.Size = new System.Drawing.Size(218, 20);
			this.TextName2.TabIndex = 10;
			this.TextName2.Text = "Nome";
			this.TextName2.Click += new System.EventHandler(this.TextName2_Click);
			// 
			// PictureIcon
			// 
			this.PictureIcon.Location = new System.Drawing.Point(45, 43);
			this.PictureIcon.Name = "PictureIcon";
			this.PictureIcon.Size = new System.Drawing.Size(218, 124);
			this.PictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureIcon.TabIndex = 9;
			this.PictureIcon.TabStop = false;
			this.PictureIcon.Click += new System.EventHandler(this.PictureIcon_Click);
			// 
			// openFileDialog3
			// 
			this.openFileDialog3.FileName = "openFileDialog3";
			// 
			// TextConfirmarSenha
			// 
			this.TextConfirmarSenha.Location = new System.Drawing.Point(45, 217);
			this.TextConfirmarSenha.Name = "TextConfirmarSenha";
			this.TextConfirmarSenha.Size = new System.Drawing.Size(218, 20);
			this.TextConfirmarSenha.TabIndex = 19;
			this.TextConfirmarSenha.Text = "Confirmar Senha";
			this.TextConfirmarSenha.Click += new System.EventHandler(this.TextConfirmarSenha_Click);
			// 
			// TextSenha
			// 
			this.TextSenha.Location = new System.Drawing.Point(45, 191);
			this.TextSenha.Name = "TextSenha";
			this.TextSenha.Size = new System.Drawing.Size(218, 20);
			this.TextSenha.TabIndex = 18;
			this.TextSenha.Text = "Senha";
			this.TextSenha.Click += new System.EventHandler(this.TextSenha_Click);
			// 
			// ConfigurarConta2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.TextConfirmarSenha);
			this.Controls.Add(this.TextSenha);
			this.Controls.Add(this.SalvarConfiguração);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.TextTelefone);
			this.Controls.Add(this.TextEmail2);
			this.Controls.Add(this.TextName2);
			this.Controls.Add(this.PictureIcon);
			this.Name = "ConfigurarConta2";
			this.Text = "ConfigurarConta2";
			this.Load += new System.EventHandler(this.ConfigurarConta2_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureIcon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SalvarConfiguração;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TextTelefone;
        private System.Windows.Forms.TextBox TextEmail2;
        private System.Windows.Forms.TextBox TextName2;
        private System.Windows.Forms.PictureBox PictureIcon;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.TextBox TextConfirmarSenha;
        private System.Windows.Forms.TextBox TextSenha;
    }
}