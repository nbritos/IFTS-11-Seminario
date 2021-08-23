using System;
using System.Collections.Generic;

namespace SeminarioUnidad1
{
    class Ejecutora
    {
        static void Main(string[] args)
        {
            List<Alumno> listaalumno = new();
            int menu = 1;

            while (menu != 0)
            {
                menu=muestraMenu();

                switch (menu)
                {
                    case 1:
                        menu1(listaalumno);
                        break;

                    case 2:
                        menu2(listaalumno);
                        break;

                    case 3:
                        menu3(listaalumno);
                        break;

                    case 0:
                        despedida();
                        break;

                    default:
                        Console.WriteLine("opcion incorrecta");
                        break;
                }
            }

            static void menu1(List<Alumno> listaalumno)
            {
                
                int salir = 0;
                string var1, var2;
                DateTime var3 = new();
                int var4;

                do
                {
                    Console.WriteLine("Ingrese nombre del alumno ");
                    var1 = Console.ReadLine();
                    Console.WriteLine("Ingrese apellido del alumno ");
                    var2 = Console.ReadLine();
                    Console.WriteLine("Ingrese fecha de nacimiento (format...) ");
                    try
                    {
                        var3 = Convert.ToDateTime(Console.ReadLine());
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Formato inválido");
                        Console.WriteLine(e.Message);
                        var3 = DateTime.Now;

                    }
                    catch (OverflowException e)
                    {
                        Console.WriteLine("excepción overflow");
                        Console.WriteLine(e.Message);
                        var3 = DateTime.Now;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("genérico");
                        Console.WriteLine(e.Message);
                        var3 = DateTime.Now;
                    }

                    Console.WriteLine("Ingrese DNI del alumno ");
                    var4 = int.Parse(Console.ReadLine());
                    listaalumno.Add(new Alumno(var1, var2, var3, var4));
                    Console.WriteLine("salir?");
                    salir = int.Parse(Console.ReadLine());

                } while (salir != 0);
            }

            static void menu2(List<Alumno> listaalumno)
            {
                int alumDocumento = 0;
                Console.WriteLine("Ingrese DNI a remover");
                try
                {
                    alumDocumento = int.Parse(Console.ReadLine());
                }
                catch (FormatException f)
                {
                    Console.WriteLine(f.Message);
                    //alumDocumento = 0;
                }
                catch (ArgumentNullException nul)
                {
                    Console.WriteLine(nul.Message);
                    //alumDocumento = 0;
                }
                catch (OutOfMemoryException oomemo)
                {
                    Console.WriteLine(oomemo.Message);
                    //alumDocumento = 0;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    //alumDocumento = 0;
                }

                Alumno aRemover = listaalumno.Find(x => x.Documento == alumDocumento);
                if (aRemover != null)
                {
                    listaalumno.Remove(aRemover);
                    Console.WriteLine($"Alumno {aRemover.Apellido} removido de la lista");
                }
            }
            
            static void menu3(List<Alumno> listaalumno)
            {
                foreach (Alumno alum in listaalumno)
                {
                    Console.WriteLine(alum.ToString() + "\n");
                }
            }

            static int muestraMenu()
            {

                int menu = 0;
                Console.WriteLine("1. Cargar alumno - - -\t2. Eliminar segun DNI - - -\t3. Mostrar todos los alumnos de la lista - - -\t0. SALIR");
                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Formato inválido");
                    Console.WriteLine(e.Message);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("excepción overflow");
                    Console.WriteLine(e.Message);
                }
                catch (SystemException e)
                {
                    Console.WriteLine("system except");
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("excepción genérica");
                    Console.WriteLine(e.Message);
                }
                return menu;
            }

            static void despedida()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Esto es to-to-todo amigos");
                Console.ResetColor();
                Console.ReadKey(true);
            }
        }
    }
}
