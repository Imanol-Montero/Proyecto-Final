using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola_Tabla_de_amortizacion
{
    class Program
    {
        private const string Value = "Monto del Prestamo \t";

        static void Main(string[] args)
        {
            //1

            float pago, Interes, Capital, MontoPrestamo, TasaAnual, TasaMensual;
            int  fila, Plazo, i;

            Console.Write("Monto Prestamo: ");
            float.TryParse(Console.ReadLine(), out MontoPrestamo);
            Console.Write("Interes Anual: ");
            float.TryParse(Console.ReadLine(), out TasaAnual);
            Console.Write("Plazo (Meses): ");
            int.TryParse(Console.ReadLine(), out Plazo);

           //2
            TasaMensual = (TasaAnual / 100) / 12;


            //3
            pago = TasaMensual + 1;
            pago = (float)Math.Pow(pago, Plazo);
            pago = pago - 1;
            pago = TasaMensual / pago;
            pago = TasaMensual + pago;
            pago = MontoPrestamo * pago;



           //4
            Console.WriteLine();
            fila = 1;
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(" Numero de Pago \t");
            Console.Write("Pago \t\t");
            Console.Write("Intereses Pagados \t\t");
            Console.Write("Capital Pagado \t\t");
            Console.Write(Value);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\t0");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t{0}", MontoPrestamo);

            //5
            for (i = 1; i <= Plazo; i++)
            {

             
             
                Console.Write("\t{0}\t\t", fila);

               
                Console.Write("{0}\t",pago);

               
                Interes = TasaMensual * MontoPrestamo;
                Console.Write("{0}\t\t",Interes);

               
                Capital = pago - Interes;
                Console.Write("\t{0}\t",Capital);

               
                MontoPrestamo = MontoPrestamo - Capital;
                Console.Write("\t{0}\t",MontoPrestamo);

                fila = fila + 1;
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}