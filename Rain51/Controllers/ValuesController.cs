using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Rain51.Controllers
{
    [Authorize]
    [EnableCors("EnableCORS")]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private static Novice novica1 = new Novice(1, "Neven", "Besedilo123");
        private static Novice novica2 = new Novice(2, "Marko", "Besedilo231");
        private static Novice novica3 = new Novice(3, "Goran", "Besedilo312");

        private static List<Novice> seznamNovic = new List<Novice> { novica1, novica2, novica3 };

        // GET api/values
        [HttpGet]
        [Authorize(Roles = "Admin, User")]
        public ActionResult<IEnumerable<Novice>> Get()
        {
            return seznamNovic;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin, User")]
        public ActionResult<Novice> Get(int id)
        {
            int index = getIndexOfNovica(id);
            if(index != -1)
            {
                return seznamNovic[index];
            }
            return new Novice(0, "", "");
        }

        // POST api/values
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public void Post([FromBody] Novice value)
        {
            seznamNovic.Add(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public void Put(int id, [FromBody] Novice value)
        {
            int index = getIndexOfNovica(id);
            if(index != -1)
            {
                seznamNovic[index] = value;
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public void Delete(int id)
        {
            int index = getIndexOfNovica(id);
            seznamNovic.RemoveAt(index);
        }

        private int getIndexOfNovica(int id)
        {
            for (int i = 0; i < seznamNovic.Capacity; i++)
            {
                if (seznamNovic[i].NoviceId == id) return id;
            }
            return -1;
        }
    }
}
