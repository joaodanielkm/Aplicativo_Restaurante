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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // tb_vlr_kg
            // 
            this.tb_vlr_kg.Location = new System.Drawing.Point(114, 74);
            this.tb_vlr_kg.Name = "tb_vlr_kg";
            this.tb_vlr_kg.Size = new System.Drawing.Size(100, 23);
            this.tb_vlr_kg.TabIndex = 0;
            this.tb_vlr_kg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_vlr_kg.TextChanged += new System.EventHandler(this.F_Configuracoes_Load);
            // 
            // tb_vlr_pg_empresa
            // 
            this.tb_vlr_pg_empresa.Location = new System.Drawing.Point(114, 141);
            this.tb_vlr_pg_empresa.Name = "tb_vlr_pg_empresa";
            this.tb_vlr_pg_empresa.Size = new System.Drawing.Size(100, 23);
            this.tb_vlr_pg_empresa.TabIndex = 1;
            this.tb_vlr_pg_empresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_vlr_pg_empresa.TextChanged += new System.EventHandler(this.tb_vlr_pg_empresa_TextChanged);
            // 
            // bt_salvar
            // 
            this.bt_salvar.Location = new System.Drawing.Point(99, 214);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(75, 23);
            this.bt_salvar.TabIndex = 2;
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
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(290, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";

            // 
            // F_Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 411);

            this.Controls.Add(this.l_pg_empresa);
            this.Controls.Add(this.l_vlr_kg);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.tb_vlr_pg_empresa);
            this.Controls.Add(this.tb_vlr_kg);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Configuracoes";
            this.Text = "Configuracoes";
            this.Load += new System.EventHandler(this.F_Configuracoes_Load);

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        public TextBox tb_vlr_kg;
        public TextBox tb_vlr_pg_empresa;
        private Button bt_salvar;
        private Label l_vlr_kg;
        private Label l_pg_empresa;
        private MenuStrip menuStrip1;

    }
}