﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly DataContext _context;
        public EventosController(DataContext context)
        {
            _context = context;
            
        }

        [HttpGet("{id}")]
        public Evento GetByID(int id)
        {
            return _context.Eventos.FirstOrDefault(evento => evento.EventoID == id);
        }

         [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
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
