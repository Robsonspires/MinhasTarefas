using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyTodoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [DisplayName("Título")]
        [Required(ErrorMessage ="Campo Obrigatório")]
        public string? Title { get; set; }

        [DisplayName("Concuído")]
        public bool Done { get; set; }

        [DisplayName("Criado em")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [DisplayName("Ultima Atualização")]
        public DateTime LastUpdateDate { get; set; } = DateTime.Now;

        [DisplayName("Usuário")]
        public string? User { get; set; }

    }
}
