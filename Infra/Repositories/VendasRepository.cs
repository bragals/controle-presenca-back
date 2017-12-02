using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class VendasRepository : RepositoryBase<Vendas>, IVendasRepository
    {
        public IEnumerable<Vendas> ListaCompleta()
        {
            return Db.Vendas.Include("Evento").Include("Participante");
        }
    }
}
