var client = new HttpClient();
var request = new HttpRequestMessage
{
    Method = HttpMethod.Post,
    RequestUri = new Uri("https://face-similarity.p.rapidapi.com/FaceSimilar"),
    Headers =
    {
        { "x-rapidapi-key", "APIKEY" },
        { "x-rapidapi-host", "face-similarity.p.rapidapi.com" },
    },
    Content = new FormUrlEncodedContent(new Dictionary<string, string>
    {
        { "imageBase64", "<REQUIRED>" },
    }),
};
using (var response = await client.SendAsync(request))
{
    response.EnsureSuccessStatusCode();
    var body = await response.Content.ReadAsStringAsync();
    Console.WriteLine(body);
}
