namespace Exer3
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
            lstVisor = new ListBox();
            btnLer = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // lstVisor
            // 
            lstVisor.FormattingEnabled = true;
            lstVisor.ItemHeight = 15;
            lstVisor.Location = new Point(12, 66);
            lstVisor.Name = "lstVisor";
            lstVisor.Size = new Size(356, 364);
            lstVisor.TabIndex = 0;
            // 
            // btnLer
            // 
            btnLer.Location = new Point(12, 12);
            btnLer.Name = "btnLer";
            btnLer.Size = new Size(117, 34);
            btnLer.TabIndex = 1;
            btnLer.Text = "LER ARQUIVO";
            btnLer.UseVisualStyleBackColor = true;
            btnLer.Click += btnLer_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 450);
            Controls.Add(btnLer);
            Controls.Add(lstVisor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstVisor;
        private Button btnLer;
        private OpenFileDialog openFileDialog1;
    }
}
