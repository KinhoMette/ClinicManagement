using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.Domain.Dtos
{
    public class CalendarioSemanaDto
    {
        public int DiasNumero { get; set; }
        public string DiasExtenso { get; set; }
        public List<ConsultasDto> Consultas { get; set; }
        public int[] HorasLivres { get; set; }
    }
}