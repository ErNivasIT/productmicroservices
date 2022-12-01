using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TrackOrders.Models;
using TrackOrders.ViewModels;

public class TrackOrderDAL : ITrackOrderDAL
{
    private readonly ApplicationContext context;
    private readonly IMapper mapper;

    public TrackOrderDAL(ApplicationContext context, IMapper mapper)
    {
        this.context = context;
        this.mapper = mapper;
    }
    public async Task<IEnumerable<TrackOrderViewModel>> GetTrackOrders()
    {
        var res = await context.TrackOrders.ToListAsync();
        var trackOrders = mapper.Map<IEnumerable<TrackOrderViewModel>>(res);
        return trackOrders;
    }

    public async Task<TrackOrderViewModel> Initiate_Track(TrackOrderViewModel obj)
    {
        var model = mapper.Map<TrackOrder>(obj);
        var res = await context.TrackOrders.AddAsync(model);
        await context.SaveChangesAsync();
        return obj;
    }
}
