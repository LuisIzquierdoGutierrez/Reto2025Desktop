﻿using Newtonsoft.Json;
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
    internal class ControlProfParticipantes
    {
        //Defino una variable privada de tipo HTTP de nombre client
        private HttpClient client;


        //Definimos el constructor
        public ControlProfParticipantes()
        {
            //Creamos una instancia de nuestro cliente
            client = new HttpClient();
        }


        //Creamos nuestra petición,
        public async Task<List<ProfParticipante>> GetAllProfParticipantes()

        {
            try
            {
                
                List<ProfParticipante> profParticipantes = new List<ProfParticipante>();

                //Creamos un objeto de tipo HttpResponseMessage, en el que le pasamos la URL
                //que se quiere consultar
                HttpResponseMessage response = await client.GetAsync("http://localhost:8080/acex/profesoresParticipantes");

                //Verifica que la respuesta tenga un estado de éxito
                //Si no es exitosa, lanza una excepción
                response.EnsureSuccessStatusCode();

                //String con las respuesta que es el JSON con toda la información
                //que habíamos visto previamente
                string responseJson = await response.Content.ReadAsStringAsync();


                //Enviamos esta respuesta a nuestra modelo, convierte (deserializa)
                //el JSON recibido en un objeto
                //biblioteca Newtonsoft.Json
                profParticipantes = JsonConvert.DeserializeObject<List<ProfParticipante>>(responseJson);

                return profParticipantes;

            }

            catch (Exception e)
            {

                //Si ocurre algún error (como problemos de conexión o un JSON no válido),
                //captura la excepción y devuelve "null" como valor de error
                MessageBox.Show(e.Message);
                return null;

            }
        }

        public async Task<ProfParticipante> GetProfParticipante(int id)

        {
            try
            {

                
                ProfParticipante profParticipante = new ProfParticipante();

                //Creamos un objeto de tipo HttpResponseMessage, en el que le pasamos la URL
                //que se quiere consultar
                HttpResponseMessage response = await client.GetAsync($"http://localhost:8080/acex/profesoresParticipantes/{id}");

                //Verifica que la respuesta tenga un estado de éxito
                //Si no es exitosa, lanza una excepción
                response.EnsureSuccessStatusCode();

                //String con las respuesta que es el JSON con toda la información
                //que habíamos visto previamente
                string responseJson = await response.Content.ReadAsStringAsync();


                //Enviamos esta respuesta a nuestra modelo, convierte (deserializa)
                //el JSON recibido en un objeto
                //biblioteca Newtonsoft.Json

                profParticipante = JsonConvert.DeserializeObject<ProfParticipante>(responseJson);

                return profParticipante;

            }

            catch (Exception e)
            {

                ////Si ocurre algún error (como problemos de conexión o un JSON no válido),
                ////captura la excepción y devuelve "null" como valor de error
                //MessageBox.Show(e.Message);
                return null;

            }
        }

        public async Task<bool> ActualizarProfParticipante(ProfParticipante profParticipante)
        {
            try
            {
                // Convertir el objeto Realizada a JSON
                string json = JsonConvert.SerializeObject(profParticipante);

                // Crear el contenido de la solicitud (POST)
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                string id = profParticipante.id.ToString();
                // Realizar la solicitud POST a la API
                HttpResponseMessage response = await client.PutAsync($"http://localhost:8080/acex/profesoresParticipantes/{id}", content);

                // Verificar si la respuesta fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Profesor participante guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        public async Task<List<ProfParticipante>> GetProfParticipanteActividad(Actividad actividad)

        {
            try
            {
                
                List<ProfParticipante> profesores = new List<ProfParticipante>();

                //Creamos un objeto de tipo HttpResponseMessage, en el que le pasamos la URL
                //que se quiere consultar
                HttpResponseMessage response = await client.GetAsync($"http://localhost:8080/acex/profesoresParticipantes/actividad/{actividad.id}");

                //Verifica que la respuesta tenga un estado de éxito
                //Si no es exitosa, lanza una excepción
                response.EnsureSuccessStatusCode();

                //String con las respuesta que es el JSON con toda la información
                //que habíamos visto previamente
                string responseJson = await response.Content.ReadAsStringAsync();


                //Enviamos esta respuesta a nuestra modelo, convierte (deserializa)
                //el JSON recibido en un objeto
                //biblioteca Newtonsoft.Json
                profesores = JsonConvert.DeserializeObject<List<ProfParticipante>>(responseJson);

                return profesores;

            }

            catch (Exception e)
            {

                ////Si ocurre algún error (como problemos de conexión o un JSON no válido),
                ////captura la excepción y devuelve "null" como valor de error
                //MessageBox.Show(e.Message);
                return null;

            }
        }

        public async Task<bool> GuardarProfParticipante(ProfParticipante profParticipante)
        {
            try
            {
                // Convertir el objeto Realizada a JSON
                string json = JsonConvert.SerializeObject(profParticipante);

                // Crear el contenido de la solicitud (POST)
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                // Realizar la solicitud POST a la API
                HttpResponseMessage response = await client.PostAsync("http://localhost:8080/acex/profesoresParticipantes", content);

                // Verificar si la respuesta fue exitosa
                if (response.IsSuccessStatusCode)
                {
                 //   MessageBox.Show("Profesor participante guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true; // La calificación fue guardada con éxito
                }
                else
                {
                  //  MessageBox.Show(response.RequestMessage.ToString());
                    return false; // Hubo un error
                }
            }
            catch (Exception e)
            {
                // Captura cualquier excepción y muestra un mensaje de error
               // MessageBox.Show($"Error: {e.Message}");
                return false;
            }
        }

        public async Task<bool> QuitarProfParticipante(int id)

        {
            try
            {

       
                //Creamos un objeto de tipo HttpResponseMessage, en el que le pasamos la URL
                //que se quiere consultar
                HttpResponseMessage response = await client.DeleteAsync($"http://localhost:8080/acex/profesoresParticipantes/{id}");

                //Verifica que la respuesta tenga un estado de éxito
                //Si no es exitosa, lanza una excepción
                response.EnsureSuccessStatusCode();

                //String con las respuesta que es el JSON con toda la información
                //que habíamos visto previamente
                string responseJson = await response.Content.ReadAsStringAsync();



                //Devuelve el objeto con los datos obtenidos de la API
                return true;

            }

            catch (Exception e)
            {

                ////Si ocurre algún error (como problemos de conexión o un JSON no válido),
                ////captura la excepción y devuelve "null" como valor de error
                //MessageBox.Show(e.Message);
                return false;

            }
        }
    }
}
