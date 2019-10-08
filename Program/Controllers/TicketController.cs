using System;
using tkt_tracker.Models;
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
                Update();
                GetUserInput();
            }

        }

        private void Update()
        {
            Console.Clear();
            Console.WriteLine("\t    Ticket Tracker \n");
            Console.WriteLine("\t Number \t Title");
            Console.WriteLine("\t------------------------- \n");
            foreach (string message in _ticketService.Messages)
            {
                Console.WriteLine(message);
            }
            int index = 0;
            foreach (Ticket ticket in _ticketService.Tickets)
            {
                index++;
                Console.WriteLine($"\t  {index}.\t\t{ticket.Title}");
            }
        }
        private void GetUserInput()
        {
            
            System.Console.WriteLine("\n Please select an option: (view/new/quit)");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "quit":
                    Environment.Exit(0);
                    break;
                case "view":
                    ViewTicket();
                    break;
                case "new":
                    NewTicket();
                    break;
            }
        }

        private void NewTicket()
        {
            Console.WriteLine("Title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Description: ");
            string desc = Console.ReadLine();
            _ticketService.CreateTicket(title, desc);

        }

        private void ViewTicket()
        {
            Console.WriteLine("Select a number");
            if(int.TryParse(Console.ReadLine(), out int index))
            {
                Ticket ticket =_ticketService.View(index - 1);
                Console.Clear();
                Console.WriteLine(
$@"Title: {ticket.Title} 
Description: {ticket.Description}");
                Console.WriteLine("Select R to return to main menu or Q to quit");
                string input = Console.ReadLine().ToLower();
                switch(input)
                {
                    case "r":
                        Run();
                        break;
                    case "q":
                        Environment.Exit(0);
                        break;
                }
                Console.ReadLine();
            }

        }
    }
}