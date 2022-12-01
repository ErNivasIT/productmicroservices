using TrackOrders.ViewModels;

public class TrackOrderBAL : ITrackOrderBAL
{
    private readonly ITrackOrderDAL orderDAL;

    public TrackOrderBAL(ITrackOrderDAL orderDAL)
    {
        this.orderDAL = orderDAL;
    }
    public async Task<IEnumerable<TrackOrderViewModel>> GetTrackOrders()
    {
        var res=await orderDAL.GetTrackOrders();
        return res;
    }

    public async Task<TrackOrderViewModel> Initiate_Track(TrackOrderViewModel obj)
    {
        var res=await orderDAL.Initiate_Track(obj);
        return res;
    }
}
