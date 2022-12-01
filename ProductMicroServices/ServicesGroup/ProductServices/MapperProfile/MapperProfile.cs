using AutoMapper;
using ProductServices.Models;
using ProductServices.ViewModels;

namespace ProductServices.MapperProfile
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<Product,ProductViewModel>();
            CreateMap<ProductViewModel, Product>();
        }
    }
}
