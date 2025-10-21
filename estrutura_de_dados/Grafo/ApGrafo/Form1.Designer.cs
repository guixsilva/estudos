namespace ApGrafo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      tabControl1 = new TabControl();
      tpTopologico = new TabPage();
      btnCriarEOrdenar = new Button();
      tpPercursoEmProfundidade = new TabPage();
      dgvGrafo = new DataGridView();
      btnOrdenarRoupas = new Button();
      tpPercursoEmLargura = new TabPage();
      txtResultado = new TextBox();
      label1 = new Label();
      tpArvoreGeradoraMinima = new TabPage();
      tabControl1.SuspendLayout();
      tpTopologico.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)dgvGrafo).BeginInit();
      SuspendLayout();
      // 
      // tabControl1
      // 
      tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      tabControl1.Controls.Add(tpTopologico);
      tabControl1.Controls.Add(tpPercursoEmProfundidade);
      tabControl1.Controls.Add(tpPercursoEmLargura);
      tabControl1.Controls.Add(tpArvoreGeradoraMinima);
      tabControl1.Location = new Point(1, 331);
      tabControl1.Name = "tabControl1";
      tabControl1.SelectedIndex = 0;
      tabControl1.Size = new Size(919, 146);
      tabControl1.TabIndex = 0;
      // 
      // tpTopologico
      // 
      tpTopologico.Controls.Add(btnOrdenarRoupas);
      tpTopologico.Controls.Add(btnCriarEOrdenar);
      tpTopologico.Location = new Point(4, 30);
      tpTopologico.Name = "tpTopologico";
      tpTopologico.Padding = new Padding(3);
      tpTopologico.Size = new Size(911, 112);
      tpTopologico.TabIndex = 0;
      tpTopologico.Text = "Ord. Topológica";
      tpTopologico.UseVisualStyleBackColor = true;
      // 
      // btnCriarEOrdenar
      // 
      btnCriarEOrdenar.Location = new Point(6, 6);
      btnCriarEOrdenar.Name = "btnCriarEOrdenar";
      btnCriarEOrdenar.Size = new Size(94, 79);
      btnCriarEOrdenar.TabIndex = 4;
      btnCriarEOrdenar.Text = "Criar e Ordenar disciplinas";
      btnCriarEOrdenar.UseVisualStyleBackColor = true;
      btnCriarEOrdenar.Click += btnCriarEOrdenar_Click;
      // 
      // tpPercursoEmProfundidade
      // 
      tpPercursoEmProfundidade.Location = new Point(4, 30);
      tpPercursoEmProfundidade.Name = "tpPercursoEmProfundidade";
      tpPercursoEmProfundidade.Padding = new Padding(3);
      tpPercursoEmProfundidade.Size = new Size(541, 415);
      tpPercursoEmProfundidade.TabIndex = 1;
      tpPercursoEmProfundidade.Text = "Percurso em profundidade";
      tpPercursoEmProfundidade.UseVisualStyleBackColor = true;
      // 
      // dgvGrafo
      // 
      dgvGrafo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgvGrafo.Location = new Point(5, 12);
      dgvGrafo.Name = "dgvGrafo";
      dgvGrafo.Size = new Size(908, 269);
      dgvGrafo.TabIndex = 5;
      // 
      // btnOrdenarRoupas
      // 
      btnOrdenarRoupas.Location = new Point(106, 6);
      btnOrdenarRoupas.Name = "btnOrdenarRoupas";
      btnOrdenarRoupas.Size = new Size(94, 81);
      btnOrdenarRoupas.TabIndex = 5;
      btnOrdenarRoupas.Text = "Criar e Ordenar roupas";
      btnOrdenarRoupas.UseVisualStyleBackColor = true;
      btnOrdenarRoupas.Click += btnOrdenarRoupas_Click;
      // 
      // tpPercursoEmLargura
      // 
      tpPercursoEmLargura.Location = new Point(4, 30);
      tpPercursoEmLargura.Name = "tpPercursoEmLargura";
      tpPercursoEmLargura.Padding = new Padding(3);
      tpPercursoEmLargura.Size = new Size(541, 415);
      tpPercursoEmLargura.TabIndex = 2;
      tpPercursoEmLargura.Text = "Percurso em largura";
      tpPercursoEmLargura.UseVisualStyleBackColor = true;
      // 
      // txtResultado
      // 
      txtResultado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      txtResultado.Location = new Point(91, 296);
      txtResultado.Name = "txtResultado";
      txtResultado.Size = new Size(436, 29);
      txtResultado.TabIndex = 7;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(3, 299);
      label1.Name = "label1";
      label1.Size = new Size(82, 21);
      label1.TabIndex = 6;
      label1.Text = "Resultado:";
      // 
      // tpArvoreGeradoraMinima
      // 
      tpArvoreGeradoraMinima.Location = new Point(4, 30);
      tpArvoreGeradoraMinima.Name = "tpArvoreGeradoraMinima";
      tpArvoreGeradoraMinima.Padding = new Padding(3);
      tpArvoreGeradoraMinima.Size = new Size(911, 112);
      tpArvoreGeradoraMinima.TabIndex = 3;
      tpArvoreGeradoraMinima.Text = "Árvore geradora mínima";
      tpArvoreGeradoraMinima.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      AutoScaleMode = AutoScaleMode.None;
      ClientSize = new Size(921, 477);
      Controls.Add(txtResultado);
      Controls.Add(label1);
      Controls.Add(dgvGrafo);
      Controls.Add(tabControl1);
      Font = new Font("Segoe UI", 12F);
      Name = "Form1";
      Text = "Form1";
      tabControl1.ResumeLayout(false);
      tpTopologico.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)dgvGrafo).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TabControl tabControl1;
    private TabPage tpTopologico;
    private TabPage tpPercursoEmProfundidade;
    private DataGridView dgvGrafo;
    private Button btnCriarEOrdenar;
    private Button btnOrdenarRoupas;
    private TabPage tpPercursoEmLargura;
    private TabPage tpArvoreGeradoraMinima;
    private TextBox txtResultado;
    private Label label1;
  }
}
