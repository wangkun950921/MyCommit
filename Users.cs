using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Users
    {
        public Users() { }
        public Users(string zhanghao, string mima, string name, string number)
        {
            uZhanghao = zhanghao;
            uMima = mima;
            uName = name;
            uNumber = number;
        }
        public Users(Users info)
        {
            uZhanghao = info.uZhanghao;
            uMima = info.uMima;
            uName = info.uName;
            uNumber = info.uNumber;
        }

        public void ToString()
        {
            Console.WriteLine("uZhanghao = {0}, uMima = {1}, uName = {2}, uNumber = {3} ",
                uZhanghao, uMima, uName, uNumber);
        }

        private string uZhanghao;
        private string uMima;
        private string uName;
        private string uNumber;

     /*   public string getZhanghao
        {
            return uZhanghao;
        }*/
    }
}
