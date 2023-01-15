using System.Text.Json.Serialization;

namespace TeamWatchAPI.Model
{
    public class SlackCommandDTO
    {
        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("team_id")]
        public string TeamId { get; set; }

        [JsonPropertyName("team_domain")]
        public string TeamDomain { get; set; }

        [JsonPropertyName("enterprise_id")]
        public string EnterpriseId { get; set; }

        [JsonPropertyName("enterprise_name")]
        public string EnterpriseName { get; set; }

        [JsonPropertyName("channel_id")]
        public string ChannelId { get; set; }

        [JsonPropertyName("channel_name")]
        public string ChannelName { get; set; }

        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        [JsonPropertyName("user_name")]
        public string UserName { get; set; }

        [JsonPropertyName("command")]
        public string Command { get; set; }

        [JsonPropertyName("text")]
        public int Text { get; set; }

        [JsonPropertyName("response_url")]
        public string ResponseUrl { get; set; }

        [JsonPropertyName("trigger_id")]
        public string TriggerId { get; set; }

        [JsonPropertyName("api_app_id")]
        public string ApiAppId { get; set; }
    }
}


