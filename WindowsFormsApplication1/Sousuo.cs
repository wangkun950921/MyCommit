using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Sousuo : Form
    {
        static string constr = "Data Source=.\\sqlexpress;Initial Catalog=MyLibrary;Integrated Security=True";
        Opertion bean = new Opertion();
        SqlConnection conn = new SqlConnection(constr);

        public Sousuo()
        {
            InitializeComponent();
        }

        private void btn_ReadAll_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sqlstr = "select * from Books";
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*
         * 类型搜索图书
         * select * from Books where Bkinds = '自然科学';
         */
        private void btn_ssLX_Click(object sender, EventArgs e)
        {

            string lx = litb_Lx.SelectedItem.ToString();
            Console.WriteLine("点击了"+lx);
            conn.Open();
            string sqlstr = "select * from Books where Bkinds = '"+ lx +"'";
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }


        /*
         * 书名搜索
         * select * from Books where Bname = 'agfd';
         */
        private void btn_ssSM_Click(object sender, EventArgs e)
        {
            string sm = txtbox_SM.Text.ToString();
            conn.Open();
            string sqlstr = "select * from Books where Bname = '" + sm +"'";
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }


        /*
         * 根据书号借书
         * select * from Books where Bnumber = '12345675546';
         */
        private void btn_js_Click(object sender, EventArgs e)
        {
            string sh = txtbox_num.Text.ToString();
            Opertion bean = new Opertion();
            Boolean ok = bean.Borrows(sh);
            if (ok)
            {
                MessageBox.Show("success!");
            }
            else
                MessageBox.Show("has borrowed!");
        }

        private void txtbox_sh_TextChanged(object sender, EventArgs e)
        {

        }


        /*
         * 按作者搜索
         * select * from Books where Bauther = 'aaa';
         */
        private void btn_Zz_Click(object sender, EventArgs e)
        {
            string zz = txtB_Zz.Text.Trim().ToString();
            conn.Open();
            string sqlstr = "select * from Books where Bauther = '" + zz + "'";
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }
    }
}
