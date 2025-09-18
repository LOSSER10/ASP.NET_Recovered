using Event_Management_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Event_Management_System.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Users()
        {
           
            List<UserViewModel> users = new List<UserViewModel>();

            UserViewModel user1 = new UserViewModel()
            {
                FirstName = "Alice",
                LastName = "Johnson",
                ContactNumber = "123-456-7890",
                Email = "alice@example.com",
                UserType = 1 // Admin

            };
            UserViewModel user2 = new UserViewModel()
            {
                FirstName = "Bob",
                LastName = "Smith",
                ContactNumber = "987-654-3210",
                Email = "bob@example.com",
                UserType = 2 // Standard
            };
            UserViewModel user3 = new UserViewModel()
            {
                FirstName = "Charlie",
                LastName = "Davis",
                ContactNumber = "555-666-7777",
                Email = "charlie@example.com",
                UserType = 3 // External
            };
            UserViewModel user4 = new UserViewModel()
            {
                FirstName = "Diana",
                LastName = "Patel",
                ContactNumber = "111-222-3333",
                Email = "diana@example.com",
                UserType = 4 // Guest
            };
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);

            return View(users);
        }
    }
}
