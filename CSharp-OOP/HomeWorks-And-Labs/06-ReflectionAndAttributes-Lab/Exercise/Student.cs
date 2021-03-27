using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class Student : ICloneable, IComparable
    {
        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public void Hello()
        {

        }
    }
}
