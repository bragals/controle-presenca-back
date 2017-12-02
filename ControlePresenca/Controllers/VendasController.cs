using Domain.Entities;
using Domain.Interfaces;
using Infra.Repositories;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AulaSPA.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
    public class VendasController : ApiController
    {
        private readonly IVendasRepository _vendasRep = new VendasRepository();

        public IEnumerable<Vendas> Get()
        {
            return _vendasRep.ListaCompleta();
        }

        public Vendas Get(int id)
        {
            return _vendasRep.GetById(id);
        }

        public HttpResponseMessage Post(Vendas obj)
        {
            try
            {
                _vendasRep.Add(obj);
                return Request.CreateResponse(HttpStatusCode.OK, new { message = "Vinculado com sucesso", success = true });
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
                _vendasRep.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { message = "Deletado com sucesso", success = true });
            }
            catch (System.Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = e.Message, success = false });
            }
        }


    }
    }

