using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Vendas
    {
        public int Id { get; set; }
        public Evento Evento { get; set; }
        public int EventoId { get; set; }
        public Participante Participante { get; set; }
        public int ParticipanteId { get; set; }

    }
}
