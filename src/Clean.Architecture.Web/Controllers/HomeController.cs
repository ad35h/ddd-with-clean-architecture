using Clean.Architecture.Core.Entities;
using Clean.Architecture.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Clean.Architecture.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var guestbook = new Guestbook() { Name = "My Guestbook" };
            guestbook.Entries.Add(new GuestbookEntry() { EmailAddress = "test@gmail.com", Message = "Hello!", DateTimeCreated = DateTime.UtcNow.AddHours(-2) });
            guestbook.Entries.Add(new GuestbookEntry() { EmailAddress = "test1@gmail.com", Message = "Hello1!", DateTimeCreated = DateTime.UtcNow.AddHours(-1) });
            guestbook.Entries.Add(new GuestbookEntry() { EmailAddress = "test2@gmail.com", Message = "Hello2!" });

            var viewModel = new HomePageViewModel();
            viewModel.GuestbookName = guestbook.Name;
            viewModel.PreviousEntries.AddRange(guestbook.Entries);

            return View(viewModel);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
