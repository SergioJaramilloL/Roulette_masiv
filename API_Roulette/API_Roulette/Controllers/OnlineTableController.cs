using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Roulette.Context;
using API_Roulette.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Roulette.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OnlineTableController : ControllerBase
    {
        private readonly AppDbContext context;
        public OnlineTableController(AppDbContext context)
        {
            this.context = context;
        }
        // GET: api/<OnlineTableController>
        [HttpGet]
        public IEnumerable<OnlineTable> Get()
        {
            return context.OnlineTable.ToList();
        }

        // GET api/<OnlineTableController>/5
        [HttpGet("{id}")]
        public OnlineTable Get(int id)
        {
            var OnlineTable = context.OnlineTable.FirstOrDefault(p=>p.Id == id);
            return OnlineTable;
        }

        // POST api/<OnlineTableController>
        [HttpPost]
        public ActionResult Post([FromBody] OnlineTable onlineTable)
        {
            try
            {
            context.OnlineTable.Add(onlineTable);
            context.SaveChanges();
                return Ok();
            }catch(Exception ex)
            {
                return BadRequest();
            }
        }

        // PUT api/<OnlineTableController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] OnlineTable onlineTable)
        {
            if (onlineTable.Id == id)
            {
                context.Entry(onlineTable).State = EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
            else 
            {
                return BadRequest();
            }
        }
    }
}
