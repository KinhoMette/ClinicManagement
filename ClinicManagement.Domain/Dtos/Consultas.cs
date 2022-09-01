namespace ClinicManagement.Domain.Dtos
{
    public class Consultas
    {
        public string NomePaciente { get; set; }
        public int HoraDoDia { get; set; }
        public string Horario { get; set; }
        public int[] HorasLivres { get; set; }
    }
}