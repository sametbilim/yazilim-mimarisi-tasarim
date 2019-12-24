using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACADE_DESİGN_PATTERN
{
    class Facade
    {
        private Banka _banka;
        private MerkezBankasi _merkezBanka;
        private Kredi _kredi;

        public Facade()
        {
            _banka = new Banka();
            _merkezBanka = new MerkezBankasi();
            _kredi = new Kredi();

        }

        public void KrediKullan(Musteri m, decimal talep)
        {
            if (!_merkezBanka.KaraListeKontrol(m.TcNo) && _kredi.KrediKullanmaDurumu(m))
            {
                _banka.KrediyiKullan(m, talep);
                Console.WriteLine("krediyi kullandırdık");
            }

        }
    }
}
