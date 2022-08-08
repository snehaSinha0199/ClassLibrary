namespace ClassLibrary1
{
    public class Class1
    {
        public int firstNumberField;
        public int secondNumberField;

        //properties - readonly, writeonly
        public int firstNumber { get; set; }
        public int secondNumber { get; set; }

        public string result = String.Empty;

        public Class1()
        {

        }
        public Class1(int firstNumberField)
        {
            this.firstNumberField = firstNumberField;
        }


        public Class1(int firstNumberField, int secondNumberField)
        {
            this.firstNumberField = firstNumberField;
            this.secondNumberField = secondNumberField;
        }

        public Class1(int firstNumber, int secondNumber, int firstNumberField)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            this.firstNumberField = firstNumberField;
        }
        public Class1(int firstNumber, int secondNumber, int firstNumberField, int secondNumberField)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            this.firstNumberField = firstNumberField;
            this.secondNumberField = secondNumberField;
        }

        public Class1(int firstNumberField, String result)
        {
            this.firstNumberField = firstNumberField;
            this.result = result;
        }

        public Class1(String result)
        {
            this.result = result;
        }

        public Class1(String result, int firstNumberField)
        {
            this.result = result;
            this.firstNumberField = firstNumberField;
        }

        public Class1(int firstNumber, int secondNumber, String result)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            this.result = result;

        }

        public Class1(int firstNumber, String result, int secondNumberField)
        {
            this.firstNumber = firstNumber;
            this.result = result;
            this.secondNumberField = secondNumberField;
        }

        public Class1(String result, int firstNumber, int secondNumberField)
        {
            this.firstNumber = firstNumber;
            this.result = result;
            this.secondNumberField = secondNumberField;
        }

        public Class1(int firstNumberField, int secondNumberField, int firstNumber, String result)
        {
            this.firstNumberField = firstNumberField;
            this.secondNumberField = secondNumberField;
            this.firstNumber = firstNumber;
            this.result = result;
        }

        public Class1(String result, int firstNumberField, int secondNumberField, int firstNumber)
        {
            this.firstNumberField = firstNumberField;
            this.secondNumberField = secondNumberField;
            this.firstNumber = firstNumber;
            this.result = result;
        }

        public Class1(int firstNumberField, String result, int secondNumberField, int firstNumber)
        {
            this.firstNumberField = firstNumberField;
            this.secondNumberField = secondNumberField;
            this.firstNumber = firstNumber;
            this.result = result;
        }

        public Class1(int firstNumberField, int secondNumberField, String result, int firstNumber)
        {
            this.firstNumberField = firstNumberField;
            this.secondNumberField = secondNumberField;
            this.firstNumber = firstNumber;
            this.result = result;
        }

        public Class1(int firstNumberField, int secondNumberField, int firstNumber, int secondNumber, String result)
        {
            this.firstNumberField = firstNumberField;
            this.secondNumberField = secondNumberField;
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            this.result = result;
        }

        public Class1(String result, int firstNumberField, int secondNumberField, int firstNumber, int secondNumber)
        {
            this.firstNumberField = firstNumberField;
            this.secondNumberField = secondNumberField;
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            this.result = result;
        }

        public Class1(int firstNumberField, String result, int secondNumberField, int firstNumber, int secondNumber)
        {
            this.firstNumberField = firstNumberField;
            this.secondNumberField = secondNumberField;
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            this.result = result;
        }

        public Class1(int firstNumberField, int secondNumberField, String result, int firstNumber, int secondNumber) 
        {
            this.firstNumberField = firstNumberField;
            this.secondNumberField = secondNumberField;
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            this.result = result;
        }

        public Class1(int firstNumberField, int secondNumberField, int firstNumber, String result, int secondNumber)
        {
            this.firstNumberField = firstNumberField;
            this.secondNumberField = secondNumberField;
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            this.result = result;
        }
    }
}