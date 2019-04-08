using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            Card c1 = new Card();
            Card c2 = new Card(3, 4);
            Card c3 = new Card(1, 14);
            Card c4 = c2;

            c1.print();
            c2.print();
            c3.print();
            c4.print();

            c1.SetSuit(c4.GetSuit());
            c2.value = 12;
            c4.value = 6;

            c1.print();
            c2.print();
            c3.print();
            c4.print();

            Console.ReadKey(true);
        }
    }
}
