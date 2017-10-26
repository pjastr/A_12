using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź ciąg znaków/zdanie.");
            string zdanie = Console.ReadLine();
            string[] slowa = zdanie.Split(new[] { " " }, StringSplitOptions.None);
            string slowo = "";
            int licznik = 0;
            foreach (String s in slowa)
            {
                if (s.Length > licznik)
                {
                    slowo = s;
                    licznik = s.Length;
                }
            }

            Console.WriteLine(slowo);
            Console.ReadKey();
        }
    }
}
