public class CustomerOrdersBAL : ICustomerOrdersBAL
{
    private readonly ICustomerOrdersDAL customerOrdersDAL;

    public CustomerOrdersBAL(ICustomerOrdersDAL _customerOrdersDAL)
    {
        customerOrdersDAL = _customerOrdersDAL;
    }
    public async Task<IEnumerable<CustomerOrderViewModel>> GetCustomerOrders()
    {
        var res = await customerOrdersDAL.GetCustomerOrders();
        return res;
    }

    public async Task<CustomerOrderViewModel> Save_Order_Details(CustomerOrderViewModel obj)
    {
        var res = await customerOrdersDAL.Save_Order_Details(obj);
        return res;
    }
}