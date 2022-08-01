using System.Data;
using System.Globalization;
using System.Windows;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class tl_home : Form
    {
        Mapeadores.MapeadorConsultaTodaTabela obtemTodaTabelaConfiguracoes = new Mapeadores.MapeadorConsultaTodaTabela();
        Mapeadores.MapeadorConsultaTodaTabela obtemSomaTotalDiario = new Mapeadores.MapeadorConsultaTodaTabela();
        Mapeadores.MapeadorSomaTotalDiario obtemSomaTotalDiarioDados = new Mapeadores.MapeadorSomaTotalDiario();
        Mapeadores.MapeadorDeUpdate processoValidaUpdate = new Mapeadores.MapeadorDeUpdate();
        Mapeadores.MapeadorDeUpdate obtemComanda = new Mapeadores.MapeadorDeUpdate();
        Mapeadores.MapeadorDeInsert insereDadosDaComandaDiario = new Mapeadores.MapeadorDeInsert();
        Processos.ProcessoCalculoDoKg somaDoKg =new Processos.ProcessoCalculoDoKg();
        Processos.ProcessoConvertToDouble convertToDouble = new Processos.ProcessoConvertToDouble();
        Processos.ProcessoMsg msg = new Processos.ProcessoMsg();
        Processos.ProcessoLogout logout = new Processos.ProcessoLogout();
        F_Configuracoes configuracoes;
        DataTable dt = new DataTable();
        
        public tl_home( )
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

        private void históricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Historico f_Historico = new F_Historico();
            this.Hide();
            f_Historico.ShowDialog();
        }

        private void tl_home_Load(object sender, EventArgs e)
        {
            
            tb_outros_valor.ReadOnly = true;

            //Perciste usuario logado
            ll_usuario.Text = Globais.user;

            
            dt = obtemTodaTabelaConfiguracoes.ObtemTodaTabelaConfiguracoes();
            l_vlr_peso_atual.Text = Convert.ToDouble(dt.Rows[0].ItemArray[1]).ToString("C2");

            dt = obtemSomaTotalDiarioDados.ObtemSomaTotalDiarioDados();
            l_vlr_parcial.Text = Convert.ToDouble(dt.Rows[0].ItemArray[0]).ToString("C2");

            ll_versao.Text = "Versão: " + Globais.versao;
            ll_versao.Refresh();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            String convertePonto = tb_outros_valor.Text;
            convertePonto = convertePonto.Replace(".", ",");
            double convertePonto1 = Convert.ToDouble(convertePonto);
            dt = obtemTodaTabelaConfiguracoes.ObtemTodaTabelaConfiguracoes();

            string l_vlr_peso_atual1 = dt.Rows[0].ItemArray[1].ToString();
            string pagoEmpresa1 = dt.Rows[0].ItemArray[2].ToString();
            string pesoDigitado1 = tb_peso1.Text.ToString();
            //TESTE DE CONVERSÃO
            double[] convertTodos = convertToDouble.ConvertToDouble(l_vlr_peso_atual1, pesoDigitado1, pagoEmpresa1);
            double pesoAtual = convertTodos[0];
            double pesoDigitado = convertTodos[1];
            double pagoEmpresa = convertTodos[2];
            //FIM DO TESTE :P
            double somaDoKgReturn = somaDoKg.SomaDoKg(pesoDigitado, pesoAtual, pagoEmpresa);

            string tb_diversos_descricao1 = tb_diversos_descricao.Text;
            string dt_data_atual1 = dt_data_atual.Text;
            string sql1 = $"SELECT * FROM tb_dados WHERE T_DATA like '{dt_data_atual1}'";

            dt = Banco.consulta(sql1);

            if (dt.Rows.Count >= 1)
            {
                var mensg = msg.DesejaAlterar();
                
                if (mensg == DialogResult.Yes)
                {

                    if (convertePonto1 > 0)
                    {
                        if (!(tb_diversos_descricao1 is null) && tb_diversos_descricao1 != "")
                        {
                            if (somaDoKgReturn < 0)
                            {
                                double result2 = convertePonto1;
                                string valor_diario = result2.ToString("F2", CultureInfo.InvariantCulture);
                                string convertePonto11 = convertePonto1.ToString("F2", CultureInfo.InvariantCulture);
                                obtemComanda.ObtemComanda(pesoDigitado.ToString(), tb_diversos_descricao1, convertePonto11, valor_diario, dt_data_atual1);
                                msg.Salvo();

                            }
                            else
                            {
                                double result2 = somaDoKgReturn + convertePonto1;
                                string valor_diario = result2.ToString("F2", CultureInfo.InvariantCulture);
                                string convertePonto11 = convertePonto1.ToString("F2", CultureInfo.InvariantCulture);
                                obtemComanda.ObtemComanda(pesoDigitado.ToString(), tb_diversos_descricao1, convertePonto11, valor_diario, dt_data_atual1);
                                msg.Salvo();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Favor informar a descricao do diversos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        if (somaDoKgReturn < 0)
                        {
                            double result2 = convertePonto1;
                            string valor_diario = result2.ToString("F2", CultureInfo.InvariantCulture);
                            string convertePonto11 = convertePonto1.ToString("F2", CultureInfo.InvariantCulture);
                            obtemComanda.ObtemComanda(pesoDigitado.ToString(), tb_diversos_descricao1, convertePonto11, valor_diario, dt_data_atual1);
                            msg.Salvo();
                        }
                        else
                        {
                            double result2 = somaDoKgReturn + convertePonto1;
                            string valor_diario = result2.ToString("F2", CultureInfo.InvariantCulture);
                            string convertePonto11 = convertePonto1.ToString("F2", CultureInfo.InvariantCulture);
                            obtemComanda.ObtemComanda(pesoDigitado.ToString(), tb_diversos_descricao1, convertePonto11, valor_diario, dt_data_atual1);
                            msg.Salvo();
                        }
                    }
                }
            }
            else
            {
                if (pesoDigitado < 0)
                {
                    MessageBox.Show("Favor informar o peso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    if (convertePonto1 > 0)
                    {
                        if (!(tb_diversos_descricao1 is null) && tb_diversos_descricao1 != "")
                        {
                            if (somaDoKgReturn < 0)
                            {

                                double result2 = convertePonto1;
                                string valor_diario = result2.ToString("F2", CultureInfo.InvariantCulture);
                                string convertePonto11 = convertePonto1.ToString("F2", CultureInfo.InvariantCulture);
                                insereDadosDaComandaDiario.InsereDadosDaComanda(dt_data_atual1, pesoDigitado.ToString(), tb_diversos_descricao1, convertePonto11, valor_diario);
                                msg.Salvo();
                            }
                            else
                            {
                                double result2 = somaDoKgReturn + convertePonto1;
                                string valor_diario = result2.ToString("F2", CultureInfo.InvariantCulture);
                                string convertePonto11 = convertePonto1.ToString("F2", CultureInfo.InvariantCulture);
                                insereDadosDaComandaDiario.InsereDadosDaComanda(dt_data_atual1, pesoDigitado.ToString(), tb_diversos_descricao1, convertePonto11, valor_diario);
                                msg.Salvo();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Favor informar a descricao do diversos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        if (somaDoKgReturn < 0)
                        {

                            double result2 = convertePonto1;
                            string valor_diario = result2.ToString("F2", CultureInfo.InvariantCulture);
                            string convertePonto11 = convertePonto1.ToString("F2", CultureInfo.InvariantCulture);
                            insereDadosDaComandaDiario.InsereDadosDaComanda(dt_data_atual1, pesoDigitado.ToString(), tb_diversos_descricao1, convertePonto11, valor_diario);
                            msg.Salvo();
                        }
                        else
                        {
                            double result2 = somaDoKgReturn + convertePonto1;
                            string valor_diario = result2.ToString("F2", CultureInfo.InvariantCulture);
                            string convertePonto11 = convertePonto1.ToString("F2", CultureInfo.InvariantCulture);
                            insereDadosDaComandaDiario.InsereDadosDaComanda(dt_data_atual1, pesoDigitado.ToString(), tb_diversos_descricao1, convertePonto11, valor_diario);
                            msg.Salvo();
                        }
                    }
                }
            }
            dt = obtemSomaTotalDiarioDados.ObtemSomaTotalDiarioDados();
            l_vlr_parcial.Text = Convert.ToDouble(dt.Rows[0].ItemArray[0]).ToString("C2");
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logout.Logout();
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Configuracoes f_Configuracoes = new F_Configuracoes(this);
            this.Hide();
            f_Configuracoes.ShowDialog();

        }

        private void tb_diversos_descricao_TextChanged(object sender, EventArgs e)
        {

            tb_diversos_descricao.CharacterCasing = CharacterCasing.Upper;

            string outrosConsumos = tb_diversos_descricao.Text;
            if (outrosConsumos != "")
            {
                tb_outros_valor.ReadOnly = false;

            }
            else
            {
                tb_outros_valor.Text = "0";
                tb_outros_valor.ReadOnly = true;
            }
        }

        private void tb_peso_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_peso1.Text))
            {
                tb_peso1.Text = "0";
                tb_peso1.SelectAll();
            }

            dt = obtemTodaTabelaConfiguracoes.ObtemTodaTabelaConfiguracoes();
            string tb_vlr_pg_empresa1 = dt.Rows[0].ItemArray[2].ToString();
            string l_vlr_peso_atual1 = dt.Rows[0].ItemArray[1].ToString();

            double pesoAtual = Convert.ToDouble(l_vlr_peso_atual1);
            double pesoDigitado = Convert.ToDouble(tb_peso1.Text);
            double pagoEmpresa = Convert.ToDouble(tb_vlr_pg_empresa1);
            double tb_outros_valor1 = Convert.ToDouble(tb_outros_valor.Text);
            double somaDoKgReturn = somaDoKg.SomaDoKg(pesoDigitado, pesoAtual, pagoEmpresa);

            if (somaDoKgReturn < 0)
            {
                double result2 = tb_outros_valor1;
                l_vlrparcial.Text = result2.ToString("C2");
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
                double result2 = somaDoKgReturn + tb_outros_valor1;
                l_vlrparcial.Text = result2.ToString("C2");
                if (result2 > 6)
                {
                    l_vlrparcial.ForeColor = Color.Red;
                }
                else
                {
                    l_vlrparcial.ForeColor = Color.Black;
                }

            }
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

            dt = obtemTodaTabelaConfiguracoes.ObtemTodaTabelaConfiguracoes();

            string tb_vlr_pg_empresa1 = dt.Rows[0].ItemArray[2].ToString();
            string l_vlr_peso_atual1 = dt.Rows[0].ItemArray[1].ToString();

            double pesoAtual = Convert.ToDouble(l_vlr_peso_atual1);
            double pesoDigitado = Convert.ToDouble(tb_peso1.Text);
            double pagoEmpresa = Convert.ToDouble(tb_vlr_pg_empresa1);
            double somaDoKgReturn = somaDoKg.SomaDoKg(pesoDigitado, pesoAtual, pagoEmpresa);

            if (somaDoKgReturn < 0)
            {

                double result2 = convertePonto1;
                l_vlrparcial.Text = Convert.ToDouble(result2).ToString("C2");
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
                double result2 = somaDoKgReturn + convertePonto1;
                l_vlrparcial.Text = Convert.ToDouble(result2).ToString("C2");
                if (result2 > 6)
                {
                    l_vlrparcial.ForeColor = Color.Red;
                }
                else
                {
                    l_vlrparcial.ForeColor = Color.Black;
                }
            }
            l_vlrparcial.Refresh();
        }

        private void tb_peso1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (char.IsWhiteSpace(e.KeyChar) || (char.IsSymbol(e.KeyChar))))
            {
                e.Handled = true;
            };
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

        private void tb_peso1_MouseClick(object sender, MouseEventArgs e)
        {
            tb_peso1.SelectAll();
            tb_peso1.BackColor = Color.LightGreen;
        }

        private void tb_outros_valor_MouseClick(object sender, MouseEventArgs e)
        {
            if (tb_outros_valor.ReadOnly != true)
            {
                tb_outros_valor.SelectAll();
                tb_outros_valor.BackColor = Color.LightGreen;
            }
        }

        private void tb_diversos_descricao_MouseClick(object sender, MouseEventArgs e)
        {
            tb_diversos_descricao.SelectAll();
            tb_diversos_descricao.BackColor = Color.LightGreen;
        }

        private void tb_peso1_Leave(object sender, EventArgs e)
        {
            tb_peso1.BackColor = Color.White;
        }

        private void tb_diversos_descricao_Leave(object sender, EventArgs e)
        {
            tb_diversos_descricao.BackColor = Color.White;
        }

        private void tb_outros_valor_Leave(object sender, EventArgs e)
        {
            if (tb_outros_valor.ReadOnly == true)
            {
                tb_outros_valor.BackColor = Color.LightGray;
            }
            else
            {
                tb_outros_valor.BackColor = Color.White;
            }
        }

        private void tb_outros_valor_ReadOnlyChanged(object sender, EventArgs e)
        {
            if (tb_outros_valor.ReadOnly == true)
            {
                tb_outros_valor.BackColor = Color.LightGray;
            }
            else
            {
                tb_outros_valor.BackColor = Color.White;
            }
        }

        private void ll_sobre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sobre sobre = new Sobre();
            this.Hide();
            sobre.ShowDialog();
        }
    }
}