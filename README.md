# Prueba_DIAN

El proyecto contiene: BackEnd .Net 6.0, FrontEnd Blazor Web App y la BD SQL Server con EF Core para mapear la BD.

Procedimiento para levantar proyectos:

1. Ajustar la cadena de conexión al servidor de la Base de Datos en el archivo "appsettings.json" del proyecto: Dian03.Business.
2. Ejecutar el comando: "Update-database", en el Package Manager Console para crear la Base de Datos. El archivo de Migración se ubica en el proyecto Dian01.Data
3. Se incluye Script para poblar la BD en la carpeta Scripts del proyecto Dian01.Data


