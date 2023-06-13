using Microsoft.AspNetCore.Mvc;
// controller/action/opcionais
// classe é u conjunto de objetos
// metodo é uma função
// ações são métodos, cada action representa uma página
using WebAppBloom.Models;
using WebAppBloom.ViewModels;
using WebAppBloom.Contexts;

namespace WebAppBloom.Controllers;
public class CompetenciaController : Controller{
    
    private readonly AppDbConext _context; // variavel para a conexão com o banco de dados
    
    public CompetenciaController(AppDbConext context) // poderiamos utilizar a instanciação de objetos aqui. Com injeção de dependencias, o framework fica responsável pela instanciação
    {
        _context = context;
    }
    public ActionResult Index(){ // O nome do arquivo deve ser igual ao da Action, Index() nesse caso retorna a View do Index.cshtml em Competencia
    
        Competencia competencia = new Competencia();
        competencia.ColunaBloom = "MEMORIZAR";
        competencia.LinhaBloom = "Listar";

        ViewData["titulo"] = "Compreender o funcionamento do Razor";
        ViewData["tablebloom"] = competencia;

        return View();
    }
    public ActionResult RelatorioComp(){
       
        var competencias = _context.Competencias.ToList();
        return View();

        // var competencia = new Competencia(){
        //    ColunaBloom = "Teste Coluna",
        //    LinhaBloom = "Teste Linha", 
        // };
        // var viewModel = new DetalhesCompViewModel(){
        //     Competencia = competencia,
        //     TituloPagina = "Página de Teste",
        // };
        //return View(viewModel);    
    }
}

// LAB-F08-24