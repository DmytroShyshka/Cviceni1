using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Triangle
    {
        private int a;
        private int b;
        private int c;

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public int B
        {
            get { return b; }
            set { b = value; }
        }

        public int C
        {
            get { return c; }
            set { c = value; }
        }

        public bool isRovnostranny()
        {
            if (a == b && a == c && b == c)
            {
                return true;
            }
            return false;
        }

        public bool isRovnoramenny()
        {
            if (a == c || a == b || b == c)
            {
                return true;
            }
            return false;
        }

        public bool isPravouhly()
        {
            if(Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
            {
                return true;
            }
            return false;
        }
    }
}
