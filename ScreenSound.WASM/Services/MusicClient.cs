using ScreenSound.WASM.Response;
using System.Net.Http.Json;

namespace ScreenSound.WASM.Services;

public class MusicClient
{
	private readonly HttpClient _httpClient;
	public MusicClient(IHttpClientFactory factory)
	{
		_httpClient = factory.CreateClient("ScreenSound.ServerAPI");
	}

	public async Task<ICollection<MusicResponse>?> GetMusicsAsync()
	{
		return await _httpClient.GetFromJsonAsync<ICollection<MusicResponse>>("musicas");
	}
}
