using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inequality
{
    struct Action
    {
        public Opeeration opeeration;
        public int degree;
        public int firstMember;
        public int secondMember;
        public Action(Opeeration o, int f, int s, int d = 1)
        {
            opeeration = o;
            degree = d;
            firstMember = f;
            secondMember = s;
        }
    }
    class Expression
    {
        public List<Member> exp;
        public List<Action> opeerations;
        public List<Bracket> brackets;
    }
}
