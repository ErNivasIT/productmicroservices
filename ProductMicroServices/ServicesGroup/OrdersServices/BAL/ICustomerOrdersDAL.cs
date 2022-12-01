public interface ICustomerOrdersDAL
{
    public Task<IEnumerable<CustomerOrderViewModel>> GetCustomerOrders();
    public Task<CustomerOrderViewModel> Save_Order_Details(CustomerOrderViewModel obj);
}