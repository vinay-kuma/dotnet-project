using System.Text.Json.Serialization;

namespace dotnet_project.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum projectClass
    {
        King = 1,
        Queen = 2,
        joker = 3
    }
}