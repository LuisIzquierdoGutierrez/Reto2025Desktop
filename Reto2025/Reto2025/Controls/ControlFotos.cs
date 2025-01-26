using Newtonsoft.Json;
using Reto2025.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Reto2025.Controls
{
    internal class ControlFotos
    {

        //Defino una variable privada de tipo HTTP de nombre client
        private HttpClient client;


        //Definimos el constructor
        public ControlFotos()
        {
            //Creamos una instancia de nuestro cliente
            client = new HttpClient();
        }


        //Creamos nuestra petición,
        public async Task<List<Foto>> GetAllFotos()

        {
            try
            {
                //Hacemos una instancia de Personajes
                List<Foto> fotos = new List<Foto>();

                //Creamos un objeto de tipo HttpResponseMessage, en el que le pasamos la URL
                //que se quiere consultar
                HttpResponseMessage response = await client.GetAsync("http://localhost:8080/acex/fotos");

                //Verifica que la respuesta tenga un estado de éxito
                //Si no es exitosa, lanza una excepción
                response.EnsureSuccessStatusCode();

                //String con las respuesta que es el JSON con toda la información
                //que habíamos visto previamente
                string responseJson = await response.Content.ReadAsStringAsync();


                //Enviamos esta respuesta a nuestra modelo, convierte (deserializa)
                //el JSON recibido en un objeto de tipo "Personajes" utilizando la
                //biblioteca Newtonsoft.Json
                fotos = JsonConvert.DeserializeObject<List<Foto>>(responseJson);

                //Devuelve el objeto "personajes" con los datos obtenidos de la API
                return fotos;

            }

            catch (Exception e)
            {

                //Si ocurre algún error (como problemos de conexión o un JSON no válido),
                //captura la excepción y devuelve "null" como valor de error
                MessageBox.Show(e.Message);
                return null;

            }
        }
        public async Task<List<Foto>> GetAllFotosActividad(Actividad actividad)

        {
            try
            {
                //Hacemos una instancia de Personajes
                List<Foto> fotos = new List<Foto>();

                //Creamos un objeto de tipo HttpResponseMessage, en el que le pasamos la URL
                //que se quiere consultar
                HttpResponseMessage response = await client.GetAsync($"http://localhost:8080/acex/fotos/actividad/{actividad.id}");

                //Verifica que la respuesta tenga un estado de éxito
                //Si no es exitosa, lanza una excepción
                response.EnsureSuccessStatusCode();

                //String con las respuesta que es el JSON con toda la información
                //que habíamos visto previamente
                string responseJson = await response.Content.ReadAsStringAsync();


                //Enviamos esta respuesta a nuestra modelo, convierte (deserializa)
                //el JSON recibido en un objeto de tipo "Personajes" utilizando la
                //biblioteca Newtonsoft.Json
                fotos = JsonConvert.DeserializeObject<List<Foto>>(responseJson);

                //Devuelve el objeto "personajes" con los datos obtenidos de la API
                return fotos;

            }

            catch (Exception e)
            {

                //Si ocurre algún error (como problemos de conexión o un JSON no válido),
                //captura la excepción y devuelve "null" como valor de error
                MessageBox.Show(e.Message);
                return null;

            }
        }

        public async Task<Foto> GetFotoId(int id)

        {
            try
            {

                //Hacemos una instancia de Personajes
                Foto foto = new Foto();

                //Creamos un objeto de tipo HttpResponseMessage, en el que le pasamos la URL
                //que se quiere consultar
                HttpResponseMessage response = await client.GetAsync($"http://localhost:8080/acex/cursos/{id}");

                //Verifica que la respuesta tenga un estado de éxito
                //Si no es exitosa, lanza una excepción
                response.EnsureSuccessStatusCode();

                //String con las respuesta que es el JSON con toda la información
                //que habíamos visto previamente
                string responseJson = await response.Content.ReadAsStringAsync();


                //Enviamos esta respuesta a nuestra modelo, convierte (deserializa)
                //el JSON recibido en un objeto de tipo "Personajes" utilizando la
                //biblioteca Newtonsoft.Json

                foto = JsonConvert.DeserializeObject<Foto>(responseJson);

                //Devuelve el objeto "personajes" con los datos obtenidos de la API
                return foto;

            }

            catch (Exception e)
            {

                //Si ocurre algún error (como problemos de conexión o un JSON no válido),
                //captura la excepción y devuelve "null" como valor de error
                MessageBox.Show(e.Message);
                return null;

            }
        }


        public async Task<bool> ActualizarFoto(Foto foto)
        {
            try
            {
                // Convertir el objeto Realizada a JSON
                string json = JsonConvert.SerializeObject(foto);

                // Crear el contenido de la solicitud (POST)
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                string id = foto.id.ToString();
                // Realizar la solicitud POST a la API
                HttpResponseMessage response = await client.PutAsync($"http://localhost:8080/acex/fotos/{id}", content);

                // Verificar si la respuesta fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Foto guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true; // La calificación fue guardada con éxito
                }
                else
                {
                    MessageBox.Show(response.RequestMessage.ToString());
                    return false; // Hubo un error
                }
            }
            catch (Exception e)
            {
                // Captura cualquier excepción y muestra un mensaje de error
                MessageBox.Show($"Error: {e.Message}");
                return false;
            }
        }


        public async Task<bool> SubirFoto(Actividad actividad, string f)
        {
            // Convert image to Base64
            string image = Convert.ToString(System.IO.File.ReadAllBytes(f));
            int a = image.Length;
            MessageBox.Show(a.ToString());
            // Prepare the JSON payload
            string jsonPayload = $"{{\"fichero\": \"{image}\"}}";
            try
            {

               
                var formData = new MultipartFormDataContent();

                var fileContent = new ByteArrayContent(System.IO.File.ReadAllBytes(f));



                formData.Add(fileContent, "fichero", "patata.png"); 

  
                string descripcion = actividad.descripcion; 

                // Realizar la solicitud POST a la API
                HttpResponseMessage response = await client.PostAsync($"http://localhost:8080/acex/fotos/{actividad.id}/foto?descripcion={descripcion}", formData);

                // Verificar si la respuesta fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Foto guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // La calificación fue guardada con éxito
                }
                else
                {
                    MessageBox.Show(response.RequestMessage.ToString());
                    // Hubo un error
                }
            }
            catch (Exception e)
            {
                // Captura cualquier excepción y muestra un mensaje de error
                MessageBox.Show($"Error: {e.Message}");

            }
            return true;
        }

        public String GetFotoUrl(Foto foto)

        {
            return $"http://localhost:8080/acex/fotos/{foto.actividad.id}/foto?id={foto.id}";
        }
        public String GetFotoUrl(Profesor profesor)

        {
            return $"http://localhost:8080/acex/profesores/{profesor.correo}/foto";
        }

    }
}

