using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskola_Diakok
{
    internal class Diak
    {
        public string[] FelvettTargyak = [];
        private int eletkor;
        private string nev;
        private float atlag;

        public int Eletkor {
            get => eletkor;
            set
            {
                if (value < 14 || value > 22) throw new Exception("Az életkor nem lehet 14-nél kisebb, vagy 22-nél nagyobb");
                eletkor = value;
            }
        }
        public string Szak {  get; set; }
        public string Nev
        { get => nev;
            set {
                if (value.Length < 3 || value.Length > 64)
                    throw new Exception("A név nem lehet rövidebb 3 karakternél és hosszabb sem mint 64 karakter");
                nev = value;
            }
        }
        public float Atlag
        { get => atlag;
            set {
                if (value < 1.0f || value > 5.0f)
                    throw new Exception("Az átlag nem lehet kisebb mint 1.0 és nem lehet nagyobb mint 5.0");
                atlag = value;
            }
        }

        public Diak(string nev, string szak) : this(nev, 18, szak, 3.0f, string.Empty)
        {

        }

        public Diak(string nev, int eletkor, string szak, float atlag, params string[] felvettTargyak)
        {
            Nev = nev;
            Eletkor = eletkor;
            Szak = szak;
            Atlag = atlag;
            foreach(string targy in felvettTargyak)
            {
                if(!FelvettTargyak.Contains(targy)) FelvettTargyak.Append(targy);
            }
            
        }
    }
}
