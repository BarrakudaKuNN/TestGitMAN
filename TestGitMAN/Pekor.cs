using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitMAN
{
    class Pekor
    {
        public List<Bulka> PlatoBulok = new List<Bulka>();
        

        public void DelatKovrishka(Bulka bul, string name)
        {
            
            var random = new Random(Guid.NewGuid().ToByteArray().Sum(x => x));
            for (int i = 0; i < 3; i++)
            {
                bul = new Bulka();
                bul.Name= name;
                bul.Weigth = random.Next(1, 20).ToString() + " " + "KG";
                
                PlatoBulok.Add(bul);
             }
            
        }

    }
}
