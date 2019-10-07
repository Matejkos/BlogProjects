using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MediatR_Lib.SampleNotification;
using MediatR_Lib.SampleQuery;
using Microsoft.AspNetCore.Mvc;

namespace MediatR_WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMediator mediator;
        public ValuesController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            this.mediator.Publish(new SampleNotification() { Valuetwo = id, ValueOne = 42 });
            return "success";
        }

        // GET api/values/5
        [HttpGet("{name}/{surname}")]
        public async Task<ActionResult<string>> Get(string name, string surname)
        {
            var response = this.mediator.Send(new QueryEvent()
            {
                Name = name,
                Surname = surname
            });
            return await response;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
