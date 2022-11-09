using bank.Database;
using bank.Entities;

namespace bank.Services
{
    public class adminService
    {

        private readonly BankdbContext context;
        public adminService()
        {
            this.context = new BankdbContext();
        }
        public bool verify(admin Admin)
        {
            var user=context.admins.Where(u=>u.userid==Admin.userid && u.password==Admin.password).FirstOrDefault();
            if (user != null)
                return true;
            return false;
        }
    }
}
