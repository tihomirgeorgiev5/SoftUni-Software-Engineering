using System;
using System.Collections.Generic;
using System.Text;

namespace Attributes
{
    class StudentAttribute : Attribute
    {
        public StudentAttribute()
        {

        }

        public StudentAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public int CustomProperty { get; set; }
    }
}
