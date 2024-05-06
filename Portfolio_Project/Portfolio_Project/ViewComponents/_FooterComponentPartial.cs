using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Project.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View(); 
        }
    }
}
