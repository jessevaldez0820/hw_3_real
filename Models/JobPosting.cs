using System;
using System.ComponentModel.DataAnnotations;

//TODO: Update this namespace to match your project name
namespace Valdez_Jesse_HW3.Models
{
    public class JobPosting
    {
        //This this the primary key
        //By naming this ClassNameID, EF automatically sets this
        //as the primary key
        public Int32 JobPostingID { get; set; }

        [Display(Name = "Unique Identifier")]
        public String UniqueIdentifier { get; set; }

        public String Title { get; set; }

        [Display(Name = "Company Name")]
        public String Company { get; set; }

        public String City { get; set; }

        public String State { get; set; }

        [Display(Name = "Posted Date")]
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public DateTime PostedDate { get; set; }

        [StringLength(3000)]
        public String Description { get; set; }


        [Display(Name = "Minimum Salary")]
        [DisplayFormat(DataFormatString = "{0:c0}")]
        public Decimal MinimumSalary { get; set; }

        public Category Category { get; set; }
    }
}
