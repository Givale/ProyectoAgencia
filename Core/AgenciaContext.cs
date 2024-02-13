﻿using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class AgenciaDBContext : DbContext
    {
        public AgenciaDBContext(DbContextOptions<AgenciaDBContext> options):base(options) 
        { 
        }
        public DbSet<Vehiculo> Vehiculos { get; set; }

    }
}
