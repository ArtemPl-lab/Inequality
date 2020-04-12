using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inequality
{
    public static class Parser
    {
        public unsafe static int ParseDegree(string str, int* i)
        {
            if(str[*i] == '^')
            {
                *i += 1;
                return ParseDigit(str,i);
            }
            else
            {
                return 1;
            }
                
        }
        public unsafe static int ParseDigit(string str, int* i)
        {
            string num = "";
            for(;*i < str.Length && char.IsDigit(str[*i]); *i+=1)
            {
                num += str[*i];
            }
            if (num != "")
                return Convert.ToInt32(num);
            else
                return -1;
        }
        public unsafe static Sign ParseSign(string str, int* i)
        {
            if (str[*i] == '-')
            {
                *i += 1;
                return Sign.MINUS;
            }  
            else if (str[*i] == '+')
            {
                *i += 1;
                return Sign.PLUS;
            }  
            else if (char.IsDigit(str[*i]))
            {
                return Sign.PLUS;
            }    
            else
                return Sign.NONE;

            
        }
        public unsafe static List<char> ParseVar(string str, int* i)
        {
            List<char> v = new List<char>();
            /*
             Parse code
             */
            return v;
        }
    }
}
