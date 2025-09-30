namespace TrabalhoGabrielOliveira
{
    partial class LoginEmpresarial
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
			this.TextSenha = new System.Windows.Forms.TextBox();
			this.BtnEntrar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.BtnCadastro = new System.Windows.Forms.Button();
			this.TextName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// TextSenha
			// 
			this.TextSenha.Location = new System.Drawing.Point(242, 167);
			this.TextSenha.Name = "TextSenha";
			this.TextSenha.Size = new System.Drawing.Size(244, 20);
			this.TextSenha.TabIndex = 19;
			this.TextSenha.Text = "Senha";
			this.TextSenha.Click += new System.EventHandler(this.TextSenha_Click);
			// 
			// BtnEntrar
			// 
			this.BtnEntrar.Location = new System.Drawing.Point(482, 193);
			this.BtnEntrar.Name = "BtnEntrar";
			this.BtnEntrar.Size = new System.Drawing.Size(75, 23);
			this.BtnEntrar.TabIndex = 18;
			this.BtnEntrar.Text = "Entrar";
			this.BtnEntrar.UseVisualStyleBackColor = true;
			this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(306, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 13);
			this.label1.TabIndex = 17;
			this.label1.Text = "Faça seu login!";
			// 
			// BtnCadastro
			// 
			this.BtnCadastro.Location = new System.Drawing.Point(26, 336);
			this.BtnCadastro.Name = "BtnCadastro";
			this.BtnCadastro.Size = new System.Drawing.Size(125, 98);
			this.BtnCadastro.TabIndex = 16;
			this.BtnCadastro.Text = "Faça seu cadastro";
			this.BtnCadastro.UseVisualStyleBackColor = true;
			this.BtnCadastro.Click += new System.EventHandler(this.BtnCadastro_Click);
			// 
			// TextName
			// 
			this.TextName.Location = new System.Drawing.Point(242, 141);
			this.TextName.Name = "TextName";
			this.TextName.Size = new System.Drawing.Size(244, 20);
			this.TextName.TabIndex = 14;
			this.TextName.Text = "Email/Nome de Usuário";
			this.TextName.Click += new System.EventHandler(this.TextName_Click);
			this.TextName.TextChanged += new System.EventHandler(this.TextName_TextChanged);
			// 
			// LoginEmpresarial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.TextSenha);
			this.Controls.Add(this.BtnEntrar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BtnCadastro);
			this.Controls.Add(this.TextName);
			this.Name = "LoginEmpresarial";
			this.Text = "LoginEmpresarial";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextSenha;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCadastro;
        private System.Windows.Forms.TextBox TextName;
    }
}