namespace WinFormsApp1.Processos
{
    internal class ProcessoLogout
    {
        Processos.ProcessoMsg msg = new Processos.ProcessoMsg();
        public void Logout() {
            tl_home home = new tl_home();
            home.ll_usuario.Text = "---";

            Globais.EstaLogado = false;
            Globais.user = "";
            msg.Bye();
            Login login = new Login();

            if (login.ShowDialog() == DialogResult.OK)
            {
                home.Show();
            }
        }
    }
}
