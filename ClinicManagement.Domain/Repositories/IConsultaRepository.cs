using ClinicManagement.Domain.Dtos;
using ClinicManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.Domain.Repositories
{
    public interface IConsultaRepository : IGenericRepository<Consulta>
    {
        Task<List<ConsultasDto>> ObterListaConsultas(int idPsicologo);
    }
}