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
           
            
            
           //home.l_vlr_peso_atual.Text = tb_vlr_kg.Text;


        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
