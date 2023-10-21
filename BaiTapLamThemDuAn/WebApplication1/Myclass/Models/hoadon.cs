using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myclass.Models
{
    [Table("Khachhang")]
    public class hoadon
    {
        [Key]
        public int soHoaDon { get; set; }
        [Required(ErrorMessage = "ten khong duoc rong")]
        public DateTime NGHD { get; set; }
        [Required(ErrorMessage = "lien ket khong duoc rong")]
        public string triGia  { get; set; }
        public string SDT { get; set; }
    }
}
