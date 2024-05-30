namespace ScreenSound.WASM.Requests;

public record ArtistRequestEdit(int Id, string Name, string Bio)
    : ArtistRequest(Name, Bio);