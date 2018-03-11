using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Common.Validation;

namespace TimeTracker.Common.ViewModels
{
  class TimeEntryViewModel
  {
    [Key]
    public int Id { get; set; }
    [Required (ErrorMessage = "All time entries must always be entered")]
    //[DateRangeValidator(ErrorMessage = "Date is ouutside expected range",
    //  MinimalDateOffset = -5, MaximumDateOffset = 0)]
    public DateTime StartTime { get; set; }
    //[DateRangeValidator(ErrorMessage = "Date is outside of expected range",
    //  MinimalDateOffset = -5, MaximumDateOffset = 0)]
    public DateTime EndTime { get; set; }
    [StringLength(128, ErrorMessage = "Task name should be less than 128 characters")]
    [Required(ErrorMessage = "All time entries should be associated with a task")]
    public string Task { get; set; }
    public string Comment { get; set; }



  }
}
