# Equipo2B
# Documentación 

## Realizado por el Equipo 
- Izan
- David
- Cristian
- Leila
- Luis



## Tabla de contenidos

1. [Introducción](#introducción)
2. [API](#api)
3. [Estructura ](#Estructura)
4. [Modelos (Entities)](#Modelos)
5. [Controladores (EndPoints)](#Controladores)
6. [Enumerados)](#enumerados)
7. [Conclusión](#conclusión)

## Introducción
Esta aplicación permite gestionar cursos, actividades y usuarios mediante la comunicación con una API externa. Está desarrollada en .NET y sigue una estructura modular para facilitar su mantenimiento y ampliación.

## API
[https://github.com/PauDiSan/ProyectoIntermodularEquipoA2/tree/main](https://github.com/PauDiSan/ProyectoIntermodularEquipoA2/tree/main)

## Estructura
El proyecto está organizado en varias carpetas, siguiendo una arquitectura modular. A continuación, se describen las principales carpetas y sus propósitos:
- La carpeta *"Controls"* contiene las clases de los controladores, responsables de la comunicación entre la aplicación y la API externa. Estas clases envían datos en formato JSON, reciben respuestas, deserializan los datos y manejan posibles errores o excepciones.

- La carpeta *"Enum"* contiene los enumerados de la base de datos, estos enumerados sirven para los objetos que lo requieran, es un tipo de dato que necesita una clase propia (como por ejemplo etapa, rol, estado...).

- La carpeta *"Models"* contiene todas las clases del proyecto, que son el núcleo para definir las estructuras de datos utilizadas en las operaciones con la API, además de representar los objetos de dominio.

- La carpeta *"Resources"* sirve almacenar para cualquier recurso externo o estático que sea necesario para la correcta operación de la aplicación (como por ejemplo imágenes o archivos de configuración). 

- La carpeta *"Views"* contiene las ventanas y formularios que conforman la interfaz gráfica de usuario (UI). Estas vistas permiten la interacción del usuario con el sistema y están vinculadas a los controladores para gestionar la lógica de negocio. 

- Por último, la carpeta  *"FAQ"* contiene formularios específicos para gestionar preguntas frecuentes (FAQs). Estos formularios permiten acceder a información de ayuda o resolver dudas de los usuarios.

> Se adjunta una imagen para ver la estructura del proyecto:

![alt text](image-1.png)
## Modelos
Las clases que se encuentran en la clase modelos son:

**Clase Actividad**

Esta clase representa una actividad en un sistema. Esta clase contiene varias propiedades que permiten almacenar detalles sobre la actividad, como su título, fechas, horarios, requisitos de transporte y alojamiento, estado, y más. Además, incluye un método para comparar dos instancias de la clase, basándose en su identificador.

**Clase Contrato**

Esta clase sirve para representar un contrato relacionado con la contratación de una actividad, específicamente para gestionar detalles sobre el transporte y los costos asociados a la actividad. La clase contiene información sobre el estado del contrato, el proveedor de transporte, el importe total y los enlaces a los documentos relacionados, como el presupuesto y la factura.

**Clase Curso**

Esta clase representa un curso educativo o académico en un sistema de gestión. Contiene información relacionada con el curso, como su identificación, código, título, nivel y estado de actividad. La clase está diseñada para organizar y gestionar cursos dentro de un sistema.

**Clase Departamento**

Esta clase sirve para representar un departamento dentro de una organización o institución. Contiene información sobre la identificación y los detalles básicos del departamento, como su código y nombre.

**Clase Empresa de Transporte**

Esta clase sirve para representar una empresa de transporte en un sistema, almacenando información relevante sobre la empresa, como su identificación, nombre, detalles de contacto, dirección y código postal. 

**Clase Foto**

Esta clase representa una foto o imagen asociada a una actividad. Permite almacenar información sobre la imagen, su URL, una descripción y la actividad a la que está vinculada. 

**Clase Grupo** 

Esta clase representa un grupo de estudiantes dentro de un curso. Contiene información sobre el grupo, como el curso al que pertenece, su código, la cantidad de alumnos, el estado de actividad del grupo y el tutor encargado

**Clase Grupo Participante**

Esta clase representa la relación entre un grupo de estudiantes y una actividad en la que participan. Almacena información sobre la actividad, el grupo, el número de participantes y cualquier comentario adicional relacionado con la participación del grupo en esa actividad

**Clase Profesor**

Esta clase representa a un profesor dentro de un sistema de gestión académica. Contiene información detallada sobre el profesor, como su identificación, datos personales, correo electrónico, rol dentro de la institución, etc...

**Clase Profesor Participante**

Esta clase representa la relación entre un profesor y una actividad en la que participa. Esta clase almacena información sobre el profesor que participa en una actividad específica, permitiendo gestionar la relación entre los docentes y las actividades en las que están involucrados.

**Clase Profesor Responsable**

Esta clase representa la relación entre un profesor y una actividad de la que es responsable. Esta clase almacena la información acerca del profesor encargado de una actividad específica, permitiendo gestionar y hacer seguimiento de las actividades que tienen un responsable docente asignado.

>Se adjunta una imagen para ver la organización de la carpeta:

![alt text](image.png)

### Controladores

**Control Actividades**
| **Elemento**                 | **Descripción**                                                                                                   |
|------------------------------|-------------------------------------------------------------------------------------------------------------------|
| **Clase `ControlActividades`** | Clase encargada de gestionar las operaciones relacionadas con actividades utilizando una API REST.                           |
| **Variable `HttpClient`**     | Cliente HTTP reutilizable para realizar solicitudes a la API.                                                   |
| **Constructor**               | - **Propósito**: Inicializa el cliente HTTP para permitir interacciones con la API.                             |
|                               | - **Acción**: Crea una nueva instancia de `HttpClient`.                                                         |
| **GetAllActividades**         | - **Propósito**: Obtiene todas las actividades desde la API (ruta: `/actividades`).                             |
|                               | - **Solicitud**: `GET`.                                                                                        |
|                               | - **Retorno**: Devuelve una lista de objetos `Actividad` deserializados del JSON de respuesta.                   |
|                               | - **Errores**: Muestra un mensaje de error y devuelve `null` si ocurre un fallo.                                |
| **GetActividadId**            | - **Propósito**: Recupera una actividad específica por ID (ruta: `/actividades/{id}`).                         |
|                               | - **Solicitud**: `GET`.                                                                                        |
|                               | - **Retorno**: Devuelve un objeto `Actividad` con los datos del ID solicitado.                                  |
|                               | - **Errores**: Muestra un mensaje de error y devuelve `null` si ocurre un fallo.                                |
| **ActualizarActividad**       | - **Propósito**: Actualiza una actividad existente en la API (ruta: `/actividades/{id}`).                      |
|                               | - **Solicitud**: `PUT`.                                                                                        |
|                               | - **Entrada**: Un objeto `Actividad` que se convierte a JSON antes de enviarlo.                                |
|                               | - **Retorno**: Devuelve `true` si la actualización es exitosa; `false` si falla.                               |
|                               | - **Errores**: Muestra un mensaje de error si la solicitud no es exitosa.                                       |
| **GuardarActividad**          | - **Propósito**: Crea una nueva actividad en la API (ruta: `/actividades`).                                    |
|                               | - **Solicitud**: `POST`.                                                                                       |
|                               | - **Entrada**: Un objeto `Actividad` que se convierte a JSON antes de enviarlo.                                |
|                               | - **Retorno**: Devuelve `true` si la actividad se guarda correctamente; `false` si falla.                      |
| **Dependencias externas**     | - **Newtonsoft.Json**: Serializa objetos a JSON y deserializa JSON a objetos.                                   |
|                               | - **HttpClient**: Realiza las solicitudes HTTP a la API.                                                        |
| **Manejo de errores**         | - **Descripción**: Cada método incluye un bloque `try-catch` para capturar excepciones.                         |
|                               | - **Acciones**: Muestra mensajes de error con `MessageBox.Show` y devuelve valores indicativos (`null` o `false`). |


**Control Contratos**
| **Elemento**                 | **Descripción**                                                                                                   |
|------------------------------|-------------------------------------------------------------------------------------------------------------------|
| **Clase `ControlContratos`**  | Clase encargada de gestionar las operaciones relacionadas con contratos utilizando una API REST.                           |
| **Variable `HttpClient`**     | Cliente HTTP reutilizable para realizar solicitudes a la API.                                                   |
| **Constructor**               | - **Propósito**: Inicializa el cliente HTTP para permitir interacciones con la API.                             |
|                               | - **Acción**: Crea una nueva instancia de `HttpClient`.                                                         |
| **GetAllContratos**           | - **Propósito**: Obtiene todos los contratos desde la API (ruta: `/contratos`).                             |
|                               | - **Solicitud**: `GET`.                                                                                        |
|                               | - **Retorno**: Devuelve una lista de objetos `Contrato` deserializados del JSON de respuesta.                   |
|                               | - **Errores**: Muestra un mensaje de error y devuelve `null` si ocurre un fallo.                                |
| **GetContratoId**             | - **Propósito**: Recupera un contrato específico por ID (ruta: `/contratos/{id}`).                         |
|                               | - **Solicitud**: `GET`.                                                                                        |
|                               | - **Retorno**: Devuelve un objeto `Contrato` con los datos del ID solicitado.                                  |
|                               | - **Errores**: Muestra un mensaje de error y devuelve `null` si ocurre un fallo.                                |
| **ActualizarContrato**        | - **Propósito**: Actualiza un contrato existente en la API (ruta: `/contratos/{id}`).                      |
|                               | - **Solicitud**: `PUT`.                                                                                        |
|                               | - **Entrada**: Un objeto `Contrato` que se convierte a JSON antes de enviarlo.                                |
|                               | - **Retorno**: Devuelve `true` si la actualización es exitosa; `false` si falla.                               |
|                               | - **Errores**: Muestra un mensaje de error si la solicitud no es exitosa.                                       |
| **GuardarContrato**           | - **Propósito**: Crea un nuevo contrato en la API (ruta: `/contratos`).                                    |
|                               | - **Solicitud**: `POST`.                                                                                       |
|                               | - **Entrada**: Un objeto `Contrato` que se convierte a JSON antes de enviarlo.                                |
|                               | - **Retorno**: Devuelve `true` si el contrato se guarda correctamente; `false` si falla.                      |
| **Dependencias externas**     | - **Newtonsoft.Json**: Serializa objetos a JSON y deserializa JSON a objetos.                                   |
|                               | - **HttpClient**: Realiza las solicitudes HTTP a la API.                                                        |
| **Manejo de errores**         | - **Descripción**: Cada método incluye un bloque `try-catch` para capturar excepciones.                         |
|                               | - **Acciones**: Muestra mensajes de error con `MessageBox.Show` y devuelve valores indicativos (`null` o `false`). |
        |

**Control Cursos**
| **Elemento**                 | **Descripción**                                                                                                   |
|------------------------------|-------------------------------------------------------------------------------------------------------------------|
| **Clase `ControlCursos`**     | Clase encargada de gestionar las operaciones relacionadas con cursos utilizando una API REST.                          |
| **Variable `HttpClient`**     | Cliente HTTP reutilizable para realizar solicitudes a la API.                                                   |
| **Constructor**               | - **Propósito**: Inicializa el cliente HTTP para permitir interacciones con la API.                             |
|                               | - **Acción**: Crea una nueva instancia de `HttpClient`.                                                         |
| **GetAllCursos**              | - **Propósito**: Obtiene todos los cursos desde la API (ruta: `/cursos`).                                      |
|                               | - **Solicitud**: `GET`.                                                                                        |
|                               | - **Retorno**: Devuelve una lista de objetos `Curso` deserializados del JSON de respuesta.                      |
|                               | - **Errores**: Muestra un mensaje de error y devuelve `null` si ocurre un fallo.                                 |
| **GetCursoId**                | - **Propósito**: Recupera un curso específico por ID (ruta: `/cursos/{id}`).                                    |
|                               | - **Solicitud**: `GET`.                                                                                        |
|                               | - **Retorno**: Devuelve un objeto `Curso` con los datos del ID solicitado.                                       |
|                               | - **Errores**: Muestra un mensaje de error y devuelve `null` si ocurre un fallo.                                 |
| **ActualizarCurso**           | - **Propósito**: Actualiza un curso existente en la API (ruta: `/cursos/{id}`).                                 |
|                               | - **Solicitud**: `PUT`.                                                                                        |
|                               | - **Entrada**: Un objeto `Curso` que se convierte a JSON antes de enviarlo.                                    |
|                               | - **Retorno**: Devuelve `true` si la actualización es exitosa; `false` si falla.                                |
|                               | - **Errores**: Muestra un mensaje de error si la solicitud no es exitosa.                                        |
| **Dependencias externas**     | - **Newtonsoft.Json**: Serializa objetos a JSON y deserializa JSON a objetos.                                    |
|                               | - **HttpClient**: Realiza las solicitudes HTTP a la API.                                                        |
| **Manejo de errores**         | - **Descripción**: Cada método incluye un bloque `try-catch` para capturar excepciones.                         |
|                               | - **Acciones**: Muestra mensajes de error con `MessageBox.Show` y devuelve valores indicativos (`null` o `false`). |

**Control Departamentos**
| **Elemento**                  | **Descripción**                                                                                                   |
|-------------------------------|-------------------------------------------------------------------------------------------------------------------|
| **Clase `ControlDepartamentos`** | Clase encargada de gestionar las operaciones relacionadas con departamentos utilizando una API REST.                          |
| **Variable `HttpClient`**      | Cliente HTTP reutilizable para realizar solicitudes a la API.                                                   |
| **Constructor**                | - **Propósito**: Inicializa el cliente HTTP para permitir interacciones con la API.                             |
|                                | - **Acción**: Crea una nueva instancia de `HttpClient`.                                                         |
| **GetAllDepartamentos**        | - **Propósito**: Obtiene todos los departamentos desde la API (ruta: `/departamentos`).                         |
|                                | - **Solicitud**: `GET`.                                                                                        |
|                                | - **Retorno**: Devuelve una lista de objetos `Departamento` deserializados del JSON de respuesta.               |
|                                | - **Errores**: Muestra un mensaje de error y devuelve `null` si ocurre un fallo.                                |
| **GetDepartamentoId**          | - **Propósito**: Recupera un departamento específico por ID (ruta: `/departamentos/{id}`).                      |
|                                | - **Solicitud**: `GET`.                                                                                        |
|                                | - **Retorno**: Devuelve un objeto `Departamento` con los datos del ID solicitado.                               |
|                                | - **Errores**: Muestra un mensaje de error y devuelve `null` si ocurre un fallo.                                |
| **ActualizarDepartamento**     | - **Propósito**: Actualiza un departamento existente en la API (ruta: `/departamentos/{id}`).                   |
|                                | - **Solicitud**: `PUT`.                                                                                        |
|                                | - **Entrada**: Un objeto `Departamento` que se convierte a JSON antes de enviarlo.                             |
|                                | - **Retorno**: Devuelve `true` si la actualización es exitosa; `false` si falla.                               |
|                                | - **Errores**: Muestra un mensaje de error si la solicitud no es exitosa.                                       |
| **Dependencias externas**      | - **Newtonsoft.Json**: Serializa objetos a JSON y deserializa JSON a objetos.                                   |
|                                | - **HttpClient**: Realiza las solicitudes HTTP a la API.                                                        |
| **Manejo de errores**          | - **Descripción**: Cada método incluye un bloque `try-catch` para capturar excepciones.                         |
|                                | - **Acciones**: Muestra mensajes de error con `MessageBox.Show` y devuelve valores indicativos (`null` o `false`). |

**Control Empresa de Transporte**
| **Elemento**                     | **Descripción**                                                                                                   |
|----------------------------------|-------------------------------------------------------------------------------------------------------------------|
| **Clase `ControlEmpTransporte`** | Clase encargada de gestionar las operaciones relacionadas con empresas de transporte utilizando una API REST.    |
| **Variable `HttpClient`**         | Cliente HTTP reutilizable para realizar solicitudes a la API.                                                   |
| **Constructor**                   | - **Propósito**: Inicializa el cliente HTTP para permitir interacciones con la API.                             |
|                                   | - **Acción**: Crea una nueva instancia de `HttpClient`.                                                         |
| **GetAllEmpTransporte**           | - **Propósito**: Obtiene todas las empresas de transporte desde la API (ruta: `/transportes`).                   |
|                                   | - **Solicitud**: `GET`.                                                                                        |
|                                   | - **Retorno**: Devuelve una lista de objetos `EmpTransporte` deserializados del JSON de respuesta.              |
|                                   | - **Errores**: Muestra un mensaje de error y devuelve `null` si ocurre un fallo.                                 |
| **GetEmpTransporteId**            | - **Propósito**: Recupera una empresa de transporte específica por ID (ruta: `/transportes/{id}`).               |
|                                   | - **Solicitud**: `GET`.                                                                                        |
|                                   | - **Retorno**: Devuelve un objeto `EmpTransporte` con los datos del ID solicitado.                               |
|                                   | - **Errores**: Muestra un mensaje de error y devuelve `null` si ocurre un fallo.                                 |
| **ActualizarEmpTransporte**       | - **Propósito**: Actualiza una empresa de transporte existente en la API (ruta: `/transportes/{id}`).            |
|                                   | - **Solicitud**: `PUT`.                                                                                        |
|                                   | - **Entrada**: Un objeto `EmpTransporte` que se convierte a JSON antes de enviarlo.                             |
|                                   | - **Retorno**: Devuelve `true` si la actualización es exitosa; `false` si falla.                                |
|                                   | - **Errores**: Muestra un mensaje de error si la solicitud no es exitosa.                                        |
| **GuardarEmpresa**                | - **Propósito**: Guarda una nueva empresa de transporte en la API (ruta: `/transportes`).                        |
|                                   | - **Solicitud**: `POST`.                                                                                         |
|                                   | - **Entrada**: Un objeto `EmpTransporte` que se convierte a JSON antes de enviarlo.                             |
|                                   | - **Retorno**: Devuelve `true` si el objeto es guardado correctamente; `false` si ocurre un error.               |
| **Dependencias externas**         | - **Newtonsoft.Json**: Serializa objetos a JSON y deserializa JSON a objetos.                                    |
|                                   | - **HttpClient**: Realiza las solicitudes HTTP a la API.                                                        |
| **Manejo de errores**             | - **Descripción**: Cada método incluye un bloque `try-catch` para capturar excepciones.                         |
|                                   | - **Acciones**: Muestra mensajes de error con `MessageBox.Show` y devuelve valores indicativos (`null` o `false`). |

**Control Fotos**
| **Elemento**                     | **Descripción**                                                                                                   |
|----------------------------------|-------------------------------------------------------------------------------------------------------------------|
| **Clase `ControlFotos`**         | Clase encargada de gestionar las operaciones relacionadas con fotos en actividades utilizando una API REST.     |
| **Variable `HttpClient`**        | Cliente HTTP reutilizable para realizar solicitudes a la API.                                                   |
| **Constructor**                  | - **Propósito**: Inicializa el cliente HTTP para permitir interacciones con la API.                             |
|                                  | - **Acción**: Crea una nueva instancia de `HttpClient`.                                                         |
| **GetAllFotos**                  | - **Propósito**: Obtiene todas las fotos desde la API (ruta: `/fotos`).                                         |
|                                  | - **Solicitud**: `GET`.                                                                                        |
|                                  | - **Retorno**: Devuelve una lista de objetos `Foto` deserializados del JSON de respuesta.                        |
|                                  | - **Errores**: Muestra un mensaje de error y devuelve `null` si ocurre un fallo.                                 |
| **GetAllFotosActividad**         | - **Propósito**: Recupera todas las fotos de una actividad específica (ruta: `/fotos/actividad/{id}`).          |
|                                  | - **Solicitud**: `GET`.                                                                                        |
|                                  | - **Retorno**: Devuelve una lista de objetos `Foto` asociados a la actividad.                                     |
|                                  | - **Errores**: Muestra un mensaje de error y devuelve `null` si ocurre un fallo.                                 |
| **GetFotoId**                    | - **Propósito**: Recupera una foto específica por ID (ruta: `/fotos/{id}`).                                      |
|                                  | - **Solicitud**: `GET`.                                                                                        |
|                                  | - **Retorno**: Devuelve un objeto `Foto` con los datos de la foto solicitada.                                    |
|                                  | - **Errores**: Muestra un mensaje de error y devuelve `null` si ocurre un fallo.                                 |
| **ActualizarFoto**               | - **Propósito**: Actualiza una foto existente en la API (ruta: `/fotos/{id}`).                                   |
|                                  | - **Solicitud**: `PUT`.                                                                                        |
|                                  | - **Entrada**: Un objeto `Foto` que se convierte a JSON antes de enviarlo.                                       |
|                                  | - **Retorno**: Devuelve `true` si la actualización es exitosa; `false` si falla.                                |
|                                  | - **Errores**: Muestra un mensaje de error si la solicitud no es exitosa.                                        |
| **SubirFoto**                    | - **Propósito**: Subir una nueva foto relacionada con una actividad a la API (ruta: `/fotos/{actividad.id}/foto`).|
|                                  | - **Solicitud**: `POST`.                                                                                         |
|                                  | - **Entrada**: Convierte la imagen a base64 y la envía como parte de la solicitud POST en un formulario.         |
|                                  | - **Retorno**: La foto se sube y se muestra un mensaje si la carga es exitosa.                                    |
|                                  | - **Errores**: Muestra un mensaje de error si ocurre algún fallo al subir la foto.                               |
| **GetFotoUrl**                   | - **Propósito**: Genera la URL de una foto específica.                                                           |
|                                  | - **Entrada**: Un objeto `Foto`.                                                                                |
|                                  | - **Retorno**: Devuelve la URL para acceder a la foto (`/fotos/{actividad.id}/foto?id={foto.id}`).              |
| **Dependencias externas**        | - **Newtonsoft.Json**: Serializa objetos a JSON y deserializa JSON a objetos.                                    |
|                                  | - **HttpClient**: Realiza las solicitudes HTTP a la API.                                                        |
| **Manejo de errores**            | - **Descripción**: Cada método incluye un bloque `try-catch` para capturar excepciones.                         |
|                                  | - **Acciones**: Muestra mensajes de error con `MessageBox.Show` y devuelve valores indicativos (`null` o `false`). |

**Control Grupos**
| **Elemento**                     | **Descripción**                                                                                                   |
|----------------------------------|-------------------------------------------------------------------------------------------------------------------|
| **Clase `ControlGrupos`**        | Clase encargada de gestionar las operaciones relacionadas con grupos en una API REST.                           |
| **Variable `HttpClient`**        | Cliente HTTP reutilizable para realizar solicitudes a la API.                                                   |
| **Constructor**                  | - **Propósito**: Inicializa el cliente HTTP para permitir interacciones con la API.                             |
|                                  | - **Acción**: Crea una nueva instancia de `HttpClient`.                                                         |
| **GetAllGrupos**                 | - **Propósito**: Obtiene todos los grupos desde la API (ruta: `/grupos`).                                        |
|                                  | - **Solicitud**: `GET`.                                                                                        |
|                                  | - **Retorno**: Devuelve una lista de objetos `Grupo` deserializados del JSON de respuesta.                       |
|                                  | - **Errores**: Muestra un mensaje de error y devuelve `null` si ocurre un fallo.                                 |
| **GetGrupoId**                   | - **Propósito**: Recupera un grupo específico por ID (ruta: `/grupos/{id}`).                                      |
|                                  | - **Solicitud**: `GET`.                                                                                        |
|                                  | - **Retorno**: Devuelve un objeto `Grupo` con los datos del grupo solicitado.                                    |
|                                  | - **Errores**: Muestra un mensaje de error y devuelve `null` si ocurre un fallo.                                 |
| **ActualizarGrupo**              | - **Propósito**: Actualiza un grupo existente en la API (ruta: `/grupos/{id}`).                                  |
|                                  | - **Solicitud**: `PUT`.                                                                                        |
|                                  | - **Entrada**: Un objeto `Grupo` que se convierte a JSON antes de enviarlo.                                       |
|                                  | - **Retorno**: Devuelve `true` si la actualización es exitosa; `false` si falla.                                |
|                                  | - **Errores**: Muestra un mensaje de error si la solicitud no es exitosa.                                        |
| **Manejo de errores**            | - **Descripción**: Cada método incluye un bloque `try-catch` para capturar excepciones.                         |
|                                  | - **Acciones**: Muestra mensajes de error con `MessageBox.Show` y devuelve valores indicativos (`null` o `false`). |

**Control Grupos Participantes**
| **Elemento**                         | **Descripción**                                                                                                        |
|--------------------------------------|------------------------------------------------------------------------------------------------------------------------|
| **Clase `ControlGruposParticipantes`**| Clase encargada de gestionar las operaciones relacionadas con los grupos participantes en una API REST.              |
| **Variable `HttpClient`**            | Cliente HTTP reutilizable para realizar solicitudes a la API.                                                          |
| **Constructor**                      | - **Propósito**: Inicializa el cliente HTTP para permitir interacciones con la API.                                    |
|                                      | - **Acción**: Crea una nueva instancia de `HttpClient`.                                                                |
| **GetAllGruposParticipantes**        | - **Propósito**: Obtiene todos los grupos participantes desde la API (ruta: `/gruposParticipantes`).                   |
|                                      | - **Solicitud**: `GET`.                                                                                                 |
|                                      | - **Retorno**: Devuelve una lista de objetos `GrupoParticipante` deserializados del JSON de respuesta.                  |
|                                      | - **Errores**: Muestra un mensaje de error y devuelve `null` si ocurre un fallo.                                        |
| **GetGrupoParticipanteId**           | - **Propósito**: Recupera un grupo participante específico por ID (ruta: `/gruposParticipantes/{id}`).                  |
|                                      | - **Solicitud**: `GET`.                                                                                                 |
|                                      | - **Retorno**: Devuelve un objeto `GrupoParticipante` con los datos del grupo participante solicitado.                  |
|                                      | - **Errores**: Muestra un mensaje de error y devuelve `null` si ocurre un fallo.                                        |
| **ActualizarGruposParticipantes**    | - **Propósito**: Actualiza un grupo participante existente en la API (ruta: `/gruposParticipantes/{id}`).               |
|                                      | - **Solicitud**: `PUT`.                                                                                                 |
|                                      | - **Entrada**: Un objeto `GrupoParticipante` que se convierte a JSON antes de enviarlo.                                  |
|                                      | - **Retorno**: Devuelve `true` si la actualización es exitosa; `false` si falla.                                       |
|                                      | - **Errores**: Muestra un mensaje de error si la solicitud no es exitosa.                                               |
| **Manejo de errores**                | - **Descripción**: Cada método incluye un bloque `try-catch` para capturar excepciones.                                |
|                                      | - **Acciones**: Muestra mensajes de error con `MessageBox.Show` y devuelve valores indicativos (`null` o `false`).      |

**Control Profesores**
| **Elemento**                         | **Descripción**                                                                                                        |
|--------------------------------------|------------------------------------------------------------------------------------------------------------------------|
| **Clase `ControlProfesores`**         | Clase encargada de gestionar las operaciones relacionadas con los profesores en una API REST.                         |
| **Variable `HttpClient`**            | Cliente HTTP reutilizable para realizar solicitudes a la API.                                                          |
| **Constructor**                      | - **Propósito**: Inicializa el cliente HTTP para permitir interacciones con la API.                                    |
|                                      | - **Acción**: Crea una nueva instancia de `HttpClient`.                                                                |
| **GetAllProfesores**                 | - **Propósito**: Obtiene todos los profesores desde la API (ruta: `/profesores`).                                       |
|                                      | - **Solicitud**: `GET`.                                                                                                 |
|                                      | - **Retorno**: Devuelve una lista de objetos `Profesor` deserializados del JSON de respuesta.                           |
|                                      | - **Errores**: Muestra un mensaje de error y devuelve `null` si ocurre un fallo.                                        |
| **GetProfesorMail**                  | - **Propósito**: Recupera un profesor específico por su correo electrónico (ruta: `/profesores/{mail}`).                |
|                                      | - **Solicitud**: `GET`.                                                                                                 |
|                                      | - **Retorno**: Devuelve un objeto `Profesor` con los datos del profesor solicitado.                                      |
|                                      | - **Errores**: Muestra un mensaje de error y devuelve `null` si ocurre un fallo.                                        |
| **ActualizarProfesor**               | - **Propósito**: Actualiza un profesor existente en la API (ruta: `/profesores/{uuid}`).                                |
|                                      | - **Solicitud**: `PUT`.                                                                                                 |
|                                      | - **Entrada**: Un objeto `Profesor` que se convierte a JSON antes de enviarlo.                                          |
|                                      | - **Retorno**: Devuelve `true` si la actualización es exitosa; `false` si falla.                                       |
|                                      | - **Errores**: Muestra un mensaje de error si la solicitud no es exitosa.                                               |
| **GetLogin**                         | - **Propósito**: Verifica el inicio de sesión de un profesor usando su correo y contraseña (ruta: `/profesores/inicio`). |
|                                      | - **Solicitud**: `GET`.                                                                                                 |
|                                      | - **Entrada**: `mail` y `password` como parámetros de la URL.                                                           |
|                                      | - **Retorno**: Devuelve un objeto `Profesor` si las credenciales son correctas; `null` si no lo son.                   |
|                                      | - **Errores**: No muestra mensajes de error (devuelve `null` si no hay coincidencia).                                   |
| **Manejo de errores**                | - **Descripción**: Cada método incluye un bloque `try-catch` para capturar excepciones.                                |
|                                      | - **Acciones**: Muestra mensajes de error con `MessageBox.Show` y devuelve valores indicativos (`null` o `false`).      |

**Control Profesores Participantes**
| **Elemento**                         | **Descripción**                                                                                                         |
|--------------------------------------|-------------------------------------------------------------------------------------------------------------------------|
| **Clase `ControlProfParticipantes`**  | Clase encargada de gestionar las operaciones relacionadas con los participantes de profesores en una API REST.          |
| **Variable `HttpClient`**            | Cliente HTTP reutilizable para realizar solicitudes a la API.                                                           |
| **Constructor**                      | - **Propósito**: Inicializa el cliente HTTP para permitir interacciones con la API.                                     |
|                                      | - **Acción**: Crea una nueva instancia de `HttpClient`.                                                                  |
| **GetAllProfParticipantes**          | - **Propósito**: Obtiene todos los participantes de profesores desde la API (ruta: `/profesoresParticipantes`).           |
|                                      | - **Solicitud**: `GET`.                                                                                                  |
|                                      | - **Retorno**: Devuelve una lista de objetos `ProfParticipante` deserializados del JSON de respuesta.                    |
|                                      | - **Errores**: Muestra un mensaje de error y devuelve `null` si ocurre un fallo.                                         |
| **GetActividadId**                   | - **Propósito**: Recupera un participante de profesor específico por su ID (ruta: `/profesoresParticipantes/{id}`).      |
|                                      | - **Solicitud**: `GET`.                                                                                                  |
|                                      | - **Retorno**: Devuelve un objeto `ProfParticipante` con los datos del participante solicitado.                          |
|                                      | - **Errores**: Muestra un mensaje de error y devuelve `null` si ocurre un fallo.                                         |
| **ActualizarProfParticipante**       | - **Propósito**: Actualiza un participante de profesor en la API (ruta: `/profesoresParticipantes/{id}`).                 |
|                                      | - **Solicitud**: `PUT`.                                                                                                  |
|                                      | - **Entrada**: Un objeto `ProfParticipante` que se convierte a JSON antes de enviarlo.                                   |
|                                      | - **Retorno**: Devuelve `true` si la actualización es exitosa; `false` si falla.                                        |
|                                      | - **Errores**: Muestra un mensaje de error si la solicitud no es exitosa.                                                |
| **Manejo de errores**                | - **Descripción**: Cada método incluye un bloque `try-catch` para capturar excepciones.                                 |
|                                      | - **Acciones**: Muestra mensajes de error con `MessageBox.Show` y devuelve valores indicativos (`null` o `false`).       |

**Control Profesores Responsables**
| **Elemento**                         | **Descripción**                                                                                                         |
|--------------------------------------|-------------------------------------------------------------------------------------------------------------------------|
| **Clase `ControlProfResponsables`**  | Clase encargada de gestionar las operaciones relacionadas con los responsables de los profesores en una API REST.       |
| **Variable `HttpClient`**            | Cliente HTTP reutilizable para realizar solicitudes a la API.                                                           |
| **Constructor**                      | - **Propósito**: Inicializa el cliente HTTP para permitir interacciones con la API.                                     |
|                                      | - **Acción**: Crea una nueva instancia de `HttpClient`.                                                                  |
| **GetAllProfResponsables**           | - **Propósito**: Obtiene todos los responsables de los profesores desde la API (ruta: `/profesoresResponsables`).        |
|                                      | - **Solicitud**: `GET`.                                                                                                  |
|                                      | - **Retorno**: Devuelve una lista de objetos `ProfResponsable` deserializados del JSON de respuesta.                     |
|                                      | - **Errores**: Muestra un mensaje de error y devuelve `null` si ocurre un fallo.                                         |
| **GetProfResponsableId**             | - **Propósito**: Recupera un responsable de profesor específico por su ID (ruta: `/profesoresResponsables/{id}`).         |
|                                      | - **Solicitud**: `GET`.                                                                                                  |
|                                      | - **Retorno**: Devuelve un objeto `ProfResponsable` con los datos del responsable solicitado.                            |
|                                      | - **Errores**: Muestra un mensaje de error y devuelve `null` si ocurre un fallo.                                         |
| **ActualizarProfResponsable**        | - **Propósito**: Actualiza un responsable de profesor en la API (ruta: `/profesoresResponsables/{id}`).                  |
|                                      | - **Solicitud**: `PUT`.                                                                                                  |
|                                      | - **Entrada**: Un objeto `ProfResponsable` que se convierte a JSON antes de enviarlo.                                    |
|                                      | - **Retorno**: Devuelve `true` si la actualización es exitosa; `false` si falla.                                        |
|                                      | - **Errores**: Muestra un mensaje de error si la solicitud no es exitosa.                                                |
| **Manejo de errores**                | - **Descripción**: Cada método incluye un bloque `try-catch` para capturar excepciones.                                 |
|                                      | - **Acciones**: Muestra mensajes de error con `MessageBox.Show` y devuelve valores indicativos (`null` o `false`).       |

## Enumerados
- EstadoActividad (define los diferentes estados posibles para una actividad)
~~~~
public enum EstadoActividad
{
    SOLICITADA,
    DENEGADA,
    APROBADA,
    REALIZADA,
    REALIZANDOSE,
    CANCELADA

}
~~~~~
- EtapaCurso (representa diferentes etapas o niveles educativos en el sistema educativo)
~~~~
  public enum EtapaCurso
  {
      ESO,
      BACH,
      FPGS,
      FPGM,
      FPB,
      FPCE

  }
  ~~~~
  - RolProfesor (representa diferentes roles que un profesor puede tener dentro de un sistema educativo)
  ~~~~
   public enum RolProfesor
 {
     ADM,
     ED,
     PROF
 }
 ~~~~
 - TipoActividad(se utiliza para categorizar diferentes tipos de actividades que pueden existir en un sistema educativo)
 ~~~~
  public enum TipoActividad
 {
     EXTRAESCOLAR,
     COMPLEMENTARIA
 }
 ~~~~
> Se adjunta foto de la carpeta donde se encuentran los enumerados:

![alt text](image-2.png)

# Conclusión

En cuanto a la conclusión, el sistema implementado se centra en la gestión integral de actividades, profesores y roles dentro de un entorno educativo, probablemente un centro como el IES Miguel Herrero. A través de este proyecto, se han desarrollado funcionalidades clave como el manejo de profesores responsables, participantes, tipos de actividades y estados de las mismas, lo que permite una organización más eficiente y estructurada de las dinámicas escolares. Además, se utilizan enumeraciones claras para definir roles, etapas educativas y tipos de actividades, facilitando la escalabilidad y mantenimiento del código.

El proyecto muestra un enfoque en el uso de servicios HTTP y el manejo de datos mediante API REST, lo que lo hace moderno, adaptable y conectado. Todo esto asegura una experiencia intuitiva para los usuarios y contribuye al control preciso de los procesos académicos y administrativos. Sin duda, este sistema representa un avance significativo hacia la digitalización de las tareas de gestión en un centro educativo.
