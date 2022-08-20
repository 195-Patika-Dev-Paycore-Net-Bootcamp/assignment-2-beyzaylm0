using Assignment2.Model;
using Assignment2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Assignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase 
    {

        private ILogger _logger;
        private IStaffServices _service;


        public StaffController(ILogger<StaffController> logger, IStaffServices service)
        {
            _logger = logger;
            _service = service;

        }

        [HttpGet("/api/staffs")]
        public ActionResult<List<Staff>> GetStaffs() // method showing all staff
        {
            return _service.GetStaffs();
        }

        [HttpGet("/api/getById")]
        public ActionResult<Staff> GetById(int id) //Method fetching staff by id
        {
            try
            {
                return _service.GetById(id);
            }
            catch (System.Exception)
            {

                return BadRequest();
            }
            
        }
        [HttpPost("/api/staffs")]
        public ActionResult<Staff> AddStaff(Staff staff)  //staff add method
        {
            try
            {
                _service.AddStaff(staff);
                return staff;
            }
            catch (System.Exception)
            {

                return BadRequest();
            }
           
        }

        [HttpPut("/api/{id}")]
        public ActionResult<Staff> UpdateStaff(int id, [FromBody] Staff staff) //staff update method
        {
            _service.UpdateStaff(id,staff);
            return staff;
        }

        [HttpDelete("/api/{id}")]
        public ActionResult<int> DeleteStaff(int id) //staff delete method
        {

            
            if(_service.DeleteStaff(id)!=null)
            {
                return Ok();
            }
            
            else
            {
                return BadRequest();
            }

        }


    }
}
