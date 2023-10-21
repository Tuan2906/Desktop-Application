
namespace WindowsFormsApp1
{
    partial class Behoctoan
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtso1 = new System.Windows.Forms.TextBox();
            this.txtso2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnchialaydu = new System.Windows.Forms.RadioButton();
            this.rbtnchiahet = new System.Windows.Forms.RadioButton();
            this.rbtnnhan = new System.Windows.Forms.RadioButton();
            this.rbtntru = new System.Windows.Forms.RadioButton();
            this.rbtncong = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, -3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Các Phép Tính Đơn Giản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ nhất";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(369, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số thứ hai";
            // 
            // txtso1
            // 
            this.txtso1.Location = new System.Drawing.Point(170, 106);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(100, 26);
            this.txtso1.TabIndex = 3;
            this.txtso1.MouseEnter += new System.EventHandler(this.btnTinh_Click);
            // 
            // txtso2
            // 
            this.txtso2.Location = new System.Drawing.Point(515, 109);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(100, 26);
            this.txtso2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.rbtnchialaydu);
            this.groupBox1.Controls.Add(this.rbtnchiahet);
            this.groupBox1.Controls.Add(this.rbtnnhan);
            this.groupBox1.Controls.Add(this.rbtntru);
            this.groupBox1.Controls.Add(this.rbtncong);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(91, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 138);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Phép Toán";
            // 
            // rbtnchialaydu
            // 
            this.rbtnchialaydu.AutoSize = true;
            this.rbtnchialaydu.Location = new System.Drawing.Point(424, 58);
            this.rbtnchialaydu.Name = "rbtnchialaydu";
            this.rbtnchialaydu.Size = new System.Drawing.Size(41, 24);
            this.rbtnchialaydu.TabIndex = 4;
            this.rbtnchialaydu.Text = "%";
            this.rbtnchialaydu.UseVisualStyleBackColor = true;
            // 
            // rbtnchiahet
            // 
            this.rbtnchiahet.AutoSize = true;
            this.rbtnchiahet.Location = new System.Drawing.Point(299, 58);
            this.rbtnchiahet.Name = "rbtnchiahet";
            this.rbtnchiahet.Size = new System.Drawing.Size(31, 24);
            this.rbtnchiahet.TabIndex = 3;
            this.rbtnchiahet.Text = "/";
            this.rbtnchiahet.UseVisualStyleBackColor = true;
            // 
            // rbtnnhan
            // 
            this.rbtnnhan.AutoSize = true;
            this.rbtnnhan.Location = new System.Drawing.Point(196, 58);
            this.rbtnnhan.Name = "rbtnnhan";
            this.rbtnnhan.Size = new System.Drawing.Size(38, 24);
            this.rbtnnhan.TabIndex = 2;
            this.rbtnnhan.Text = "X";
            this.rbtnnhan.UseVisualStyleBackColor = true;
            // 
            // rbtntru
            // 
            this.rbtntru.AutoSize = true;
            this.rbtntru.Location = new System.Drawing.Point(108, 58);
            this.rbtntru.Name = "rbtntru";
            this.rbtntru.Size = new System.Drawing.Size(32, 24);
            this.rbtntru.TabIndex = 1;
            this.rbtntru.Text = "-";
            this.rbtntru.UseVisualStyleBackColor = true;
            // 
            // rbtncong
            // 
            this.rbtncong.AutoSize = true;
            this.rbtncong.Checked = true;
            this.rbtncong.Location = new System.Drawing.Point(26, 58);
            this.rbtncong.Name = "rbtncong";
            this.rbtncong.Size = new System.Drawing.Size(36, 24);
            this.rbtncong.TabIndex = 0;
            this.rbtncong.TabStop = true;
            this.rbtncong.Text = "+";
            this.rbtncong.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 350);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 54);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kết qủa";
            // 
            // txtKQ
            // 
            this.txtKQ.AllowDrop = true;
            this.txtKQ.Location = new System.Drawing.Point(185, 350);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.ReadOnly = true;
            this.txtKQ.Size = new System.Drawing.Size(430, 40);
            this.txtKQ.TabIndex = 7;
            // 
            // btnTinh
            // 
            this.btnTinh.BackColor = System.Drawing.SystemColors.Control;
            this.btnTinh.ForeColor = System.Drawing.Color.Black;
            this.btnTinh.Location = new System.Drawing.Point(636, 350);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(70, 40);
            this.btnTinh.TabIndex = 8;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = false;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(799, 461);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtso2);
            this.Controls.Add(this.txtso1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Calculator";
            this.Text = "CacPhepTinh";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.MouseEnter += new System.EventHandler(this.btnTinh_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtso1;
        private System.Windows.Forms.TextBox txtso2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnchialaydu;
        private System.Windows.Forms.RadioButton rbtnchiahet;
        private System.Windows.Forms.RadioButton rbtnnhan;
        private System.Windows.Forms.RadioButton rbtntru;
        private System.Windows.Forms.RadioButton rbtncong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnTinh;
    }
}