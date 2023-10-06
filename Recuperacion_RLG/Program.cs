namespace Recuperacion_RLG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicios ejercicios = new Ejercicios();
            //ejercicio de intervalo
            //ejercicios.IntervaloDosNumeros();

            //ejercicio de recursividad
            Console.WriteLine("Dame el numero a multiplicar: ");
            int numero = int.Parse(Console.ReadLine());
            int multi = 1;
            ejercicios.TablaMultiplicar(numero, multi);

            //curp
            //ejercicios.CURP();
        }
    }
}