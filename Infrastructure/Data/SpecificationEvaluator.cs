using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Specifications;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class SpecificationEvaluator<TEntity> where TEntity : BaseEntity
    {
        public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery, ISpecification<TEntity> spec)
        {
            var query = inputQuery;

            if(spec.Critaria != null)
            {
                query = query.Where(spec.Critaria);
            }
            
            if(spec.OrderBy != null)
            {
                query = query.OrderBy(spec.OrderBy);
            }

            if(spec.OrderByDecending != null)
            {
                query = query.OrderByDescending(spec.OrderByDecending);
            }

            if(spec.IsPagingEnabled)
            {
                query = query.Skip(spec.Skip).Take(spec.Take);
            }

            query = spec.Includes.Aggregate(query, (current, include) => current.Include(include));

            return query;
        }
    }
}