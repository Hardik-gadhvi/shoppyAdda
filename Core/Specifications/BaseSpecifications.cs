using System.Linq.Expressions;

namespace Core.Specifications
{
    public class BaseSpecifications<T> : ISpecification<T>
    {
        public BaseSpecifications(){

        }
        public BaseSpecifications(Expression<Func<T, bool>> critaria){

            Critaria = critaria;
        } 
        public Expression<Func<T, bool>> Critaria {get;}

        public List<Expression<Func<T, object>>> Includes {get;} = 
            new List<Expression<Func<T, object>>>();

        public Expression<Func<T, object>> OrderBy { get; private set; }

        public Expression<Func<T, object>> OrderByDecending { get; private set; }

        public int Take { get; private set; }

        public int Skip { get; private set; }

        public bool IsPagingEnabled { get; private set; }

        protected void AddInclude(Expression<Func<T, object >> includeExpression){
            Includes.Add(includeExpression);
        }

        protected void AddOrderBy(Expression<Func<T, object >> orderByExpression)
        {
            OrderBy = orderByExpression;
        }
        protected void AddOrderByDecending(Expression<Func<T, object >> orderByDecExpression)
        {
            OrderByDecending = orderByDecExpression;
        }
        protected void AddPaging(int skip, int take){
            Skip = skip;
            Take = take;
            IsPagingEnabled = true;
        }
    }
}