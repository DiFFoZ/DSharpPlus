using System;
using DSharpPlus.Core.Attributes;
using DSharpPlus.Core.Enums;
using Newtonsoft.Json;

namespace DSharpPlus.Core.RestEntities
{
    [DiscordGatewayPayload("INTEGRATION_CREATE", "INTEGRATION_UPDATE")]
    public sealed record DiscordIntegration
    {
        /// <summary>
        /// The integration id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public DiscordSnowflake Id { get; init; } = null!;

        /// <summary>
        /// The integration name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; init; } = null!;

        /// <summary>
        /// The integration type (twitch, youtube, or discord).
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public DiscordIntegrationType Type { get; init; }

        /// <summary>
        /// Is this integration enabled.
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool Enabled { get; init; }

        /// <summary>
        /// Is this integration syncing.
        /// </summary>
        /// <remarks>
        /// Not provided for bot integrations.
        /// </remarks>
        [JsonProperty("syncing", NullValueHandling = NullValueHandling.Ignore)]
        public Optional<bool> Syncing { get; init; }

        /// <summary>
        /// The id that this integration uses for "subscribers".
        /// </summary>
        /// <remarks>
        /// Not provided for bot integrations.
        /// </remarks>
        [JsonProperty("role_id", NullValueHandling = NullValueHandling.Ignore)]
        public Optional<string> RoleId { get; init; }

        /// <summary>
        /// Whether emoticons should be synced for this integration (twitch only currently).
        /// </summary>
        /// <remarks>
        /// Not provided for bot integrations.
        /// </remarks>
        [JsonProperty("enable_emoticons", NullValueHandling = NullValueHandling.Ignore)]
        public Optional<bool> EnableEmoticons { get; init; }

        /// <summary>
        /// The behavior of expiring subscribers.
        /// </summary>
        /// <remarks>
        /// Not provided for bot integrations.
        /// </remarks>
        [JsonProperty("expire_behavior", NullValueHandling = NullValueHandling.Ignore)]
        public Optional<DiscordIntegrationExpireBehavior> ExpireBehavior { get; init; }

        /// <summary>
        /// The grace period (in days) before expiring subscribers.
        /// </summary>
        /// <remarks>
        /// Not provided for bot integrations.
        /// </remarks>
        [JsonProperty("expire_grace_period", NullValueHandling = NullValueHandling.Ignore)]
        public Optional<int> ExpireGracePeriod { get; init; }

        /// <summary>
        /// The user for this integration.
        /// </summary>
        /// <remarks>
        /// Not provided for bot integrations.
        /// </remarks>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public Optional<DiscordUser> User { get; init; }

        /// <summary>
        /// The integration account information.
        /// </summary>
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public DiscordIntegrationAccount Account { get; init; } = null!;

        /// <summary>
        /// When this integration was last synced.
        /// </summary>
        /// <remarks>
        /// Not provided for bot integrations.
        /// </remarks>
        [JsonProperty("synced_at", NullValueHandling = NullValueHandling.Ignore)]
        public Optional<DateTimeOffset> SyncedAt { get; init; }

        /// <summary>
        /// How many subscribers this integration has.
        /// </summary>
        /// <remarks>
        /// Not provided for bot integrations.
        /// </remarks>
        [JsonProperty("subscriber_count", NullValueHandling = NullValueHandling.Ignore)]
        public Optional<int> SubscriberCount { get; init; }

        /// <summary>
        /// Has this integration been revoked.
        /// </summary>
        /// <remarks>
        /// Not provided for bot integrations.
        /// </remarks>
        [JsonProperty("revoked", NullValueHandling = NullValueHandling.Ignore)]
        public Optional<bool> Revoked { get; init; }

        /// <summary>
        /// The bot/OAuth2 application for discord integrations.
        /// </summary>
        [JsonProperty("application", NullValueHandling = NullValueHandling.Ignore)]
        public Optional<DiscordIntegrationApplication> Application { get; init; }

        /// <summary>
        /// Sent on gateway integration events such as INTEGRATION_CREATE or INTEGRATION_UPDATE.
        /// </summary>
        public Optional<DiscordSnowflake> GuildId { get; init; }
    }
}