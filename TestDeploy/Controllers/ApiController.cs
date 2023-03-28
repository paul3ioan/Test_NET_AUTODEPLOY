using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDeploy
{
    public class ApiController: ControllerBase
    {
        private readonly IDBContext dBContext;
        public ApiController(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        [HttpGet("api/data")]
        public ActionResult<IEnumerable<Test1>> GetData()
        {
            var data = dBContext.Test1s.ToList();

            return Ok(data);
        }
        [HttpGet("api/test")] 
        public ActionResult<IEnumerable<string>> GetDataTest()
        {
            return Ok(new List<string>() { "abc", "cda" });
        }
    }
}
