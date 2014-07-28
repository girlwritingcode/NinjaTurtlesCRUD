using NinjaTurtlesMVC.Data.Models;
using NinjaTurtlesMVC.Web.Adapters;
using NinjaTurtlesMVC.Web.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NinjaTurtlesMVC.Web.Controllers
{
    public class HomeController : Controller
    {
        private ITurtle _adapter;
        public HomeController()
        {
            _adapter = new TurtleAdapter();
        }
        public ActionResult Index()
        {
            return View(_adapter.GetTurtles());
        }
        public ActionResult Details(int id)
        {
            return View(_adapter.GetTurtle(id));
        }
        public ActionResult Create()
        {
            return View(_adapter.GetTurtles());
        }
        [HttpPost]
        public ActionResult Create(string name, string color, string weapons, string personality, string bio, string photoSm, string photoLg)
        {
            _adapter.CreateTurtle(name, color, weapons, personality, bio, photoSm, photoLg);
            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            return View(_adapter.GetTurtle(id));
        }
        [HttpPost]
        public ActionResult Update(int id, string name, string color, string weapons, string personality, string bio, string photoSm, string photoLg)
        {
            _adapter.UpdateTurtle(id, name, color, weapons, personality, bio, photoSm, photoLg);
            return RedirectToAction("Details", new { id });
        }
        public ActionResult Delete(int id)
        {
            _adapter.DeleteTurtle(id);
            return RedirectToAction("Index");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}