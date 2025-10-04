using System.Threading.Channels;
using System.Transactions;

namespace Laba3
{
    internal class Program
    {
        enum Status { New, Processing, Shipped, Delivered }
        enum Lignh { Red, Yellow, Green }

        enum TaskPriority
        {
            Low = 1,
            Medium = 2,
            High = 3
        }
        enum Hero { воин, маг, вор }
        enum TimeOfday { Утро, День, Вечер, Ночь }
        enum DayOfWeek
        {
            Monday,
            Tuesday,
            Wensday,
            Thusday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int i = 1;
            //for (; ; )
            //{
            //    Console.WriteLine($"i = {i}");
            //    i++;
            //}

            //for (int i=1,j=1;i<10;i++,j++)
            //    Console.WriteLine($"{i+j}");

            //int sum = 0;
            //for (int i=1; i <= 10; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine($"Сумма: {sum}");

            //int i = 10;
            //do
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}
            //while (i > 0);

            //int i = 10;
            //while (i > 0)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}

            //int i = -1;
            //while (i > 0)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}

            //foreach(char i in "Hello world")
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < 9; i++)
            //{
            //    if (i == 5)
            //        break;
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.Write($"{i*j}\t");
            //    }
            //    Console.WriteLine();
            //}

            //string? input;
            //Console.WriteLine("Добро пожаловать в Эхо-чат!" +
            //"Напиши что - нибудь(или 'выход' для завершения):");
            //while (true)
            //{
            //    Console.Write("> ");
            //    input = Console.ReadLine();
            //    if (input == null)
            //        continue;
            //    if (input.ToLower() == "выход")
            //    {
            //        Console.WriteLine("До встречи!");
            //        break;
            //    }
            //    Console.WriteLine($"Вы сказали: {input}");
            //}


            //    DayOfWeek today = DayOfWeek.Friday;
            //    Console.WriteLine(today);


            //TaskPriority priority = TaskPriority.High;
            //    Console.WriteLine((int)priority);



            //DayOfWeek day = DayOfWeek.Saturday;
            //switch (day)
            //{
            //    case DayOfWeek.Saturday:
            //    case DayOfWeek.Sunday:
            //        Console.WriteLine("Выходной!");
            //        break;
            //    default:
            //        Console.WriteLine("Будний день.");
            //        break;
            //}


            //var times = Enum.GetValues(typeof(TimeOfday));
            //var heroes = Enum.GetValues(typeof(Hero));

            //for (int i = 0; i < times.Length; i++)
            //{
            //    TimeOfday time = (TimeOfday)times.GetValue(i);
            //    Console.WriteLine($"\nВремя сейчас: {time}");

            //    for (int j = 0; j < heroes.Length; j++)
            //    {
            //        Hero h = (Hero)heroes.GetValue(j);
            //        Console.WriteLine($"{h} - ");

            //    }
            //}
            //switch (time)
            //{
            //    case TimeOfday.Утро:
            //        Console.WriteLine(heroes switch
            //        {
            //            Hero.воин => "делает зарядку с мечом",
            //            Hero.маг => "заваривает зелья",
            //            Hero.вор => "крадётся по базару",
            //            _ => "ничего не делает"
            //        });
            //        break;
            //    case TimeOfday.Вечер:
            //        Console.WriteLine(heroes switch
            //        {
            //            Hero.воин => "ест мясо у костра",
            //            Hero.маг => "создаёт магический щит",
            //            Hero.вор => "пранирует налёт",
            //            _ => ""
            //        });
            //        break;
            //    case TimeOfday.Ночь:
            //        Console.WriteLine(heroes switch
            //        {
            //            Hero.воин => "спит в палатке",
            //            Hero.маг => "медитирует под луной",
            //            Hero.вор => "лезет в чежой дом",
            //            _ => ""
            //        });
            //        break;
            //}

            //Задание 1
            Lignh a = Lignh.Yellow;
            switch (a)
            {
                case Lignh.Red:
                    Console.WriteLine("Состояние светофора Red следующий GREEN");
                    break;
                case Lignh.Yellow:
                    Console.WriteLine("Состояние светофора Yellow следующий Red");
                    break;
                case Lignh.Green:
                    Console.WriteLine("Состояние светофора Green следующий Yellow");
                    break;
            }
            //Задание 2
            Status a = Status.New;
            switch (a)
            {
                case Status.New:
                case Status.Processing:
                    Console.WriteLine("Заказ можно отменить");
                    break;
                default:
                    Console.WriteLine("Заказ нельзя отменить");
                    break;
            }
            //Задание 3
            int a = 10;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a);
                a = a - 1;
            }
            //Задание 4
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"5 * {i} = {5 * i}");
            }


        }
    }
}
