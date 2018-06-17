namespace DoDuyDat_QLQuanGame_CDTH17.Forms
{
    partial class ThemTien
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
            this.txtUS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnNaptien = new System.Windows.Forms.Button();
            this.txtPMN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAMN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTMN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUS
            // 
            this.txtUS.Location = new System.Drawing.Point(127, 11);
            this.txtUS.Name = "txtUS";
            this.txtUS.Size = new System.Drawing.Size(173, 20);
            this.txtUS.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tài khoản :";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(182, 188);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(118, 38);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnNaptien
            // 
            this.btnNaptien.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaptien.Location = new System.Drawing.Point(12, 188);
            this.btnNaptien.Name = "btnNaptien";
            this.btnNaptien.Size = new System.Drawing.Size(118, 38);
            this.btnNaptien.TabIndex = 8;
            this.btnNaptien.Text = "Nạp";
            this.btnNaptien.UseVisualStyleBackColor = true;
            this.btnNaptien.Click += new System.EventHandler(this.btnNaptien_Click);
            // 
            // txtPMN
            // 
            this.txtPMN.Location = new System.Drawing.Point(127, 54);
            this.txtPMN.Name = "txtPMN";
            this.txtPMN.Size = new System.Drawing.Size(173, 20);
            this.txtPMN.TabIndex = 7;
            this.txtPMN.TextChanged += new System.EventHandler(this.txtPMN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số tiền cần nạp :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Số tiền hiện tại :";
            // 
            // txtAMN
            // 
            this.txtAMN.Location = new System.Drawing.Point(127, 101);
            this.txtAMN.Name = "txtAMN";
            this.txtAMN.Size = new System.Drawing.Size(173, 20);
            this.txtAMN.TabIndex = 13;
            this.txtAMN.TextChanged += new System.EventHandler(this.txtAMN_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tổng tiền :";
            // 
            // txtTMN
            // 
            this.txtTMN.Location = new System.Drawing.Point(127, 151);
            this.txtTMN.Name = "txtTMN";
            this.txtTMN.Size = new System.Drawing.Size(173, 20);
            this.txtTMN.TabIndex = 15;
            // 
            // ThemTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 236);
            this.Controls.Add(this.txtTMN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAMN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnNaptien);
            this.Controls.Add(this.txtPMN);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThemTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Tiền";
            this.Load += new System.EventHandler(this.ThemTien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnNaptien;
        private System.Windows.Forms.TextBox txtPMN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAMN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTMN;
    }
}