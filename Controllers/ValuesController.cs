using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Krajoski_Clase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {
        
        private IAlumnosService alumnosService;

        public AlumnosController(IAlumnosService alumnosService)
        {
            this.alumnosService = alumnosService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<List<Alumno>> Get()
        {
            return alumnosService.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Alumno> Get(int id)
        {
            return alumnosService.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Alumno alumno)
        {
            alumnosService.Save(alumno);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Alumno alumno)
        {
            alumnosService.Save(alumno);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            alumnosService.Delete(id);
        }
    }
}
