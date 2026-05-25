using System.ComponentModel.DataAnnotations;


namespace Bibliotec_MVC.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; } = null!;

        public ICollection<LivroCategoria> livroCategorias { get; set; } = new List<LivroCategoria>();
    }
}