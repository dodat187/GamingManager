﻿namespace DoDuyDat_QLQuanGame_CDTH17
{
    partial class PCManager
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.thietBiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doDuyDat_QLQuanGame_17DataSet = new DoDuyDat_QLQuanGame_CDTH17.DoDuyDat_QLQuanGame_17DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.thietBiTableAdapter = new DoDuyDat_QLQuanGame_CDTH17.DoDuyDat_QLQuanGame_17DataSetTableAdapters.ThietBiTableAdapter();
            this.iDPCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thietBiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doDuyDat_QLQuanGame_17DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Người Dùng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPCDataGridViewTextBoxColumn,
            this.iDUserDataGridViewTextBoxColumn,
            this.stimeDataGridViewTextBoxColumn,
            this.etimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.thietBiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(571, 240);
            this.dataGridView1.TabIndex = 0;
            // 
            // thietBiBindingSource
            // 
            this.thietBiBindingSource.DataMember = "ThietBi";
            this.thietBiBindingSource.DataSource = this.doDuyDat_QLQuanGame_17DataSet;
            // 
            // doDuyDat_QLQuanGame_17DataSet
            // 
            this.doDuyDat_QLQuanGame_17DataSet.DataSetName = "DoDuyDat_QLQuanGame_17DataSet";
            this.doDuyDat_QLQuanGame_17DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Máy :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bắt Đầu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kết Thúc :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thời gian sử dụng :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Thành Tiền :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(588, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thêm Máy";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(588, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 47);
            this.button2.TabIndex = 7;
            this.button2.Text = "Nhập Thời Gian Bắt Đầu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(588, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 44);
            this.button3.TabIndex = 8;
            this.button3.Text = "Nhập Thời Gian Bắt Đầu";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(588, 212);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 44);
            this.button4.TabIndex = 9;
            this.button4.Text = "Tính Tiền";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(588, 368);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 42);
            this.button5.TabIndex = 10;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(246, 276);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(246, 303);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(246, 337);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(166, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(246, 376);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(166, 20);
            this.textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(246, 414);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(166, 20);
            this.textBox5.TabIndex = 15;
            // 
            // thietBiTableAdapter
            // 
            this.thietBiTableAdapter.ClearBeforeFill = true;
            // 
            // iDPCDataGridViewTextBoxColumn
            // 
            this.iDPCDataGridViewTextBoxColumn.DataPropertyName = "ID_PC";
            this.iDPCDataGridViewTextBoxColumn.HeaderText = "ID_PC";
            this.iDPCDataGridViewTextBoxColumn.Name = "iDPCDataGridViewTextBoxColumn";
            this.iDPCDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDUserDataGridViewTextBoxColumn
            // 
            this.iDUserDataGridViewTextBoxColumn.DataPropertyName = "ID_User";
            this.iDUserDataGridViewTextBoxColumn.HeaderText = "ID_User";
            this.iDUserDataGridViewTextBoxColumn.Name = "iDUserDataGridViewTextBoxColumn";
            this.iDUserDataGridViewTextBoxColumn.Width = 125;
            // 
            // stimeDataGridViewTextBoxColumn
            // 
            this.stimeDataGridViewTextBoxColumn.DataPropertyName = "Stime";
            this.stimeDataGridViewTextBoxColumn.HeaderText = "Stime";
            this.stimeDataGridViewTextBoxColumn.Name = "stimeDataGridViewTextBoxColumn";
            this.stimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // etimeDataGridViewTextBoxColumn
            // 
            this.etimeDataGridViewTextBoxColumn.DataPropertyName = "Etime";
            this.etimeDataGridViewTextBoxColumn.HeaderText = "Etime";
            this.etimeDataGridViewTextBoxColumn.Name = "etimeDataGridViewTextBoxColumn";
            this.etimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // PCManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 470);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "PCManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrderMenu_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thietBiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doDuyDat_QLQuanGame_17DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private DoDuyDat_QLQuanGame_17DataSet doDuyDat_QLQuanGame_17DataSet;
        private System.Windows.Forms.BindingSource thietBiBindingSource;
        private DoDuyDat_QLQuanGame_17DataSetTableAdapters.ThietBiTableAdapter thietBiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etimeDataGridViewTextBoxColumn;
    }
}