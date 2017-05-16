using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        Sousuo f_ss = null;
        public Main()
        {
            this.MaximizeBox = false;
            InitializeComponent();   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_JieShu_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sousuo_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_ss = new Sousuo();
            f_ss.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_Fanhui_Click(object sender, EventArgs e)
        {

        }
    }
}
