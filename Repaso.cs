using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_No1___Poo___Repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            //Seguridad ante errores
            try
            {
                //Repaso de Cast y Operadores
                string text1 = "Medellín";
                String text2 = "Medellín";
                DateTime hoy = DateTime.Today;

                float nmbrf = 0.0f;
                double nmbrd = 0.0d;
                int nmbri = 0, diceFace = 0;
                string nmbrTxt = "105";

                bool condicional = true;

                char character = 'C';
                short tiny;

                //Caracter
                if (Char.IsDigit(character)) Console.WriteLine("Es digito");
                else if (Char.IsLetter(character)) Console.WriteLine("Es letra");
                else if (Char.IsLower(character)) Console.WriteLine("Es minuscula");
                else if (Char.IsUpper(character)) Console.WriteLine("Es mayuscula");
                else Console.WriteLine("No es digito, ni letra");

                //Sacar el codigo ascii
                nmbri = (int)character;
                tiny = (short)character;

                //Conversion de valores númericos
                nmbrf = (float)nmbrd;
                nmbri = (int)nmbrf;

                //Conversion de valores de texto
                nmbri = Int32.Parse(nmbrTxt);
                text1 = nmbri.ToString();

                //Practica de DateTime
                Console.WriteLine(hoy);
                Console.WriteLine(hoy.ToString("d"));
                Console.WriteLine(hoy.ToString("D"));
                Console.WriteLine(hoy.ToString("g"));

                //ciclos
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(i);
                }

                nmbri = 5;

                while (nmbri >= 0)
                {
                    Console.WriteLine(nmbri);
                    nmbri--;
                }

                do
                    Console.WriteLine(nmbri);
                while (nmbri >= 0);

                //listas

                //Crear Lista
                    var fibNumeros = new List<int> { 0, 1, 1, 2, 3, 5, 8, 11 };

                nmbri = 0;
                
                //Navergar la lista
                foreach(int i in fibNumeros)
                {

                    Console.WriteLine(i);

                }

                //Adicionar a la lista
                fibNumeros.Add(19);

                //Navergar la lista
                foreach (int i in fibNumeros)
                {

                    Console.WriteLine(i);

                }

                //Vectores
                int[] score = new int[] { 96, 95, 92, 88 };
                string[] vectorTxt = new string[100];
                string[] days = { "Mon", "Thus", "Wen", "Thr", "Fri", "Sat", "Sun" };

                //Recorrer Vectores
                for (int i = 0; i < days.Length; i++)
                {
                    Console.WriteLine(days[i]);
                }

                foreach (string i in days)
                {
                    Console.WriteLine(i);
                }

                //matriz
                int[,] matriz1 = new int[5, 5];

                int[,] matriz2 = new int[,] { {4,5},{0,6},{8,7} };

                for (int i = 0; i < 3; i++)
                {
                    for (int o = 0; o < 2; o++)
                    {
                        Console.WriteLine(matriz2[i,o]);
                    }
                }

                //Mala Practica
                if (text1 == text2)
                {

                    Console.WriteLine("Son iguales");

                }
                else Console.WriteLine("No son Iguales");

                Console.ReadKey();

                //Buena Practica
                if (text1.Equals(text2))
                {

                    Console.WriteLine("Son iguales");

                }
                else Console.WriteLine("No son Iguales");

                Console.ReadKey();

                //Condicionales

                if (condicional) Console.WriteLine("Es verdadero");
                else Console.WriteLine("Es falso");

                if (!condicional) Console.WriteLine("Es verdadero");
                else Console.WriteLine("Es falso");

                if (condicional) Console.WriteLine(1);
                else if (!condicional) Console.WriteLine(2);
                else Console.WriteLine(3);

                switch (diceFace)
                {
                    case 1:
                        Console.WriteLine("Uno");
                        break;
                    case 2:
                        Console.WriteLine("Dos");
                        break;
                    case 3:
                        Console.WriteLine("tres");
                        break;
                    case 4:
                        Console.WriteLine("Cuatro");
                        break;
                    case 5:
                        Console.WriteLine("Cinco");
                        break;
                    case 6:
                        Console.WriteLine("Seis");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }

            }

            //Debugg de errores
            catch (Exception error)
            {
                Console.WriteLine(error);
                Console.ReadKey();
            }
        }
    }
}
