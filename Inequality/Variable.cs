using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inequality
{
    public class Variable : Number
    {
        public int degree_var = 1;
        public List<char> variable = new List<char>();
        public Variable(string str)
        {
            ParseVar(str);
        }
        public Variable()
        {

        }
        public unsafe void ParseVar(string str)
        {
            int i = 0;
            sign = Parser.ParseSign(str, &i);
            digit = Convert.ToUInt32(Parser.ParseDigit(str, &i));
            degree_num = Parser.ParseDegree(str, &i);
            variable = Parser.ParseVar(str, &i);
            degree_var = Parser.ParseDegree(str, &i);
        }
    }
}
