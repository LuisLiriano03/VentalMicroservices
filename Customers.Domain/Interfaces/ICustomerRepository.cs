using System.Linq.Expressions;

namespace Customers.Domain.Interfaces
{
    public interface ICustomerRepository<TModel> where TModel : class
    {
        Task<TModel> GetAllAsync(Expression<Func<TModel, bool>> filter);
        Task<TModel> CreateData(TModel model);
        Task<bool> UpdateData(TModel model);
        Task<bool> RemoveData(TModel model);
        Task<IQueryable<TModel>> ValidateDataExistence(Expression<Func<TModel, bool>> filter = null);

    }

}
