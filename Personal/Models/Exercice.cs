using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Personal.Models;

[Table("Exercises")]
public class Exercise
{
    [Key]
    public int Id { get; set; }
    
    public string Nome { get; set; }
    public string NomeAux { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public string Tipo { get; set; }
    public string Imagem { get; set; }
    public string ImagemAux { get; set; }
    public string Icon { get; set; }
    public List<string> Info { get; set; }
    public string Tabela {get;set;}
}