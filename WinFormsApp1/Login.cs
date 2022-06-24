using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string username = tb_username.Text;
            string senha = tb_senha.Text;
            if (username == "")
            {
                MessageBox.Show("Favor digitar o usuario!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_username.Focus();
                return;
            }
            else if (senha == "")
            {
                MessageBox.Show("Favor digite a senha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_senha.Focus();
                return;
            }

            string sql = $"SELECT * FROM tb_usuario WHERE T_USERNAME = '{username}' AND T_SENHA = '{senha}'";
           

            dt = Banco.consulta(sql);
            if (dt.Rows.Count == 1)
            {
                //home.ll_usuario.Text = dt.Rows[0].ItemArray[1].ToString(); outra forma de fazer
                home.ll_usuario.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO");
                Globais.logado = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario ou senha invalidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
                private void tb_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            if (Globais.logado == true)
            {
                tl_home home = new tl_home();
                home.ShowDialog();
            }
            else {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
