using TrackOrders.ViewModels;

public interface ITrackOrderBAL
{
    Task<IEnumerable<TrackOrderViewModel>> GetTrackOrders();
    Task<TrackOrderViewModel> Initiate_Track(TrackOrderViewModel obj);
}