using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ödev1.interfaces;

namespace ödev1
{
    internal class bmw : araba, IOzell, IOzellik2, IOzellik3
    {
        public void gidiyor(string marka)
        {
            Console.WriteLine(marka+"çook hızlı gider...");
        }

        public void ucuyo(string marka)
        {
            Console.WriteLine(marka+"havada uçar...");
        }

        public void yüzüyor(string marka)
        {
            Console.WriteLine(marka+"denizde yüzer...");
        }
    }
}
