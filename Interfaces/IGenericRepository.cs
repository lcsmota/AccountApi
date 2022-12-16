using System.Linq.Expressions;

namespace AccountApi.Interfaces;

public interface IGenericRepository<T>
{
    IQueryable<T> GetAll();
    IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression);
    void Insert(T entity);
    void Update(T entity);
    void Delete(T entity);
}
