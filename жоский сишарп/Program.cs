using System.Diagnostics;
using жоский_сишарп;

namespace жоский_сишарп
{
    internal class Program
    {

        static void Main()
        {

            cake_created cake_Created = new cake_created();
            int position = 3;

            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                Console.Clear();
                cake_Created.Menu();

                position = cake_Created.Arrow(position, key);


                if (key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    switch (position)
                    {
                        case 3:
                            Console.WriteLine("Выберите форму тортика");
                            cake_Created.Output_Pod_Menu(cake_Created.Forma());
                            break;
                        case 4:
                            Console.WriteLine("Выберите размер тортика");
                            cake_Created.Output_Pod_Menu(cake_Created.Size());
                            break;
                        case 5:
                            Console.WriteLine("Выберите вкус тортика");
                            cake_Created.Output_Pod_Menu(cake_Created.Taste());
                            break;
                        case 6:
                            Console.WriteLine("Выберите количество коржей в тортике");
                            cake_Created.Output_Pod_Menu(cake_Created.Korge());
                            break;
                        case 7:
                            Console.WriteLine("Выберите вкус глазури");
                            cake_Created.Output_Pod_Menu(cake_Created.Glasure());
                            break;
                        case 8:
                            Console.WriteLine("Выберите декор тортика");
                            cake_Created.Output_Pod_Menu(cake_Created.Dekor());
                            break;
                        case 9:
                            Console.WriteLine("Выберите пропитку");
                            cake_Created.Output_Pod_Menu(cake_Created.propitka());
                            break;
                        case 10:
                            Console.WriteLine("Спасибо за заказ! \n Нажмите Esc, что-бы заказать еще");
                            cake_Created.Save();
                            break;

                    }
                        if (key == ConsoleKey.Escape)
                        {
                            cake_Created.Menu();
                            cake_Created.ClearOrder();
                        }

                    }
                }
            }
        }
    }
