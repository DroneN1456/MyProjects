using DSharpPlus;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DroneBot.Handlers.Dialogue.Steps
{
    public abstract class DialogueStepBase : IDialogueStep
    {

        protected readonly string _content;

        public DialogueStepBase(string content)
        {
            _content = content;
        }

        public Action<DiscordMessage> onMessageAdded { get; set; } = delegate { };
        public abstract IDialogueStep NextStep { get; }

        public abstract Task<bool> ProcessStep(DiscordClient client, DiscordChannel channel, DiscordUser user);
       

        public async Task TryAgain(DiscordChannel channel, string problem)
        {
            var embedBuilder = new DiscordEmbedBuilder
            {
                Title = "Tente novamente",
                Color = DiscordColor.Red
            };

            embedBuilder.AddField("Houve um problema com o seu input anterior", problem);
            var embed = await channel.SendMessageAsync(embed: embedBuilder).ConfigureAwait(false);

            onMessageAdded(embed);
        }
    }
}
