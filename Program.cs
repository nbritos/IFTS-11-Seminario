using System;

namespace SeminarioUnidad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int salir = -1;
            do
            {
                try
                {
                    salir = -1;
                    Console.WriteLine("Ingrese un valor numérico");
                    numero = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese un valor <> de cero para terminar");
                    salir = Convert.ToInt32(Console.ReadLine());

                }
                catch (FormatException f)
                {
                    Console.WriteLine("Se ha lanzado format");
                    Console.WriteLine(f.Message);
                    Console.WriteLine(f.Source);
                    Console.WriteLine(f.InnerException);
                    Console.WriteLine(f.StackTrace);
                    Console.WriteLine(f.TargetSite);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Se ha lanzado general");
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.Source);
                    Console.WriteLine(e.InnerException);
                    Console.WriteLine(e.StackTrace);
                    Console.WriteLine(e.TargetSite);
                    salir = 0;
                }

            } while (salir==0);
        }
    }
}
