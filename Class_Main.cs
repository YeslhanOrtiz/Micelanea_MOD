using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Micelanea_MOD
{
    public class Class_Main
    {
        public static void Main()
        {
            do
            {
                try
                {
                    int menu;
                    Menu.menu();
                    menu = Convert.ToInt32(Console.ReadLine());

                    switch (menu)
                    {
                        case 1:
                            Operadores.operadores();
                            int menu_op;
                            menu_op = Convert.ToInt32(Console.ReadLine());
                            switch (menu_op)
                            {
                                case 1:
                                    Operadores.op_1(1, 2);
                                    break;

                                case 2:
                                    Operadores.op_2(1, 2);
                                    break;

                                case 3:
                                    Operadores.op_3(1);
                                    break;

                                case 4:
                                    Operadores.op_4(1);
                                    break;

                                case 5:
                                    Operadores.op_5(1);
                                    break;

                                case 6:
                                    Operadores.op_6(1, 2);
                                    break;

                                case 7:
                                    Operadores.op_7(1, 2);
                                    break;

                                case 8:
                                    Operadores.op_8(1, 2, 3);
                                    break;

                                case 9:
                                    Salir.salir();
                                    break;

                                default:
                                    Operadores.op_def();
                                    break;
                            }
                            break;

                        case 2:
                            Condicionales.condicionales();
                            int menu_con = Convert.ToInt32(Console.ReadLine());
                            switch (menu_con)
                            {
                                case 1:
                                    Condicionales.op_1(1);
                                    break;

                                case 2:
                                    Condicionales.op_2(1, 2);
                                    break;

                                case 3:
                                    Condicionales.op_3(1, 2, 3);
                                    break;

                                case 4:
                                    Condicionales.op_4(1, 2);
                                    break;

                                case 5:
                                    Condicionales.op_5(1, 2);
                                    break;

                                case 6:
                                    Condicionales.op_6(1, 2);
                                    break;

                                case 7:
                                    Condicionales.op_7(1);
                                    break;

                                case 9:
                                    Salir.salir();
                                    break;

                                default:
                                    Condicionales.op_def();
                                    break;
                            }
                            break;

                        case 3:
                            Ciclos.ciclos();
                            int menu_cil = Convert.ToInt32(Console.ReadLine());
                            switch (menu_cil)
                            {
                                case 1:
                                    Ciclos.op_1(1);
                                    break;

                                case 2:
                                    Ciclos.op_2(1);
                                    break;

                                case 3:

                                    Ciclos.op_3(1);
                                    break;

                                case 4:
                                    Ciclos.op_4(1);
                                    break;

                                case 5:
                                    Ciclos.op_5(1);
                                    break;

                                case 6:
                                    Ciclos.op_6(1, 2, 3);
                                    break;

                                case 7:
                                    Ciclos.op_7(1);
                                    break;

                                case 9:
                                    Salir.salir();
                                    break;

                                default:
                                    Ciclos.op_def();
                                    break;
                            }
                            break;

                        case 9:
                            Salir.salir();
                            break;

                        default:
                            Menu.def();
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("------------------------");
                    Console.WriteLine("El dato ingresado es invalido");
                }
                   
                Do.inicio();
                
            } while (true);

        }
    }
}
