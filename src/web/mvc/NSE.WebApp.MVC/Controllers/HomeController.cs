using Microsoft.AspNetCore.Mvc;
using NSE.WebApp.MVC.Models;
using System.Diagnostics;

namespace NSE.WebApp.MVC.Controllers
{
    public class HomeController : Controller
    {
        [Route("sistema-indisponivel")]
       public IActionResult SistemaIndisponivel()
        {
            var modelErro = new ErrorViewModel
            {
                Message = "O sistema esta temporariamente indisponivel, isto pode ocorrer em um momento de sobrecarga de usuarios.",
                Titulo = "Sistema Indisponivel.",
                ErrorCode = 500
            };
            return View("Error",modelErro);
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
           
            return View("Error", modelErro);
        }
    }
}