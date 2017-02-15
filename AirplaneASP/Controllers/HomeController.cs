﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AirportService;
using AirportService.DTO;

namespace AirplaneASP.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ICityService cityService= new CityService();
            List<CityDTO> cityList = cityService.GetAll();

            return View("Index",cityList);
        }

        [HttpGet]
        public ActionResult Remove(Guid cityID)
        {
            ICityService cityService = new CityService();
            cityService.Remove(cityID);

            return Index();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Countries()
        {
            ICountryService countryService = new CountryService();
            List<CountryDTO> countryList = countryService.GetAll();

            return View(countryList);
        }
    }
}