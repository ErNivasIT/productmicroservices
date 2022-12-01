using CustomerServices.Models;

namespace CustomerServices.BAL
{
    public class CustomerBAL : ICustomerBAL
    {
        private readonly ICustomerDAL customerDAL;

        public CustomerBAL(ICustomerDAL customerDAL)
        {
            this.customerDAL = customerDAL;
        }
        public async Task<IEnumerable<CustomerViewModel>> GetAllCustomers()
        {
            var res =await customerDAL.GetAllCustomers();
            return res;
        }

        public async Task<CustomerViewModel> Save(CustomerViewModel obj)
        {
            await customerDAL.Save(obj);
            return obj;
        }
    }
}
