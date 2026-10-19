# Mesa de Partes Digital - Municipalidad de Los Olivos

Aplicación de consola en C# que propone digitalizar el registro y la consulta de expedientes de una mesa de partes. Es un proyecto académico del curso **Fundamentos de Programación (CIIN1205P)** de la Universidad Privada del Norte.

## Objetivo

Organizar la información de los trámites mediante un prototipo sencillo que permita registrar expedientes, validar el DNI del administrado, consultar registros, ordenarlos por código y conservarlos en archivos de texto.

## Funcionalidades previstas

- Registro del DNI, nombres y apellidos, correo electrónico y asunto del trámite.
- Validación del DNI con exactamente ocho dígitos numéricos, conservando los ceros iniciales.
- Generación de códigos con el formato `EXP-2026-001`.
- Búsqueda por código de expediente o DNI, con varias coincidencias para un mismo DNI.
- Ordenamiento ascendente por código de expediente.
- Almacenamiento y recuperación de hasta 100 expedientes mediante un archivo de texto.

## Estado actual

La versión inicial contiene el menú principal, el control de opciones y los arreglos compartidos. El proyecto compila y permite recorrer las opciones de la consola.

Los módulos de registro, búsqueda, ordenamiento y persistencia contienen métodos temporales que muestran **«Funcionalidad pendiente de implementar»**. Por ello, esta versión todavía no registra, consulta, ordena ni guarda expedientes. Las funcionalidades descritas corresponden al alcance previsto del prototipo.

## Tecnologías y conceptos utilizados

- C# y .NET 10.
- Entrada y salida mediante `Console.ReadLine()` y `Console.WriteLine()`.
- Estructuras de control `if`, `switch`, `while`, `for` y `do-while`.
- Métodos y clases estáticas para organizar el código.
- Arreglos paralelos de tipo `string[]`.

Los algoritmos previstos utilizan búsqueda secuencial, ordenamiento con ciclos anidados y archivos de texto mediante `System.IO`. El proyecto no requiere paquetes NuGet adicionales.

## Organización del código

```text
src/
└── MesaPartesDigital/
    ├── MesaPartesDigital.csproj
    ├── Program.cs
    ├── DatosExpedientes.cs
    ├── RegistroExpedientes.cs
    ├── BusquedaExpedientes.cs
    ├── OrdenamientoExpedientes.cs
    └── ArchivoExpedientes.cs
```

| Archivo | Propósito |
| --- | --- |
| `MesaPartesDigital.csproj` | Configuración del proyecto de consola y versión de .NET |
| `Program.cs` | Menú principal y selección de opciones |
| `DatosExpedientes.cs` | Arreglos de códigos, DNI, nombres, correos y asuntos; contador y capacidad máxima |
| `RegistroExpedientes.cs` | Módulo destinado al registro y la validación del DNI |
| `BusquedaExpedientes.cs` | Módulo destinado a la consulta por código o DNI |
| `OrdenamientoExpedientes.cs` | Módulo destinado al ordenamiento por código |
| `ArchivoExpedientes.cs` | Módulo destinado a la lectura y escritura de datos |

Los cinco arreglos comparten el mismo índice para relacionar los datos de cada expediente. La capacidad máxima es de **100 registros**.

## Requisitos

- Visual Studio con soporte para proyectos de consola de .NET 10.
- SDK de .NET 10 instalado.

## Ejecución en Visual Studio

1. Abrir `src/MesaPartesDigital/MesaPartesDigital.csproj`.
2. Seleccionar **Compilar > Compilar solución**.
3. Ejecutar con **Depurar > Iniciar sin depurar** o **Ctrl + F5**.

El menú presenta las siguientes opciones:

```text
1. Registrar Expediente
2. Buscar Expediente
3. Ordenar Expedientes por Código
4. Salir
```

## Almacenamiento previsto

La persistencia utilizará un archivo llamado `expedientes.txt`, con un expediente por línea y cinco campos separados por `|`:

```text
EXP-2026-001|00123456|Ana Prueba|ana@example.com|Solicitud de licencia
```

El archivo se ubicará en el directorio desde el que se ejecute la aplicación. La lectura y la escritura estarán disponibles al completar el módulo de persistencia. Los datos del ejemplo son ficticios.
