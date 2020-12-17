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

namespace DroneBot.Commands
{
    public class TeamCommands : BaseCommandModule
    {
       

        [Command("Entrar")]
        public async Task Ping(CommandContext ctx)
        {
            var joinEmbed = new DiscordEmbedBuilder
            {
                Title = "Quer entrar para o time GirombaBot?",
                ImageUrl = ctx.Client.CurrentUser.AvatarUrl,
                Description = "Ao entrar voce tera acesso aos comandos do GirombaBot",
                Color = DiscordColor.Green
            };

            var joinMessage = await ctx.Channel.SendMessageAsync(embed: joinEmbed).ConfigureAwait(false);
            var ThumbsUp = DiscordEmoji.FromName(ctx.Client, ":+1:");
            var ThumbsDown = DiscordEmoji.FromName(ctx.Client, ":-1:");

            await joinMessage.CreateReactionAsync(ThumbsUp).ConfigureAwait(false);
            await joinMessage.CreateReactionAsync(ThumbsDown).ConfigureAwait(false);

            var intera = ctx.Client.GetInteractivity();

            var result = await intera.WaitForReactionAsync(x => x.Message == joinMessage && x.User == ctx.User && (x.Emoji == ThumbsUp || x.Emoji == ThumbsDown)).ConfigureAwait(false);

            if(result.Result.Emoji == ThumbsUp)
            {
                if (ctx.Guild.Id == 556245740624543755)
                {
                    var role = ctx.Guild.GetRole(789216446374346793);
                    await ctx.Member.GrantRoleAsync(role).ConfigureAwait(false);
                }
                
            }
            await joinMessage.DeleteAsync();

        }

     
       
    }
}
