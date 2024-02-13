using Core;
using Gateway.Controllers;
using Microsoft.EntityFrameworkCore;

namespace PruebasUnitarias
{
    public class AgenciaTesting
    {
        private readonly AgenciaDBContext _dbContext;
        private readonly AgenciaController _controller;
        public AgenciaTesting() { 
        //    _dbContext=new AgenciaDBContext();
        //_controller=new AgenciaController();
        }
        [Fact]
        public void Test1()
        {

        }
    }
}