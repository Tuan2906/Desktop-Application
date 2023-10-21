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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing.Drawing2D;
using Font = iTextSharp.text.Font;
using System.IO;
using ZXing;
using ZXing.Common;
using iText.Kernel.Font;
using NumberToWords;
using System.Drawing.Imaging;

namespace QuanLiHangKhong
{
    public partial class InFile : UserControl
    {
        public InFile()
        {
            InitializeComponent();
        }
        Bus_tableThonhTinMuaVe laythongtinTienVe = new Bus_tableThonhTinMuaVe();
        Bus_tableKhachHang1 layTTKH = new Bus_tableKhachHang1();
        public static int laymakh;
          private void InFile_Load(object sender, EventArgs e)
        {


            Showve(laymakh);
            XulyTTKH(laymakh);
        }
        private void Showve(int dieuKien)
        {
            dataGiaVe.DataSource = laythongtinTienVe.LayDuLieuTienVe(dieuKien);
        }
        private void XulyTTKH(int dieukien)
        {
            DataTable d = layTTKH.LayDuLieuTTKH(dieukien);
            if (d.Rows.Count > 0)
            {
                string hovaten = d.Rows[0]["TenKH"].ToString();
                string SoDienThoai = d.Rows[0]["SDT"].ToString();

                lblTen.Text = hovaten;
                lblSĐT.Text = SoDienThoai;
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGiaVe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        Document inpdf = new Document(PageSize.A0);
        private void btnIn_Click(object sender, EventArgs e)
        {
            
            BaseFont baseFont = BaseFont.CreateFont("C:/Users/Tuan Chau/OneDrive/Desktop/New folder/SVN-Arial 2.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font font = new Font(baseFont, 40);
            
            try
            {
                SaveFileDialog savepdf = new SaveFileDialog();
                savepdf.Filter = "PDF file(*.pdf)| *.pdf";
               
                if (savepdf.ShowDialog() == DialogResult.OK)
                {
                    PdfWriter ghiPDF = PdfWriter.GetInstance(inpdf, new FileStream(savepdf.FileName, FileMode.OpenOrCreate));
                    inpdf.Open();
                    Paragraph paragraph = new Paragraph(lblCty.Text, font);
                   // paragraph.Alignment = Element.ALIGN_LEFT; // Căn lề theo cả hai bên
                    paragraph.SetLeading(0, 1.5f);
                    inpdf.Add(paragraph);
                    TaoMaQR("link thanh toán: htttps/hacker.com");
                    Paragraph paragraph1 = new Paragraph(lblThanhToan.Text,font);
                    paragraph1.Alignment = Element.ALIGN_CENTER; // Căn lề theo cả hai bên
                    paragraph1.SetLeading(0, 1.5f);
                    inpdf.Add(paragraph1);
                    Paragraph paragraph2 = new Paragraph();
                    Chunk chunk1 = new Chunk(lblhvt.Text + ": " + lblTen.Text);
                    chunk1.Font = font;
                    paragraph2.Add(chunk1);
                    paragraph2.Add( new Chunk("                                                                                                                             " +
                        "    "));
                    Chunk chunk2 = new Chunk(lblNgayLap.Text + ":" + dtmNgayLap.Text);
                    chunk2.Font = font;
                  
                    paragraph2.Add(chunk2);
                    paragraph2.SetLeading(0, 6.5f);
                    inpdf.Add(paragraph2);
                    Paragraph paragraph3 = new Paragraph();
                    Chunk soDT = new Chunk(lblso.Text + " khách hàng " + lblSĐT.Text, font);
                    soDT.Font = font;
                    paragraph3.Add(soDT);
                    paragraph3.Add(new Chunk("                                                                                                                             " +
                        "    "));
                    Chunk ngayHetHan = new Chunk(lblNgayHetHan.Text + ": " + dtpHetHan.Text);
                    ngayHetHan.Font = font;
                    paragraph3.Add(ngayHetHan);
                    paragraph3.SetLeading(0, 4.5f);
                 
                    inpdf.Add(paragraph3);
                    Paragraph emptySpace = new Paragraph(" ");
                    inpdf.Add(emptySpace);

                    // Thêm bảng dữ liệu từ DataGridView
                    PdfPTable table = new PdfPTable(dataGiaVe.Columns.Count);
                    table.DefaultCell.Padding = 20;
                    table.WidthPercentage = 100;    
                   // table.HorizontalAlignment = Element.ALIGN_LEFT;
                    
                    for (int i = 0; i < dataGiaVe.Columns.Count; i++)
                    { 
                        table.AddCell(new Phrase(dataGiaVe.Columns[i].HeaderText,font));
                    }
                    // Them dòng mà đọc được từ csdl
                    for(int i=0;i<dataGiaVe.Rows.Count;i++)
                    {
                        for (int j = 0; j < dataGiaVe.Columns.Count; j++)
                        {
                            if (dataGiaVe.Rows[i].Cells[j].Value != null)
                            {
                                table.AddCell(new Phrase(dataGiaVe.Rows[i].Cells[j].Value.ToString(),font));
                            }
                        }

                    }
                    
                    inpdf.Add(table);
                    int sotien = int.Parse(dataGiaVe.Rows[0].Cells[5].Value.ToString());
                    ConvertToMoney a = new ConvertToMoney();
                    string chuyenTienThanhChu = a.ConvertToText(sotien);
                    Paragraph paragraph4 = new Paragraph("Tổng tiền\n", font);

                    paragraph4.Alignment = Element.ALIGN_RIGHT;

                    paragraph4.SetLeading(0, 2.5f);
                    paragraph4.IndentationRight = 200;
                    inpdf.Add(paragraph4);
                    Paragraph paragraph7 = new Paragraph(sotien.ToString() + " VNĐ", font);
                    paragraph7.Alignment = Element.ALIGN_RIGHT;
                    paragraph7.IndentationRight = 170;
                    paragraph7.SetLeading(0, 1.5f);

                    inpdf.Add(paragraph7);

                    Paragraph paragraph6 = new Paragraph(chuyenTienThanhChu, font);
                    
                   paragraph6.Alignment = Element.ALIGN_RIGHT; // Căn lề theo cả hai bên
                    paragraph6.SetLeading(0, 1.5f);
                   paragraph6.IndentationRight=60;
                    inpdf.Add(paragraph6);
                   Paragraph chuY= new Paragraph("Ghi chú"+"\n * Thanh toán online bằng cách chuyển khoản:" +"\n+ Ngân hàng: Vietcombank"+
 "\n+ STK:19000920322"+"\n+ Người thụ hưởng: Công ty Cổ Phần Hàng Không Việt Nam"+"\n•	Thanh toán trực tiếp tại quầy bán vé của công ty"+"\n•	" +
 "Lưu ý: khách hàng vui lòng thanh toán trước giờ bay 72 tiếng.Khi thanh toán " +
 "online xong thì khách hàng vui lòng gửi phiếu đã thanh toán của mình mà đã chuyển " +
 "khoản cho công ty và đưa nhân viên bán vé để kiểm tra và sau đó sẽ tiến hành in vé cho khách hàng.",font);
                    inpdf.Add(chuY);
                    Paragraph paragraph5 = new Paragraph("Người lập" +
                     "\n" + "  " + "Nguyễn châu tuấn", font);
                    paragraph5.Alignment = Element.ALIGN_RIGHT; // Căn lề theo cả hai bên
                    paragraph5.SetLeading(0, 1.5f);

                    inpdf.Add(paragraph5);
                    inpdf.Close();
                    MessageBox.Show("Xuất file pdf thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void TaoMaQR(string content)
        {
          
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap = new Bitmap(barcodeWriter.Write(content));

            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(bitmap, ImageFormat.Png);
            float qrWidth = 500; // Đặt độ rộng của mã QR
            float qrHeight = 500; // Đặt chiều cao của mã QR

            float pageWidth = inpdf.PageSize.Width - inpdf.LeftMargin - inpdf.RightMargin;
            float pageHeight = inpdf.PageSize.Height - inpdf.TopMargin - inpdf.BottomMargin;

            float x = pageWidth - qrWidth; // Đặt vị trí ngang của mã QR (qua phải)

            float y = pageHeight-qrHeight+200; // Đặt vị trí dọc ở trên của mã QR


            image.SetAbsolutePosition(x, y);
            image.ScaleToFit(qrWidth, qrHeight);

            inpdf.Add(image);
        }
    }
}
