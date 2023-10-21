using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHangKhongBUS;
using QuanLyHangKhongDAL;
using QuanLyHangKhongEntity;
namespace QuanLiHangKhong
{
    public partial class frmNhanVien : Form
    {
        Bus_tableNhanVien busNV = new Bus_tableNhanVien();
        EC_tableNhanVien ecNhanVien = new EC_tableNhanVien();
        bool themmoi=true;
        public frmNhanVien()
         {
            InitializeComponent();
        }

        public void KhoaButtton()// chi mo nut them,sua,xoa
        {
            txtMaNV.Enabled = false;
            txtTen.Enabled = false;
            txtLuong.Enabled = false;
            btnThem.Enabled = true;
            btnFix.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = true;
        }
        public void MoButtton()// chi khoa nut them,sua,xoa
        {
            txtMaNV.Enabled = true;
            txtTen.Enabled = true;
            txtLuong.Enabled = true;
            btnThem.Enabled =false;
            btnFix.Enabled = false;
            btnSave.Enabled =true;
            btnDelete.Enabled = false;
        }
        public void setNull() {
            txtMaNV.Text = "";
            txtTen.Text = "";
                txtLuong.Text = "";        
        }
        public void show(string where)
        {
            dataGridView1.DataSource = busNV.TaoBang(where);
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            show("");
            KhoaButtton();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoButtton();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
       
            MoButtton();
            setNull();
            themmoi = true;
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            MoButtton();
            
            txtMaNV.Enabled = false;
            themmoi = false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                ecNhanVien.MaNV = txtMaNV.Text;
                busNV.xoaDL(ecNhanVien);
                show("");
                MessageBox.Show("Delete successful");
                KhoaButtton();
                setNull();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ( txtTen.Text == "" || txtLuong.Text == "")
            {
                return;
            }
           else{
                if (themmoi == true)
                {
                    if (txtMaNV.Text == "") return;
                    try
                    {
                        ecNhanVien.MaNV = txtMaNV.Text;
                        ecNhanVien.TenNV = txtTen.Text;
                        ecNhanVien.LuongNV = int.Parse(txtLuong.Text);
                        busNV.themDL(ecNhanVien);
                        
                        MessageBox.Show("Du lieu them moi thanh cong");
                        

                    }
                    catch (Exception EX)
                    {
                        MessageBox.Show(EX.Message);
                    }

                }
                else
                {
                    try
                    {
                        if (txtMaNV.Text != "")
                        {
                            ecNhanVien.MaNV = txtMaNV.Text;
                        }
                        
                        ecNhanVien.TenNV = txtTen.Text;
                        ecNhanVien.LuongNV = int.Parse(txtLuong.Text);
                        busNV.suaDL(ecNhanVien);
                      
                        MessageBox.Show("Du lieu da sua thanh cong");
                       

                    }
                    catch (Exception EX)
                    {
                        MessageBox.Show(EX.Message);
                    }

                   

                }
                setNull();
                KhoaButtton();
                show("");
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == ecNhanVien.TenNV)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }

            }

        }
     
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                KhoaButtton();
                txtMaNV.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTen.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLuong.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
