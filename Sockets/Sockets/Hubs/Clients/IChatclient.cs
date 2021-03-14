using Sockets.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sockets.Hubs.Clients
{
    public interface IChatclient
    {
        Task Notificar(Mensaje mensajes);
    }
}
