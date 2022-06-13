using System;

namespace DSharpPlus.Core.Enums
{
    /// <remarks>
    /// Type 10 (<see cref="GuildNewsThread"/>), 11 (<see cref="GuildPublicThread"/>) and 12 (<see cref="GuildPrivateThread"/>) are only available in API v9.
    /// </remarks>
    [Flags] // Required for DiscordApplicationCommandOption.ChannelTypes
    public enum DiscordChannelType
    {
        /// <summary>
        /// A text channel within a server.
        /// </summary>
        GuildText = 0,

        /// <summary>
        /// A direct message between users.
        /// </summary>
        Dm = 1,

        /// <summary>
        /// A voice channel within a server.
        /// </summary>
        GuildVoice = 2,

        /// <summary>
        /// A direct message between multiple users.
        /// </summary>
        GroupDm = 3,

        /// <summary>
        /// An <see href="https://support.discord.com/hc/en-us/articles/115001580171-Channel-Categories-101">organizational category</see> that contains up to 50 channels.
        /// </summary>
        GuildCategory = 4,

        /// <summary>
        /// A channel that <see href="https://support.discord.com/hc/en-us/articles/360032008192">users can follow and crosspost into their own server</see>.
        /// </summary>
        GuildNews = 5,

        /// <summary>
        /// A channel in which game developers can <see href="https://discord.com/developers/docs/game-and-server-management/special-channels">sell their game on Discord</see>.
        /// </summary>
        [Obsolete("Selling SKUs on Discord has been discontinued as of March 1, 2022. Read here for more info: https://support-dev.discord.com/hc/en-us/articles/4414590563479")]
        GuildStore = 6,

        /// <summary>
        /// A temporary sub-channel within a <see cref="GuildNews"/> channel.
        /// </summary>
        GuildNewsThread = 10,

        /// <summary>
        /// A temporary sub-channel within a <see cref="GuildText"/> channel.
        /// </summary>
        GuildPublicThread = 11,

        /// <summary>
        /// A temporary sub-channel within a <see cref="GuildText"/> channel that is only viewable by those invited and those with the <see cref="DiscordPermissions.ManageThreads"/> permission.
        /// </summary>
        GuildPrivateThread = 12,

        /// <summary>
        /// A voice channel for <see href="https://support.discord.com/hc/en-us/articles/1500005513722">hosting events with an audience</see>.
        /// </summary>
        GuildStageVoice = 13,

        /// <summary>
        /// The channel in a hub containing the listed servers.
        /// </summary>
        GuildDirectory = 14
    }
}