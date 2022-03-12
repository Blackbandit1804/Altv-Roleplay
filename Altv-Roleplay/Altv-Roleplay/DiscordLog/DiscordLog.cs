using System;
using System.Net;
using Discord.Webhook;
using Discord.Webhook.HookRequest;

namespace Altv_Roleplay.Handler
{
    class DiscordLog
    {
        internal static void SendEmbed(string type, string nickname, string text)
        {
            DiscordWebhook hook = new DiscordWebhook();

            switch (type)
            {
                case "adminmenu":
                    hook.HookUrl = "https://discordapp.com/api/webhooks/952175744056975410/xC6Kltx761KQ6LFTDxbKXJoBjDH6zaoOOWioQgK3-9jIdvVg1bPXXC-qaOrAkSBLxXEi";
                    break;
                default:
                    hook.HookUrl = "https://discordapp.com/api/webhooks/952175744056975410/xC6Kltx761KQ6LFTDxbKXJoBjDH6zaoOOWioQgK3-9jIdvVg1bPXXC-qaOrAkSBLxXEi";
                    break;
            }

            if (hook.HookUrl == "YOUR_WEBHOOK") return; //Hier YOUR_WEBHOOK nicht ersetzen

            DiscordHookBuilder builder = DiscordHookBuilder.Create(Nickname: nickname, AvatarUrl: "https://media.discordapp.net/attachments/723871259791720520/784117781271937034/Logo.png?width=519&height=519");

            DiscordEmbed embed = new DiscordEmbed(
                            Title: "Community-host.net Log",
                            Description: text,
                            Color: 0xf54242,
                            FooterText: "Community-host.net - Logs",
                            FooterIconUrl: "https://media.discordapp.net/attachments/723871259791720520/784117781271937034/Logo.png?width=519&height=519");
            builder.Embeds.Add(embed);

            DiscordHook HookMessage = builder.Build();
            hook.Hook(HookMessage);
        }
    }
}
