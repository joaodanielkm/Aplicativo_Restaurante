namespace WinFormsApp1.Processos
{
    internal class ProcessoLogout
    {
        Processos.ProcessoMsg msg = new Processos.ProcessoMsg();
        tl_home home = new tl_home();
        Form login = new Form();
        

        public void Logout() {
            
            home.ll_usuario.Text = "---";
            Globais.logado = false;
            Globais.user = "";
            home.Hide();
            msg.Bye();
            login.ShowDialog();
        }
    }
}