using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitMAN
{
    class Vistovka
    {
        public Vistovka(Pekor pek)
        {
            foreach (var item in pek.PlatoBulok)
            {
                Console.WriteLine(item.Name + " " + item.Weigth);
            }

        }
        
    }
}
