using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapVeNha
{
    public partial class frmVe : Form
    {
        public frmVe()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmVe_Load(object sender, EventArgs e)
        {

        }
        hinhTrongHinh hinh;
        bool checkHinh = true;
        private void Hinh_Click(object sender, EventArgs e)
        {
          hinh  = new hinhTrongHinh();
            hinh.MdiParent = this;
            hinh.Show();
            checkHinh = false;
        }

        private void theSinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkHinh == false)
            {
                hinh.Close();
                checkHinh = true;
            }
            frmTheSinhVien theSinhVien = new frmTheSinhVien();
            theSinhVien.MdiParent = this;
            theSinhVien.Show();
        }
    }
}
