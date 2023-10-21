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
    public class KhachHang
    {
        [Key]
        public string maKH { get; set;}
        [Required(ErrorMessage ="ten khong duoc rong")]
        public string tenKH { get; set;}
        [Required(ErrorMessage = "lien ket khong duoc rong")]
        public string link { get; set; }
        public string SDT { get; set;}
    }
}
