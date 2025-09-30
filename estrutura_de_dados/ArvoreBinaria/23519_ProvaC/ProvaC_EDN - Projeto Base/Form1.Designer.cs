namespace ProvaC_ED
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
            this.txtNovoDado = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnNosInternos = new System.Windows.Forms.Button();
            this.btnCaminho = new System.Windows.Forms.Button();
            this.btnBalanceada = new System.Windows.Forms.Button();
            this.pbArvore = new System.Windows.Forms.PictureBox();
            this.txtDadoAnterior = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDireito = new System.Windows.Forms.RadioButton();
            this.rbEsquerdo = new System.Windows.Forms.RadioButton();
            this.btnSomarDados = new System.Windows.Forms.Button();
            this.txtDadoABuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbArvore)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNovoDado
            // 
            this.txtNovoDado.Location = new System.Drawing.Point(109, 49);
            this.txtNovoDado.Name = "txtNovoDado";
            this.txtNovoDado.Size = new System.Drawing.Size(200, 20);
            this.txtNovoDado.TabIndex = 0;
            this.txtNovoDado.Text = "txtNovoDado";
            // 
            // txtResultado
            // 
            this.txtResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtResultado.Location = new System.Drawing.Point(30, 200);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(428, 20);
            this.txtResultado.TabIndex = 1;
            this.txtResultado.Text = "txtResultado";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(358, 86);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(100, 30);
            this.btnInserir.TabIndex = 2;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnNosInternos
            // 
            this.btnNosInternos.Location = new System.Drawing.Point(138, 158);
            this.btnNosInternos.Name = "btnNosInternos";
            this.btnNosInternos.Size = new System.Drawing.Size(100, 30);
            this.btnNosInternos.TabIndex = 5;
            this.btnNosInternos.Text = "Nós Internos";
            this.btnNosInternos.UseVisualStyleBackColor = true;
            this.btnNosInternos.Click += new System.EventHandler(this.btnNosInternos_Click);
            // 
            // btnCaminho
            // 
            this.btnCaminho.Location = new System.Drawing.Point(358, 122);
            this.btnCaminho.Name = "btnCaminho";
            this.btnCaminho.Size = new System.Drawing.Size(100, 30);
            this.btnCaminho.TabIndex = 6;
            this.btnCaminho.Text = "Caminho até";
            this.btnCaminho.UseVisualStyleBackColor = true;
            this.btnCaminho.Click += new System.EventHandler(this.btnCaminho_Click);
            // 
            // btnBalanceada
            // 
            this.btnBalanceada.Location = new System.Drawing.Point(30, 158);
            this.btnBalanceada.Name = "btnBalanceada";
            this.btnBalanceada.Size = new System.Drawing.Size(100, 30);
            this.btnBalanceada.TabIndex = 7;
            this.btnBalanceada.Text = "Balanceada?";
            this.btnBalanceada.UseVisualStyleBackColor = true;
            this.btnBalanceada.Click += new System.EventHandler(this.btnBalanceada_Click);
            // 
            // pbArvore
            // 
            this.pbArvore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbArvore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbArvore.Location = new System.Drawing.Point(475, 12);
            this.pbArvore.Name = "pbArvore";
            this.pbArvore.Size = new System.Drawing.Size(598, 418);
            this.pbArvore.TabIndex = 9;
            this.pbArvore.TabStop = false;
            this.pbArvore.Paint += new System.Windows.Forms.PaintEventHandler(this.pbArvore_Paint);
            // 
            // txtDadoAnterior
            // 
            this.txtDadoAnterior.Location = new System.Drawing.Point(109, 23);
            this.txtDadoAnterior.Name = "txtDadoAnterior";
            this.txtDadoAnterior.Size = new System.Drawing.Size(200, 20);
            this.txtDadoAnterior.TabIndex = 10;
            this.txtDadoAnterior.Text = "txtDadoAnterior";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dado antecessor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Novo dado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDireito);
            this.groupBox1.Controls.Add(this.rbEsquerdo);
            this.groupBox1.Location = new System.Drawing.Point(141, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 41);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lado";
            // 
            // rbDireito
            // 
            this.rbDireito.AutoSize = true;
            this.rbDireito.Location = new System.Drawing.Point(103, 18);
            this.rbDireito.Name = "rbDireito";
            this.rbDireito.Size = new System.Drawing.Size(55, 17);
            this.rbDireito.TabIndex = 1;
            this.rbDireito.Text = "Direito";
            this.rbDireito.UseVisualStyleBackColor = true;
            // 
            // rbEsquerdo
            // 
            this.rbEsquerdo.AutoSize = true;
            this.rbEsquerdo.Checked = true;
            this.rbEsquerdo.Location = new System.Drawing.Point(6, 18);
            this.rbEsquerdo.Name = "rbEsquerdo";
            this.rbEsquerdo.Size = new System.Drawing.Size(70, 17);
            this.rbEsquerdo.TabIndex = 0;
            this.rbEsquerdo.TabStop = true;
            this.rbEsquerdo.Text = "Esquerdo";
            this.rbEsquerdo.UseVisualStyleBackColor = true;
            // 
            // btnSomarDados
            // 
            this.btnSomarDados.Location = new System.Drawing.Point(244, 158);
            this.btnSomarDados.Name = "btnSomarDados";
            this.btnSomarDados.Size = new System.Drawing.Size(100, 30);
            this.btnSomarDados.TabIndex = 18;
            this.btnSomarDados.Text = "Somar Dados";
            this.btnSomarDados.UseVisualStyleBackColor = true;
            this.btnSomarDados.Click += new System.EventHandler(this.btnSomarDados_Click);
            // 
            // txtDadoABuscar
            // 
            this.txtDadoABuscar.Location = new System.Drawing.Point(144, 128);
            this.txtDadoABuscar.Name = "txtDadoABuscar";
            this.txtDadoABuscar.Size = new System.Drawing.Size(200, 20);
            this.txtDadoABuscar.TabIndex = 19;
            this.txtDadoABuscar.Text = "txtDadoABuscar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Dado a buscar:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1085, 442);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDadoABuscar);
            this.Controls.Add(this.btnSomarDados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDadoAnterior);
            this.Controls.Add(this.pbArvore);
            this.Controls.Add(this.txtNovoDado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnNosInternos);
            this.Controls.Add(this.btnCaminho);
            this.Controls.Add(this.btnBalanceada);
            this.Name = "Form1";
            this.Text = "Árvore Binária";
            ((System.ComponentModel.ISupportInitialize)(this.pbArvore)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private System.Windows.Forms.TextBox txtNovoDado;
    private System.Windows.Forms.TextBox txtResultado;
    private System.Windows.Forms.Button btnInserir;
    private System.Windows.Forms.Button btnNosInternos;
    private System.Windows.Forms.Button btnCaminho;
    private System.Windows.Forms.Button btnBalanceada;

    #endregion

    private System.Windows.Forms.PictureBox pbArvore;
    private System.Windows.Forms.TextBox txtDadoAnterior;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton rbDireito;
    private System.Windows.Forms.RadioButton rbEsquerdo;
    private System.Windows.Forms.Button btnSomarDados;
    private System.Windows.Forms.TextBox txtDadoABuscar;
    private System.Windows.Forms.Label label3;
  }
}

