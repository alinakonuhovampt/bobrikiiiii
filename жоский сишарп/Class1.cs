using System;

namespace жоский_сишарп
{
    internal class cake_created
    {
        private int cost;
        private string zakaz;
        internal class PodMenu
        {
            public string title;
            public int price;

        }
        public void Menu()
        {
            Console.WriteLine("Та самая игра на винде с тортиками\nВыберете параметр торта ");

            Console.WriteLine("                                      ");
            Console.WriteLine("  Форма торта");
            Console.WriteLine("  Размер торта");
            Console.WriteLine("  Вкус коржей");
            Console.WriteLine("  Количество коржей");
            Console.WriteLine("  Глазурь");
            Console.WriteLine("  Декор");
            Console.WriteLine("  Пропитка коржей:) ");
            Console.WriteLine("  Ура победа");
            Console.WriteLine("                                       ");
            Console.WriteLine("Цена: " + cost);
            Console.WriteLine("Ваш заказ: " + zakaz);
        }
        public List<PodMenu> Glasure()
        {
            PodMenu berry = new PodMenu();
            berry.title = "Ягодная";
            berry.price = 450;
            PodMenu choko = new PodMenu();
            choko.title = "Шоколадная";
            choko.price = 200;
            PodMenu magic = new PodMenu();
            magic.title = "Волшебная";
            magic.price = 1000;

            List<PodMenu> glasure = new List<PodMenu>();
            glasure.Add(berry);
            glasure.Add(choko);
            glasure.Add(magic);

            return glasure;
        }
        public List<PodMenu> Size()
        {
            PodMenu big = new PodMenu();
            big.title = "Большой";
            big.price = 1500;
            PodMenu medile = new PodMenu();
            medile.title = "Средний";
            medile.price = 1300;
            PodMenu small = new PodMenu();
            small.title = "Маленький";
            small.price = 1100;

            List<PodMenu> size = new List<PodMenu>();
            size.Add(big);
            size.Add(medile);
            size.Add(small);

            return size;
        }
        public List<PodMenu> Taste()
        {
            PodMenu zeml = new PodMenu();
            zeml.title = "Земляника";
            zeml.price = 250;
            PodMenu pineapple = new PodMenu();
            pineapple.title = "Ананасовый";
            pineapple.price = 550;
            PodMenu koniak = new PodMenu();
            koniak.title = "Ирландский коньяк";
            koniak.price = 1000;

            List<PodMenu> taste = new List<PodMenu>();
            taste.Add(zeml);
            taste.Add(pineapple);
            taste.Add(koniak);

            return taste;
        }
        public List<PodMenu> Korge()
        {
            PodMenu one = new PodMenu();
            one.title = "1 корж";
            one.price = 100;
            PodMenu two = new PodMenu();
            two.title = "2 коржа";
            two.price = 200;
            PodMenu tre = new PodMenu();
            tre.title = "3 коржа";
            tre.price = 300;

            List<PodMenu> korge = new List<PodMenu>();
            korge.Add(one);
            korge.Add(two);
            korge.Add(tre);

            return korge;
        }
        public List<PodMenu> Forma()
        {
            PodMenu krug = new PodMenu();
            krug.title = "Круг";
            krug.price = 100;
            PodMenu cat = new PodMenu();
            cat.title = "Котик";
            cat.price = 145;
            PodMenu kvadrat = new PodMenu();
            kvadrat.title = "Квадрат";
            kvadrat.price = 290;

            List<PodMenu> forma = new List<PodMenu>();
            forma.Add(krug);
            forma.Add(cat);
            forma.Add(kvadrat);

            return forma;
        }
        public List<PodMenu> Dekor()
        {
            PodMenu berry = new PodMenu();
            berry.title = "Ягоды";
            berry.price = 500;
            PodMenu figure = new PodMenu();
            figure.title = "Фигурки аянами рей";
            figure.price = 1000;
            PodMenu glitter = new PodMenu();
            glitter.title = "Блёстки";
            glitter.price = 950;

            List<PodMenu> glasure = new List<PodMenu>();
            glasure.Add(berry);
            glasure.Add(figure);
            glasure.Add(glitter);

            return glasure;
        }
        public List<PodMenu> propitka()
        {
            PodMenu tears = new PodMenu();
            tears.title = "Слёзы студентов";
            tears.price = 550;
            PodMenu kefir = new PodMenu();
            kefir.title = "Остатки кефира с кружки разбавленные водой";
            kefir.price = 200;
            PodMenu milk = new PodMenu();
            milk.title = "Молоко";
            milk.price = 300;

            List<PodMenu> propitkA = new List<PodMenu>();
            propitkA.Add(tears);
            propitkA.Add(kefir);
            propitkA.Add(milk);

            return propitkA;
        }
        public void Output_Pod_Menu(List<PodMenu> box)
        {
            int position = 1;
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                Console.Clear();
                foreach (PodMenu podmenu in box)
                {
                    Console.WriteLine("  " + podmenu.title + " - " + podmenu.price);
                }
                position = Arrow(position, key);
                if (key == ConsoleKey.Enter)
                {
                    cost = cost + box[position].price;
                    zakaz = zakaz + box[position].title;
                    break;
                }
                if (key == ConsoleKey.Escape)
                {
                    Menu();
                }
            }
        }
        public int Arrow(int position, ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.DownArrow:
                    position++;

                    break;
                case ConsoleKey.UpArrow:
                    position--;
                    break;
            }


            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
            return position;
        }

        public void ClearOrder()
        {
            zakaz = "";
            cost = 0;
        }

        public void Save()
        {
            File.AppendAllText("C:\\Users\\Дарья\\source\\repos\\практическая 5 (тортики)\\cake_story.txt", cost.ToString());
            File.AppendAllText("C:\\Users\\Дарья\\source\\repos\\практическая 5 (тортики)\\cake_story.txt", zakaz.ToString());
        }

    }
}
