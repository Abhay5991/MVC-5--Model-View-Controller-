using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiMVC5.Controllers
{
    public class ValueController : ApiController
    {
        [Route("api/AbhayAction/{id}")]

        public IHttpActionResult Get([FromUri]int id)
        {
            if (id > 5)
            {
                return Ok(1);
            }
            else
                return NotFound();
        }
    }
}
