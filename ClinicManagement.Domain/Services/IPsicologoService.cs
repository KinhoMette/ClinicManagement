﻿using ClinicManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.Domain.Services
{
    public interface IPsicologoService
    {
        List<Psicologo> RetornaListaPsicologos();
    }
}