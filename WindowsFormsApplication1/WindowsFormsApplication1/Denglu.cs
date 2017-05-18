﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    public partial class Denglu : Form
    {

        private int flag;//1为用户2为管理员
        Main f_m = null;
        Guanliyuan f_gly = null;

        public static string UsrName = null;
        public static string UsrMima = null;
        public static string UsrZhanghao = null;
        public static string UsrXuehao = null;

        public Denglu()
        {
            this.MaximizeBox = false;
            InitializeComponent();
        }

        private void lab_Zhanghao_Click(object sender, EventArgs e)
        {

        }

        private void Denglu_Load(object sender, EventArgs e)
        {
            if (rbtn_Guanliyuan.Checked == true)
            {
                txtbox_Xuehao.Visible = false;
                lab_Xuehao.Visible = false;
            }
        }


        private void btn_Denglu_Click(object sender, EventArgs e)
        {
            //判定各种是否为空
            if(txtbox_Zhanghao.Text.Trim() == string.Empty)
            {
                txtbox_Zhanghao.Focus();
            }
            if (txtbox_Mima.Text.Trim() == string.Empty)
            {
                txtbox_Mima.Focus();
            }



            string zhanghao = txtbox_Zhanghao.Text.Trim();
            string mima = txtbox_Mima.Text.Trim();
            Opertion bean = new Opertion();

            if (rbtn_Yonghu.Checked)
            {
                if (txtbox_Xuehao.Text.Trim() == string.Empty)
                    txtbox_Xuehao.Focus();

                string xuehao = txtbox_Xuehao.Text.Trim();
                
                Boolean ok = bean.pswCheck(zhanghao, mima, xuehao);
                if (ok)
                {
                    //密码正确需要跳转页面到main
                    MessageBox.Show("success!");
                    this.Hide();
                   
                    UsrZhanghao = txtbox_Zhanghao.Text.Trim().ToString();
                    UsrXuehao = txtbox_Xuehao.Text.Trim().ToString();

                    /*  ShowTest f_s = new ShowTest();
                      f_s.Show();*/
                    f_m = new Main();
                    f_m.Show();

                }
                else
                {
                    MessageBox.Show("mima Error!");
                }
            }
            else if (rbtn_Guanliyuan.Checked)
            {
                Boolean glyLog = bean.gylLogin(zhanghao, mima);
                if (glyLog)
                {
                    //密码正确需要跳转页面到main
                    MessageBox.Show("success!");
                    this.Hide();
                    f_gly = new Guanliyuan();
                    f_gly.Show();
                }
            }


        }

        private void btn_Fanhui_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.pForm1.Show();
        }

        private void rbtn_Yonghu_CheckedChanged(object sender, EventArgs e)
        {
            txtbox_Xuehao.Visible = true;
            lab_Xuehao.Visible = true;
            string a = null;
        }

        private void rbtn_Guanliyuan_CheckedChanged(object sender, EventArgs e)
        {
            txtbox_Xuehao.Visible = false;
            lab_Xuehao.Visible = false;
        }
    }
}
