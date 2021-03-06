﻿using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotMarchesBotForWestMarches.Modules
{
    public class Ping : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task PingAsync()
        {
            await ReplyAsync("pong.");
        }
    }
}
