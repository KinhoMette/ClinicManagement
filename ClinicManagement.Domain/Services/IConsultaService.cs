﻿using ClinicManagement.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.Domain.Services
{
    public interface IConsultaService
    {
        Task<List<ConsultasDto>> ObtemConsultasPorPsicologo(int idPsicologo);
    }
}