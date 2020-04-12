using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inequality
{
    class Number
    {
        public Sign sign;
        public uint digit;
        public int degree_num = 1;

        public Number(string str)
        {

        }
        public Number()
        {

        }
        public void SignReverse()
        {
            /*
               Reverse code
            */
        }
        public int Abs()
        {
            return Convert.ToInt32(digit);
        }
        protected void ParseNumber(string str)
        {
            /*
               Parse code
            */
        }
    }
}
