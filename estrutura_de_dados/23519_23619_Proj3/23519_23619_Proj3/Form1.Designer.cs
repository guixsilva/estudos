namespace _23519_23619_Proj3
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtDica = new TextBox();
            txtPalavra = new TextBox();
            dataDicionario = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            slRegistro = new StatusStrip();
            statusText = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            btnInicio = new ToolStripButton();
            btnAnterior = new ToolStripButton();
            btnProximo = new ToolStripButton();
            btnFim = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnBuscar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnNovo = new ToolStripButton();
            btnEditar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnExcluir = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            btnSair = new ToolStripButton();
            tabPage2 = new TabPage();
            dlgAbrir = new OpenFileDialog();
            btnSalvar = new ToolStripButton();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataDicionario).BeginInit();
            slRegistro.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(15, 17);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(998, 512);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightGray;
            tabPage1.Controls.Add(txtDica);
            tabPage1.Controls.Add(txtPalavra);
            tabPage1.Controls.Add(dataDicionario);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(slRegistro);
            tabPage1.Controls.Add(toolStrip1);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(990, 478);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            // 
            // txtDica
            // 
            txtDica.Location = new Point(77, 104);
            txtDica.Name = "txtDica";
            txtDica.Size = new Size(362, 29);
            txtDica.TabIndex = 6;
            txtDica.Leave += txtDica_Leave;
            // 
            // txtPalavra
            // 
            txtPalavra.Location = new Point(77, 69);
            txtPalavra.Name = "txtPalavra";
            txtPalavra.Size = new Size(200, 29);
            txtPalavra.TabIndex = 5;
            txtPalavra.Leave += txtPalavra_Leave;
            // 
            // dataDicionario
            // 
            dataDicionario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataDicionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataDicionario.Location = new Point(7, 161);
            dataDicionario.Name = "dataDicionario";
            dataDicionario.Size = new Size(976, 288);
            dataDicionario.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 108);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 3;
            label2.Text = "Dica:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 73);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 2;
            label1.Text = "Palavra:";
            // 
            // slRegistro
            // 
            slRegistro.Items.AddRange(new ToolStripItem[] { statusText });
            slRegistro.Location = new Point(4, 452);
            slRegistro.Name = "slRegistro";
            slRegistro.Size = new Size(982, 22);
            slRegistro.TabIndex = 1;
            slRegistro.Text = "statusStrip1";
            // 
            // statusText
            // 
            statusText.Name = "statusText";
            statusText.Size = new Size(118, 17);
            statusText.Text = "toolStripStatusLabel1";
            // 
            // toolStrip1
            // 
            toolStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            toolStrip1.AutoSize = false;
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(36, 36);
            toolStrip1.ImeMode = ImeMode.NoControl;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnInicio, btnAnterior, btnProximo, btnFim, toolStripSeparator1, btnBuscar, toolStripSeparator2, btnNovo, btnEditar, btnSalvar, toolStripSeparator3, btnExcluir, toolStripSeparator4, btnSair });
            toolStrip1.Location = new Point(4, 4);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(982, 43);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnInicio
            // 
            btnInicio.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInicio.Image = Properties.Resources.double_left;
            btnInicio.ImageTransparentColor = Color.Magenta;
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(40, 40);
            btnInicio.Text = "Inicio";
            btnInicio.Click += btnInicio_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.AutoSize = false;
            btnAnterior.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAnterior.Image = Properties.Resources.arrows_long_left;
            btnAnterior.ImageTransparentColor = Color.Magenta;
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(40, 40);
            btnAnterior.Text = "Anterior";
            btnAnterior.TextImageRelation = TextImageRelation.TextAboveImage;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnProximo
            // 
            btnProximo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnProximo.Image = Properties.Resources.arrows_long_right;
            btnProximo.ImageTransparentColor = Color.Magenta;
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(40, 40);
            btnProximo.Text = "Próximo";
            btnProximo.Click += btnProximo_Click;
            // 
            // btnFim
            // 
            btnFim.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFim.Image = Properties.Resources.double_right;
            btnFim.ImageTransparentColor = Color.Magenta;
            btnFim.Name = "btnFim";
            btnFim.Size = new Size(40, 40);
            btnFim.Text = "Último";
            btnFim.Click += btnFim_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 43);
            // 
            // btnBuscar
            // 
            btnBuscar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnBuscar.Image = Properties.Resources.search;
            btnBuscar.ImageTransparentColor = Color.Magenta;
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(40, 40);
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 43);
            // 
            // btnNovo
            // 
            btnNovo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnNovo.Image = Properties.Resources.create_new;
            btnNovo.ImageTransparentColor = Color.Magenta;
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(40, 40);
            btnNovo.Text = "Novo";
            btnNovo.Click += btnNovo_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = Properties.Resources.file;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(40, 40);
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 43);
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Image = Properties.Resources.eraser;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(40, 40);
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 43);
            // 
            // btnSair
            // 
            btnSair.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSair.Image = Properties.Resources.shutdown;
            btnSair.ImageTransparentColor = Color.Magenta;
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(40, 40);
            btnSair.Text = "Sair";
            btnSair.Click += btnSair_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(990, 484);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Forca";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dlgAbrir
            // 
            dlgAbrir.FileName = "openFileDialog1";
            // 
            // btnSalvar
            // 
            btnSalvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSalvar.Image = Properties.Resources.hdd;
            btnSalvar.ImageTransparentColor = Color.Magenta;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(40, 40);
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 546);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Jogo de Forca";
            FormClosing += Form1_FormClosing;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataDicionario).EndInit();
            slRegistro.ResumeLayout(false);
            slRegistro.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ToolStripButton btnInicio;
        private ToolStripButton btnAnterior;
        private ToolStripButton btnProximo;
        private ToolStripButton btnFim;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnBuscar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnNovo;
        private ToolStripButton btnEditar;
        private ToolStripButton btnCancelar;
        private ToolStripButton toolStripButton9;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnExcluir;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btnSair;
        private DataGridView dataDicionario;
        private Label label2;
        private Label label1;
        private StatusStrip slRegistro;
        private TextBox txtDica;
        private TextBox txtPalavra;
        public ToolStrip toolStrip1;
        private OpenFileDialog dlgAbrir;
        private ToolStripStatusLabel statusText;
        private ToolStripButton btnSalvar;
    }
}
