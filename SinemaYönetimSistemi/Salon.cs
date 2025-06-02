using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SinemaYönetimSistemi
{
    public class Salon
    {
        public int SalonId{ get; set; }
        public string FilmName{ get; set; }

        public int doluKoltukSayi { get; set; }
        public int KoltukSayi  { get; set; }

    public Salon() { }
        public Salon(int _salonId, string _FilmName, int _doluKoltukSayi) 
        {
            SalonId=_salonId;

            FilmName = _FilmName;

            doluKoltukSayi = _doluKoltukSayi;
            KoltukSayi = 30;


        }



    }
}
