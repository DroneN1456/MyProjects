using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.Exceptions;
using DSharpPlus.EventArgs;
using DSharpPlus.Interactivity;
using DSharpPlus.Net;
using DSharpPlus.Entities;
using DSharpPlus.CommandsNext.Attributes;
using System.Threading;
using System.Linq;
using DSharpPlus.Interactivity.Extensions;
using System.Net;
using System.Media;
using System.Timers;

namespace DroneBot.Commands
{
    public class SpecialCommands : BaseCommandModule
    {

        private bool _pedidos = false;
        private bool _especial = false;
        public SoundPlayer sound { get; private set; } = new SoundPlayer(@"C:\Users\gugag\source\repos\DroneBot\Resources\kzkzkzk.wav");
        public bool StopTimer { get; set; } = false;


        [Command("Pedidos")]
        [RequireOwner]
        public async Task Pedidos(CommandContext ctx)
        {
            Console.WriteLine("pedidos esta ativado!!!!");
            _pedidos = true;
            var pedidosEmbed = new DiscordEmbedBuilder
            {
                Title = "Pedidos!!!",
                Description = "Meia noite, façam seus pedidos :)) \n~Função feita pra minha praguinha q eu amo mto" +
                "\nIsso era apenas pra ser uma surpresinha, mas depois doque vc me contou hoje, eu decidi fazer algo mais" +
                "\nOlha cara, isso vai estar em todo o servidor KKKKKKK, então eu to com um pouco de vergonha e fodase" +
                "\nvoce é uma pessoa maravilhosa demais cara, te ver assim me machuca de vdd, vc é alguem que realmente faz todo mundo sorrir" +
                "\ne eu acho injusto voce, que tem sido o motivo do meu sorriso e minha motivação, não consiga ser feliz dentro do lugar q vc vive" +
                "\nentão aqui fica minha suspresinha :)",
                Color = DiscordColor.Magenta,
                ImageUrl = "https://cdn.discordapp.com/attachments/708424675201384460/789329177463226369/305bfbb2-9c4c-4421-b688-b8ae8c0d3267.jpg"
            };

            var guilds = ctx.Client.Guilds;

            while (_pedidos)
            {
                if (DateTime.Now.Hour == 0 && DateTime.Now.Minute == 0)
                {
                    foreach (var guild in guilds)
                    {
                        var channels = guild.Value.Channels;
                        foreach (var channel in channels)
                        {
                            if (channel.Value.Type == ChannelType.Text)
                            {
                                await channel.Value.SendMessageAsync(embed: pedidosEmbed).ConfigureAwait(false);
                            }
                        }
                    }
                    var coloraux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Warning, Pedidos esta setado como false, cuidada para nao perder seu viado");
                    Console.WriteLine("Warning, Pedidos esta setado como false, cuidada para nao perder seu viado");
                    Console.WriteLine("Warning, Pedidos esta setado como false, cuidada para nao perder seu viado");
                    Console.ForegroundColor = coloraux;
                    sound.Play();
                    _pedidos = false;
                }


            }
        }

        [Command("Pedidosteste")]
        [RequireOwner]
        public async Task pedidosteste(CommandContext ctx)
        {
            var pedidosEmbed = new DiscordEmbedBuilder
            {
                Title = "Pedidos!!!",
                Description = "Meia noite, façam seus pedidos :)) \n~Função feita pra minha praguinha q eu amo mto" +
               "\nIsso era apenas pra ser uma surpresinha, mas depois doque vc me contou hoje, eu decidi fazer algo mais" +
               "\nOlha cara, isso vai estar em todo o servidor KKKKKKK, então eu to com um pouco de vergonha e fodase" +
               "\nvoce é uma pessoa maravilhosa demais cara, te ver assim me machuca de vdd, vc é alguem que realmente faz todo mundo sorrir" +
               "\ne eu acho injusto voce, que tem sido o motivo do meu sorriso e minha motivação, não consiga ser feliz dentro do lugar q vc vive" +
               "\nentão aqui fica minha suspresinha :)",
                Color = DiscordColor.Magenta,
                ImageUrl = "https://cdn.discordapp.com/attachments/708424675201384460/789329177463226369/305bfbb2-9c4c-4421-b688-b8ae8c0d3267.jpg"
            };

            await ctx.Channel.SendMessageAsync(embed: pedidosEmbed);
        }

        [Command("LogOn")]
        [RequireOwner]
        public async Task LogOn(CommandContext ctx, DiscordMember user)
        {
            Console.WriteLine("Log is enabled!");
            TimeSpan interval = TimeSpan.FromMinutes(3);
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = interval.TotalMilliseconds;
            timer.Elapsed += new ElapsedEventHandler(OnElapseLog);
            timer.Start();



            void OnElapseLog(object sender, ElapsedEventArgs e)
            {
                if (StopTimer)
                {
                    timer.Stop();
                }
                else
                {
                    if (_pedidos == true)
                    {
                        user.SendMessageAsync("Everthing os ok!, pedidos is true :)");
                    }
                    else
                    {
                        user.SendMessageAsync("Warning!, pedidos is off, and its " + DateTime.Now.ToString("HH:mm"));
                    }
                }
            }
        }


        [Command("LogOff")]
        [RequireOwner]
        public async Task LogOff(CommandContext ctx)
        {
            
            StopTimer = true;
            
        }

        [Command("NomeEspecial")]
        public async Task NomeEspecial (CommandContext ctx)
        {
            _especial = true;
            while(_especial)
            {
               
            }
        }
       
    }
}
