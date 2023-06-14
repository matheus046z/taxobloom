using WebAppBloom.Models;

public class ListaCompetenciaViewModel{

    public ICollection<Competencia> Competencias {get; set;} = new List<Competencia>(); // ou colocar "<>?" para nao precisar atribuir um valor
    
}