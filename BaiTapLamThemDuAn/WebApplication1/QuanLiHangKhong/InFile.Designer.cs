
namespace QuanLiHangKhong
{
    partial class InFile
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblThanhToan = new System.Windows.Forms.Label();
            this.dataGiaVe = new System.Windows.Forms.DataGridView();
            this.lblhvt = new System.Windows.Forms.Label();
            this.lblso = new System.Windows.Forms.Label();
            this.lblSĐT = new System.Windows.Forms.Label();
            this.lblCty = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.lblNgayHetHan = new System.Windows.Forms.Label();
            this.dtmNgayLap = new System.Windows.Forms.DateTimePicker();
            this.dtpHetHan = new System.Windows.Forms.DateTimePicker();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGiaVe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhToan.Location = new System.Drawing.Point(9, 26);
            this.lblThanhToan.Name = "lblThanhToan";
            this.lblThanhToan.Size = new System.Drawing.Size(713, 67);
            this.lblThanhToan.TabIndex = 0;
            this.lblThanhToan.Text = "Phiếu thanh toán";
            this.lblThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblThanhToan.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGiaVe
            // 
            this.dataGiaVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGiaVe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.MaCB,
            this.SoTien,
            this.thue,
            this.SoLuong,
            this.thanhTien});
            this.dataGiaVe.Location = new System.Drawing.Point(3, 202);
            this.dataGiaVe.Name = "dataGiaVe";
            this.dataGiaVe.Size = new System.Drawing.Size(794, 143);
            this.dataGiaVe.TabIndex = 1;
            this.dataGiaVe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGiaVe_CellContentClick);
            // 
            // lblhvt
            // 
            this.lblhvt.AutoSize = true;
            this.lblhvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhvt.Location = new System.Drawing.Point(2, 93);
            this.lblhvt.Name = "lblhvt";
            this.lblhvt.Size = new System.Drawing.Size(220, 24);
            this.lblhvt.TabIndex = 3;
            this.lblhvt.Text = "Họ và tên khách hàng:";
            // 
            // lblso
            // 
            this.lblso.AutoSize = true;
            this.lblso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblso.Location = new System.Drawing.Point(12, 156);
            this.lblso.Name = "lblso";
            this.lblso.Size = new System.Drawing.Size(151, 25);
            this.lblso.TabIndex = 4;
            this.lblso.Text = "Số điện thoại";
            // 
            // lblSĐT
            // 
            this.lblSĐT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSĐT.Location = new System.Drawing.Point(216, 156);
            this.lblSĐT.Name = "lblSĐT";
            this.lblSĐT.Size = new System.Drawing.Size(295, 23);
            this.lblSĐT.TabIndex = 5;
            // 
            // lblCty
            // 
            this.lblCty.AutoSize = true;
            this.lblCty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCty.Location = new System.Drawing.Point(13, 10);
            this.lblCty.Name = "lblCty";
            this.lblCty.Size = new System.Drawing.Size(389, 24);
            this.lblCty.TabIndex = 6;
            this.lblCty.Text = "Công Ty Cổ Phấn Hàng Không Việt Nam";
            this.lblCty.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblTen
            // 
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(228, 93);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(199, 33);
            this.lblTen.TabIndex = 2;
            this.lblTen.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(863, 368);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(83, 44);
            this.btnIn.TabIndex = 7;
            this.btnIn.Text = "In và gửi file";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLap.Location = new System.Drawing.Point(466, 93);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(92, 24);
            this.lblNgayLap.TabIndex = 9;
            this.lblNgayLap.Text = "Ngày lập";
            // 
            // lblNgayHetHan
            // 
            this.lblNgayHetHan.AutoSize = true;
            this.lblNgayHetHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayHetHan.Location = new System.Drawing.Point(457, 156);
            this.lblNgayHetHan.Name = "lblNgayHetHan";
            this.lblNgayHetHan.Size = new System.Drawing.Size(238, 24);
            this.lblNgayHetHan.TabIndex = 11;
            this.lblNgayHetHan.Text = "Ngày hết hạn thanh toán";
            // 
            // dtmNgayLap
            // 
            this.dtmNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtmNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgayLap.Location = new System.Drawing.Point(722, 97);
            this.dtmNgayLap.Name = "dtmNgayLap";
            this.dtmNgayLap.Size = new System.Drawing.Size(200, 20);
            this.dtmNgayLap.TabIndex = 12;
            this.dtmNgayLap.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpHetHan
            // 
            this.dtpHetHan.CustomFormat = "dd/MM/yyyy";
            this.dtpHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHetHan.Location = new System.Drawing.Point(722, 161);
            this.dtpHetHan.Name = "dtpHetHan";
            this.dtpHetHan.Size = new System.Drawing.Size(200, 20);
            this.dtpHetHan.TabIndex = 13;
            // 
            // MaKH
            // 
            this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKH.DataPropertyName = "MAKH";
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.Name = "MaKH";
            // 
            // MaCB
            // 
            this.MaCB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaCB.DataPropertyName = "macb";
            this.MaCB.HeaderText = "Mã Chuyến bay";
            this.MaCB.Name = "MaCB";
            // 
            // SoTien
            // 
            this.SoTien.DataPropertyName = "thanhtien";
            this.SoTien.HeaderText = "Số Tiền";
            this.SoTien.Name = "SoTien";
            // 
            // thue
            // 
            this.thue.DataPropertyName = "thue";
            this.thue.HeaderText = "Thuế";
            this.thue.Name = "thue";
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.DataPropertyName = "soluongmua";
            this.SoLuong.FillWeight = 50F;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // thanhTien
            // 
            this.thanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thanhTien.DataPropertyName = "sotien";
            this.thanhTien.HeaderText = "Thành tiền(VNĐ)";
            this.thanhTien.Name = "thanhTien";
            // 
            // InFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpHetHan);
            this.Controls.Add(this.dtmNgayLap);
            this.Controls.Add(this.lblNgayHetHan);
            this.Controls.Add(this.lblNgayLap);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.lblCty);
            this.Controls.Add(this.lblSĐT);
            this.Controls.Add(this.lblso);
            this.Controls.Add(this.lblhvt);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.dataGiaVe);
            this.Controls.Add(this.lblThanhToan);
            this.Name = "InFile";
            this.Size = new System.Drawing.Size(1010, 412);
            this.Load += new System.EventHandler(this.InFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGiaVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThanhToan;
        private System.Windows.Forms.DataGridView dataGiaVe;
        private System.Windows.Forms.Label lblhvt;
        private System.Windows.Forms.Label lblso;
        private System.Windows.Forms.Label lblSĐT;
        private System.Windows.Forms.Label lblCty;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.Label lblNgayHetHan;
        private System.Windows.Forms.DateTimePicker dtmNgayLap;
        private System.Windows.Forms.DateTimePicker dtpHetHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn thue;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTien;
    }
}
