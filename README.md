# Gestor de tareas en C#

Aplicación de escritorio desarrollada con **Windows Forms** que permite gestionar una lista de tareas almacenadas en archivos **JSON**.

## Funcionalidades
- Carga inicial de tareas desde un archivo JSON seleccionado por el usuario.
- Alta de nuevas tareas con descripción y fecha límite.
- Posibilidad de marcar tareas como realizadas.
- Guardado automático de las tareas pendientes al cerrar la aplicación.
- Importación y exportación de listas de tareas en formato JSON.

## Requisitos
- Windows con [.NET Framework 4.8](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48).
- [Visual Studio 2022](https://visualstudio.microsoft.com/) o compatible.
- Restaurar los paquetes NuGet antes de compilar.

## Cómo ejecutar
1. Clona este repositorio.
2. Abre `HolaMundo.sln` con Visual Studio.
3. Restaura los paquetes NuGet y compila la solución.
4. Ejecuta el proyecto **HolaMundo** para gestionar tus tareas.

## Próximas mejoras
- Resaltar en rojo las tareas cuyo plazo haya vencido.
- Optimizar la liberación de recursos y el cierre de procesos.
- Permitir importar y exportar tareas usando bases de datos SQL.

## Tecnologías utilizadas
![Lenguaje](https://img.shields.io/badge/C%23-.NET-blueviolet?logo=csharp)
![Framework](https://img.shields.io/badge/.NET_Framework-4.8-512BD4)
![UI](https://img.shields.io/badge/WinForms-UI-blue?logo=windows)

> [!IMPORTANT]
> Usa Visual Studio 2022 para evitar problemas de compatibilidad.
