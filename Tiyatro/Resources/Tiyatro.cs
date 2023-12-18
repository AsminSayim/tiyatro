using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiyatro.Resources
{
    internal class Tiyatro
    {
        int ıd;
        string oyunAdi;
        DateTime tarih;
        NumericUpDown sure;
        string sahne;
        bool müzikal;
        int fiyat;

        public int Id { get => ıd; set => ıd = value; }
        public string OyunAdi { get => oyunAdi; set => oyunAdi = value; }
        public DateTime Tarih { get => tarih; set => tarih = value; }
        public NumericUpDown Sure { get => sure; set => sure = value; }
        public string Sahne { get => sahne; set => sahne = value; }
        public bool Müzikal { get => müzikal; set => müzikal = value; }
        public int Fiyat { get => fiyat; set => fiyat = value; }

        public Tiyatro(int ıd, string oyunAdi, DateTime tarih, NumericUpDown sure, string sahne, bool müzikal, int fiyat)
        {
            this.ıd = ıd;
            this.oyunAdi = oyunAdi;
            this.tarih = tarih;
            this.sure = sure;
            this.sahne = sahne;
            this.müzikal = müzikal;
            this.fiyat = fiyat;
        }
    }
}
