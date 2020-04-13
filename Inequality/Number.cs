using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inequality
{
    public class Number
    {
        public Sign sign;
        public uint digit;
        public int degree_num = 1;

        public Number(string str)
        {
            ParseNumber(str);
        }
        public Number()
        {

        }
        public void SignReverse()
        {
            sign = (Sign.PLUS == sign) ? Sign.MINUS : Sign.PLUS;
        }
        public int Abs()
        {
            return Convert.ToInt32(digit);
        }
        private unsafe void ParseNumber(string str)
        {
            int i = 0;
            sign = Parser.ParseSign(str, &i);
            digit = Convert.ToUInt32(Parser.ParseDigit(str, &i));
            degree_num = Parser.ParseDegree(str, &i);
        }
    }
}
