using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA1
{
    static class Global
    {
        private static string gname = "";
        private static string glastname = "";

        public static string Gname
        {
            get { return gname; }
            set { gname = value; }
        }

        public static string Glastname
        {
            get { return glastname; }
            set { glastname = value; }
        }
    }
}
