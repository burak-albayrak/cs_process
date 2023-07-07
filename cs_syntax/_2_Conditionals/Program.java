namespace Conditionals
{
    class Program
    {
        static void Main(String[] args)
        {
            var number = 11;
            
            // Causal if-else conditional.
            if (number == 10)
            {
                Console.WriteLine("Number is 10.");
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is 20.");
            }
            else
            {
                Console.WriteLine("Number is not 10 or 20.");
            }
            
            // Single line if-else conditional.
            
            Console.WriteLine(number == 11 ? "Number is 10." : "Number is not 10.");
            
            // Switch-case conditional.

            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                default:
                    Console.WriteLine("Number is nnot 10 or 20");
                    break;
            }
        }
    }
}

