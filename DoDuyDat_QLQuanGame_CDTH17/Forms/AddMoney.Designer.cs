namespace DoDuyDat_QLQuanGame_CDTH17
{
    partial class AddMoney
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
            this.btnAddMoney = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbUS = new System.Windows.Forms.ComboBox();
            this.txtPMN = new System.Windows.Forms.TextBox();
            this.txtAMN = new System.Windows.Forms.TextBox();
            this.txtTMN = new System.Windows.Forms.TextBox();
            this.nguoiDung = new DoDuyDat_QLQuanGame_CDTH17.DTS.NguoiDung();
            this.nguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nguoiDungBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nguoiDungTableAdapter = new DoDuyDat_QLQuanGame_CDTH17.DTS.NguoiDungTableAdapters.NguoiDungTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(211, 170);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 38);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnAddMoney
            // 
            this.btnAddMoney.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMoney.Location = new System.Drawing.Point(12, 171);
            this.btnAddMoney.Name = "btnAddMoney";
            this.btnAddMoney.Size = new System.Drawing.Size(120, 38);
            this.btnAddMoney.TabIndex = 14;
            this.btnAddMoney.Text = "Nạp Tiền";
            this.btnAddMoney.UseVisualStyleBackColor = true;
            this.btnAddMoney.Click += new System.EventHandler(this.btnAddMoney_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tổng số tiền :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Số tiền nạp thêm :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "TK hiện tại :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tài Khoản :";
            // 
            // cbbUS
            // 
            this.cbbUS.FormattingEnabled = true;
            this.cbbUS.Location = new System.Drawing.Point(160, 14);
            this.cbbUS.Name = "cbbUS";
            this.cbbUS.Size = new System.Drawing.Size(171, 21);
            this.cbbUS.TabIndex = 17;
            this.cbbUS.SelectedValueChanged += new System.EventHandler(this.cbbUS_SelectedValueChanged);
            // 
            // txtPMN
            // 
            this.txtPMN.Location = new System.Drawing.Point(160, 54);
            this.txtPMN.Name = "txtPMN";
            this.txtPMN.Size = new System.Drawing.Size(171, 20);
            this.txtPMN.TabIndex = 18;
            // 
            // txtAMN
            // 
            this.txtAMN.Location = new System.Drawing.Point(160, 90);
            this.txtAMN.Name = "txtAMN";
            this.txtAMN.Size = new System.Drawing.Size(171, 20);
            this.txtAMN.TabIndex = 19;
            this.txtAMN.TextChanged += new System.EventHandler(this.txtAMN_TextChanged);
            // 
            // txtTMN
            // 
            this.txtTMN.Location = new System.Drawing.Point(160, 132);
            this.txtTMN.Name = "txtTMN";
            this.txtTMN.Size = new System.Drawing.Size(171, 20);
            this.txtTMN.TabIndex = 20;
            this.txtTMN.TextChanged += new System.EventHandler(this.txtTMN_TextChanged);
            // 
            // nguoiDung
            // 
            this.nguoiDung.DataSetName = "NguoiDung";
            this.nguoiDung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nguoiDungBindingSource
            // 
            this.nguoiDungBindingSource.DataSource = this.nguoiDung;
            this.nguoiDungBindingSource.Position = 0;
            // 
            // nguoiDungBindingSource1
            // 
            this.nguoiDungBindingSource1.DataMember = "NguoiDung";
            this.nguoiDungBindingSource1.DataSource = this.nguoiDungBindingSource;
            // 
            // nguoiDungTableAdapter
            // 
            this.nguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // AddMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 220);
            this.Controls.Add(this.txtTMN);
            this.Controls.Add(this.txtAMN);
            this.Controls.Add(this.txtPMN);
            this.Controls.Add(this.cbbUS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnAddMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddMoney";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Tiền";
            this.Load += new System.EventHandler(this.AddMoney_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnAddMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbUS;
        private System.Windows.Forms.TextBox txtPMN;
        private System.Windows.Forms.TextBox txtAMN;
        private System.Windows.Forms.TextBox txtTMN;
        private DTS.NguoiDung nguoiDung;
        private System.Windows.Forms.BindingSource nguoiDungBindingSource;
        private System.Windows.Forms.BindingSource nguoiDungBindingSource1;
        private DTS.NguoiDungTableAdapters.NguoiDungTableAdapter nguoiDungTableAdapter;
    }
}