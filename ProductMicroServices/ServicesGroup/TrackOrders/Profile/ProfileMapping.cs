using AutoMapper;
using TrackOrders.Models;
using TrackOrders.ViewModels;

public class ProfileMapping:Profile
{
public ProfileMapping()
{
    CreateMap<TrackOrder,TrackOrderViewModel>();
    CreateMap<TrackOrderViewModel,TrackOrder>();
}
}