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
6. [Views](#views)
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

### Controladores

Los controladores interactuan con la api para manejar los modelos de los cuales estan encargados

1. **ControlActividades**: Permite interactuar con la API para gestionar **Actividad**
2. **ControlContratos**: Permite interactuar con la API para gestionar **Contrato**
3. **ControlCursos**: Permite interactuar con la API para gestionar **Curso**
4. **ControlDepartamentos**: Permite interactuar con la API para gestionar **Departamento**
5. **ControlEmpTransporte** Permite interactuar con la API para gestionar **EmpTransporte**
6. **ControlFotos** Permite interactuar con la API para gestionar **Foto**
7. **ControlGrupos** Permite interactuar con la API para gestionar **Grupo**
8. **ControlProfesores** Permite interactuar con la API para gestionar **Profesor**


## Views

Los views son los forms que forman la parte visual e interactiva de la aplicacion

1. **FrmAgregarEmpresa**

![imagen](https://github.com/user-attachments/assets/a981a98a-909d-4b26-a7b1-20b3e7e1c804)
   
2. **FrmContratosActividad**

![imagen](https://github.com/user-attachments/assets/5e40c3f9-c124-44d7-9415-e4d692e19919)

3. **FrmContratoTransporte**

![imagen](https://github.com/user-attachments/assets/05eb1fa3-af7c-4c04-9b11-5db6fc859cd4)

4. **FrmCrearActividad**

![imagen](https://github.com/user-attachments/assets/de64affd-bc17-4e29-ae6e-78e077f373f0)

5. **FrmCursos**

![imagen](https://github.com/user-attachments/assets/848e126b-3417-4634-97d0-1ceda80e48ac)

6. **FrmDepartamentos**

![imagen](https://github.com/user-attachments/assets/8c88ce38-4f0b-4b85-95e8-21ae85d9c462)

7. **FrmEmpresasTransporte**

![imagen](https://github.com/user-attachments/assets/4472137f-d581-4f93-a32b-3bd1a7447298)

8. **FrmFAQ**

![imagen](https://github.com/user-attachments/assets/91366c36-2adb-45e3-a986-bee399dea489)

9. **FrmFoto**
 
![imagen](https://github.com/user-attachments/assets/163835d6-2de9-4a93-a98c-b6bda4a8b7ef)

10. **FrmFotosActividad**

![imagen](https://github.com/user-attachments/assets/78029849-0b2b-47a4-ad1c-b9c05c1722a3)

11. **FrmInicio**

![imagen](https://github.com/user-attachments/assets/2fb9cbab-16a8-4f62-a495-ea5d941ba342)

12. **FrmLogin**

![imagen](https://github.com/user-attachments/assets/31e67867-1830-4529-8b0e-5faec6793ded)

13. **FrmNormativa**

![imagen](https://github.com/user-attachments/assets/d61bd95d-a1dd-41cb-8a0f-42668e222376)

14. **FrmPerfil**

![imagen](https://github.com/user-attachments/assets/66a3c08d-4651-4ef2-8f88-8defb7c9e2ba)

15. **FrmProfesores**

![imagen](https://github.com/user-attachments/assets/97e9857b-4ec1-4ba2-ad8e-8c9e7438499a)

16. **FrmVerActividad**

![imagen](https://github.com/user-attachments/assets/50db5019-0271-4e35-8ff1-9631ce44948c)

17. **FrmVerActividadAdmin**

![imagen](https://github.com/user-attachments/assets/8561f8c3-fc77-4d95-ab16-b94b0708a340)

18. **FrmVerActividades**

![imagen](https://github.com/user-attachments/assets/f55f582a-c07d-4cea-8bfa-6d0fbd9d9c76)


# Conclusión

En cuanto a la conclusión, el sistema implementado se centra en la gestión integral de actividades, profesores y roles dentro de un entorno educativo, probablemente un centro como el IES Miguel Herrero. A través de este proyecto, se han desarrollado funcionalidades clave como el manejo de profesores responsables, participantes, tipos de actividades y estados de las mismas, lo que permite una organización más eficiente y estructurada de las dinámicas escolares. Además, se utilizan enumeraciones claras para definir roles, etapas educativas y tipos de actividades, facilitando la escalabilidad y mantenimiento del código.

El proyecto muestra un enfoque en el uso de servicios HTTP y el manejo de datos mediante API REST, lo que lo hace moderno, adaptable y conectado. Todo esto asegura una experiencia intuitiva para los usuarios y contribuye al control preciso de los procesos académicos y administrativos. Sin duda, este sistema representa un avance significativo hacia la digitalización de las tareas de gestión en un centro educativo.
