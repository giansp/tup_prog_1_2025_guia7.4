
namespace AgenciaLoteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tb_precio = 400, qs_precio = 800, tb2_precio = 750;
            int cant_tb_g = 0, cant_qs_g = 0, cant_tb2_g = 0;
            int vendedores = 0, v_actual = 0, mejor_vendedor = 0;
            int opcion = 0, cantidad = 0;
            double total_agencia = 0, rec_tb_g = 0, rec_qs_g = 0, rec_tb2_g = 0;
            double max_recaudacion = 0, cant_tb = 0, cant_qs = 0, cant_tb2 = 0;
            double rec_tb = 0, rec_qs = 0, rec_tb2 = 0, rec_total = 0;
            bool continuar = true;

            Console.WriteLine("Ingrese cantidad de vendedores (2 o 4): ");
            vendedores = Convert.ToInt32(Console.ReadLine());

            for (v_actual = 1; v_actual <= vendedores; v_actual++)
            {
                cant_tb = cant_qs = cant_tb2 = 0;
                rec_tb = rec_qs = rec_tb2 = 0;
                continuar = true;

                Console.WriteLine($"VENDEDOR {v_actual}");

                while (continuar)
                {
                    Console.WriteLine("1.TeleBingo 2.Quini6 3.TotoBingo 0.Terminar");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    if (opcion == 0)
                    {
                        continuar = false;
                    }
                    else if (opcion >= 1 && opcion <= 3)
                    {
                        Console.Write("Cantidad: ");
                        cantidad = Convert.ToInt32(Console.ReadLine());

                        if (cantidad > 0)
                        {
                            switch (opcion)
                            {
                                case 1:
                                    cant_tb += cantidad;
                                    rec_tb += cantidad * tb_precio;
                                    Console.WriteLine($"{cantidad} TeleBingo - Total: ${cantidad * tb_precio}");
                                    break;
                                case 2:
                                    cant_qs += cantidad;
                                    rec_qs += cantidad * qs_precio;
                                    Console.WriteLine($"{cantidad} Quini6 - Total: ${cantidad * qs_precio}");
                                    break;
                                case 3:
                                    cant_tb2 += cantidad;
                                    rec_tb2 += cantidad * tb2_precio;
                                    Console.WriteLine($"{cantidad} TotoBingo - Total: ${cantidad * tb2_precio}");
                                    break;
                            }
                        }
                    }
                }

                rec_total = rec_tb + rec_qs + rec_tb2;

                Console.WriteLine($"TOTAL VENDEDOR {v_actual}: ${rec_total}");
                Console.WriteLine($"TeleBingo: {cant_tb} - ${rec_tb}");
                Console.WriteLine($"Quini6: {cant_qs} - ${rec_qs}");
                Console.WriteLine($"TotoBingo: {cant_tb2} - ${rec_tb2}");

                total_agencia += rec_total;
                cant_tb_g += (int)cant_tb;
                cant_qs_g += (int)cant_qs;
                cant_tb2_g += (int)cant_tb2;
                rec_tb_g += rec_tb;
                rec_qs_g += rec_qs;
                rec_tb2_g += rec_tb2;

                if (rec_total > max_recaudacion)
                {
                    max_recaudacion = rec_total;
                    mejor_vendedor = v_actual;
                }
            }

            Console.WriteLine($"RECAUDACION AGENCIA: ${total_agencia}");
            Console.WriteLine($"TeleBingo: ${rec_tb_g} ({(rec_tb_g / total_agencia) * 100:F2}%)");
            Console.WriteLine($"Quini6: ${rec_qs_g} ({(rec_qs_g / total_agencia) * 100:F2}%)");
            Console.WriteLine($"TotoBingo: ${rec_tb2_g} ({(rec_tb2_g / total_agencia) * 100:F2}%)");
            Console.WriteLine($"MEJOR VENDEDOR: {mejor_vendedor} con ${max_recaudacion}");
        }
    }
}
