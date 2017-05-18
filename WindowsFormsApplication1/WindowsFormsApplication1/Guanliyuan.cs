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
        public static string Updatename = null;
        public static string Updatenum = null;
        public static string Updatemima = null;
        public static string Updatezhanghao = null;
        public static string Updateauther = null;
        public static string Updatekind = null;
        public static string Updatebuff = null;
        public static string well = null;
        public static int UpdateFlag = 1;
        public static string UsrName = null;
        public static string BorrowData = null;



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
            //dataGridView1.Update();
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
                SqlConnection conn = new SqlConnection(constr);
                conn.Open();
                string sqlstr = "select * from User1";
                SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            else
                MessageBox.Show("error");
        }

        /*
         * 修改当前行用户信息， 传数据？需要各种修改啦
         */
        private void btn_UpUsr_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Selected == true)
                {
                    Updatezhanghao = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    Updatemima = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    Updatename = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    Updatenum = dataGridView1.Rows[i].Cells[3].Value.ToString();
                }
            }
            Console.WriteLine(Updatezhanghao+Updatemima+";"+Updatename+Updatenum);
            f_upU = new UpdateUser();
           // f_upU.Owner = this;
            f_upU.Show();
        }


        /*
         * 删除指定行图书信息
         */
        private void btn_BkDelete_Click(object sender, EventArgs e)
        {
            string number = null;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Selected == true)
                {
                    number = dataGridView1.Rows[i].Cells[1].Value.ToString();
                }
            }
            Console.WriteLine("number = " + number);
            Opertion bean = new Opertion();
            Boolean ok = bean.BookDelete(number);
            if (ok)
                MessageBox.Show("delete success!");
            else
                MessageBox.Show("error!");
        }

        /*
         * 图书信息的增加,跳转界面
         */
        private void btn_AddBk_Click(object sender, EventArgs e)
        {
            UpdateFlag = 1;
            UpdateBooks f_upBk = new UpdateBooks();
            f_upBk.Show();
        }

        /*
         * 借阅信息的删除
         */
        private void btn_DelBorr_Click(object sender, EventArgs e)
        {
            string bkNum = null;
            string usrName = null;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Selected == true)
                {
                    bkNum = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    usrName = dataGridView1.Rows[i].Cells[2].Value.ToString();
                }
            }
            Opertion bean = new Opertion();
            Boolean ok = bean.BorrowDelete(bkNum, usrName);
            if (ok)
            {
                MessageBox.Show("dalete success!");
                SqlConnection conn = new SqlConnection(constr);
                conn.Open();
                string sqlstr = "select * from Borrow";
                SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            else
                MessageBox.Show("error!");
            //this.dataGridView1.Update();
            //this.btn_ReadAllBorrow_Click(this.SendToBack, this.Events);
        }

        /*
         * 借阅信息的修改
         */
        private void btn_updateBk_Click(object sender, EventArgs e)
        {
            UpdateFlag = 2;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Selected == true)
                {
                    Updatename = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    Updatenum = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    Updatebuff = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    Updatekind = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    Updateauther = dataGridView1.Rows[i].Cells[4].Value.ToString();
                }
            }
            Console.WriteLine(Updatename + Updatenum + Updatebuff);
            UpdateBooks f_upBk = new UpdateBooks();
            f_upBk.ShowDialog();
        }

        /*
         * 修改借阅信息
         */
        private void btn_UpdateBor_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Selected == true)
                {
                    Updatename = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    Updatenum = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    UsrName = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    BorrowData = dataGridView1.Rows[i].Cells[3].Value.ToString();
                }
            }

            UpdateBorrow f_upBor = new UpdateBorrow();
            f_upBor.ShowDialog();
        }



    }
}
