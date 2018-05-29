namespace DoDuyDat_QLQuanGame_CDTH17
{
    partial class MainForm
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManager = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManagerAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddMoney = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPCManager = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmService = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMenuManager = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBillManager = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.Label();
            this.tsmPhanQuyen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmInfo,
            this.tsmManager,
            this.tsmService,
            this.tsmFunction});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(771, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tsmInfo
            // 
            this.tsmInfo.Font = new System.Drawing.Font("Tahoma", 9F);
            this.tsmInfo.Name = "tsmInfo";
            this.tsmInfo.Size = new System.Drawing.Size(133, 20);
            this.tsmInfo.Text = "Thông Tin Cửa Hàng";
            this.tsmInfo.Click += new System.EventHandler(this.tsmInfo_Click);
            // 
            // tsmManager
            // 
            this.tsmManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmManagerAccount,
            this.tsmPCManager});
            this.tsmManager.Font = new System.Drawing.Font("Tahoma", 9F);
            this.tsmManager.Name = "tsmManager";
            this.tsmManager.Size = new System.Drawing.Size(64, 20);
            this.tsmManager.Text = "Quản Lý";
            // 
            // tsmManagerAccount
            // 
            this.tsmManagerAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddUser,
            this.tsmChangePassword,
            this.tsmAddMoney});
            this.tsmManagerAccount.Name = "tsmManagerAccount";
            this.tsmManagerAccount.Size = new System.Drawing.Size(177, 22);
            this.tsmManagerAccount.Text = "Quản Lý Tài Khoản";
            this.tsmManagerAccount.Click += new System.EventHandler(this.tsmManagerAccount_Click_1);
            // 
            // tsmAddUser
            // 
            this.tsmAddUser.Name = "tsmAddUser";
            this.tsmAddUser.Size = new System.Drawing.Size(153, 22);
            this.tsmAddUser.Text = "Tạo Tài Khoản";
            this.tsmAddUser.Click += new System.EventHandler(this.tsmAddUser_Click);
            // 
            // tsmChangePassword
            // 
            this.tsmChangePassword.Name = "tsmChangePassword";
            this.tsmChangePassword.Size = new System.Drawing.Size(153, 22);
            this.tsmChangePassword.Text = "Đổi Mật Khẩu";
            this.tsmChangePassword.Click += new System.EventHandler(this.tsmChangePassword_Click);
            // 
            // tsmAddMoney
            // 
            this.tsmAddMoney.Name = "tsmAddMoney";
            this.tsmAddMoney.Size = new System.Drawing.Size(153, 22);
            this.tsmAddMoney.Text = "Nạp Tiền";
            this.tsmAddMoney.Click += new System.EventHandler(this.tsmAddMoney_Click);
            // 
            // tsmPCManager
            // 
            this.tsmPCManager.Name = "tsmPCManager";
            this.tsmPCManager.Size = new System.Drawing.Size(177, 22);
            this.tsmPCManager.Text = "Quản Lý Thiết Bị";
            this.tsmPCManager.Click += new System.EventHandler(this.tsmPCManager_Click);
            // 
            // tsmService
            // 
            this.tsmService.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenuManager,
            this.tsmBillManager});
            this.tsmService.Font = new System.Drawing.Font("Tahoma", 9F);
            this.tsmService.Name = "tsmService";
            this.tsmService.Size = new System.Drawing.Size(61, 20);
            this.tsmService.Text = "Dịch Vụ";
            // 
            // tsmMenuManager
            // 
            this.tsmMenuManager.Name = "tsmMenuManager";
            this.tsmMenuManager.Size = new System.Drawing.Size(178, 22);
            this.tsmMenuManager.Text = "Quản Lý Thực Đơn";
            this.tsmMenuManager.Click += new System.EventHandler(this.tsmMenuManager_Click);
            // 
            // tsmBillManager
            // 
            this.tsmBillManager.Name = "tsmBillManager";
            this.tsmBillManager.Size = new System.Drawing.Size(178, 22);
            this.tsmBillManager.Text = "Quản Lý Hóa Đơn";
            this.tsmBillManager.Click += new System.EventHandler(this.tsmBillManager_Click);
            // 
            // tsmFunction
            // 
            this.tsmFunction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPhanQuyen,
            this.tsmLogout,
            this.tsmExit});
            this.tsmFunction.Font = new System.Drawing.Font("Tahoma", 9F);
            this.tsmFunction.Name = "tsmFunction";
            this.tsmFunction.Size = new System.Drawing.Size(79, 20);
            this.tsmFunction.Text = "Chức Năng";
            // 
            // tsmLogout
            // 
            this.tsmLogout.Name = "tsmLogout";
            this.tsmLogout.Size = new System.Drawing.Size(152, 22);
            this.tsmLogout.Text = "Đăng Xuất";
            this.tsmLogout.Click += new System.EventHandler(this.tsmLogout_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(152, 22);
            this.tsmExit.Text = "Thoát";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(608, 9);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(0, 13);
            this.txtID.TabIndex = 3;
            // 
            // tsmPhanQuyen
            // 
            this.tsmPhanQuyen.Name = "tsmPhanQuyen";
            this.tsmPhanQuyen.Size = new System.Drawing.Size(152, 22);
            this.tsmPhanQuyen.Text = "Phân Quyền";
            this.tsmPhanQuyen.Click += new System.EventHandler(this.tsmPhanQuyen_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoDuyDat_QLQuanGame_CDTH17.Properties.Resources._28822594_1869285000030337_1040742205_o;
            this.ClientSize = new System.Drawing.Size(771, 491);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao Diện Quản Lý";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmManager;
        private System.Windows.Forms.ToolStripMenuItem tsmService;
        private System.Windows.Forms.ToolStripMenuItem tsmFunction;
        private System.Windows.Forms.ToolStripMenuItem tsmLogout;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem tsmManagerAccount;
        private System.Windows.Forms.ToolStripMenuItem tsmPCManager;
        private System.Windows.Forms.ToolStripMenuItem tsmMenuManager;
        private System.Windows.Forms.ToolStripMenuItem tsmBillManager;
        private System.Windows.Forms.ToolStripMenuItem tsmAddUser;
        private System.Windows.Forms.ToolStripMenuItem tsmChangePassword;
        private System.Windows.Forms.ToolStripMenuItem tsmAddMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.ToolStripMenuItem tsmPhanQuyen;
    }
}