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
            string pageId = "316063401590480"; // ID de tu página de Facebook
            string accessToken = ""; // Reemplaza con tu token de acceso

            string message = "hola desde api graph 6"; // Mensaje que quieres publicar
            bool published = true; // Indicador de publicación

            using (var httpClient = new HttpClient())
            {
                try
                {
                    var requestUri = $"https://graph.facebook.com/{pageId}/feed";
                    var content = new StringContent($"message={message}&published={published}", System.Text.Encoding.UTF8, "application/x-www-form-urlencoded");

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
