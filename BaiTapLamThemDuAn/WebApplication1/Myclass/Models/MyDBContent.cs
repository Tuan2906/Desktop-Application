using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myclass.Models
{
    public class MyDBContent : DbContext
    {
        private DbSet<KhachHang> khaches1;
        private DbSet<hoadon> hoadons1;

        public MyDBContent() : base("name=StrConnect") { }
        public DbSet<KhachHang> khachHangs { get => khaches1; set => khaches1 = value; }
        public DbSet<hoadon> hoadons { get => hoadons1; set => hoadons1 = value; }

    }
}
