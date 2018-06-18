namespace DoDuyDat_QLQuanGame_CDTH17
{
    partial class CreatBill
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
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListDVCheck = new System.Windows.Forms.ListBox();
            this.ListDV = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaHD2 = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtTenDA = new System.Windows.Forms.TextBox();
            this.txtCTHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btnThietlap = new System.Windows.Forms.Button();
            this.btnCreatHD = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btUnpick = new System.Windows.Forms.Button();
            this.btPick = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Hóa Đơn :";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(112, 27);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(133, 20);
            this.txtMaHD.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.ListDVCheck);
            this.groupBox1.Controls.Add(this.ListDV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.btUnpick);
            this.groupBox1.Controls.Add(this.btPick);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 566);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thực Đơn";
            // 
            // ListDVCheck
            // 
            this.ListDVCheck.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListDVCheck.FormattingEnabled = true;
            this.ListDVCheck.ItemHeight = 16;
            this.ListDVCheck.Location = new System.Drawing.Point(196, 66);
            this.ListDVCheck.Name = "ListDVCheck";
            this.ListDVCheck.Size = new System.Drawing.Size(234, 420);
            this.ListDVCheck.TabIndex = 8;
            // 
            // ListDV
            // 
            this.ListDV.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListDV.FormattingEnabled = true;
            this.ListDV.ItemHeight = 16;
            this.ListDV.Location = new System.Drawing.Point(20, 66);
            this.ListDV.Name = "ListDV";
            this.ListDV.Size = new System.Drawing.Size(147, 420);
            this.ListDV.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCTHD);
            this.groupBox2.Location = new System.Drawing.Point(466, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 384);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Hóa Đơn";
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Location = new System.Drawing.Point(6, 19);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.Size = new System.Drawing.Size(649, 365);
            this.dgvCTHD.TabIndex = 0;
            this.dgvCTHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHD_CellContentClick);
            this.dgvCTHD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHD_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtMaHD2);
            this.groupBox3.Controls.Add(this.txtSL);
            this.groupBox3.Controls.Add(this.txtTenDA);
            this.groupBox3.Controls.Add(this.txtCTHD);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtTongTien);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btUpdate);
            this.groupBox3.Location = new System.Drawing.Point(469, 402);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(652, 172);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Mã CTHĐ:";
            // 
            // txtMaHD2
            // 
            this.txtMaHD2.Location = new System.Drawing.Point(153, 13);
            this.txtMaHD2.Name = "txtMaHD2";
            this.txtMaHD2.Size = new System.Drawing.Size(128, 20);
            this.txtMaHD2.TabIndex = 25;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(153, 133);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(128, 20);
            this.txtSL.TabIndex = 24;
            // 
            // txtTenDA
            // 
            this.txtTenDA.Location = new System.Drawing.Point(153, 91);
            this.txtTenDA.Name = "txtTenDA";
            this.txtTenDA.Size = new System.Drawing.Size(128, 20);
            this.txtTenDA.TabIndex = 23;
            // 
            // txtCTHD
            // 
            this.txtCTHD.Location = new System.Drawing.Point(153, 51);
            this.txtCTHD.Name = "txtCTHD";
            this.txtCTHD.Size = new System.Drawing.Size(128, 20);
            this.txtCTHD.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Số Lượng:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(400, 13);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(130, 20);
            this.txtTongTien.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(312, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tổng Tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tên Sản Phẩm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Mã Hóa Đơn:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::DoDuyDat_QLQuanGame_CDTH17.Properties.Resources.exit;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1028, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 60);
            this.button1.TabIndex = 14;
            this.button1.Text = "Thoát";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Image = global::DoDuyDat_QLQuanGame_CDTH17.Properties.Resources.update;
            this.btUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUpdate.Location = new System.Drawing.Point(315, 94);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(111, 59);
            this.btUpdate.TabIndex = 16;
            this.btUpdate.Text = "Cập Nhật";
            this.btUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btnThietlap
            // 
            this.btnThietlap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThietlap.Image = global::DoDuyDat_QLQuanGame_CDTH17.Properties.Resources.add;
            this.btnThietlap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThietlap.Location = new System.Drawing.Point(340, 594);
            this.btnThietlap.Name = "btnThietlap";
            this.btnThietlap.Size = new System.Drawing.Size(99, 60);
            this.btnThietlap.TabIndex = 12;
            this.btnThietlap.Text = "Tạo và thiết lập";
            this.btnThietlap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThietlap.UseVisualStyleBackColor = true;
            this.btnThietlap.Click += new System.EventHandler(this.btnThietlap_Click);
            // 
            // btnCreatHD
            // 
            this.btnCreatHD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatHD.Image = global::DoDuyDat_QLQuanGame_CDTH17.Properties.Resources.createbill;
            this.btnCreatHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreatHD.Location = new System.Drawing.Point(855, 594);
            this.btnCreatHD.Name = "btnCreatHD";
            this.btnCreatHD.Size = new System.Drawing.Size(110, 60);
            this.btnCreatHD.TabIndex = 9;
            this.btnCreatHD.Text = "Hoàn Tất";
            this.btnCreatHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreatHD.UseVisualStyleBackColor = true;
            this.btnCreatHD.Click += new System.EventHandler(this.btnCreatHD_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::DoDuyDat_QLQuanGame_CDTH17.Properties.Resources.cancel;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(746, 594);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 60);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Hủy";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::DoDuyDat_QLQuanGame_CDTH17.Properties.Resources.uncheckall;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(331, 503);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(99, 47);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy Tất";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btUnpick
            // 
            this.btUnpick.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUnpick.Image = global::DoDuyDat_QLQuanGame_CDTH17.Properties.Resources.uncheck;
            this.btUnpick.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUnpick.Location = new System.Drawing.Point(196, 503);
            this.btUnpick.Name = "btUnpick";
            this.btUnpick.Size = new System.Drawing.Size(107, 47);
            this.btUnpick.TabIndex = 7;
            this.btUnpick.Text = "Bỏ Chọn";
            this.btUnpick.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btUnpick.UseVisualStyleBackColor = true;
            this.btUnpick.Click += new System.EventHandler(this.btUnpick_Click);
            // 
            // btPick
            // 
            this.btPick.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPick.Image = global::DoDuyDat_QLQuanGame_CDTH17.Properties.Resources.check;
            this.btPick.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPick.Location = new System.Drawing.Point(20, 503);
            this.btPick.Name = "btPick";
            this.btPick.Size = new System.Drawing.Size(89, 47);
            this.btPick.TabIndex = 6;
            this.btPick.Text = "Chọn";
            this.btPick.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPick.UseVisualStyleBackColor = true;
            this.btPick.Click += new System.EventHandler(this.btPick_Click);
            // 
            // CreatBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 666);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnThietlap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCreatHD);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreatBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo Hóa Đơn";
            this.Load += new System.EventHandler(this.CreatBill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ListDV;
        private System.Windows.Forms.Button btnCreatHD;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btUnpick;
        private System.Windows.Forms.Button btPick;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.ListBox ListDVCheck;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThietlap;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaHD2;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtTenDA;
        private System.Windows.Forms.TextBox txtCTHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}