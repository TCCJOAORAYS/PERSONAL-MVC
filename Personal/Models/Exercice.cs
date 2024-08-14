namespace Personal.Models;
public class Exercise
{
    // Atributos
    public int Id { get; set; }
    public string Nome { get; set; }
    public string NomeAux { get; set; }
    public string Titulo { get; set; }
    public string SubTitulo { get; set; }
    public string Descricao { get; set; }
    public List<string> Tipo { get; set; }
    public string Imagem { get; set; }
    public string ImagemAux { get; set; }
    public string Icon { get; set; }
    public List<string> Info { get; set; }
    public string Tabela {get;set;}
    // Método Construtor
    public Exercise()
    {
        Tipo = new List<string>();
    }
}