using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnitTestingTest.Models;

namespace UnitTestingTest.Controllers
{
    public class MathController : Controller
    {
        IMathService service;
        public MathController(IMathService service)
        {
            this.service = service;
        }
        // GET: Math
        public ViewResult Add(int x, int y)
        {
            int r = x + y;//service.Add(x,y);
            ViewBag.TotalCount = r;
            return View();
        }
    }
}