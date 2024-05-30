namespace ScreenSound.WASM.Response;

public record MusicResponse(int Id, string Name, int ArtistId, string ArtistName, int? Release);