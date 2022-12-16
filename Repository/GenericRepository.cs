using System.Linq.Expressions;
using AccountApi.Context;
using AccountApi.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AccountApi.Repository;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly AppDbContext _context;
    public GenericRepository(AppDbContext context)
    {
        _context = context;
    }

    public IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression)
        => _context.Set<T>().AsNoTracking().Where(expression);

    public IQueryable<T> GetAll()
        => _context.Set<T>().AsNoTracking();

    public void Insert(T entity)
        => _context.Set<T>().Add(entity);

    public void Update(T entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        _context.Set<T>().Update(entity);
    }
    public void Delete(T entity)
        => _context.Set<T>().Remove(entity);
}
