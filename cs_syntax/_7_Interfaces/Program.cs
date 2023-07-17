namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new OracleCustomerDal(),
                new SqlServerCustomerDal(),
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
                customerDal.Delete();
                customerDal.Update();
            }
        }
    }
}
