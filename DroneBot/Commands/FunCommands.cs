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

namespace DroneBot.Commands
{
    public class FunCommands : BaseCommandModule
    {
        public bool isStopped { get; private set; }
        public bool isMutadoViado { get; private set; } = false;

        [Command("Ping")]
        [Description("Retorna pong(Comando Basico)")]
        public async Task Ping(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Pong").ConfigureAwait(false);
        }

        [Command("Somar")]
        [Description("Soma dois numeros")]
        public async Task Soma(CommandContext ctx, [Description("Numero 1")] double n1, [Description("Numero 2")] double n2)
        {
            await ctx.Channel.SendMessageAsync((n1 + n2).ToString("F2")).ConfigureAwait(false);
        }

        [Command("Desmutar")]
        [Description("Comando dalezada para desmutar vermes")]
        public async Task Desmutar(CommandContext ctx, [Description("Verme a ser desmutado")] DiscordMember user, [Description("Id do canal de voz 1")] DiscordChannel d1, [Description("Id do canal de voz 2")] DiscordChannel d2)
        {
            isStopped = false;
            while (!isStopped)
            {
                await user.PlaceInAsync(d1).ConfigureAwait(false);
                Thread.Sleep(1500);
                await user.PlaceInAsync(d2).ConfigureAwait(false);
            }
        }

        [Command("Desmutar2")]
        [Description("Comando dalezada para desmutar vermes")]
        public async Task Desmutar2(CommandContext ctx, DiscordChannel d1, DiscordChannel d2, params DiscordMember[] users)
        {
            foreach (var a in users)
            {
                await a.PlaceInAsync(d1).ConfigureAwait(false);
            }
            Thread.Sleep(1500);
            foreach (var a in users)
            {
                await a.PlaceInAsync(d2).ConfigureAwait(false);
            }

        }


        [Command("Stop")]
        [Description("Comando para parar o looping dos comandos")]
        public async Task Stop(CommandContext ctx)
        {
            isStopped = true;
        }

        [Command("MutadoViado")]
        [Description("Muta um verme, se o verme se desmutar ele toma dc(Acontece 1x só)")]
        public async Task DesmutarEViado(CommandContext ctx, [Description("Verme a ser abusado")] DiscordMember user)
        {
            await user.SetDeafAsync(true).ConfigureAwait(false);
            await user.SetMuteAsync(true).ConfigureAwait(false);
            isMutadoViado = true;
            Thread.Sleep(1500);
            while (isMutadoViado)
            {
                if (!user.IsDeafened || !user.IsMuted)
                {
                    await user.ModifyAsync(a => a.VoiceChannel = null).ConfigureAwait(false);
                    isMutadoViado = false;
                }
            }
        }

        [Command("ChangeNick")]
        public async Task Response(CommandContext ctx, DiscordMember user)
        {
            var intera = ctx.Client.GetInteractivity();
            var message = await intera.WaitForMessageAsync(x => x.Channel == ctx.Channel).ConfigureAwait(false);

            await user.ModifyAsync(x => x.Nickname = message.Result.Content).ConfigureAwait(false);

        }

        [Command("Ip")]
        public async Task Ip(CommandContext ctx)
        {
            string externalip = new WebClient().DownloadString("http://icanhazip.com");
            await ctx.Channel.SendMessageAsync(externalip);
        }

        [Command("IpCsgo")]
        public async Task IpCsgo(CommandContext ctx)
        {
            string externalip = new WebClient().DownloadString("http://icanhazip.com");
            externalip = externalip.Replace("\n", "");
            await ctx.Channel.SendMessageAsync((externalip + ":27016"));
        }





    }
}
