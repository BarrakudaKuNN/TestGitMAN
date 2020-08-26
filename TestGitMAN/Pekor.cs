using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitMAN
{
    class Pekor
    {
        List<Bulka> PlatoBulok = new List<Bulka>();
        private string name;
        private string weight;
        


        public List<Bulka> DelatKovrishka(Bulka bul, string name)
        {
            for (int i = 0; i < 10; i++)
            {
                Random random = new Random(DateTime.Now.Second);
               
                bul.Name= name;
                bul.Weigth = random.Next(1, 20).ToString() + " " + "KG";

                PlatoBulok.Add(bul);
             }
            return PlatoBulok;

        }

    }
}
