using System.Data;
using System.Runtime.InteropServices;
using System.Transactions;

namespace prakt_5
{
    internal class Program
    {
        public static int num = 0;
        static void Main(string[] args)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            while (true)
            {

                Console.WriteLine("Приветсвуем вас в нашей кондитерской!");
                Console.WriteLine("Сегодня у нас акция: \" Собери торт сам!\")");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("  Форма");
                Console.WriteLine("  размер");
                Console.WriteLine("  вкус");
                Console.WriteLine("  кол-во коржей");
                Console.WriteLine("  наполнитель");
                Console.WriteLine("  Декор");
                Console.WriteLine("  Сохранить заказ");
                Console.WriteLine("-----------------");
                Console.WriteLine("Заказ: ");
              
                foreach (var i in total.goods)
                {
                    Console.Write(i.name);
                    Console.WriteLine(i.price);
                    
                    num += i.price;
                }
                Console.WriteLine(num);

                int pos = menu.Show(3, 9);
                if (pos == -999)
                {
                    Console.Clear();
                    total.goods.Clear();
                    num = 0;
                    continue;

                }

                Console.Clear();
                Console.WriteLine("  Выбирай");
                foreach (var i in hranenie.zakaz[pos - 3])
                {
                    Console.WriteLine(i.name + "\t" + i.price);
                    
                }
                ;

                int a = menu.Show(1,3);
                if (a == -999)
                {
                    Console.Clear();
                    continue;

                }


                total.goods.Add(hranenie.zakaz[pos - 3][a - 1]);

               
                Console.Clear();
                if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    continue;
                }

            }
        }
    }
}