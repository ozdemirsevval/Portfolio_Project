using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Portfolio_Project.Data_Access_Layer.Context;

namespace Portfolio_Project.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        Portfolio_ProjectContext portfolio_Context = new Portfolio_ProjectContext();
        
        public IViewComponentResult Invoke()
        {
            //values isminde bir değişken oluştur, içine potfolioContextte yer alan Feautures tablosundaki
            //verileri liste olarak getir, geriye de bu sayfa açılırken values içindeki değerleri döndür.
            var values = portfolio_Context.Features.ToList();
            return View(values);
        }
    }
}
