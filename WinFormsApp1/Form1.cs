using System.Data;
using System.Globalization;
using System.Windows;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class tl_home : Form
    {



        F_Configuracoes configuracoes;
        DataTable dt = new DataTable();

        public tl_home()
        {
            InitializeComponent();



            if (Globais.logado == false)
            {
                Login login = new Login(this);

                login.ShowDialog();
                this.Hide();


            }


        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hist�ricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Historico f_Historico = new F_Historico();
            f_Historico.ShowDialog();
        }

        private void tl_home_Load(object sender, EventArgs e)
        {
            tb_outros_valor.Visible = false;

            //Perciste usuario logado
            ll_usuario.Text = Globais.user;



            //VLR DEFINIDO EM CONFIGURA��ES
            string sql = "select * from tb_configuracoes";

            dt = Banco.consulta(sql);
            l_vlr_peso_atual.Text =  Convert.ToDouble(dt.Rows[0].ItemArray[1]).ToString("C2");

            //GASTOS DO MES
            string total_mes = $"select sum(T_TOTAL_DIARIO) from tb_dados";

            dt = Banco.consulta(total_mes);

            //CONVERSAO DO TIPO
            l_vlr_parcial.Text =  Convert.ToDouble(dt.Rows[0].ItemArray[0]).ToString("C2");

            

            //FIM GASTOS DO MES

            //VERSAO
            ll_versao.Text = "Vers�o: " + Globais.versao;
            ll_versao.Refresh();

        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            String convertePonto = tb_outros_valor.Text;

            convertePonto = convertePonto.Replace(".", ",");

            double convertePonto1 = Convert.ToDouble(convertePonto);


            string sql = "select * from tb_configuracoes";

            dt = Banco.consulta(sql);
            string tb_vlr_pg_empresa1 = dt.Rows[0].ItemArray[2].ToString();
            string tb_vlr_kg1 = dt.Rows[0].ItemArray[1].ToString();
            string l_vlr_peso_atual1 = dt.Rows[0].ItemArray[1].ToString();
            double pesoAtual = Convert.ToDouble(l_vlr_peso_atual1);


            //double vlrEmpresa = Convert.ToDouble(l_vlr_peso_atual.Text);


            double pesoDigitado = Convert.ToDouble(tb_peso1.Text);
            double pagoEmpresa = Convert.ToDouble(tb_vlr_pg_empresa1);
            //double tb_outros_valor1 = Convert.ToDouble(this.tb_outros_valor.Text);

            double result1 = (pesoDigitado * pesoAtual) / 1000;


            result1 = (result1 - pagoEmpresa);
            string tb_diversos_descricao1 = tb_diversos_descricao.Text;

            //VERIFICA SE EXISTE LAN�AMENTO NA DATA
            string dt_data_atual1 = dt_data_atual.Text;
            string sql1 = $"SELECT * FROM tb_dados WHERE T_DATA like '{dt_data_atual1}'";
            dt = Banco.consulta(sql1);

            if (dt.Rows.Count >= 1)
            {
                var mensg = MessageBox.Show("Ja existe lancamento para essa data! Deseja Alterar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (mensg == DialogResult.Yes)
                {


                    //home.ll_usuario.Text = dt.Rows[0].ItemArray[1].ToString(); outra forma de fazer
                    if (convertePonto1 > 0)
                    {
                        if (!(tb_diversos_descricao1 is null) && tb_diversos_descricao1 != "")
                        {
                            //adiciona o valor do dia na coludo T_TOTAL_DIARIO
                            if (result1 < 0)
                            {

                                double result2 = convertePonto1;
                                string valor_diario = result2.ToString("F2", CultureInfo.InvariantCulture);
                                string sql2 = $"UPDATE tb_dados SET N_PESO = {pesoDigitado}, T_OUTROSDIVERSOS = '{tb_diversos_descricao1}' , N_OUTROSVALOR = '{convertePonto}',T_TOTAL_DIARIO = '{valor_diario}' WHERE T_DATA LIKE '{dt_data_atual1}'";
                                //string sql = "SELECT * FROM tb_dados";

                                dt = Banco.consulta(sql2);
                                MessageBox.Show("Salvo!", "Lan�amento", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                double result2 = result1 + convertePonto1;
                                string valor_diario = result2.ToString("F2", CultureInfo.InvariantCulture);
                                string sql2 = $"UPDATE tb_dados SET N_PESO = {pesoDigitado}, T_OUTROSDIVERSOS = '{tb_diversos_descricao1}' , N_OUTROSVALOR ='{convertePonto}',T_TOTAL_DIARIO = '{valor_diario}'  WHERE T_DATA LIKE '{dt_data_atual1}'";
                                //string sql = "SELECT * FROM tb_dados";

                                dt = Banco.consulta(sql2);
                                MessageBox.Show("Salvo!", "Lan�amento", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }


                            ///final da adicao

                        }
                        else
                        {
                            MessageBox.Show("Favor informar a descricao do diversos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        if (result1 < 0)
                        {

                            double result2 = convertePonto1;
                            string valor_diario = result2.ToString("F2", CultureInfo.InvariantCulture);
                            string sql2 = $"UPDATE tb_dados SET N_PESO = {pesoDigitado}, T_OUTROSDIVERSOS = '{tb_diversos_descricao1}' , N_OUTROSVALOR = '{convertePonto}',T_TOTAL_DIARIO = '{valor_diario}' WHERE T_DATA LIKE '{dt_data_atual1}'";
                            //string sql = "SELECT * FROM tb_dados";

                            dt = Banco.consulta(sql2);
                            MessageBox.Show("Salvo!", "Lan�amento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            double result2 = result1 + convertePonto1;
                            string valor_diario = result2.ToString("F2", CultureInfo.InvariantCulture);
                            string sql2 = $"UPDATE tb_dados SET N_PESO = {pesoDigitado}, T_OUTROSDIVERSOS = '{tb_diversos_descricao1}' , N_OUTROSVALOR = '{convertePonto}',T_TOTAL_DIARIO = '{valor_diario}' WHERE T_DATA LIKE '{dt_data_atual1}'";
                            //string sql = "SELECT * FROM tb_dados";

                            dt = Banco.consulta(sql2);
                            MessageBox.Show("Salvo!", "Lan�amento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    //this.Close();
                }

            }

            else
            {


                if (pesoDigitado < 0)//PESO DIGITADO MENOR QUE 0
                {
                    MessageBox.Show("Favor informar o peso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
                else
                {
                    if (convertePonto1 > 0)
                    {
                        if (!(tb_diversos_descricao1 is null) && tb_diversos_descricao1 != "")
                        {
                            if (result1 < 0)
                            {

                                double result2 = convertePonto1;
                                string valor_diario = result2.ToString("F2", CultureInfo.InvariantCulture);

                                string sql2 = $"INSERT INTO tb_dados (T_DATA,N_PESO,T_OUTROSDIVERSOS,N_OUTROSVALOR,T_TOTAL_DIARIO) VALUES ('{dt_data_atual1}',{pesoDigitado},'{tb_diversos_descricao1}','{convertePonto}','{valor_diario}')";
                                //string sql = "SELECT * FROM tb_dados";

                                dt = Banco.consulta(sql2);
                                MessageBox.Show("Salvo!", "Lan�amento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                double result2 = result1 + convertePonto1;
                                string valor_diario = result2.ToString("F2", CultureInfo.InvariantCulture);
                                string sql2 = $"INSERT INTO tb_dados (T_DATA,N_PESO,T_OUTROSDIVERSOS,N_OUTROSVALOR,T_TOTAL_DIARIO) VALUES ('{dt_data_atual1}',{pesoDigitado},'{tb_diversos_descricao1}','{convertePonto}','{valor_diario}')";
                                //string sql = "SELECT * FROM tb_dados";

                                dt = Banco.consulta(sql2);
                                MessageBox.Show("Salvo!", "Lan�amento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Favor informar a descricao do diversos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        if (result1 < 0)
                        {

                            double result2 = convertePonto1;
                            string valor_diario = result2.ToString("F2", CultureInfo.InvariantCulture);
                            string sql2 = $"INSERT INTO tb_dados (T_DATA,N_PESO,T_OUTROSDIVERSOS,N_OUTROSVALOR,T_TOTAL_DIARIO) VALUES ('{dt_data_atual1}',{pesoDigitado},'{tb_diversos_descricao1}','{convertePonto}','{valor_diario}')";
                            //string sql = "SELECT * FROM tb_dados";

                            dt = Banco.consulta(sql2);
                            MessageBox.Show("Salvo!", "Lan�amento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            double result2 = result1 + convertePonto1;
                            string valor_diario = result2.ToString("F2", CultureInfo.InvariantCulture);
                            string sql2 = $"INSERT INTO tb_dados (T_DATA,N_PESO,T_OUTROSDIVERSOS,N_OUTROSVALOR,T_TOTAL_DIARIO) VALUES ('{dt_data_atual1}',{pesoDigitado},'{tb_diversos_descricao1}','{convertePonto}','{valor_diario}')";
                            //string sql = "SELECT * FROM tb_dados";

                            dt = Banco.consulta(sql2);
                            MessageBox.Show("Salvo!", "Lan�amento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }



            //GASTOS DO MES
            string total_mes = $"select sum(T_TOTAL_DIARIO) from tb_dados";

            dt = Banco.consulta(total_mes);

            l_vlr_parcial.Text =  Convert.ToDouble(dt.Rows[0].ItemArray[0]).ToString("C2");
            //FIM GASTOS DO MES

        }

        private void sQLiteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /* F_SQLite f_SQLite = new F_SQLite();
             f_SQLite.ShowDialog();*/
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ll_usuario.Text = "---";
            Globais.logado = false;
            Globais.user = "";
            this.Hide();
            MessageBox.Show("At� logo!", "Bye", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Login login = new Login(this);
            login.ShowDialog();


        }

        private void configura��esToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Configuracoes f_Configuracoes = new F_Configuracoes(this);
            this.Hide();
            f_Configuracoes.ShowDialog();

        }

        private void l_vlr_peso_atual_Click(object sender, EventArgs e)
        {


        }

        private void l_vlrparcial_Click(object sender, EventArgs e)
        {

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

            l_vlr_parcial.Text = Convert.ToDouble(dt.Rows[0].ItemArray[0]).ToString("C2");


        }

        private void ll_versao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*ll_versao.Text = "Vers�o: " + Globais.versao;
            ll_versao.Refresh();*/
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

        }

        private void tb_peso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tb_peso22_TextChanged(object sender, EventArgs e)
        {

        }

        private void l_valor_peso_Click(object sender, EventArgs e)
        {

        }

        private void tb_outros_valor_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ll_usuario_Click(object sender, EventArgs e)
        {

        }

        private void tb_outros_valor_Click(object sender, EventArgs e)
        {


        }

        private void tb_diversos_descricao_Click(object sender, EventArgs e)
        {

        }

        private void tb_diversos_descricao_TextChanged(object sender, EventArgs e)
        {


            tb_diversos_descricao.CharacterCasing = CharacterCasing.Upper;

            string verifica = tb_diversos_descricao.Text;
            if (verifica != "")
            {
                //l_rs.Visible = true;
                tb_outros_valor.Visible = true;
                
                //tb_outros_valor.Enabled = true;

            }
            else
            {
                //l_rs.Visible = false;
                tb_outros_valor.Text = "0";
                tb_outros_valor.Visible = false;
                //tb_diversos_descricao.Enabled = false;
            }
        }

        private void tb_peso_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_peso1.Text))
            {
                tb_peso1.Text = "0";
                tb_peso1.SelectAll();
                
            }
            
            //Calculo parcial

            string sql = "select * from tb_configuracoes";

            dt = Banco.consulta(sql);
            string tb_vlr_pg_empresa1 = dt.Rows[0].ItemArray[2].ToString();
            string l_vlr_peso_atual1 = dt.Rows[0].ItemArray[1].ToString();


            double pesoAtual = Convert.ToDouble(l_vlr_peso_atual1);

         
            double pesoDigitado = Convert.ToDouble(tb_peso1.Text);
            double pagoEmpresa = Convert.ToDouble(tb_vlr_pg_empresa1);
            double tb_outros_valor1 = Convert.ToDouble(tb_outros_valor.Text);

            double result1 = (pesoDigitado * pesoAtual) / 1000;

            result1 = (result1 - pagoEmpresa);


            if (result1 < 0)
            {

                double result2 = tb_outros_valor1;
                l_vlrparcial.Text =  result2.ToString("C2");
                if (result2 > 6)
                {
                    l_vlrparcial.ForeColor = Color.Red;
                }
                else { 
                    l_vlrparcial.ForeColor= Color.Black;
                }

            }
            else
            {
                double result2 = result1 + tb_outros_valor1;
                l_vlrparcial.Text =  result2.ToString("C2");
                if (result2 > 6)
                {
                    l_vlrparcial.ForeColor = Color.Red;
                }
                else{
                    l_vlrparcial.ForeColor = Color.Black;
                }

            }
            //recalcula valor do kg calculado na configura��o
            //F_Configuracoes f_Configuracoes = new F_Configuracoes(this);
            //l_vlr_peso_atual.Text = "R$ " + f_Configuracoes.tb_vlr_kg.Text;


            l_vlrparcial.Refresh();
        }

        private void tb_outros_valor_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_outros_valor.Text))
            {
                tb_outros_valor.Text = "0";
                tb_outros_valor.SelectAll();
                
            }
            String convertePonto = tb_outros_valor.Text;
                    

            convertePonto = convertePonto.Replace(".", ",");

            double convertePonto1 = Convert.ToDouble(convertePonto);

            
            //Calculo parcial

            string sql = "select * from tb_configuracoes";

            dt = Banco.consulta(sql);
            string tb_vlr_pg_empresa1 = dt.Rows[0].ItemArray[2].ToString();
            string l_vlr_peso_atual1 = dt.Rows[0].ItemArray[1].ToString();


            double pesoAtual = Convert.ToDouble(l_vlr_peso_atual1);


            double pesoDigitado = Convert.ToDouble(tb_peso1.Text);
            double pagoEmpresa = Convert.ToDouble(tb_vlr_pg_empresa1);
            //double tb_outros_valor1 = Convert.ToDouble(this.tb_outros_valor.Text);

            double result1 = (pesoDigitado * pesoAtual) / 1000;

            result1 = (result1 - pagoEmpresa);


            if (result1 < 0)
            {

                double result2 = convertePonto1;
                l_vlrparcial.Text =  Convert.ToDouble(result2).ToString("C2");
                if (result2 > 6)
                {
                    l_vlrparcial.ForeColor = Color.Red;
                }
                else
                {
                    l_vlrparcial.ForeColor = Color.Black;
                }

            }
            else
            {
                double result2 = result1 + convertePonto1;
                l_vlrparcial.Text = Convert.ToDouble( result2).ToString("C2");
                if (result2 > 6)
                {
                    l_vlrparcial.ForeColor = Color.Red;
                }
                else
                {
                    l_vlrparcial.ForeColor = Color.Black;
                }

            }
            //recalcula valor do kg calculado na configura��o
            //F_Configuracoes f_Configuracoes = new F_Configuracoes(this);
            //l_vlr_peso_atual.Text = "R$ " + f_Configuracoes.tb_vlr_kg.Text;


            l_vlrparcial.Refresh();
        }
           
        private void tb_peso1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (char.IsWhiteSpace(e.KeyChar) || (char.IsSymbol(e.KeyChar))))
            {

                e.Handled = true;
            };
        }

        private void tb_peso1_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void tb_peso1_KeyDown(object sender, KeyEventArgs e)
        {


            /*if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == (Keys.LControlKey & Keys.A)  || e.KeyCode == (Keys.RControlKey & Keys.A)  || e.KeyCode == (Keys.ControlKey & Keys.A))
            {
                e.Handled = true;
            }*/
        }

        private void tb_outros_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (char.IsWhiteSpace(e.KeyChar) || (char.IsSymbol(e.KeyChar))))
            {

                e.Handled = true;
            };
        }

        private void tb_diversos_descricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar))
            {

                e.Handled = true;
            };
        }

        private void l_vlr_peso_atual_TextChanged(object sender, EventArgs e)
        {
            /*String convertePonto = l_vlr_peso_atual.Text;

            convertePonto = convertePonto.Replace(".", ",");

            double convertePonto1 = Convert.ToDouble(convertePonto);*/
        }

        private void tb_peso1_MouseClick(object sender, MouseEventArgs e)
        {
            tb_peso1.SelectAll();
            tb_peso1.BackColor = Color.LightGreen;

        }

        private void tb_outros_valor_MouseClick(object sender, MouseEventArgs e)
        {
            tb_outros_valor.SelectAll();
            tb_outros_valor.BackColor = Color.LightGreen;
        }

        private void tb_diversos_descricao_MouseClick(object sender, MouseEventArgs e)
        {
            tb_diversos_descricao.SelectAll();
            tb_diversos_descricao.BackColor = Color.LightGreen;
        }

        private void tb_peso1_Leave(object sender, EventArgs e)
        {
            /*int tb_peso11 = Convert.ToInt32(tb_peso1.Text);
            if (tb_peso11 > 1)
            {
                tb_peso11 = 0;
                tb_peso1.Text = tb_peso1.ToString();

            }*/

            tb_peso1.BackColor = Color.White;

        }

        private void tb_diversos_descricao_Leave(object sender, EventArgs e)
        {
            tb_diversos_descricao.BackColor = Color.White;
        }

        private void tb_outros_valor_Leave(object sender, EventArgs e)
        {
            tb_outros_valor.BackColor = Color.White;
        }

        private void ll_sobre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sobre sobre = new Sobre();
            this.Hide();
            sobre.ShowDialog();
        }

        private void l_vlr_parcial_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void l_vlrparcial_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}