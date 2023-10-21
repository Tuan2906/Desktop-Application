
namespace version1
{
    partial class FlappyBird
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlappyBird));
            this.ongtru1 = new System.Windows.Forms.PictureBox();
            this.ongtruduoi = new System.Windows.Forms.PictureBox();
            this.ongtruc2 = new System.Windows.Forms.PictureBox();
            this.ongtrucduoi2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.conchim = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblgameover = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ongtru1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongtruduoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongtruc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongtrucduoi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conchim)).BeginInit();
            this.SuspendLayout();
            // 
            // ongtru1
            // 
            this.ongtru1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.ongtru1, "ongtru1");
            this.ongtru1.Name = "ongtru1";
            this.ongtru1.TabStop = false;
            this.ongtru1.Click += new System.EventHandler(this.ongtru1_Click);
            // 
            // ongtruduoi
            // 
            resources.ApplyResources(this.ongtruduoi, "ongtruduoi");
            this.ongtruduoi.Name = "ongtruduoi";
            this.ongtruduoi.TabStop = false;
            // 
            // ongtruc2
            // 
            this.ongtruc2.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.ongtruc2, "ongtruc2");
            this.ongtruc2.Name = "ongtruc2";
            this.ongtruc2.TabStop = false;
            // 
            // ongtrucduoi2
            // 
            resources.ApplyResources(this.ongtrucduoi2, "ongtrucduoi2");
            this.ongtrucduoi2.Name = "ongtrucduoi2";
            this.ongtrucduoi2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // conchim
            // 
            this.conchim.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.conchim, "conchim");
            this.conchim.Name = "conchim";
            this.conchim.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblDiem
            // 
            this.lblDiem.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblDiem, "lblDiem");
            this.lblDiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.btnPlay, "btnPlay");
            this.btnPlay.ForeColor = System.Drawing.Color.Red;
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            this.btnPlay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FlappyBird_KeyDown);
            // 
            // lblgameover
            // 
            this.lblgameover.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblgameover, "lblgameover");
            this.lblgameover.ForeColor = System.Drawing.Color.Red;
            this.lblgameover.Name = "lblgameover";
            this.lblgameover.UseWaitCursor = true;
            this.lblgameover.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // FlappyBird
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblgameover);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblDiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conchim);
            this.Controls.Add(this.ongtrucduoi2);
            this.Controls.Add(this.ongtruc2);
            this.Controls.Add(this.ongtruduoi);
            this.Controls.Add(this.ongtru1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FlappyBird";
            this.Load += new System.EventHandler(this.FlappyBird_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FlappyBird_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ongtru1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongtruduoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongtruc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongtrucduoi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conchim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox ongtru1;
        private System.Windows.Forms.PictureBox ongtruduoi;
        public System.Windows.Forms.PictureBox ongtruc2;
        private System.Windows.Forms.PictureBox ongtrucduoi2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox conchim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblgameover;
    }
}

