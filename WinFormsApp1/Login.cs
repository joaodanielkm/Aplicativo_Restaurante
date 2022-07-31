using System.Data;


namespace WinFormsApp1
{
    public partial class Login : Form
    {
        tl_home home;
        DataTable dt = new DataTable();
        public Login(tl_home h)
        {
            InitializeComponent();
            home = h;
        }

        private void bt_entrar_Click(object sender, EventArgs e)
        {
            string username = cbx_username.Text;
            string senha = tb_senha.Text;

            var processoLogin = new Processos.ProcessoLogin();
            var processoValidaLogin = new Processos.ProcessoValidaCampoLogin();
            processoValidaLogin.EhValidaInformacaoDeLoguin(username, senha);
            //var obtenhaLogins = processoLogin.ObtenhaLogins(username, senha);

            if (!processoValidaLogin.EhValidaInformacaoDeLoguin(username, senha))
            {
                cbx_username.Focus();
                MessageBox.Show("Favor digitar usuário e senha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            var obtenhaLogins = new Mapeadores.MapeadorDeLogin() ;
            dt = obtenhaLogins.ObtenhaLogins(username, senha);
            if (processoValidaLogin.EhValidaInformacaoDeLoguin(username, senha))
            {
                if (dt.Rows.Count == 1)
                {
                    home.ll_usuario.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO");
                    Globais.logado = true;
                    Globais.user = home.ll_usuario.Text;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario ou senha invalidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cbx_username.Focus();
        }
        //private void tb_username_TextChanged(object sender, EventArgs e)
        //{
        //    //cbx_username.CharacterCasing = CharacterCasing.Upper;
        //}

        private void Login_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            if (Globais.logado == true)
            {
                tl_home home = new tl_home();
                home.ShowDialog();
            }
            else
            {
                Application.Exit();
            }
        }

        private void bt_fechar(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tb_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || (char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            };
        }

        private void tb_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            };
        }

        private void tb_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tb_senha.Focus();
            };
        }

        private void tb_senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_entrar.Focus();
            };
        }

        private void cbx_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tb_senha.Focus();
            };
        }

        private void cbx_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || (char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            };
        }
    }
}
