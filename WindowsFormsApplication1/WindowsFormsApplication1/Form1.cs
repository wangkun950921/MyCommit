using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Zhuce f_zc = null;
        public static Form1 pForm1 = null;
        Denglu f_dl = null;
        public Form1()
        {
            pForm1 = this;
            this.MaximizeBox = false;
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
          /*  Thread thread = new Thread();
            thread.IsBackground = true;
            thread.Start();*/
        }


        private void btn_Zhuce_Click(object sender, EventArgs e)
        {
            
            //this.Visible = false;//将当前窗口设置为不可视；如果不这样处理则系统报错。
            
            
           // Thread thread = new Thread();
           // f_zc.ShowDialog();//打开窗口
            f_zc = new Zhuce();
            this.Hide();
            f_zc.Show();
            
            //Application.ExitThread();
        }

        private void btn_Tuichu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_denglu_Click(object sender, EventArgs e)
        {
            f_dl = new Denglu();
            this.Hide();
            f_dl.Show();
        }
    }
}
