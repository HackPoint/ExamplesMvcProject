using System.Collections.Generic;
using System.Diagnostics;
using System.Web.Mvc;
using Core.Controllers;
using Core.Extensions.Paging;
using Domain.Models.Base;
using Domain.Models.Workers;

namespace Site.Controllers {
    public class HomeController : DefaultController {
        public ActionResult Index(int? id, int? page) {
            ViewBag.Pager = Pager.Items(_list.Count).PerPage(10).Move(page ?? 1).Segment(5).Center();
            return View();
        }

        private readonly IList<Entity> _list = new List<Entity> {
            new Worker("Test1", "Test2"),
            new Worker("Test1", "Test2"),
            new Worker("Test1", "Test2"),
            new Worker("Test1", "Test2"),
            new Worker("Test1", "Test2"),
            new Worker("Test1", "Test2"),
            new Worker("Test1", "Test2"),
            new Worker("Test1", "Test2"),
            new Worker("Test1", "Test2"),
            new Worker("Test1", "Test2"),
            new Worker("Test1", "Test2"),
            new Worker("Test1", "Test2"),
            new Worker("Test1", "Test2"),
            new Worker("Test1", "Test2"),
            new Worker("Test1", "Test2"),
            new Worker("Test1", "Test2"),
            new Worker("Test1", "Test2"),
            new Worker("Test1", "Test2"),
            new Worker("Test1", "Test2"),
            new Worker("Test1", "Test2"),
            new Worker("Test1", "Test2"),
            new Worker("Test1", "Test2"),
        };
    }
}