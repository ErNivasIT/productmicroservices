using Microsoft.EntityFrameworkCore;
using ProductServices.DAL;
using ProductServices.Models;
using ProductServices.ViewModels;

namespace ProductServices.BAL
{
    public class ProductBAL : IProductBAL
    {
        private readonly IProductDAL productDAL;

        public ProductBAL(IProductDAL productDAL)
        {
            this.productDAL = productDAL;
        }
        public async Task<IEnumerable<ProductViewModel>> GetAllProducts()
        {
            var res = await productDAL.GetAllProducts();
            return res;
        }

        public async Task<ProductViewModel> Save(ProductViewModel obj)
        {
            var res = await productDAL.Save(obj);
            return res;
        }
    }
}
