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

        protected void AddInclude(Expression<Func<T, object >> includeExpression){
            Includes.Add(includeExpression);
        }
    }
}