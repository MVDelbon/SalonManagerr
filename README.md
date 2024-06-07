# Aplicación de Gestión de Turnos y Clientes de Peluquería

Este repositorio contiene una aplicación web para la gestión de turnos y clientes de una peluquería, desarrollada en C# utilizando Blazor, API REST y Entity Framework Core. La arquitectura de la aplicación está organizada en capas: dominio, aplicación, infraestructura, API y web.

## Estructura del Proyecto

- **Dominio**: Contiene las entidades, interfaces y lógica de negocio.
- **Aplicación**: Maneja los casos de uso y la lógica de la aplicación.
- **Infraestructura**: Implementa los repositorios y la comunicación con la base de datos utilizando Entity Framework Core.
- **API**: Expone los servicios a través de una API REST.
- **Web**: Interfaz de usuario desarrollada con Blazor.

## Requisitos

- .NET 6 SDK o superior
- Visual Studio 2022 o Visual Studio Code
- SQL Server

## Configuración del Entorno

1. Clona este repositorio en tu máquina local:
    ```sh
    git clone https://github.com/tu_usuario/nombre_del_repositorio.git
    cd nombre_del_repositorio
    ```

2. Configura la cadena de conexión en `appsettings.json` dentro del proyecto de infraestructura:
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Server=tu_servidor;Database=nombre_base_de_datos;User Id=tu_usuario;Password=tu_contraseña;"
    }
    ```

3. Aplica las migraciones de Entity Framework Core para crear la base de datos:
    ```sh
    dotnet ef database update --project Infraestructura
    ```

## Ejecución de la Aplicación

1. Actualiza los paquetes NuGet:
    ```sh
    dotnet restore
    ```

2. Aplica las migraciones de la base de datos:
    ```sh
    dotnet ef database update --project Infraestructura
    ```

3. Ejecuta la aplicación:
    ```sh
    dotnet run --project Web
    ```

## Contribuciones

¡Las contribuciones son bienvenidas! Por favor, sigue los siguientes pasos:

1. Haz un fork de este repositorio.
2. Crea una rama con tu nueva característica (`git checkout -b feature/nueva-caracteristica`).
3. Realiza los cambios necesarios.
4. Realiza un commit de tus cambios (`git commit -am 'Agrega nueva característica'`).
5. Sube tus cambios a la rama (`git push origin feature/nueva-caracteristica`).
6. Abre un Pull Request.

## Licencia

Este proyecto está licenciado bajo la Licencia MIT. Consulta el archivo [LICENSE](LICENSE) para obtener más detalles.

## Contacto

Para cualquier consulta, por favor contacta a:

- **Nombre del Desarrollador**
- **Correo Electrónico**
- **GitHub**: [MVDelbon](https://github.com/MVDelbon)
