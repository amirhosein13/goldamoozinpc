using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using layedata;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bomblearn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class soalapisearch : ControllerBase
    {
        context db;
        public soalapisearch(context context)
        {
           db=context;
        }

        [Produces("application/json")]
        [HttpGet("search")]
        public async Task<IActionResult> Search()
        {
            try
            {
                string term = HttpContext.Request.Query["term"].ToString();
                var courseTitle = db.Soals
                    .Where(c => c.soaltitr.Contains(term))
                    .Select(c => c.soaltitr)
                    .ToList();
                return Ok(courseTitle);
            }
            catch
            {
                return BadRequest();
            }
        }
        [Produces("application/json")]
        [HttpGet("Searchindex")]
        public async Task<IActionResult> Searchindex()
        {
            try
            {
                string term = HttpContext.Request.Query["term"].ToString();
                var courseTitle = db.dores
                    .Where(c => c.dorename.Contains(term))
                    .Select(c => c.dorename)
                    .ToList();
                return Ok(courseTitle);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
