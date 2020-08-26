using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitMAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Pekor Vladik = new Pekor(new Bulka(), "Kovrishka");
            
            
            var vistovka = new Vistovka(Vladik);



            
            Console.ReadLine();
        }
    }
}
