using ProductServices.ViewModels;

namespace ProductServices.BAL
{
    public interface IProductBAL
    {
        Task<IEnumerable<ProductViewModel>> GetAllProducts();
        Task<ProductViewModel> Save(ProductViewModel obj);
    }
}
