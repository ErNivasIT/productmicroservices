using ProductServices.ViewModels;

namespace ProductServices.DAL
{
    public interface IProductDAL
    {
        Task<IEnumerable<ProductViewModel>> GetAllProducts();
        Task<ProductViewModel> Save(ProductViewModel obj);
    }
}
