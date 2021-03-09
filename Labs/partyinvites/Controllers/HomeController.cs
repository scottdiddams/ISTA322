using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System.Linq;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();  //returns the result from calling the view
        }
        [HttpGet]
        public ViewResult RsvpForm()    //Action Method
        {
            return View();      //Invokes the view method without args - 
        }                       //the Razor engine will use the name of the action file when looking for a view file
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
        }
        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true)); //Linq
        }
    }
}