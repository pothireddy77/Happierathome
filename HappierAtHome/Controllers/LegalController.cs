using HappierAtHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HappierAtHome.Controllers
{
    public class LegalController : Controller
    {
        // GET: Legal
        public ActionResult Index()
        {
            var model = new List<Query>() {
                new Query() { Question = "I have a living will (details person's desires regarding their medical treatment, in the event of incapacity)" },
                new Query() { Question = "I have medical power of attorney (allows you to make healthcare decisions for your loved one, in the event of illness or incapacity)" },
                new Query() { Question = "I have end quality of life wishes documented" },
                new Query() { Question = "I have my ‘when I go’ plan (details of funeral)" },
                new Query() { Question = "My health care agent (appointed loved one(s) for medical decisions) have easy access to my documents" },
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Evaluate(List<Query> queries)
        {
            ViewBag.Score = queries.Count(q => q.SelectedAnswer == "No");
            return View("Index");
        }
    }
}