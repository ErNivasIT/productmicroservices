using CustomerServices.Models;

namespace CustomerServices.BAL
{
    public interface ICustomerBAL
    {
        Task<IEnumerable<CustomerViewModel>> GetAllCustomers();
        Task<CustomerViewModel> Save(CustomerViewModel obj);
    }
}
