namespace apNaufragio_1
{
  partial class FrmTitanic
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
      this.lsbSalvos = new System.Windows.Forms.ListBox();
      this.lsbNaoSalvos = new System.Windows.Forms.ListBox();
      this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.rbLista = new System.Windows.Forms.RadioButton();
      this.rbVetor = new System.Windows.Forms.RadioButton();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // lsbSalvos
      // 
      this.lsbSalvos.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lsbSalvos.FormattingEnabled = true;
      this.lsbSalvos.ItemHeight = 17;
      this.lsbSalvos.Location = new System.Drawing.Point(13, 81);
      this.lsbSalvos.Name = "lsbSalvos";
      this.lsbSalvos.Size = new System.Drawing.Size(759, 191);
      this.lsbSalvos.TabIndex = 0;
      this.lsbSalvos.DoubleClick += new System.EventHandler(this.lsbSalvos_DoubleClick);
      // 
      // lsbNaoSalvos
      // 
      this.lsbNaoSalvos.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lsbNaoSalvos.FormattingEnabled = true;
      this.lsbNaoSalvos.ItemHeight = 17;
      this.lsbNaoSalvos.Location = new System.Drawing.Point(12, 283);
      this.lsbNaoSalvos.Name = "lsbNaoSalvos";
      this.lsbNaoSalvos.Size = new System.Drawing.Size(759, 259);
      this.lsbNaoSalvos.TabIndex = 1;
      // 
      // dlgAbrir
      // 
      this.dlgAbrir.DefaultExt = "*.txt";
      this.dlgAbrir.Title = "Selecione o arquivo com os dados dos passageiros";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.rbLista);
      this.groupBox1.Controls.Add(this.rbVetor);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(200, 55);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Tipo de fila";
      // 
      // rbLista
      // 
      this.rbLista.AutoSize = true;
      this.rbLista.Location = new System.Drawing.Point(105, 24);
      this.rbLista.Name = "rbLista";
      this.rbLista.Size = new System.Drawing.Size(85, 22);
      this.rbLista.TabIndex = 1;
      this.rbLista.Text = "Por Lista";
      this.rbLista.UseVisualStyleBackColor = true;
      // 
      // rbVetor
      // 
      this.rbVetor.AutoSize = true;
      this.rbVetor.Checked = true;
      this.rbVetor.Location = new System.Drawing.Point(7, 24);
      this.rbVetor.Name = "rbVetor";
      this.rbVetor.Size = new System.Drawing.Size(87, 22);
      this.rbVetor.TabIndex = 0;
      this.rbVetor.TabStop = true;
      this.rbVetor.Text = "Por vetor";
      this.rbVetor.UseVisualStyleBackColor = true;
      // 
      // FrmTitanic
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.ClientSize = new System.Drawing.Size(784, 554);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.lsbNaoSalvos);
      this.Controls.Add(this.lsbSalvos);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Name = "FrmTitanic";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Resgatem o Titanic!";
      this.Load += new System.EventHandler(this.FrmTitanic_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListBox lsbSalvos;
    private System.Windows.Forms.ListBox lsbNaoSalvos;
    private System.Windows.Forms.OpenFileDialog dlgAbrir;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton rbLista;
    private System.Windows.Forms.RadioButton rbVetor;
  }
}

