using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = portfolioContext.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDecription = portfolioContext.Abouts.Select(x =>x.SubDecription).FirstOrDefault();
            ViewBag.aboutDetail = portfolioContext.Abouts.Select(x =>x.Details).FirstOrDefault();
            return View();
        }
    }
}
