namespace WinFormsApp1
{
    partial class Login
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
            this.ll_versao = new System.Windows.Forms.LinkLabel();
            this.ll_sobre = new System.Windows.Forms.LinkLabel();
            this.l_username = new System.Windows.Forms.Label();
            this.l_senha = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.bt_entrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ll_versao
            // 
            this.ll_versao.AutoSize = true;
            this.ll_versao.Location = new System.Drawing.Point(79, 250);
            this.ll_versao.Name = "ll_versao";
            this.ll_versao.Size = new System.Drawing.Size(50, 15);
            this.ll_versao.TabIndex = 16;
            this.ll_versao.TabStop = true;
            this.ll_versao.Text = "Versão 1";
            // 
            // ll_sobre
            // 
            this.ll_sobre.AutoSize = true;
            this.ll_sobre.Location = new System.Drawing.Point(87, 205);
            this.ll_sobre.Name = "ll_sobre";
            this.ll_sobre.Size = new System.Drawing.Size(37, 15);
            this.ll_sobre.TabIndex = 15;
            this.ll_sobre.TabStop = true;
            this.ll_sobre.Text = "Sobre";
            // 
            // l_username
            // 
            this.l_username.AutoSize = true;
            this.l_username.Location = new System.Drawing.Point(12, 9);
            this.l_username.Name = "l_username";
            this.l_username.Size = new System.Drawing.Size(47, 15);
            this.l_username.TabIndex = 17;
            this.l_username.Text = "Usuario";
            // 
            // l_senha
            // 
            this.l_senha.AutoSize = true;
            this.l_senha.Location = new System.Drawing.Point(12, 81);
            this.l_senha.Name = "l_senha";
            this.l_senha.Size = new System.Drawing.Size(39, 15);
            this.l_senha.TabIndex = 18;
            this.l_senha.Text = "Senha";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(15, 31);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(180, 23);
            this.tb_username.TabIndex = 19;
            this.tb_username.Tag = "";
            this.tb_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_username.TextChanged += new System.EventHandler(this.tb_username_TextChanged);
            this.tb_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_username_KeyPress);
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(15, 108);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(180, 23);
            this.tb_senha.TabIndex = 20;
            this.tb_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_senha_KeyPress);
            // 
            // bt_entrar
            // 
            this.bt_entrar.Location = new System.Drawing.Point(12, 159);
            this.bt_entrar.Name = "bt_entrar";
            this.bt_entrar.Size = new System.Drawing.Size(112, 31);
            this.bt_entrar.TabIndex = 21;
            this.bt_entrar.Text = "Logar";
            this.bt_entrar.UseVisualStyleBackColor = true;
            this.bt_entrar.Click += new System.EventHandler(this.bt_entrar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 32);
            this.button1.TabIndex = 22;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bt_fechar);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 251);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_entrar);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.l_senha);
            this.Controls.Add(this.l_username);
            this.Controls.Add(this.ll_versao);
            this.Controls.Add(this.ll_sobre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed_1);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel ll_versao;
        private LinkLabel ll_sobre;
        private Label l_username;
        private Label l_senha;
        private TextBox tb_username;
        private TextBox tb_senha;
        private Button bt_entrar;
        private Button button1;
    }
}