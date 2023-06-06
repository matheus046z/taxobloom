using Microsoft.AspNetCore.Mvc;
// controller/action/opcionais
// classe é u conjunto de objetos
// metodo é uma função
// ações são métodos, cada action representa uma página

public class CompetenciaController : Controller{
    public ActionResult Index(){ // O nome do arquivo deve ser igual ao da Action, Index() nesse caso retorna a View do Index.cshtml em Competencia
        return View();
    }
}

