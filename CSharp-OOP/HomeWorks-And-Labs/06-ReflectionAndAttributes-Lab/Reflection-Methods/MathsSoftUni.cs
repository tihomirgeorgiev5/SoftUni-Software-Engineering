using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection_Methods
{
    class MathsSoftUni
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        protected int Divide(int a, int b)
        {
            return a / b;
        }

        public virtual int Percentage (int a, int b)
        {
            return a / b * 100;
        }
    }
}
