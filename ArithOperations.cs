namespace ArithmeticLibrary
{
    public class ArithOperations

    {
        //create project AccessModifiers
        //create ClassA
        //create methods with different access modifiers
        //create ClassB
        //try to see methods visibility
        //try to inherit
        //visibility
        //give your project to another project by adding as reference
        //create object there and try to see the visibility of methods.

        public int Add(int a)
        {
            return a + 1;

        }
        private int Subtract(int a)
        {
            return a - 1;
        }

        internal int Multiply(int a) { 
            return a * 1; 
        }
        protected int Divide(int a)
        {
            Console.WriteLine(this.Subtract(10));
            return a  / 2;
        }

        protected internal int square(int a)
        {

            return a * a;
        }

    }
   public  class B 
    {
        //Class level scope
      //  ArithOperations result = new ArithOperations();
        public void main() {
           
            //Method Level scope
            ArithOperations result = new ArithOperations();
           //public method
            Console.WriteLine(result.Add(10));
            //Internal method
            Console.WriteLine(result.Multiply(10));
            Console.WriteLine(result.square(10));
            
        }
        
    }

   public class C:ArithOperations
    { 
        public void main()
        {
            ArithOperations result = new ArithOperations();
            //Protected method
            Console.WriteLine(Divide(10));


        }

    }
}