using System.ComponentModel.DataAnnotations;
namespace ServiceDesk;

    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateOnly DataAbertura { get; set; }
        public Status? Status { get; set; }
        public Prioridade? Prioridade { get; set; }
        public Categoria? Categoria { get; set; }
        public Dispositivo? Dispositivo { get; set; }
        public Usuario? UsuarioCriador { get; set; }  
        public Funcionario? FuncionarioResponsavel { get; set; }

    }