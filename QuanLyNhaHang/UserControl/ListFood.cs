using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Bunifu.Framework.Lib;
using Bunifu.Framework.UI;
using Bunifu;
using BunifuAnimatorNS;
using System.Data.SqlClient;

namespace QuanLyNhaHang
{
    public partial class ListFood : UserControl
    {
        public ListFood()
        {
            InitializeComponent();

            cbbSelect.SelectedIndex = 0;

        }



    } 
}
