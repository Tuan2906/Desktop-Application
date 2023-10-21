
namespace WindowsFormsApp1
{
    partial class RandomNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomNumber));
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1118 = new System.Windows.Forms.RadioButton();
            this.radiobadenmuoi = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.SystemColors.Control;
            this.lbl3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(461, 18);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(104, 105);
            this.lbl3.TabIndex = 1;
            this.lbl3.Text = "0";
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.SystemColors.Control;
            this.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(308, 18);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(103, 105);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "0";
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.SystemColors.Control;
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(142, 18);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(94, 105);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1118);
            this.groupBox1.Controls.Add(this.radiobadenmuoi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(136, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 151);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn";
            // 
            // radioButton1118
            // 
            this.radioButton1118.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1118.AutoSize = true;
            this.radioButton1118.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1118.Location = new System.Drawing.Point(221, 48);
            this.radioButton1118.Name = "radioButton1118";
            this.radioButton1118.Size = new System.Drawing.Size(82, 35);
            this.radioButton1118.TabIndex = 1;
            this.radioButton1118.Text = "11-18";
            this.radioButton1118.UseVisualStyleBackColor = true;
            // 
            // radiobadenmuoi
            // 
            this.radiobadenmuoi.Appearance = System.Windows.Forms.Appearance.Button;
            this.radiobadenmuoi.AutoSize = true;
            this.radiobadenmuoi.Checked = true;
            this.radiobadenmuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobadenmuoi.Location = new System.Drawing.Point(63, 48);
            this.radiobadenmuoi.Name = "radiobadenmuoi";
            this.radiobadenmuoi.Size = new System.Drawing.Size(69, 35);
            this.radiobadenmuoi.TabIndex = 0;
            this.radiobadenmuoi.TabStop = true;
            this.radiobadenmuoi.Text = "3-10";
            this.radiobadenmuoi.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(162, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 58);
            this.button1.TabIndex = 6;
            this.button1.Text = "Quay Số";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btQuaySo_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 47);
            this.label1.TabIndex = 7;
            this.label1.Text = "ĐIỂM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiem.ForeColor = System.Drawing.Color.Red;
            this.lblDiem.Location = new System.Drawing.Point(511, 311);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(0, 42);
            this.lblDiem.TabIndex = 8;
            this.lblDiem.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RandomNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 367);
            this.Controls.Add(this.lblDiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RandomNumber";
            this.Text = "Random number";
            this.Load += new System.EventHandler(this.RamDom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1118;
        private System.Windows.Forms.RadioButton radiobadenmuoi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDiem;
    }
}