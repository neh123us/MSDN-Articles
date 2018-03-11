using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TimeTracker.Web.Models
{
  // Models returned by MeController actions.
  public class GetViewModel
  {
    public string Hometown { get; set; }
  }
}