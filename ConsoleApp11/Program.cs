using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuál es su código");
            Console.WriteLine("(1)101");
            Console.WriteLine("(2)102");
            Console.WriteLine("(3)103");
            string codigoTexto = Console.ReadLine();

            Console.WriteLine("Cuántas unidades adquirio");
            string unidadesTexto = Console.ReadLine();

            float codigo = float.Parse(codigoTexto);
            float unidades = float.Parse(unidadesTexto);

            switch (codigo)
            {
                case 1:
                    if (unidades > 0 && unidades <= 10)
                    {
                        float total1 = 17.5f * unidades;
                        float dsct = total1 * 0.05f;
                        float total2 = total1 - dsct;
                        float total3 = total2 + (total2 * 0.18f);
                        Console.WriteLine("El precio unitario es: 17.5 soles");
                        Console.WriteLine("El importe de compra es: " + total1 + " soles");
                        Console.WriteLine("El descuento es: " + dsct + " soles");
                        Console.WriteLine("El importe a pagar es: " + total2 + " soles");
                        Console.WriteLine("El total + IGV es: " + total3 + " soles");
                    }
                    else if (unidades >= 11 && unidades <= 20)
                    {
                        float total1 = 17.5f * unidades;
                        float dsct = total1 * 0.075f;
                        float total2 = total1 - dsct;
                        float total3 = total2 + (total2 * 0.18f);
                        Console.WriteLine("El precio unitario es: 17.5 soles");
                        Console.WriteLine("El importe de compra es: " + total1 + " soles");
                        Console.WriteLine("El descuento es: " + dsct + " soles");
                        Console.WriteLine("El importe a pagar es: " + total2 + " soles");
                        Console.WriteLine("El total + IGV es: " + total3 + " soles");
                    }
                    else
                    {
                        float total1 = 17.5f * unidades;
                        float dsct = total1 * 0.10f;
                        float total2 = total1 - dsct;
                        float total3 = total2 + (total2 * 0.18f);
                        Console.WriteLine("El precio unitario es: 17.5 soles");
                        Console.WriteLine("El importe de compra es: " + total1 + " soles");
                        Console.WriteLine("El descuento es: " + dsct + " soles");
                        Console.WriteLine("El importe a pagar es: " + total2 + " soles");
                        Console.WriteLine("El total + IGV es: " + total3 + " soles");
                    }
                    break;
                case 2:
                    if (unidades > 0 && unidades <= 10)
                    {
                        float total1 = 25f * unidades;
                        float dsct = total1 * 0.05f;
                        float total2 = total1 - dsct;
                        float total3 = total2 + (total2 * 0.18f);
                        Console.WriteLine("El precio unitario es: 25 soles");
                        Console.WriteLine("El importe de compra es: " + total1 + " soles");
                        Console.WriteLine("El descuento es: " + dsct + " soles");
                        Console.WriteLine("El importe a pagar es: " + total2 + " soles");
                        Console.WriteLine("El total + IGV es: " + total3 + " soles");
                    }
                    else if (unidades >= 11 && unidades <= 20)
                    {
                        float total1 = 25f * unidades;
                        float dsct = total1 * 0.075f;
                        float total2 = total1 - dsct;
                        float total3 = total2 + (total2 * 0.18f);
                        Console.WriteLine("El precio unitario es: 25 soles");
                        Console.WriteLine("El importe de compra es: " + total1 + " soles");
                        Console.WriteLine("El descuento es: " + dsct + " soles");
                        Console.WriteLine("El importe a pagar es: " + total2 + " soles");
                        Console.WriteLine("El total + IGV es: " + total3 + " soles");
                    }
                    else
                    {
                        float total1 = 25f * unidades;
                        float dsct = total1 * 0.10f;
                        float total2 = total1 - dsct;
                        float total3 = total2 + (total2 * 0.18f);
                        Console.WriteLine("El precio unitario es: 25 soles");
                        Console.WriteLine("El importe de compra es: " + total1 + " soles");
                        Console.WriteLine("El descuento es: " + dsct + " soles");
                        Console.WriteLine("El importe a pagar es: " + total2 + " soles");
                        Console.WriteLine("El total + IGV es: " + total3 + " soles");
                    }
                    break;
                case 3:
                    if (unidades > 0 && unidades <= 10)
                    {
                        float total1 = 15.5f * unidades;
                        float dsct = total1 * 0.05f;
                        float total2 = total1 - dsct;
                        float total3 = total2 + (total2 * 0.18f);
                        Console.WriteLine("El precio unitario es: 15.5 soles");
                        Console.WriteLine("El importe de compra es: " + total1 + " soles");
                        Console.WriteLine("El descuento es: " + dsct + " soles");
                        Console.WriteLine("El importe a pagar es: " + total2 + " soles");
                        Console.WriteLine("El total + IGV es: " + total3 + " soles");
                    }
                    else if (unidades >= 11 && unidades <= 20)
                    {
                        float total1 = 15.5f * unidades;
                        float dsct = total1 * 0.075f;
                        float total2 = total1 - dsct;
                        float total3 = total2 + (total2 * 0.18f);
                        Console.WriteLine("El precio unitario es: 15.5 soles");
                        Console.WriteLine("El importe de compra es: " + total1 + " soles");
                        Console.WriteLine("El descuento es: " + dsct + " soles");
                        Console.WriteLine("El importe a pagar es: " + total2 + " soles");
                        Console.WriteLine("El total + IGV es: " + total3 + " soles");
                    }
                    else
                    {
                        float total1 = 15.5f * unidades;
                        float dsct = total1 * 0.10f;
                        float total2 = total1 - dsct;
                        float total3 = total2 + (total2 * 0.18f);
                        Console.WriteLine("El precio unitario es: 15.5 soles");
                        Console.WriteLine("El importe de compra es: " + total1 + " soles");
                        Console.WriteLine("El descuento es: " + dsct + " soles");
                        Console.WriteLine("El importe a pagar es: " + total2 + " soles");
                        Console.WriteLine("El total + IGV es: " + total3 + " soles");
                    }
                    break;

            }

            Console.ReadKey();

        }
    }
}
