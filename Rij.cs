using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Werken_Met_Rijen
{
    internal class Rij
    {
        List<int> container;

        internal Rij()
        {
            container = new List<int>();
        }

        public void Toevoegen(int i)
        {
            container.Add(i);
        }
        public int Uithalen ()
        {
            if (container.Count == 0)
                return int.MinValue;
            int even = container[0];
            container.RemoveAt(0);
            return even;
        }

        public void Maakleeg()
        {
            container.Clear();
        }



        public override string ToString()
        {
            string s = "";
            foreach (int i in container)
            {
                s += i.ToString() + "\n";
            }
            return s;
        }
    }
}
