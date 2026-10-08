Console.WriteLine("MOTOR DE CORRIENTE DIRECTA");
Console.WriteLine();

                                                                      // Crear un objeto de la clase Motor
Motor motor1 = new Motor();

                                                                     // Capturar la información del objeto
Console.Write("Ingrese el identificador del motor: ");
motor1.Identificador = Console.ReadLine() ?? "Sin identificador";

Console.Write("Ingrese el voltaje de alimentación (V): ");
motor1.Voltaje = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la corriente consumida (A): ");
motor1.Corriente = Convert.ToDouble(Console.ReadLine());

                                                                   // Solicitar al objeto que calcule su potencia
double potencia = motor1.CalcularPotencia();

                                                                     // Mostrar resultados
Console.WriteLine();
Console.WriteLine($"Motor: {motor1.Identificador}");
Console.WriteLine($"Voltaje: {motor1.Voltaje:F2} V");
Console.WriteLine($"Corriente: {motor1.Corriente:F2} A");
Console.WriteLine($"Potencia: {potencia:F2} W");
Console.WriteLine($"Estado: {motor1.ObtenerEstado()}");

                                                                     // Definición de la clase
class Motor
{
                                                                     // Propiedades
    public string Identificador { get; set; } = "";

    public double Voltaje { get; set; }

    public double Corriente { get; set; }

                                                                   // Método para calcular la potencia
    public double CalcularPotencia()
    {
        double potencia;

        potencia = Voltaje * Corriente;

        return potencia;
    }

                                                                 // Método para determinar el estado
    public string ObtenerEstado()
    {
        double potencia = CalcularPotencia();

        if (potencia <= 120.0)
        {
            return "Consumo normal";
        }
        else
        {
            return "Consumo elevado";
        }
    }
}