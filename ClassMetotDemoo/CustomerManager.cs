using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemoo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Eklendi:"+customer.FirsName+""+customer.LastName);

        }
        public void Delete(Customer customer) 
        {
            Console.WriteLine( "Silindi "+customer.FirsName+customer.LastName);

        }
        public void UpDate(Customer customer)
        {
            Console.WriteLine("Güncellendi "+customer.FirsName+customer.LastName);

        }
        public void List(Customer customer)
        {
            Console.WriteLine("Listelendi"+customer.FirsName+customer.LastName);

        }
        
       
    }
}
