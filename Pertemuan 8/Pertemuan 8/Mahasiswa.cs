using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihanInheritance
{
    internal class Mahasiswa
    {
        public string Name { get; set; }
        public int NIM { get; set; }

        public void GetNameAndNIM()
        {
            Console.WriteLine("The person has name: {0} and NIM: {1}", Name, NIM);
        }
    }
}
