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

            string N_VLR_PG_EMPRESA = "select * from tb_configuracoes";

            dt = Banco.consulta(N_VLR_PG_EMPRESA);


            tb_vlr_pg_empresa.Text = dt.Rows[0].ItemArray[2].ToString();
            tb_vlr_kg.Text = dt.Rows[0].ItemArray[1].ToString();

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
            
            double tb_vlr_kg1 = Convert.ToDouble(tb_vlr_kg.Text);
            //double tb_vlr_pago_empresa1 = Convert.ToDouble(tb_vlr_pg_empresa.Text);
            double var2 = (tb_vlr_kg1 / 2);

            double var3 = tb_vlr_kg1 - var2;


            

            //tb_vlr_pg_empresa.Text = var3.ToString("F2");

            string sql = $"UPDATE tb_configuracoes SET N_VLR_KG = '{tb_vlr_kg1}', N_VLR_PG_EMPRESA = '{var2}'";
            //string sql1 = $"UPDATE tb_configuracoes SET N_VLR_PG_EMPRESA = '{var3}'";



           // dt = Banco.consulta(sql);
            dt = Banco.consulta(sql);

            MessageBox.Show("Salvo!");

            this.Close();


        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}
