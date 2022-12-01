using AutoMapper;

public class ProfileMapping:Profile{
    public ProfileMapping()
    {
        CreateMap<CustomerOrder,CustomerOrderViewModel>()
        .ForMember(p=>p.Customer_Order_ID,q=>q.MapFrom(r=>r.ID));
        CreateMap<CustomerOrderViewModel,CustomerOrder>();
    }
}