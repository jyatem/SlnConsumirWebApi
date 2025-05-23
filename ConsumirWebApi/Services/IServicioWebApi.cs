using ConsumirWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumirWebApi.Services
{
    public interface IServicioWebApi
    {
        public Task<List<Personaje>> Obtener();
    }
}
