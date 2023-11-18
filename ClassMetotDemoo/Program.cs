namespace ClassMetotDemoo
{
    class program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();

            customer1.Id = 1;
            customer1.FirsName = "mustafa";
            customer1.LastName = "özdemir";
            customer1.Phone = "5555555555";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirsName = "enes";
            customer2.LastName = "uyanık";
            customer2.Phone = "7777777777";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.UpDate(customer1);
            customerManager.Delete(customer1);
            customerManager.List(customer1);

            customerManager.Add(customer2);
            customerManager.UpDate(customer2);
            customerManager.Delete(customer2);
            customerManager.List(customer2);

            List<Customer> customers = new List<Customer>() { customer1, customer2 };
            foreach (var item in customers)
            {
                customerManager.List(item);

            }
        }
    }
}
