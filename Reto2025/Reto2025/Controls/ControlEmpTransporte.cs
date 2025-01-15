using Newtonsoft.Json;
using Reto2025.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reto2025.Controls
{
    internal class ControlEmpTransporte
    {
        //Defino una variable privada de tipo HTTP de nombre client
        private HttpClient client;


        //Definimos el constructor
        public ControlEmpTransporte()
        {
            //Creamos una instancia de nuestro cliente
            client = new HttpClient();
        }


        //Creamos nuestra petición,
        public async Task<List<EmpTransporte>> GetAllEmpTransporte()

        {
            try
            {
                //Hacemos una instancia de Personajes
                List<EmpTransporte> empTransporte = new List<EmpTransporte>();

                //Creamos un objeto de tipo HttpResponseMessage, en el que le pasamos la URL
                //que se quiere consultar
                HttpResponseMessage response = await client.GetAsync("http://localhost:8080/acex/transportes");

                //Verifica que la respuesta tenga un estado de éxito
                //Si no es exitosa, lanza una excepción
                response.EnsureSuccessStatusCode();

                //String con las respuesta que es el JSON con toda la información
                //que habíamos visto previamente
                string responseJson = await response.Content.ReadAsStringAsync();


                //Enviamos esta respuesta a nuestra modelo, convierte (deserializa)
                //el JSON recibido en un objeto de tipo "Personajes" utilizando la
                //biblioteca Newtonsoft.Json
                empTransporte = JsonConvert.DeserializeObject<List<EmpTransporte>>(responseJson);

                //Devuelve el objeto "personajes" con los datos obtenidos de la API
                return empTransporte;

            }

            catch (Exception e)
            {

                //Si ocurre algún error (como problemos de conexión o un JSON no válido),
                //captura la excepción y devuelve "null" como valor de error
                MessageBox.Show(e.Message);
                return null;

            }
        }

        public async Task<EmpTransporte> GetEmpTransporteId(int id)

        {
            try
            {

                //Hacemos una instancia de Personajes
                EmpTransporte empTransporte = new EmpTransporte();

                //Creamos un objeto de tipo HttpResponseMessage, en el que le pasamos la URL
                //que se quiere consultar
                HttpResponseMessage response = await client.GetAsync($"http://localhost:8080/acex/transportes/{id}");

                //Verifica que la respuesta tenga un estado de éxito
                //Si no es exitosa, lanza una excepción
                response.EnsureSuccessStatusCode();

                //String con las respuesta que es el JSON con toda la información
                //que habíamos visto previamente
                string responseJson = await response.Content.ReadAsStringAsync();


                //Enviamos esta respuesta a nuestra modelo, convierte (deserializa)
                //el JSON recibido en un objeto de tipo "Personajes" utilizando la
                //biblioteca Newtonsoft.Json

                empTransporte = JsonConvert.DeserializeObject<EmpTransporte>(responseJson);

                //Devuelve el objeto "personajes" con los datos obtenidos de la API
                return empTransporte;

            }

            catch (Exception e)
            {

                //Si ocurre algún error (como problemos de conexión o un JSON no válido),
                //captura la excepción y devuelve "null" como valor de error
                MessageBox.Show(e.Message);
                return null;

            }
        }

        public async Task<bool> GuardarEmpTransporte(EmpTransporte empTransporte)
        {
            try
            {
                // Convertir el objeto Realizada a JSON
                string json = JsonConvert.SerializeObject(empTransporte);

                // Crear el contenido de la solicitud (POST)
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                string id = empTransporte.id.ToString();
                // Realizar la solicitud POST a la API
                HttpResponseMessage response = await client.PutAsync($"http://localhost:8080/acex/transportes/{id}", content);

                // Verificar si la respuesta fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Empresa de transporte guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

    }
}
