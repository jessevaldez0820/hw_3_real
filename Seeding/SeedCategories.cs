using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//TODO:Make these namespaces match your project name
using Valdez_Jesse_HW3.Models;
using Valdez_Jesse_HW3.DAL;
using System.Text;

//TODO:Make this namespace match your project name
namespace Valdez_Jesse_HW3.Seeding
{
    //make this class static so you can use the dbContext
    public static class SeedCategories
    {
        //You will call this method from the SeedController to add categories
        public static void SeedAllCategories(AppDbContext db)
        {
            //create a list of categories to add
            List<Category> AllCategories = new List<Category>();

            //create a new instance of the Category class
            Category c1 = new Category() { CategoryName = "Media" };
            //add the category to the list
            AllCategories.Add(c1);
            
            //create a new instance of the Category class
            Category c2 = new Category() { CategoryName = "Healthcare Technology" };
            //add the category to the list
            AllCategories.Add(c2);

            //create a new instance of the Category class
            Category c3 = new Category() { CategoryName = "Social Science" };
            //add the category to the list
            AllCategories.Add(c3);

            //create a new instance of the Category class
            Category c4 = new Category() { CategoryName = "Finance" };
            //add the category to the list
            AllCategories.Add(c4);

            //create a new instance of the Category class
            Category c5 = new Category() { CategoryName = "Management" };
            //add the category to the list
            AllCategories.Add(c5);

            //create a new instance of the Category class
            Category c6 = new Category() { CategoryName = "Higher Ed" };
            //add the category to the list
            AllCategories.Add(c6);

            //create a new instance of the Category class
            Category c7 = new Category() { CategoryName = "Computer" };
            //add the category to the list
            AllCategories.Add(c7);

            //create a new instance of the Category class
            Category c8 = new Category() { CategoryName = "Business Operations" };
            //add the category to the list
            AllCategories.Add(c8);

            //create a new instance of the Category class
            Category c9 = new Category() { CategoryName = "Executive" };
            //add the category to the list
            AllCategories.Add(c9);

            //create a new instance of the Category class
            Category c10 = new Category() { CategoryName = "Communications" };
            //add the category to the list
            AllCategories.Add(c10);

            //create a new instance of the Category class
            Category c11 = new Category() { CategoryName = "Library" };
            //add the category to the list
            AllCategories.Add(c11);

            //create a new instance of the Category class
            Category c12 = new Category() { CategoryName = "Education" };
            //add the category to the list
            AllCategories.Add(c12);

            //create a counter and flag to help with debugging
            int intCategoryID = 0;
            String strCategoryName = "Start";

            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the categories
                foreach (Category seedCategory in AllCategories)
                {
                    //updates the counters to get info on where the problem is
                    intCategoryID = seedCategory.CategoryID;
                    strCategoryName = seedCategory.CategoryName;

                    //try to find the category in the database
                    Category dbCategory = db.Categories.FirstOrDefault(c => c.CategoryName == seedCategory.CategoryName);

                    //if the category isn't in the database, dbCategory will be null
                    if (dbCategory == null)
                    {
                        //add the Category to the database
                        db.Categories.Add(seedCategory);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //this isn't really needed for category because it only has one field
                        //but you will need it to re-set seeded data with more fields
                        dbCategory.CategoryName = seedCategory.CategoryName;
                        //you would add other fields here
                        db.SaveChanges();
                    }

                }
            }
            catch (Exception ex)  //something about adding to the database caused a problem
            {
                //create a new instance of the string builder to make building out 
                //our message neater - we don't want a REALLY long line of code for this
                //so we break it up into several lines
                StringBuilder msg = new StringBuilder();

                msg.Append("There was an error adding the ");
                msg.Append(strCategoryName);
                msg.Append(" category (CategoryID = ");
                msg.Append(intCategoryID);
                msg.Append(")");

                //have this method throw the exception to the calling method
                //this code wraps the exception from the database with the 
                //custom message we built above.  The original error from the
                //database becomes the InnerException
                throw new Exception(msg.ToString(), ex);
            }

        }
    
    }
}
