using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Servidor.Controllers
{
    [Route("api/[controller]")]
    public class ChamadaController : ControllerBase
    {
        private Model.Repository.IRepositoryMongo<Model.Chamada.Chamada> repository;

        public ChamadaController(Model.Repository.IRepositoryMongo<Model.Chamada.Chamada> repository)
        {
            this.repository = repository;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(this.repository.Get("bebb"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // GET api/values/5
      

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Model.Chamada.Chamada value)
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



        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(String id, [FromBody]Model.Chamada.Chamada value)
        {
            try
            {
                this.repository.Edit("bebb", value);
                return Ok(value);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                this.repository.Delete(
                    "bebb",
                    this.repository.Get("bebb"
                        ).FirstOrDefault(x => x.Id.Equals(id))
                );

                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}