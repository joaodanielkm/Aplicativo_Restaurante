namespace WinFormsApp1
{
    partial class tl_home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outrosMesesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLiteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.l_peso = new System.Windows.Forms.Label();
            this.dt_data_atual = new System.Windows.Forms.DateTimePicker();
            this.l_diversos = new System.Windows.Forms.Label();
            this.tb_peso = new System.Windows.Forms.TextBox();
            this.tb_diversos_descricao = new System.Windows.Forms.TextBox();
            this.l_gr = new System.Windows.Forms.Label();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.l_valor_parcial = new System.Windows.Forms.Label();
            this.l_vlr_parcial = new System.Windows.Forms.Label();
            this.ll_sobre = new System.Windows.Forms.LinkLabel();
            this.ll_versao = new System.Windows.Forms.LinkLabel();
            this.tb_outros_valor = new System.Windows.Forms.TextBox();
            this.l_rs = new System.Windows.Forms.Label();
            this.ll_usuario = new System.Windows.Forms.Label();
            this.l_vlr_kg = new System.Windows.Forms.Label();
            this.l_vlrkg = new System.Windows.Forms.Label();
            this.l_vlrdinamico = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.sQLiteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(290, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarSenhaToolStripMenuItem,
            this.históricoToolStripMenuItem,
            this.outrosMesesToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.alterarSenhaToolStripMenuItem.Text = "Alterar Senha";
            // 
            // históricoToolStripMenuItem
            // 
            this.históricoToolStripMenuItem.Name = "históricoToolStripMenuItem";
            this.históricoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.históricoToolStripMenuItem.Text = "Histórico";
            this.históricoToolStripMenuItem.Click += new System.EventHandler(this.históricoToolStripMenuItem_Click);
            // 
            // outrosMesesToolStripMenuItem
            // 
            this.outrosMesesToolStripMenuItem.Name = "outrosMesesToolStripMenuItem";
            this.outrosMesesToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.outrosMesesToolStripMenuItem.Text = "Outros Meses";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // sQLiteToolStripMenuItem
            // 
            this.sQLiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sQLiteToolStripMenuItem1});
            this.sQLiteToolStripMenuItem.Name = "sQLiteToolStripMenuItem";
            this.sQLiteToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sQLiteToolStripMenuItem.Text = "SQLite";
            // 
            // sQLiteToolStripMenuItem1
            // 
            this.sQLiteToolStripMenuItem1.Name = "sQLiteToolStripMenuItem1";
            this.sQLiteToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.sQLiteToolStripMenuItem1.Text = "SQLite";
            this.sQLiteToolStripMenuItem1.Click += new System.EventHandler(this.sQLiteToolStripMenuItem1_Click);
            // 
            // l_peso
            // 
            this.l_peso.AutoSize = true;
            this.l_peso.Location = new System.Drawing.Point(49, 123);
            this.l_peso.Name = "l_peso";
            this.l_peso.Size = new System.Drawing.Size(32, 15);
            this.l_peso.TabIndex = 1;
            this.l_peso.Text = "Peso";
            this.l_peso.Click += new System.EventHandler(this.label1_Click);
            // 
            // dt_data_atual
            // 
            this.dt_data_atual.Location = new System.Drawing.Point(12, 39);
            this.dt_data_atual.Name = "dt_data_atual";
            this.dt_data_atual.Size = new System.Drawing.Size(260, 23);
            this.dt_data_atual.TabIndex = 2;
            // 
            // l_diversos
            // 
            this.l_diversos.AutoSize = true;
            this.l_diversos.Location = new System.Drawing.Point(49, 181);
            this.l_diversos.Name = "l_diversos";
            this.l_diversos.Size = new System.Drawing.Size(51, 15);
            this.l_diversos.TabIndex = 4;
            this.l_diversos.Text = "Diversos";
            // 
            // tb_peso
            // 
            this.tb_peso.Location = new System.Drawing.Point(107, 123);
            this.tb_peso.Name = "tb_peso";
            this.tb_peso.Size = new System.Drawing.Size(100, 23);
            this.tb_peso.TabIndex = 5;
            // 
            // tb_diversos_descricao
            // 
            this.tb_diversos_descricao.Location = new System.Drawing.Point(107, 178);
            this.tb_diversos_descricao.Name = "tb_diversos_descricao";
            this.tb_diversos_descricao.Size = new System.Drawing.Size(100, 23);
            this.tb_diversos_descricao.TabIndex = 6;
            // 
            // l_gr
            // 
            this.l_gr.AutoSize = true;
            this.l_gr.Location = new System.Drawing.Point(213, 126);
            this.l_gr.Name = "l_gr";
            this.l_gr.Size = new System.Drawing.Size(19, 15);
            this.l_gr.TabIndex = 7;
            this.l_gr.Text = "Gr";
            // 
            // bt_salvar
            // 
            this.bt_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_salvar.Location = new System.Drawing.Point(107, 257);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(75, 23);
            this.bt_salvar.TabIndex = 8;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // l_valor_parcial
            // 
            this.l_valor_parcial.AutoSize = true;
            this.l_valor_parcial.Location = new System.Drawing.Point(60, 313);
            this.l_valor_parcial.Name = "l_valor_parcial";
            this.l_valor_parcial.Size = new System.Drawing.Size(96, 15);
            this.l_valor_parcial.TabIndex = 9;
            this.l_valor_parcial.Text = "Valor parcial mês";
            // 
            // l_vlr_parcial
            // 
            this.l_vlr_parcial.AutoSize = true;
            this.l_vlr_parcial.Location = new System.Drawing.Point(162, 313);
            this.l_vlr_parcial.Name = "l_vlr_parcial";
            this.l_vlr_parcial.Size = new System.Drawing.Size(56, 15);
            this.l_vlr_parcial.TabIndex = 10;
            this.l_vlr_parcial.Text = "R$ 500,00";
            // 
            // ll_sobre
            // 
            this.ll_sobre.AutoSize = true;
            this.ll_sobre.Location = new System.Drawing.Point(130, 342);
            this.ll_sobre.Name = "ll_sobre";
            this.ll_sobre.Size = new System.Drawing.Size(37, 15);
            this.ll_sobre.TabIndex = 13;
            this.ll_sobre.TabStop = true;
            this.ll_sobre.Text = "Sobre";
            // 
            // ll_versao
            // 
            this.ll_versao.AutoSize = true;
            this.ll_versao.Location = new System.Drawing.Point(122, 387);
            this.ll_versao.Name = "ll_versao";
            this.ll_versao.Size = new System.Drawing.Size(50, 15);
            this.ll_versao.TabIndex = 14;
            this.ll_versao.TabStop = true;
            this.ll_versao.Text = "Versão 1";
            // 
            // tb_outros_valor
            // 
            this.tb_outros_valor.Location = new System.Drawing.Point(107, 207);
            this.tb_outros_valor.Name = "tb_outros_valor";
            this.tb_outros_valor.Size = new System.Drawing.Size(100, 23);
            this.tb_outros_valor.TabIndex = 15;
            // 
            // l_rs
            // 
            this.l_rs.AutoSize = true;
            this.l_rs.Location = new System.Drawing.Point(80, 210);
            this.l_rs.Name = "l_rs";
            this.l_rs.Size = new System.Drawing.Size(20, 15);
            this.l_rs.TabIndex = 16;
            this.l_rs.Text = "R$";
            // 
            // ll_usuario
            // 
            this.ll_usuario.AutoSize = true;
            this.ll_usuario.Location = new System.Drawing.Point(234, 24);
            this.ll_usuario.Name = "ll_usuario";
            this.ll_usuario.Size = new System.Drawing.Size(17, 15);
            this.ll_usuario.TabIndex = 17;
            this.ll_usuario.Text = "--";
            // 
            // l_vlr_kg
            // 
            this.l_vlr_kg.AutoSize = true;
            this.l_vlr_kg.Location = new System.Drawing.Point(68, 81);
            this.l_vlr_kg.Name = "l_vlr_kg";
            this.l_vlr_kg.Size = new System.Drawing.Size(50, 15);
            this.l_vlr_kg.TabIndex = 18;
            this.l_vlr_kg.Text = "Valor Kg";
            // 
            // l_vlrkg
            // 
            this.l_vlrkg.AutoSize = true;
            this.l_vlrkg.Location = new System.Drawing.Point(135, 81);
            this.l_vlrkg.Name = "l_vlrkg";
            this.l_vlrkg.Size = new System.Drawing.Size(22, 15);
            this.l_vlrkg.TabIndex = 19;
            this.l_vlrkg.Text = "---";
            this.l_vlrkg.TextChanged += new System.EventHandler(this.l_vlrkg_Click);
            this.l_vlrkg.Click += new System.EventHandler(this.l_vlrkg_Click);
            this.l_vlrkg.Enter += new System.EventHandler(this.l_vlrkg_Click);
            // 
            // l_vlrdinamico
            // 
            this.l_vlrdinamico.AutoSize = true;
            this.l_vlrdinamico.Location = new System.Drawing.Point(130, 149);
            this.l_vlrdinamico.Name = "l_vlrdinamico";
            this.l_vlrdinamico.Size = new System.Drawing.Size(22, 15);
            this.l_vlrdinamico.TabIndex = 20;
            this.l_vlrdinamico.Text = "---";
            this.l_vlrdinamico.Click += new System.EventHandler(this.l_vlrdinamico_Click);
            // 
            // tl_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 411);
            this.Controls.Add(this.l_vlrdinamico);
            this.Controls.Add(this.l_vlrkg);
            this.Controls.Add(this.l_vlr_kg);
            this.Controls.Add(this.ll_usuario);
            this.Controls.Add(this.l_rs);
            this.Controls.Add(this.tb_outros_valor);
            this.Controls.Add(this.ll_versao);
            this.Controls.Add(this.ll_sobre);
            this.Controls.Add(this.l_vlr_parcial);
            this.Controls.Add(this.l_valor_parcial);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.l_gr);
            this.Controls.Add(this.tb_diversos_descricao);
            this.Controls.Add(this.tb_peso);
            this.Controls.Add(this.l_diversos);
            this.Controls.Add(this.dt_data_atual);
            this.Controls.Add(this.l_peso);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tl_home";
            this.Text = " Home";
            this.Load += new System.EventHandler(this.tl_home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem alterarSenhaToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private Label l_peso;
        private DateTimePicker dt_data_atual;
        private Label l_diversos;
        private TextBox tb_peso;
        private TextBox tb_diversos_descricao;
        private Label l_gr;
        private Button bt_salvar;
        private Label l_valor_parcial;
        private Label l_vlr_parcial;
        private LinkLabel ll_sobre;
        private LinkLabel ll_versao;
        private ToolStripMenuItem históricoToolStripMenuItem;
        private ToolStripMenuItem outrosMesesToolStripMenuItem;
        private TextBox tb_outros_valor;
        private Label l_rs;
        private ToolStripMenuItem sQLiteToolStripMenuItem;
        private ToolStripMenuItem sQLiteToolStripMenuItem1;
        public Label ll_usuario;
        private Label l_vlr_kg;
        private Label l_vlrkg;
        private Label l_vlrdinamico;
    }
}