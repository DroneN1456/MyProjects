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
using DroneBot.Handlers.Dialogue.Steps;

namespace DroneBot.Handlers.Dialogue
{
    public class DialogueHandler
    {
        private readonly DiscordClient _client;
        private readonly DiscordChannel _channel;
        private readonly DiscordUser _user;
        private IDialogueStep _currentStep;


        public DialogueHandler(DiscordClient client, DiscordChannel channel, DiscordUser user, IDialogueStep startingStep)
        {
            _channel = channel;
            _client = client;
            _user = user;
            _currentStep = startingStep;
        }

        private readonly List<DiscordMessage> messages = new List<DiscordMessage>();
        public async Task<bool> ProcessDialogue()
        {
            while(_currentStep != null)
            {
                _currentStep.onMessageAdded += (message) => messages.Add(message);


                bool canceled = await _currentStep.ProcessStep(_client, _channel, _user).ConfigureAwait(false);

                if(canceled)
                {
                    await DeleteMessages().ConfigureAwait(false);
                    var cancelEmbed = new DiscordEmbedBuilder
                    {
                        Title = "O Dialogo foi cancelado!",
                        Description = _user.Mention,
                        Color = DiscordColor.Green
                    };

                    await _channel.SendMessageAsync(embed: cancelEmbed).ConfigureAwait(false);
                    return false;
                }

                _currentStep = _currentStep.NextStep;
            }

            await DeleteMessages().ConfigureAwait(false);

            return true;
        }

        private async Task DeleteMessages()
        {
            if (_channel.IsPrivate) { return; }

            foreach(var message in messages)
            {
                await message.DeleteAsync().ConfigureAwait(false);
            }
        }
    }
}
