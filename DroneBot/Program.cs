using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.EventArgs;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Converters;
using DSharpPlus.CommandsNext.Builders;
using DSharpPlus.CommandsNext.Entities;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.CommandsNext.Exceptions;
using DSharpPlus.Interactivity;
using DSharpPlus.Interactivity.Enums;
using DSharpPlus.Interactivity.EventHandling;
using DSharpPlus.Interactivity.Extensions;
using DSharpPlus.Net;
using DSharpPlus.Net.Models;
using DSharpPlus.Net.Serialization;
using DSharpPlus.Net.Udp;
using DSharpPlus.Net.WebSocket;
using DSharpPlus.Entities;
using System.IO;
using Newtonsoft.Json;
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
