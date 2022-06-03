using Microsoft.AspNetCore.Mvc;
using NSE.WebApp.MVC.Models;
using System.Diagnostics;

namespace NSE.WebApp.MVC.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("erro/{id:length(3,3)}")]
        public IActionResult Error(int id)
        {
            var modelErro = new ErrorViewModel();

            if(id == 500)
            {
                modelErro.Message = "Ocorreu um erro! Tente novamente mais tarde ou contate nosso suporte.";
                modelErro.Titulo = "Ocorreu um erro!";
                modelErro.ErrorCode = id;
            }
            else if(id == 404)
            {
                modelErro.Message = "A página que esta procurando não existe <br />Em caso de duvidas entre em contato com nosso suporte";
                modelErro.Titulo = "Ops ! Página não encontrada.";
                modelErro.ErrorCode = id;
            }
            else if(id == 403)
            {
                modelErro.Message = "Você não tem permissao para fazer isto.";
                modelErro.Titulo = "Acesso Negado";
                modelErro.ErrorCode = id;
            }
            else
            {
                return StatusCode(404);
            }
           
            return View(modelErro);
        }
    }
}