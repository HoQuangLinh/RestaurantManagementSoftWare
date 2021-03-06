using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;


namespace QuanLyNhaHang
{
    public partial class fHome : Form
    {
        int PanelWidth;


        public fHome()
        {
            InitializeComponent();
            PanelWidth = panelLeft.Width;
            panelMove.Height = buttonHome.Height;
            panelMove.Top = buttonHome.Top;
            buttonHome.BackColor = Color.FromArgb(136, 232, 242);

        }


        private void buttonFood_Click(object sender, EventArgs e)
        {
            //PanelLeft hiển thị theo từng tab
            panelMove.Height = buttonFood.Height;
            panelMove.Top = buttonFood.Top;
            buttonFood.BackColor = Color.FromArgb(136, 232, 242);
            //LoadData lên form
            ListFood f = new ListFood();
            this.panelLoadData.Controls.Add(f);
            f.BringToFront();
            //button trả về màu cũ khi qua button khác
            buttonHome.BackColor = Color.FromArgb(5, 199, 242);
            buttonTable.BackColor = Color.FromArgb(5, 199, 242);
            buttonStaff.BackColor = Color.FromArgb(5, 199, 242);
            buttonBill.BackColor = Color.FromArgb(5, 199, 242);
            buttonRevenue.BackColor = Color.FromArgb(5, 199, 242);
        }

        private void buttonTable_Click(object sender, EventArgs e)
        {
            panelMove.Height = buttonTable.Height;
            panelMove.Top = buttonTable.Top;
            buttonTable.BackColor = Color.FromArgb(136, 232, 242);
            //LoadData lên form
            ListTable f = new ListTable();
            this.panelLoadData.Controls.Add(f);
            f.BringToFront();
            //button trả về màu cũ khi qua button khác
            buttonFood.BackColor = Color.FromArgb(5, 199, 242);
            buttonHome.BackColor = Color.FromArgb(5, 199, 242);
            buttonStaff.BackColor = Color.FromArgb(5, 199, 242);
            buttonBill.BackColor = Color.FromArgb(5, 199, 242);
            buttonRevenue.BackColor = Color.FromArgb(5, 199, 242);
        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            panelMove.Height = buttonStaff.Height;
            panelMove.Top = buttonStaff.Top;
            buttonStaff.BackColor = Color.FromArgb(136, 232, 242);
            //LoadData lên form
            ListStaff f = new ListStaff();
            this.panelLoadData.Controls.Add(f);
            f.BringToFront();
            //button trả về màu cũ khi qua button khác
            buttonFood.BackColor = Color.FromArgb(5, 199, 242);
            buttonHome.BackColor = Color.FromArgb(5, 199, 242);
            buttonTable.BackColor = Color.FromArgb(5, 199, 242);
            buttonBill.BackColor = Color.FromArgb(5, 199, 242);
            buttonRevenue.BackColor = Color.FromArgb(5, 199, 242);
        }

        private void buttonBill_Click(object sender, EventArgs e)
        {
            panelMove.Height = buttonBill.Height;
            panelMove.Top = buttonBill.Top;
            buttonBill.BackColor = Color.FromArgb(136, 232, 242);
            //LoadData lên form
            ListBill f = new ListBill();
            this.panelLoadData.Controls.Add(f);
            f.BringToFront();
            //button trả về màu cũ khi qua button khác
            buttonFood.BackColor = Color.FromArgb(5, 199, 242);
            buttonHome.BackColor = Color.FromArgb(5, 199, 242);
            buttonTable.BackColor = Color.FromArgb(5, 199, 242);
            buttonStaff.BackColor = Color.FromArgb(5, 199, 242);
            buttonRevenue.BackColor = Color.FromArgb(5, 199, 242);
        }



        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelMove.Height = buttonHome.Height;
            panelMove.Top = buttonHome.Top;
            buttonHome.BackColor = Color.FromArgb(136, 232, 242);
            //LoadData lên form
            ListHome fh = new ListHome();
            this.panelLoadData.Controls.Add(fh);
            fh.BringToFront();
            //button trả về màu cũ khi qua button khác
            buttonFood.BackColor = Color.FromArgb(5, 199, 242);
            buttonTable.BackColor = Color.FromArgb(5, 199, 242);
            buttonStaff.BackColor = Color.FromArgb(5, 199, 242);
            buttonBill.BackColor = Color.FromArgb(5, 199, 242);
            buttonRevenue.BackColor = Color.FromArgb(5, 199, 242);

        }



        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            new fLogin().Show();
        }



        private void buttonRevenue_Click(object sender, EventArgs e)
        {
            panelMove.Height = buttonRevenue.Height;
            panelMove.Top = buttonRevenue.Top;
            buttonRevenue.BackColor = Color.FromArgb(136, 232, 242);
            //LoadData lên form
            ListRevenue lr = new ListRevenue();
            this.panelLoadData.Controls.Add(lr);
            lr.BringToFront();
            //button trả về màu cũ khi qua button khác
            buttonFood.BackColor = Color.FromArgb(5, 199, 242);
            buttonHome.BackColor = Color.FromArgb(5, 199, 242);
            buttonTable.BackColor = Color.FromArgb(5, 199, 242);
            buttonStaff.BackColor = Color.FromArgb(5, 199, 242);
            buttonBill.BackColor = Color.FromArgb(5, 199, 242);

        }


        private void fHome_Load(object sender, EventArgs e)
        {
            this.Height = 880;
            this.Width = 1500;

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            fHelp f = new fHelp();
            f.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLoadData_Paint(object sender, PaintEventArgs e)
        {
            ListHome fh = new ListHome();
            this.panelLoadData.Controls.Add(fh);
            fh.BringToFront();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



    }
}