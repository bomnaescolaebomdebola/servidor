using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Servidor.Controllers
{
    [Route("api/[controller]")]
    public class ControllerBase : Controller
    {

        public bool validaToken()
        {
            return true;
        }

        public string getIdentificador()
        {
            try
            {
                string identificador = Request.Headers["token"].ToString();

                if (identificador.Trim().Equals(""))
                {
                    throw new Exception("Token não encontrado");
                }

               return identificador; 
            }
            catch
            {
                throw;
            }
        }
    }
}
