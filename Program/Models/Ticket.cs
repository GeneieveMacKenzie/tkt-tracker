using tkt_tracker.Interfaces;

namespace tkt_tracker.Models
{
    public class Ticket : ITicket
    {

        public string Title { get; set; }
        public string Description { get; set; }

        public Ticket(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}