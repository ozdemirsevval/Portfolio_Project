using Microsoft.AspNetCore.Mvc;
using Portfolio_Project.Data_Access_Layer.Context;

namespace Portfolio_Project.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        Portfolio_ProjectContext portfolio_Context = new Portfolio_ProjectContext();
        
        public IViewComponentResult Invoke()
        {
            //
            ViewBag.AboutTitle = portfolio_Context.Abouts.Select(x => x.AboutTitle).FirstOrDefault();
            ViewBag.AboutSubDescription = portfolio_Context.Abouts.Select(x=>x.AboutSubDescription).FirstOrDefault();
            ViewBag.AboutDetails = portfolio_Context.Abouts.Select(x => x.AboutDetails).FirstOrDefault();
            return View();
        }
    }
}
