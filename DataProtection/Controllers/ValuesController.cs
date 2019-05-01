using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.DataProtection.EntityFrameworkCore;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DataProtection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private IDataProtector _protector;

        public ValuesController(IDataProtectionProvider provider)
        {
            _protector = provider.CreateProtector("DataEventRecordRepository.v1");
        }
        //// GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var encripted = _protector.Protect("Apurba");
            Console.WriteLine(encripted);

            var dycripted = _protector.Unprotect(encripted);
            Console.WriteLine(encripted);

            return new string[] { $"Encripted -> Apurba : {encripted}", $"Decripted -> {encripted} : {dycripted}" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
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
