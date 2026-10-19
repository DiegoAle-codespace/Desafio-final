
using System;
using static DatosExpedientes;

public static class OrdenamientoExpedientes
{
    public static void OrdenarExpedientes()
    {
        if (totalExpedientes < 2)
        {
            Console.WriteLine("\n[!] Se requieren al menos 2 expedientes para ordenar.");
            return;
        }

        for (int i = 0; i < totalExpedientes - 1; i++)
        {
            for (int j = i + 1; j < totalExpedientes; j++)
            {
                if (string.Compare(codigos[i], codigos[j],
                    StringComparison.Ordinal) > 0)
                {
                    string auxCod = codigos[i];
                    codigos[i] = codigos[j];
                    codigos[j] = auxCod;

                    string auxDni = dni[i];
                    dni[i] = dni[j];
                    dni[j] = auxDni;

                    string auxNom = nombres[i];
                    nombres[i] = nombres[j];
                    nombres[j] = auxNom;

                    string auxCor = correos[i];
                    correos[i] = correos[j];
                    correos[j] = auxCor;

                    string auxAsu = asuntos[i];
                    asuntos[i] = asuntos[j];
                    asuntos[j] = auxAsu;
                }
            }
        }

        Console.WriteLine("\n[✓] ¡Expedientes ordenados correctamente por Código!");

        for (int i = 0; i < totalExpedientes; i++)
        {
            Console.WriteLine(
                $"Código: {codigos[i]} | DNI: {dni[i]} | " +
                $"Nombre: {nombres[i]} | Correo: {correos[i]} | " +
                $"Asunto: {asuntos[i]}");
        }

        ArchivoExpedientes.GuardarEnArchivo();
    }
}
