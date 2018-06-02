namespace DoDuyDat_QLQuanGame_CDTH17
{
    partial class UserManager
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvNguoiDung = new System.Windows.Forms.DataGridView();
            this.nguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doDuyDat_QLQuanGame_17DataSet = new DoDuyDat_QLQuanGame_CDTH17.DoDuyDat_QLQuanGame_17DataSet();
            this.btnTaotk = new System.Windows.Forms.Button();
            this.btnXoatk = new System.Windows.Forms.Button();
            this.btnNaptien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.nguoiDungTableAdapter = new DoDuyDat_QLQuanGame_CDTH17.DoDuyDat_QLQuanGame_17DataSetTableAdapters.NguoiDungTableAdapter();
            this.btnDoimk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtSotien = new System.Windows.Forms.TextBox();
            this.iDUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doDuyDat_QLQuanGame_17DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNguoiDung);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 589);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Người Dùng";
            // 
            // dgvNguoiDung
            // 
            this.dgvNguoiDung.AutoGenerateColumns = false;
            this.dgvNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUserDataGridViewTextBoxColumn,
            this.ID_Password,
            this.iDMoneyDataGridViewTextBoxColumn});
            this.dgvNguoiDung.DataSource = this.nguoiDungBindingSource;
            this.dgvNguoiDung.Location = new System.Drawing.Point(3, 20);
            this.dgvNguoiDung.Name = "dgvNguoiDung";
            this.dgvNguoiDung.Size = new System.Drawing.Size(744, 569);
            this.dgvNguoiDung.TabIndex = 0;
            this.dgvNguoiDung.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNguoiDung_CellDoubleClick);
            // 
            // nguoiDungBindingSource
            // 
            this.nguoiDungBindingSource.DataMember = "NguoiDung";
            this.nguoiDungBindingSource.DataSource = this.doDuyDat_QLQuanGame_17DataSet;
            // 
            // doDuyDat_QLQuanGame_17DataSet
            // 
            this.doDuyDat_QLQuanGame_17DataSet.DataSetName = "DoDuyDat_QLQuanGame_17DataSet";
            this.doDuyDat_QLQuanGame_17DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTaotk
            // 
            this.btnTaotk.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaotk.Location = new System.Drawing.Point(786, 230);
            this.btnTaotk.Name = "btnTaotk";
            this.btnTaotk.Size = new System.Drawing.Size(132, 41);
            this.btnTaotk.TabIndex = 1;
            this.btnTaotk.Text = "Tạo Tài Khoản";
            this.btnTaotk.UseVisualStyleBackColor = true;
            this.btnTaotk.Click += new System.EventHandler(this.btnTaotk_Click);
            // 
            // btnXoatk
            // 
            this.btnXoatk.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoatk.Location = new System.Drawing.Point(786, 326);
            this.btnXoatk.Name = "btnXoatk";
            this.btnXoatk.Size = new System.Drawing.Size(132, 41);
            this.btnXoatk.TabIndex = 2;
            this.btnXoatk.Text = "Xóa Tài Khoản";
            this.btnXoatk.UseVisualStyleBackColor = true;
            this.btnXoatk.Click += new System.EventHandler(this.btnXoatk_Click);
            // 
            // btnNaptien
            // 
            this.btnNaptien.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaptien.Location = new System.Drawing.Point(953, 326);
            this.btnNaptien.Name = "btnNaptien";
            this.btnNaptien.Size = new System.Drawing.Size(132, 41);
            this.btnNaptien.TabIndex = 3;
            this.btnNaptien.Text = "Nạp Tiền";
            this.btnNaptien.UseVisualStyleBackColor = true;
            this.btnNaptien.Click += new System.EventHandler(this.btnNaptien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(953, 438);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(132, 41);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(783, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tài Khoản :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(783, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số Tiền :";
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Location = new System.Drawing.Point(870, 68);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(215, 20);
            this.txtTaikhoan.TabIndex = 7;
            // 
            // nguoiDungTableAdapter
            // 
            this.nguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // btnDoimk
            // 
            this.btnDoimk.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoimk.Location = new System.Drawing.Point(953, 230);
            this.btnDoimk.Name = "btnDoimk";
            this.btnDoimk.Size = new System.Drawing.Size(132, 41);
            this.btnDoimk.TabIndex = 9;
            this.btnDoimk.Text = "Đổi Mật Khẩu";
            this.btnDoimk.UseVisualStyleBackColor = true;
            this.btnDoimk.Click += new System.EventHandler(this.btnDoimk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(783, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mật Khẩu  :";
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(786, 230);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(132, 41);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(786, 438);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(132, 41);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(870, 105);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(215, 20);
            this.txtMatkhau.TabIndex = 14;
            // 
            // txtSotien
            // 
            this.txtSotien.Location = new System.Drawing.Point(870, 141);
            this.txtSotien.Name = "txtSotien";
            this.txtSotien.Size = new System.Drawing.Size(215, 20);
            this.txtSotien.TabIndex = 15;
            // 
            // iDUserDataGridViewTextBoxColumn
            // 
            this.iDUserDataGridViewTextBoxColumn.DataPropertyName = "ID_User";
            this.iDUserDataGridViewTextBoxColumn.HeaderText = "Tài Khoản";
            this.iDUserDataGridViewTextBoxColumn.Name = "iDUserDataGridViewTextBoxColumn";
            this.iDUserDataGridViewTextBoxColumn.Width = 250;
            // 
            // ID_Password
            // 
            this.ID_Password.DataPropertyName = "ID_Password";
            this.ID_Password.HeaderText = "Mật Khẩu";
            this.ID_Password.Name = "ID_Password";
            this.ID_Password.Width = 250;
            // 
            // iDMoneyDataGridViewTextBoxColumn
            // 
            this.iDMoneyDataGridViewTextBoxColumn.DataPropertyName = "ID_Money";
            this.iDMoneyDataGridViewTextBoxColumn.HeaderText = "Tiền";
            this.iDMoneyDataGridViewTextBoxColumn.Name = "iDMoneyDataGridViewTextBoxColumn";
            this.iDMoneyDataGridViewTextBoxColumn.Width = 250;
            // 
            // UserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 590);
            this.Controls.Add(this.txtSotien);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDoimk);
            this.Controls.Add(this.txtTaikhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnNaptien);
            this.Controls.Add(this.btnXoatk);
            this.Controls.Add(this.btnTaotk);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Người Dùng";
            this.Load += new System.EventHandler(this.UserManager_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doDuyDat_QLQuanGame_17DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTaotk;
        private System.Windows.Forms.Button btnXoatk;
        private System.Windows.Forms.Button btnNaptien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.DataGridView dgvNguoiDung;
        private DoDuyDat_QLQuanGame_17DataSet doDuyDat_QLQuanGame_17DataSet;
        private System.Windows.Forms.BindingSource nguoiDungBindingSource;
        private DoDuyDat_QLQuanGame_17DataSetTableAdapters.NguoiDungTableAdapter nguoiDungTableAdapter;
        private System.Windows.Forms.Button btnDoimk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtSotien;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMoneyDataGridViewTextBoxColumn;
    }
}