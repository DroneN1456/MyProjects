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
    public class UtilitaryCommands : BaseCommandModule
    {
        Program _program = new Program();
        public SoundPlayer sound { get; private set; } = new SoundPlayer(@"C:\Users\gugag\source\repos\DroneBot\Resources\kzkzkzk.wav");

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

        [Command("ConsoleMsg")]
        public async Task ConsoleMsg(CommandContext ctx, params string[] message)
        {
            string date = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            await ctx.Message.DeleteAsync();
            int count = 0;
            string msg = string.Empty;
            foreach (var a in message)
            {
                if (count != 0)
                {
                    msg = msg + " " + a;
                }
                else
                {
                    msg = a;
                }
                count++;
            }
            var aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (ctx.Member.Nickname != null)
            {
                Console.WriteLine(date + " - " + ctx.Member.Username + "(" + ctx.Member.Nickname + ")" + " : " + msg);
            }
            else
            {
                Console.WriteLine(date + " - " + ctx.Member.Username + " : " + msg);
            }
            Console.ForegroundColor = aux;
            sound.Play();
        }

        [Command("sayasconsole")]
        public async Task sayasconsole(CommandContext ctx)
        {
            if (ctx.Member.Id == 252465089813282817)
            {
                await ctx.Message.DeleteAsync();
                string message = _program.Sendmessage();
                await ctx.Channel.SendMessageAsync(message);
            }
            else
            {
                await ctx.Channel.SendMessageAsync("Voce não é meu dono verme");
            }
        }


        [Command("ExecuteCommand")]
        public async Task ExecuteCommand(CommandContext ctx)
        {
            if (ctx.Member.Id == 252465089813282817)
            {
                await ctx.Message.DeleteAsync();

                string args = _program.ExecuteCommand();

                string[] fields = args.Split(" ");

                var users = ctx.Guild.Members;

                DiscordMember user = null;

                //Kick command
                if (fields[0].ToUpper() == "KICK")
                {
                    foreach (var a in users)
                    {
                        if (a.Value.Username == fields[1])
                        {
                            user = a.Value;
                        }

                    }

                    if (user != null)
                    {
                        await user.RemoveAsync();
                    }
                }

                //Disconect command
                if (fields[0].ToUpper() == "DISCONNECT")
                {
                    foreach (var a in users)
                    {
                        if (a.Value.Username == fields[1])
                        {
                            user = a.Value;
                        }

                    }

                    if (user != null)
                    {
                        await user.ModifyAsync(x => x.VoiceChannel = null);
                    }
                }
            }

            else
            {
                await ctx.Channel.SendMessageAsync("Voce não é meu dono verme");
            }

        }

        [Command("Clear")]
        public async Task Clear(CommandContext ctx, int number)
        {

            if (ctx.Member.PermissionsIn(ctx.Channel).HasPermission(Permissions.ManageMessages))
            {
                var a = await ctx.Channel.GetMessagesAsync(number);
                await ctx.Channel.DeleteMessagesAsync(a);
            }
            else
            {
                await ctx.Channel.SendMessageAsync("Voce não tem permissão para fazer isso :(");
            }

        }

        [Command("ClearAll")]

        public async Task ClearAll(CommandContext ctx)
        {
            if (ctx.Member.PermissionsIn(ctx.Channel).HasPermission(Permissions.ManageMessages))
            {
                var channel = await ctx.Channel.CloneAsync();
                var pos = ctx.Channel.Position;
                await ctx.Channel.DeleteAsync();
                await channel.ModifyPositionAsync(pos);
            }
            else
            {
                await ctx.Channel.SendMessageAsync("Voce não tem permissão para fazer isso :(");
            }

        }

        [Command("Mute")]
        public async Task Task(CommandContext ctx, DiscordMember user, TimeSpan duration)
        {
            var haspermission = ctx.Member.PermissionsIn(ctx.Channel);
            if (ctx.Member.PermissionsIn(ctx.Channel).HasPermission(Permissions.MuteMembers))
            {
                //setando as coisinhas
                var channels = ctx.Guild.Channels;
                System.Timers.Timer timer = new System.Timers.Timer();
                timer.Interval = duration.TotalMilliseconds;
                timer.Elapsed += new ElapsedEventHandler(OnElapseMute);
                timer.Start();



                //mutando a pessoa
                user.SetMuteAsync(true);
                foreach (var channel in channels)
                {
                    if (channel.Value.Type == ChannelType.Text)
                    {
                        await channel.Value.AddOverwriteAsync(user, Permissions.None, Permissions.SendMessages);
                    }
                }

                //desmutando a pessoa
                void OnElapseMute(object source, ElapsedEventArgs e)
                {
                    user.SetMuteAsync(false);
                    foreach (var channel in channels)
                    {
                        if (channel.Value.Type == ChannelType.Text)
                        {
                            channel.Value.AddOverwriteAsync(user, Permissions.SendMessages, Permissions.None);
                        }
                    }
                    timer.Stop();
                }
            }
            else
            {
                await ctx.Channel.SendMessageAsync("Voce não tem permissão para fazer isso :(").ConfigureAwait(false);
            }

        }


        [Command("TypeMode")]
        public async Task TypeMode(CommandContext ctx)
        {
            if (ctx.Member.Id == 252465089813282817)
            {
                _program.isTyping = true;
                while (_program.isTyping)
                {
                    var users = ctx.Guild.Members;
                    string argument = _program.Chatting();
                    if (argument[0] == '/')
                    {
                        string[] fields = argument.Split(' ');
                        if (fields[0].ToUpper() == "/KICK")
                        {
                            DiscordMember user = null;
                            foreach (var member in users)
                            {
                                if (member.Value.Username == fields[1])
                                {
                                    user = member.Value;
                                }
                            }
                            if (user != null)
                            {
                                await user.RemoveAsync();
                            }
                        }

                    }
                    else
                    {
                        await ctx.Channel.SendMessageAsync(argument);
                    }
                }
            }
            else
            {
                await ctx.Channel.SendMessageAsync("Voce não pode fazer isso!");
            }

        }


        [Command("TypeModeOff")]
        public async Task TypeModeOff(CommandContext ctx)
        {
            if (ctx.Member.Id == 252465089813282817)
            {
                _program.isTyping = false;
            }
            else
            {
                await ctx.Channel.SendMessageAsync("Voce não pode fazer isso!");
            }

        }


        [Command("Sorteio")]
        public async Task Sorteio(CommandContext ctx, params DiscordMember[] users)
        {
            Random rnd = new Random();
            List<DiscordMember> jafoi = new List<DiscordMember>();



            foreach (var user in users)
            {
                bool podeMandar = false;


                while(!podeMandar)
                {
                    var rnduser = users[rnd.Next(users.Count())];
                    if (!jafoi.Contains(rnduser))
                    {
                        jafoi.Add(rnduser);
                        var nomeEmbed = new DiscordEmbedBuilder
                        {
                            Title = "Seu nome foi:",
                            Description = rnduser.Username,
                            Color = DiscordColor.DarkBlue
                        };
                        await user.SendMessageAsync(embed: nomeEmbed);
                        var consolecolor = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine();
                        Console.WriteLine(user.Username + " Recebeu um nome unico :)");
                        Console.WriteLine();
                        Console.ForegroundColor = consolecolor;
                        podeMandar = true;
                    }
                    else
                    {

                    }
                }
       
            }

          
        }

        [Command("Disconnect")]
        public async Task Disconnect (CommandContext ctx, DiscordMember user)
        {
            var permissions = ctx.Member.PermissionsIn(ctx.Channel);
            if (permissions.HasPermission(Permissions.KickMembers))
            {
                await user.ModifyAsync(x => x.VoiceChannel = null);
            }
            else
            {
                await ctx.Channel.SendMessageAsync("Sem permissão para isso");
            }
        }

        [Command("Swap")]
        public async Task Swap (CommandContext ctx, DiscordMember user1, DiscordMember user2)
        {
            var permissions = ctx.Member.PermissionsIn(ctx.Channel);
            if (permissions.HasPermission(Permissions.KickMembers))
            {
                if (user1.VoiceState != null && user2.VoiceState != null)
                {
                    var channel1 = user1.VoiceState.Channel;
                    var channel2 = user2.VoiceState.Channel;
                    await user1.ModifyAsync(x => x.VoiceChannel = channel2);
                    await user2.ModifyAsync(x => x.VoiceChannel = channel1);

                }
                else
                {
                    await ctx.Channel.SendMessageAsync("Não é possivel efetuar o comando, ambos os membros precisam estar conectados a canais de voz");
                }
            }
            else
            {
                await ctx.Channel.SendMessageAsync("Você não tem permissao para fazer isso!");
            }
        }

        [Command("GetBot")]
        public async Task GetBot(CommandContext ctx)
        {
            var Drone = ctx.Guild.GetMemberAsync(252465089813282817).Result;
            var msgEmbed = new DiscordEmbedBuilder
            {
                Title = "Aqui esta o link para adicionar o bot no seu servidor :)",
                Description = "https://discord.com/oauth2/authorize?client_id=789147202139979816&scope=bot&permissions=8",
            };

            msgEmbed.Footer = new DiscordEmbedBuilder.EmbedFooter
            {
                Text = "Bot feito por " + Drone.ToString().Substring(27),
                IconUrl = "https://pbs.twimg.com/profile_images/1339315294838386699/zObYNagT_400x400.jpg"
            };



            await ctx.Member.SendMessageAsync(embed: msgEmbed);
        }




      



    }
}
