using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Project.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
