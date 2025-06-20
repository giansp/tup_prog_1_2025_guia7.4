using System.ComponentModel.Design;

namespace EncuestaTransporte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int encuestadores, i, opcion, encuestados, totalEncuestados = 0;
            int personasBici, personasMoto, personasAuto, personasPublico;
            double distanciaBici, distanciaMoto, distanciaAuto, distanciaPublico;
            bool bandera = true;
            double totalGeneralBici = 0, totalGeneralMoto = 0, totalGeneralAuto = 0, totalGeneralPublico = 0;
            double distanciaGeneralBici = 0, distanciaGeneralMoto = 0, distanciaGeneralAuto = 0, distanciaGeneralPublico = 0;

            Console.WriteLine("Cantidad de encuestadores(1-4):");
            encuestadores = Convert.ToInt32(Console.ReadLine());

            if (encuestadores >= 1 && encuestadores <= 4)
            {
                for (i = 1; i <= encuestadores; i++)
                {
                    personasBici = 0;
                    personasMoto = 0;
                    personasAuto = 0;
                    personasPublico = 0;
                    double distanciaLocalBici = 0;
                    double distanciaLocalMoto = 0;
                    double distanciaLocalAuto = 0;
                    double distanciaLocalPublico = 0;
                    encuestados = 0;
                    bandera = true;

                    Console.WriteLine("====== Encuestador " + i + "======");
                    while (bandera == true)
                    {
                        Console.WriteLine("Seleccione una opción:");
                        Console.WriteLine(" 1-Bicicleta     |   2-Motocicleta   |   3-Automóvil     |   4-Transporte publico    ");
                        Console.WriteLine(" Ingrese -1 para finalizar encuesta");
                        opcion = Convert.ToInt32(Console.ReadLine());
                        if (opcion == -1)
                        {
                            bandera = false;
                        }
                        else if (opcion >= 1 && opcion <= 4)
                        {
                            Console.WriteLine("Distancia recorrida en km:");
                            switch (opcion)
                            {
                                case 1:
                                    personasBici = personasBici + 1;
                                    distanciaBici = Convert.ToDouble(Console.ReadLine());
                                    distanciaLocalBici = distanciaLocalBici + distanciaBici;
                                    distanciaGeneralBici = distanciaGeneralBici + distanciaBici;
                                    break;
                                case 2:
                                    personasMoto = personasMoto + 1;
                                    distanciaMoto = Convert.ToDouble(Console.ReadLine());
                                    distanciaLocalMoto = distanciaLocalMoto + distanciaMoto;
                                    distanciaGeneralMoto = distanciaGeneralMoto + distanciaMoto;
                                    break;
                                case 3:
                                    personasAuto = personasAuto + 1;
                                    distanciaAuto = Convert.ToDouble(Console.ReadLine());
                                    distanciaLocalAuto = distanciaLocalAuto + distanciaAuto;
                                    distanciaGeneralAuto = distanciaGeneralAuto + distanciaAuto;
                                    break;
                                case 4:
                                    personasPublico = personasPublico + 1;
                                    distanciaPublico = Convert.ToDouble(Console.ReadLine());
                                    distanciaLocalPublico = distanciaLocalPublico + distanciaPublico;
                                    distanciaGeneralPublico = distanciaGeneralPublico + distanciaPublico;
                                    break;
                            }
                            encuestados = encuestados + 1;
                        }
                        else
                        {
                            Console.WriteLine("Opción no válida, intente nuevamente.");
                        }
                    }

                    Console.WriteLine("====== Encuesta finalizada para el encuestador " + i + "======");
                    Console.WriteLine("Total de encuestados: " + encuestados);

                    if (personasBici > 0)
                    {
                        Console.WriteLine("Total de personas que usan bicicleta: " + personasBici);
                        Console.WriteLine("Promedio de distancia recorrida en bicicleta: " + (distanciaLocalBici / personasBici) + " km");
                    }
                    else
                    {
                        Console.WriteLine("No se registraron personas que usan bicicleta.");
                    }
                    if (personasMoto > 0)
                    {
                        Console.WriteLine("Total de personas que usan motocicleta: " + personasMoto);
                        Console.WriteLine("Promedio de distancia recorrida en motocicleta: " + (distanciaLocalMoto / personasMoto) + " km");
                    }
                    else
                    {
                        Console.WriteLine("No se registraron personas que usan motocicleta.");
                    }
                    if (personasAuto > 0)
                    {
                        Console.WriteLine("Total de personas que usan automóvil: " + personasAuto);
                        Console.WriteLine("Promedio de distancia recorrida en automóvil: " + (distanciaLocalAuto / personasAuto) + " km");
                    }
                    else
                    {
                        Console.WriteLine("No se registraron personas que usan automóvil.");
                    }
                    if (personasPublico > 0)
                    {
                        Console.WriteLine("Total de personas que usan transporte público: " + personasPublico);
                        Console.WriteLine("Promedio de distancia recorrida en transporte público: " + (distanciaLocalPublico / personasPublico) + " km");
                    }
                    else
                    {
                        Console.WriteLine("No se registraron personas que usan transporte público.");
                    }

                    totalGeneralBici = totalGeneralBici + personasBici;
                    totalGeneralMoto = totalGeneralMoto + personasMoto;
                    totalGeneralAuto = totalGeneralAuto + personasAuto;
                    totalGeneralPublico = totalGeneralPublico + personasPublico;
                    totalEncuestados = totalEncuestados + encuestados;
                }

                Console.WriteLine("====== Encuesta finalizada para todos los encuestadores ======");
                Console.WriteLine("Total de encuestados: " + totalEncuestados);

                if (totalEncuestados > 0)
                {
                    Console.WriteLine("Porcentaje por tipo de transporte");
                    Console.WriteLine(" Bicicleta: " + (totalGeneralBici / totalEncuestados * 100.00) + "%");
                    Console.WriteLine(" Motocicleta: " + (totalGeneralMoto / totalEncuestados * 100.00) + "%");
                    Console.WriteLine(" Automóvil: " + (totalGeneralAuto / totalEncuestados * 100.00) + "%");
                    Console.WriteLine(" Transporte público: " + (totalGeneralPublico / totalEncuestados * 100.00) + "%");
                    Console.WriteLine("Promedio de distancia recorrida por tipo de transporte");
                    if (totalGeneralBici > 0)
                    {
                        Console.WriteLine(" Bicicleta: " + (distanciaGeneralBici / totalGeneralBici) + " km");
                    }
                    if (totalGeneralMoto > 0)
                    {
                        Console.WriteLine(" Motocicleta: " + (distanciaGeneralMoto / totalGeneralMoto) + " km");
                    }
                    if (totalGeneralAuto > 0)
                    {
                        Console.WriteLine(" Automóvil: " + (distanciaGeneralAuto / totalGeneralAuto) + " km");
                    }
                    if (totalGeneralPublico > 0)
                    {
                        Console.WriteLine(" Transporte público: " + (distanciaGeneralPublico / totalGeneralPublico) + " km");
                    }
                }
                else
                {
                    Console.WriteLine("No se registraron encuestados.");
                }
            }
            else
            {
                Console.WriteLine("Número de encuestadores no válido. Debe ser entre 1 y 4.");
            }
        }
    }
}
