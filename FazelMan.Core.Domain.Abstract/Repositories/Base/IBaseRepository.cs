﻿using FazelMan.Core.Common.Dto.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using FazelMan.Core.Common.ApiResult;
using FazelMan.Core.Domain.Dto;
using Microsoft.EntityFrameworkCore;

namespace FazelMan.Core.Domain.Abstract.Repositories.Base
{
    public interface IBaseRepository<T, Type> where T : class
    {
        Task<T> InsertAsync(T entity, bool isSave = true);
        Task InsertRangeAsync(List<T> entity, bool isSave = true);
        Task<ApiResultList<T>> GetListAsync(PaginationDto pagination, bool isSortedByPriority = true, bool isSortedByCreateDate = false);
        Task<ApiResultList<T>> GetListAsync(bool isSortedByPriority = true, bool isSortedByCreateDate = false);
        Task<T> FindAsync(Type id);
        T Find(Type id);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task<Type> DeleteAsync(Type id, bool isSave = true);
        Task DeleteRangeAsync(List<T> list, bool isSave = true);
        Task<Type> UpdateAsync(T entity, bool isSave = true);
        Task<Type> UpdateRangeAsync(List<T> items, bool isSave = true);
        IQueryable<T> GetAll();
        IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] propertySelectors);
        Task<List<T>> GetAllListAsync();
        Task<List<T>> GetAllListAsync(Expression<Func<T, bool>> predicate);
    }
}
