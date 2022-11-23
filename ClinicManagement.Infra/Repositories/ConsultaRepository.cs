using ClinicManagement.Domain.Dtos;
using ClinicManagement.Domain.Entities;
using ClinicManagement.Domain.Repositories;
using ClinicManagement.Infra.Context;
using ClinicManagement.Infra.Repositorios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.Infra.Repositories
{
    public class ConsultaRepository : GenericRepository<Consulta>, IConsultaRepository
    {
        public ConsultaRepository(MainContext contexto) : base(contexto)
        {
        }

        public async Task<List<ConsultasDto>> ObterListaConsultas(int idPsicologo)
        {
            return await DbSet.Where(x => x.IdPsicologo == idPsicologo).Select(x => new ConsultasDto { HoraDoDia = x.HoraConsulta, Horario = x.Horario, NomePaciente = x.NomePaciente }).ToListAsync();
        }
    }
}