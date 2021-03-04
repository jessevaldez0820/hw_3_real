using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Valdez_Jesse_HW3.Models
{
    public class Category
    {
        public Int32 CategoryID { get; set; }

        public String CategoryName { get; set; }

        public List<JobPosting> JobPostings { get; set; }

        public Category()
        {
            if (JobPostings == null)
            {
                JobPostings = new List<JobPosting>();
            }
        }
    }
}
