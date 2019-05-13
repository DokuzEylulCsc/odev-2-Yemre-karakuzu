using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_2
{
    class fakulte
    {
        public fakulte()
        {
            f_bolumleri = new List<bolum>();
        }
        public string f_adi { get; set; }
        public List<bolum> f_bolumleri { get; set; }

        public void Bolum_Ekle(bolum eklenecek)
        {
            f_bolumleri.Add(eklenecek);
        }
        public void Bolum_Silme(bolum silinecek)
        {
            f_bolumleri.Remove(silinecek);
        }
    }
}
