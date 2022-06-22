// Copyright © 2022-present Corpsolution Tech. All Rights Reserved.
// See LICENSE for license information.

namespace Web.Streamteam.HttpAggregator.Web.Streamteam.HttpAggregator.Controllers;

[Route("")]
public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return new RedirectResult("~/swagger");
    }
}