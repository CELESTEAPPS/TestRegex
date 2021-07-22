using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using TestRegex.Helpers;
using TestRegex.Models;

namespace TestRegex.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(TestViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                if (model.Option > 0)
                {
                    switch (model.Option)
                    {
                        case 1:
                            model.Result = RegexHelper.IsContainsText(model.Text);
                            break;
                        case 2:
                            model.Result = RegexHelper.IsContainsNumber(model.Text);
                            break;
                        case 3:
                            model.Result = RegexHelper.IsContainsAlphaNumeric(model.Text);
                            break;
                        case 4:
                            model.Result = RegexHelper.IsValidUserNameId(model.Text);
                            break;
                        case 5:
                            model.Result = RegexHelper.IsValidUserNameIdBox(model.Text);
                            break;
                        case 6:
                            model.Result = RegexHelper.IsCoordinatesTxt(model.Text);
                            break;
                        case 7:
                            model.Result = RegexHelper.IsDuplicateWords(model.Text);
                            break;
                        case 8:
                            model.Result = RegexHelper.Is_A_URLTxt(model.Text);
                            break;
                        case 9:
                            model.Result = RegexHelper.Is_Facebook_bool(model.Text);
                            break;
                        case 10:
                            model.Result = RegexHelper.IsValidEmail(model.Text);
                            break;
                        case 11:
                            model.Result = RegexHelper.IsValidPhone(model.Text);
                            break;



                        default:
                            model.Result = false;
                            break;
                    }


                }
                else
                {
                    return this.View(model);
                }

            }
            return this.View(model);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
