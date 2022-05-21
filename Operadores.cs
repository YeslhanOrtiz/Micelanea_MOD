using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Micelanea_MOD
{
    public class Operadores
    {
        public static void operadores()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Elija la operación a realizar");
            Console.WriteLine("1. Calcular el area de un triangulo");
            Console.WriteLine("2. Suma de terminos");
            Console.WriteLine("3. Un número elvado al cuadradro (x^2)");
            Console.WriteLine("4. Conversor de Euros a Dolares");
            Console.WriteLine("5. Área y perímetro de un cuadrado");
            Console.WriteLine("6. Área y Volúmen de un cilindro");
            Console.WriteLine("7. Radio, longitud y area de un circulo");
            Console.WriteLine("8. Promedio de tres números");
            Console.WriteLine("9. Salir");
            Console.WriteLine("-------------------------------");
        }
        public static void op_1(int num1, int num2)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Ingrese el primer número entero: ");
            num1 = (int)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número entero: ");
            num2 = (int)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("El area del triángulo es: ");
            Console.WriteLine((num1 * num2) / 2);
            Console.WriteLine("-------------------------------");
        }
        public static void op_2(int num1, int num2)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Ingrese el primer número entero: ");
            num1 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número entero: ");
            num2 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("La suma de los dos números enteros es: ");
            Console.WriteLine(num1 + num2);
            Console.WriteLine("-------------------------------");
        }
        public static void op_3(int num1)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Ingrese el primer número entero: ");
            num1 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El Numero elevado al cuadrado es: ");
            Console.WriteLine(Math.Pow(num1, 2));
            Console.WriteLine("-------------------------------");
        }
        public static void op_4(int num1)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Ingrese el número de Euros: ");
            num1 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Número de Dolares: ");
            Console.WriteLine(num1 * 1.06);
            Console.WriteLine("-------------------------------");
        }
        public static void op_5(int num1)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Ingrese la medida de un lado del cuadrado: ");
            num1 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El área del cuadrado es: ");
            Console.WriteLine(Math.Pow(num1, 2) + "cm2");
            Console.WriteLine("El perímetro del cuadrado es: ");
            Console.WriteLine(num1 + num1 + num1 + num1 + "cm");
            Console.WriteLine("-------------------------------");
        }
        public static void op_6(int num1, int num2)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Ingrese el radio del cilindro: ");
            num1 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del cilindro: ");
            num2 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El area del cilindro es: ");
            Console.WriteLine(2 * Math.PI * num1 * (num1 * num2));
            Console.WriteLine("El volúmen del cilindro es: ");
            Console.WriteLine((Math.PI * num1 * num1 * num2) + "cm3");
            Console.WriteLine("-------------------------------");
        }
        public static void op_7(int num1, int num2)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Ingrese el diametro de la circunferencia: ");
            num1 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("----------");
            Console.WriteLine("El radio de la circunferencia es: ");
            Console.WriteLine(num2 = num1 / 2);
            Console.WriteLine("La longitud de la circunferencia es: ");
            Console.WriteLine(2 * Math.PI * num2);
            Console.WriteLine("El área de la circunferencia es: ");
            Console.WriteLine(Math.PI * Math.Pow(num2, 2));
            Console.WriteLine("-------------------------------");
        }
        public static void op_8(int num1, int num2, int num3)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Ingrese el primer número entero: ");
            num1 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número entero: ");
            num2 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero entero: ");
            num3 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El promedio es: ");
            Console.WriteLine((num1 + num2 + num3) / 3);
            Console.WriteLine("-------------------------------");
        }
        public static void op_def()
        {
            Console.WriteLine("Dato incorrecto");
            Console.WriteLine("saliendo del programa");
        }
    }
}
