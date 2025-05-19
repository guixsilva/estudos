namespace projecBacktracking
{
    partial class FrmCaminhos
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
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            txtDestino = new NumericUpDown();
            txtOrigem = new NumericUpDown();
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            btnAbrirArquivo = new Button();
            dataGridView1 = new DataGridView();
            dataGrafo = new DataGridView();
            listBox1 = new ListBox();
            dlgAbrir = new OpenFileDialog();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtDestino).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtOrigem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrafo).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(328, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 69);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de grafo";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(122, 28);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(106, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Com distâncias";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 28);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(110, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Apenas ligações";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDestino);
            groupBox2.Controls.Add(txtOrigem);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(310, 69);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Descobrir caminhos";
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(165, 26);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(47, 23);
            txtDestino.TabIndex = 5;
            // 
            // txtOrigem
            // 
            txtOrigem.Location = new Point(59, 26);
            txtOrigem.Name = "txtOrigem";
            txtOrigem.Size = new Size(47, 23);
            txtOrigem.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(229, 26);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 30);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 4;
            label2.Text = "Destino";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Origem";
            // 
            // btnAbrirArquivo
            // 
            btnAbrirArquivo.Location = new Point(203, 87);
            btnAbrirArquivo.Name = "btnAbrirArquivo";
            btnAbrirArquivo.Size = new Size(173, 40);
            btnAbrirArquivo.TabIndex = 2;
            btnAbrirArquivo.Text = "Abrir Arquivo";
            btnAbrirArquivo.UseVisualStyleBackColor = true;
            btnAbrirArquivo.Click += btnAbrirArquivo_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(564, 150);
            dataGridView1.TabIndex = 3;
            // 
            // dataGrafo
            // 
            dataGrafo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrafo.Location = new Point(12, 322);
            dataGrafo.Name = "dataGrafo";
            dataGrafo.Size = new Size(564, 188);
            dataGrafo.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 534);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(564, 184);
            listBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 129);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 6;
            label3.Text = "Pilha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 304);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Grafo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 516);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 8;
            label5.Text = "Movimentos";
            // 
            // FrmCaminhos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 748);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(dataGrafo);
            Controls.Add(dataGridView1);
            Controls.Add(btnAbrirArquivo);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmCaminhos";
            Text = "Busca de caminhos entre cidades";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtDestino).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtOrigem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrafo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private Label label1;
        private NumericUpDown txtDestino;
        private NumericUpDown txtOrigem;
        private Button button2;
        private Label label2;
        private Button btnAbrirArquivo;
        private DataGridView dataGridView1;
        private DataGridView dataGrafo;
        private ListBox listBox1;
        private OpenFileDialog dlgAbrir;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
