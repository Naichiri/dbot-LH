﻿using Discord.WebSocket;

namespace dbotLH.Core.Entities
{
    public class BotConfig
    {
        public string Token { get; set; }
        public DiscordSocketConfig SocketConfig { get; set; }
    }
}
