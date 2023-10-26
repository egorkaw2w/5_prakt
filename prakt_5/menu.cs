using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace prakt_5
{

    internal class menu
    {
        private int minstrelka;
        private int maxstrelka;
        public menu(int min, int max)
        {
            minstrelka = min;
            maxstrelka = max;
        }

        static public int Show(int min, int max)
        {

            int pos = min;
            ConsoleKey key;

            do
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");

                key = Console.ReadKey(true).Key;

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");

                if (key == ConsoleKey.UpArrow && pos != min)
                {
                    pos--;
                }
                else if (key == ConsoleKey.DownArrow && pos != max)
                {
                    pos++;
                }
                else if (pos == 9 && key == ConsoleKey.Enter)
                {
                    File.AppendAllText("zakaz.txt",DateAndTime.Now.ToString("d") + "\n");
                    foreach (var i in total.goods)
                    {
                        File.AppendAllText("zakaz.txt", i.name + " " + i.price + "\n");
                    }
                    File.AppendAllText("zakaz.txt", "ИТОГО: " + Program.num.ToString());
                    total.goods.Clear();
                    return pos = -999;

                }
                if (key == ConsoleKey.Escape)
                {
                    return -999;
                }


            } while (key != ConsoleKey.Enter);

            return pos  ;
        }
    }

}
