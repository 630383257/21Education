﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _21Education.MODEL;
namespace _21Education.WebSite.Controllers
{
    /// <summary>
    /// 关于我们
    /// </summary>
    public class AboutController : Controller
    {
        //
        // GET: /About/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            var viewModel = new ViewModels.HomeIndexViewModel
            {
                ProductShow = new DATA.CarouselViewModel(new List<MODEL.Carousel>
                {
                    new Carousel{Describe="1",ImgPath="/image/honor1.jpg"},
                    new Carousel{Describe="2",ImgPath="/image/honor2.jpg"},
                    new Carousel{Describe="3",ImgPath="/image/honor3.jpg"},
                    new Carousel{Describe="4",ImgPath="/image/honor4.jpg"}
                })
                {
                    ImgWidth = 800,
                    ClassName = "HonorShow"
                }
            };
            return View(viewModel);
        }


        public ActionResult aa()
        {
            return View();
        }

    }
}
