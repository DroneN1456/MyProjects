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


namespace DroneBot.Commands
{
    public class FunCommands : BaseCommandModule
    {
        public bool isStopped { get; private set; }
        public bool isMutadoViado { get; private set; } = false;
        public bool isFinished { get; private set; } = false;
        public DiscordMember CurrentUser { get; private set; }
        public SoundPlayer sound { get; private set; } = new SoundPlayer(@"C:\Users\gugag\source\repos\DroneBot\Resources\kzkzkzk.wav");
        public static Dictionary<DiscordMember, IEnumerable<DiscordRole>> esperandoporcargo = new Dictionary<DiscordMember, IEnumerable<DiscordRole>>();

        [Command("Ping")]
        [Description("Retorna pong(Comando Basico)")]
        [RequirePermissions(Permissions.Administrator)]
        public async Task Ping(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Pong").ConfigureAwait(false);
        }

        [Command("Somar")]
        [Description("Soma dois numeros")]
        [RequirePermissions(Permissions.Administrator)]
        public async Task Soma(CommandContext ctx, [Description("Numero 1")] double n1, [Description("Numero 2")] double n2)
        {
            await ctx.Channel.SendMessageAsync((n1 + n2).ToString("F2")).ConfigureAwait(false);
        }

        [Command("Desmutar")]
        [Description("Comando dalezada para desmutar vermes")]
        [RequirePermissions(Permissions.Administrator)]
        public async Task Desmutar(CommandContext ctx, [Description("Verme a ser desmutado")] DiscordMember user, [Description("Id do canal de voz 1")] DiscordChannel d1, [Description("Id do canal de voz 2")] DiscordChannel d2)
        {
            CurrentUser = ctx.Member;
            isStopped = false;
            while(!isStopped)
            {
                if (user.VoiceState.Channel != null)
                {
                    await user.ModifyAsync(x => x.VoiceChannel = d1);
                    Thread.Sleep(1500);
                    if (user.VoiceState.Channel != null)
                    {
                        await user.ModifyAsync(x => x.VoiceChannel = d2);
                    }
                }
                else
                {
                    await ctx.Channel.SendMessageAsync("Usuario não esta em um canal de voz, tentando novamente em 5 segundos");
                    Thread.Sleep(5000);
                }
            }
        }

        [Command("Desmutar2")]
        [Description("Comando dalezada para desmutar vermes")]
        [RequirePermissions(Permissions.Administrator)]
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
        [RequirePermissions(Permissions.Administrator)]
        public async Task Stop(CommandContext ctx)
        {
            if (CurrentUser != ctx.Member)
            {
                await ctx.Channel.SendMessageAsync("Apenas a pessoa que executou o comando pode dar *stop");
            }
            else
            {
                CurrentUser = null;
                isStopped = true;
            }
        }

        [Command("MutadoViado")]
        [Description("Muta um verme, se o verme se desmutar ele toma dc(Acontece 1x só)")]
        [RequirePermissions(Permissions.Administrator)]
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
        [RequirePermissions(Permissions.Administrator)]
        public async Task Response(CommandContext ctx, DiscordMember user)
        {
            var intera = ctx.Client.GetInteractivity();
            var message = await intera.WaitForMessageAsync(x => x.Channel == ctx.Channel).ConfigureAwait(false);

            await user.ModifyAsync(x => x.Nickname = message.Result.Content).ConfigureAwait(false);

        }


        [Command("KickInvite")]
        [RequirePermissions(Permissions.Administrator)]
        public async Task KickInvite(CommandContext ctx, DiscordMember user)
        {
            var roles = user.Roles;
            var invites = ctx.Guild.GetInvitesAsync().Result;
            DiscordInvite invitex = null;
            foreach (var invite in invites)
            {
                if (invite.MaxAge == 0 && invite.MaxUses == 0)
                {
                    invitex = invite;
                    break;
                }
            }
            await user.SendMessageAsync(invitex.ToString());
            await user.RemoveAsync();
            esperandoporcargo.Add(user, roles);


        }

        [Command("DevolverCargos")]
        public async Task DevolverCargos(CommandContext ctx)
        {
            if (esperandoporcargo.Count != 0)
            {
                foreach (var user in esperandoporcargo)
                {
                    foreach (var role in user.Value)
                    {
                        await user.Key.GrantRoleAsync(role);
                    }
                }
            }
            else
            {
                await ctx.Channel.SendMessageAsync("Não tem ninguem esperando por cargo!");
            }
        }

        [Command("EsperandoPorCargos")]
        public async Task EsperandoPorCargos(CommandContext ctx)
        {
            if (esperandoporcargo.Count != 0)
            {
                var msmembemd = new DiscordEmbedBuilder
                {
                    Title = "Membros esperando por cargo:",
                    Color = DiscordColor.Aquamarine
                };
                foreach (var user in esperandoporcargo)
                {
                    string roles = "";
                    foreach (var role in user.Value)
                    {
                        roles = roles + " `" + role.Name + "`";
                    }
                    msmembemd.AddField(user.Key.Username, roles, false);
                }
                await ctx.Channel.SendMessageAsync(embed: msmembemd);
            }
            else
            {
                await ctx.Channel.SendMessageAsync("Não tem ninguem esperando por cargo!");
            }
        }

       



        [Command("Ban")]
        [RequirePermissions(Permissions.Administrator)]
        public async Task Ban(CommandContext ctx, DiscordMember user)
        {
            await user.BanAsync();
            await user.SendMessageAsync("VAZA VERME, MEDIOCRE!!");
        }

        [Command("Desmutar3")]
        [RequirePermissions(Permissions.Administrator)]
        public async Task Desmutar3(CommandContext ctx, DiscordChannel channel, DiscordChannel channel2)
        {

        }







    }
}
