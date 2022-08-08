using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class CalculateOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {

            return a + b + c;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Subtract(int a, int b, int c)
        {

            return a - b - c;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Multiply(int a, int b, int c)
        {

            return a * b * c;
        }
        public int Divide(int a, int b)
        {
            return a / b;
        }
        public int Divide(int a, int b, int c)
        {

            return a / b / c;
        }
    }

    public class Concat
    {
        public string concatenate(string a, string b)
        {
            return a + b;
        }
    }

    public class squareroot
    {
        public float sr(int a)
        {
            return (float)Math.Sqrt(a);
        }
    }
}
