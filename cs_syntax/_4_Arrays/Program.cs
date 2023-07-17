namespace Arrays
{
    class Program
    {
        static void Main(String[] args)
        {
            string[] students = new String[3];
            students[0] = "Murat";
            students[1] = "Mehmet";
            students[2] = "Mustafa";

            string[] students2 = { "Ahmet", "Burak", "Yusuf" };
            
            //Matrix
            string[,] cities = new string[3, 3]
            {
                { "Istanbul", "Izmit", "Balıkesir" },
                { "Ankara", "Konya", "Kırıkkale" },
                { "Antalya", "Adana", "Mersin" }
            };
            
            Console.WriteLine(students[1]);
            Console.WriteLine(students2[2]);
            Console.WriteLine(cities[1,0]);
        }
    }
}

