# WebApiServicesReport

API web en **ASP.NET Web API 2** (.NET Framework 4.5) orientada a la **generación y exposición de informes** operativos y de negocio (fin de día, facturación, cheques, giros, pagos de facturas, cumplimiento normativo, etc.). La solución sigue una capa clásica: presentación HTTP, lógica de negocio, acceso a datos, entidades y un ensamblado dedicado a definiciones de informes.

## Contenido de la solución

| Proyecto | Rol |
|----------|-----|
| **WebAPIServices** | Aplicación web ASP.NET MVC + Web API: controladores, filtros de autorización, Swagger (Swashbuckle), Help Page, telemetría Application Insights y **log4net**. |
| **WebAPIBusiness** | Reglas de negocio y orquestación; referencia a informes y entidades. |
| **WebAPIReports** | Informes **DevExpress XtraReports** (PDF/imprimir), plantillas por dominio (agencia, facturas, cheques, FX, etc.). |
| **WebAPIDataAccess** | Acceso a datos; integración con **Microsoft ReportViewer** (SSRS) y tipos SQL Server. |
| **WebAPIEntities** | Modelos / entidades compartidas. |

Archivo de solución: `WebAPIServices.sln`.

## Requisitos previos

- **Visual Studio** 2013 o superior (la solución está en formato VS 2013; se puede abrir con versiones más nuevas con posibles avisos de retargeting).
- **.NET Framework 4.5** (SDK / targeting pack).
- **IIS Express** o **IIS** para ejecutar el proyecto web.
- **NuGet**: restaurar paquetes antes de compilar (`packages` en la raíz del repo).

### Dependencias comerciales y de terceros

- **DevExpress** (v17.2 / v18.1 según referencias en `WebAPIReports`): componentes con licencia. El proyecto de informes referencia ensamblados DevExpress; hace falta el entorno de desarrollo/licencias acordes para compilar y diseñar informes.
- **Microsoft SQL Server** y cadena de conexión / configuración de aplicación según el entorno (ver `Web.config` y transformaciones `Web.DEV.config`, `Web.QA.config`, `Web.UAT.config`, `Web.Release.config`).

## Cómo compilar

1. Clonar el repositorio.
2. Abrir `WebAPIServices.sln` en Visual Studio.
3. Menú **Compilar → Restaurar paquetes NuGet** (o `nuget restore` / `msbuild -t:restore` según tu toolchain).
4. Compilar la solución en configuración **Debug** o **Release**.

Desde línea de comandos (con MSBuild en el PATH), ejemplo:

```powershell
msbuild "WebAPIServices.sln" /p:Configuration=Release
```

## Cómo ejecutar en desarrollo

1. Establecer **WebAPIServices** como proyecto de inicio.
2. Ajustar `Web.config` (o la transformación del entorno activo) con los valores necesarios, entre otros:
   - `EnvironmentId`, `ApplicationId` (usados por la autorización y configuración).
   - Credenciales y cadenas de conexión que espere la capa de datos (no incluir secretos en el repositorio; usar configuración local o secretos del host).
3. Ejecutar con **F5** (IIS Express) o publicar en IIS.

En el `.csproj` del sitio aparecen URLs de ejemplo para IIS Express (`http://localhost:8087/`, puerto SSL `44300`); el puerto efectivo puede variar según la configuración de Visual Studio.

## API y documentación

- Rutas Web API habituales: prefijo **`api/`** con plantillas `api/{controller}/{id}` y `api/{controller}/{action}/{param}` (ver `App_Start/WebApiConfig.cs`).
- Controladores de ejemplo en `WebAPIServices/Controllers/` (informes de fin de día, facturas, cheques, giros, pagos de facturas, tarjeta de débito, cumplimiento normativo, SSRS, etc.).
- **Swagger / OpenAPI** (Swashbuckle): tras arrancar la aplicación, la UI suele estar disponible en **`/swagger`** (ruta por defecto de Swashbuckle).
- **Help Page** de ASP.NET Web API en el área `Areas/HelpPage`.

## Autenticación

Los endpoints protegidos pueden usar el filtro **`APIAuthorizeAttribute`**, que valida **HTTP Basic** frente a credenciales obtenidas de la base de configuración según `EnvironmentId` y `ApplicationId`. Las llamadas deben enviar la cabecera `Authorization: Basic <base64>`.

## Telemetría y registro

- **Application Insights** (configuración en `ApplicationInsights.config` y variantes por entorno).
- **log4net** en los proyectos web y de negocio/datos.

## Estructura de carpetas relevante

- `WebAPIServices/App_Start/` — Web API, MVC, Swagger, bundles.
- `WebAPIServices/Controllers/` — API HTTP.
- `WebAPIReports/Reports/` — definiciones de informes por dominio.
- `WebAPIDataAccess/` — acceso a datos e informes SSRS vía ReportViewer cuando aplique.

## Contribuciones

Las contribuciones internas suelen seguir el flujo de la organización (ramas, revisión de código, CI). Si este repositorio es público o compartido con externos, documenta aquí el proceso acordado (por ejemplo: *fork*, *pull request*, convenciones de commits).

## Licencia

Este repositorio no incluye un archivo `LICENSE` en la raíz. La licencia del código y de las dependencias de terceros (DevExpress, Microsoft, etc.) depende de los acuerdos de tu organización; conviene añadir un `LICENSE` explícito si el proyecto se publica fuera del ámbito interno.
