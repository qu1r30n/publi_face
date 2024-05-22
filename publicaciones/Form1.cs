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

            if (txt_id_pagina.Text != "" && txt_token.Text != "")
            {


                if (cmb_a_publicar.Text == "texto")
                {
                    if (txt_mensaje.Text != "")
                    {
                        publicar_face(0, "", txt_mensaje.Text, txt_id_pagina.Text, txt_token.Text);
                    }
                    else
                    {
                        MessageBox.Show("pon algo en el texto a publicar");
                    }
                }
                else if (cmb_a_publicar.Text == "imajen")
                {
                    if (txt_mensaje.Text != "" && txt_url_de_imagen_o_video.Text != "")
                    {
                        publicar_face(1, "https://i.ibb.co/MM8BXcT/25.jpg", txt_mensaje.Text, txt_id_pagina.Text, txt_token.Text);

                    }
                    else
                    {
                        MessageBox.Show("pon algo en el texto y url a publicar");
                    }
                }
                else if (cmb_a_publicar.Text == "video")
                {
                    if (txt_mensaje.Text != "" && txt_url_de_imagen_o_video.Text != "")
                    {
                        publicar_face(2, "https://video.000webhostapp.com/1.mp4", txt_mensaje.Text, txt_id_pagina.Text, txt_token.Text);
                    }
                    else
                    {
                        MessageBox.Show("pon algo en el texto y url a publicar");
                    }
                }
                else
                {
                    MessageBox.Show("elige una opcion a enviar");
                }

            }
            else
            {
                MessageBox.Show("falta id_de_la_pagina o token");
            }
            
            
            
            
        }

        public async void publicar_face(int tipo, string url_sino_es_mensage, string mensage, string pageId, string accessToken)
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
                            content = new StringContent($"message={mensage}&published={published}", System.Text.Encoding.UTF8, "application/x-www-form-urlencoded");
                            break;
                        case 1:
                            //imagen
                            requestUri = $"https://graph.facebook.com/{pageId}/photos";
                            content = new StringContent($"url={url_sino_es_mensage}&message={mensage}&published={published}", System.Text.Encoding.UTF8, "application/x-www-form-urlencoded");
                            break; 
                        case 2:
                            //video
                            requestUri = $"https://graph.facebook.com/{pageId}/videos";
                            content = new StringContent($"file_url={url_sino_es_mensage}&message={mensage}&published={published}", System.Text.Encoding.UTF8, "application/x-www-form-urlencoded");
                            break;
                        default:
                            //texto otra vez
                            requestUri = $"https://graph.facebook.com/{pageId}/feed";
                            content = new StringContent($"message={mensage}&published={published}", System.Text.Encoding.UTF8, "application/x-www-form-urlencoded");
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

        private void cmb_a_publicar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_a_publicar.Text=="imajen")
            {
                label2.Visible = true;
                txt_url_de_imagen_o_video.Visible = true;
            }
            else if (cmb_a_publicar.Text== "video")
            {
                label2.Visible = true;
                txt_url_de_imagen_o_video.Visible = true;
            }
            else
            {
                label2.Visible = false;
                txt_url_de_imagen_o_video.Visible = false;
            }
        }
    }
}
