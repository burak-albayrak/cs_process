namespace Inheritance
{
    class Program
    {
        static void Main(String[] args)
        {
            Person[] persons = new Person[3]
                {
                    new Customer
                    {
                        FirstName = "Burak"
                    },
                    new Student
                    {
                        LastName = "Albayrak"
                    },
                    new Person
                    {
                        Id = 123124
                    }
                }
                ;
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
                Console.WriteLine(person.LastName);
                Console.WriteLine(person.Id);
            }
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}
