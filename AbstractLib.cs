using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractLib
{

    public abstract class AbstractLib
    {
        public int a;
        public int add(int a, int b)
        {

            return a + b;
        }
        public int subtract(int a, int b)
        {
            return a - b;
        }
        public abstract int multiply(int a, int b); // Method without body i.e, Abstract method
        public abstract int divide(int a, int b);
        public int square(int a)
        {
            return a * a;
        }
        // static AbstractLib() { } static constructors are also allowed
        public AbstractLib()
        {
            a = 10;
            Console.WriteLine("Abstract class Constructor");
        } // constructors are allowed to initialize the variables

    }



    public class AbstractClass : AbstractLib
    {
        public override int multiply(int a, int b)
        {
            int result = square(a);
            return result * b;

        }

        public int square(int a)
        {
            return a * a;
        }

        public override int divide(int a, int b)
        {
            int result = base.add(a, b);
            return result / b;
        }

        public String ClassName()
        {
            return this.GetType().Name;
        }

        public AbstractClass()
        {
            Console.WriteLine("Class which implemented the abstract class Constructor");
        }
    }
}
