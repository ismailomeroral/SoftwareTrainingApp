using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SoftwareTrainingApplication.EntityModels;
using SoftwareTrainingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTrainingApplication.ViewModels
{
    internal class AIController
    {

        static public List<Chat> ListChatHistory(List<Chat> _chat, string _user, string _message)
        {
            _chat.Add(new Chat { user = _user, message = _message });
            return _chat;
        }
        static public List<Chat> ListChatHistory( string _user, string _message)
        {
            List<Chat> list = new List<Chat> {new Chat { user= _user, message= _message } };
            return list;
        }

        static public async Task<string> SendRequestAndGetResponse(string _prompt, double _temperature)
        {
            HttpClient client = new HttpClient();
            var requestBody = new
            {
                contents = new[]
        {
            new
            {
                role = "user",
                parts = new[]
                {
                    new { text = _prompt }
                }
            }
        },
                generationConfig = new
                {
                    temperature = _temperature,
                    topK = 64,
                    topP = 0.95,
                    maxOutputTokens = 8196,
                    stopSequences = new string[] { }
                },
                safetySettings = new object[] { }
            };

            string jsonBody = JsonConvert.SerializeObject(requestBody);
            var request = new HttpRequestMessage(HttpMethod.Post, $"https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-pro:generateContent?key={Gemini.apiKey}");
            request.Content = new StringContent(jsonBody, Encoding.UTF8);
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await client.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                return BreakTheRequest(responseBody);
            }
            else
            {
                return $"Error: {response.StatusCode} - {response.ReasonPhrase}";
            }
        }
        static private string BreakTheRequest(string _response)
        {
            // JSON verisini parse etmek için JObject kullanıyoruz
            JObject jsonObject = JObject.Parse(_response);

            // "parts" dizisindeki "text" alanını almak için path kullanıyoruz
            string response = (string)jsonObject["candidates"][0]["content"]["parts"][0]["text"];

            return response;
        }

    }
}
