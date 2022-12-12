using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RamiroBApiNet.HttpApi
{
    public interface IListaUsuariosAppService
    {
        Task<string> GetUsuario(string cedula);

    }
}