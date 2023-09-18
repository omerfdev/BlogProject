using Domain.Entities.Abstract;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IBaseRepository<T> where T : IBaseEntity
    {
        Task AddAsync(T entity);
        Task<int> Update(T entity);
        Task DeleteAsync(T entity);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        //istenilen bir kaydı bulmak için
        Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
        //GenreID=2 list döner
        Task<List<T>> GetDefaultAsync(Expression<Func<T, bool>> predicate);
        Task<TResult> GetFilteredFirstOrDefaultAsync<TResult>(
            Expression<Func<T, TResult>> select,
            Expression<Func<T, bool>> where,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null
            );
        Task<List<TResult>> GetFilteredListAsync<TResult>(
            Expression<Func<T, TResult>> select,
            Expression<Func<T, bool>> where,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null
            );
        IQueryable<T> GetAll();
    }
}