namespace DoDuyDat_QLQuanGame_CDTH17
{
    partial class PhanQuyen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbUser = new System.Windows.Forms.ComboBox();
            this.nguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doDuyDat_QLQuanGame_17DataSet = new DoDuyDat_QLQuanGame_CDTH17.DoDuyDat_QLQuanGame_17DataSet();
            this.cbbPhanquyen = new System.Windows.Forms.ComboBox();
            this.btnSetquyen = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.nguoiDungTableAdapter = new DoDuyDat_QLQuanGame_CDTH17.DoDuyDat_QLQuanGame_17DataSetTableAdapters.NguoiDungTableAdapter();
            this.quanTriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanTriTableAdapter = new DoDuyDat_QLQuanGame_CDTH17.DoDuyDat_QLQuanGame_17DataSetTableAdapters.QuanTriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doDuyDat_QLQuanGame_17DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanTriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản :";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quyền Hạn :";
            this.label2.UseWaitCursor = true;
            // 
            // cbbUser
            // 
            this.cbbUser.DataSource = this.nguoiDungBindingSource;
            this.cbbUser.DisplayMember = "ID_User";
            this.cbbUser.FormattingEnabled = true;
            this.cbbUser.Location = new System.Drawing.Point(118, 12);
            this.cbbUser.Name = "cbbUser";
            this.cbbUser.Size = new System.Drawing.Size(189, 21);
            this.cbbUser.TabIndex = 2;
            this.cbbUser.UseWaitCursor = true;
            this.cbbUser.ValueMember = "ID_User";
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
            // cbbPhanquyen
            // 
            this.cbbPhanquyen.FormattingEnabled = true;
            this.cbbPhanquyen.Items.AddRange(new object[] {
            "Admin",
            "User",
            "Guest"});
            this.cbbPhanquyen.Location = new System.Drawing.Point(118, 51);
            this.cbbPhanquyen.Name = "cbbPhanquyen";
            this.cbbPhanquyen.Size = new System.Drawing.Size(189, 21);
            this.cbbPhanquyen.TabIndex = 3;
            this.cbbPhanquyen.UseWaitCursor = true;
            // 
            // btnSetquyen
            // 
            this.btnSetquyen.Location = new System.Drawing.Point(340, 5);
            this.btnSetquyen.Name = "btnSetquyen";
            this.btnSetquyen.Size = new System.Drawing.Size(121, 33);
            this.btnSetquyen.TabIndex = 4;
            this.btnSetquyen.Text = "Set Quyền";
            this.btnSetquyen.UseVisualStyleBackColor = true;
            this.btnSetquyen.UseWaitCursor = true;
            this.btnSetquyen.Click += new System.EventHandler(this.btnSetquyen_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(340, 51);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(121, 33);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.UseWaitCursor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // nguoiDungTableAdapter
            // 
            this.nguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // quanTriBindingSource
            // 
            this.quanTriBindingSource.DataMember = "QuanTri";
            this.quanTriBindingSource.DataSource = this.doDuyDat_QLQuanGame_17DataSet;
            // 
            // quanTriTableAdapter
            // 
            this.quanTriTableAdapter.ClearBeforeFill = true;
            // 
            // PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 92);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSetquyen);
            this.Controls.Add(this.cbbPhanquyen);
            this.Controls.Add(this.cbbUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhanQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân Quyền Quản Trị";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.PhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doDuyDat_QLQuanGame_17DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanTriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbUser;
        private System.Windows.Forms.ComboBox cbbPhanquyen;
        private System.Windows.Forms.Button btnSetquyen;
        private System.Windows.Forms.Button btnThoat;
        private DoDuyDat_QLQuanGame_17DataSet doDuyDat_QLQuanGame_17DataSet;
        private System.Windows.Forms.BindingSource nguoiDungBindingSource;
        private DoDuyDat_QLQuanGame_17DataSetTableAdapters.NguoiDungTableAdapter nguoiDungTableAdapter;
        private System.Windows.Forms.BindingSource quanTriBindingSource;
        private DoDuyDat_QLQuanGame_17DataSetTableAdapters.QuanTriTableAdapter quanTriTableAdapter;
    }
}