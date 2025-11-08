using System.Net.Http;

namespace BlueArchiveApi
{
    public class BlueArchive
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://api-blue-archive.vercel.app/api";
        public BlueArchive()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36"
            );
        }

        public async Task<string> GetCharacters()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/characters");
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetRandomCharacter()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/character/random");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
