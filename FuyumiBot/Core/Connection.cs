﻿using FuyumiBot.Core.Entities;
using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace FuyumiBot.Core
{
    public class Connection
    {
        private readonly DiscordSocketClient _client;

        private readonly DiscordLogger _logger;

        public Connection(DiscordLogger logger, DiscordSocketClient client)
        {
            _logger = logger;
            _client = client;
        }

        internal async Task ConnectAsync(BotConfig config)
        {
            _client.Log += _logger.Log;

            await _client.LoginAsync(TokenType.Bot, config.Token);
            await _client.StartAsync();

            await _client.SetActivityAsync(config.Activity);

            await Task.Delay(-1);
        }
    }
}