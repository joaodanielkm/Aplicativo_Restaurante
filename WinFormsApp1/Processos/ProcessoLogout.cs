namespace WinFormsApp1.Processos
{
    internal class ProcessoLogout
    {
        Processos.ProcessoMsg msg = new Processos.ProcessoMsg();

        public void Logout() {
            //tl_home home = new tl_home();
            //F_Historico historico = new F_Historico();
            //Login login = new Login(home);
            //home.ll_usuario.Text = "---";
            //Globais.logado = false;
            //Globais.user = "";
            //home.ShowDialog();
            msg.Bye();
            Application.Exit();
        }
    }
}
