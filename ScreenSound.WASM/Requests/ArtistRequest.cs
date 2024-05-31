using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ScreenSound.WASM.Requests;
public record ArtistRequest([Required] [property: JsonPropertyName("nome")] string Name, [Required] string Bio, [property: JsonPropertyName("fotoPerfil")] string? ImageUrl);

