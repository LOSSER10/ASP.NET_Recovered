using System.Security.Principal;

namespace Event_Management_System.Models
{  public class EventViewModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public string? Address { get; set; }

        public string? Assigneduser { get; set; }



    }
}
