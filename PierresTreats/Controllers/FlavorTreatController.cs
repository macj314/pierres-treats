using Microsoft.AspNetCore.Mvc;
using PierresTreats.Models;
using PierresTreats.ViewModels;
using System.Linq;

namespace PierresTreats.Controllers
{
  public class FlavorTreatController : Controller
  {
    private readonly PierresTreatsContext _db;

    public FlavorTreatController(PierresTreatsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      var viewModel = new FlavorTreatViewModel();
      viewModel.FlavorList = _db.Flavors.ToList();
      viewModel.TreatList = _db.Treats.ToList();
      return View(viewModel);
    }
  }
}