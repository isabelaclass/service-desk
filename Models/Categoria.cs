using System.ComponentModel.DataAnnotations;
namespace ServiceDesk;

    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        public string? Nome { get; set; }
    }
