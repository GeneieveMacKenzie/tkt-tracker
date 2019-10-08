using System;
using tkt_tracker.Controllers;

namespace tkt_tracker
{
    class Program
    {
        static void Main(string[] args)
        {
            new TicketController().Run();
        }
    }
}
