using System;
using System.Collections.Generic;
using System.Text;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.Net;
using DSharpPlus.Interactivity;
using Newtonsoft.Json;


namespace DroneBot
{
    public struct ConfigJson
    {
        [JsonProperty("token")]
        public string Token { get; private set; }
        [JsonProperty("prefix")]
        public string Prefix { get; private set; }
    }
}
