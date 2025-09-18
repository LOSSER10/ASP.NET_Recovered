using Event_Management_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Event_Management_System.Controllers
{
    public class EventController : Controller
    {
        public List<EventViewModel> GetEvents()
        {
            List<EventViewModel> events = new List<EventViewModel>();

            EventViewModel event1 = new EventViewModel()
            {
                Name = "Music Concert",
                Description = "A live music concert featuring popular bands.",
                Date = new DateTime(2023, 11, 15),
                Address = "123 Music Ave, Cityville",
                Assigneduser = "Admin User"
            };
            EventViewModel event2 = new EventViewModel()
            {
                Name = "Art Exhibition",
                Description = "An exhibition showcasing contemporary art.",
                Date = new DateTime(2023, 12, 5),
                Address = "456 Art St, Townsville",
                Assigneduser = "Standard User"
            };
            EventViewModel event3 = new EventViewModel()
            {
                Name = "Tech Conference",
                Description = "A conference for tech enthusiasts and professionals.",
                Date = new DateTime(2024, 11, 20),
                Address = "789 Tech Rd, Metropolis",
                Assigneduser = "Admin User"
            };
            EventViewModel event4 = new EventViewModel()
            {
                Name = "Food Festival",
                Description = "A festival celebrating diverse cuisines and culinary arts.",
                Date = new DateTime(2025, 12, 10),
                Address = "321 Food Ln, Gourmet City",
                Assigneduser = "External User"
            };
            EventViewModel event5 = new EventViewModel()
            {
                Name = "Marathon",
                Description = "An annual marathon event for runners of all levels.",
                Date = new DateTime(2025, 11, 25),
                Address = "654 Runway Blvd, Sportstown",
                Assigneduser = "Guest User"
            };

            events.Add(event1);
            events.Add(event2);
            events.Add(event3);
            events.Add(event4);
            events.Add(event5);

            return events;
        }

        public IActionResult AllEvents()
        {
            var allevents = GetEvents();

            return View(allevents);
        }

        public IActionResult UpcomingEvents()
        {
            var events = GetEvents();

            DateTime today = new DateTime(2025, 9, 2);

            var upcomingEvents = events
                                .Where(e => e.Date > today)
                                .OrderBy(e => e.Date)
                                .ToList();

            return View(upcomingEvents);
        }
    }
}
 