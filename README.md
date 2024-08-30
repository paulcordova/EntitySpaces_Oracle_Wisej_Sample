# Northwind Application with Wisej.NET, EntitySpaces, and Oracle

This project is a .NET 8 application built with Visual Studio 2022, using Wisej.NET for the frontend, EntitySpaces as the ORM, and Oracle as the database.

## Requirements

- Visual Studio 2022
- .NET 8 SDK
- Oracle Database (using Oracle Express in Docker)
- EntitySpaces libraries
- Wisej.NET libraries
- Docker

## Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/yourusername/northwind-app.git
cd northwind-app
```

### 2. Set up Oracle Database using Docker

- Ensure Docker is installed and running on your local machine.
- Pull and run the Oracle Express image from Docker Hub:
  
  ```bash
  docker run -d --name oracle-xe -p 1521:1521 -e ORACLE_PWD=yourpassword gvenzl/oracle-xe
  ```
  
- Once the container is running, you can connect to the Oracle database using tools like SQL*Plus or SQL Developer.
- Run the Northwind database script to create tables and insert data. You can do this from within the container or using an external tool:
  
  ```bash
  sqlplus sys/yourpassword@localhost:1521/XEPDB1 as sysdba @path/to/northwind.sql
  ```

### 3. Configure the application

- Open the solution in Visual Studio 2022.
- Go to `appsettings.json` and update the Oracle connection string with your database credentials:
  
  ```json
  {
    "ConnectionStrings": {
      "DefaultConnection": "User Id=yourusername;Password=yourpassword;Data Source=localhost:1521/XEPDB1"
    }
  }
  ```

### 4. Restore NuGet packages

- In Visual Studio, restore the NuGet packages by right-clicking the solution and selecting "Restore NuGet Packages."

### 5. Run the application

- Set the startup project to the Wisej.NET frontend project.
- Build and run the application by pressing `F5` or clicking the "Start" button in Visual Studio.

## Troubleshooting

- Ensure that the Oracle Docker container is running and that the connection string is correctly configured.
- If there are any issues with EntitySpaces, ensure that the correct libraries are referenced and that the configuration is correct.

## License

This project is licensed under the MIT License.

---

# Aplicación Northwind con Wisej.NET, EntitySpaces y Oracle

Este proyecto es una aplicación .NET 8 construida con Visual Studio 2022, utilizando Wisej.NET para el frontend, EntitySpaces como ORM y Oracle como base de datos.

## Requisitos

- Visual Studio 2022
- .NET 8 SDK
- Oracle Database (usando Oracle Express en Docker)
- Librerías de EntitySpaces
- Librerías de Wisej.NET
- Docker

## Comenzando

### 1. Clona el repositorio

```bash
git clone https://github.com/yourusername/northwind-app.git
cd northwind-app
```

### 2. Configurar la base de datos Oracle usando Docker

- Asegúrate de que Docker esté instalado y en ejecución en tu máquina local.
- Descarga y ejecuta la imagen de Oracle Express desde Docker Hub:
  
  ```bash
  docker run -d --name oracle-xe -p 1521:1521 -e ORACLE_PWD=tupassword gvenzl/oracle-xe
  ```
  
- Una vez que el contenedor esté en ejecución, puedes conectarte a la base de datos Oracle usando herramientas como SQL*Plus o SQL Developer.
- Ejecuta el script de la base de datos Northwind para crear las tablas e insertar datos. Puedes hacerlo desde dentro del contenedor o usando una herramienta externa:
  
  ```bash
  sqlplus sys/tupassword@localhost:1521/XEPDB1 as sysdba @path/to/northwind.sql
  ```

### 3. Configura la aplicación

- Abre la solución en Visual Studio 2022.
- Ve a `appsettings.json` y actualiza la cadena de conexión de Oracle con tus credenciales de base de datos:
  
  ```json
  {
    "ConnectionStrings": {
      "DefaultConnection": "User Id=tuusuario;Password=tupassword;Data Source=localhost:1521/XEPDB1"
    }
  }
  ```

### 4. Restaurar paquetes NuGet

- En Visual Studio, restaura los paquetes NuGet haciendo clic derecho en la solución y seleccionando "Restaurar paquetes NuGet."

### 5. Ejecuta la aplicación

- Establece el proyecto de inicio en el proyecto frontend de Wisej.NET.
- Compila y ejecuta la aplicación presionando `F5` o haciendo clic en el botón "Iniciar" en Visual Studio.

## Solución de problemas

- Asegúrate de que el contenedor Docker de Oracle esté en ejecución y que la cadena de conexión esté correctamente configurada.
- Si hay algún problema con EntitySpaces, asegúrate de que las bibliotecas correctas estén referenciadas y que la configuración sea correcta.

## Licencia

Este proyecto está licenciado bajo la Licencia MIT.

---

Este README te proporcionará una guía clara tanto en inglés como en español para ejecutar tu aplicación localmente utilizando Oracle en Docker.
