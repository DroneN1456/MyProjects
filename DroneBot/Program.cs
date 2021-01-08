using System;
using DroneBot.Commands;

namespace DroneBot
{
    class Program
    {
        public bool isTyping { get; set; } = false;

        static void Main(string[] args)
        {
            FunCommands funCommands = new FunCommands();
            var Bot = new Bot();
            Bot.RunAsync().GetAwaiter().GetResult();
        }

        public string  Sendmessage()
        {
            string message = Console.ReadLine();
            return message;
        }

        public string ExecuteCommand()
        {
            string message = Console.ReadLine();
            return message;
        }

        public string Chatting()
        {
            Console.Write(">");
            return Console.ReadLine();
        }
       
    }
}
