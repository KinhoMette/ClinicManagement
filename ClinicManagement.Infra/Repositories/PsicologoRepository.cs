using ClinicManagement.Domain.Entities;
using ClinicManagement.Infra.Context;
using ClinicManagement.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.Infra.Repositories
{
    public class PsicologoRepository : GenericRepository<Psicologo>
    {
        public PsicologoRepository(MainContext contexto) : base(contexto)
        {
        }
    }
}