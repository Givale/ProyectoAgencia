using Core;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gateway.Controllers
{
    [Route("api/[controller]")]
    public class AgenciaController : ControllerBase
    {
        private AgenciaDBContext _dbContext;
        public AgenciaController(AgenciaDBContext dbContext) 
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IEnumerable<Vehiculo> Read()
        {
            return _dbContext.Vehiculos.ToList();
        }

        [Route("api/[controller]/id")]
        [HttpGet]
        public Vehiculo? Read([FromQuery] Int64 id)
        {
            return _dbContext.Vehiculos.Find(id);
        }

        [HttpPut]
        public Int64 Create([FromBody] Vehiculo vehiculo)
        {
            _dbContext.Vehiculos.Add(vehiculo);
            var response = _dbContext.SaveChanges();
            return response;
        }

        [HttpPost]
        public Int64 Update([FromBody] Vehiculo vehiculo)
        {
            _dbContext.Vehiculos.Update(vehiculo);
            var response = _dbContext.SaveChanges();
            return response;
        }

        [HttpDelete]
        public Int64 Delete([FromBody] Vehiculo vehiculo)
        {
            _dbContext.Vehiculos.Remove(vehiculo);
            var response = _dbContext.SaveChanges();
            return response;
        }

    }
}
