using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
    public partial class Zhuce : Form
    {
        public Zhuce()
        {
            this.MaximizeBox = false;
            InitializeComponent();
        }

        private void lab_Zhanghao_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Zhuce_Load(object sender, EventArgs e)
        {

        }

        private void btn_Zhuce_Click(object sender, EventArgs e)
        {

            //判定各种是否为空
            if (txtbox_Zhanghao.Text.Trim() == string.Empty)
            {
                txtbox_Zhanghao.Focus();
            }
            if (txtbox_Mima.Text.Trim() == string.Empty)
            {
                txtbox_Mima.Focus();
            }
            if (txtbox_Mima2.Text.Trim() == string.Empty)
                txtbox_Mima2.Focus();
            if (txtbox_Xuehao.Text.Trim() == string.Empty)
                txtbox_Xuehao.Focus();
            if (txtbox_Name.Text.Trim() == string.Empty)
                txtbox_Name.Focus();


            string zhanghao = txtbox_Zhanghao.Text.Trim();
            string mima1 = txtbox_Mima.Text.Trim();
            string mima2 = txtbox_Mima2.Text.Trim();
            string name = txtbox_Name.Text.Trim();
            string xuehao = txtbox_Xuehao.Text.Trim();
            if (mima1 != mima2)
            {
                MessageBox.Show("两次输入的密码不相等，请重输!");
                txtbox_Mima2.Focus();
            }

            Opertion bean = new Opertion();
            if (bean.UserAdd(zhanghao, mima1, name, xuehao))
            {
                MessageBox.Show("注册成功");
            }
            else
                MessageBox.Show("error注册失败!");        
        }

        private void btn_Fanhui_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.pForm1.Show();
        }
    }
}
