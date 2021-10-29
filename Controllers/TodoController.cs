using api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static LinqToDB.SqlQuery.SqlPredicate;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ProductionContext _dbcontext;
        // GET: api/<TodoController>


        public TodoController(ProductionContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        [HttpGet]
        public IEnumerable<HumanResource> Get()
        {
            
            return _dbcontext.HumanResources.ToList();
            
        }


        [HttpGet("{id}")]
        public IEnumerable<HumanResource> Get(string id)
        {
            var result = _dbcontext.HumanResources.Where(a => a.通訊地址.Contains(id));
            return result;
        }

        // GET api/<TodoController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return id + "";
        //}

        // POST api/<TodoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TodoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TodoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
