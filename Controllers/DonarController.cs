using BloodDonationManagement.Core;
using BloodDonationManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonationManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonarController : ControllerBase
    {
        private readonly IDonar _donar;
        public DonarController(IDonar donar)
        {
            _donar = donar;
        }

        //Get : api/Donar
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<SchoolModel> schoolModels = _donar.GetAll();
            return Ok(schoolModels);
        }

        //Post : api/Donar
        public IActionResult Post([FromBody]SchoolModel schoolModel)
        {
            if(schoolModel == null)
            {
                return BadRequest("School Details is null");
            }
            _donar.AddDonar(schoolModel);
            return Ok();
        }
    }
}
