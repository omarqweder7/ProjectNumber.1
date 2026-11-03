using System;
using System.Collections.Generic;
using System.Text;

namespace Project_no._1
{
    public class Chat
    {
        public static void Main(string[] args)
        {
            ChatterBot[] bots = new ChatterBot[2];
            Console.Write("Enter the first bot name: ");
            string name1 = Console.ReadLine();
            Console.Write("Enter the second bot name: ");
            string name2 = Console.ReadLine();
            string[] Greets = new string[4];
            Greets[0] = "Hi! " ; Greets[1] = "How are you? "; Greets[2] = "Whats good? "; Greets[3] = "Whats up? ";
            bots[0] = new ChatterBot(name1, Greets);
            bots[1] = new ChatterBot(name2, Greets);
            string statement = "Hello!";
            while (true)
            {
                foreach(ChatterBot bot in bots)
                {
                    statement = bot.ReplyTo(statement);
                    Console.WriteLine($"{bot.GetName()}:{statement}");
                    Console.ReadLine();
                }
            }
        }
    }

}

