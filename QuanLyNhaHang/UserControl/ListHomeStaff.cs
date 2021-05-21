using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;




namespace QuanLyNhaHang
{
    public partial class ListHomeStaff : UserControl
    {
        public ListHomeStaff()
        {
            InitializeComponent();
        }

        private void ListHome_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            labelTime.Text = today.ToString("F");
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // timer1.Enabled = true;
            //timer1.Interval = 1000;
            DateTime today = DateTime.Now;
            labelTime.Text = today.ToString("F");
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }



        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void buttonFoodHome_Click(object sender, EventArgs e)
        {
            panelLoadData.Controls.Clear();
            ListFood f = new ListFood();
            panelLoadData.Controls.Add(f);
            f.BringToFront();


        }



        private void panelLoadData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFoodTable_Click(object sender, EventArgs e)
        {
            panelLoadData.Controls.Clear();
            ListTable f = new ListTable();
            panelLoadData.Controls.Add(f);

            f.BringToFront();
        }

       

        private void btnBill_Click(object sender, EventArgs e)
        {
            ListBill f = new ListBill();
            panelLoadData.Controls.Add(f);
            f.BringToFront();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }
    }
}
