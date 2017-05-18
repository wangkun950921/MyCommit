﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Timers;
using WindowsFormsApplication1;


namespace WindowsFormsApplication1
{
    class Opertion
    {
        public Opertion() { }

        private string constr = "Data Source=.\\sqlexpress;Initial Catalog=MyLibrary;Integrated Security=True";

        /*
         * 用户信息的添加
         */
        public Boolean UserAdd(string zhanghao, string mima, string name, string number)
        {      
            SqlConnection conn = new SqlConnection(constr);
            try
            {
                conn.Open();
                string sqlstr = "insert into User1(Uzhanghao, Umima, Uname, Unumber)"
                    + "values('"+ zhanghao
                    + "','"+ mima
                    + "','"+ name
                    + "','"+ number +"')";
                SqlCommand comd = new SqlCommand(sqlstr, conn);
                comd.ExecuteNonQuery();
                Console.WriteLine("计算");
            /*    string sqlstr = "insert into User1(Uzhanghao, Umima, Uname, Unumber)"
                    + "values('"+ zhanghao
                    + "','"+ mima
                    + "','"+ name
                    + "','"+ number +"')";
                SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);*/
              /*  DataSet ds = new DataSet();
                da.Fill(ds);*/
                return true;
            }
            catch (Exception ex)
            {
                string er = ex.Message;
                Console.WriteLine(er);
                return false;
            }
            finally
            {
                conn.Close();      
            }
        }

