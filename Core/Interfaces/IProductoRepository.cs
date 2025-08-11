using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IProductoRepository
    {
        Task<Producto> GetProductoByIdAsync(int id);
        Task<IReadOnlyList<Producto>> GetProductosAsync(); // al ser un metodo de solo lectura de valores usamos IReadOnlyList

    }
}
