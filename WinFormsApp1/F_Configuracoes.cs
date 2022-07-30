using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class F_Configuracoes : Form
    {

        tl_home home;
        DataTable dt = new DataTable();
        public F_Configuracoes(tl_home h)
        {
            InitializeComponent();
            home = h;
        }

        private void F_Configuracoes_Load(object sender, EventArgs e)
        {

            tb_vlr_kg.BackColor = Color.LightGreen;

            string N_VLR_PG_EMPRESA = "select * from tb_configuracoes";

            dt = Banco.consulta(N_VLR_PG_EMPRESA);


            tb_vlr_pg_empresa.Text = "" + Convert.ToDouble(dt.Rows[0].ItemArray[2]).ToString("F2");
            tb_vlr_kg.Text = "" + Convert.ToDouble(dt.Rows[0].ItemArray[1]).ToString("F2");


        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tb_vlr_pg_empresa_TextChanged(object sender, EventArgs e)
        {
            string N_VLR_PG_EMPRESA = "select * from tb_configuracoes";

            dt = Banco.consulta(N_VLR_PG_EMPRESA);


            //tb_vlr_pg_empresa.Text = dt.Rows[0].ItemArray[0].ToString();

        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            double verificaVlrKg = Convert.ToDouble(tb_vlr_kg.Text);
                        
            if (verificaVlrKg <= 10)
            {
                var verificaPesoBaixo = MessageBox.Show("Valor R$ " + verificaVlrKg + " muito baixo. Confirma? ", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                if (verificaPesoBaixo == DialogResult.OK)
                {
                    //CONVERSAO . POR ,
                    //String convertePonto = tb_vlr_kg.Text;

                    //convertePonto = convertePonto.Replace(".", ",");


                    //FIM DA CONVERSAO


                    //double tb_vlr_kg1 = Convert.ToDouble(tb_vlr_kg.Text);
                    double convertePonto1 = Convert.ToDouble(tb_vlr_kg.Text);
                    //tb_vlr_kg.Text = Convert.ToString((Convert.ToDouble(tb_vlr_kg.Text) / 2));

                    double pg_empresa = (convertePonto1 / 2);

                    
                    string sql = $"UPDATE tb_configuracoes SET N_VLR_KG = '{convertePonto1}', N_VLR_PG_EMPRESA = '{pg_empresa}'";

                    dt = Banco.consulta(sql);

                    MessageBox.Show("Alterado!", "Lançamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    home.ShowDialog();
                }
                else
                {



                    tb_vlr_kg.Focus();
                    return;
                }
            }
            else
            {
                //CONVERSAO . POR ,
                //String convertePonto = tb_vlr_kg.Text;

                //convertePonto = convertePonto.Replace(".", ",");


                //FIM DA CONVERSAO



                double convertePonto1 = Convert.ToDouble(tb_vlr_kg.Text);


                double pg_empresa = (convertePonto1 / 2);


                string sql = $"UPDATE tb_configuracoes SET N_VLR_KG = '{convertePonto1}', N_VLR_PG_EMPRESA = '{pg_empresa}'";

                dt = Banco.consulta(sql);

                MessageBox.Show("Alterado!", "Lançamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                home.ShowDialog();

            }

        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tl_home home = new tl_home();
            this.Hide();
            home.ShowDialog();

        }

        private void tb_vlr_kg_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tb_vlr_kg.Text))
            {
                tb_vlr_kg.Text = "0";
                tb_vlr_kg.SelectAll();
                return;
            }


            String convertePonto = tb_vlr_kg.Text;

            convertePonto = convertePonto.Replace(".", ",");

            double convertePonto1 = Convert.ToDouble(convertePonto);


            double tb_vlr_kg1 = Convert.ToDouble(tb_vlr_kg.Text);

            //tb_vlr_kg.Text = Convert.ToString((Convert.ToDouble(tb_vlr_kg.Text) / 2));

            double var2 = (convertePonto1 / 2);

            double var3 = convertePonto1 - var2;

            double tb_vlr_kg2 = convertePonto1;

            double var4 = var2;

            

            tb_vlr_pg_empresa.Text = Convert.ToString(var4);


        }

        private void F_Configuracoes_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();

        }

        private void tb_vlr_kg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (char.IsWhiteSpace(e.KeyChar) || (char.IsSymbol(e.KeyChar))))
            {

                e.Handled = true;
            };
        }

        private void tb_vlr_kg_Click(object sender, EventArgs e)
        {
            tb_vlr_kg.SelectAll();
            tb_vlr_kg.BackColor = Color.LightGreen;
        }

        private void tb_vlr_kg_Leave(object sender, EventArgs e)
        {
            tb_vlr_kg.BackColor = Color.White;
        }

        //private void tb_vlr_pg_empresa_MouseClick(object sender, MouseEventArgs e)
        //{
        //    tb_vlr_pg_empresa.BackColor = Color.LightGreen;
        //}

        //private void tb_vlr_pg_empresa_Leave(object sender, EventArgs e)
        //{
        //    tb_vlr_pg_empresa.BackColor = Color.White;
        //}


    }
}
