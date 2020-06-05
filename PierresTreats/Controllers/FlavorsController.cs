using Microsoft.AspNetCore.Mvc;
using PierresTreats.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace PierresTreats.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly PierresTreatsContext _db;

    public FlavorsController(PierresTreatsContext db)
    {
      _db = db;
    }

    [Authorize]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Index(Flavor Flavor)
    {
      _db.Flavors.Add(Flavor);
      _db.SaveChanges();
      return RedirectToAction("Index", "FlavorTreat");
    }
  }
}