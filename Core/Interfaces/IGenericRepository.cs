using Core.Entities;
using Core.Specifications;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : ClaseBase
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> GetAllAsync();

        /* Dentro de la especificacion le pasaremos las relaciones que tendra una entidad con otras entidades */
        Task<T> GetByIdWithSpec(ISpecification<T> spec);

        /* Que devuelva todos los elementos de una lista que incluya todas las relaciones 
         * que tiene con otras entidades y que tambien incluya las condiciones de los filtos que esta devolvera */
        Task<IReadOnlyList<T>> GetAllWithSpec(ISpecification<T> spec);
        Task<int> CountAsync(ISpecification<T> spec);
    }
}
