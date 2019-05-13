using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_2
{
    class Program
    {

        static List<Universite> unv = new List<Universite>();
        static void Main(string[] args)
        {
            #region  tanımlamar ve atamalar region halinde gizlenmiştir
            //nesne oluşturma//
            Universite universiteler = new Universite();
            universiteler.u_adi = "Dokuz Eylül";
           // DokuzEylül.u_fakulteler
            fakulte fakulteler = new fakulte();
            fakulteler.f_adi = "Fen Bilimleri";
            // fakulte.f_bolumleri
            bolum bolumler = new bolum();
            bolumler.b_adi = "Bilgisayar Bilimleri";
            // bolum.b_dersleri
            ders dersler = new ders();
            dersler.d_adi = "Nesneye Yönelik Programlama";
            //ders.d_subeleri
            sube subeler = new sube();
            subeler.s_adi = "Birinci Sube";
            OgretimElemanı akademisyen = new OgretimElemanı();
            akademisyen.ogrtm_adi = "Uğur Eliiyi";
            akademisyen.ogrtm_id = 12345;
            Lisans ogr1 = new Lisans();
            ogr1.adı = "Yunus Emre Karakuzu";
            ogr1.numara = 2015280014;
            //sınav verilerini link list tarzında atadık
            ogr1.sınavlar = new sınav(sınav_Tipi.quiz, 90);
            ogr1.sınavlar.next = new sınav(sınav_Tipi.vize, 75);
            ogr1.sınavlar.next.next = new sınav(sınav_Tipi.final, 50);
            Yukseklisans ogr2 = new Yukseklisans();
            ogr2.adı = "Can Yücel";
            ogr2.numara = 201024584;
            ogr2.sınavlar = new sınav(sınav_Tipi.quiz, 70);
            ogr2.sınavlar.next = new sınav(sınav_Tipi.vize,65);
            ogr2.sınavlar.next.next = new sınav(sınav_Tipi.final, 68);
            Doktora ogr3 = new Doktora();
            ogr3.adı = "Cemal sureyya";
            ogr3.numara = 2005214565;
            ogr3.sınavlar = new sınav(sınav_Tipi.quiz, 50);
            ogr3.sınavlar.next = new sınav(sınav_Tipi.vize, 58);
            ogr3.sınavlar.next.next = new sınav(sınav_Tipi.final, 70);
            //ogrenci atamaları
            subeler.Ogrenci_Ekleme(ogr1);
            subeler.Ogrenci_Ekleme(ogr2);
            subeler.Ogrenci_Ekleme(ogr3);
            //subenin akademisyeni atama
            subeler.akademisyen = akademisyen;
            //dersin subesini ekleme
            dersler.Sube_Eklenecek(subeler);
            //bolümün dersini ekleme
            bolumler.Ders_Ekleme(dersler);
            //fakultenin bolümlerini ekleme
            fakulteler.Bolum_Ekle(bolumler);
            //universitenin fakultelerini ekleme
            universiteler.Fakulte_Ekle(fakulteler);
            #endregion
            // region vardır + tusuna basarak yazdıgım kodları görebilirsiniz.
            anamenu:
            try
            {
                
                Console.WriteLine("Ne İslem yapacagınızı seciniz.");
                Console.WriteLine("[1]Ogrenci sorgula");
                Console.WriteLine("[2]Cıkıs");
                int secenek = int.Parse(Console.ReadLine());
                if (secenek==1)
                {
                    menu:
                    int i = 1;
                    foreach(Ogrenci item in subeler.s_ogrencileri)
                    {
                        Console.WriteLine(item.adı+" İçin "+(i++)+ " Girin");
                       
                    }                  
                    try
                    {
                        secenek = Int16.Parse(Console.ReadLine());                    
                        sınav anlık;
                        anlık = subeler.s_ogrencileri[secenek - 1].sınavlar;
                        while(anlık!=null)
                        {
                            Console.WriteLine("" + anlık.tip.ToString() + ":" + " " + anlık.not);
                            anlık = anlık.next;
                        }
                        Console.ReadKey();
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Lutfen sayi giriniz");
                        goto menu;
                        
                    }
                }
                else if(secenek==2)
                {
                    Environment.Exit(0);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen Sayi giriniz.");
                goto anamenu;
            }
        }
    }
}
