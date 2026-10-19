public static class DatosExpedientes
{
    public const int CapacidadMaxima = 100;

    // Un mismo índice relaciona los cinco datos de un expediente.
    public static string[] codigos = new string[CapacidadMaxima];
    public static string[] dni = new string[CapacidadMaxima];
    public static string[] nombres = new string[CapacidadMaxima];
    public static string[] correos = new string[CapacidadMaxima];
    public static string[] asuntos = new string[CapacidadMaxima];

    public static int totalExpedientes = 0;
}
