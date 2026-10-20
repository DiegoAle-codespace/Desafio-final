using System;
using static DatosExpedientes;

public static class RegistroExpedientes
{
    private static string dnis = "";
    private static string nombres = "";
    private static string apellidos = "";
    private static string correos = "";
    private static string asuntos = "";

    public static void RegistrarExpediente()
    {
        Console.WriteLine("--- Registro de Nuevo Expediente ---");

        Console.Write("Ingrese DNI (8 dígitos): ");
        string dni = Console.ReadLine() ?? "";

        if (dni.Length != 8 || !System.Text.RegularExpressions.Regex.IsMatch(dni, @"^\d{8}$"))
        {
            Console.WriteLine("Error: El DNI debe tener exactamente 8 dígitos numéricos.");
            return;
        }

        Console.Write("Ingrese Nombres: ");
        string nombre = Console.ReadLine() ?? "";

        Console.Write("Ingrese Apellidos: ");
        string apellido = Console.ReadLine() ?? "";

        Console.Write("Ingrese Correo Electrónico: ");
        string correo = Console.ReadLine() ?? "";

        Console.Write("Ingrese Asunto del trámite: ");
        string asunto = Console.ReadLine() ?? "";

        // Mantenemos las asignaciones originales de tu compañero
        dnis = dni;
        nombres = nombre;
        apellidos = apellido;
        correos = correo;
        asuntos = asunto;

        // --- CONEXIÓN CON TU MÓDULO (CONSOLIDADOS EN DATOSGLOBALES Y ARCHIVO) ---
        if (totalExpedientes < CapacidadMaxima)
        {
            codigos[totalExpedientes] = "EXP-" + (totalExpedientes + 1).ToString("D3");
            DatosExpedientes.dni[totalExpedientes] = dni;
            DatosExpedientes.nombres[totalExpedientes] = nombre + " " + apellido;
            DatosExpedientes.correos[totalExpedientes] = correo;
            DatosExpedientes.asuntos[totalExpedientes] = asunto;

            totalExpedientes++;

            // Llamamos a tu método para guardar en el .txt
            ArchivoExpedientes.GuardarEnArchivo();
        }

        Console.WriteLine("Expediente registrado exitosamente.");
        Console.WriteLine($"Total de expedientes registrados: {totalExpedientes}");
    }
}