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
    public partial class huanShu : Form
    {
        string constr = "Data Source=.\\sqlexpress;Initial Catalog=MyLibrary;Integrated Security=True";

        public huanShu()
        {
            InitializeComponent();
        }


        /*
         * 根据用户信息直接显示已有的借书记录
         */
        private void huanShu_Load(object sender, EventArgs e)
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
    }
}
