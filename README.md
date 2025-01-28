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
Esta aplicación permite la gestion con todo lo relacionado con las actividades extraescolares y complementarias mediante la comunicación con una API externa. Está desarrollada en .NET y sigue una estructura modular para facilitar su mantenimiento y ampliación.

## API
La api con la cual nos comunicamos se puede encontrar en este github justo con su documentacion
[https://github.com/PauDiSan/ProyectoIntermodularEquipoA2/tree/main](https://github.com/PauDiSan/ProyectoIntermodularEquipoA2/tree/main)

## Estructura

```plaintext
Reto2025
    ├── Controls        # Controladores (Contiene los controladores que interactuan con la API)
    ├── Models          # Clases de modelo y enums (Incluye las entidades que representan tablas de la base de datos)
         └── Enums      # Guarda los enums utilizados por los modelos
    ├── Resources       # Guarda ciertas imagenes utilizadas por la interfaz grafica de la aplicacion
    └── Views           # Clases Form las cuales compenen la aplicacion
```

## Modelos (Entities)

Los modelos representan las entidades en la base de datos. Utilizando los Controls convertimos los datos en formato Json que nos da la api en estas entidades

### Principales entidades del proyecto

1. **Actividad**: Representa una actividad registrada en el sistema.
2. **Contrato**: Guarda la actividad, tranposrte e información basica del contrato.
3. **Curso**: Representa los cursos del instituto.
4. **Departamento** Representa los departamentos del instituto
5. **EmpTransporte**: Representa las empresas transporte que se han contratado para realizar alguna actividad.
6. **Foto**: Guarda la informacion necesaria para acceder a las fotos y a que actividad pertenecen.
7. **Grupo**: Representa el grupo, guardando el curso al que pertenecen, su tutor y si aun existe.
8. **Profesores**: Representa un profesor y toda su informacion relevante como email, nombre, apellidos, contraseña(encriptada), dni, etc...

Además, se utilizan los **Enums** para valores constantes de etapa, rol, estado y tipo

## Modelos
Las clases que se encuentran en la clase modelos son:


### Controladores

1. **ControlActividades**: Permite interactuar con la API para gestionar **Actividad**
2. **ControlContratos**: Permite interactuar con la API para gestionar **Contrato**
3. **ControlCursos**: Permite interactuar con la API para gestionar **Curso**
4. **ControlDepartamentos**: Permite interactuar con la API para gestionar **Departamento**
5. **ControlEmpTransporte** Permite interactuar con la API para gestionar **EmpTransporte**
6. **ControlFotos** Permite interactuar con la API para gestionar **Foto**
7. **ControlGrupos** Permite interactuar con la API para gestionar **Grupo**
8. **ControlProfesores** Permite interactuar con la API para gestionar **Profesor**

# Conclusión

En cuanto a la conclusión, el sistema implementado se centra en la gestión integral de actividades, profesores y roles dentro de un entorno educativo, probablemente un centro como el IES Miguel Herrero. A través de este proyecto, se han desarrollado funcionalidades clave como el manejo de profesores responsables, participantes, tipos de actividades y estados de las mismas, lo que permite una organización más eficiente y estructurada de las dinámicas escolares. Además, se utilizan enumeraciones claras para definir roles, etapas educativas y tipos de actividades, facilitando la escalabilidad y mantenimiento del código.

El proyecto muestra un enfoque en el uso de servicios HTTP y el manejo de datos mediante API REST, lo que lo hace moderno, adaptable y conectado. Todo esto asegura una experiencia intuitiva para los usuarios y contribuye al control preciso de los procesos académicos y administrativos. Sin duda, este sistema representa un avance significativo hacia la digitalización de las tareas de gestión en un centro educativo.
