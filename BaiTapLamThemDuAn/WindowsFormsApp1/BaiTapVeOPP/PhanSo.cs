using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapVeOPP
{
    class PhanSo
    {
        private int tu, mau;
        public PhanSo()
        {
            Tu = 0;
            Mau = 1;
        }
        public PhanSo(int t, int m)
        {
            this.Tu = t;
            this.Mau = m;
        }

        public int Tu { get => tu; set => tu = value; }
        public int Mau { get => mau; set => mau = value; }
        public PhanSo tong(PhanSo a)
        {
            PhanSo k = new PhanSo();
            k.tu = this.tu * a.mau + this.mau * a.tu;
            k.mau = this.mau * a.mau;
            return k;

        }
    }
}
