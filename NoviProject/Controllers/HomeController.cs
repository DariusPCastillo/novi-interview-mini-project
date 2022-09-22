using Microsoft.AspNetCore.Mvc;
using NoviProject.Models;
using System.Diagnostics;
using NoviProject.Services;
using System.Runtime.CompilerServices;
using System.Linq.Expressions;

namespace NoviProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly INoviAMSApiService _noviAMSApiService;

        public HomeController(INoviAMSApiService noviAMSApiService)
        {
            _noviAMSApiService = noviAMSApiService;
        }

        public async Task<IActionResult> Index(string? searchString)
        {

            ViewData["CurrentFilter"] = searchString;

            List<Member> members = new List<Member>();
            members = await _noviAMSApiService.GetMembers();
            
            var students = from s in members
                           select s;
            students = students.Where(s => s.Active.Value == true 
                                            && s.CustomerType.Equals("Company") 
                                            || s.CustomerType.Equals("Person"));
            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.Name.Contains(searchString)
                                        || s.CustomerType.Equals(searchString)
                                        && s.Active.Value == true
                                        );
                return View(students.ToList());
            }

            return View(students.ToList());
        }

    }
}
