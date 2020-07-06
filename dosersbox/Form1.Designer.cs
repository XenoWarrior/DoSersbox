namespace dosersbox
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dosbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ipadd = new System.Windows.Forms.TextBox();
            this.mode = new System.Windows.Forms.ComboBox();
            this.resb = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.packetsize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.packetcount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.portin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dosbtn
            // 
            this.dosbtn.Location = new System.Drawing.Point(799, 386);
            this.dosbtn.Name = "dosbtn";
            this.dosbtn.Size = new System.Drawing.Size(75, 23);
            this.dosbtn.TabIndex = 0;
            this.dosbtn.Text = "DOS!";
            this.dosbtn.UseVisualStyleBackColor = true;
            this.dosbtn.Click += new System.EventHandler(this.dosbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Adress";
            // 
            // ipadd
            // 
            this.ipadd.Location = new System.Drawing.Point(146, 52);
            this.ipadd.Name = "ipadd";
            this.ipadd.Size = new System.Drawing.Size(100, 22);
            this.ipadd.TabIndex = 2;
            // 
            // mode
            // 
            this.mode.FormattingEnabled = true;
            this.mode.Items.AddRange(new object[] {
            "UDP",
            "TCP"});
            this.mode.Location = new System.Drawing.Point(146, 118);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(121, 24);
            this.mode.TabIndex = 3;
            // 
            // resb
            // 
            this.resb.AllowDrop = true;
            this.resb.AutoSize = true;
            this.resb.Location = new System.Drawing.Point(220, 379);
            this.resb.Name = "resb";
            this.resb.Size = new System.Drawing.Size(573, 38);
            this.resb.TabIndex = 4;
            this.resb.Text = "By using this program, User is taking full responsibility for their actions.\r\nThe" +
    " author of this program is not responsible for any damage caused by this program" +
    ".";
            this.resb.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mode";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(380, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 310);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // packetsize
            // 
            this.packetsize.Location = new System.Drawing.Point(146, 254);
            this.packetsize.Name = "packetsize";
            this.packetsize.Size = new System.Drawing.Size(100, 22);
            this.packetsize.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Packet Size";
            // 
            // packetcount
            // 
            this.packetcount.Location = new System.Drawing.Point(146, 322);
            this.packetcount.Name = "packetcount";
            this.packetcount.Size = new System.Drawing.Size(100, 22);
            this.packetcount.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Packet Count";
            // 
            // portin
            // 
            this.portin.Location = new System.Drawing.Point(146, 179);
            this.portin.Name = "portin";
            this.portin.Size = new System.Drawing.Size(100, 22);
            this.portin.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Port";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(55, 392);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(62, 17);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "By fedqx";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.portin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.packetcount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.packetsize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resb);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.ipadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dosbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.Text = "DoSer\'s Box";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dosbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipadd;
        private System.Windows.Forms.ComboBox mode;
        private System.Windows.Forms.CheckBox resb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox packetsize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox packetcount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox portin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

