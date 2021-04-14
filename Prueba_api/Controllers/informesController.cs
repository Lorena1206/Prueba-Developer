using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prueba_Api.Data;
using Prueba_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_Api.Controllers
{
    [Route("api/tickets")]
    [ApiController]
    public class informesController : ControllerBase
    {

        private readonly tickets _contexto;

        public informesController(tickets contexto)
        {
            _contexto = contexto;
        }

        [HttpGet]
        public List<Informacion> GetTicket()
        {
            var informacion = _contexto.Infomacionitems.ToList();
            return informacion;
        }

        [HttpPost]
        public String CrearTicket(Informacion ticket)
        {
            try {
                _contexto.Infomacionitems.Add(ticket);
                _contexto.SaveChanges();
                return "Ticket creado";
            }
            catch (Exception error)
            {
                return error.ToString();

            }
         

        }

        [HttpPut]
        public string ActualizarTicker(updateModel datos)
        {
            try
            {
                var ticket = _contexto.Infomacionitems.SingleOrDefault(e => e.id == datos.id);
                ticket.Estatus = datos.Estatus;
                _contexto.SaveChanges();
                return "Registro actualizado exitosamente";
            }catch(Exception error)
            {
                return error.ToString();
            }
        }

            
    }
}
