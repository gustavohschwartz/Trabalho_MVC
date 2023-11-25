using Microsoft.AspNetCore.Mvc;
using MVC.Models.ModelView;
using System.Diagnostics;


namespace MVC.Controllers
{
    public class TarefasController : Controller
    {

        public IActionResult ListaTarefas()
        {
            List<TarefasModelView> tarefasModelViews = new List<TarefasModelView>();
            tarefasModelViews.Add(new TarefasModelView("Trabalho Análise Orientada a Objetos", true));
            tarefasModelViews.Add(new TarefasModelView("Trabalho de Banco de Dados", true));
            tarefasModelViews.Add(new TarefasModelView("Trabalho UX/UI", false));
            tarefasModelViews.Add(new TarefasModelView("Trabalho POO", false));
            tarefasModelViews.Add(new TarefasModelView("Trabalho Desenvolvimento WEB", false));
            tarefasModelViews.Add(new TarefasModelView("Trabalho de Estrutura de Dados", true));
            tarefasModelViews.Add(new TarefasModelView("Trabalho de Extensão", false));

            return View(tarefasModelViews);
        }
    }
}
