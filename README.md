1. Integrantes del grupo: ⦁ Valeria Chacón Aragón ⦁ Camila Corrales Roca ⦁ Diana Ramírez Aguilar ⦁ Vivian Michelle Velázquez Rojas

3. Link del Repositorio:  (https://github.com/Dramirez00467/PracticaProgramada3.git)

4. Especificación básica del proyecto:
   ```
    a. Arquitectura del proyecto:
          El programa está estructurado en una arquitectura por capas, donde cada proyecto cumple un rol específico dentro del sistema:
           -PracticaProgramada3 (MVC): corresponde a la capa de presentación. Aquí se gestiona la interfaz, los controladores y toda la parte visual que interactúa con el usuario.
           -PracticaProgramada3DAL: funciona como la capa de acceso a datos, incluyendo la entidad y el repositorio encargado de realizar las operaciones CRUD.
           -PracticaProgramada3BLL: representa la capa de negocio, donde se maneja la lógica del sistema, los servicios internos, los Dtos y el mapeo necesario entre capas.
         Esta separación permite mantener cada parte del programa organizada según su responsabilidad, facilitando la lectura y el mantenimiento del proyecto.

   b. Libraries o paquetes de nuget utilizados
            Paquetes nugget usados
                  -Microsoft.EntityFrameworkCore(8.0.21)
                  -Microsoft.EntityFrameworkCore.Desing(8.0.21)
                  -Microsoft.EntityFrameworkCore.Sqlite(8.0.21)
                  -Microsoft.EntityFrameworkCore.Tools(8.0.21)
                  -Swashbucle.ASPNetCore(6.6.2)
                  -Automapper(15.1.0)
                  
            Librerias usadas
                  -using Microsoft.AspNetCore.Mvc
                  -using PracticaProgramada3.BLL.Servicios
                  -using Microsoft.EntityFrameworkCore;
                  -using PracticaProgramada3.BLL.Mapeos;
                  -using PracticaProgramada3.BLL.Servicios;
                  -using PracticaProgramada3.DLL;
                  -using PracticaProgramada3.DLL.Repositorio;
                  -using System;
                  -using System.Collections.Generic;
                  -using System.Linq;
                  -using System.Text;
                  -using System.Threading.Tasks;
                  -using AutoMapper;
                  -using PracticaProgramada3.BLL.Dtos;
                  -using PracticaProgramada3.DLL.Entidades;
                  -using static System.Runtime.InteropServices.JavaScript.JSType;
                  -using AutoMapper;

   c. Principios de SOLID y patrones de diseño utilizados
      Principio de responsabilidad única: Busca que cada clase asuma una única responsabilidad. Donde el controller se encarga de gestionar las peticiones HTTP y llamar al servicio. El servicio se encarga de la lógica de negocio y el repositorio provee el acceso a los           datos.
      Principio de alimentación de objetos:  "Estos principios ayudan a crear software modular, reutilizable y fácil de mantener al organizar el código en torno a "objetos" que tienen atributos y comportamientos." (Pontia, 2025)
      Patrón MVC: Modelo, Vista y Controlador:  Enfatiza una separación entre la lógica de negocios y su visualización.(MVC - Glosario De MDN Web Docs | MDN, s.f.)




   Pontia. (2025, enero 10). Principios de la programación orientada a objetos 💡. Pontia. https://www.pontia.tech/principios-de-la-programacion-orientada-a-objetos/
   MVC - Glosario de MDN Web Docs | MDN. (s.f.). https://developer.mozilla.org/es/docs/Glossary/MVC
