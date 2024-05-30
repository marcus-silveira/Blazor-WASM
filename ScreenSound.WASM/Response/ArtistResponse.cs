using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ScreenSound.WASM.Response;

public record ArtistResponse(
    [property: JsonPropertyName("id")] int Id, 
    [property: JsonPropertyName("nome")] string Name, 
    [property: JsonPropertyName("bio")] string Bio, 
    [property: JsonPropertyName("fotoPerfil")] string? ProfilePhoto
); 