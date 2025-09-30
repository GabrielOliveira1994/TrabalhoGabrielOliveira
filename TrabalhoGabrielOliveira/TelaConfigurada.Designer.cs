namespace TrabalhoGabrielOliveira
{
    partial class TelaConfigurada
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.LabelNome = new System.Windows.Forms.Label();
			this.LabelEmail = new System.Windows.Forms.Label();
			this.LabelTelefone = new System.Windows.Forms.Label();
			this.pictureBoxPerfil = new System.Windows.Forms.PictureBox();
			this.BtnTelaInicial = new System.Windows.Forms.Button();
			this.BtnCarrinho = new System.Windows.Forms.Button();
			this.BtnAvaliados = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerfil)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(29, 304);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(218, 112);
			this.button1.TabIndex = 15;
			this.button1.Text = "Configurar Endereço";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(253, 304);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(218, 112);
			this.button2.TabIndex = 16;
			this.button2.Text = "Configurar Cartão";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// LabelNome
			// 
			this.LabelNome.AutoSize = true;
			this.LabelNome.Location = new System.Drawing.Point(26, 150);
			this.LabelNome.Name = "LabelNome";
			this.LabelNome.Size = new System.Drawing.Size(35, 13);
			this.LabelNome.TabIndex = 17;
			this.LabelNome.Text = "Nome";
			// 
			// LabelEmail
			// 
			this.LabelEmail.AutoSize = true;
			this.LabelEmail.Location = new System.Drawing.Point(26, 182);
			this.LabelEmail.Name = "LabelEmail";
			this.LabelEmail.Size = new System.Drawing.Size(36, 13);
			this.LabelEmail.TabIndex = 18;
			this.LabelEmail.Text = "E-Mail";
			// 
			// LabelTelefone
			// 
			this.LabelTelefone.AutoSize = true;
			this.LabelTelefone.Location = new System.Drawing.Point(26, 212);
			this.LabelTelefone.Name = "LabelTelefone";
			this.LabelTelefone.Size = new System.Drawing.Size(49, 13);
			this.LabelTelefone.TabIndex = 19;
			this.LabelTelefone.Text = "Telefone";
			// 
			// pictureBoxPerfil
			// 
			this.pictureBoxPerfil.Location = new System.Drawing.Point(29, 31);
			this.pictureBoxPerfil.Name = "pictureBoxPerfil";
			this.pictureBoxPerfil.Size = new System.Drawing.Size(173, 103);
			this.pictureBoxPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxPerfil.TabIndex = 20;
			this.pictureBoxPerfil.TabStop = false;
			// 
			// BtnTelaInicial
			// 
			this.BtnTelaInicial.Location = new System.Drawing.Point(713, 12);
			this.BtnTelaInicial.Name = "BtnTelaInicial";
			this.BtnTelaInicial.Size = new System.Drawing.Size(75, 23);
			this.BtnTelaInicial.TabIndex = 21;
			this.BtnTelaInicial.Text = "Tela Incial";
			this.BtnTelaInicial.UseVisualStyleBackColor = true;
			this.BtnTelaInicial.Click += new System.EventHandler(this.BtnTelaInicial_Click);
			// 
			// BtnCarrinho
			// 
			this.BtnCarrinho.Location = new System.Drawing.Point(713, 59);
			this.BtnCarrinho.Name = "BtnCarrinho";
			this.BtnCarrinho.Size = new System.Drawing.Size(75, 23);
			this.BtnCarrinho.TabIndex = 22;
			this.BtnCarrinho.Text = "Carrinho";
			this.BtnCarrinho.UseVisualStyleBackColor = true;
			// 
			// BtnAvaliados
			// 
			this.BtnAvaliados.Location = new System.Drawing.Point(713, 89);
			this.BtnAvaliados.Name = "BtnAvaliados";
			this.BtnAvaliados.Size = new System.Drawing.Size(75, 23);
			this.BtnAvaliados.TabIndex = 23;
			this.BtnAvaliados.Text = "Avaliados";
			this.BtnAvaliados.UseVisualStyleBackColor = true;
			// 
			// TelaConfigurada
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.BtnAvaliados);
			this.Controls.Add(this.BtnCarrinho);
			this.Controls.Add(this.BtnTelaInicial);
			this.Controls.Add(this.pictureBoxPerfil);
			this.Controls.Add(this.LabelTelefone);
			this.Controls.Add(this.LabelEmail);
			this.Controls.Add(this.LabelNome);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "TelaConfigurada";
			this.Text = "TelaConfigurada";
			this.Load += new System.EventHandler(this.TelaConfigurada_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerfil)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LabelNome;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelTelefone;
        private System.Windows.Forms.PictureBox pictureBoxPerfil;
        private System.Windows.Forms.Button BtnTelaInicial;
        private System.Windows.Forms.Button BtnCarrinho;
        private System.Windows.Forms.Button BtnAvaliados;
    }
}