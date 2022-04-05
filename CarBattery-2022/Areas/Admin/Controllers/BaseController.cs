namespace CarBattery_2022.Areas.Admin.Controllers
{
    using CarBattery_2022.Core.Constants;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using static CarBattery_2022.Core.Constants.UserConstants;

    [Authorize (Roles = UserConstants.Roles.Administrator)]
    [Area("Admin")]
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
