using Assignment5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBookRepository repository;

        // constructor
        public NavigationMenuViewComponent (IBookRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            // sets the selected category in the ViewBag
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            // returns the list of distinct categories to the NavigationMenu Default view
            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
