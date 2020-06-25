using RestAPI_Core.Contracts;
using System.Threading.Tasks;

namespace RestAPI_Core.Business
{
    public interface IProductBusiness
    {
        Task<ProductResponse> GetAsync(long id);
        Task<ProductResponse> GetAllAsync();
        Task AddAsync(ProductRequest productRequest);
    }
}
