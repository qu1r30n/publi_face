using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace publicaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_empezar_Click(object sender, EventArgs e)
        {
            //publicar_face(0, "pru c2", "316063401590480", "EAALC3ciHKp4BO2LTb9dFBpBdlpBTPXufA24vS9zZCCgOuirxXiPGXFdMzOzZCPNkFlabXhpKnMOmqFEc4MtVnxa6MZAAWmaL2fZCUZCy0ZCZBMuPEarMoxaNlMijIgOZAVFJth7rM7ycu5ZCFvde3VT61stbIRqU0MvuMZAUOgSaIF7RJTTCXW6Iau5jzZCuYMEIJpZByqaUZAJ9W");
            //publicar_face(1, "https://i.ibb.co/MM8BXcT/25.jpg", "316063401590480", "EAALC3ciHKp4BO2LTb9dFBpBdlpBTPXufA24vS9zZCCgOuirxXiPGXFdMzOzZCPNkFlabXhpKnMOmqFEc4MtVnxa6MZAAWmaL2fZCUZCy0ZCZBMuPEarMoxaNlMijIgOZAVFJth7rM7ycu5ZCFvde3VT61stbIRqU0MvuMZAUOgSaIF7RJTTCXW6Iau5jzZCuYMEIJpZByqaUZAJ9W");
            publicar_face(2, "https://8y-qu1r30n.000webhostapp.com/1.mp4", "316063401590480", "EAALC3ciHKp4BO2LTb9dFBpBdlpBTPXufA24vS9zZCCgOuirxXiPGXFdMzOzZCPNkFlabXhpKnMOmqFEc4MtVnxa6MZAAWmaL2fZCUZCy0ZCZBMuPEarMoxaNlMijIgOZAVFJth7rM7ycu5ZCFvde3VT61stbIRqU0MvuMZAUOgSaIF7RJTTCXW6Iau5jzZCuYMEIJpZByqaUZAJ9W");
        }

        public async void publicar_face(int tipo, string url_o_mensage, string pageId, string accessToken)
        {
            

            
            bool published = true; // Indicador de publicación

            using (var httpClient = new HttpClient())
            {
                string requestUri;
                StringContent content;
                try
                {
                    switch (tipo)
                    {
                        case 0:
                            //texto
                            requestUri = $"https://graph.facebook.com/{pageId}/feed";
                            content = new StringContent($"message={url_o_mensage}&published={published}", System.Text.Encoding.UTF8, "application/x-www-form-urlencoded");
                            break;
                        case 1:
                            //imagen
                            requestUri = $"https://graph.facebook.com/{pageId}/photos";
                            content = new StringContent($"url={url_o_mensage}&published={published}", System.Text.Encoding.UTF8, "application/x-www-form-urlencoded");
                            break; 
                        case 2:
                            //video
                            requestUri = $"https://graph.facebook.com/{pageId}/videos";
                            content = new StringContent($"file_url={url_o_mensage}&published={published}", System.Text.Encoding.UTF8, "application/x-www-form-urlencoded");
                            break;
                        default:
                            //texto otra vez
                            requestUri = $"https://graph.facebook.com/{pageId}/feed";
                            content = new StringContent($"message={url_o_mensage}&published={published}", System.Text.Encoding.UTF8, "application/x-www-form-urlencoded");
                            break;
                    }
                    
                    httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

                    var response = await httpClient.PostAsync(requestUri, content);

                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Publicación exitosa en el muro de Facebook.");
                        MessageBox.Show("Publicación exitosa en el muro de Facebook.");
                    }
                    else
                    {
                        Console.WriteLine("Error al publicar en el muro de Facebook.");
                        MessageBox.Show("Error al publicar en el muro de Facebook.");
                    }
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"Error en la solicitud HTTP: {ex.Message}");
                    MessageBox.Show($"Error en la solicitud HTTP: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

    }
}
