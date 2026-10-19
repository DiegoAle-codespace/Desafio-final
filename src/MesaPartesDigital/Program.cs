using System;

public static class Program
{
    public static void Main(string[] args)
    {
        ArchivoExpedientes.CargarDesdeArchivo();
        int opcDoc = 0;

        do
        {
            Console.WriteLine("\n===========================================================");
            Console.WriteLine("  MESA DE PARTES DIGITAL - MUNICIPALIDAD DE LOS OLIVOS");
            Console.WriteLine("===========================================================");
            Console.WriteLine("1. Registrar Expediente");
            Console.WriteLine("2. Buscar Expediente");
            Console.WriteLine("3. Ordenar Expedientes por Código");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            string entrada = Console.ReadLine();
            if (entrada == null)
            {
                Console.WriteLine("\nEntrada finalizada. Cerrando el sistema...");
                break;
            }

            if (!int.TryParse(entrada, out opcDoc))
            {
                Console.WriteLine("\n[!] Error: Debe ingresar un número entero válido.");
                continue;
            }

            switch (opcDoc)
            {
                case 1:
                    RegistroExpedientes.RegistrarExpediente();
                    break;
                case 2:
                    BusquedaExpedientes.BuscarExpediente();
                    break;
                case 3:
                    OrdenamientoExpedientes.OrdenarExpedientes();
                    break;
                case 4:
                    Console.WriteLine("\nCerrando el sistema de la Municipalidad de Los Olivos...");
                    break;
                default:
                    Console.WriteLine("\nOpción inválida, intente nuevamente.");
                    break;
            }
        } while (opcDoc != 4);
    }
}
