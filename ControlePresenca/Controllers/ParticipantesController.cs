using Domain.Entities;
using Infra.Repositories;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AulaSPA.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
    public class ParticipantesController : ApiController
    {
        private readonly ParticipanteRepository _participanteRep = new ParticipanteRepository();

        public IEnumerable<Participante> Get()
        {
            return _participanteRep.GetAll();
        }

        public Participante Get(int id)
        {
            return _participanteRep.GetById(id);
        }

        public HttpResponseMessage Post(Participante obj)
        {
            try
            {
                _participanteRep.Add(obj);
                return Request.CreateResponse(HttpStatusCode.OK, new { message = "Cadastrado com sucesso", success = true });
            }
            catch (System.Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = e.Message, success = false });
            }
        }

        public HttpResponseMessage Put(Participante obj)
        {
            try
            {
                _participanteRep.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, new { message = "Alterado com sucesso", success = true });
            }
            catch (System.Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = e.Message, success = false });
            }
        }

        public HttpResponseMessage Delete(int id)
        {
            try
            {
                _participanteRep.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { message = "Deletado com sucesso", success = true });
            }
            catch (System.Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = e.Message, success = false });
            }
        }
    }
}
