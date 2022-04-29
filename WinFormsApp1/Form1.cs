namespace WinFormsApp1
{
    public partial class tl_home : Form
    {
        public tl_home()
        {
            InitializeComponent();
            Login login = new Login(this);
            login.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void históricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Historico f_Historico = new F_Historico();
            f_Historico.ShowDialog();
        }

        private void tl_home_Load(object sender, EventArgs e)
        {

        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Dados dados = new Dados();
            dados.data = dt_data_atual.Text;
            dados.peso = tb_peso.Text;
            dados.outrosDiversos = tb_diversos_descricao.Text;
            dados.outrosValor = tb_outros_valor.Text;
        }

        private void sQLiteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_SQLite f_SQLite = new F_SQLite();
            f_SQLite.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ll_usuario.Text = "---";
            Globais.logado = false;

            Login login = new Login(this);
            login.ShowDialog();

            
        }

        private void l_vlrkg_Click(object sender, EventArgs e)
        {
            F_Configuracoes f_Configuracoes = new F_Configuracoes();
            l_vlrkg.Text = f_Configuracoes.tb_vlrkg.Text;
        }

        private void l_vlrdinamico_Click(object sender, EventArgs e)
        {

            F_Configuracoes f_Configuracoes = new F_Configuracoes();
            int valor1 = int.Parse(tb_peso.Text);
            int valor2 = int.Parse(f_Configuracoes.tb_vlrkg.Text);
            int l_vlrdinamico = ((valor1 * valor2) / 1000); 



        }
    }
}