using AutoMapper;
using CustomerServices.BAL;
using CustomerServices.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerServices.DAL
{
    public class CustomerDAL : ICustomerDAL
    {
        private readonly CustomersDbContext customersDbContext;
        private readonly IMapper mapper;

        public CustomerDAL(CustomersDbContext customersDbContext,IMapper mapper)
        {
            this.customersDbContext = customersDbContext;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<CustomerViewModel>> GetAllCustomers()
        {
            var res=await customersDbContext.Customers.ToListAsync();
            return mapper.Map<IEnumerable<CustomerViewModel>>(res);
        }

        public async Task<CustomerViewModel> Save(CustomerViewModel obj)
        {
            var cust = mapper.Map<Customer>(obj);
            await customersDbContext.Customers.AddAsync(cust);
            await customersDbContext.SaveChangesAsync();
            return obj;
        }
    }
}
