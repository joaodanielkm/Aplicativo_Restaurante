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
            this.ll_sobre = new System.Windows.Forms.LinkLabel();
            this.l_username = new System.Windows.Forms.Label();
            this.l_senha = new System.Windows.Forms.Label();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.bt_entrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbx_username = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ll_sobre
            // 
            this.ll_sobre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ll_sobre.AutoSize = true;
            this.ll_sobre.LinkArea = new System.Windows.Forms.LinkArea(0, 10);
            this.ll_sobre.Location = new System.Drawing.Point(73, 209);
            this.ll_sobre.Name = "ll_sobre";
            this.ll_sobre.Size = new System.Drawing.Size(70, 15);
            this.ll_sobre.TabIndex = 5;
            this.ll_sobre.TabStop = true;
            this.ll_sobre.Text = "Como logar";
            this.ll_sobre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(12, 109);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(180, 23);
            this.tb_senha.TabIndex = 2;
            this.tb_senha.Text = "123";
            this.tb_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_senha_KeyDown);
            this.tb_senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_senha_KeyPress);
            // 
            // bt_entrar
            // 
            this.bt_entrar.Location = new System.Drawing.Point(12, 159);
            this.bt_entrar.Name = "bt_entrar";
            this.bt_entrar.Size = new System.Drawing.Size(112, 31);
            this.bt_entrar.TabIndex = 3;
            this.bt_entrar.Text = "Logar";
            this.bt_entrar.UseVisualStyleBackColor = true;
            this.bt_entrar.Click += new System.EventHandler(this.bt_entrar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bt_fechar);
            // 
            // cbx_username
            // 
            this.cbx_username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbx_username.FormattingEnabled = true;
            this.cbx_username.Items.AddRange(new object[] {
            "JOAO"});
            this.cbx_username.Location = new System.Drawing.Point(12, 36);
            this.cbx_username.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cbx_username.Name = "cbx_username";
            this.cbx_username.Size = new System.Drawing.Size(180, 23);
            this.cbx_username.TabIndex = 1;
            this.cbx_username.Text = "JOAO";
            this.cbx_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx_username_KeyDown);
            this.cbx_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbx_username_KeyPress);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 251);
            this.ControlBox = false;
            this.Controls.Add(this.cbx_username);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_entrar);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.l_senha);
            this.Controls.Add(this.l_username);
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
        private LinkLabel ll_sobre;
        private Label l_username;
        private Label l_senha;
        private Button bt_entrar;
        private Button button1;
        public ComboBox cbx_username;
        public TextBox tb_senha;
    }
}