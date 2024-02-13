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

        [Route("get")]
        [HttpGet]
        public IEnumerable<Vehiculo> Get()
        {
            return _dbContext.Vehiculos.ToList();
        }

        [Route("find")]
        [HttpGet]
        public Vehiculo? Find([FromQuery] Int64 id)
        {
            return _dbContext.Vehiculos.Find(id);
        }

        [Route("create")]
        [HttpPut]
        public Int64 Create([FromBody] Vehiculo vehiculo)
        {
            _dbContext.Vehiculos.Add(vehiculo);
            var response = _dbContext.SaveChanges();
            return response;
        }

        [Route("update")]
        [HttpPost]
        public Int64 Update([FromBody] Vehiculo vehiculo)
        {
            _dbContext.Vehiculos.Update(vehiculo);
            var response = _dbContext.SaveChanges();
            return response;
        }

        [Route("delete")]
        [HttpDelete]
        public Int64 Delete([FromBody] Vehiculo vehiculo)
        {
            _dbContext.Vehiculos.Remove(vehiculo);
            var response = _dbContext.SaveChanges();
            return response;
        }

    }
}
