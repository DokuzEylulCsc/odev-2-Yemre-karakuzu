using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace odev_2
{
    class bolum
    {
        public bolum()
        {
            b_dersleri = new List<ders>();
        }
        public string b_adi { get; set; }
        public List<ders> b_dersleri { get; set; }

        public void Ders_Ekleme(ders eklenecek)
        {
            b_dersleri.Add(eklenecek);
        }
        public void Ders_Silme(ders silinecek)
        {
            b_dersleri.Remove(silinecek);
        }
        public ders okuVeOlustur()
        {
            //txt dosyasından okudugumuz verileri(belli sartlar altında yazılmıs olması gerekiyor) okuyup bolume dersi subeleri ogrencileri atayan metod
            string[] veriler = File.ReadAllLines("Cikti.txt");
            int i=1;
            //bolum bolum1 = new bolum();
            ders ders1 = new ders();
            sube sube1 = new sube();
            OgretimElemanı ogrt1 = new OgretimElemanı();
            Ogrenci ogrnc1;
            ders1.d_adi = veriler[0].Replace("Ders:","");
            bayrak://2. veya daha fazla sube varsa onlarıda eklemek için
            while (veriler[i]!="Ogrenci Basla")
            {          
                if(veriler[i].Contains("Sube Adi"))
                {
                    sube1.s_adi = veriler[i].Replace("Sube Adi:","");
                }
                else if(veriler[i].Contains("Ogretim Elemani"))
                {
                    ogrt1.ogrtm_adi = veriler[i].Replace("Ogretim Elemani:", "");
                    i++;
                    ogrt1.ogrtm_id = int.Parse(veriler[i].Replace("Ogretim Elemani ID:", ""));
                }
                i++;
            }
            //akedemisyeni subeye atıyoruz
            sube1.OgretimElemani_Ekleme(ogrt1);
            while(veriler[i]!="Ogrenciler Son")
            {
                if (veriler[i].Contains("Ogrenci Adi"))
                {
                    ogrnc1 = new Lisans();//eklenecek olan kişilerin hepsinin lisans ogrencisi oldugunu varsaydık
                    ogrnc1.adı = veriler[i].Replace("Ogrenci Adi:", "");
                    i++;
                    ogrnc1.numara = int.Parse(veriler[i].Replace("Ogrenci Numarasi:",""));
                    sube1.Ogrenci_Ekleme(ogrnc1);
                }
                i++;
            }
            //subeyi derse ekledik
            ders1.Sube_Eklenecek(sube1);
            if(veriler[++i]!="Subeler Son")
            {
                goto bayrak;
            }
            return ders1;
        }
    }
}
