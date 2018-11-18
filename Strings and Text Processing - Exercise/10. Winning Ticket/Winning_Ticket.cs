using System;

namespace _10._Winning_Ticket
{
    public class Winning_Ticket
    {
        public static void Main()
        {
            string[] tickets = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < tickets.Length; i++)
            {
                var currentTicket = new Ticket(tickets[i]);
                if (currentTicket.IsValid)
                {
                    if (currentTicket.IsWinner)
                    {
                        if (currentTicket.HasJackpot)
                        {
                            // Match with length 10
                            Console.WriteLine($"ticket \"{currentTicket.Value}\" - {currentTicket.Match.Length}{currentTicket.Match[0]} Jackpot!");
                        }
                        else
                        {
                            // Match with length 6 to 9 
                            Console.WriteLine($"ticket \"{currentTicket.Value}\" - {currentTicket.Match.Length}{currentTicket.Match[0]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{currentTicket.Value}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
