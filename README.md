# BlueArchive.cs
Web-API for api-blue-archive.vercel.app an open source API providing character information about the Blue Archive

## Example
```cs
using BlueArchiveApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new BlueArchive();
            string characters = await api.GetCharacters();
            Console.WriteLine(characters);
        }
    }
}
```
