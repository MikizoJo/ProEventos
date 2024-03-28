using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento(){
                    EventoID = 1,
                    Tema = "Angular 11 e .NET5",
                    Local = "Lucelia",
                    Lote = "1",
                    QtdPessoas=250,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImagemURL = "foto.jpg"
                },  
                new Evento(){
                    EventoID = 2,
                    Tema = "Angular 11  e novidades",
                    Local = "Adamantina",
                    Lote = "2",
                    QtdPessoas=150,
                    DataEvento = DateTime.Now.AddDays(4).ToString(),
                    ImagemURL = "foto1.jpg"
                }              
            }; 
        public EventoController()
        {
            
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetByID(int id)
        {
            return _evento.Where(evento => evento.EventoID == id);
        }

         [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpPost]
        public string Post()
        {
            return "Ex. Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Ex. Put id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Ex. Delete id = {id}";
        }
    }
}
