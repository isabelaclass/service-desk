using System.ComponentModel.DataAnnotations;
namespace ServiceDesk;

    public class Solucao
    {
        [Key]
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public Ticket? Ticket { get; set; }
        public Feedback? Feedback { get; set; }
    }
