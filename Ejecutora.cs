using System;
using System.Collections.Generic;

namespace SeminarioUnidad1
{
    class Ejecutora
    {

        static void Main(string[] args)
        {
            List<Alumno> listaalumno = new List<Alumno>();

            int salir=0;
            string var1, var2;
            DateTime var3 = new DateTime();
            int var4, menu = 1;


            while (menu!=0)
            {
                Console.WriteLine("1. Cargar alumno\t2. Eliminar segun DNI\t3. Mostrar todos los alumnos de la lista");
                switch (menu)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("Ingrese nombre del alumno ");
                            var1 = Console.ReadLine();
                            Console.WriteLine("Ingrese nombre del alumno ");
                            var2 = Console.ReadLine();
                            Console.WriteLine("Ingrese fecha de nacimiento (format...) ");
                            try
                            {
                                var3 = Convert.ToDateTime(Console.ReadLine());
                            }
                            catch (FormatException f1)
                            {
                                Console.WriteLine(f1.StackTrace);
                            }

                            Console.WriteLine("Ingrese DNI del alumno ");
                            var4 = int.Parse(Console.ReadLine());
                            listaalumno.Add(new Alumno(var1, var2, var3, var4));

                            Console.WriteLine("salir?");
                            salir = int.Parse(Console.ReadLine());

                        } while (salir != 0);
                        break;

                    case 2:
                        int alumDocumento;
                        Console.WriteLine("Ingrese apellido a remover");
                        alumDocumento = int.Parse(Console.ReadLine());

                        Alumno aRemover = listaalumno.Find(x => x.Documento == alumDocumento);
                        if (aRemover != null) listaalumno.Remove(aRemover);
                        break;

                    case 3:
                        foreach (Alumno alum in listaalumno)
                        {
                            Console.WriteLine(alum.ToString() + "\n");
                        }
                        break;

                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Esto es to-to-todos");
                        Console.ResetColor();
                        break;

                    default:
                        Console.WriteLine("opcion incorrecta");
                        break;
                }
            } 
        }
    }
}
