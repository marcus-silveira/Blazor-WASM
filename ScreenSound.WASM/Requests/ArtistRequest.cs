using System.ComponentModel.DataAnnotations;

namespace ScreenSound.WASM.Requests;
public record ArtistRequest([Required] string Name, [Required] string Bio);

