using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IVendasRepository : IRepositoryBase<Vendas>
    {

        IEnumerable<Vendas> ListaCompleta();
    }
}
