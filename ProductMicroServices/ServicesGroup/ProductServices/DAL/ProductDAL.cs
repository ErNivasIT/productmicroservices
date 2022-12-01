using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProductServices.Models;
using ProductServices.ViewModels;

namespace ProductServices.DAL
{
    public class ProductDAL : IProductDAL
    {
        private readonly ProductsDbContext dbContext;
        private readonly IMapper mapper;

        public ProductDAL(ProductsDbContext dbContext,IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<ProductViewModel>> GetAllProducts()
        {
            var preductsViewModels=new List<ProductViewModel>();
            var res =await dbContext.Products.ToListAsync();
            preductsViewModels = mapper.Map<List<ProductViewModel>>(res);
            return preductsViewModels;
        }

        public async Task<ProductViewModel> Save(ProductViewModel obj)
        {
            var productObj = mapper.Map<Product>(obj);
            await dbContext.Products.AddAsync(productObj);
            await dbContext.SaveChangesAsync();
            return obj;
        }
    }
}
