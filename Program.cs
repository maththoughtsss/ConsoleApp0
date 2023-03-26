namespace ConsoleApp0 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Declaración de Variables
            String? name, strNum1, strNum2, strNum3, status;
            double num1, num2, num3, sumScore, totalAvg; 

            //Inicio y Bienvenida del Programa
            Console.WriteLine("Bienvenido, cual es tu nombre?: ");
            name = Console.ReadLine();

            //Input - Ingreso de Datos
            Console.WriteLine("Ingrese la primera nota: ");
            strNum1 = Console.ReadLine();
            Console.WriteLine("Ingrese la segunda nota: ");
            strNum2 = Console.ReadLine();
            Console.WriteLine("Ingrese la tercera nota: ");
            strNum3 = Console.ReadLine();

            //Conversión de Datos
            double.TryParse(strNum1, out num1);
            double.TryParse(strNum2, out num2);
            double.TryParse(strNum3, out num3);

            //Suma y Promedio
            sumScore = num1 + num2 + num3;
            totalAvg = sumScore/3;

            //Sentencia
            if(totalAvg >= 4)
            {
                status = "Aprobado";
            }
            else
            {
                status = "Reprobado";
            }

            //Output
            Console.Write($"Estimado {name}, tu promedio es: {totalAvg}, su estatus es: {status}");
        }
    }
}