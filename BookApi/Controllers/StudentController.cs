using DataLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IBaseRepository<MarksModel> _repo;

        public StudentController(IBaseRepository<MarksModel> repo)
        {
            this._repo = repo;

        }

        [HttpGet("Get")]//paging , also google
        public async Task<IActionResult> Get()
        {
            ///return Ok(await _repo.GetAll());
            var list = await _repo.GetAll();
            return Ok(list);

        }


        [HttpGet("GetById/{studid}")]
        public async Task<IActionResult> Get(string studid)
        {
            if (studid == null)
            {
                return BadRequest();
            }

            var studMarksList = await _repo.Get(studid);
            if (studMarksList.Count() == 0)
            {
                return NotFound();
            }

            return Ok(studMarksList);
        }

        [HttpPost("Add/{studId}/{subjId}")]
        public async  Task<IActionResult> Post(string studId,string subjId,[FromQuery]int marks )
        {
            /* if (ModelState.IsValid)
             {
                 await _repo.Insert(marksModel);
                 return Ok();
             }
             return BadRequest();*/
            await _repo.Insert(studId, subjId,marks);
            return Ok();
        }

        [HttpPut("Update/{studId}/{subjId}")]
        public async Task<IActionResult> Put(string studId,[FromQuery]int marks,string subjId)
        {
         
            await _repo.Update(studId, subjId,marks);
            return Ok();
        }
        [HttpDelete("Del/{studId}/{subjId}")]
        // GET: Employee/Delete/5
        public  async Task <IActionResult> Delete(string studId,string subjId)
        {
           
            await _repo.Delete(studId, subjId);
          

            return Ok();
        }
    }
}
