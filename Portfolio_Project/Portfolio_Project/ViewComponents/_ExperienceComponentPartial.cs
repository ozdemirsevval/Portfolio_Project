using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Portfolio_Project.Data_Access_Layer.Context;

namespace Portfolio_Project.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        Portfolio_ProjectContext context = new Portfolio_ProjectContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}
