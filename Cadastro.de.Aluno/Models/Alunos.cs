// Models/Aluno.cs

using System.ComponentModel.DataAnnotations;

public class Aluno
{
    [Required]
    [StringLength(100)]
    public string Nome { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [StringLength(20)]
    public string RA { get; set; }

    [Required]
    [StringLength(100)]
    public string Curso { get; set; }

    [Required]
    [StringLength(10)]
    public string DataNascimento { get; set; }
}
