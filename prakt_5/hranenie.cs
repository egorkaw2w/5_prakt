using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_5
{


    internal class hranenie
    {
        public string name;
        public int price;

        public hranenie(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

         static public List<List<hranenie>> zakaz = new List<List<hranenie>>()
        {
            new List<hranenie>
            {
                new hranenie("  круглая     ", 1500),
                new hranenie("  квадратная  ", 1200),
                new hranenie("  полукруглая ", 1350),
            },
            new List<hranenie>
            {
                new hranenie("  Большой    ", 3500),
                new hranenie("  Средний    ", 2500),
                new hranenie("  маленький  ", 1500),
            },
            new List<hranenie>
            {
                new hranenie("  вкусный     ", 3500),
                new hranenie("  невкусный   ", 2500),
                new hranenie("  хз, попробуй", 1500),
            },
            new List<hranenie>
            {
                new hranenie("       3     ", 3500),
                new hranenie("       2     ", 2500),
                new hranenie("       1     ", 1500),
            },
            new List<hranenie>
            {
                new hranenie("  Шоколад    ", 3500),
                new hranenie("  Карамель   ", 2500),
                new hranenie("  Вишня      ", 1500),
            },
            new List<hranenie>
            {
                new hranenie("  Красивый    ", 3500),
                new hranenie("  некрасивый   ", 2500),
                new hranenie("  случайный   ", 666),
            },
            


        };
    }
}
