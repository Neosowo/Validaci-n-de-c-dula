using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace VALIDACION_DE_CEDULA__EY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CEDULA x = new CEDULA();
            Console.WriteLine("Bienvenido/a al programa de validación de cedula :D!");
            x.Recepcion();
            Console.WriteLine("HECHO POR ERICK YANEZ");
            Console.ReadKey(true);
        }
    }
    public class CEDULA
    {
        public string Recepcion()
        {
            CEDULA x = new CEDULA();
            Console.WriteLine("" + "Ingrese su cedula:");
            string ci = Console.ReadLine();
            while (!EsSoloNumeros(ci))
            {
                Console.WriteLine("La cedula debe contener solo números. \nIntentelo nuevamente:");
                ci = Console.ReadLine();
            }
            Capturacion(ci);
            return ci;
        }
        static bool EsSoloNumeros(string ci)
        {
            foreach (char caracter in ci)
            {
                if (!char.IsNumber(caracter))
                {
                    return false;
                }
            }

            return true;
        }
        public string Capturacion(string ci)
        {
            CEDULA x = new CEDULA();
            while (ci.Length < 10 || ci.Length > 10)
            {
                Console.WriteLine("Su cedula no es valida!, debe tener diez digitos" + "\n");
                x.Recepcion();
            }
            string a2 = ci.Substring(0, 2);
            char a3 = ci.Substring(2, 1)[0];
            Validacion(ci, a2, a3);
            return a2;

        }
        public string Validacion(string ci, string a2, char a3)
        {
            CEDULA x = new CEDULA();
            int X1 = Convert.ToInt32(a2);
            char c66 = '\u0036'; //Como es char lo pone en ASCII algo asi, por eso puse esto xD
            while (X1 > 24)
            {
                Console.WriteLine("Su cedula no es valida!, fuera de limite de provincias" + "\n");
                x.Recepcion();
            }
            while (a3 > c66)
            {
                Console.WriteLine("Su cedula no es valida!, tercer digito no valido" + "\n");
                x.Recepcion();
            }
            if (ci.Length == 10)
            {
                //Arreglo tipo char para separar cada caracter
                char[] cisp = ci.ToCharArray();

                //Ubicacion de variable
                char c1 = (cisp[0]);
                char c2 = (cisp[1]);
                char c3 = (cisp[2]);
                char c4 = (cisp[3]);
                char c5 = (cisp[4]);
                char c6 = (cisp[5]);
                char c7 = (cisp[6]);
                char c8 = (cisp[7]);
                char c9 = (cisp[8]);
                char c10 = (cisp[9]);

                //Asignación de variable
                int n1 = int.Parse(c1.ToString());
                n1 = n1 * 2;
                int n2 = int.Parse(c2.ToString());
                int n3 = int.Parse(c3.ToString());
                n3 = n3 * 2;
                int n4 = int.Parse(c4.ToString());
                int n5 = int.Parse(c5.ToString());
                n5 = n5 * 2;
                int n6 = int.Parse(c6.ToString());
                int n7 = int.Parse(c7.ToString());
                n7 = n7 * 2;
                int n8 = int.Parse(c8.ToString());
                int n9 = int.Parse(c9.ToString());
                int n10 = int.Parse(c10.ToString());
                n9 = n9 * 2;

                if (n1 >= 10)
                {
                    n1 = n1 - 9;
                }
                if (n3 >= 10)
                {
                    n3 = n3 - 9;
                }
                if (n5 >= 10)
                {
                    n5 = n5 - 9;
                }
                if (n7 >= 10)
                {
                    n7 = n7 - 9;
                }
                if (n9 >= 10)
                {
                    n9 = n9 - 9;
                }
                int uwu = 0; int nt = 0;
                int[] array_suma =
                {
                    n1, n2, n3, n4, n5, n6, n7, n8, n9
                };

                while (uwu < array_suma.Length)
                {
                    nt += array_suma[uwu];
                    uwu++;
                }

                //Esto redondea un número hacia arriba uwu
                int op = (int)Math.Ceiling((double)nt / 10) * 10; 
                int qw = op - nt;
            
                //Por si sale negativo, aunque es imposible B)
                if (qw < 0)
                {
                    qw = qw * -1;
                }
                else if (qw == n10)
                {
                    Console.WriteLine("\n"+ "Cedula valida!");
                    Provincias(ci, a2, X1);
                }
                while (nt != qw)
                {
                    Console.WriteLine("Su cedula no es valida!, operación incorrecta" + "\n" );
                    x.Recepcion();
                }

            }
            return ci;
        }              
        public void Provincias(string ci, string a2, int a1)
        {
            CEDULA x = new CEDULA();
            Console.WriteLine(" ");
            switch (a1)
            {
                case (1):
                    Console.WriteLine(" - " + ci + " comienza con 0" + a1 + ", por ello es de Azuay");
                    break;
                case (2):
                    Console.WriteLine(" - " + ci + " comienza con 0" + a1 + ", por ello es de Bolivar");
                    break;
                case (3):
                    Console.WriteLine(" - " + ci + " comienza con 0" + a1 + ", por ello su C.I. es de Cañar");
                    break;
                case (4):
                    Console.WriteLine(" - " + ci + " comienza con 0" + a1 + ", por ello su C.I. es de Carchi");
                    break;
                case (5):
                    Console.WriteLine(" - " + ci + " comienza con 0" + a1 + ", por ello su C.I. es de Cotopaxi");
                    break;
                case (6):
                    Console.WriteLine(" - " + ci + " comienza con 0" + a1 + ", por ello su C.I. es de Chimborazo");
                    break;
                case (7):
                    Console.WriteLine(" - " + ci + " comienza con 0" + a1 + ", por ello su C.I. es de El Oro");
                    break;
                case (8):
                    Console.WriteLine(" - " + ci + " comienza con 0" + a1 + ", por ello su C.I. es de Esmeraldas");
                    break;
                case (9):
                    Console.WriteLine(" - " + ci + " comienza con 0" + a1 + ", por ello su C.I. es de Guayas");
                    break;
                case (10):
                    Console.WriteLine(" - " + ci + " comienza con " + a1 + ", por ello su C.I. es de Imbabura");
                    break;
                case (11):
                    Console.WriteLine(" - " + ci + " comienza con " + a1 + ", por ello su C.I. es de Loja");
                    break;
                case (12):
                    Console.WriteLine(" - " + ci + " comienza con " + a1 + ", por ello su C.I. es de Los Ríos");
                    break;
                case (13):
                    Console.WriteLine(" - " + ci + " comienza con " + a1 + ", por ello su C.I. es de Manabí");
                    break;
                case (14):
                    Console.WriteLine(" - " + ci + " comienza con " + a1 + ", por ello su C.I. es de Morona Santiago");
                    break;
                case (15):
                    Console.WriteLine(" - " + ci + " comienza con " + a1 + ", por ello su C.I. es de Napo");
                    break;
                case (16):
                    Console.WriteLine(" - " + ci + " comienza con " + a1 + ", por ello su C.I. es de Pastaza");
                    break;
                case (17):
                    Console.WriteLine(" - " + ci + " comienza con " + a1 + ", por ello su C.I. es de Pichincha");
                    break;
                case (18):
                    Console.WriteLine(" - " + ci + " comienza con " + a1 + ", por ello su C.I. es de Tungurahua");
                    break;
                case (19):
                    Console.WriteLine(" - " + ci + " comienza con " + a1 + ", por ello su C.I. es de Zamora Chinchipe");
                    break;
                case (20):
                    Console.WriteLine(" - " + ci + " comienza con " + a1 + ", por ello su C.I. es de Galápagos");
                    break;
                case (21):
                    Console.WriteLine(" - " + ci + " comienza con " + a1 + ", por ello su C.I. es de Sucumbíos");
                    break;
                case (22):
                    Console.WriteLine(" - " + ci + " comienza con " + a1 + ", por ello su C.I. es de Orellana");
                    break;
                case (23):
                    Console.WriteLine(" - " + ci + " comienza con " + a1 + ", por ello su C.I. es de Santo Domingo de los Tsáchilas");
                    break;
                case (24):
                    Console.WriteLine(" - " + ci + " comienza con " + a1 + ", por ello su C.I. es de Santa Elena");
                    break;
            }
            Console.WriteLine(" " + "\n¿Quiere validad otra cedula? (Ingresando el número)" + "\n1. Si" + "\n2. No");
            string op = Console.ReadLine();
            while(op != "1" && op != "2") 
            {
                Console.WriteLine("Valor incorrecto!, intentelo nuevamente");
                op = Console.ReadLine();
            }
            if(op == "1")
            {
                x.Recepcion();
            }
            else if(op == "2")
            {
                Console.WriteLine("Cerrando...");
                Thread.Sleep(1000);
                Environment.Exit(1);
            }
        }
    }
}
