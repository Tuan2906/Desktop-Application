using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RandomNumber : Form
    {
        Random r = new Random();
        int mark = 0;
        public RandomNumber()
        {
            InitializeComponent();
        }
        private void btQuaySo_Click(object sender, EventArgs e)
        {
            int so1, so2, so3;
            so1 = r.Next(1, 7);
            so2 = r.Next(1, 7);
            so3 = r.Next(1, 7);
            lbl1.Text = so1.ToString();
            lbl2.Text = so2.ToString();
            lbl3.Text = so3.ToString();
            if (radiobadenmuoi.Checked)//kiem tra so 1  số 2 số 3 thuộc trong khoảng từ 3 đến 10
                if (so1 + so2 + so3 <= 10)
                    mark += 10;
                else
                    mark -= 10;
            else
                if (so1 + so2 + so3 > 10)
                mark += 10;
            else
                mark -= 10;
            lblDiem.Text = mark.ToString();

        }

        private void RamDom_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
