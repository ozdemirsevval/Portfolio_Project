using Microsoft.AspNetCore.Mvc;
using Portfolio_Project.Data_Access_Layer.Context;

namespace Portfolio_Project.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        Portfolio_ProjectContext portfolio_Context = new Portfolio_ProjectContext();

        public IViewComponentResult Invoke()
        {
            var values = portfolio_Context.Skills.ToList();
            return View(values); 
        }
    }
}
