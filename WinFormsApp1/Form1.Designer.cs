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
            this.históricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outrosMesesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.l_peso = new System.Windows.Forms.Label();
            this.dt_data_atual = new System.Windows.Forms.DateTimePicker();
            this.l_diversos = new System.Windows.Forms.Label();
            this.tb_peso = new System.Windows.Forms.TextBox();
            this.tb_diversos_descricao = new System.Windows.Forms.TextBox();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.l_valor_parcial = new System.Windows.Forms.Label();
            this.l_vlr_parcial = new System.Windows.Forms.Label();
            this.ll_sobre = new System.Windows.Forms.LinkLabel();
            this.ll_versao = new System.Windows.Forms.LinkLabel();
            this.tb_outros_valor = new System.Windows.Forms.TextBox();
            this.l_rs = new System.Windows.Forms.Label();
            this.ll_usuario = new System.Windows.Forms.Label();
            this.l_valor_peso = new System.Windows.Forms.Label();
            this.l_vlr_peso_atual = new System.Windows.Forms.Label();
            this.l_vlrparcial = new System.Windows.Forms.Label();
            this.bt_calcular = new System.Windows.Forms.Button();
            this.l_gastodehoje = new System.Windows.Forms.Label();
            this.bt_carregar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(290, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.históricoToolStripMenuItem,
            this.outrosMesesToolStripMenuItem,
            this.configuraçõesToolStripMenuItem,
            this.alterarSenhaToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // históricoToolStripMenuItem
            // 
            this.históricoToolStripMenuItem.Name = "históricoToolStripMenuItem";
            this.históricoToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.históricoToolStripMenuItem.Text = "Histórico";
            this.históricoToolStripMenuItem.Click += new System.EventHandler(this.históricoToolStripMenuItem_Click);
            // 
            // outrosMesesToolStripMenuItem
            // 
            this.outrosMesesToolStripMenuItem.Name = "outrosMesesToolStripMenuItem";
            this.outrosMesesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.outrosMesesToolStripMenuItem.Text = "Outros Meses";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            this.configuraçõesToolStripMenuItem.Click += new System.EventHandler(this.configuraçõesToolStripMenuItem_Click);
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.alterarSenhaToolStripMenuItem.Text = "Alterar Senha";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // l_peso
            // 
            this.l_peso.AutoSize = true;
            this.l_peso.Location = new System.Drawing.Point(33, 126);
            this.l_peso.Name = "l_peso";
            this.l_peso.Size = new System.Drawing.Size(95, 15);
            this.l_peso.TabIndex = 1;
            this.l_peso.Text = "Peso em Gramas";
            this.l_peso.Click += new System.EventHandler(this.label1_Click);
            // 
            // dt_data_atual
            // 
            this.dt_data_atual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_data_atual.Location = new System.Drawing.Point(109, 48);
            this.dt_data_atual.Name = "dt_data_atual";
            this.dt_data_atual.Size = new System.Drawing.Size(78, 23);
            this.dt_data_atual.TabIndex = 2;
            this.dt_data_atual.ValueChanged += new System.EventHandler(this.dt_data_atual_ValueChanged);
            // 
            // l_diversos
            // 
            this.l_diversos.AutoSize = true;
            this.l_diversos.Location = new System.Drawing.Point(33, 181);
            this.l_diversos.Name = "l_diversos";
            this.l_diversos.Size = new System.Drawing.Size(51, 15);
            this.l_diversos.TabIndex = 4;
            this.l_diversos.Text = "Diversos";
            // 
            // tb_peso
            // 
            this.tb_peso.Location = new System.Drawing.Point(150, 126);
            this.tb_peso.Name = "tb_peso";
            this.tb_peso.Size = new System.Drawing.Size(100, 23);
            this.tb_peso.TabIndex = 5;
            this.tb_peso.Text = "0";
            this.tb_peso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_diversos_descricao
            // 
            this.tb_diversos_descricao.Location = new System.Drawing.Point(90, 178);
            this.tb_diversos_descricao.Name = "tb_diversos_descricao";
            this.tb_diversos_descricao.Size = new System.Drawing.Size(160, 23);
            this.tb_diversos_descricao.TabIndex = 6;
            // 
            // bt_salvar
            // 
            this.bt_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_salvar.Location = new System.Drawing.Point(193, 319);
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
            this.l_valor_parcial.Location = new System.Drawing.Point(58, 268);
            this.l_valor_parcial.Name = "l_valor_parcial";
            this.l_valor_parcial.Size = new System.Drawing.Size(96, 15);
            this.l_valor_parcial.TabIndex = 9;
            this.l_valor_parcial.Text = "Valor parcial mês";
            // 
            // l_vlr_parcial
            // 
            this.l_vlr_parcial.AutoSize = true;
            this.l_vlr_parcial.Location = new System.Drawing.Point(184, 268);
            this.l_vlr_parcial.Name = "l_vlr_parcial";
            this.l_vlr_parcial.Size = new System.Drawing.Size(22, 15);
            this.l_vlr_parcial.TabIndex = 10;
            this.l_vlr_parcial.Text = "---";
            this.l_vlr_parcial.Click += new System.EventHandler(this.l_vlr_parcial_Click);
            // 
            // ll_sobre
            // 
            this.ll_sobre.AutoSize = true;
            this.ll_sobre.Location = new System.Drawing.Point(127, 360);
            this.ll_sobre.Name = "ll_sobre";
            this.ll_sobre.Size = new System.Drawing.Size(37, 15);
            this.ll_sobre.TabIndex = 13;
            this.ll_sobre.TabStop = true;
            this.ll_sobre.Text = "Sobre";
            // 
            // ll_versao
            // 
            this.ll_versao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ll_versao.AutoSize = true;
            this.ll_versao.Location = new System.Drawing.Point(136, 375);
            this.ll_versao.Name = "ll_versao";
            this.ll_versao.Size = new System.Drawing.Size(17, 15);
            this.ll_versao.TabIndex = 14;
            this.ll_versao.TabStop = true;
            this.ll_versao.Text = "--";
            this.ll_versao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ll_versao.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_versao_LinkClicked);
            // 
            // tb_outros_valor
            // 
            this.tb_outros_valor.Location = new System.Drawing.Point(150, 207);
            this.tb_outros_valor.Name = "tb_outros_valor";
            this.tb_outros_valor.Size = new System.Drawing.Size(100, 23);
            this.tb_outros_valor.TabIndex = 15;
            this.tb_outros_valor.Text = "0";
            this.tb_outros_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // l_rs
            // 
            this.l_rs.AutoSize = true;
            this.l_rs.Location = new System.Drawing.Point(124, 210);
            this.l_rs.Name = "l_rs";
            this.l_rs.Size = new System.Drawing.Size(20, 15);
            this.l_rs.TabIndex = 16;
            this.l_rs.Text = "R$";
            // 
            // ll_usuario
            // 
            this.ll_usuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ll_usuario.AutoSize = true;
            this.ll_usuario.Location = new System.Drawing.Point(12, 24);
            this.ll_usuario.Name = "ll_usuario";
            this.ll_usuario.Size = new System.Drawing.Size(17, 15);
            this.ll_usuario.TabIndex = 17;
            this.ll_usuario.Text = "--";
            // 
            // l_valor_peso
            // 
            this.l_valor_peso.AutoSize = true;
            this.l_valor_peso.Location = new System.Drawing.Point(92, 92);
            this.l_valor_peso.Name = "l_valor_peso";
            this.l_valor_peso.Size = new System.Drawing.Size(61, 15);
            this.l_valor_peso.TabIndex = 18;
            this.l_valor_peso.Text = "Valor Peso";
            // 
            // l_vlr_peso_atual
            // 
            this.l_vlr_peso_atual.AutoSize = true;
            this.l_vlr_peso_atual.Location = new System.Drawing.Point(175, 92);
            this.l_vlr_peso_atual.Name = "l_vlr_peso_atual";
            this.l_vlr_peso_atual.Size = new System.Drawing.Size(22, 15);
            this.l_vlr_peso_atual.TabIndex = 19;
            this.l_vlr_peso_atual.Text = "---";
            this.l_vlr_peso_atual.Click += new System.EventHandler(this.l_vlr_peso_atual_Click);
            // 
            // l_vlrparcial
            // 
            this.l_vlrparcial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.l_vlrparcial.AutoSize = true;
            this.l_vlrparcial.Location = new System.Drawing.Point(184, 240);
            this.l_vlrparcial.Name = "l_vlrparcial";
            this.l_vlrparcial.Size = new System.Drawing.Size(22, 15);
            this.l_vlrparcial.TabIndex = 20;
            this.l_vlrparcial.Text = "---";
            this.l_vlrparcial.Click += new System.EventHandler(this.l_vlrparcial_Click);
            // 
            // bt_calcular
            // 
            this.bt_calcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_calcular.Location = new System.Drawing.Point(112, 319);
            this.bt_calcular.Name = "bt_calcular";
            this.bt_calcular.Size = new System.Drawing.Size(75, 23);
            this.bt_calcular.TabIndex = 21;
            this.bt_calcular.Text = "Calcular";
            this.bt_calcular.UseVisualStyleBackColor = true;
            this.bt_calcular.Click += new System.EventHandler(this.l_vlrparcial_Click);
            // 
            // l_gastodehoje
            // 
            this.l_gastodehoje.AutoSize = true;
            this.l_gastodehoje.Location = new System.Drawing.Point(58, 240);
            this.l_gastodehoje.Name = "l_gastodehoje";
            this.l_gastodehoje.Size = new System.Drawing.Size(79, 15);
            this.l_gastodehoje.TabIndex = 22;
            this.l_gastodehoje.Text = "Gasto de hoje";
            // 
            // bt_carregar
            // 
            this.bt_carregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_carregar.Location = new System.Drawing.Point(31, 319);
            this.bt_carregar.Name = "bt_carregar";
            this.bt_carregar.Size = new System.Drawing.Size(75, 23);
            this.bt_carregar.TabIndex = 23;
            this.bt_carregar.Text = "Carregar";
            this.bt_carregar.UseVisualStyleBackColor = true;
            this.bt_carregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tl_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 411);
            this.Controls.Add(this.bt_carregar);
            this.Controls.Add(this.l_gastodehoje);
            this.Controls.Add(this.bt_calcular);
            this.Controls.Add(this.l_vlrparcial);
            this.Controls.Add(this.l_vlr_peso_atual);
            this.Controls.Add(this.l_valor_peso);
            this.Controls.Add(this.ll_usuario);
            this.Controls.Add(this.l_rs);
            this.Controls.Add(this.tb_outros_valor);
            this.Controls.Add(this.ll_versao);
            this.Controls.Add(this.ll_sobre);
            this.Controls.Add(this.l_vlr_parcial);
            this.Controls.Add(this.l_valor_parcial);
            this.Controls.Add(this.bt_salvar);
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
        private Button bt_salvar;
        private Label l_valor_parcial;
        private Label l_vlr_parcial;
        private LinkLabel ll_sobre;
        private LinkLabel ll_versao;
        private ToolStripMenuItem históricoToolStripMenuItem;
        private ToolStripMenuItem outrosMesesToolStripMenuItem;
        private TextBox tb_outros_valor;
        private Label l_rs;
        public Label ll_usuario;

        private Label l_valor_peso;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        public Label l_vlr_peso_atual;
        private Label l_vlrparcial;
        private Button bt_calcular;
        private Label l_gastodehoje;
        private Button bt_carregar;

    }
}