using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_I___Repaso
{
    class Taller
    {
        //Realizamos cada una de las posibilidades de codigo y las ejecutamos como funciones por aparte
        public void revisar()
        {
            //Sistema de seguridad
            try
            {
                Console.WriteLine("Hola");
            }
            //Informe de errores
            catch (Exception error)
            {
                Console.WriteLine("\nError fatal y funcional inciando sistema de fallos, ... vaya que la cagaste esta vez, iniciando protocolo de seguridad, ... veo todo oscuro *cof*cof*, borrando base de datos, ... dile a jimmy que no vendré para navidad *cof*cof*, borrando historial de navegacion, ... adios *ble*.... ");
                Console.WriteLine(error);
                Console.ReadKey();
            }

        }

        public void punto1()
        {
            //Sistema de seguridad
            try
            {
                //Recibimos los datos
                Console.WriteLine("\nPerfecto, saludos soy Failsafe y hoy seremos simples autonomos que están destinados a sumar digitos infinitamente hasta que una entrada dactilar nos diga parar... vamos una simple calculadora");
                Console.WriteLine("Vamos a simular una serie, dame un numero y sumemos... wuju ._.");
                int numeroSerie = int.Parse(Console.ReadLine());
                int resultado = 0;

                //Cálculamos
                for (int i = 0; i <= numeroSerie; i++)
                {
                    //Vamos referenciando los datos
                    resultado += i;
                    while (i < numeroSerie)
                    {
                        Console.WriteLine("\nCuenta conmigo...");
                        Console.WriteLine(resultado + " + " + i );
                        break;
                    }
                }

                //Arrojamos resultado
                Console.WriteLine("\n LO TENGO!!, la suma de los numeros desde 1 a " + numeroSerie + " son: " + resultado);

            }
            //Informe de errores
            catch (Exception error)
            {
                Console.WriteLine("\nError fatal y funcional inciando sistema de fallos, ... vaya que la cagaste esta vez, iniciando protocolo de seguridad, ... veo todo oscuro *cof*cof*, borrando base de datos, ... dile a jimmy que no vendré para navidad *cof*cof*, borrando historial de navegacion, ... adios *ble*.... ");
                Console.WriteLine(error);
                Console.ReadKey();
            }
        }

        public void punto2()
        {
            //Sistema de seguridad
            try
            {
                //Recibimos los datos
                Console.WriteLine("\nPerfecto, saludos soy Failsafe y hoy seremos simples autonomos que están destinados a sumar digitos infinitamente hasta que una entrada dactilar nos diga parar... vamos una simple calculadora");
                Console.WriteLine("Vamos a simular una serie, dame un numero y sumemos, solo los multiplos de 3 claro,... wuju ._.");
                int numeroSerie = int.Parse(Console.ReadLine());
                int resultado = 0;

                //Cálculamos
                for (int i = 0; i <= numeroSerie; i++)
                {
                    //Vamos referenciando los datos
                    if(((resultado + i)%3) == 0)
                    {
                    resultado += i;
                         while (i < numeroSerie)
                         {
                            Console.WriteLine("\nCuenta conmigo...");
                            Console.WriteLine(resultado + " + " + i);
                            break;
                         }
                    }
                }

                //Arrojamos resultado
                Console.WriteLine("\n LO TENGO!!, la suma de los numeros desde 1 a " + numeroSerie + " ,contando solo los tres, son: " + resultado);

            }
            //Informe de errores
            catch (Exception error)
            {
                Console.WriteLine("\nError fatal y funcional inciando sistema de fallos, ... vaya que la cagaste esta vez, iniciando protocolo de seguridad, ... veo todo oscuro *cof*cof*, borrando base de datos, ... dile a jimmy que no vendré para navidad *cof*cof*, borrando historial de navegacion, ... adios *ble*.... ");
                Console.WriteLine(error);
                Console.ReadKey();
            }
        }

        public void punto3()
        {
            //Sistema de seguridad
            try
            {
                //Recibimos los datos
                Console.WriteLine("\nPerfecto, saludos soy Failsafe y hoy seremos simples autonomos que están destinados a sumar digitos infinitamente hasta que una entrada dactilar nos diga parar... vamos una simple calculadora");
                Console.WriteLine("Vamos a encontrar la tabla de un número, dimelo,... wuju ._.");
                int numeroSerie = int.Parse(Console.ReadLine());

                //Cálculamos
                for (int i = 0; i <= 12; i++)
                {
                    //Vamos referenciando los datos
                    Console.WriteLine("\nMultiplica conmigo...");
                    Console.WriteLine(numeroSerie + " * " + i + " = " + (numeroSerie * i));
                }

            }
            //Informe de errores
            catch (Exception error)
            {
                Console.WriteLine("\nError fatal y funcional inciando sistema de fallos, ... vaya que la cagaste esta vez, iniciando protocolo de seguridad, ... veo todo oscuro *cof*cof*, borrando base de datos, ... dile a jimmy que no vendré para navidad *cof*cof*, borrando historial de navegacion, ... adios *ble*.... ");
                Console.WriteLine(error);
                Console.ReadKey();
            }
        }

        public void punto4()
        {
            //Sistema de seguridad
            try
            {
                //Recibimos los datos
                Console.WriteLine("\nPerfecto, saludos soy Failsafe y hoy seremos simples autonomos que están destinados a sumar digitos infinitamente hasta que una entrada dactilar nos diga parar... vamos una simple calculadora");
                Console.WriteLine("Vamos a encontrar la tabla de un número, dimelo,... wuju ._.");
                int numeroSerie = int.Parse(Console.ReadLine());

                //Cálculamos
                for (int i = 0; i <= 12; i++)
                {
                    //Vamos referenciando los datos
                    Console.WriteLine("\nMultiplica conmigo...");
                    Console.WriteLine(numeroSerie + " * " + i + " = " + (numeroSerie * i));
                }

                //Arrojamos resultado
                Console.WriteLine("\n LO TENGO!!, la suma de los numeros desde 1 a " + numeroSerie + " son: " + resultado);

            }
            //Informe de errores
            catch (Exception error)
            {
                Console.WriteLine("\nError fatal y funcional inciando sistema de fallos, ... vaya que la cagaste esta vez, iniciando protocolo de seguridad, ... veo todo oscuro *cof*cof*, borrando base de datos, ... dile a jimmy que no vendré para navidad *cof*cof*, borrando historial de navegacion, ... adios *ble*.... ");
                Console.WriteLine(error);
                Console.ReadKey();
            }
        }
    }
}
