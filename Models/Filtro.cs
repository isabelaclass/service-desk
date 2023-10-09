using System.ComponentModel.DataAnnotations;
namespace ServiceDesk;

    public class Filtro
    {
        [Key]
        public int Id { get; set; }
        public string? Nome { get; set; }
    }
