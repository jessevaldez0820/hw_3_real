using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Valdez_Jesse_HW3.Models

{
    public enum SalarySort { GreaterThan, LessThan };

    public class SearchViewModel : Category
    {
        [Display(Name = "Search by Title: ")]
        public String Title { get; set; }

        [Display(Name = "Search by Description:")]
        public String Description { get; set; }

        [Display(Name = "Search by Category:")]
        public Int32 SelectedCategoryID { get; set; }

        [Display(Name = "Search by Salary:")]
        public Decimal Salary { get; set; }

        [Display(Name = "Search by Date Posted:")]
        [DataType(DataType.Date)]
        //DateTime?  means this date is nullable - we want to allow them to 
        //be able to NOT select a date
        public DateTime? PostedDate { get; set; }

        [Display(Name = "Greater than Less than Filter for Salary")]
        public SalarySort GreaterLess { get; set; }
    }
}
