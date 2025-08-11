using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Specifications
{
    public interface ISpecification<T>
    {
        //va a representar la condicion logica que le queremos aplicar a una entidad
        Expression<Func<T, bool>> Criteria { get; }

        //representa las relaciones que vamos a poder aplicar a una entidad
        List<Expression<Func<T, object>>> Includes { get; }
        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }
        int Take { get; }
        int Skip { get; }
        bool IsPaginEnabled { get; }
    }
}
