namespace StructLibrary
{
    //primitive types, struct -> value types -> stored in stack memory
    //classes, delegates, string -> reference types -> stored heap memory
    //stack - primitive types int i = 10;

    //heap A a = new A();

    //class is a reference type - object stored in heap memory - supports inheritance
    //struct is value type - stored in stack memory - wont support inheritance

    public struct Struct1 
    {
      public  int a =2;
        //byte b = 128; it wont allow because its out of range
      public  byte b = 100;
       public decimal d = 20.0M; //We need to attach M with the literal value of decimal otherwise
        //compiler wont do it implicity and it will give error.
        public long l = 1200;
      public  float f = 20.0f;
       public double e = 40.0;
       public short s = 6;
        public int width;
        public int height;

        public Struct1(int width, int height,int a)
        {
            this.a = a;
            this.width = width;
            this.height = height;
            Console.WriteLine(a);
            Console.WriteLine("Area of rectangle of is {0}", width * height);
        }//if we are declaring primitive inside struct we need to make an constructors explicitly

      // public Struct1() { }


    }
}