using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;
        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.TGetList());
            return Json(jsonCity);
        }
        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            destination.Status = true;
            _destinationService.TAdd(destination);
            var values = JsonConvert.SerializeObject(destination);
            return Json(destination);
        }
        public IActionResult GetById(int DestinationID)
        {
            var values = _destinationService.TGetByID(DestinationID);
            var jsonvalues = JsonConvert.SerializeObject(values);
            return Json(jsonvalues);
        }
        public IActionResult DeleteCity(int id)
        {
            var values = _destinationService.TGetByID(id);
            _destinationService.TDelete(values);
            return NoContent();
        }
        [HttpPost]
        public IActionResult UpdateCity(Destination destination)
        {
            //var values = _destinationService.TGetByID(destination.DestinationID);
            _destinationService.TUpdate(destination);
            var jsonvalues = JsonConvert.SerializeObject(destination);
            return Json(jsonvalues);
        }





        //public static List<CityClass> cities = new List<CityClass>()
        //{
        //    new CityClass
        //    {
        //        CityID=1,
        //        CityName="Baki",
        //        CityCountry="Azerbaycan"
        //    },
        //    new CityClass
        //    {
        //        CityID=2,
        //        CityName="Roma",
        //        CityCountry="Italiya"
        //    },
        //    new CityClass
        //    {
        //        CityID=3,
        //        CityName="London",
        //        CityCountry="Ingiltere"
        //    }
        //};


    }
}
