namespace QuanLyNhaHang
{
    partial class ListTable
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvFoodbyId = new System.Windows.Forms.DataGridView();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonPayMonney = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFoodbyId)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvFoodbyId);
            this.panel2.Location = new System.Drawing.Point(352, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 441);
            this.panel2.TabIndex = 21;
            // 
            // dtgvFoodbyId
            // 
            this.dtgvFoodbyId.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtgvFoodbyId.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFoodbyId.Location = new System.Drawing.Point(0, 3);
            this.dtgvFoodbyId.Name = "dtgvFoodbyId";
            this.dtgvFoodbyId.Size = new System.Drawing.Size(400, 435);
            this.dtgvFoodbyId.TabIndex = 0;
       
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.Yellow;
            this.buttonOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrder.Location = new System.Drawing.Point(3, 3);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(153, 63);
            this.buttonOrder.TabIndex = 28;
            this.buttonOrder.Text = "Gọi món";
            this.buttonOrder.UseVisualStyleBackColor = false;   // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.panel3.Controls.Add(this.buttonPayMonney);
            this.panel3.Controls.Add(this.buttonOrder);
            this.panel3.Location = new System.Drawing.Point(23, 467);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 69);
            this.panel3.TabIndex = 28;
            // 
            // buttonPayMonney
            // 
            this.buttonPayMonney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonPayMonney.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPayMonney.Location = new System.Drawing.Point(175, 3);
            this.buttonPayMonney.Name = "buttonPayMonney";
            this.buttonPayMonney.Size = new System.Drawing.Size(146, 63);
            this.buttonPayMonney.TabIndex = 29;
            this.buttonPayMonney.Text = "Thanh toán";
            this.buttonPayMonney.UseVisualStyleBackColor = false;
        
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(355, 467);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 69);
            this.panel1.TabIndex = 29;
         
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(146, 30);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(146, 20);
            this.txtTongTien.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng tiền";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(324, 441);
            this.flowLayoutPanel1.TabIndex = 30;
       
            // 
            // ListTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListTable";
            this.Size = new System.Drawing.Size(755, 549);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFoodbyId)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonPayMonney;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dtgvFoodbyId;
    }
}
