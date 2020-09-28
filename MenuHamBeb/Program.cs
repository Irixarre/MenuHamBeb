using System;

namespace MenuHamBeb
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;


            string[] GrandBigBoot = { "1-Big Boot", "2-BootPollo", "3-Cuarto de libra", "4-BootRoyal Deluxe" };
            string[] GrandBigBoot2 = { "1-Big Boot", "2-BootPollo", "3-Cuarto de libra", "4-BootRoyal Deluxe" };
            string[] Bebidas = { "1-CocaCola", "2-Fanta", "3-Agua", "4-Cerveza" };








            do
            {
                Console.WriteLine("1-Pedir menu\n2-Pedir Hamburguesa\n3-Pedir bebida\n4-Salir");

                opcion = int.Parse(Console.ReadLine());
                opcion1 = int.Parse(Console.ReadLine());
                opcion2 = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Menu");
                        Console.WriteLine(GrandBigBoot[0]);
                        Console.WriteLine(GrandBigBoot[1]);
                        Console.WriteLine(GrandBigBoot[2]);
                        Console.WriteLine(GrandBigBoot[3]);
                        MostrarValor();
                        break;
                    case 2:
                        Console.WriteLine("Hamburguesa");
                        Console.WriteLine(GrandBigBoot2[0]);
                        Console.WriteLine(GrandBigBoot2[1]);
                        Console.WriteLine(GrandBigBoot2[2]);
                        Console.WriteLine(GrandBigBoot2[3]);
                        MostrarHamburguesa();
                        break;
                    case 3:
                        Console.WriteLine("Bebida");
                        Console.WriteLine(Bebidas[0]);
                        Console.WriteLine(Bebidas[1]);
                        Console.WriteLine(Bebidas[2]);
                        Console.WriteLine(Bebidas[3]);
                        MostrarBebida();
                        break;
                    case 4:
                        Console.WriteLine("Salir");
                        break;
                    default:
                        Console.WriteLine("Esa opcion no esta disponible");
                        break;
                }

            } while (opcion != 4);

            {

            }

        }



        static void MostrarValor()
        {
            Console.WriteLine("Escoge el menu");
            int opcion = Convert.ToInt32(Console.ReadLine());
            string[] GrandBigBoot = { "1-Big Boot", "2-BootPollo", "3-Cuarto de libra", "4-BootRoyal Deluxe" };


            //opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:

                    Console.WriteLine("Aqui tienes tu menu:" + GrandBigBoot[0]);
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("Has elegido el menu:" + GrandBigBoot[1]);
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("Has elegido el menu:" + GrandBigBoot[2]);
                    break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine("Has elegido el menu:" + GrandBigBoot[3]);
                    break;
                default:
                    Console.WriteLine("Esa opcion no esta disponible");
                    break;
            }

            static void MostrarHamburguesa()
            {
                Console.WriteLine("Escogue Hamburguesa");
                //int opcion1 = Convert.ToInt32(Console.ReadLine());
                int opcion = Convert.ToInt32(Console.ReadLine());
                string[] GrandBigBoot2 = { "1-Big Boot", "2-BootPollo", "3-Cuarto de libra", "4-BootRoyal Deluxe" };

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Aqui tienes tu hamburguesa:" + GrandBigBoot2[0]);
                        break;
                    case 2:
                        Console.WriteLine("Has elegido el hamburguesa:" + GrandBigBoot2[1]);
                        break;
                    case 3:
                        Console.WriteLine("Has elegido el hamburguesa:" + GrandBigBoot2[2]);
                        break;
                    case 4:
                        Console.WriteLine("Has elegido el hamburguesa:" + GrandBigBoot2[3]);
                        break;
                    default:
                        Console.WriteLine("Esa opcion no esta disponible");
                        break;
                }




                static void MostrarBebida()
                {
                    Console.WriteLine("Escogue bebida");
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    string[] Bebidas = { "1-CocaCola", "2-Fanta", "3-Agua", "4-Cerveza" };
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Aqui tienes tu bebida:" + Bebidas[0]);
                            break;
                        case 2:
                            Console.WriteLine("Has elegido el bebida:" + Bebidas[1]);
                            break;
                        case 3:
                            Console.WriteLine("Has elegido el bebida:" + Bebidas[2]);
                            break;
                        case 4:
                            Console.WriteLine("Has elegido el bebida:" + Bebidas[3]);
                            break;
                        default:
                            Console.WriteLine("Esa opcion no esta disponible");
                            break;
                    }


                }
            }
        }
    }
}
    

    

