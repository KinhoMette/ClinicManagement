using ClinicManagement.Domain.Dtos;
using ClinicManagement.Domain.Repositories;
using ClinicManagement.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.Application.Services
{
    public class ConsultaService : IConsultaService
    {
        private readonly IConsultaRepository _consultaRepository;

        public ConsultaService(IConsultaRepository consultaRepository)
        {
            _consultaRepository = consultaRepository;
        }

        public async Task<List<ConsultasDto>> ObtemConsultasPorPsicologo(int idPsicologo)
        {
            return await _consultaRepository.ObterListaConsultas(idPsicologo);
        }
    }
}