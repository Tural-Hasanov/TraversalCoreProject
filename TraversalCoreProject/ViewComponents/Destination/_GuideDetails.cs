using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.ViewComponents.Destination
{
    public class _GuideDetails : ViewComponent
    {
        private readonly IGuideService _guideService;

        public _GuideDetails(IGuideService guideService)
        {
            _guideService = guideService;
        }
        public IViewComponentResult Invoke()
        {
            var c = new Context();
            var min = c.Guides.Select(x => x.GuideID).Min();
            var max = c.Guides.Select(x => x.GuideID).Max();
            Random random = new Random();

            var values = random.Next(min, max);
            var values1 = _guideService.TGetByID(values);
            return View(values1);
        }
    }
}
