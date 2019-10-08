using System.Collections.Generic;

namespace tkt_tracker.Services
{
    public class TicketService
    {

        public List<string> Messages { get; set; }
        public TicketService()
        {
            Messages = new List<string>();
        }
    }
}