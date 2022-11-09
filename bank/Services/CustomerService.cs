using bank.Database;
using bank.Entities;
using System.Collections.Generic;
using System.Linq;

namespace bank.Services
{
    public class CustomerService
    { 
            private readonly BankdbContext context;
            public CustomerService()
            {
                this.context = new BankdbContext();
            }
            public void Add(Customer customer)
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }

            public void Delete(int id)
            {
                Customer customer = context.Customers.SingleOrDefault(i => i.Accountno == id);
                context.Customers.Remove(customer);
                context.SaveChanges();
            }



            public List<Customer> GetAll()
            {
                return context.Customers.ToList();
            }
        
    

}
}
