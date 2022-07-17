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
    public partial class F_Historico : Form
    {
        DataTable dt = new DataTable();
        public F_Historico()
        {
            InitializeComponent();
        }

        private void F_Historico_Load(object sender, EventArgs e)
        {
            string sql = @"select 
                     T_DATA as 'Data',
                     N_PESO as 'Peso',
                     T_OUTROSDIVERSOS as 'Descricao outros valores',
                     iif(N_OUTROSVALOR = 0, '' , 'R$ '|| N_OUTROSVALOR) as 'Outros VLR',
                     iif(T_TOTAL_DIARIO = 0, '' , 'R$ '|| T_TOTAL_DIARIO ) as 'valor total diario'
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
    }
}
