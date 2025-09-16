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
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SalvarConfiguração = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureIcon
            // 
            this.PictureIcon.Location = new System.Drawing.Point(34, 35);
            this.PictureIcon.Name = "PictureIcon";
            this.PictureIcon.Size = new System.Drawing.Size(218, 124);
            this.PictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureIcon.TabIndex = 0;
            this.PictureIcon.TabStop = false;
            this.PictureIcon.Click += new System.EventHandler(this.PictureIcon_Click);
            // 
            // TextName2
            // 
            this.TextName2.Location = new System.Drawing.Point(274, 35);
            this.TextName2.Name = "TextName2";
            this.TextName2.Size = new System.Drawing.Size(218, 20);
            this.TextName2.TabIndex = 1;
            this.TextName2.TextChanged += new System.EventHandler(this.TextName2_TextChanged);
            // 
            // TextEmail2
            // 
            this.TextEmail2.Location = new System.Drawing.Point(34, 186);
            this.TextEmail2.Name = "TextEmail2";
            this.TextEmail2.Size = new System.Drawing.Size(218, 20);
            this.TextEmail2.TabIndex = 2;
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 238);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Telefone";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(34, 212);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "CPF (Opcional)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 112);
            this.button1.TabIndex = 5;
            this.button1.Text = "Configurar Endereço";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(562, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 307);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Termine seu Cadastro";
            // 
            // SalvarConfiguração
            // 
            this.SalvarConfiguração.Location = new System.Drawing.Point(616, 376);
            this.SalvarConfiguração.Name = "SalvarConfiguração";
            this.SalvarConfiguração.Size = new System.Drawing.Size(75, 23);
            this.SalvarConfiguração.TabIndex = 8;
            this.SalvarConfiguração.Text = "Salvar";
            this.SalvarConfiguração.UseVisualStyleBackColor = true;
            this.SalvarConfiguração.Click += new System.EventHandler(this.SalvarConfiguração_Click);
            // 
            // ConfigurarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SalvarConfiguração);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TextEmail2);
            this.Controls.Add(this.TextName2);
            this.Controls.Add(this.PictureIcon);
            this.Name = "ConfigurarConta";
            this.Text = "ConfigurarConta";
            this.Load += new System.EventHandler(this.ConfigurarConta_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.PictureIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureIcon;
        private System.Windows.Forms.TextBox TextName2;
        private System.Windows.Forms.TextBox TextEmail2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SalvarConfiguração;
    }
}