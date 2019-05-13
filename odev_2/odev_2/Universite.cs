using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_2
{
    class Universite
    {
        public Universite()
        {
            u_fakulteler = new List<fakulte>();
        }
        public string u_adi { get; set; }
        public List <fakulte> u_fakulteler { get; set; }
        
        public void Fakulte_Ekle(fakulte eklenecek)
        {
            u_fakulteler.Add(eklenecek);
        }
        public void Fakulte_Silme(fakulte Silinecek)
        {
            u_fakulteler.Remove(Silinecek);
        }
    }
}
