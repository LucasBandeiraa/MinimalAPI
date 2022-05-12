using System.ComponentModel.DataAnnotations;

namespace APIminimal.Models;

public class Livro
{
    [Key]
    public int id_livro { get; set; }

    public string? Nome { get; set; }
}
