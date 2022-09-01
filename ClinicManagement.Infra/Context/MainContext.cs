using ClinicManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.Infra.Context
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {
        }

        public DbSet<Psicologo> Psicologo { get; set; }
        public DbSet<Consulta> Consulta { get; set; }
    }
}