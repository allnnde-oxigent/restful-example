using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResfulExample.Context;
using ResfulExample.Entities;

namespace ResfulExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {

        [HttpGet("all")]
        public IActionResult Get()
        {
            var db = new OxigentContext();
            var empleados = db.Employers.ToList();
            return Ok(empleados);
        }

        [HttpPost("create")]
        public IActionResult Create(Employer emp)
        {
            var db = new OxigentContext();
            db.Employers.Add(emp);
            db.SaveChanges();
            return Ok($"El empleado se creo ok, nombre: {emp.Name}");

        }

        [HttpDelete("delete")]
        public IActionResult Delete(int id) {
            var db = new OxigentContext();
            var emp = db.Employers.Find(id);
            db.Employers.Remove(emp!);
            db.SaveChanges();
            return Ok($"el empleado : {id} ha sido eliminado!");
        }

        [HttpGet("one/{id}")]
        public IActionResult GetByid(int id)
        {
            var db = new OxigentContext();
            var emp = db.Employers.Find(id);
            return Ok(emp);
        }

        [HttpPut("{id}")]
        public IActionResult Modify(Employer emp, int id) {

            var db = new OxigentContext();
            var employer = db.Employers.Find(id);
            employer.Name = emp.Name;
            employer.LastName = emp.LastName;
            db.Update(employer);
            db.SaveChanges();
            return Ok($"Se modifico el empleado {id} - {emp.Name}");
        }

    }
}
