using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers;

public class HomeController : Controller
{
   
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public ViewResult RsvpForm()
    {
        return View();
    }

    [HttpPost]
    public ViewResult RsvpForm(GuestResponse guessResponse) 
    { 
        if(ModelState.IsValid)
        {
            Repository.AddResponse(guessResponse);
            return View("Thanks", guessResponse);
        }
        else
        {
            return View();
        }
       
    }

    public ViewResult ListResponses()
    {
        return View(Repository.responses.Where(r => r.WillAttend == true));
    }

}
