namespace ScreenSound.WASM.Requests;

public record ArtistRequestEdit(int Id, string Name, string Bio, string ImageUrl)
    : ArtistRequest(Name, Bio, ImageUrl);