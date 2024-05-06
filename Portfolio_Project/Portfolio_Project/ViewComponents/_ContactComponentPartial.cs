using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Project.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View(); 
        }
    }
}
