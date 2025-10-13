namespace apArvore
{
  partial class FrmFuncionario
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
      this.btnPre_Ordem = new System.Windows.Forms.Button();
      this.lsbDados = new System.Windows.Forms.ListBox();
      this.btnEm_Ordem = new System.Windows.Forms.Button();
      this.btnPos_Ordem = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.button6 = new System.Windows.Forms.Button();
      this.button7 = new System.Windows.Forms.Button();
      this.lbQuantosNos = new System.Windows.Forms.Label();
      this.chkEquivalem = new System.Windows.Forms.CheckBox();
      this.lbQuantasFolhas = new System.Windows.Forms.Label();
      this.lbAltura = new System.Windows.Forms.Label();
      this.btnPorNiveis = new System.Windows.Forms.Button();
      this.btnLargura = new System.Windows.Forms.Button();
      this.lbLargura = new System.Windows.Forms.Label();
      this.btnAntecessores = new System.Windows.Forms.Button();
      this.txtProcurado = new System.Windows.Forms.TextBox();
      this.pnlArvore = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.txtMatricula = new System.Windows.Forms.TextBox();
      this.txtNome = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
      this.label3 = new System.Windows.Forms.Label();
      this.txtCodigoSecao = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtMatriculaChefe = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.udDependentes = new System.Windows.Forms.NumericUpDown();
      this.txtSalario = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.chkAfastado = new System.Windows.Forms.CheckBox();
      this.btnIncluirRec = new System.Windows.Forms.Button();
      this.btnExcluir = new System.Windows.Forms.Button();
      this.btnExibir = new System.Windows.Forms.Button();
      this.btnAlterar = new System.Windows.Forms.Button();
      this.btnIncluirSemRecursao = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.udDependentes)).BeginInit();
      this.SuspendLayout();
      // 
      // btnPre_Ordem
      // 
      this.btnPre_Ordem.Location = new System.Drawing.Point(2, 7);
      this.btnPre_Ordem.Name = "btnPre_Ordem";
      this.btnPre_Ordem.Size = new System.Drawing.Size(75, 23);
      this.btnPre_Ordem.TabIndex = 0;
      this.btnPre_Ordem.Text = "Pré Ordem";
      this.btnPre_Ordem.UseVisualStyleBackColor = true;
      this.btnPre_Ordem.Click += new System.EventHandler(this.button1_Click);
      // 
      // lsbDados
      // 
      this.lsbDados.FormattingEnabled = true;
      this.lsbDados.Location = new System.Drawing.Point(2, 99);
      this.lsbDados.Name = "lsbDados";
      this.lsbDados.Size = new System.Drawing.Size(158, 186);
      this.lsbDados.TabIndex = 1;
      // 
      // btnEm_Ordem
      // 
      this.btnEm_Ordem.Location = new System.Drawing.Point(2, 36);
      this.btnEm_Ordem.Name = "btnEm_Ordem";
      this.btnEm_Ordem.Size = new System.Drawing.Size(75, 23);
      this.btnEm_Ordem.TabIndex = 2;
      this.btnEm_Ordem.Text = "Em Ordem";
      this.btnEm_Ordem.UseVisualStyleBackColor = true;
      this.btnEm_Ordem.Click += new System.EventHandler(this.btnEm_Ordem_Click);
      // 
      // btnPos_Ordem
      // 
      this.btnPos_Ordem.Location = new System.Drawing.Point(2, 65);
      this.btnPos_Ordem.Name = "btnPos_Ordem";
      this.btnPos_Ordem.Size = new System.Drawing.Size(75, 23);
      this.btnPos_Ordem.TabIndex = 3;
      this.btnPos_Ordem.Text = "Pós Ordem";
      this.btnPos_Ordem.UseVisualStyleBackColor = true;
      this.btnPos_Ordem.Click += new System.EventHandler(this.btnPos_Ordem_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(2, 291);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 5;
      this.button1.Text = "Exercício 1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click_1);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(1, 320);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 6;
      this.button2.Text = "Exercício 2";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(2, 349);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 23);
      this.button3.TabIndex = 7;
      this.button3.Text = "Exercício 3";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(2, 378);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(75, 23);
      this.button4.TabIndex = 8;
      this.button4.Text = "Exercício 4";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(2, 407);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(75, 23);
      this.button5.TabIndex = 9;
      this.button5.Text = "Exercício 5";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // button6
      // 
      this.button6.Location = new System.Drawing.Point(2, 436);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(75, 23);
      this.button6.TabIndex = 10;
      this.button6.Text = "Exercício 6";
      this.button6.UseVisualStyleBackColor = true;
      this.button6.Click += new System.EventHandler(this.button6_Click);
      // 
      // button7
      // 
      this.button7.Location = new System.Drawing.Point(2, 465);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(75, 23);
      this.button7.TabIndex = 11;
      this.button7.Text = "Exercício 7";
      this.button7.UseVisualStyleBackColor = true;
      this.button7.Click += new System.EventHandler(this.button7_Click);
      // 
      // lbQuantosNos
      // 
      this.lbQuantosNos.AutoSize = true;
      this.lbQuantosNos.Location = new System.Drawing.Point(82, 325);
      this.lbQuantosNos.Name = "lbQuantosNos";
      this.lbQuantosNos.Size = new System.Drawing.Size(33, 13);
      this.lbQuantosNos.TabIndex = 12;
      this.lbQuantosNos.Text = "0 nós";
      // 
      // chkEquivalem
      // 
      this.chkEquivalem.AutoSize = true;
      this.chkEquivalem.Location = new System.Drawing.Point(85, 292);
      this.chkEquivalem.Name = "chkEquivalem";
      this.chkEquivalem.Size = new System.Drawing.Size(75, 17);
      this.chkEquivalem.TabIndex = 13;
      this.chkEquivalem.Text = "Equivalem";
      this.chkEquivalem.UseVisualStyleBackColor = true;
      // 
      // lbQuantasFolhas
      // 
      this.lbQuantasFolhas.AutoSize = true;
      this.lbQuantasFolhas.Location = new System.Drawing.Point(82, 354);
      this.lbQuantasFolhas.Name = "lbQuantasFolhas";
      this.lbQuantasFolhas.Size = new System.Drawing.Size(44, 13);
      this.lbQuantasFolhas.TabIndex = 14;
      this.lbQuantasFolhas.Text = "0 folhas";
      // 
      // lbAltura
      // 
      this.lbAltura.AutoSize = true;
      this.lbAltura.Location = new System.Drawing.Point(83, 412);
      this.lbAltura.Name = "lbAltura";
      this.lbAltura.Size = new System.Drawing.Size(40, 13);
      this.lbAltura.TabIndex = 15;
      this.lbAltura.Text = "Altura: ";
      // 
      // btnPorNiveis
      // 
      this.btnPorNiveis.Location = new System.Drawing.Point(2, 494);
      this.btnPorNiveis.Name = "btnPorNiveis";
      this.btnPorNiveis.Size = new System.Drawing.Size(75, 23);
      this.btnPorNiveis.TabIndex = 16;
      this.btnPorNiveis.Text = "Exercício 8";
      this.btnPorNiveis.UseVisualStyleBackColor = true;
      this.btnPorNiveis.Click += new System.EventHandler(this.btnPorNiveis_Click);
      // 
      // btnLargura
      // 
      this.btnLargura.Location = new System.Drawing.Point(2, 523);
      this.btnLargura.Name = "btnLargura";
      this.btnLargura.Size = new System.Drawing.Size(75, 23);
      this.btnLargura.TabIndex = 17;
      this.btnLargura.Text = "Exercício 9";
      this.btnLargura.UseVisualStyleBackColor = true;
      this.btnLargura.Click += new System.EventHandler(this.btnLargura_Click);
      // 
      // lbLargura
      // 
      this.lbLargura.AutoSize = true;
      this.lbLargura.Location = new System.Drawing.Point(83, 528);
      this.lbLargura.Name = "lbLargura";
      this.lbLargura.Size = new System.Drawing.Size(49, 13);
      this.lbLargura.TabIndex = 18;
      this.lbLargura.Text = "Largura: ";
      // 
      // btnAntecessores
      // 
      this.btnAntecessores.Location = new System.Drawing.Point(2, 552);
      this.btnAntecessores.Name = "btnAntecessores";
      this.btnAntecessores.Size = new System.Drawing.Size(75, 23);
      this.btnAntecessores.TabIndex = 19;
      this.btnAntecessores.Text = "Exercício 10";
      this.btnAntecessores.UseVisualStyleBackColor = true;
      this.btnAntecessores.Click += new System.EventHandler(this.btnAntecessores_Click);
      // 
      // txtProcurado
      // 
      this.txtProcurado.Location = new System.Drawing.Point(86, 552);
      this.txtProcurado.Name = "txtProcurado";
      this.txtProcurado.Size = new System.Drawing.Size(60, 20);
      this.txtProcurado.TabIndex = 20;
      // 
      // pnlArvore
      // 
      this.pnlArvore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlArvore.BackColor = System.Drawing.Color.White;
      this.pnlArvore.Location = new System.Drawing.Point(166, 99);
      this.pnlArvore.Name = "pnlArvore";
      this.pnlArvore.Size = new System.Drawing.Size(744, 484);
      this.pnlArvore.TabIndex = 21;
      this.pnlArvore.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlArvore_Paint);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(163, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 13);
      this.label1.TabIndex = 22;
      this.label1.Text = "Matrícula:";
      // 
      // txtMatricula
      // 
      this.txtMatricula.Location = new System.Drawing.Point(224, 9);
      this.txtMatricula.Name = "txtMatricula";
      this.txtMatricula.Size = new System.Drawing.Size(75, 20);
      this.txtMatricula.TabIndex = 23;
      // 
      // txtNome
      // 
      this.txtNome.Location = new System.Drawing.Point(349, 9);
      this.txtNome.MaxLength = 30;
      this.txtNome.Name = "txtNome";
      this.txtNome.Size = new System.Drawing.Size(226, 20);
      this.txtNome.TabIndex = 25;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(305, 12);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(38, 13);
      this.label2.TabIndex = 24;
      this.label2.Text = "Nome:";
      // 
      // dtpNascimento
      // 
      this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpNascimento.Location = new System.Drawing.Point(653, 7);
      this.dtpNascimento.Name = "dtpNascimento";
      this.dtpNascimento.Size = new System.Drawing.Size(105, 20);
      this.dtpNascimento.TabIndex = 26;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(581, 9);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(66, 13);
      this.label3.TabIndex = 27;
      this.label3.Text = "Nascimento:";
      // 
      // txtCodigoSecao
      // 
      this.txtCodigoSecao.Location = new System.Drawing.Point(811, 6);
      this.txtCodigoSecao.Name = "txtCodigoSecao";
      this.txtCodigoSecao.Size = new System.Drawing.Size(46, 20);
      this.txtCodigoSecao.TabIndex = 29;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(764, 12);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(41, 13);
      this.label4.TabIndex = 28;
      this.label4.Text = "Seção:";
      // 
      // txtMatriculaChefe
      // 
      this.txtMatriculaChefe.Location = new System.Drawing.Point(224, 37);
      this.txtMatriculaChefe.Name = "txtMatriculaChefe";
      this.txtMatriculaChefe.Size = new System.Drawing.Size(75, 20);
      this.txtMatriculaChefe.TabIndex = 31;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(163, 40);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(38, 13);
      this.label5.TabIndex = 30;
      this.label5.Text = "Chefe:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(305, 40);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(74, 13);
      this.label6.TabIndex = 32;
      this.label6.Text = "Dependentes:";
      // 
      // udDependentes
      // 
      this.udDependentes.Location = new System.Drawing.Point(386, 36);
      this.udDependentes.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.udDependentes.Name = "udDependentes";
      this.udDependentes.Size = new System.Drawing.Size(46, 20);
      this.udDependentes.TabIndex = 33;
      // 
      // txtSalario
      // 
      this.txtSalario.Location = new System.Drawing.Point(500, 35);
      this.txtSalario.Name = "txtSalario";
      this.txtSalario.Size = new System.Drawing.Size(75, 20);
      this.txtSalario.TabIndex = 35;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(459, 38);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(42, 13);
      this.label7.TabIndex = 34;
      this.label7.Text = "Salário:";
      // 
      // chkAfastado
      // 
      this.chkAfastado.AutoSize = true;
      this.chkAfastado.Location = new System.Drawing.Point(588, 40);
      this.chkAfastado.Name = "chkAfastado";
      this.chkAfastado.Size = new System.Drawing.Size(74, 17);
      this.chkAfastado.TabIndex = 36;
      this.chkAfastado.Text = "Afastado?";
      this.chkAfastado.UseVisualStyleBackColor = true;
      // 
      // btnIncluirRec
      // 
      this.btnIncluirRec.Location = new System.Drawing.Point(264, 70);
      this.btnIncluirRec.Name = "btnIncluirRec";
      this.btnIncluirRec.Size = new System.Drawing.Size(75, 23);
      this.btnIncluirRec.TabIndex = 37;
      this.btnIncluirRec.Text = "Incluir Rec";
      this.btnIncluirRec.UseVisualStyleBackColor = true;
      this.btnIncluirRec.Click += new System.EventHandler(this.btnIncluir_Click);
      // 
      // btnExcluir
      // 
      this.btnExcluir.Location = new System.Drawing.Point(349, 70);
      this.btnExcluir.Name = "btnExcluir";
      this.btnExcluir.Size = new System.Drawing.Size(75, 23);
      this.btnExcluir.TabIndex = 38;
      this.btnExcluir.Text = "Excluir";
      this.btnExcluir.UseVisualStyleBackColor = true;
      this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
      // 
      // btnExibir
      // 
      this.btnExibir.Location = new System.Drawing.Point(443, 70);
      this.btnExibir.Name = "btnExibir";
      this.btnExibir.Size = new System.Drawing.Size(75, 23);
      this.btnExibir.TabIndex = 39;
      this.btnExibir.Text = "Exibir";
      this.btnExibir.UseVisualStyleBackColor = true;
      this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
      // 
      // btnAlterar
      // 
      this.btnAlterar.Location = new System.Drawing.Point(536, 70);
      this.btnAlterar.Name = "btnAlterar";
      this.btnAlterar.Size = new System.Drawing.Size(75, 23);
      this.btnAlterar.TabIndex = 40;
      this.btnAlterar.Text = "Alterar";
      this.btnAlterar.UseVisualStyleBackColor = true;
      // 
      // btnIncluirSemRecursao
      // 
      this.btnIncluirSemRecursao.Location = new System.Drawing.Point(166, 70);
      this.btnIncluirSemRecursao.Name = "btnIncluirSemRecursao";
      this.btnIncluirSemRecursao.Size = new System.Drawing.Size(92, 23);
      this.btnIncluirSemRecursao.TabIndex = 41;
      this.btnIncluirSemRecursao.Text = "Incluir sem Rec";
      this.btnIncluirSemRecursao.UseVisualStyleBackColor = true;
      this.btnIncluirSemRecursao.Click += new System.EventHandler(this.button8_Click);
      // 
      // FrmFuncionario
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(916, 585);
      this.Controls.Add(this.btnIncluirSemRecursao);
      this.Controls.Add(this.btnAlterar);
      this.Controls.Add(this.btnExibir);
      this.Controls.Add(this.btnExcluir);
      this.Controls.Add(this.btnIncluirRec);
      this.Controls.Add(this.chkAfastado);
      this.Controls.Add(this.txtSalario);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.udDependentes);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.txtMatriculaChefe);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtCodigoSecao);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.dtpNascimento);
      this.Controls.Add(this.txtNome);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtMatricula);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.pnlArvore);
      this.Controls.Add(this.txtProcurado);
      this.Controls.Add(this.btnAntecessores);
      this.Controls.Add(this.lbLargura);
      this.Controls.Add(this.btnLargura);
      this.Controls.Add(this.btnPorNiveis);
      this.Controls.Add(this.lbAltura);
      this.Controls.Add(this.lbQuantasFolhas);
      this.Controls.Add(this.chkEquivalem);
      this.Controls.Add(this.lbQuantosNos);
      this.Controls.Add(this.button7);
      this.Controls.Add(this.button6);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.btnPos_Ordem);
      this.Controls.Add(this.btnEm_Ordem);
      this.Controls.Add(this.lsbDados);
      this.Controls.Add(this.btnPre_Ordem);
      this.Name = "FrmFuncionario";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Testes de Árvores Binárias";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFuncionario_FormClosing);
      this.Load += new System.EventHandler(this.FrmArvore_Load);
      ((System.ComponentModel.ISupportInitialize)(this.udDependentes)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnPre_Ordem;
    private System.Windows.Forms.ListBox lsbDados;
    private System.Windows.Forms.Button btnEm_Ordem;
    private System.Windows.Forms.Button btnPos_Ordem;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Label lbQuantosNos;
    private System.Windows.Forms.CheckBox chkEquivalem;
    private System.Windows.Forms.Label lbQuantasFolhas;
    private System.Windows.Forms.Label lbAltura;
    private System.Windows.Forms.Button btnPorNiveis;
    private System.Windows.Forms.Button btnLargura;
    private System.Windows.Forms.Label lbLargura;
    private System.Windows.Forms.Button btnAntecessores;
    private System.Windows.Forms.TextBox txtProcurado;
    private System.Windows.Forms.Panel pnlArvore;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtMatricula;
    private System.Windows.Forms.TextBox txtNome;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DateTimePicker dtpNascimento;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtCodigoSecao;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtMatriculaChefe;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.NumericUpDown udDependentes;
    private System.Windows.Forms.TextBox txtSalario;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.CheckBox chkAfastado;
    private System.Windows.Forms.Button btnIncluirRec;
    private System.Windows.Forms.Button btnExcluir;
    private System.Windows.Forms.Button btnExibir;
    private System.Windows.Forms.Button btnAlterar;
    private System.Windows.Forms.Button btnIncluirSemRecursao;
  }
}

