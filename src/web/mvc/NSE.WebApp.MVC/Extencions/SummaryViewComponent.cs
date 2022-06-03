using Microsoft.AspNetCore.Mvc;

namespace NSE.WebApp.MVC.Extencions
{
    public class SummaryViewComponent : ViewComponent   
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
