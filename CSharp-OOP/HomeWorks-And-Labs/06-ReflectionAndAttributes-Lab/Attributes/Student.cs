using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Attributes
{
    [Serializable]
    [Obsolete]
    [Student("Pesho", Name = "Test", CustomProperty = 5)]
    class Student
    {
        [Obsolete]
        [Student]
        public void PrintName()
        {

        }

        [Student]
        public int Age { get; set; }
    }
}
