using System;
using System.Collections.Generic;
using tkt_tracker.Models;

namespace tkt_tracker.Services
{
    public class TicketService
    {
        public List<Ticket> Tickets { get; set; }
        public List<string> Messages { get; set; }
        public TicketService()
        {
            Messages = new List<string>();
            Tickets = new List<Ticket>();
        }

        internal void CreateTicket(string title, string desc)
        {
            Tickets.Add(new Ticket(title, desc));
        }

        internal Ticket View(int index)
        {
            return Tickets[index];
        }
    }
}