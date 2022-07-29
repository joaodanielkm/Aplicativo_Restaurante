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

namespace WinFormsApp1
{
    public partial class F_Historico : Form
    {
        DataTable dt = new DataTable();
        public F_Historico()
        {
            InitializeComponent();
        }

        private void F_Historico_Load(object sender, EventArgs e)
        {
            string sql1 = @"select 
                            distinct
                            	(case substr(T_DATA, 4 , 2)
                                when '01' then 'Janeiro'
                                when '02' then 'Fevereiro'
                                when '03' then 'Março'
                                when '04' then 'Abril'
                                when '05' then 'Maio'
                                when '06' then 'Junho'
                                when '07' then 'Julho'
                            end) as 'mes'
                            from tb_dados";


            cb_meses.Items.Clear();
            cb_meses.DataSource = Banco.consulta(sql1);
            cb_meses.DisplayMember = "mes";
            
            

            string sql = @"select 
                     T_DATA as 'Data',
                     iif(N_PESO = 0, '', N_PESO || ' Kg') as 'Peso',
                     T_OUTROSDIVERSOS as 'Descricao outros valores',
                     iif(CAST(N_OUTROSVALOR AS NUMERIC (17,8)) <= 0  , '' ,  'R$ '|| REPLACE(N_OUTROSVALOR, '.', ',' ) )as 'Outros VLR',
                     iif (CAST(T_TOTAL_DIARIO AS NUMERIC (17,8)) <= 0 , '' , 'R$ '||  replace(T_TOTAL_DIARIO, '.',',') ) as 'valor total diario'
                     from tb_dados";


            dgv_historico.DataSource = Banco.consulta(sql);


            dgv_historico.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_historico.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_historico.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv_historico.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_historico.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            



            dgv_historico.Columns[0].Width = 80;//DATA
            dgv_historico.Columns[1].Width = 50;//PESO
            dgv_historico.Columns[2].Width = 200;//DESCRIÇÃO OUTROS
            dgv_historico.Columns[3].Width = 80;//OUTROS VALOR
            dgv_historico.Columns[4].Width = 68;//VALOR TOTAL DIARIO
            dgv_historico.Columns[3].DefaultCellStyle.Format = "C2";
            dgv_historico.Columns[4].DefaultCellStyle.Format = "C2";


            //gasto do mes
            string total_mes = $"select sum(T_TOTAL_DIARIO) from tb_dados";

            dt = Banco.consulta(total_mes);

            tb_gasto_do_mes.Text = Convert.ToDouble(dt.Rows[0].ItemArray[0]).ToString("C2");


        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tl_home home = new tl_home();
            this.Hide();
            home.ShowDialog();
        }

        private void dgv_historico_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgv_historico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
