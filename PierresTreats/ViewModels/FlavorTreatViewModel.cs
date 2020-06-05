using System.Collections.Generic;
using PierresTreats.Models;

namespace PierresTreats.ViewModels
{
    public class FlavorTreatViewModel
    {
      public List<Flavor> FlavorList { get; set; }
      public List<Treat> TreatList { get; set; }
    }
}