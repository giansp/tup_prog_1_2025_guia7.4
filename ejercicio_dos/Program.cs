using System;

namespace SistemaEstacionamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            int tarifaMoto, tarifaAuto, tarifaUtilitario, tarifaCamion;
            double totalGlobal, recMotosG, recAutosG, recUtilitG, recCamionesG;
            int cantMotosG, cantAutosG, cantUtilitG, cantCamionesG, zonas, zonaActual;
            int cantMotos, cantAutos, cantUtilit, cantCamiones;
            double recMotos, recAutos, recUtilit, recCamiones, recZona;
            int opcion, horas, totalVeh;
            bool continuar;

            tarifaMoto = 100;
            tarifaAuto = 200;
            tarifaUtilitario = 250;
            tarifaCamion = 700;
            totalGlobal = 0;
            cantMotosG = 0;
            cantAutosG = 0;
            cantUtilitG = 0;
            cantCamionesG = 0;
            recMotosG = 0;
            recAutosG = 0;
            recUtilitG = 0;
            recCamionesG = 0;
            Console.WriteLine("Ingrese cantidad de zonas:");
            zonas = Convert.ToInt32(Console.ReadLine());

            for (zonaActual = 1; zonaActual <= zonas; zonaActual++)
            {
                cantMotos = 0;
                cantAutos = 0;
                cantUtilit = 0;
                cantCamiones = 0;
                recMotos = 0;
                recAutos = 0;
                recUtilit = 0;
                recCamiones = 0;
                continuar = true;

                Console.WriteLine($"ZONA {zonaActual}");

                while (continuar)
                {
                    Console.WriteLine("1.Moto 2.Auto 3.Utilitario 4.Camion 0.Terminar");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    if (opcion == 0)
                    {
                        continuar = false;
                    }
                    else
                    {
                        if (opcion >= 1 && opcion <= 4)
                        {
                            Console.WriteLine("Horas:");
                            horas = Convert.ToInt32(Console.ReadLine());

                            if (horas > 0)
                            {
                                switch (opcion)
                                {
                                    case 1:
                                        cantMotos++;
                                        recMotos += (horas * tarifaMoto);
                                        break;
                                    case 2:
                                        cantAutos++;
                                        recAutos += (horas * tarifaAuto);
                                        break;
                                    case 3:
                                        cantUtilit++;
                                        recUtilit += (horas * tarifaUtilitario);
                                        break;
                                    case 4:
                                        cantCamiones++;
                                        recCamiones += (horas * tarifaCamion);
                                        break;
                                }
                            }
                        }
                    }
                }

                recZona = recMotos + recAutos + recUtilit + recCamiones;
                Console.WriteLine($"Recaudacion Zona {zonaActual}: ${recZona}");

                totalGlobal += recZona;
                cantMotosG += cantMotos;
                cantAutosG += cantAutos;
                cantUtilitG += cantUtilit;
                cantCamionesG += cantCamiones;
                recMotosG += recMotos;
                recAutosG += recAutos;
                recUtilitG += recUtilit;
                recCamionesG += recCamiones;
            }

            Console.WriteLine($"TOTAL RECAUDADO: ${totalGlobal}");

            totalVeh = cantMotosG + cantAutosG + cantUtilitG + cantCamionesG;

            if (totalVeh > 0)
            {
                Console.WriteLine($"Motos: {(double)cantMotosG / totalVeh * 100:F2}%");
                Console.WriteLine($"Autos: {(double)cantAutosG / totalVeh * 100:F2}%");
                Console.WriteLine($"Utilitarios: {(double)cantUtilitG / totalVeh * 100:F2}%");
                Console.WriteLine($"Camiones: {(double)cantCamionesG / totalVeh * 100:F2}%");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        } 
    }
}