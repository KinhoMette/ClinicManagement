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
        public short HoraConsulta { get; set; }
        public string Horario { get; set; }
        public string NomePaciente { get; set; }
        public int IdPsicologo { get; set; }
    }
}