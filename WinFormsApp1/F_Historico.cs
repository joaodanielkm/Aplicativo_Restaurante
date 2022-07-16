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
                     N_OUTROSVALOR as 'outros valores',
                     T_TOTAL_DIARIO as 'valor total diario'
                     from tb_dados";

            //dt = Banco.consulta(sql);
            
            dgv_historico.DataSource = Banco.consulta(sql);
            dgv_historico.Columns[0].Width = 85;
            dgv_historico.Columns[1].Width = 60;
            dgv_historico.Columns[2].Width = 200;
            dgv_historico.Columns[3].Width = 60;
            dgv_historico.Columns[4].Width = 60;




        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tl_home home = new tl_home();
            this.Hide();
            home.ShowDialog();
        }
    }
}
