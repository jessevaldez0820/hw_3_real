using Valdez_Jesse_HW3.DAL;
using Valdez_Jesse_HW3.Models;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Valdez_Jesse_HW3.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext dbContext)
        {
            _context = dbContext;
        }
        private SelectList GetAllCategories()
        {
            //Get the list of months from the database
            List<Category> categoryList = _context.Categories.ToList();

            //add a dummy entry so the user can select all months
            Category SelectNone = new Category() { CategoryID = 0, CategoryName = "All Categories" };
            categoryList.Add(SelectNone);

            //convert the list to a SelectList by calling SelectList constructor
            //MonthID and MonthName are the names of the properties on the Month class
            //MonthID is the primary key
            SelectList CategorySelectList = new SelectList(categoryList.OrderBy(m => m.CategoryID), "CategoryID", "CategoryName");

            //return the electList
            return CategorySelectList;
        }

        // GET: /<controller>/
        public IActionResult Index(String SearchString)
        {
            var query = from jp in _context.JobPostings
                        select jp;
            if (SearchString != null && SearchString != "")
            {
                query = query.Where(jp => jp.Title.Contains(SearchString) || jp.Description.Contains(SearchString));
            }
            List<JobPosting> SelectedJobPostings = query.Include(jp => jp.Category).ToList();
            //Populate the view bag with a count of all job postings
            ViewBag.AllJobs = _context.JobPostings.Count();
            //Populate the view bag with a count of selected job postings
            ViewBag.SelectedJobs = SelectedJobPostings.Count();
            return View("Index", SelectedJobPostings.OrderByDescending(jp => jp.PostedDate));
        }
        public ActionResult DetailedSearch()
        {
            ViewBag.AllCategories = GetAllCategories();
            SearchViewModel svm = new SearchViewModel();
            return View(svm);
        }
        public IActionResult DisplaySearchResults(SearchViewModel svm)
        {
            var query = from jp in _context.JobPostings select jp;

            if (String.IsNullOrEmpty(svm.Title) == false) //JobPostingID not specified
            {
                query = query.Where(jp => jp.Title.Contains(svm.Title));

            }

            if (String.IsNullOrEmpty(svm.Description) == false)
            {
                query = query.Where(jp => jp.Description.Contains(svm.Description));
            }

            if (svm.SelectedCategoryID != 0)
            {
                query = query.Where(jp => jp.Category.CategoryID == svm.SelectedCategoryID);
            }

            if (svm.Salary != 0)
            {
                switch (svm.GreaterLess)
                {
                    case SalarySort.LessThan:
                        query = query.Where(jp => jp.MinimumSalary <= svm.Salary);

                        ViewBag.AllJobs = _context.JobPostings.Count();

                        ViewBag.SelectedJobs = query.Count();

                        break;

                    case SalarySort.GreaterThan:
                        query = query.Where(jp => jp.MinimumSalary >= svm.Salary);

                        ViewBag.AllJobs = _context.JobPostings.Count();

                        ViewBag.SelectedJobs = query.Count();

                        break;

                    default:

                        break;
                }

            }

            if (svm.PostedDate != null)
            {
                query = query.Where(jp => jp.PostedDate == svm.PostedDate);
            }


            List<JobPosting> SelectedJobPostings = query.Include(jp => jp.Category).ToList();

            ViewBag.AllJobs = _context.JobPostings.Count();

            ViewBag.SelectedJobs = SelectedJobPostings.Count();

            return View("Index", SelectedJobPostings.OrderByDescending(jp => jp.PostedDate));



        }


        public IActionResult Details(int? id)
        {
            if (id == null) //JobPostingID not specified
            {
                return View("Error", new String[] { "JobPostingID not specified - which job posting do you want to view?" });
            }
            JobPosting jobPosting = _context.JobPostings.Include(j => j.Category).FirstOrDefault(j => j.JobPostingID == id);
            if (jobPosting == null) //Job posting does not exist in database 
            {
                return View("Error", new String[] { "Job posting not found in database" });
            }
            //if code gets this far, all is well
            return View(jobPosting); 
        }

    }
}
