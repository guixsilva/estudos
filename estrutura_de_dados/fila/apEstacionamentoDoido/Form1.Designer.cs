namespace apEstacionamentoDoido
{
  partial class FrmEstacionamento
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
      this.lsbVagas = new System.Windows.Forms.ListBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lsbManobras = new System.Windows.Forms.ListBox();
      this.label3 = new System.Windows.Forms.Label();
      this.lsbOcorrencias = new System.Windows.Forms.ListBox();
      this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
      this.btnIniciar = new System.Windows.Forms.Button();
      this.gbxTipo = new System.Windows.Forms.GroupBox();
      this.rbLista = new System.Windows.Forms.RadioButton();
      this.rbVetor = new System.Windows.Forms.RadioButton();
      this.gbxTipo.SuspendLayout();
      this.SuspendLayout();
      // 
      // lsbVagas
      // 
      this.lsbVagas.FormattingEnabled = true;
      this.lsbVagas.ItemHeight = 17;
      this.lsbVagas.Location = new System.Drawing.Point(9, 30);
      this.lsbVagas.Margin = new System.Windows.Forms.Padding(4);
      this.lsbVagas.Name = "lsbVagas";
      this.lsbVagas.Size = new System.Drawing.Size(198, 429);
      this.lsbVagas.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 2);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(152, 17);
      this.label1.TabIndex = 1;
      this.label1.Text = "Alameda de Vagas";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(223, 8);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(80, 17);
      this.label2.TabIndex = 3;
      this.label2.Text = "Manobras";
      // 
      // lsbManobras
      // 
      this.lsbManobras.FormattingEnabled = true;
      this.lsbManobras.ItemHeight = 17;
      this.lsbManobras.Location = new System.Drawing.Point(226, 29);
      this.lsbManobras.Margin = new System.Windows.Forms.Padding(4);
      this.lsbManobras.Name = "lsbManobras";
      this.lsbManobras.Size = new System.Drawing.Size(198, 429);
      this.lsbManobras.TabIndex = 2;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(431, 9);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(107, 17);
      this.label3.TabIndex = 5;
      this.label3.Text = "Ocorrências";
      // 
      // lsbOcorrencias
      // 
      this.lsbOcorrencias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lsbOcorrencias.FormattingEnabled = true;
      this.lsbOcorrencias.ItemHeight = 17;
      this.lsbOcorrencias.Location = new System.Drawing.Point(434, 30);
      this.lsbOcorrencias.Margin = new System.Windows.Forms.Padding(4);
      this.lsbOcorrencias.Name = "lsbOcorrencias";
      this.lsbOcorrencias.Size = new System.Drawing.Size(482, 429);
      this.lsbOcorrencias.TabIndex = 4;
      // 
      // dlgAbrir
      // 
      this.dlgAbrir.DefaultExt = "*.txt";
      // 
      // btnIniciar
      // 
      this.btnIniciar.Enabled = false;
      this.btnIniciar.Location = new System.Drawing.Point(226, 466);
      this.btnIniciar.Name = "btnIniciar";
      this.btnIniciar.Size = new System.Drawing.Size(198, 27);
      this.btnIniciar.TabIndex = 6;
      this.btnIniciar.Text = "Iniciar simulação";
      this.btnIniciar.UseVisualStyleBackColor = true;
      this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
      // 
      // gbxTipo
      // 
      this.gbxTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.gbxTipo.Controls.Add(this.rbLista);
      this.gbxTipo.Controls.Add(this.rbVetor);
      this.gbxTipo.Location = new System.Drawing.Point(9, 466);
      this.gbxTipo.Name = "gbxTipo";
      this.gbxTipo.Size = new System.Drawing.Size(200, 51);
      this.gbxTipo.TabIndex = 9;
      this.gbxTipo.TabStop = false;
      this.gbxTipo.Text = "Tipo de fila";
      // 
      // rbLista
      // 
      this.rbLista.AutoSize = true;
      this.rbLista.Location = new System.Drawing.Point(106, 23);
      this.rbLista.Name = "rbLista";
      this.rbLista.Size = new System.Drawing.Size(71, 21);
      this.rbLista.TabIndex = 10;
      this.rbLista.TabStop = true;
      this.rbLista.Text = "Lista";
      this.rbLista.UseVisualStyleBackColor = true;
      this.rbLista.CheckedChanged += new System.EventHandler(this.rbLista_CheckedChanged);
      // 
      // rbVetor
      // 
      this.rbVetor.AutoSize = true;
      this.rbVetor.Location = new System.Drawing.Point(6, 23);
      this.rbVetor.Name = "rbVetor";
      this.rbVetor.Size = new System.Drawing.Size(71, 21);
      this.rbVetor.TabIndex = 9;
      this.rbVetor.TabStop = true;
      this.rbVetor.Text = "Vetor";
      this.rbVetor.UseVisualStyleBackColor = true;
      this.rbVetor.CheckedChanged += new System.EventHandler(this.rbVetor_CheckedChanged);
      // 
      // FrmEstacionamento
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(922, 525);
      this.Controls.Add(this.gbxTipo);
      this.Controls.Add(this.btnIniciar);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.lsbOcorrencias);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lsbManobras);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lsbVagas);
      this.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "FrmEstacionamento";
      this.Text = "Estacionamento do Cotuca";
      this.Load += new System.EventHandler(this.FrmEstacionamento_Load);
      this.gbxTipo.ResumeLayout(false);
      this.gbxTipo.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox lsbVagas;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ListBox lsbManobras;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ListBox lsbOcorrencias;
    private System.Windows.Forms.OpenFileDialog dlgAbrir;
    private System.Windows.Forms.Button btnIniciar;
    private System.Windows.Forms.GroupBox gbxTipo;
    private System.Windows.Forms.RadioButton rbLista;
    private System.Windows.Forms.RadioButton rbVetor;
  }
}

