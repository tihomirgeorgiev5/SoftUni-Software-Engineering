using System;
using System.Text;

namespace CreateInstance_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Type sbType = typeof(StringBuilder);
            //StringBuilder sb = (StringBuilder)Activator.CreateInstance(sbType);

            StringBuilder sb = (StringBuilder)Activator.CreateInstance(sbType,new object[] { "hi hi" });
            sb.Append("Hello");
            Console.WriteLine(sb);
        }
    }
}
