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
    public partial class CacPhepToanCoBan : Form
    {
        public CacPhepToanCoBan()
        {
            InitializeComponent();
        }

        private void Dangki_Load(object sender, EventArgs e)
        {

        }
        private void btnCong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt1.Text);
            int b = int.Parse(txt2.Text);
            txtKq.Text = String.Format("{0}", a + b);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult rel = MessageBox.Show("ban co chac thoat khong?", "Thong báo", MessageBoxButtons.OKCancel);
            if (rel == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt1.Text);
            int b = int.Parse(txt2.Text);
            if (b != 0)
            {
                txtKq.Text = String.Format("{0}", a / b);
            }
            else
            {
                MessageBox.Show("Loi chia cho 0", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt1.Text);
            int b = int.Parse(txt2.Text);
            txtKq.Text = String.Format("{0}", a - b);
        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt1.Text);
            int b = int.Parse(txt2.Text);
            txtKq.Text = String.Format("{0}", a * b);
        }

        
    }
    
}
