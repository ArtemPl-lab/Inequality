using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inequality
{
    public struct Action
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
    public static class Operations
    {
        public static Member Multiply(Member m1, Member m2)
        {
            /*
             Multiply code
            */
            return m1;
        }
        public static Member Multiply(Member m1, List<Member> m2)
        {
            /*
             Multiply code
            */
            return m1;
        }
        public static Member Multiply(List<Member> m1, Member m2)
        {
            /*
             Multiply code
            */
            return m1[0];
        }
        public static Member Multiply(List<Member> m1, List<Member> m2)
        {
            /*
             Multiply code
            */
            return m1[0];
        }


        public static Member Division(Member m1, Member m2)
        {
            /*
             Division code
            */
            return m1;
        }
        public static Member Division(Member m1, List<Member> m2)
        {
            /*
             Division code
            */
            return m1;
        }
        public static Member Division(List<Member> m1, Member m2)
        {
            /*
             Division code
            */
            return m2;
        }
        public static Member Division(List<Member> m1, List<Member> m2)
        {
            /*
             Division code
            */
            return m1[0];
        }
    }
}
