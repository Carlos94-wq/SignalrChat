using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Sockets.Entities;
using Sockets.Hubs;
using Sockets.Hubs.Clients;
using Sockets.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sockets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SenderController : ControllerBase
    {
        private readonly IHubContext<Mensajes, IChatclient> _context;

        public SenderController(IHubContext<Mensajes, IChatclient> context)
        {
            this._context = context;
        }

        [HttpPost]
        public async Task<IActionResult> SendArticulo([FromBody] Mensaje mensaje) 
        {
            await _context.Clients.All.Notificar(mensaje);
            var respose = new ApiResponse<string>("datos enviados");
            return Ok(respose);
        }
    }
}
