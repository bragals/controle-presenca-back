using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Context
{
    public class EventoConfiguration: EntityTypeConfiguration<Evento>
    {
        public EventoConfiguration()
        {
            HasKey(x => x.Id);
            Property(x => x.NomeEvento).HasMaxLength(150).HasColumnType("VARCHAR");
        }
    }
}
