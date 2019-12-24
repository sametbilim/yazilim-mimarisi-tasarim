using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACADE_DESİGN_PATTERN
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade fcd = new Facade();

            fcd.KrediKullan(new Musteri { Ad = "Burak", TcNo = "123303", MusteriNumarasi = 4234242 }, 1000);
        }
    }
}
