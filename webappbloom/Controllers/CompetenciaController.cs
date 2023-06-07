using Microsoft.AspNetCore.Mvc;
// controller/action/opcionais
// classe é u conjunto de objetos
// metodo é uma função
// ações são métodos, cada action representa uma página
using WebAppBloom.Models;
namespace WebAppBloom.Controllers;
public class CompetenciaController : Controller{
    public ActionResult Index(){ // O nome do arquivo deve ser igual ao da Action, Index() nesse caso retorna a View do Index.cshtml em Competencia
        
        Competencia competencia = new Competencia();
        competencia.ColunaBloom = "MEMORIZAR";
        competencia.LinhaBloom = "Listar";

        ViewData["titulo"] = "Compreender o funcionamento do Razor";
        ViewData["tablebloom"] = competencia;

        return View();
    }
}

