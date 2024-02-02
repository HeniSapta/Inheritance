using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihanInheritance
{
    internal class OrangTua : Mahasiswa
    {
        public string Name { get; set; }
        public int Umur { get; set; }

        public void GetNameAndUmur()
        {
            Console.WriteLine("The OrangTua has name: {0} and Umur : {1}", Name, Umur);
        }
    }
}
