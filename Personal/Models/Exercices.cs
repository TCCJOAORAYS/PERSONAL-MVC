namespace Personal.Models;
public class Exercicio
{
    // Atributos
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public List<string> Tipo { get; set; }
    public string Imagem { get; set; }
    // Método Construtor
    public Exercicio()
    {
        Tipo = new List<string>();
    }
}