using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace publicaciones
{
    public class FacebookAPI
    {
        private readonly string accessToken;

        public FacebookAPI(string accessToken)
        {
            this.accessToken = accessToken;
        }

        public async Task<string> UploadPhotoToProfileAsync(string imagePath, string message)
        {
            using (var httpClient = new HttpClient())
            {
                string requestUrl = $"https://graph.facebook.com/me/photos?access_token={accessToken}";

                using (var form = new MultipartFormDataContent())
                {
                    form.Add(new StringContent(message), "message");
                    var imageContent = new ByteArrayContent(System.IO.File.ReadAllBytes(imagePath));
                    imageContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");
                    form.Add(imageContent, "source", System.IO.Path.GetFileName(imagePath));

                    HttpResponseMessage response = await httpClient.PostAsync(requestUrl, form);

                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        string errorDetails = await response.Content.ReadAsStringAsync();
                        return $"Error: {response.ReasonPhrase} - {errorDetails}";
                    }
                }
            }
        }
    }
}
