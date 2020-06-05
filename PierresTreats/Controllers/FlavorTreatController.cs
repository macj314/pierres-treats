using Microsoft.AspNetCore.Mvc;
using PierresTreats.Models;
using PierresTreats.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

//user directives
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace PierresTreats.Controllers
{
  public class FlavorTreatController : Controller
  {
    private readonly PierresTreatsContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public FlavorTreatController(UserManager<ApplicationUser> userManager, PierresTreatsContext db)
    {
      _userManager = userManager;
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