using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihanInheritance
{
    class program
    {
        static void Main(string[] srgs)
        {
            Mahasiswa mahasiswa = new Mahasiswa();
            mahasiswa.Name = "Heni";
            mahasiswa.NIM = 5370;
            mahasiswa.GetNameAndNIM();

            Dosen dosen = new Dosen();
            dosen.Name = "Rani";
            dosen.Email = "rani@students.ac.id";
            dosen.GetNameAndEmail();

            OrangTua orangtua = new OrangTua();
            orangtua.Name = "Sunsine";
            orangtua.Umur = 40;
            orangtua.GetNameAndUmur();

            Console.ReadKey();
        }

    }
}