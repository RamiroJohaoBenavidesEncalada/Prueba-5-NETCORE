using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RamiroBApiNet.HttpApi
{
    public class ListaUsuariosAppService : IListaUsuariosAppService
    {
        private readonly ILogger<ListaUsuariosAppService> logger;

        public ListaUsuariosAppService(ILogger<ListaUsuariosAppService> logger)
        {
            this.logger = logger;
        }

        public async Task<string> GetUsuario(string cedula)
        {
            logger.LogInformation("Agregando usuarios a la lista");

            var listaUsuarios = new List<Usuarios>() { new Usuarios("Ramiro", "123456789") };

            listaUsuarios.Add(new Usuarios("Jose", "12314745"));
            listaUsuarios.Add(new Usuarios("Pedro", "12322245"));

            var consulta = listaUsuarios.Where(x => x.Cedula.Contains(cedula));
            var existe = consulta.Any();
            if (existe)
            {
                string result = string.Empty;
                byte[] encrypted = System.Text.Encoding.Unicode.GetBytes(cedula);
                result = Convert.ToBase64String(encrypted);
                System.Console.WriteLine($"");


                var msg = $"||METODO GET||cedula:{result}||CODIGO 200||";
                logger.LogInformation(msg);

                var mensaje1=$"||METODO GET||cedula:{result}||CODIGO 200||";
                return mensaje1;
            }

            string result2 = string.Empty;
            byte[] encrypted2 = System.Text.Encoding.Unicode.GetBytes(cedula);
            result2 = Convert.ToBase64String(encrypted2);
            System.Console.WriteLine($"");
            var msg2 = $"||METODO GET||cedula:{result2}||CODIGO 404||";
            logger.LogError(msg2);
            throw new ArgumentException(msg2);

            var mensaje2 =$"||METODO GET||cedula:{result2}||CODIGO 404||";

            return mensaje2;
        }

    }
}