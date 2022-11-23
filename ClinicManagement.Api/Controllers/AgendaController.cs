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
        private readonly IConsultaService _consultaService;

        public AgendaController(IPsicologoService psicologoService, IConsultaService consultaService)
        {
            _psicologoService = psicologoService;
            _consultaService = consultaService;
        }

        [HttpGet("ObterPsicologos")]
        public IActionResult ObterListaPsicologos()
        {
            return Ok(_psicologoService.RetornaListaPsicologos());
        }

        [HttpGet("ObterCalendarioSemana")]
        public IActionResult ObterCalendarioSemana([FromQuery] int id, [FromQuery] int mes, [FromQuery] int semanas)
        {
            //  var listConsultas = _consultaService.ObtemConsultasPorPsicologo(id);

            var listConsultas = new List<ConsultasDto>()
            {
                new ConsultasDto() { HoraDoDia = 10, Horario = "10:00", NomePaciente = "Diego" },
                new ConsultasDto() { HoraDoDia = 13, Horario = "13:00", NomePaciente = "Henrique" },
                new ConsultasDto() { HoraDoDia = 14, Horario = "14:00", NomePaciente = "Diego" },
                new ConsultasDto() { HoraDoDia = 18, Horario = "18:00", NomePaciente = "Henrique" }
            };

            List<int> horasPreenchidas = new();

            foreach (var item in listConsultas)
            {
                horasPreenchidas.Add(item.HoraDoDia);
            }

            var horasLivres = new int[] { 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            foreach (var item in horasPreenchidas)
            {
                horasLivres = horasLivres.Where(x => x != item).ToArray();
            }

            var hoje = DateTime.Now.AddDays(semanas * 7);
            var diaAtual = hoje.DayOfWeek;
            int days = (int)diaAtual - 1;
            DateTime sexta = hoje.AddDays(-days);
            var diasDessaSemana = Enumerable.Range(0, 5)
                .Select(d => sexta.AddDays(d).Day)
                .ToArray();

            var listCalendario = new List<CalendarioSemanaDto>()
            {
                new CalendarioSemanaDto(){Consultas = listConsultas.Where(x => (int)x.DataConsulta.DayOfWeek == diasDessaSemana[0] && x.DataConsulta.Month == mes).ToList(),DiasExtenso = "Segunda-Feira",HorasLivres =horasLivres,DiasNumero =  diasDessaSemana[0]},

                new CalendarioSemanaDto(){Consultas = listConsultas.Where(x => (int)x.DataConsulta.DayOfWeek == diasDessaSemana[1] && x.DataConsulta.Month == mes).ToList(),DiasExtenso = "Terça-Feira",HorasLivres =horasLivres,DiasNumero =  diasDessaSemana[1]},

                new CalendarioSemanaDto(){Consultas = listConsultas.Where(x => (int)x.DataConsulta.DayOfWeek == diasDessaSemana[2] && x.DataConsulta.Month == mes).ToList(),DiasExtenso = "Quarta-Feira",HorasLivres =horasLivres,DiasNumero =  diasDessaSemana[2]},

                new CalendarioSemanaDto() { Consultas = listConsultas.Where(x => (int)x.DataConsulta.DayOfWeek == diasDessaSemana[3] && x.DataConsulta.Month == mes).ToList(), DiasExtenso = "Quinta-Feira", HorasLivres = horasLivres, DiasNumero = diasDessaSemana[3] },

                new CalendarioSemanaDto() { Consultas = listConsultas.Where(x => (int)x.DataConsulta.DayOfWeek == diasDessaSemana[4] && x.DataConsulta.Month == mes).ToList(), DiasExtenso = "Sexta-Feira", HorasLivres = horasLivres, DiasNumero = diasDessaSemana[4] }
            };

            return Ok(listCalendario);
        }
    }
}