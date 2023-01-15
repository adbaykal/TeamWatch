using System.Text.Json.Serialization;

namespace TeamWatchAPI.Model
{
    public class SlackResponseDTO
    {
        [JsonPropertyName("blocks")]
        public List<Block> Blocks { get; set; }
    }
}

public class Block
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("text")]
    public Text Text { get; set; }
}

public class Text
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("text")]
    public string TextStr { get; set; }
}
