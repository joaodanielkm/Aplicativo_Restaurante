﻿using System;
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
    public partial class Sobre : Form
    {
        public Sobre()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sobre_Load(object sender, EventArgs e)
        {
           
            l_sobre.Text = Globais.sobre.ToString();
        }

        private void bt_ok_sobre_Click(object sender, EventArgs e)
        {
            tl_home home = new tl_home();
            this.Hide();
            home.ShowDialog();
        }

        private void bt_ok_sobre_Enter(object sender, EventArgs e)
        {
            bt_ok_sobre.Focus();
        }
    }
}
