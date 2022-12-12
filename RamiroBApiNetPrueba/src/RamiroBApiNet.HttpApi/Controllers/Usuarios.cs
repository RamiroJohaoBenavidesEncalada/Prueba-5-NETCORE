using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RamiroBApiNet.HttpApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Usuarios : ControllerBase
    {
        private readonly IListaUsuariosAppService service;

        public Usuarios(IListaUsuariosAppService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<string> GetUsuario([FromQuery]string cedula)
        {
            return await service.GetUsuario(cedula);
        }
    }
}