namespace Methods
{
    class Program
    {
        static void Main(String[] args)
        {
            Add();
            Sum(20, 30);
            var result = Sum(20, 30);
            Console.WriteLine(result);
            
            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2,4,5));
            
            Console.WriteLine(Sum2(2,3,4,1,2,5,2));
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        //Method Overloading
        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }
        //Params Keyword
        static int Sum2(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
