
using Microsoft.AspNetCore.Mvc;

namespace CustomerOrders.Controller;
[ApiController]
[Route("api/[controller]")]
public class CustomerOrdersController : ControllerBase
{
    private readonly ILogger<CustomerOrdersController> logger;
    private readonly ICustomerOrdersBAL ordersBAL;

    public CustomerOrdersController(ILogger<CustomerOrdersController> logger, ICustomerOrdersBAL ordersBAL)
    {
        this.logger = logger;
        this.ordersBAL = ordersBAL;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<CustomerOrderViewModel>>> Get()
    {
        var res = await ordersBAL.GetCustomerOrders();
        return Ok(res);
    }
    [HttpPost]
    public async Task<ActionResult<CustomerOrderViewModel>> Save(CustomerOrderViewModel obj)
    {
        var res = await ordersBAL.Save_Order_Details(obj);
        return Ok(res);
    }
}