using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion_RLG
{
    internal class Ejercicios
    {
        //public void IntervaloDosNumeros()
        //{
        //    Console.WriteLine("Escriba el primer numero:");
        //    int numero1 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Escriba el segundo numero:");
        //    int numero2 = int.Parse(Console.ReadLine()); 

        //    if (numero1 != numero2 && numero1 < numero2)
        //    {
        //        Console.WriteLine($"La secuencia de los numeros es {numero1}");

        //        for (int i=0; numero1<numero2; i++)
        //        {
        //            numero1 += 1;
        //            Console.WriteLine($"La secuencia de los numeros es {numero1}");
        //        }
                
        //    }
        //    else if (numero1 != numero2 && numero1 > numero2)
        //    {
        //        Console.WriteLine($"La secuencia de los numeros es {numero1}");

        //        for (int i = 0; numero2 < numero1; i++)
        //        {
        //            numero1 -= 1;
        //            Console.WriteLine($"La secuencia de los numeros es {numero1}");
        //        }

        //    }
        //    else if (numero1== numero2)
        //    {
        //        Console.WriteLine("Los numeros ingresados son iguales y son estos: "+ numero1+" y "+numero2);
        //    }
        //}

        public void TablaMultiplicar(int numeroDado, int multi)
        {
            int multiplicacion;
            if (numeroDado > 0 && multi<=10) 
            {    
                 multiplicacion = numeroDado * multi;
                Console.WriteLine($"{numeroDado} * {multi} = {multiplicacion}");
                TablaMultiplicar(numeroDado, multi+1);
            }
        }
        public void CURP ()
        {
            Console.WriteLine("Ingrese su CURP(18 caracteres letras y numeros):");
            string curpPersona = Console.ReadLine();
            
            DateOnly fecha = DateOnly.ParseExact(curpPersona, "yy/MM/dd", CultureInfo.InvariantCulture);

            if (curpPersona.Length==18)
            {
                Console.WriteLine("Usted es de sexo femenino y su fecha de nacimiento es ");
            }
        }
    }
}
