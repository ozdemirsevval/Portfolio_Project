using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Project.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        { 
            return View(); 
        }
    }
}
