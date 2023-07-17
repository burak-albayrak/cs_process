namespace Loops
{
    class Program
    {
        static void Main(String[] args)
        {
            //for loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            //while loop
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine(j);
                j++;
            }

            //do-while loop
            int k = 0;
            do
            {
                Console.WriteLine(k);
                k++;
            } while (k < 5);

            //foreach loop
            string[] students = new String[3] { "Ahmet", "Burak", "Ravza" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
