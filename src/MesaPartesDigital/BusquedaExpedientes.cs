using System;
using static DatosExpedientes;

public static class BusquedaExpedientes
{
    public static void BuscarExpediente()
    {
        if (totalExpedientes == 0)
        {
            Console.WriteLine("\n[!] No hay expedientes registrados en el sistema.");
            return;
        }

        Console.WriteLine("\n--- BUSCAR EXPEDIENTE ---");
        Console.Write("Ingrese Código de Expediente o DNI: ");
        string busqueda = Console.ReadLine()?.Trim() ?? "";
        bool encontrado = false;

        // No usamos break: un DNI puede tener varios expedientes.
        for (int i = 0; i < totalExpedientes; i++)
        {
            if (string.Equals(codigos[i], busqueda, StringComparison.OrdinalIgnoreCase) ||
                string.Equals(dni[i], busqueda, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\n=== EXPEDIENTE ENCONTRADO ===");
                Console.WriteLine($"Código  : {codigos[i]}");
                Console.WriteLine($"DNI     : {dni[i]}");
                Console.WriteLine($"Nombre  : {nombres[i]}");
                Console.WriteLine($"Correo  : {correos[i]}");
                Console.WriteLine($"Asunto  : {asuntos[i]}");
                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("\n[!] Error: Expediente no registrado o datos incorrectos.");
        }
    }
}
