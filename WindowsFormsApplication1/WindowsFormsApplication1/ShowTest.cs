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
    public partial class ShowTest : Form
    {

        static string constr = "Data Source=.\\sqlexpress;Initial Catalog=MyLibrary;Integrated Security=True";
        Opertion bean = new Opertion();
        SqlConnection conn = new SqlConnection(constr);

        public ShowTest()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sqlstr = "select * from User1";
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            

            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
            //bean.
        }
    }
}
