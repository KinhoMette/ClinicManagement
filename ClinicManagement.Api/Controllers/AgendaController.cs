using ClinicManagement.Domain.Dtos;
using ClinicManagement.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AgendaController : ControllerBase
    {
        private readonly IPsicologoService _psicologoService;

        public AgendaController(IPsicologoService psicologoService)
        {
            _psicologoService = psicologoService;
        }

        [HttpGet("ObterPsicologos")]
        public IActionResult ObterListaPsicologos()
        {
            return Ok(_psicologoService.RetornaListaPsicologos());
        }
    }
}