using System;
using System.IO;
using static DatosExpedientes;

public static class ArchivoExpedientes
{
    private static string nombreArchivo = "expedientes.txt";

    public static void GuardarEnArchivo()
    {
        using (StreamWriter writer = new StreamWriter(nombreArchivo))
        {
            for (int i = 0; i < totalExpedientes; i++)
            {
                writer.WriteLine($"{codigos[i]}|{dni[i]}|{nombres[i]}|{correos[i]}|{asuntos[i]}");
            }
        }
    }

    public static void CargarDesdeArchivo()
    {
        if (File.Exists(nombreArchivo))
        {
            string[] lineas = File.ReadAllLines(nombreArchivo);
            totalExpedientes = 0; // reiniciamos el contador

            foreach (string linea in lineas)
            {
                string[] partes = linea.Split('|');

                if (partes.Length == 5)
                {
                    codigos[totalExpedientes] = partes[0];
                    dni[totalExpedientes] = partes[1];
                    nombres[totalExpedientes] = partes[2];
                    correos[totalExpedientes] = partes[3];
                    asuntos[totalExpedientes] = partes[4];
                    totalExpedientes++;
                }
            }
        }
    }
}