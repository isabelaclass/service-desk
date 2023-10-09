using System.ComponentModel.DataAnnotations;
namespace ServiceDesk;

    public class Status
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public Filtro? Filtro { get; set; }
    }
