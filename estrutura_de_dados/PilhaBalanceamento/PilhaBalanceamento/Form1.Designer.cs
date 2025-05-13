namespace PilhaBalanceamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtExpressao = new TextBox();
            label1 = new Label();
            statusBar = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtExpressao
            // 
            txtExpressao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtExpressao.Location = new Point(146, 15);
            txtExpressao.Margin = new Padding(6);
            txtExpressao.Name = "txtExpressao";
            txtExpressao.Size = new Size(456, 38);
            txtExpressao.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(10, 18);
            label1.Name = "label1";
            label1.Size = new Size(127, 31);
            label1.TabIndex = 1;
            label1.Text = "Expressão";
            // 
            // statusBar
            // 
            statusBar.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1 });
            statusBar.Location = new Point(0, 428);
            statusBar.Name = "statusBar";
            statusBar.RightToLeft = RightToLeft.No;
            statusBar.Size = new Size(741, 22);
            statusBar.TabIndex = 2;
            statusBar.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(111, 17);
            toolStripStatusLabel1.Text = "Execute uma ação...";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Alignment = ToolStripItemAlignment.Right;
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(619, 16);
            button1.Name = "button1";
            button1.Size = new Size(110, 38);
            button1.TabIndex = 3;
            button1.Text = "Analisar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(717, 353);
            dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(statusBar);
            Controls.Add(label1);
            Controls.Add(txtExpressao);
            Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Balanceamento de Parênteses";
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtExpressao;
        private Label label1;
        private StatusStrip statusBar;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button button1;
        private DataGridView dataGridView1;
        private ToolStripProgressBar toolStripProgressBar1;
    }
}
