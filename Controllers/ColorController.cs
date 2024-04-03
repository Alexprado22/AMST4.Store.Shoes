using Microsoft.AspNetCore.Mvc;

namespace AMST4.Store.Shoes.Controllers;

public class ColorController : Controller
{
    [HttpGet]
    public ActionResult ColorIndex()
    {
        return View();
    }

    [HttpGet]
    public ActionResult Cadastre()
    {
        return View();
    }


}
