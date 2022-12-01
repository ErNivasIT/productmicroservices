using CustomerServices.Models;

namespace CustomerServices.BAL
{
    public interface ICustomerDAL
    {
        Task<IEnumerable<CustomerViewModel>> GetAllCustomers();
        Task<CustomerViewModel> Save(CustomerViewModel obj);
    }
}
