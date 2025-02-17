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
    internal class ControlGruposParticipantes
    {
        //Defino una variable privada de tipo HTTP de nombre client
        private HttpClient client;


        //Definimos el constructor
        public ControlGruposParticipantes()
        {
            //Creamos una instancia de nuestro cliente
            client = new HttpClient();
        }


        //Creamos nuestra petición,
        public async Task<List<GrupoParticipante>> GetAllGruposParticipantes()
        {
            try
            {
                
                List<GrupoParticipante> gruposParticipantes = new List<GrupoParticipante>();

                //Creamos un objeto de tipo HttpResponseMessage, en el que le pasamos la URL
                //que se quiere consultar
                HttpResponseMessage response = await client.GetAsync("http://localhost:8080/acex/gruposParticipantes");

                //Verifica que la respuesta tenga un estado de éxito
                //Si no es exitosa, lanza una excepción
                response.EnsureSuccessStatusCode();

                //String con las respuesta que es el JSON con toda la información
                //que habíamos visto previamente
                string responseJson = await response.Content.ReadAsStringAsync();


                //Enviamos esta respuesta a nuestra modelo, convierte (deserializa)
                //el JSON recibido en un objeto utilizando la
                //biblioteca Newtonsoft.Json
                gruposParticipantes = JsonConvert.DeserializeObject<List<GrupoParticipante>>(responseJson);

                return gruposParticipantes;

            }

            catch (Exception e)
            {

                ////Si ocurre algún error (como problemos de conexión o un JSON no válido),
                ////captura la excepción y devuelve "null" como valor de error
                //MessageBox.Show(e.Message);
                return null;

            }
        }

        public async Task<GrupoParticipante> GetGrupoParticipanteId(int id)

        {
            try
            {

                
                GrupoParticipante grupoParticipante = new GrupoParticipante();

                //Creamos un objeto de tipo HttpResponseMessage, en el que le pasamos la URL
                //que se quiere consultar
                HttpResponseMessage response = await client.GetAsync($"http://localhost:8080/acex/gruposParticipantes/{id}");

                //Verifica que la respuesta tenga un estado de éxito
                //Si no es exitosa, lanza una excepción
                response.EnsureSuccessStatusCode();

                //String con las respuesta que es el JSON con toda la información
                //que habíamos visto previamente
                string responseJson = await response.Content.ReadAsStringAsync();


                //Enviamos esta respuesta a nuestra modelo, convierte (deserializa)
                //el JSON recibido en un objeto utilizando la
                //biblioteca Newtonsoft.Json

                grupoParticipante = JsonConvert.DeserializeObject<GrupoParticipante>(responseJson);

                return grupoParticipante;

            }

            catch (Exception e)
            {

                //Si ocurre algún error (como problemos de conexión o un JSON no válido),
                //captura la excepción y devuelve "null" como valor de error
                MessageBox.Show(e.Message);
                return null;

            }
        }

        public async Task<bool> ActualizarGrupoParticipante(GrupoParticipante grupoParticipante)
        {
            try
            {
                // Convertir el objeto Realizada a JSON
                string json = JsonConvert.SerializeObject(grupoParticipante);

                // Crear el contenido de la solicitud (POST)
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                string id = grupoParticipante.id.ToString();
                // Realizar la solicitud POST a la API
                HttpResponseMessage response = await client.PutAsync($"http://localhost:8080/acex/gruposParticipantes/{id}", content);

                // Verificar si la respuesta fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    //MessageBox.Show("Grupo participante guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        public async Task<List<GrupoParticipante>> GetGruposActividad(Actividad actividad)

        {
            try
            {
                
                List<GrupoParticipante> grupos = new List<GrupoParticipante>();

                //Creamos un objeto de tipo HttpResponseMessage, en el que le pasamos la URL
                //que se quiere consultar
                HttpResponseMessage response = await client.GetAsync($"http://localhost:8080/acex/gruposParticipantes/actividad/{actividad.id}");

                //Verifica que la respuesta tenga un estado de éxito
                //Si no es exitosa, lanza una excepción
                response.EnsureSuccessStatusCode();

                //String con las respuesta que es el JSON con toda la información
                //que habíamos visto previamente
                string responseJson = await response.Content.ReadAsStringAsync();


                //Enviamos esta respuesta a nuestra modelo, convierte (deserializa)
                //el JSON recibido en un objeto utilizando la
                //biblioteca Newtonsoft.Json
                grupos = JsonConvert.DeserializeObject<List<GrupoParticipante>>(responseJson);

                return grupos;

            }

            catch (Exception e)
            {

                ////Si ocurre algún error (como problemos de conexión o un JSON no válido),
                ////captura la excepción y devuelve "null" como valor de error
                //MessageBox.Show(e.Message);
                return null;

            }
        }

        public async Task<bool> GuardarGrupoParticipante(GrupoParticipante grupoParticipante)
        {
            try
            {
                // Convertir el objeto Realizada a JSON
                string json = JsonConvert.SerializeObject(grupoParticipante);

                // Crear el contenido de la solicitud (POST)
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Realizar la solicitud POST a la API
                HttpResponseMessage response = await client.PostAsync($"http://localhost:8080/acex/gruposParticipantes", content);

                // Verificar si la respuesta fue exitosa
                if (response.IsSuccessStatusCode)
                {
                  //  MessageBox.Show("Grupo participante guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true; // La calificación fue guardada con éxito
                }
                else
                {
                   // MessageBox.Show(response.RequestMessage.ToString());
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

        public async Task<bool> QuitarGrupoParticipante(int id)

        {
            try
            {


                //Creamos un objeto de tipo HttpResponseMessage, en el que le pasamos la URL
                //que se quiere consultar
                HttpResponseMessage response = await client.DeleteAsync($"http://localhost:8080/acex/gruposParticipantes/{id}");

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
