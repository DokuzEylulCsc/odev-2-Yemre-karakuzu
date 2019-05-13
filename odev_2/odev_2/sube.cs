using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_2
{
    class sube
    {
        public sube()
        {
            s_ogrencileri = new List<Ogrenci>();
        }
        public string s_adi { get; set; }
        public List<Ogrenci> s_ogrencileri { get; set; }
        public OgretimElemanı akademisyen { get; set; }
        public OgretimElemanı eski_akademisyen { get; set; }
        public void Ogrenci_Ekleme(Ogrenci eklenecek)
        {
            s_ogrencileri.Add(eklenecek);
        }
        public void Ogrenci_Silme(Ogrenci silinecek)
        {
            s_ogrencileri.Remove(silinecek);
        }
        public void OgretimElemani_Ekleme(OgretimElemanı eklenecek)
        {
            if(akademisyen==null)
            {
                akademisyen = eklenecek;
            }
            else if (akademisyen!=eklenecek)
            {
                OgretimElemani_Degistirmek(eklenecek);
            }
            
        }
        private void OgretimElemani_Degistirmek(OgretimElemanı degistirilecek )
        {
            eski_akademisyen = akademisyen;
            akademisyen = degistirilecek;
        }

    }
}
