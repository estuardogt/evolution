using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Terrazas.Models;
using Terrazas.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace Terrazas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly EvolutionWaterContext _context;

        public UsuarioController(EvolutionWaterContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable>> GetUsers()
        {
            var usuarios = _context.Usuario.AsQueryable();            

            return await usuarios.ToListAsync();

        }
    }
}