using TrackOrders.ViewModels;

public interface ITrackOrderDAL
{
    Task<IEnumerable<TrackOrderViewModel>> GetTrackOrders();
    Task<TrackOrderViewModel> Initiate_Track(TrackOrderViewModel obj);
}