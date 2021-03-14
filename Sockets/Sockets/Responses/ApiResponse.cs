using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sockets.Responses
{
    public class ApiResponse<T>
    {
        public T Data { get; set; }

        public ApiResponse(T data)
        {
            this.Data = data;
        }
    }
}
