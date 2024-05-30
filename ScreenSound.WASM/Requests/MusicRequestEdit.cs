namespace ScreenSound.WASM.Requests;

public record MusicaRequestEdit(int Id, string Name, int ArtistId, int Release)
    : MusicRequest(Name, ArtistId, Release);