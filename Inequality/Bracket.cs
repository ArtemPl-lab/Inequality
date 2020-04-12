using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inequality
{
    public class Bracket
    {
        public int firstMember;
        public int lastMember;
        public int priority;
        public Sign sign;
        public List<Member> membersInBracket;
    }
}
