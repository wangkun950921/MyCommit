using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    public partial class Guanliyuan : Form
    {
        private string constr = "Data Source=.\\sqlexpress;Initial Catalog=MyLibrary;Integrated Security=True";

        UpdateUser f_upU = null;

        public Guanliyuan()
        {
            InitializeComponent();
        }

        /*
         * 读取全部用户信息
         * select * from User1;
         */
        private void btn_ReadAllUser_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            string sqlstr = "select * from User1";
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        /*
         * 查看全部图书信息
         */
        private void btn_ReadAllBook_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            string sqlstr = "select * from Books";
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        /*
         * 查看全部借阅信息
         */
        private void btn_ReadAllBorrow_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            string sqlstr = "select * from Borrow";
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }


        /*
         * 选中用户列表信息删除
         */
        private void btn_DelUser_Click(object sender, EventArgs e)
        {
            string num = null;
            string zhanghao = null;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Selected == true)
                {
                    zhanghao = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    num = dataGridView1.Rows[i].Cells[3].Value.ToString();
                }
            }
            Console.WriteLine("num = " + num + "; zhanghao = " + zhanghao);
            Opertion bean = new Opertion();
            Boolean ok = bean.UserDelete(zhanghao, num);
            if (ok)
            {
                MessageBox.Show("delete success!");
            }
            else
                MessageBox.Show("error");
        }

        /*
         * 修改当前行用户信息
         */
        private void btn_UpUsr_Click(object sender, EventArgs e)
        {

            string num = null;
            string zhanghao = null;
            string mima = null;
            string name = null;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Selected == true)
                {
                    zhanghao = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    mima = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    name = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    num = dataGridView1.Rows[i].Cells[3].Value.ToString();
                }
            }



            f_upU = new UpdateUser();
           // f_upU.Owner = this;
            f_upU.Show();
        }

    }
}
