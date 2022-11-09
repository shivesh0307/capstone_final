using bank.Database;
using bank.Entities;
using System.Collections.Generic;
using System.Linq;

namespace bank.Services
{
    public class BranchService
    {
        private readonly BankdbContext context;
        public BranchService()
        {
            this.context = new BankdbContext();
        }
        public void Add(Branch branch)
        {
            context.Branches.Add(branch);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Branch branch = context.Branches.SingleOrDefault(i => i.BranchId == id);
            context.Branches.Remove(branch);
            context.SaveChanges();
        }



        public List<Branch> GetAll()
        {
           return context.Branches.ToList();
        }
    }
}
