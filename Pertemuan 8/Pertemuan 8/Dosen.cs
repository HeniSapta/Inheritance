using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihanInheritance
{
    internal class Dosen : Mahasiswa
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public void GetNameAndEmail()
        {
            Console.WriteLine("The Dosen has name: {0} and email: {1}", Name, Email);
        }
    }
}
