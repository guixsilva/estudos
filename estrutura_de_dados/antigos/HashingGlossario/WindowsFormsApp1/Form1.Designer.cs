namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLerArquivo = new System.Windows.Forms.Button();
            this.listBoxPalavras = new System.Windows.Forms.ListBox();
            this.listBoxDefinicoes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonLerArquivo
            // 
            this.buttonLerArquivo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLerArquivo.Location = new System.Drawing.Point(12, 12);
            this.buttonLerArquivo.Name = "buttonLerArquivo";
            this.buttonLerArquivo.Size = new System.Drawing.Size(141, 68);
            this.buttonLerArquivo.TabIndex = 0;
            this.buttonLerArquivo.Text = "Ler Arquivo";
            this.buttonLerArquivo.UseVisualStyleBackColor = true;
            this.buttonLerArquivo.Click += new System.EventHandler(this.buttonLerArquivo_Click);
            // 
            // listBoxPalavras
            // 
            this.listBoxPalavras.FormattingEnabled = true;
            this.listBoxPalavras.Location = new System.Drawing.Point(12, 103);
            this.listBoxPalavras.Name = "listBoxPalavras";
            this.listBoxPalavras.Size = new System.Drawing.Size(176, 212);
            this.listBoxPalavras.TabIndex = 1;
            this.listBoxPalavras.Click += new System.EventHandler(this.listBoxPalavras_Click);
            // 
            // listBoxDefinicoes
            // 
            this.listBoxDefinicoes.FormattingEnabled = true;
            this.listBoxDefinicoes.Location = new System.Drawing.Point(194, 103);
            this.listBoxDefinicoes.Name = "listBoxDefinicoes";
            this.listBoxDefinicoes.Size = new System.Drawing.Size(468, 212);
            this.listBoxDefinicoes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Palavras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Definições";
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 327);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDefinicoes);
            this.Controls.Add(this.listBoxPalavras);
            this.Controls.Add(this.buttonLerArquivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLerArquivo;
        private System.Windows.Forms.ListBox listBoxPalavras;
        private System.Windows.Forms.ListBox listBoxDefinicoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
    }
}

