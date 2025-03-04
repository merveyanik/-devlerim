using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ödev1.interfaces;

namespace ödev1
{
    internal class mercedes : araba, IOzellik2, IOzellik3
    {
        public void ucuyo(string marka)
        {
            Console.WriteLine("havada uçar...");
            
        }

        public void yüzüyor(string marka)
        {
          Console.WriteLine("denizde yüzer...");
        }
    }
}
