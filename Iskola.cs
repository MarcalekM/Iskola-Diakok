using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskola_Diakok
{
    internal class Iskola
    {
        public List<Diak> diakok = new();
        public int DiakokSzama => diakok.Count;
        public double DiakokAtlagEletkora => diakok.Average(d => d.Eletkor);

        public void DiakFelvitele(Diak diak)
        {
            diakok.Add(diak);
        }

        public void DiakTorlese(string nev)
        {
            var diak = diakok.Where(d => d.Nev.Equals(nev)).First();
            diakok.Remove(diak);
        }
    }
}
