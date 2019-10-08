using System;
using tkt_tracker.Services;

namespace tkt_tracker.Controllers
{
    public class TicketController
    {
        private TicketService _ticketService = new TicketService();
        public void Run()
        {
            while (true)
            {
                GetUserInput();
                Update();
            }
        }

        private void Update()
        {
            Console.Clear();
            foreach (string message in _ticketService.Messages)
            {
                Console.WriteLine(message);
            }
                _ticketService.Messages.Clear();
        }
        private void GetUserInput()
        {
            
            Console.WriteLine("Ticket Tracker");
            System.Console.WriteLine("Please select an option: (view/new/quit)");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "quit":
                    Environment.Exit(0);
                    break;
                case "view":
                    _ticketService.Messages.Add("Select a ticket number to view");
                    break;
                case "new":
                    _ticketService.Messages.Add("Enter title for ticket");
                    break;
            }
        }
    }
}