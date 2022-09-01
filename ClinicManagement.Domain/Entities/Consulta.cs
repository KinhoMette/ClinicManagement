using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.Domain.Entities
{
    public class Consulta
    {
        public int Id { get; set; }
        public DateTime DataConsulta { get; set; }
        public int IdPsicologo { get; set; }
    }
}