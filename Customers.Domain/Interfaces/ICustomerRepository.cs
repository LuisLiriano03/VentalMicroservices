using Customers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customers.Domain.Entities;
using System.Linq.Expressions;

namespace Customers.Domain.Interfaces
{
    public interface ICustomerRepository<TModel> where TModel : class
    {
        Task<TModel> GetDataDetails(Expression<Func<TModel, bool>> filter);
        Task<TModel> CreateData(TModel model);
        Task<bool> UpdateData(TModel model);
        Task<bool> RemoveData(TModel model);
        Task<IQueryable<TModel>> ValidateDataExistence(Expression<Func<TModel, bool>> filter = null);

    }

}
