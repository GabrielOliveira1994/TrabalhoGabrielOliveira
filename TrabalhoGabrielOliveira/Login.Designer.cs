namespace TrabalhoGabrielOliveira
{
    partial class Login
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
            this.TextName = new System.Windows.Forms.TextBox();
            this.TextEmail = new System.Windows.Forms.TextBox();
            this.BtnCE = new System.Windows.Forms.Button();
            this.BtnLogin2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.TextSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(251, 99);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(244, 20);
            this.TextName.TabIndex = 0;
            this.TextName.Text = "Digite seu Nome";
            this.TextName.Click += new System.EventHandler(this.TextName1_Click);
            this.TextName.TextChanged += new System.EventHandler(this.TextName_TextChanged);
            // 
            // TextEmail
            // 
            this.TextEmail.Location = new System.Drawing.Point(251, 125);
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.Size = new System.Drawing.Size(244, 20);
            this.TextEmail.TabIndex = 1;
            this.TextEmail.Text = "E-Mail";
            this.TextEmail.Click += new System.EventHandler(this.TextEmail2_Click);
            this.TextEmail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BtnCE
            // 
            this.BtnCE.Location = new System.Drawing.Point(37, 288);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(127, 98);
            this.BtnCE.TabIndex = 2;
            this.BtnCE.Text = "Conta Empresarial";
            this.BtnCE.UseVisualStyleBackColor = true;
            this.BtnCE.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // BtnLogin2
            // 
            this.BtnLogin2.Location = new System.Drawing.Point(193, 288);
            this.BtnLogin2.Name = "BtnLogin2";
            this.BtnLogin2.Size = new System.Drawing.Size(125, 98);
            this.BtnLogin2.TabIndex = 3;
            this.BtnLogin2.Text = "Fazer Login";
            this.BtnLogin2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Faça seu cadastro!";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(502, 189);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 5;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // TextSenha
            // 
            this.TextSenha.Location = new System.Drawing.Point(251, 151);
            this.TextSenha.Name = "TextSenha";
            this.TextSenha.Size = new System.Drawing.Size(244, 20);
            this.TextSenha.TabIndex = 6;
            this.TextSenha.Text = "Senha";
            this.TextSenha.Click += new System.EventHandler(this.TextSenha3_Click);
            this.TextSenha.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextSenha);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLogin2);
            this.Controls.Add(this.BtnCE);
            this.Controls.Add(this.TextEmail);
            this.Controls.Add(this.TextName);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.TextBox TextEmail;
        private System.Windows.Forms.Button BtnCE;
        private System.Windows.Forms.Button BtnLogin2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.TextBox TextSenha;
    }
}