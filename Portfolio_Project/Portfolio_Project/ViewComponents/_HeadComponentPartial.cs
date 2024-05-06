using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Project.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View(); 
        }
    }
}
