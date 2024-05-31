using ScreenSound.WASM.Requests;
using ScreenSound.WASM.Response;
using System.Net.Http.Json;

namespace ScreenSound.WASM.Services;

public class ArtistClient
{
	private readonly HttpClient _httpClient;

	public ArtistClient(IHttpClientFactory factory)
	{
		_httpClient = factory.CreateClient("ScreenSound.ServerAPI");
	}

	public async Task<ICollection<ArtistResponse>?> GetArtistsAsync()
	{
		var result = await _httpClient.GetFromJsonAsync<ICollection<ArtistResponse>>("artistas");
		return result;
	}

	public async Task RegisterArtistAsync(ArtistRequest artist)
	{
		await _httpClient.PostAsJsonAsync("artistas", artist);
	}

	public async Task<ArtistResponse?> GetArtistByName(string name)
	{
		return await _httpClient.GetFromJsonAsync<ArtistResponse>($"artistas/{name}");
	}
	public async Task<ArtistResponse?> GetArtistAsync(int id)
	{
		return await _httpClient.GetFromJsonAsync<ArtistResponse>($"artista/{id}");
	}
	public async Task DeleteArtistAsync(int id)
	{
		await _httpClient.DeleteAsync($"artistas/{id}");
	}

	public async Task UpdateArtistAsync(ArtistRequestEdit artist)
	{
		await _httpClient.PutAsJsonAsync($"artistas", artist);
	}
}

