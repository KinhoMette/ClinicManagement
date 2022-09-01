using ClinicManagement.Domain.Dtos;
using ClinicManagement.Domain.Entities;
using ClinicManagement.Domain.Repositories;
using ClinicManagement.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.Application.Services
{
    public class PsicologoService : IPsicologoService
    {
        private readonly IPsicologoRepository _psicologoRepository;

        public PsicologoService(IPsicologoRepository psicologoRepository)
        {
            _psicologoRepository = psicologoRepository;
        }

        public List<Psicologo> RetornaListaPsicologos()
        {
            return _psicologoRepository.GetAll();
        }
    }
}