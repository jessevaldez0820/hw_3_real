using Valdez_Jesse_HW3.DAL;
using Valdez_Jesse_HW3.Models; 
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Valdez_Jesse_HW3.Controllers
{
    public class SeedController : Controller
    {
        //You will need an instance of the AppDbContext class for this code to work
        //Create a private variable to hold the AppDbContext object
        private readonly AppDbContext _context;

        //Create a constructor for this class that accepts an instance of AppDbContext
        //The code in Startup.cs configures the project to provide an instance of AppDbContext
        //when Controller classes are instantiated.
        public SeedController(AppDbContext dbContext)
        {
            //Set the private variable equal to the instance that was
            //passed into the constructor
            _context = dbContext;
        }
        
        //This is the action method for the Seeding page with the two buttons
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SeedAllCategories()
        {
            //this code may throw an exception, so we need to be in a Try/Catch block 
            try
            {
                //call the SeedCategories method from your Seeding folder
                //you will need to pass in the instance of AppDbContext
                //that you set in the constructor
                Seeding.SeedCategories.SeedAllCategories(_context);
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception
                errorList.Add(ex.InnerException.Message);

                //Add additional inner exception messages, if there are any
                if (ex.InnerException.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);

            }

            //everything is okay - send user to confirmation page
            return View("Confirm");
        }


        public IActionResult SeedAllJobPostings()
        {
            //this code may throw an exception, so we need to be in a Try/Catch block 
            try
            {
                //call the SeedCategories method from your Seeding folder
                //you will need to pass in the instance of AppDbContext
                //that you set in the constructor
                Seeding.SeedJobPostings.SeedAllJobPostings(_context);
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception
                errorList.Add(ex.InnerException.Message);

                //Add additional inner exception messages, if there are any
                if (ex.InnerException.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);

            }

            //everything is okay - send user to confirmation page
            return View("Confirm");
        }

    }
}
