using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManegementSystem
{
    class yonghu
    {
        string name;
        string passwords;
        string banji;

        public yonghu(string name, string passwords, string banji)
        {
            this.name = name;
            this.passwords = passwords;
            this.banji = banji;
        }

        public string getname()
        {
            return name;
        }

        public string getpasswords()
        {
            return passwords;
        }

        public string getbanji()
        {
            return banji;
        }

    }
}
