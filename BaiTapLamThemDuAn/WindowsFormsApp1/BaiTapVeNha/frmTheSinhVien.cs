using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace BaiTapVeNha
{
    public partial class frmTheSinhVien : Form
    {
        string path = @"Hinh\";
        public frmTheSinhVien()
        {
            InitializeComponent();
        }
        Graphics graphics=null;
        private void picThe_Paint(object sender, PaintEventArgs e)
        {
           picThe.Size = new Size(700, 700);
          
            //  picThe.BackColor = Color.Black;
            Rectangle r = new Rectangle(100,50, 400, 400);
            e.Graphics.DrawRectangle(Pens.Black, r);
          
            Font f = new Font(FontFamily.GenericSansSerif, 20,FontStyle.Bold);
            string s = "giấy đăng kí kết hôn".ToUpper();
            e.Graphics.DrawString(s, f, Brushes.Black, 150, 80);
            //picThe.BringToFront();

            PictureBox a1 = new PictureBox();
            a1.Size = new Size(900, 900);
            a1.Location = new Point(150, 80);
            a1.BackColor = Color.Blue;
            a1.BringToFront();
            a1.Image= Image.FromFile(path + "0.JPG");
            e.Graphics.DrawImage(a1.Image, 105, 80,50,50);
            Rectangle r1 = new Rectangle(110, 150, 150, 150);
            e.Graphics.DrawRectangle(Pens.Black, r1);
            PictureBox a2 = new PictureBox();
            a2.Size = new Size(900, 900);
            a2.Location = new Point(100, 80);
            a2.BackColor = Color.Blue;
            a2.BringToFront();
            a2.Image = Image.FromFile(path + "truong.jpg");
            e.Graphics.DrawImage(a2.Image, 110, 150, 150, 150);
            graphics = picThe.CreateGraphics();
            
           graphics.DrawString("Ho va ten:",Font,Brushes.Black,270,160);

            graphics.DrawString("Ngo Quang Truong", Font, Brushes.Black, 350, 160);

            graphics.DrawString("Quan he:", Font, Brushes.Black, 270, 200);

            graphics.DrawString("Chong Kim Lien", Font, Brushes.Black, 350, 200);

            graphics.DrawString("Ly do ket hon:đã có 2 con", Font, Brushes.Black, 270, 250);

            graphics.DrawString("Tài sản hiện nay: 5 miếng đất ở Bình Dương", Font, Brushes.Black, 270, 290);

            graphics.DrawString("Ký Tên:", Font, Brushes.Black, 400, 350);

            graphics.DrawString("Ngo Quang Truong", Font, Brushes.Black, 380, 370);
        }

        private void frmTheSinhVien_Load(object sender, EventArgs e)
        {
            lblMau.Size = new Size(405, 70);
            lblMau.Location = new Point(110, 62);
            lblMau.Name = this.Name;
            lblMau.BringToFront();
            picThe.BringToFront();
        }
    }
}
