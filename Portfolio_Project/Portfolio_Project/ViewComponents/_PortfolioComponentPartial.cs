using Microsoft.AspNetCore.Mvc;
using Portfolio_Project.Data_Access_Layer.Context;

namespace Portfolio_Project.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent
    {
        Portfolio_ProjectContext portfolio_Context = new Portfolio_ProjectContext();

        public IViewComponentResult Invoke()
        {
            var values = portfolio_Context.Portfolios.ToList();
            return View(values);
        }
    }
}
