using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoAngularAPI.Models;

namespace ProjetoAngularAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
            new Evento(){
            EventoId = 1,
            Tema = "Curso Angular",
            Local = "Araraquara",
            Lote = "1º Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString(),
            ImageURL = "foto.png"

            },

            new Evento(){
            EventoId = 2,
            Tema = "Curso Bootstrap",
            Local = "Araraquara",
            Lote = "2º Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(10).ToString(),
            ImageURL = "foto.png"

            }
             
            };

        public EventoController()
        {
           
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return _evento;
        }

         [HttpGet("{id}")]
        public IEnumerable<Evento> Get(long id)
        {
           return _evento.Where(x=> x.EventoId == id);
        }
    }
}
