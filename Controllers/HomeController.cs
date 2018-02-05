using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
        [Route("/journal")]
        public ActionResult Journal()
        {
            return View();
        }

        // [Route("/")]
        // public ActionResult Letter()
        // {
            // LetterVariable myLetterVariable = new LetterVariable();
            // myLetterVariable.SetRecipient("Eric");
            // myLetterVariable.SetSender("John");
            // return View(myLetterVariable);
        // }

        [Route("/")]
        public ActionResult Form()
        {
            return View();
        }

        [Route("/greeting_card")]
        public ActionResult GreetingCard()
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.SetRecipient(Request.Query["recipient"]);
            myLetterVariable.SetSender(Request.Query["sender"]);
            return View("Letter", myLetterVariable);
        }
    }
}