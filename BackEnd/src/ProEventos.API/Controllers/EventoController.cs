using Microsoft.AspNetCore.Mvc;
using ProEventos.Domain.Entities;
using System.Collections.Generic;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public List<Evento> evento;
        public EventoController()
        {
             evento = new List<Evento>()
            {
                new Evento()
                {
                    EventoId=1,
                    EventoName="test",
                    EventoDescription="testdescription",
                    EventoDate=DateTime.UtcNow,
                    Lote="1º Lote",
                    QtdPessoas=50,
                    Tema="Angular Submit",
                    ImagemURL=string.Empty,
                },

                new Evento()
                {
                    EventoId=2,
                    EventoName="Nodejs",
                    EventoDescription="testdescription",
                    EventoDate=DateTime.UtcNow,
                    Lote="2º Lote",
                    QtdPessoas=100,
                    Tema="Nodejs Submit",
                    ImagemURL=string.Empty,
                }
            };
        }

        [HttpGet(Name = "GetEvento")]
        public IEnumerable<Evento> Get()
        {
          
            return this.evento;
        }

        [HttpGet("{Id}",Name = "GetEventoById")]
        public IEnumerable<Evento> GetById(int Id)
        {

            return this.evento.Where(x =>x.EventoId==Id);
        }

        [HttpPost(Name = "PostEvento")]
        public string Post()
        {
            return "Post value";
        }

        [HttpPut("{Id:int}",Name = "PutEvento")]
        public string Put(int Id)
        {

            return $"Post value{Id}";
        }
    }
}