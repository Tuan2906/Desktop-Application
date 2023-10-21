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
    public partial class hinhTrongHinh : Form
    {
        public hinhTrongHinh()
        {
            InitializeComponent();
        }

        private void hinhTrongHinh_Paint(object sender, PaintEventArgs e)
        {    Pen mau = new Pen(Color.Red, 3);
            Pen mau1 = new Pen(Color.Green, 2);   
            e.Graphics.DrawLine(mau,0,ClientRectangle.Height / 2, ClientRectangle.Width, ClientRectangle.Height / 2);
            e.Graphics.DrawLine(mau, ClientRectangle.Width / 2, 0, ClientRectangle.Width / 2, ClientRectangle.Height);
            Rectangle r = new Rectangle(ClientRectangle.Width / 2, ClientRectangle.Height / 2, 200, 200);
            e.Graphics.DrawRectangle(mau1, r);
            float a =1.5f; // Hệ số góc của đường thẳng
            float b = 2f; // Hệ số tự do của đường thẳng
            float x1 = -ClientRectangle.Width / 2;
            float y1 = a * x1 + b;
            float x2 = ClientRectangle.Width / 2;
            float y2 = -a * x2 + b;
            e.Graphics.DrawLine(Pens.Blue, x1 + ClientRectangle.Width / 2, ClientRectangle.Height / 2 - y1, x2 + ClientRectangle.Width / 2, ClientRectangle.Height / 2 - y2);
            // Vẽ đồ thị của parabol
            float c = -1f; // Hệ số bậc 2 của đường parabol
            float d = 4f;
            float f = -4f;
            for (int x = -ClientRectangle.Width/ 2; x <= ClientRectangle.Width/ 2; x++){
                float y = (c * x * x)+(d*x)+(f);
                e.Graphics.FillRectangle(Brushes.Blue, x + ClientRectangle.Width / 2, ClientRectangle.Height / 2 - y, 1, 1);
            }
            e.Graphics.DrawEllipse(mau1, r);// ve hinh tron noi tiep hinh vuong
        }

        private void hinhTrongHinh_Load(object sender, EventArgs e)
        {

        }

        private void picHinh_Paint(object sender, PaintEventArgs e)
        {
            picHinh.Size = new Size(500,500);
            picHinh.Location = new Point(10, 20);
            int width = picHinh.Width;
            int height = picHinh.Height;
            e.Graphics.DrawLine(Pens.Black, 0, height / 2, width, height / 2);
            e.Graphics.DrawLine(Pens.Black, width/2, 0, width/2, height);
            float a = 1f;
            float b = 0f;
            float x1 = -width / 2;
            float y1 = a * x1 + b;
            float x2 = width / 2;
            float y2 = a * x2 + b;
            e.Graphics.DrawLine(Pens.Red, width / 2 + x1, height / 2 - y1, width / 2 + x2, height / 2 - y2);
            float c = -1f; // Hệ số bậc 2 của đường parabol
            float d = 4f;
            float f = -4f;
            for (int x = -width / 2; x<= width / 2; x++)
            {
                float y = (c * x * x) + (d * x) + (f);
                e.Graphics.FillRectangle(Brushes.Red, x + width/2, height/2-y, 1, 1);
            }
        }

        private void picHinh_Click(object sender, EventArgs e)
        {

        }
    }
}
