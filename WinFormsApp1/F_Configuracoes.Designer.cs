namespace WinFormsApp1
{
    partial class F_Configuracoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_vlr_kg = new System.Windows.Forms.TextBox();
            this.tb_vlr_pg_empresa = new System.Windows.Forms.TextBox();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.l_vlr_kg = new System.Windows.Forms.Label();
            this.l_pg_empresa = new System.Windows.Forms.Label();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_vlr_kg
            // 
            this.tb_vlr_kg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_vlr_kg.Location = new System.Drawing.Point(114, 74);
            this.tb_vlr_kg.Name = "tb_vlr_kg";
            this.tb_vlr_kg.Size = new System.Drawing.Size(100, 23);
            this.tb_vlr_kg.TabIndex = 1;
            this.tb_vlr_kg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_vlr_kg.Click += new System.EventHandler(this.tb_vlr_kg_Click);
            this.tb_vlr_kg.TextChanged += new System.EventHandler(this.tb_vlr_kg_TextChanged);
            this.tb_vlr_kg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_vlr_kg_KeyPress);
            this.tb_vlr_kg.Leave += new System.EventHandler(this.tb_vlr_kg_Leave);
            // 
            // tb_vlr_pg_empresa
            // 
            this.tb_vlr_pg_empresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_vlr_pg_empresa.Location = new System.Drawing.Point(114, 141);
            this.tb_vlr_pg_empresa.Name = "tb_vlr_pg_empresa";
            this.tb_vlr_pg_empresa.Size = new System.Drawing.Size(100, 23);
            this.tb_vlr_pg_empresa.TabIndex = 2;
            this.tb_vlr_pg_empresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_vlr_pg_empresa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_vlr_pg_empresa_MouseClick);
            this.tb_vlr_pg_empresa.TextChanged += new System.EventHandler(this.tb_vlr_pg_empresa_TextChanged);
            this.tb_vlr_pg_empresa.Leave += new System.EventHandler(this.tb_vlr_pg_empresa_Leave);
            // 
            // bt_salvar
            // 
            this.bt_salvar.Location = new System.Drawing.Point(99, 214);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(75, 23);
            this.bt_salvar.TabIndex = 3;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // l_vlr_kg
            // 
            this.l_vlr_kg.AutoSize = true;
            this.l_vlr_kg.Location = new System.Drawing.Point(38, 77);
            this.l_vlr_kg.Name = "l_vlr_kg";
            this.l_vlr_kg.Size = new System.Drawing.Size(50, 15);
            this.l_vlr_kg.TabIndex = 3;
            this.l_vlr_kg.Text = "Valor Kg";
            // 
            // l_pg_empresa
            // 
            this.l_pg_empresa.AutoSize = true;
            this.l_pg_empresa.Location = new System.Drawing.Point(38, 149);
            this.l_pg_empresa.Name = "l_pg_empresa";
            this.l_pg_empresa.Size = new System.Drawing.Size(70, 15);
            this.l_pg_empresa.TabIndex = 4;
            this.l_pg_empresa.Text = "PG Empresa";
            this.l_pg_empresa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem1});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.homeToolStripMenuItem.Text = "Menu";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click_1);
            // 
            // homeToolStripMenuItem1
            // 
            this.homeToolStripMenuItem1.Name = "homeToolStripMenuItem1";
            this.homeToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.homeToolStripMenuItem1.Text = "Home";
            this.homeToolStripMenuItem1.Click += new System.EventHandler(this.homeToolStripMenuItem1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(290, 24);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // F_Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 411);
            this.ControlBox = false;
            this.Controls.Add(this.l_pg_empresa);
            this.Controls.Add(this.l_vlr_kg);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.tb_vlr_pg_empresa);
            this.Controls.Add(this.tb_vlr_kg);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Configuracoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracoes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Configuracoes_FormClosed);
            this.Load += new System.EventHandler(this.F_Configuracoes_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        public TextBox tb_vlr_kg;
        public TextBox tb_vlr_pg_empresa;
        private Button bt_salvar;
        private Label l_vlr_kg;
        private Label l_pg_empresa;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem homeToolStripMenuItem1;
    }
}