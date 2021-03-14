using Microsoft.AspNetCore.SignalR;
using Sockets.Entities;
using Sockets.Hubs.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sockets.Hubs
{
    public class Mensajes: Hub<IChatclient>
    {
        public async Task NotificaAtodos(Mensaje mensaje)
        {
            await Clients.All.Notificar(mensaje);
        }
    }
}
