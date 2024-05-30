using System.ComponentModel.DataAnnotations;

namespace ScreenSound.WASM.Requests;

public record MusicRequest([Required] string Name, [Required] int ArtistId, int Release, ICollection<GenreRequest> Genre = null);

