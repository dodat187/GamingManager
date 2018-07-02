namespace DoDuyDat_QLQuanGame_CDTH17.Forms
{
    partial class PCService
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTinhtien = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCTSD = new System.Windows.Forms.DataGridView();
            this.maCTSDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTietSuDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doDuyDat_QLQuanGame_17DataSet = new DoDuyDat_QLQuanGame_CDTH17.DoDuyDat_QLQuanGame_17DataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbPC = new System.Windows.Forms.ComboBox();
            this.cbbUser = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaCTSD = new System.Windows.Forms.TextBox();
            this.chiTietSuDungTableAdapter = new DoDuyDat_QLQuanGame_CDTH17.DoDuyDat_QLQuanGame_17DataSetTableAdapters.ChiTietSuDungTableAdapter();
            this.txtHidden = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietSuDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doDuyDat_QLQuanGame_17DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::DoDuyDat_QLQuanGame_CDTH17.Properties.Resources.exit;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1004, 591);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(114, 59);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTinhtien
            // 
            this.btnTinhtien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhtien.Image = global::DoDuyDat_QLQuanGame_CDTH17.Properties.Resources.bill;
            this.btnTinhtien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTinhtien.Location = new System.Drawing.Point(831, 591);
            this.btnTinhtien.Name = "btnTinhtien";
            this.btnTinhtien.Size = new System.Drawing.Size(111, 59);
            this.btnTinhtien.TabIndex = 25;
            this.btnTinhtien.Text = "Tính Tiền";
            this.btnTinhtien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTinhtien.UseVisualStyleBackColor = true;
            this.btnTinhtien.Click += new System.EventHandler(this.btnTinhtien_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(830, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Thành Tiền :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(830, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Thời gian sử dụng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(829, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tên Máy :";
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Image = global::DoDuyDat_QLQuanGame_CDTH17.Properties.Resources.uncheck;
            this.btnEnd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnd.Location = new System.Drawing.Point(1004, 416);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(114, 59);
            this.btnEnd.TabIndex = 22;
            this.btnEnd.Text = "Kết Thúc";
            this.btnEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 661);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết Sử Dụng Máy";
            // 
            // dgvCTSD
            // 
            this.dgvCTSD.AutoGenerateColumns = false;
            this.dgvCTSD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTSD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCTSDDataGridViewTextBoxColumn,
            this.iDPCDataGridViewTextBoxColumn,
            this.iDUserDataGridViewTextBoxColumn,
            this.stimeDataGridViewTextBoxColumn,
            this.etimeDataGridViewTextBoxColumn});
            this.dgvCTSD.DataSource = this.chiTietSuDungBindingSource;
            this.dgvCTSD.Location = new System.Drawing.Point(3, 19);
            this.dgvCTSD.Name = "dgvCTSD";
            this.dgvCTSD.Size = new System.Drawing.Size(796, 643);
            this.dgvCTSD.TabIndex = 32;
            this.dgvCTSD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTSD_CellDoubleClick);
            // 
            // maCTSDDataGridViewTextBoxColumn
            // 
            this.maCTSDDataGridViewTextBoxColumn.DataPropertyName = "MaCTSD";
            this.maCTSDDataGridViewTextBoxColumn.HeaderText = "Mã CTSD";
            this.maCTSDDataGridViewTextBoxColumn.Name = "maCTSDDataGridViewTextBoxColumn";
            this.maCTSDDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDPCDataGridViewTextBoxColumn
            // 
            this.iDPCDataGridViewTextBoxColumn.DataPropertyName = "ID_PC";
            this.iDPCDataGridViewTextBoxColumn.HeaderText = "Mã Máy";
            this.iDPCDataGridViewTextBoxColumn.Name = "iDPCDataGridViewTextBoxColumn";
            this.iDPCDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDUserDataGridViewTextBoxColumn
            // 
            this.iDUserDataGridViewTextBoxColumn.DataPropertyName = "ID_User";
            this.iDUserDataGridViewTextBoxColumn.HeaderText = "Tài Khoản";
            this.iDUserDataGridViewTextBoxColumn.Name = "iDUserDataGridViewTextBoxColumn";
            this.iDUserDataGridViewTextBoxColumn.Width = 150;
            // 
            // stimeDataGridViewTextBoxColumn
            // 
            this.stimeDataGridViewTextBoxColumn.DataPropertyName = "Stime";
            this.stimeDataGridViewTextBoxColumn.HeaderText = "Thời Gian Bắt Đầu";
            this.stimeDataGridViewTextBoxColumn.Name = "stimeDataGridViewTextBoxColumn";
            this.stimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // etimeDataGridViewTextBoxColumn
            // 
            this.etimeDataGridViewTextBoxColumn.DataPropertyName = "Etime";
            this.etimeDataGridViewTextBoxColumn.HeaderText = "Thời Gian Kết Thúc";
            this.etimeDataGridViewTextBoxColumn.Name = "etimeDataGridViewTextBoxColumn";
            this.etimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // chiTietSuDungBindingSource
            // 
            this.chiTietSuDungBindingSource.DataMember = "ChiTietSuDung";
            this.chiTietSuDungBindingSource.DataSource = this.doDuyDat_QLQuanGame_17DataSet;
            // 
            // doDuyDat_QLQuanGame_17DataSet
            // 
            this.doDuyDat_QLQuanGame_17DataSet.DataSetName = "DoDuyDat_QLQuanGame_17DataSet";
            this.doDuyDat_QLQuanGame_17DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(832, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "User : ";
            // 
            // cbbPC
            // 
            this.cbbPC.FormattingEnabled = true;
            this.cbbPC.Location = new System.Drawing.Point(913, 65);
            this.cbbPC.Name = "cbbPC";
            this.cbbPC.Size = new System.Drawing.Size(121, 21);
            this.cbbPC.TabIndex = 34;
            // 
            // cbbUser
            // 
            this.cbbUser.FormattingEnabled = true;
            this.cbbUser.Location = new System.Drawing.Point(913, 128);
            this.cbbUser.Name = "cbbUser";
            this.cbbUser.Size = new System.Drawing.Size(121, 21);
            this.cbbUser.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(828, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Kết Thúc :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(828, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Bắt Đầu :";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Image = global::DoDuyDat_QLQuanGame_CDTH17.Properties.Resources.logout;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(831, 416);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(103, 59);
            this.btnStart.TabIndex = 36;
            this.btnStart.Text = "Bắt Đầu";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(913, 187);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(121, 20);
            this.txtStart.TabIndex = 37;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(913, 241);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(121, 20);
            this.txtEnd.TabIndex = 38;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(963, 301);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(155, 20);
            this.txtTime.TabIndex = 39;
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(963, 358);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(155, 20);
            this.txtTien.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(828, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "Mã CTSD :";
            // 
            // txtMaCTSD
            // 
            this.txtMaCTSD.Location = new System.Drawing.Point(913, 15);
            this.txtMaCTSD.Name = "txtMaCTSD";
            this.txtMaCTSD.Size = new System.Drawing.Size(121, 20);
            this.txtMaCTSD.TabIndex = 42;
            // 
            // chiTietSuDungTableAdapter
            // 
            this.chiTietSuDungTableAdapter.ClearBeforeFill = true;
            // 
            // txtHidden
            // 
            this.txtHidden.Location = new System.Drawing.Point(963, 321);
            this.txtHidden.Name = "txtHidden";
            this.txtHidden.Size = new System.Drawing.Size(155, 20);
            this.txtHidden.TabIndex = 43;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Image = global::DoDuyDat_QLQuanGame_CDTH17.Properties.Resources.refresh;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(1004, 507);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(116, 58);
            this.btnReset.TabIndex = 44;
            this.btnReset.Text = "Làm mới";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // PCService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 666);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtHidden);
            this.Controls.Add(this.txtMaCTSD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTien);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbbUser);
            this.Controls.Add(this.cbbPC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvCTSD);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinhtien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PCService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thiết Bị";
            this.Load += new System.EventHandler(this.PCService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietSuDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doDuyDat_QLQuanGame_17DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTinhtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCTSD;
        private DoDuyDat_QLQuanGame_17DataSet doDuyDat_QLQuanGame_17DataSet;
        private System.Windows.Forms.BindingSource chiTietSuDungBindingSource;
        private DoDuyDat_QLQuanGame_17DataSetTableAdapters.ChiTietSuDungTableAdapter chiTietSuDungTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbPC;
        private System.Windows.Forms.ComboBox cbbUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaCTSD;
        private System.Windows.Forms.TextBox txtHidden;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCTSDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnReset;
    }
}