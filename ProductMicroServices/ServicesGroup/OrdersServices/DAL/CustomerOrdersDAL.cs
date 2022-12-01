using AutoMapper;
using MongoDB.Services;

public class CustomerOrdersDAL : ICustomerOrdersDAL
{
    private readonly CustomerOrdersService service;
    private readonly IMapper mapper;

    public CustomerOrdersDAL(CustomerOrdersService service, IMapper mapper)
    {
        this.service = service;
        this.mapper = mapper;
    }
    public async Task<IEnumerable<CustomerOrderViewModel>> GetCustomerOrders()
    {
        var res = await service.GetAsync();
        var models = mapper.Map<IEnumerable<CustomerOrderViewModel>>(res);
        return models;
    }

    public async Task<CustomerOrderViewModel> Save_Order_Details(CustomerOrderViewModel obj)
    {
        var model = mapper.Map<CustomerOrder>(obj);
        await service.CreateAsync(model);
        return obj;
    }
}