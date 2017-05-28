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
        string usrName = Main.UsrName;

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
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderCell.Value = "书名";
            dataGridView1.Columns[1].HeaderCell.Value = "书号";
            dataGridView1.Columns[2].HeaderCell.Value = "状态";
            dataGridView1.Columns[3].HeaderCell.Value = "类型";
            dataGridView1.Columns[4].HeaderCell.Value = "作者";
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

            string lx = cbox_lx.SelectedItem.ToString();
            Console.WriteLine("点击了"+lx);
            conn.Open();
            string sqlstr = "select * from Books where Bkinds = '"+ lx +"'";
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderCell.Value = "书名";
            dataGridView1.Columns[1].HeaderCell.Value = "书号";
            dataGridView1.Columns[2].HeaderCell.Value = "状态";
            dataGridView1.Columns[3].HeaderCell.Value = "类型";
            dataGridView1.Columns[4].HeaderCell.Value = "作者";
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
            dataGridView1.Columns[0].HeaderCell.Value = "书名";
            dataGridView1.Columns[1].HeaderCell.Value = "书号";
            dataGridView1.Columns[2].HeaderCell.Value = "状态";
            dataGridView1.Columns[3].HeaderCell.Value = "类型";
            dataGridView1.Columns[4].HeaderCell.Value = "作者";
            conn.Close();
        }


        /*
         * 根据书号借书
         * select * from Books where Bnumber = '12345675546';
         */
        private void btn_js_Click(object sender, EventArgs e)
        {
            int flag = -1;
            string sh = txtbox_bkNum.Text.ToString();
            Opertion bean = new Opertion();
            Boolean ok1 = bean.Borrows(sh);
            if (ok1)
            {
                flag = 1;
                //MessageBox.Show("success!");
                string bkName = bean.GetBkName(sh);
                Console.WriteLine("bkName = "+ bkName);
                //DateTime.Now.ToString("yyyy-MM-dd");        // 2008-09-04
                Boolean ok2 = bean.BorrowRecord(sh, bkName, DateTime.Now.ToString("yyyy-MM-dd"), usrName);
                if (ok2)
                {
                    flag = 1;
                    if (bean.BkBuffChange(sh))
                        flag = 1;
                    else
                        flag = -1;
                }
                else
                    flag = -1;
            }
            else
                flag = -1;

            if (flag == 1)
                MessageBox.Show("success");
            else
                MessageBox.Show("error");

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
            dataGridView1.Columns[0].HeaderCell.Value = "书名";
            dataGridView1.Columns[1].HeaderCell.Value = "书号";
            dataGridView1.Columns[2].HeaderCell.Value = "状态";
            dataGridView1.Columns[3].HeaderCell.Value = "类型";
            dataGridView1.Columns[4].HeaderCell.Value = "作者";
            conn.Close();
        }

        private void Sousuo_Load(object sender, EventArgs e)
        {
           /* usrName = Main.UsrName;
            Console.WriteLine("usrName = " + usrName);*/
        }

        private void Sousuo_Load(object sender, EventArgs e)
        {
            /* usrName = Main.UsrName;
             Console.WriteLine("usrName = " + usrName);*/
        }

        private void 返回ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Main.f_m.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
