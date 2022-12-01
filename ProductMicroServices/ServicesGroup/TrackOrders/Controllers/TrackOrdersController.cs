using Microsoft.AspNetCore.Mvc;
using TrackOrders.ViewModels;

[ApiController]
[Route("api/[controller]")]
public class TrackOrdersController : ControllerBase
{
    private readonly ITrackOrderBAL trackOrderBAL;

    public TrackOrdersController(ITrackOrderBAL trackOrderBAL)
    {
        this.trackOrderBAL = trackOrderBAL;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TrackOrderViewModel>>> GetTrackOrders()
    {
        var res = await trackOrderBAL.GetTrackOrders();
        return Ok(res);
    }
     [HttpPost]
    public async Task<ActionResult<TrackOrderViewModel>> Save_Track(TrackOrderViewModel obj)
    {
        var res = await trackOrderBAL.Initiate_Track(obj);
        return Ok(res);
    }
}