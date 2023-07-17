namespace Classes
{
    class Program
    {
        static void Main(String[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.FirstName = "Burak";
            customer.LastName = "Albayrak";
            customer.City = "Ankara";
            customer.Id = 12345;

            Customer customer2 = new Customer
            {
                Id = 213234, City = "Istanbul", FirstName = "Ahmet", LastName = "Albayrak"
            };
            
            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer.LastName);
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added.");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated.");
        }
    }
}
