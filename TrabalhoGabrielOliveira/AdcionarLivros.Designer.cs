namespace TrabalhoGabrielOliveira
{
    partial class AdcionarLivros
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
            this.TextNome = new System.Windows.Forms.TextBox();
            this.BtnAutor = new System.Windows.Forms.Button();
            this.TextSinopse = new System.Windows.Forms.TextBox();
            this.TextGênero = new System.Windows.Forms.TextBox();
            this.TextPaginas = new System.Windows.Forms.TextBox();
            this.TextAcabamento = new System.Windows.Forms.TextBox();
            this.TextPreço = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.PictureCapa = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TextAutor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCapa)).BeginInit();
            this.SuspendLayout();
            // 
            // TextNome
            // 
            this.TextNome.Location = new System.Drawing.Point(353, 53);
            this.TextNome.Name = "TextNome";
            this.TextNome.Size = new System.Drawing.Size(100, 20);
            this.TextNome.TabIndex = 0;
            this.TextNome.Text = "Nome";
            this.TextNome.Click += new System.EventHandler(this.TextNameClick);
            this.TextNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnAutor
            // 
            this.BtnAutor.Location = new System.Drawing.Point(473, 90);
            this.BtnAutor.Name = "BtnAutor";
            this.BtnAutor.Size = new System.Drawing.Size(99, 23);
            this.BtnAutor.TabIndex = 1;
            this.BtnAutor.Text = "Adicionar autor";
            this.BtnAutor.UseVisualStyleBackColor = true;
            this.BtnAutor.Click += new System.EventHandler(this.BtnAutor_Click);
            // 
            // TextSinopse
            // 
            this.TextSinopse.Location = new System.Drawing.Point(353, 136);
            this.TextSinopse.Multiline = true;
            this.TextSinopse.Name = "TextSinopse";
            this.TextSinopse.Size = new System.Drawing.Size(144, 20);
            this.TextSinopse.TabIndex = 2;
            this.TextSinopse.Text = "Sinopse";
            this.TextSinopse.Click += new System.EventHandler(this.TextSinopse_Click);
            // 
            // TextGênero
            // 
            this.TextGênero.Location = new System.Drawing.Point(353, 183);
            this.TextGênero.Name = "TextGênero";
            this.TextGênero.Size = new System.Drawing.Size(100, 20);
            this.TextGênero.TabIndex = 3;
            this.TextGênero.Text = "Gênero";
            this.TextGênero.Click += new System.EventHandler(this.TextGêneroClick);
            // 
            // TextPaginas
            // 
            this.TextPaginas.Location = new System.Drawing.Point(353, 225);
            this.TextPaginas.Name = "TextPaginas";
            this.TextPaginas.Size = new System.Drawing.Size(100, 20);
            this.TextPaginas.TabIndex = 4;
            this.TextPaginas.Text = "Páginas";
            this.TextPaginas.Click += new System.EventHandler(this.TextPáginasClick);
            // 
            // TextAcabamento
            // 
            this.TextAcabamento.Location = new System.Drawing.Point(353, 273);
            this.TextAcabamento.Name = "TextAcabamento";
            this.TextAcabamento.Size = new System.Drawing.Size(100, 20);
            this.TextAcabamento.TabIndex = 5;
            this.TextAcabamento.Text = "Acabamento";
            this.TextAcabamento.Click += new System.EventHandler(this.TextAcabamento_Click);
            // 
            // TextPreço
            // 
            this.TextPreço.Location = new System.Drawing.Point(169, 183);
            this.TextPreço.Name = "TextPreço";
            this.TextPreço.Size = new System.Drawing.Size(100, 20);
            this.TextPreço.TabIndex = 6;
            this.TextPreço.Text = "Preço";
            this.TextPreço.Click += new System.EventHandler(this.TextPreço_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(698, 399);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 7;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // PictureCapa
            // 
            this.PictureCapa.Location = new System.Drawing.Point(169, 53);
            this.PictureCapa.Name = "PictureCapa";
            this.PictureCapa.Size = new System.Drawing.Size(100, 124);
            this.PictureCapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureCapa.TabIndex = 8;
            this.PictureCapa.TabStop = false;
            this.PictureCapa.Click += new System.EventHandler(this.PictureCapa_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // TextAutor
            // 
            this.TextAutor.Location = new System.Drawing.Point(353, 90);
            this.TextAutor.Name = "TextAutor";
            this.TextAutor.Size = new System.Drawing.Size(100, 20);
            this.TextAutor.TabIndex = 9;
            this.TextAutor.Text = "Autor";
            this.TextAutor.Click += new System.EventHandler(this.TextAutor_Click);
            this.TextAutor.TextChanged += new System.EventHandler(this.TextAutor_TextChanged);
            // 
            // AdcionarLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextAutor);
            this.Controls.Add(this.PictureCapa);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.TextPreço);
            this.Controls.Add(this.TextAcabamento);
            this.Controls.Add(this.TextPaginas);
            this.Controls.Add(this.TextGênero);
            this.Controls.Add(this.TextSinopse);
            this.Controls.Add(this.BtnAutor);
            this.Controls.Add(this.TextNome);
            this.Name = "AdcionarLivros";
            this.Text = "te";
            this.Load += new System.EventHandler(this.AdcionarLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureCapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextNome;
        private System.Windows.Forms.Button BtnAutor;
        private System.Windows.Forms.TextBox TextSinopse;
        private System.Windows.Forms.TextBox TextGênero;
        private System.Windows.Forms.TextBox TextPaginas;
        private System.Windows.Forms.TextBox TextAcabamento;
        private System.Windows.Forms.TextBox TextPreço;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.PictureBox PictureCapa;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox TextAutor;
    }
}