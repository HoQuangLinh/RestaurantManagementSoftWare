namespace QuanLyNhaHang
{
    partial class ListStaff
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListStaff));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvStaff = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtNameStaff = new System.Windows.Forms.TextBox();
            this.txtIdStaff = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonDeleteStaff = new System.Windows.Forms.Button();
            this.buttonUpdateStaff = new System.Windows.Forms.Button();
            this.buttonAddStaff = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(338, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 35);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = true;
          
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSearch.Location = new System.Drawing.Point(45, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(290, 19);
            this.txtSearch.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvStaff);
            this.panel1.Location = new System.Drawing.Point(42, 391);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 431);
            this.panel1.TabIndex = 2;
            // 
            // dtgvStaff
            // 
            this.dtgvStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvStaff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvStaff.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvStaff.Location = new System.Drawing.Point(0, 0);
            this.dtgvStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvStaff.Name = "dtgvStaff";
            this.dtgvStaff.ReadOnly = true;
            this.dtgvStaff.RowHeadersWidth = 62;
            this.dtgvStaff.Size = new System.Drawing.Size(1054, 431);
            this.dtgvStaff.TabIndex = 0;
            
         
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.panel3.Controls.Add(this.panel13);
            this.panel3.Controls.Add(this.panel12);
            this.panel3.Controls.Add(this.panel11);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.txtPosition);
            this.panel3.Controls.Add(this.txtDate);
            this.panel3.Controls.Add(this.txtSex);
            this.panel3.Controls.Add(this.txtNameStaff);
            this.panel3.Controls.Add(this.txtIdStaff);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(35, 72);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(891, 288);
            this.panel3.TabIndex = 3;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel13.Location = new System.Drawing.Point(628, 47);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(2, 30);
            this.panel13.TabIndex = 24;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel12.Location = new System.Drawing.Point(628, 135);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(2, 30);
            this.panel12.TabIndex = 23;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel11.Location = new System.Drawing.Point(195, 218);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(2, 30);
            this.panel11.TabIndex = 22;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel10.Location = new System.Drawing.Point(195, 135);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(2, 30);
            this.panel10.TabIndex = 21;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel9.Location = new System.Drawing.Point(195, 47);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(2, 30);
            this.panel9.TabIndex = 20;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel8.Location = new System.Drawing.Point(628, 75);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(234, 2);
            this.panel8.TabIndex = 19;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel7.Location = new System.Drawing.Point(628, 163);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(234, 2);
            this.panel7.TabIndex = 18;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel6.Location = new System.Drawing.Point(196, 246);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(234, 2);
            this.panel6.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Location = new System.Drawing.Point(196, 163);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(234, 2);
            this.panel5.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Location = new System.Drawing.Point(196, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 2);
            this.panel2.TabIndex = 15;
            // 
            // txtPosition
            // 
            this.txtPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPosition.Location = new System.Drawing.Point(632, 137);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(234, 28);
            this.txtPosition.TabIndex = 11;
            this.txtPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Location = new System.Drawing.Point(632, 47);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(234, 28);
            this.txtDate.TabIndex = 9;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.txtSex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSex.Location = new System.Drawing.Point(200, 220);
            this.txtSex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(234, 28);
            this.txtSex.TabIndex = 8;
            this.txtSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNameStaff
            // 
            this.txtNameStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.txtNameStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameStaff.Location = new System.Drawing.Point(200, 137);
            this.txtNameStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNameStaff.Name = "txtNameStaff";
            this.txtNameStaff.Size = new System.Drawing.Size(234, 28);
            this.txtNameStaff.TabIndex = 7;
            this.txtNameStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIdStaff
            // 
            this.txtIdStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.txtIdStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdStaff.Location = new System.Drawing.Point(200, 47);
            this.txtIdStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdStaff.Name = "txtIdStaff";
            this.txtIdStaff.ReadOnly = true;
            this.txtIdStaff.Size = new System.Drawing.Size(234, 28);
            this.txtIdStaff.TabIndex = 6;
            this.txtIdStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(478, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chức vụ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(478, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.panel4.Controls.Add(this.buttonDeleteStaff);
            this.panel4.Controls.Add(this.buttonUpdateStaff);
            this.panel4.Controls.Add(this.buttonAddStaff);
            this.panel4.Location = new System.Drawing.Point(934, 72);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 288);
            this.panel4.TabIndex = 4;
           
            // 
            // buttonDeleteStaff
            // 
            this.buttonDeleteStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDeleteStaff.FlatAppearance.BorderSize = 0;
            this.buttonDeleteStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteStaff.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteStaff.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteStaff.Image")));
            this.buttonDeleteStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteStaff.Location = new System.Drawing.Point(8, 196);
            this.buttonDeleteStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDeleteStaff.Name = "buttonDeleteStaff";
            this.buttonDeleteStaff.Size = new System.Drawing.Size(154, 87);
            this.buttonDeleteStaff.TabIndex = 2;
            this.buttonDeleteStaff.Text = "Xóa";
            this.buttonDeleteStaff.UseVisualStyleBackColor = false;
            
            // 
            // buttonUpdateStaff
            // 
            this.buttonUpdateStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonUpdateStaff.FlatAppearance.BorderSize = 0;
            this.buttonUpdateStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateStaff.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateStaff.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdateStaff.Image")));
            this.buttonUpdateStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdateStaff.Location = new System.Drawing.Point(8, 101);
            this.buttonUpdateStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUpdateStaff.Name = "buttonUpdateStaff";
            this.buttonUpdateStaff.Size = new System.Drawing.Size(154, 85);
            this.buttonUpdateStaff.TabIndex = 1;
            this.buttonUpdateStaff.Text = "Sửa";
            this.buttonUpdateStaff.UseVisualStyleBackColor = false;
         
            // 
            // buttonAddStaff
            // 
            this.buttonAddStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAddStaff.FlatAppearance.BorderSize = 0;
            this.buttonAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStaff.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStaff.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddStaff.Image")));
            this.buttonAddStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddStaff.Location = new System.Drawing.Point(8, 5);
            this.buttonAddStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddStaff.Name = "buttonAddStaff";
            this.buttonAddStaff.Size = new System.Drawing.Size(154, 86);
            this.buttonAddStaff.TabIndex = 0;
            this.buttonAddStaff.Text = "   Thêm";
            this.buttonAddStaff.UseVisualStyleBackColor = false;
          
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Black;
            this.panel14.Location = new System.Drawing.Point(42, 51);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(290, 2);
            this.panel14.TabIndex = 8;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Black;
            this.panel15.Location = new System.Drawing.Point(42, 29);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(2, 21);
            this.panel15.TabIndex = 9;
            // 
            // ListStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Name = "ListStaff";
            this.Size = new System.Drawing.Size(1132, 845);
          
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvStaff;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtNameStaff;
        private System.Windows.Forms.TextBox txtIdStaff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonAddStaff;
        private System.Windows.Forms.Button buttonDeleteStaff;
        private System.Windows.Forms.Button buttonUpdateStaff;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
    }
}
