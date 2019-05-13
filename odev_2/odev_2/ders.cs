using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
namespace odev_2
{
    class sınav
    {
        public int not { get; set; }//dersin sınavı vardır. ve bu sınavında quiz vize ve final tipi vardır. 
        //Notlar da linlist yapısı kullanarak itarasyon yapılmıstır.
        public sınav_Tipi tip { get; set; }
        public sınav next { get; set; }
        public sınav(sınav_Tipi tip,int not)
        {
            this.not = not;
            this.tip = tip;
        }
    }
    enum sınav_Tipi
    {
        quiz = 1,
        vize = 2,
        final = 3

    }
    class ders
    {
        public ders()
        {
            d_subeleri = new List<sube>();
        }
        public string d_adi { get; set; }
        public List<sube> d_subeleri { get; set; }

        public void Sube_Eklenecek(sube eklenecek)
        {
            d_subeleri.Add(eklenecek);
        }
        public void Sube_Silincek(sube silinecek)
        {
            d_subeleri.Remove(silinecek);
        }
        public void olustur()
        {
            // ekledigimiz dersi subeyi ve ogrencileri txt uzantısı ile dosya ya yazdırma işlemini yapmaktadır.
            StreamWriter yazici = new StreamWriter("Cikti.txt",false);
            yazici.WriteLine("Ders:"+d_adi);
            yazici.WriteLine("Şubeler:");
            foreach(sube item in d_subeleri)
            {
                yazici.WriteLine("Sube Adi:" + item.s_adi);
                yazici.WriteLine("Ogretim Elemani:" + item.akademisyen.ogrtm_adi);
                yazici.WriteLine("Ogretim Elemani ID:" + item.akademisyen.ogrtm_id);
                yazici.WriteLine("Ogrenci Basla");
                foreach(Ogrenci item2 in item.s_ogrencileri)
                {
                    yazici.WriteLine("Ogrenci Adi: " + item2.adı);
                    yazici.WriteLine("Ogrenci Numarasi: " + item2.numara);
                }
                yazici.WriteLine("Ogrenciler Son");
            }
            yazici.WriteLine("Subeler Son");
            yazici.Close();
        }
       
    }
   
}
