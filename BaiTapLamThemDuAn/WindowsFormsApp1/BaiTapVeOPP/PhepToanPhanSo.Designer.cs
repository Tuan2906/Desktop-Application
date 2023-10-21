
namespace BaiTapVeOPP
{
    partial class PhepToanPhanSo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMauSo2 = new System.Windows.Forms.TextBox();
            this.txtTuSo2 = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.txtMauSo3 = new System.Windows.Forms.TextBox();
            this.txtTuso1 = new System.Windows.Forms.TextBox();
            this.txtMauSo1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblToanTu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btTru = new System.Windows.Forms.Button();
            this.btNhan = new System.Windows.Forms.Button();
            this.btChia = new System.Windows.Forms.Button();
            this.txtTuSo3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(32, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÁC PHÉP TÍNH TRÊN PHÂN SỐ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMauSo2
            // 
            this.txtMauSo2.Location = new System.Drawing.Point(22, 91);
            this.txtMauSo2.Multiline = true;
            this.txtMauSo2.Name = "txtMauSo2";
            this.txtMauSo2.Size = new System.Drawing.Size(97, 42);
            this.txtMauSo2.TabIndex = 3;
            this.txtMauSo2.TextChanged += new System.EventHandler(this.txtMauSo2_TextChanged);
            // 
            // txtTuSo2
            // 
            this.txtTuSo2.Location = new System.Drawing.Point(22, 20);
            this.txtTuSo2.Multiline = true;
            this.txtTuSo2.Name = "txtTuSo2";
            this.txtTuSo2.Size = new System.Drawing.Size(97, 41);
            this.txtTuSo2.TabIndex = 1;
            this.txtTuSo2.TextChanged += new System.EventHandler(this.txttuSo2_TextChanged);
            // 
            // btnCong
            // 
            this.btnCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCong.ForeColor = System.Drawing.Color.Orange;
            this.btnCong.Location = new System.Drawing.Point(208, 289);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(54, 42);
            this.btnCong.TabIndex = 5;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // txtMauSo3
            // 
            this.txtMauSo3.Enabled = false;
            this.txtMauSo3.Location = new System.Drawing.Point(19, 91);
            this.txtMauSo3.Multiline = true;
            this.txtMauSo3.Name = "txtMauSo3";
            this.txtMauSo3.Size = new System.Drawing.Size(100, 42);
            this.txtMauSo3.TabIndex = 3;
            this.txtMauSo3.TextChanged += new System.EventHandler(this.txtMauSoKQ_TextChanged);
            // 
            // txtTuso1
            // 
            this.txtTuso1.Location = new System.Drawing.Point(21, 20);
            this.txtTuso1.Multiline = true;
            this.txtTuso1.Name = "txtTuso1";
            this.txtTuso1.Size = new System.Drawing.Size(93, 41);
            this.txtTuso1.TabIndex = 1;
            this.txtTuso1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMauSo1
            // 
            this.txtMauSo1.Location = new System.Drawing.Point(21, 91);
            this.txtMauSo1.Multiline = true;
            this.txtMauSo1.Name = "txtMauSo1";
            this.txtMauSo1.Size = new System.Drawing.Size(93, 42);
            this.txtMauSo1.TabIndex = 3;
            this.txtMauSo1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.txtTuso1);
            this.panel1.Controls.Add(this.txtMauSo1);
            this.panel1.Location = new System.Drawing.Point(32, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 146);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.txtTuSo2);
            this.panel2.Controls.Add(this.txtMauSo2);
            this.panel2.Location = new System.Drawing.Point(278, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 146);
            this.panel2.TabIndex = 8;
            // 
            // lblToanTu
            // 
            this.lblToanTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToanTu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblToanTu.Location = new System.Drawing.Point(212, 169);
            this.lblToanTu.Name = "lblToanTu";
            this.lblToanTu.Size = new System.Drawing.Size(35, 34);
            this.lblToanTu.TabIndex = 9;
            this.lblToanTu.Text = "+";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(456, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "=";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.txtMauSo3);
            this.panel3.Controls.Add(this.txtTuSo3);
            this.panel3.Location = new System.Drawing.Point(516, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(145, 146);
            this.panel3.TabIndex = 11;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btTru
            // 
            this.btTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTru.ForeColor = System.Drawing.Color.Orange;
            this.btTru.Location = new System.Drawing.Point(288, 289);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(52, 42);
            this.btTru.TabIndex = 12;
            this.btTru.Text = "-";
            this.btTru.UseVisualStyleBackColor = true;
            // 
            // btNhan
            // 
            this.btNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhan.ForeColor = System.Drawing.Color.Orange;
            this.btNhan.Location = new System.Drawing.Point(361, 289);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(51, 42);
            this.btNhan.TabIndex = 13;
            this.btNhan.Text = "*";
            this.btNhan.UseVisualStyleBackColor = true;
            // 
            // btChia
            // 
            this.btChia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChia.ForeColor = System.Drawing.Color.Orange;
            this.btChia.Location = new System.Drawing.Point(438, 289);
            this.btChia.Name = "btChia";
            this.btChia.Size = new System.Drawing.Size(58, 42);
            this.btChia.TabIndex = 14;
            this.btChia.Text = "/";
            this.btChia.UseVisualStyleBackColor = true;
            // 
            // txtTuSo3
            // 
            this.txtTuSo3.Enabled = false;
            this.txtTuSo3.Location = new System.Drawing.Point(19, 20);
            this.txtTuSo3.Multiline = true;
            this.txtTuSo3.Name = "txtTuSo3";
            this.txtTuSo3.Size = new System.Drawing.Size(100, 41);
            this.txtTuSo3.TabIndex = 1;
            this.txtTuSo3.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(21, 71);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 10);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(22, 71);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(97, 10);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_2);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(19, 71);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 10);
            this.textBox4.TabIndex = 15;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox2_TextChanged_2);
            // 
            // PhepToanPhanSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(677, 337);
            this.Controls.Add(this.btChia);
            this.Controls.Add(this.btNhan);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblToanTu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "PhepToanPhanSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhanSo";
            this.Load += new System.EventHandler(this.PhanSo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMauSo2;
        private System.Windows.Forms.TextBox txtTuSo2;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.TextBox txtMauSo3;
        private System.Windows.Forms.TextBox txtTuso1;
        private System.Windows.Forms.TextBox txtMauSo1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblToanTu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btTru;
        private System.Windows.Forms.Button btNhan;
        private System.Windows.Forms.Button btChia;
        private System.Windows.Forms.TextBox txtTuSo3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
    }
}