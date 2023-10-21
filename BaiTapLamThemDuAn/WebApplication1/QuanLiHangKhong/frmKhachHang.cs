using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHangKhongEntity;
using QuanLyHangKhongBUS;

namespace QuanLiHangKhong
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        public static string gaDi, gaDen,loaive,MaCB;
        private List<string> arrLuu = new List<string>();
        private List<string> arrLaySoGhe = new List<string>();
       
        private const int thue = 500000;
        public static List<double> soTien= new List<double>();
        public static int demSoluongKHachDatVe;
        public static bool check = true;
        EC_ThongTinMuaVe ec_muave = new EC_ThongTinMuaVe();
        Bus_tableKhachHang1 bus_TableKhachHang1 = new Bus_tableKhachHang1();
        EC_tableKhachHang EC_TableKhach = new EC_tableKhachHang();
        Bus_tableThonhTinMuaVe bus_TableThonhTinMuaVe = new Bus_tableThonhTinMuaVe();
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            EC_tableChuyenBay ec = new EC_tableChuyenBay();
            txtGaDi.Text = gaDi;
            txtGaDen.Text =gaDen;
            
         //  dataGridView1.DataSource = bus_TableKhachHang1.LayDuLieuKH("");
         
            if (demSoluongKHachDatVe >= 1)
            {
                
                moButton();
              
            }
            
            if (check == false)
            {
                picLeftArrow.Visible = true;
            }
            else{

                picLeftArrow.Visible = false;
            }
            
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }
        // de day r lam tiep xu li cach khong trung maKH

     
        private void  khoaButton()
        {
            btnChonGhe.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false; 
        }
        private void moButton()
        {
            btnChonGhe.Enabled =false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false ;
            btnLuu.Enabled = true;
        }
        private void setNull()
        {
            txtHoVaTen.Clear();
            txtSDT.Clear();
            txtHoVaTen.Focus();
        }
        private void moButtoon()
        {
            btnSua.Enabled = true;
            
        }
        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            check = true;
            frmDatVe f = new frmDatVe();
            f.Show();
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGaDi_TextChanged(object sender, EventArgs e)
        {

        }
        frmChonghe chonghe = new frmChonghe();
        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            
            chonghe.Show();
        }
       
        int demsoluotnhap = 0;

      
        public List<string> ArrLuu { get => arrLuu; set => arrLuu = value; }
        public List<string> ArrLaySoGhe { get => arrLaySoGhe; set => arrLaySoGhe = value; }
     

        // Khac phuc van de chon so luong 2 nhung ma luu chi 1 và csdl thi luu trung 
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtHoVaTen.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Nhap khong dung dinh dang", "Thong Bao!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                setNull();
                return;
            }
            demsoluotnhap++;
           
            dataGridView1.DataSource = bus_TableKhachHang1.LayDuLieuKH("");

            if (dataGridView1.Rows.Count > 1)
            {
                int t1;

                t1 = int.Parse(dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value.ToString());
                t1++;
                luuThongTinhKH(t1);
                luuThongTinVe(t1);
                
            }
            else
            {
                luuThongTinhKH(demsoluotnhap);
                luuThongTinVe(demsoluotnhap);
            }
            setNull();
        
            if (demsoluotnhap == demSoluongKHachDatVe)
            {
                khoaButton();
            }
            

        }
        
        private void luuThongTinVe(int dem)
        {
            int j= 0;
                 
                for (int i = 0; i < arrLuu.Count; i++)
                {
                       // lay macb dem qua cho cho chọn ghế;
                    ec_muave.MaCB1 = arrLuu[i].ToString();
                    ec_muave.MAKH1 = dem;//1//1
                    chonghe.ArrLayMaCBDaChon1.Add(ec_muave.MaCB1); 
                    chonghe.ArrLayMaKH1.Add(ec_muave.MAKH1);//1
                    ec_muave.Tinhtrang = "ChuaThanhToan";
                      if (rdChild.Checked)
                        {
                            double tienGiam = Math.Round(soTien[j] - soTien[j] * 0.5);
                            ec_muave.Sotien = (demSoluongKHachDatVe * tienGiam + thue);

                        }
                        else
                        {
                            ec_muave.Sotien = (demSoluongKHachDatVe * soTien[j] + thue);
                        }
                        if (loaive.Contains("Khứ hồi"))
                        {
                           ec_muave.Sotien *= 2;
                           ec_muave.Soluongmua = (demSoluongKHachDatVe *2).ToString();
                         }
                    
                    // txtTien.Text = ec_muave.Sotien.ToString();
                    ec_muave.Thue = thue.ToString();
                    ec_muave.Soluongmua = demSoluongKHachDatVe.ToString();
                    ec_muave.Soghe = "";
                    ec_muave.Loaive = loaive;
                    bus_TableThonhTinMuaVe.themDL(ec_muave);
                  j++;
                }
              
        }
        private void luuThongTinhKH(int dem)
        {
            EC_TableKhach.MAKH1 = dem;

            EC_TableKhach.TenKH1 = txtHoVaTen.Text;
            if (txtSDT.Text.Length > 11)
            {
                MessageBox.Show("Vui long nhap lai!So dien thoai phai toi da 10 den 11 ki tu", "Thong bao!!!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtSDT.Text = "";
            }
            else
            {
                EC_TableKhach.SDT1 = txtSDT.Text;
                EC_TableKhach.NgaySinh1 = dtNgaySinh.Text;
                EC_TableKhach.GoiTinh = rdbNam.Checked ? rdbNam.Text : rdbNu.Text;
                EC_TableKhach.GhChu = rdChild.Checked ? rdChild.Text : rdOld.Text;
            }
            bus_TableKhachHang1.themDL(EC_TableKhach);
        }
     

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
