namespace WebAppBloom.Models;
public class Competencia // Camada Model
{
    public int Id  { get; set; }
    public string? ColunaBloom { get; set; } // a partir do dotnet 6? ,  nao permitido valores nulos para a variavel quando é declarada como objeto (string é uma classe), por isso o "?" para não precisar atribuir valores para o objeto não criação.
    public string? LinhaBloom { get; set; }
}

