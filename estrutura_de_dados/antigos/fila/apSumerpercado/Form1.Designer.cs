namespace apSumerpercado
{
  partial class FrmSupermercado
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
      this.dgvFilas = new System.Windows.Forms.DataGridView();
      this.lsbMensagens = new System.Windows.Forms.ListBox();
      this.btnSimular = new System.Windows.Forms.Button();
      this.lbValorSorteado = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lbQuantosClientesAgora = new System.Windows.Forms.Label();
      this.lbSemClientes = new System.Windows.Forms.Label();
      this.Fila1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fila2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fila3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fila4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fila5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dgvFilas)).BeginInit();
      this.SuspendLayout();
      // 
      // dgvFilas
      // 
      this.dgvFilas.AllowUserToAddRows = false;
      this.dgvFilas.AllowUserToDeleteRows = false;
      this.dgvFilas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvFilas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fila1,
            this.fila2,
            this.fila3,
            this.fila4,
            this.fila5});
      this.dgvFilas.Location = new System.Drawing.Point(3, 3);
      this.dgvFilas.Name = "dgvFilas";
      this.dgvFilas.ReadOnly = true;
      this.dgvFilas.Size = new System.Drawing.Size(351, 324);
      this.dgvFilas.TabIndex = 0;
      // 
      // lsbMensagens
      // 
      this.lsbMensagens.FormattingEnabled = true;
      this.lsbMensagens.ItemHeight = 16;
      this.lsbMensagens.Location = new System.Drawing.Point(360, 3);
      this.lsbMensagens.Name = "lsbMensagens";
      this.lsbMensagens.Size = new System.Drawing.Size(247, 324);
      this.lsbMensagens.TabIndex = 1;
      // 
      // btnSimular
      // 
      this.btnSimular.Location = new System.Drawing.Point(3, 336);
      this.btnSimular.Name = "btnSimular";
      this.btnSimular.Size = new System.Drawing.Size(75, 32);
      this.btnSimular.TabIndex = 2;
      this.btnSimular.Text = "Simular";
      this.btnSimular.UseVisualStyleBackColor = true;
      this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
      // 
      // lbValorSorteado
      // 
      this.lbValorSorteado.AutoSize = true;
      this.lbValorSorteado.Location = new System.Drawing.Point(159, 344);
      this.lbValorSorteado.Name = "lbValorSorteado";
      this.lbValorSorteado.Size = new System.Drawing.Size(26, 17);
      this.lbValorSorteado.TabIndex = 3;
      this.lbValorSorteado.Text = "-o-";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(96, 344);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(57, 17);
      this.label1.TabIndex = 4;
      this.label1.Text = "Sorteio:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(216, 344);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(159, 17);
      this.label2.TabIndex = 5;
      this.label2.Text = "Quantos clientes agora:";
      // 
      // lbQuantosClientesAgora
      // 
      this.lbQuantosClientesAgora.AutoSize = true;
      this.lbQuantosClientesAgora.Location = new System.Drawing.Point(382, 344);
      this.lbQuantosClientesAgora.Name = "lbQuantosClientesAgora";
      this.lbQuantosClientesAgora.Size = new System.Drawing.Size(16, 17);
      this.lbQuantosClientesAgora.TabIndex = 6;
      this.lbQuantosClientesAgora.Text = "0";
      // 
      // lbSemClientes
      // 
      this.lbSemClientes.AutoSize = true;
      this.lbSemClientes.Location = new System.Drawing.Point(490, 344);
      this.lbSemClientes.Name = "lbSemClientes";
      this.lbSemClientes.Size = new System.Drawing.Size(92, 17);
      this.lbSemClientes.TabIndex = 7;
      this.lbSemClientes.Text = "Sem clientes:";
      this.lbSemClientes.Click += new System.EventHandler(this.lbSemClientes_Click);
      // 
      // Fila1
      // 
      this.Fila1.HeaderText = "1";
      this.Fila1.Name = "Fila1";
      this.Fila1.ReadOnly = true;
      this.Fila1.Width = 50;
      // 
      // fila2
      // 
      this.fila2.HeaderText = "2";
      this.fila2.Name = "fila2";
      this.fila2.ReadOnly = true;
      this.fila2.Width = 50;
      // 
      // fila3
      // 
      this.fila3.HeaderText = "3";
      this.fila3.Name = "fila3";
      this.fila3.ReadOnly = true;
      this.fila3.Width = 50;
      // 
      // fila4
      // 
      this.fila4.HeaderText = "4";
      this.fila4.Name = "fila4";
      this.fila4.ReadOnly = true;
      this.fila4.Width = 50;
      // 
      // fila5
      // 
      this.fila5.HeaderText = "5";
      this.fila5.Name = "fila5";
      this.fila5.ReadOnly = true;
      this.fila5.Width = 50;
      // 
      // FrmSupermercado
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.ClientSize = new System.Drawing.Size(611, 370);
      this.Controls.Add(this.lbSemClientes);
      this.Controls.Add(this.lbQuantosClientesAgora);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lbValorSorteado);
      this.Controls.Add(this.btnSimular);
      this.Controls.Add(this.lsbMensagens);
      this.Controls.Add(this.dgvFilas);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Name = "FrmSupermercado";
      this.Text = "Simulação de Filas em Supermercado";
      this.Load += new System.EventHandler(this.FrmSupermercado_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvFilas)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvFilas;
    private System.Windows.Forms.ListBox lsbMensagens;
    private System.Windows.Forms.Button btnSimular;
    private System.Windows.Forms.Label lbValorSorteado;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lbQuantosClientesAgora;
    private System.Windows.Forms.Label lbSemClientes;
    private System.Windows.Forms.DataGridViewTextBoxColumn Fila1;
    private System.Windows.Forms.DataGridViewTextBoxColumn fila2;
    private System.Windows.Forms.DataGridViewTextBoxColumn fila3;
    private System.Windows.Forms.DataGridViewTextBoxColumn fila4;
    private System.Windows.Forms.DataGridViewTextBoxColumn fila5;
  }
}

