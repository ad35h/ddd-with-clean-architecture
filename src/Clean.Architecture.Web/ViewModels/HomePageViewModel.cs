using Clean.Architecture.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clean.Architecture.Web.ViewModels
{
    public class HomePageViewModel
    {
        public string GuestbookName { get; set; }
        public List<GuestbookEntry> PreviousEntries { get; set; }
        public HomePageViewModel()
        {
            PreviousEntries = new List<GuestbookEntry>();
        }
    }
}
