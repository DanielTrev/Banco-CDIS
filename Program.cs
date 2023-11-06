Console.WriteLine("\t-------------------------------------------------------------------------------------");
Console.WriteLine("\t---                                      <*(CDIS)*>                               ---");
Console.WriteLine("\t-------------------------------------------------------------------------------------");


int entero;

int num_r = 0;

int[] r = new int[10]; //r es la variable para el dinero que haya sido retirado

int aux_r = 0; //este es el auxiliar para acumular r

int sobrante = 0; // feria xd

int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0;

int m1 = 0, m2 = 0, m3 = 0;

int c_total = 0, m_total = 0;

// c1 y sus consecutivos son los casos para cada tipo de billete asignado por ejemplo c1 seria un billete de 500, c2 billetes 200
// m_totales son las monedas o el sobrante que no se pudiera cubir con billetes


while (true)
{
    Console.WriteLine("        -----                                                                           -----\n");
    Console.WriteLine("        ---           1.Ingresar la cantidad de retiros hechos por los usuarios.          ---\n");
    Console.WriteLine("        -----                                                                           -----\n");
    Console.WriteLine("        -------------------------------------------------------------------------------------");
    Console.WriteLine("        -----                                                                           -----\n");
    Console.WriteLine("        ---             2.Revisar la cantidad entregada de billetes y monedas.            ---\n");
    Console.WriteLine("        -----                                                                           -----\n");
    Console.WriteLine("        -------------------------------------------------------------------------------------");
    Console.WriteLine("        -----                                                                           -----\n");
    Console.WriteLine("        ---                                  Ingresa la opcion:                           ---\n");
    Console.WriteLine("        -----                                                                           -----\n");
    Console.WriteLine("        -------------------------------------------------------------------------------------\n");
    entero = int.Parse(Console.ReadLine());
    

    switch (entero)
    {

        case 1:
            Console.WriteLine("        -------------------------------------------------------------------------------------\n");
            Console.WriteLine("        -----                                                                           -----\n");
            Console.WriteLine("        ---                          ¿Cuantos retiros se realizaron?                      ---");
            Console.WriteLine("        -----                                                                           -----\n");
            Console.WriteLine("        -------------------------------------------------------------------------------------\n");

            num_r = int.Parse(Console.ReadLine());
      
            sobrante = num_r % 1;

            if (sobrante == 0 && num_r > 0 && num_r <= 10)
            {
                for (int i = 0; i < num_r; i++)
                {
                    Console.WriteLine("        -------------------------------------------------------------------------------------\n");
                    Console.WriteLine("        -----                                                                           -----\n");
                    Console.WriteLine("\n        ---                      --> Tienes un maximo de 10 retiros <--                   --- ");
                    Console.WriteLine("        -----                                                                           -----\n");
                    Console.WriteLine("        -------------------------------------------------------------------------------------\n");
                    Console.WriteLine("        -----                                                                           -----\n");
                    Console.WriteLine("\n        ---                        ¿Cuantos retiros se realizaran {0}?:                     --- ", i + 1);
                    Console.WriteLine("        -----                                                                           -----\n");
                    Console.WriteLine("        -------------------------------------------------------------------------------------\n");
                
                    aux_r = int.Parse(Console.ReadLine());
            

                    sobrante = aux_r % 1;
                    if (sobrante == 0 && aux_r <= 50000 && aux_r > 0)
                    {
            
                        r[i] = aux_r;

                    }
                    else
                    {
                  
                        Console.WriteLine("\n1.La cantidad de retiro debe ser como maximo 50,000.\n2.La cantidad debe ser entera y positiva.");
                        i--;
                    }


                }
                Console.WriteLine("        -------------------------------------------------------------------------------------\n");
                Console.WriteLine("        -----                                                                           -----\n");
                Console.WriteLine("        ---                       Presiona cualquier tecla para continuar                 ---");
                Console.WriteLine("        -----                                                                           -----\n");
                Console.WriteLine("        -------------------------------------------------------------------------------------\n");
                Console.ReadKey();


            }
            else
            {
                Console.WriteLine("\n!!!!   ------------------------------------------Error-----------------------------------  !!!!");
                Console.WriteLine("\n!!!!   Solo se aceptan retiros con numeros enteros y que no pasen mas de 10 o menores a 0  !!!!");
                Console.WriteLine("\n!!!!   ----------------------------------------------------------------------------------  !!!!\n");
                Console.WriteLine("       -----                                                                         -----\n");
                Console.WriteLine("       ---                      Presiona cualquier tecla para continuar              -----");
                Console.WriteLine("       -----                                                                         -----\n");
                Console.WriteLine("       -----------------------------------------------------------------------------------");
                Console.ReadKey();



            }


            break;
        case 2:
            for (int i = 0; i < num_r; i++)
            {
            
                c1 = (int)Math.Floor((decimal)r[i] / 500);
                r[i] = r[i] - (c1 * 500);

                c2 = (int)Math.Floor((decimal)r[i] / 200);
                r[i] = r[i] - (c2 * 200);

                c3 = (int)Math.Floor((decimal)r[i] / 100);
                r[i] = r[i] - (c3 * 100);

                c4 = (int)Math.Floor((decimal)r[i] / 50);
                r[i] = r[i] - (c4 * 50);

                c5 = (int)Math.Floor((decimal)r[i] / 20);
                r[i] = r[i] - (c5 * 20);

                m1 = (int)Math.Floor((decimal)r[i] / 10);
                r[i] = r[i] - (m1 * 10);

                m2 = (int)Math.Floor((decimal)r[i] / 5);
                r[i] = r[i] - (m2 * 5);

                m3 = (int)Math.Floor((decimal)r[i] / 1);
                r[i] = r[i] - (m3 * 1);

                c_total = c1 + c2 + c3 + c4 + c5;
                m_total = m1 + m2 + m3;

                Console.WriteLine("        -----                                                                           -----\n");
                Console.WriteLine("        ---                                      Retiro {0}                                 --- ", i + 1);
                Console.WriteLine("        ---                              Billetes Dispensados: {0}                          --- ", c_total);
                Console.WriteLine("        ---                              Monedas Dispensadas:  {0}                          --- \n",m_total);
                Console.WriteLine("        -----                                                                           -----\n");
            }
            Console.WriteLine("        -------------------------------------------------------------------------------------");
            Console.WriteLine("        ---                         Presiona cualquier tecla para continuar               ---");
            Console.WriteLine("        -------------------------------------------------------------------------------------");
            Console.ReadKey();
            Console.WriteLine("        -------------------------------------------------------------------------------------");
            Console.WriteLine("        -----                                                                           -----\n");
            Console.WriteLine("        ---                          Espere en lo que se procesa la accion...             ---");
            Console.WriteLine("        ---        Se retornara al inicio de las opciones que tenga un buen dia           ---");
            Console.WriteLine("        -----                                          :)                               -----\n");
            Console.WriteLine("        -------------------------------------------------------------------------------------");
            Thread.Sleep(3500);
            break;

            default:
            return;
    }
    Console.Clear();
}