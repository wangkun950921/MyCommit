using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace LibraryManegementSystem
{
    class dbope
    {
        public DataTable chaxun()
        {
            string connstr = "Server=USER\\SQLEXPRESS;Database=dblibrary;Trusted_Connection=SSPI";

            SqlConnection conn = new SqlConnection(connstr);
            try
            {
                //Open DataBase
                //打开数据库
                conn.Open();
                string sqlstr = "select * from book";
                //  Console.WriteLine("dsadasdasddddddddddddddddd");
                SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds.Tables[0];
                

               
            }
       
            finally
            {
                //Close DataBase
                //关闭数据库连接
                conn.Close();
            }
        }

        public DataTable chaxun2(string shuming)
        {
            string connstr = "Server=USER\\SQLEXPRESS;Database=dblibrary;Trusted_Connection=SSPI";

            SqlConnection conn = new SqlConnection(connstr);
            try
            {
                //Open DataBase
                //打开数据库
                conn.Open();
                string sqlstr = "select * from book where name='"+shuming+"'";
                //  Console.WriteLine("dsadasdasddddddddddddddddd");
                SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds.Tables[0];
              

              
            }
           
            finally
            {
                //Close DataBase
                //关闭数据库连接
                conn.Close();
            }
        }
        public void addperson(string mingzi, string mima, string banji)
        {
            string connstr = "Server=USER\\SQLEXPRESS;Database=dblibrary;Trusted_Connection=SSPI";

            SqlConnection conn = new SqlConnection(connstr);
            try
            {
               
              
                conn.Open();
                string sqlstr = "insert into yonghu(sname,passwords,class)values('" + mingzi + "','" + mima + "','" + banji + "')";

                SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                Console.WriteLine("Success");


               
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
              
                conn.Close();
            }
        }

        public void addbbok(string bianhao, string shuming, string chubanshe, string jiage, string jieyue)
        {
            string connstr = "Server=USER\\SQLEXPRESS;Database=dblibrary;Trusted_Connection=SSPI";

            SqlConnection conn = new SqlConnection(connstr);
            try
            {
                //Open DataBase
                //打开数据库
                conn.Open();
                string sqlstr = "insert into book(id,name,republic,price,rent)values('" + bianhao + "','" + shuming + "','" + chubanshe + "','" + jiage + "','" + jieyue + "')";

                SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                Console.WriteLine("Success");


                // IsCanConnectioned = true;
            }
            catch (Exception ex)
            {
                //   MessageBox.Show("失败");
                //Can not Open DataBase
                //打开不成功 则连接不成功
                //  IsCanConnectioned = false;
            }
            finally
            {
                //Close DataBase
                //关闭数据库连接
                conn.Close();
            }
         }


        public Boolean shanchu(string shuming)
        {
            string connstr = "Server=USER\\SQLEXPRESS;Database=dblibrary;Trusted_Connection=SSPI";

            SqlConnection conn = new SqlConnection(connstr);
            try
            {
                //Open DataBase
                //打开数据库
                conn.Open();
                
                string sqlstr = "select id,name,republic,price,rent from book";
               
               
                SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
               int flag = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    if (shuming == dt.Rows[i]["name"].ToString())
                    {

                        flag = 1;
                        break;

                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine("qqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqq");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("delete from book where name='" + shuming + "'", conn);
                    cmd.ExecuteNonQuery();
                 
                }

                if (flag == 1)
                    return true;
                else 
                    return false;
            }
            catch (Exception ex)
            {
                //   MessageBox.Show("失败");   Console.WriteLine("qqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqq");
                //Can not Open DataBase
                //打开不成功 则连接不成功
                //  IsCanConnectioned = false;
                return false;
            }
            finally
            {
                //Close DataBase
                //关闭数据库连接
                conn.Close();
            }
        }

        public Boolean denglu(string mingzi, string passwords)
        {
            string connstr = "Server=USER\\SQLEXPRESS;Database=dblibrary;Trusted_Connection=SSPI";
            SqlConnection conn = new SqlConnection(connstr);
            try
            {

                conn.Open();
                string sqlstr = "select passwords from yonghu where sname='" + mingzi + "'";
              
                SqlCommand da = new SqlCommand(sqlstr, conn);
                
                DataSet ds = new DataSet();
                
                string passcheck = Convert.ToString(da.ExecuteScalar());
                
              
               
                if (passcheck == passwords)
                {
                   
                    return true;
                    
                }
                else
                {
                    Console.WriteLine("qqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqq");
                    
                    return false;
                }
            }
            catch (Exception ex)
            {
                //   MessageBox.Show("失败");   Console.WriteLine("qqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqq");
                //Can not Open DataBase
                //打开不成功 则连接不成功
                //  IsCanConnectioned = false;
                return false;
            }
            finally
            {
                //Close DataBase
                //关闭数据库连接
                conn.Close();
            }
        }

        public Boolean xiugai(string shuming,string bianhao1,string shuming1,string chubanshe1,string jiage1,string jieyue1)
        {
            string connstr = "Server=USER\\SQLEXPRESS;Database=dblibrary;Trusted_Connection=SSPI";

            SqlConnection conn = new SqlConnection(connstr);
            try
            {
                //Open DataBase
                //打开数据库
                conn.Open();

                string sqlstr = "select id,name,republic,price,rent from book";


                SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                int flag = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    if (shuming == dt.Rows[i]["name"].ToString())
                    {

                        flag = 1;
                        break;

                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine("qqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqq");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("update book set id='" + bianhao1 + "',name='" + shuming1 + "',republic='" + chubanshe1 + "',price='" + jiage1 + "',rent='" + jieyue1 + "' where name='" + shuming + "'", conn);
                    cmd.ExecuteNonQuery();

                }
                if (flag==1)
                {

                    return true;

                }
                else
                {
                    Console.WriteLine("qqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqq");

                    return false;
                }
            }
            catch (Exception ex)
            {
                //   MessageBox.Show("失败");   Console.WriteLine("qqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqq");
                //Can not Open DataBase
                //打开不成功 则连接不成功
                //  IsCanConnectioned = false;
                return false;
            }
            finally
            {
                //Close DataBase
                //关闭数据库连接
                conn.Close();
            }

               

        }

    }
}
