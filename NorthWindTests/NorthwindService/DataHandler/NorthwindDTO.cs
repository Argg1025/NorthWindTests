using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace NorthWindTests
{
    public class NorthwindDTO
    {
        public List<Customer> customers = new List<Customer>();
        public Customer firstCustomer = new Customer();

         public Customer FirstCustomerToObject()
        {
            using (var db = new NorthwindEntities())
            {
                firstCustomer = db.Customers.FirstOrDefault();
            }
            return firstCustomer;
        }
        public List<Customer> CustomerToObject()
        {
            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList<Customer>();
            }
            return customers;
        }

        public int IDLength(string id)
        {
            return id.Length;
        }

        public bool UniqueID()
        {
            List<string> customerIDS = new List<string>();
            foreach (var customer in customers)
            {
                customerIDS.Add(customer.CustomerID);
            }
            if (customerIDS.Count == customerIDS.Distinct().Count()) return true;
            else return false;
        }
    }
}
