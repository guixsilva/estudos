namespace apRefCruz
{
  partial class FrmRefCruzada
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
      this.lsbSaida = new System.Windows.Forms.ListBox();
      this.btnProcessar = new System.Windows.Forms.Button();
      this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
      this.SuspendLayout();
      // 
      // lsbSaida
      // 
      this.lsbSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lsbSaida.FormattingEnabled = true;
      this.lsbSaida.Location = new System.Drawing.Point(12, 46);
      this.lsbSaida.Name = "lsbSaida";
      this.lsbSaida.Size = new System.Drawing.Size(541, 277);
      this.lsbSaida.TabIndex = 0;
      // 
      // btnProcessar
      // 
      this.btnProcessar.Location = new System.Drawing.Point(12, 10);
      this.btnProcessar.Name = "btnProcessar";
      this.btnProcessar.Size = new System.Drawing.Size(115, 30);
      this.btnProcessar.TabIndex = 1;
      this.btnProcessar.Text = "Processar";
      this.btnProcessar.UseVisualStyleBackColor = true;
      this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
      // 
      // dlgAbrir
      // 
      this.dlgAbrir.DefaultExt = "*.txt";
      this.dlgAbrir.Title = "Selecione o arquivo com o texto a referenciar";
      // 
      // FrmRefCruzada
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(565, 323);
      this.Controls.Add(this.btnProcessar);
      this.Controls.Add(this.lsbSaida);
      this.Name = "FrmRefCruzada";
      this.Text = "Relatório de Referência Cruzada";
      this.Load += new System.EventHandler(this.FrmRefCruzada_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListBox lsbSaida;
    private System.Windows.Forms.Button btnProcessar;
    private System.Windows.Forms.OpenFileDialog dlgAbrir;
  }
}

