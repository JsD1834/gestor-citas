namespace GestorCitasApi.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }

        public ICollection<Cita>? Citas { get; set; } = new List<Cita>();
    }
}
