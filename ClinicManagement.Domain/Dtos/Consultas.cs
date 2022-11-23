using System;

namespace ClinicManagement.Domain.Dtos
{
    public class ConsultasDto
    {
        public string NomePaciente { get; set; }
        public int HoraDoDia { get; set; }
        public string Horario { get; set; }
        public DateTime DataConsulta { get; set; }
    }
}