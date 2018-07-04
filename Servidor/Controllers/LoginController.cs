using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Servidor.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private Model.Repository.IRepositoryMongo<Model.Voluntario.Voluntario> repository;

        public LoginController(Model.Repository.IRepositoryMongo<Model.Voluntario.Voluntario> repository)
        {
            this.repository = repository;
        }

    
        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Model.Voluntario.Voluntario value)
        {
            try
            {

                this.repository.Add("bebb", value);

                return Ok(value);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }




    }
}