        /*
         * 用户信息的修改
         */
        public Boolean UserChanges(string zhanghao, string mima, string name, string number)
        {
            SqlConnection conn = new SqlConnection(constr);
            try
            {
                conn.Open();
                /*update User1 set Uname = 'b', Unumber = 'b' 
                where Uzhanghao = 'a';*/
                string sqlstr = "update User1 set Uname = '"
                    +name
                    +"', Unumber = '"+number
                    + "', Umima = '" + mima
                    +"' where Uzhanghao = '"+ zhanghao
                    +"'";
                SqlCommand comd = new SqlCommand(sqlstr, conn);
                comd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string er = ex.Message;
                Console.WriteLine(er);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        /*
         * 用户信息的删除
         */
        public Boolean UserDelete( string zhanghao, string number)
        {
            SqlConnection conn = new SqlConnection(constr);
            try
            {
                conn.Open();
                /*update User1 set Uname = 'b', Unumber = 'b' 
                where Uzhanghao = 'a';*/
                string sqlstr = "delete from User1 where Uzhanghao = '"+ zhanghao
                    + " 'and Unumber = '"+ number + "'";
                SqlCommand comd = new SqlCommand(sqlstr, conn);
                comd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string er = ex.Message;
                Console.WriteLine(er);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        /*
         * 用户信息的查询，迟点写
         */

        /*
         * 用户信息的遍历,这个不采取封装，所以这里好像是没有用了
         * select * from User1;
         */
        public Boolean Read()
        {
            SqlConnection conn = new SqlConnection(constr);
            try
            {
                conn.Open();
                string sqlstr = "select * from User1";
                SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return true;
            }
            catch (Exception ex)
            {
                string er = ex.Message;
                Console.WriteLine(er);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        /*
         * 用户密码校验
         */
        public Boolean pswCheck(string zhanghao, string mima, string xuehao)
        {           
            SqlConnection conn = new SqlConnection(constr);
            try
            {
                conn.Open();
               // DbCommand comd;
                string sqlstr = "select Umima from User1 where Uzhanghao = '" + zhanghao
                    + "' and Unumber = '" + xuehao + "'";
                SqlCommand comd = new SqlCommand(sqlstr, conn);
               // comd.Connection();
              /*  comd.CommandText = "select Umima from User1 where Uzhanghao = '" + zhanghao
                    + "' and Unumber = '" + xuehao + "'";*/
               // comd.Connection = conn;
                string psw = comd.ExecuteScalar().ToString();
                Console.WriteLine(psw);
               /* conn.Open();
                //select Umima from User1 where Uzhanghao = 'a' and Unumber = '123456';
                string sqlstr = "select Umima from User1 where Uzhanghao = '" + zhanghao
                    + "' and Unumber = '" + xuehao + "'";
                SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);*/
                if (psw == mima)
                {
                    return true;
                }
                else
                    return false;
                //return true;
            }
            catch (Exception ex)
            {
                string er = ex.Message;
                Console.WriteLine(er);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }


        /*
         * 管理员登录校验
         */
        public Boolean gylLogin(string zhanghao, string mima)
        {
            if (zhanghao == "admin" && mima == "admin")
                return true;
            else
                return false;
          /*  SqlConnection conn = new SqlConnection(constr);
            try
            {
                conn.Open();
                // DbCommand comd;
                string sqlstr = "select Umima from User1 where Uzhanghao = '" + zhanghao
                    + "' and Unumber = '" + xuehao + "'";
                SqlCommand comd = new SqlCommand(sqlstr, conn);
                string psw = comd.ExecuteScalar().ToString();
                Console.WriteLine(psw);
                if (psw == mima)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                string er = ex.Message;
                Console.WriteLine(er);
                return false;
            }
            finally
            {
                conn.Close();
            }*/
        }

        /*
         * 图书信息的增删改
         * insert into Books(Bname, Bnumber,Bkinds, Bbuff) values('a', '123456', '自然科学', '借出');
            update Books set Bname = 'a', Bkinds = 'a',Bbuff = '未借出' where Bnumber = '123456';
            delete from Books where Bnumber = '123456';
         */
        public Boolean BookAdd(string name, string number, string kinds, string buff, string auther)
        {
            SqlConnection conn = new SqlConnection(constr);
            try
            {
                conn.Open();
                /*insert into Books(Bname, Bnumber,Bkinds, Bbuff,Bauther) values('a','1','未借出','人文','aaa');*/
                string sqlstr = "insert into Books(Bname, Bnumber,Bkinds, Bbuff,Bauther) values('"
                    + name + "', '"
                    + number + "', '"
                    + kinds + "', '"
                    + buff +  "', '"
                    + auther + "')";
                SqlCommand comd = new SqlCommand(sqlstr, conn);
                comd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string er = ex.Message;
                Console.WriteLine(er);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        //根据图书需要改变图片信息，可以用作图书的借出，根据书的编号修改
        public Boolean BookUpdateByNumber(string name, string number, string kinds, string buff,string auther)
        {
            SqlConnection conn = new SqlConnection(constr);
            try
            {
                conn.Open();
                /* update Books set Bname = 'a', Bkinds = 'a',Bbuff = '未借出' where Bnumber = '123456';*/
                string sqlstr = "update Books set Bname = '"+ name
                    + "', Bkinds = '"+ kinds
                    + "', Bbuff = '"+ buff
                    + "', Bauther = '" + auther
                    + "' where Bnumber = '"+ number + "'";
                SqlCommand comd = new SqlCommand(sqlstr, conn);
                comd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string er = ex.Message;
                Console.WriteLine(er);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }


        //根据书的名字修改
        public Boolean BookUpdateByName(string name, string number, string kinds, string buff, string auther)
        {
            SqlConnection conn = new SqlConnection(constr);
            try
            {
                conn.Open();
                /* update Books set Bname = 'a', Bkinds = 'a',Bbuff = '未借出' where Bnumber = '123456';*/
                string sqlstr = "update Books set Bnumber = '" + number
                    + "', Bkinds = '" + kinds
                    + "', Bbuff = '" + buff
                    + "', Bauther = '" + auther
                    + "' where Bname = '" + name + "'";
                SqlCommand comd = new SqlCommand(sqlstr, conn);
                comd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string er = ex.Message;
                Console.WriteLine(er);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        /*
         * 讲道理书本的修改应该根据书名和序号
         */
        
        //根据书名删除书本
        public Boolean BookDelete(string number)
        {
            SqlConnection conn = new SqlConnection(constr);
            try
            {
                conn.Open();
                /* delete from Books where Bnumber = '123456';*/
                string sqlstr = "delete from Books where Bnumber = '"
                    + number + "'";

                SqlCommand comd = new SqlCommand(sqlstr, conn);
                comd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                string er = ex.Message;
                Console.WriteLine(er);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }


        /*
         * 借书信息的增删改
         * 
         * insert into Borrow(BookName, BookNum, BorrowData, UserName) values('a', '123456', '2017/5/11', 'a');
            update Borrow set BorrowData = '2000/1/1' where (UserName = 'a' and BookNum = '123456') ;
            delete from Borrow where (UserName = 'a' and BookNum = '123456');
         */
        public Boolean BorrowAdd(string bkName, string bkNum, string bkData, string usrName)
        {
            SqlConnection conn = new SqlConnection(constr);
            try
            {
                conn.Open();
                /* insert into Borrow(BookName, BookNum, BorrowData, UserName) values('a', '123456', '2017/5/11', 'a');*/
                string sqlstr = "insert into Borrow(BookName, BookNum, BorrowData, UserName) values('"
                    + bkName + "', '"
                    + bkNum + "', '"
                    + bkData + "', '"
                    + usrName + "')";
                SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
                return true;
            }
            catch (Exception ex)
            {
                string er = ex.Message;
                Console.WriteLine(er);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public Boolean BorrowUpdate(string bkName, string bkNum, string bkData, string usrName)
        {
            SqlConnection conn = new SqlConnection(constr);
            try
            {
                conn.Open();
                /*update Borrow set BorrowData = '2000/1/1' where (UserName = 'a' and BookNum = '123456') ;*/
                string sqlstr = "update Borrow set BorrowData = '" + bkData
                    + "' where (UserName = '" + usrName
                    + "' and BookNum = '" + bkNum + "')";
                SqlCommand comd = new SqlCommand(sqlstr, conn);
                comd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string er = ex.Message;
                Console.WriteLine(er);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }


        //借书信息删除
        public Boolean BorrowDelete(string bkNum, string usrName)
        {
            SqlConnection conn = new SqlConnection(constr);
            try
            {
                conn.Open();
                /*delete from Borrow where (UserName = 'a' and BookNum = '123456');*/
                string sqlstr = "delete from Borrow where (UserName = '"+ usrName
                    + "' and BookNum = '"+ bkNum + "')";
                SqlCommand comd = new SqlCommand(sqlstr, conn);
                comd.ExecuteNonQuery();
               
                return true;
            }
            catch (Exception ex)
            {
                string er = ex.Message;
                Console.WriteLine(er);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }


        /*
         * 借书过程
         * 先检测是否可借"select Bbuff from Books where Bnumber = '" + bkNumber + "'";
         * 再计入记录表"insert into Borrow(BookName, BookNum, BorrowData, UserName) values('a', '123456', '2017/5/11', 'a');
         * 最后改变借出状态"update Books set Bbuff = '借出' where Bnumber = '125546';
         */
        public Boolean Borrows(string bkNumber)
        {
            SqlConnection conn = new SqlConnection(constr);
            try
            {
                conn.Open();
                string sqlstr = "select Bbuff from Books where Bnumber = '" + bkNumber + "'";
                SqlCommand comd = new SqlCommand(sqlstr, conn);              
                string buff = comd.ExecuteScalar().ToString();
                Console.WriteLine("buff = " + buff);
                if (buff == "借出")
                    return false;
                else
                {
                    return true;
                }
                //return true;
            }
            catch (Exception ex)
            {
                string er = ex.Message;
                Console.WriteLine(er);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        //借出书后，borrow表需要有记录，迟点写，以及book表的buff需要改变
        //insert into Borrow(BookName, BookNum, BorrowData, UserName) values('a', '123456', '2017/5/11', 'a');
        public Boolean BorrowRecord(string bkNumber, string bkName, string bwData, string urName)
        {
            SqlConnection conn = new SqlConnection(constr);
            /*DateTime currentTime = new DateTime(); 
            string strMD = currentTime.ToString("m");//取中文日期显示_月日*/
            try
            {
                conn.Open();
                string sqlstr = "insert into Borrow(BookName, BookNum, BorrowData, UserName) values('"+ bkName
                    + "', '" + bkNumber
                    + "', '" + bwData
                    + "', '" + urName +"')";
                SqlCommand comd = new SqlCommand(sqlstr, conn);
                /*string buff = */
                    comd.ExecuteNonQuery();
                //Console.WriteLine("buff = " + buff);
                return true;
            }
            catch (Exception ex)
            {
                string er = ex.Message;
                Console.WriteLine(er);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        /*
         * 最后改变借出状态"update Books set Bbuff = '借出' where Bnumber = '125546';
         */
        public Boolean BkBuffChange(string bkNumber)
        {
            SqlConnection conn = new SqlConnection(constr);
            try
            {
                conn.Open();
                string sqlstr = "update Books set Bbuff = '借出' where Bnumber = '" + bkNumber + "'";
                SqlCommand comd = new SqlCommand(sqlstr, conn);
               /* string buff = */comd.ExecuteScalar();
               /* Console.WriteLine("buff = " + buff);*/
                return true;
            }
            catch (Exception ex)
            {
                string er = ex.Message;
                Console.WriteLine(er);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        /*
         * 根据书号获取书名
         * select Bname from Books Where Bnumber = '1322';
         */
        public string GetBkName(string bkNumber)
        {
            SqlConnection conn = new SqlConnection(constr);
            string bkName = null;
            try
            {
                conn.Open();
                string sqlstr = "select Bname from Books Where Bnumber = '"+ bkNumber + "'";
                SqlCommand comd = new SqlCommand(sqlstr, conn);
                bkName = comd.ExecuteScalar().ToString();
                Console.WriteLine("bkName = " + bkName);
                return bkName;
            }
            catch (Exception ex)
            {
                string er = ex.Message;
                Console.WriteLine(er);
                return bkName;
            }
            finally
            {
                conn.Close();
            }
        }

        /*
         * 读取单个用户的信息,并保存
         * select * from User1 where Uzhanghao = 'a' and Unumber = '123456';
         */
        public Boolean ReadUsr(string zhanghao, string xuehao, Users usr)
        {
            SqlConnection conn = new SqlConnection(constr);
            try
            {
                conn.Open();
                Console.WriteLine("zhanghao = " + zhanghao + "xuehao = " + xuehao);
                string sqlstr = "select * from User1 where Uzhanghao = '" + zhanghao
                    + "' and Unumber = '" + xuehao + "'";
                Console.WriteLine("1");
                SqlCommand comd = new SqlCommand(sqlstr, conn);
                //comd.BeginExecuteReader();
                
                SqlDataReader read = comd.ExecuteReader();
                Console.WriteLine("能read吗？");
                read.Read();
                Console.WriteLine(read.ToString());
                string Uzhanghao = read.GetString(0);
                string Umima = read.GetString(1);
                string Uname = read.GetString(2);
                string Uxuehao = read.GetString(3);

                //usr = new Users(Uzhanghao, Umima, Uname, Uxuehao);
                usr.setZhanghao(Uzhanghao);
                usr.setMima(Umima);
                usr.setName(Uname);
                usr.setNumber(Uxuehao);
                usr.ToString();
                return true;
            }
            catch (Exception ex)
            {
                string er = ex.Message;
                Console.WriteLine(er);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
