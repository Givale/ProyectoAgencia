using Core;
using Gateway.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PruebasUnitarias
{
    public class AgenciaTesting
    {
        private readonly DbContextOptions<AgenciaDBContext> _options;
        private readonly AgenciaDBContext _dbContext;
        private readonly AgenciaController _controller;
        public AgenciaTesting() {
            _options=new DbContextOptions<AgenciaDBContext>();
            _dbContext = new AgenciaDBContext();
            _controller = new AgenciaController(_dbContext);
        }

        [Fact]
        public void Get_Ok()
        {
            var resul = _controller.Get();
            Assert.IsType<OkObjectResult>(resul);
        }
    }
}