using System.Data;


namespace WinFormsApp1
{
    public partial class tl_home : Form
    {



        F_Configuracoes configuracoes;
        DataTable dt = new DataTable();

        public tl_home()
        {
            InitializeComponent();

            Login login = new Login(this);
            login.ShowDialog();
            if (Globais.logado == false)
            {
                this.Close();
            }


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

            //VLR DEFINIDO EM CONFIGURAÇÕES
            string sql = "select * from tb_configuracoes";

            dt = Banco.consulta(sql);
            l_vlr_peso_atual.Text = "R$ " + dt.Rows[0].ItemArray[1].ToString();

            //GASTOS DO MES
            string total_mes = $"select sum(T_TOTAL_DIARIO) from tb_dados";

            dt = Banco.consulta(total_mes);

            l_vlr_parcial.Text = "R$ " + dt.Rows[0].ItemArray[0].ToString();
            //FIM GASTOS DO MES

            //VERSAO
            ll_versao.Text = "Versão: " + Globais.versao;
            ll_versao.Refresh();

        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {

            double tb_peso1 = Convert.ToDouble(tb_peso.Text);
            F_Configuracoes f_configuracoes = new F_Configuracoes(this);
            double tb_vlr_kg1 = Convert.ToDouble(f_configuracoes.tb_vlr_kg.Text);
            double tb_vlr_pg_empresa1 = Convert.ToDouble(f_configuracoes.tb_vlr_pg_empresa.Text);
            double tb_outros_valor1 = Convert.ToDouble(tb_outros_valor.Text);


            double result1 = (tb_peso1 * tb_vlr_kg1) / 1000;

            result1 = result1 - tb_vlr_pg_empresa1;


            string dt_data_atual1 = dt_data_atual.Text;
            //int tb_peso1 = int.Parse(tb_peso.Text);
            string tb_diversos_descricao1 = tb_diversos_descricao.Text;
            //int tb_outros_valor1 = int.Parse(tb_outros_valor.Text);
            string sql1 = $"SELECT * FROM tb_dados WHERE T_DATA like '{dt_data_atual1}'";
            //string sql = "SELECT * FROM tb_dados";

            dt = Banco.consulta(sql1);
            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("Ja existe lancamento para essa data!");
                //home.ll_usuario.Text = dt.Rows[0].ItemArray[1].ToString(); outra forma de fazer
                if (tb_outros_valor1 > 0)
                {
                    if (!(tb_diversos_descricao1 is null) && tb_diversos_descricao1 != "")
                    {
                        //adiciona o valor do dia na coludo T_TOTAL_DIARIO
                        if (result1 < 0)
                        {

                            double result2 = tb_outros_valor1;
                            string valor_diario = result2.ToString("F2");
                            string sql = $"UPDATE tb_dados SET N_PESO = {tb_peso1}, T_OUTROSDIVERSOS = '{tb_diversos_descricao1}' , N_OUTROSVALOR = {tb_outros_valor1},T_TOTAL_DIARIO = '{valor_diario}' WHERE T_DATA LIKE '{dt_data_atual1}'";
                            //string sql = "SELECT * FROM tb_dados";

                            dt = Banco.consulta(sql);
                            MessageBox.Show("Salvo!");

                        }
                        else
                        {
                            double result2 = result1 + tb_outros_valor1;
                            string valor_diario = result2.ToString("F2");
                            string sql = $"UPDATE tb_dados SET N_PESO = {tb_peso1}, T_OUTROSDIVERSOS = '{tb_diversos_descricao1}' , N_OUTROSVALOR = {tb_outros_valor1},T_TOTAL_DIARIO = '{valor_diario}'  WHERE T_DATA LIKE '{dt_data_atual1}'";
                            //string sql = "SELECT * FROM tb_dados";

                            dt = Banco.consulta(sql);
                            MessageBox.Show("Salvo!");

                        }




                        ///final da adicao

                    }
                    else
                    {
                        MessageBox.Show("Favor informar a descricao do diversos!");
                    }
                }
                else
                {
                    if (result1 < 0)
                    {

                        double result2 = tb_outros_valor1;
                        string valor_diario = result2.ToString("F2");
                        string sql = $"UPDATE tb_dados SET N_PESO = {tb_peso1}, T_OUTROSDIVERSOS = '{tb_diversos_descricao1}' , N_OUTROSVALOR = {tb_outros_valor1},T_TOTAL_DIARIO = '{valor_diario}' WHERE T_DATA LIKE '{dt_data_atual1}'";
                        //string sql = "SELECT * FROM tb_dados";

                        dt = Banco.consulta(sql);
                        MessageBox.Show("Salvo!");
                    }
                    else
                    {
                        double result2 = result1 + tb_outros_valor1;
                        string valor_diario = result2.ToString("F2");
                        string sql = $"UPDATE tb_dados SET N_PESO = {tb_peso1}, T_OUTROSDIVERSOS = '{tb_diversos_descricao1}' , N_OUTROSVALOR = {tb_outros_valor1},T_TOTAL_DIARIO = '{valor_diario}' WHERE T_DATA LIKE '{dt_data_atual1}'";
                        //string sql = "SELECT * FROM tb_dados";

                        dt = Banco.consulta(sql);
                        MessageBox.Show("Salvo!");
                    }
                }
                //this.Close();
            }

            else
            {






                if (tb_peso1 <= 0)
                {
                    MessageBox.Show("Favor informar o peso!");

                }
                else
                {
                    if (tb_outros_valor1 > 0)
                    {
                        if (!(tb_diversos_descricao1 is null) && tb_diversos_descricao1 != "")
                        {
                            if (result1 < 0)
                            {

                                double result2 = tb_outros_valor1;
                                string valor_diario = result2.ToString("F2");

                                string sql = $"INSERT INTO tb_dados (T_DATA,N_PESO,T_OUTROSDIVERSOS,N_OUTROSVALOR,T_TOTAL_DIARIO) VALUES ('{dt_data_atual1}',{tb_peso1},'{tb_diversos_descricao1}',{tb_outros_valor1},'{valor_diario}')";
                                //string sql = "SELECT * FROM tb_dados";

                                dt = Banco.consulta(sql);
                                MessageBox.Show("Salvo!");
                            }
                            else
                            {
                                double result2 = result1 + tb_outros_valor1;
                                string valor_diario = result2.ToString("F2");
                                string sql = $"INSERT INTO tb_dados (T_DATA,N_PESO,T_OUTROSDIVERSOS,N_OUTROSVALOR,T_TOTAL_DIARIO) VALUES ('{dt_data_atual1}',{tb_peso1},'{tb_diversos_descricao1}',{tb_outros_valor1},'{valor_diario}')";
                                //string sql = "SELECT * FROM tb_dados";

                                dt = Banco.consulta(sql);
                                MessageBox.Show("Salvo!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Favor informar a descricao do diversos!");
                        }
                    }
                    else
                    {
                        if (result1 < 0)
                        {

                            double result2 = tb_outros_valor1;
                            string valor_diario = result2.ToString("F2");
                            string sql = $"INSERT INTO tb_dados (T_DATA,N_PESO,T_OUTROSDIVERSOS,N_OUTROSVALOR,T_TOTAL_DIARIO) VALUES ('{dt_data_atual1}',{tb_peso1},'{tb_diversos_descricao1}',{tb_outros_valor1},'{valor_diario}')";
                            //string sql = "SELECT * FROM tb_dados";

                            dt = Banco.consulta(sql);
                            MessageBox.Show("Salvo!");
                        }
                        else
                        {
                            double result2 = result1 + tb_outros_valor1;
                            string valor_diario = result2.ToString("F2");
                            string sql = $"INSERT INTO tb_dados (T_DATA,N_PESO,T_OUTROSDIVERSOS,N_OUTROSVALOR,T_TOTAL_DIARIO) VALUES ('{dt_data_atual1}',{tb_peso1},'{tb_diversos_descricao1}',{tb_outros_valor1},'{valor_diario}')";
                            //string sql = "SELECT * FROM tb_dados";

                            dt = Banco.consulta(sql);
                            MessageBox.Show("Salvo!");
                        }
                    }
                }
            }
            /*
            Dados dados = new Dados();
            dados.data = dt_data_atual.Text;
            dados.peso = tb_peso.Text;
            dados.outrosDiversos = tb_diversos_descricao.Text;
            dados.outrosValor = tb_outros_valor.Text;*/
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

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Configuracoes f_Configuracoes = new F_Configuracoes(this);
            f_Configuracoes.ShowDialog();
        }

        private void l_vlr_peso_atual_Click(object sender, EventArgs e)
        {
            /*F_Configuracoes f_Configuracoes = new F_Configuracoes(this);
            l_vlr_peso_atual.Text = f_Configuracoes.tb_vlr_kg.Text;*/

        }

        private void l_vlrparcial_Click(object sender, EventArgs e)
        {
            //incrementar esse bloco todo novamente sem chamar os objetos de outro formulario, e sem do banco de dados

            string sql = "select * from tb_configuracoes";

            dt = Banco.consulta(sql);
            l_vlr_peso_atual.Text = dt.Rows[0].ItemArray[1].ToString();



            double vari = Convert.ToDouble(l_vlr_peso_atual.Text);




            
            double tb_peso1 = Convert.ToDouble(tb_peso.Text);
            F_Configuracoes f_configuracoes = new F_Configuracoes(this);
            vari = Convert.ToDouble(f_configuracoes.tb_vlr_kg.Text);
            double tb_vlr_pg_empresa1 = Convert.ToDouble(f_configuracoes.tb_vlr_pg_empresa.Text);
            double tb_outros_valor1 = Convert.ToDouble(tb_outros_valor.Text);

            /*F_Configuracoes f_configuracoes = new F_Configuracoes(this);
            double l_vlr_peso_atual1 = Convert.ToDouble(f_configuracoes.tb_vlr_kg.Text);
            double tb_vlr_pg_empresa1 = Convert.ToDouble(f_configuracoes.tb_vlr_pg_empresa.Text);
            double tb_outros_valor1 = Convert.ToDouble(tb_outros_valor.Text);
            */
            double result1 = (tb_peso1 * vari) / 1000;

            result1 = result1 - tb_vlr_pg_empresa1;
            if (result1 < 0)
            {

                double result2 = tb_outros_valor1;
                l_vlrparcial.Text = "R$ " + result2.ToString("F2");


            }
            else
            {
                double result2 = result1 + tb_outros_valor1;
                l_vlrparcial.Text = "R$ " + result2.ToString("F2");


            }
            //recalcula valor do kg calculado na configuração
            //F_Configuracoes f_Configuracoes = new F_Configuracoes(this);
            //l_vlr_peso_atual.Text = "R$ " + f_Configuracoes.tb_vlr_kg.Text;


            //l_vlrparcial.Refresh();
        }

        private void dt_data_atual_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void l_vlr_parcial_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string total_mes = $"select sum(T_TOTAL_DIARIO) from tb_dados";

            dt = Banco.consulta(total_mes);

            l_vlr_parcial.Text = "R$ " + double.Parse(dt.Rows[0].ItemArray[0].ToString());

            F_Configuracoes f_Configuracoes = new F_Configuracoes(this);
            l_vlr_peso_atual.Text = "R$ " + f_Configuracoes.tb_vlr_kg.Text;
        }

        private void ll_versao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ll_versao.Text = "Versão: " + Globais.versao;
            ll_versao.Refresh();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void l_vlrkg_Click(object sender, EventArgs e)
        {
            /*F_Configuracoes f_Configuracoes = new F_Configuracoes(this);
            // l_vlrkg.Text = f_Configuracoes.tb_vlrkg.Text;*/
        }

        private void l_vlrdinamico_Click(object sender, EventArgs e)
        {

            /*F_Configuracoes f_Configuracoes = new F_Configuracoes(this);
            int valor1 = int.Parse(tb_peso.Text);
            //int valor2 = int.Parse(f_Configuracoes.tb_vlrkg.Text);
            //int l_vlrdinamico = ((valor1 * valor2) / 1000); */



        }
    }
}