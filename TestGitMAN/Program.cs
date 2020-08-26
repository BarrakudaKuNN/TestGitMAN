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
            Pekor Vladik = new Pekor();
            Bulka bulka = new Bulka();

            Vladik.DelatKovrishka(bulka,"Kovrishka");

            


            Console.WriteLine("HI im TEST 1");
            Console.ReadLine();
        }
    }
}
