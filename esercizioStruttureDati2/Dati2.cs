using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizioStruttureDati2
{
    class Dati2
    {
        static void Main(string[] args)
        {
            HashSet<int> numeri = new HashSet<int>();
            using (StreamReader sr = new StreamReader("dati2.txt", Encoding.UTF8))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    int n = int.Parse(line);
                    numeri.Add(n);
                }
            }
            using (StreamWriter sw = new StreamWriter("file2dati_fake.txt", false, Encoding.UTF8))
            {
                foreach (int s in numeri)
                {
                    sw.WriteLine(s);
                }
            }

        }

    }
}
