using System.ComponentModel.DataAnnotations;
namespace ServiceDesk;

    public class Sla
    {
        [Key]
        public int Id { get; set; }
        public string? Nome { get; set; }
        public Filtro? Filtro { get; set; }
    }
