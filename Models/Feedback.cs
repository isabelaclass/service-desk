using System.ComponentModel.DataAnnotations;
namespace ServiceDesk;

    public class Feedback
    {
        [Key]
        public int Id { get; set; }
        public string? Nome { get; set; }

        public string? Descricao { get; set; }
    }
