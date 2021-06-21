using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace QuanLyNhaHang
{

    public partial class fInvoice : Form
    {
        public fInvoice(int maban)
        {
            InitializeComponent();
            txtIdTable.Text = maban.ToString();

            LoadBill(maban);

        }
        void LoadBill(int maban)
        {
            dtgvBill.DataSource = MenuDAO.Instance.LoadBillByIdTable(maban);
            DataRow row = BillDAO.Instance.GetInforBillByIdTable(maban);
            if (row != null)
            {
                txtIdBill.Text = ((int)row["MAHOADON"]).ToString();
                txtIdTable.Text = ((int)row["MABAN"]).ToString();
                DateTime now = DateTime.Now;
                txtDate.Text = now.ToString();
                txtTotal.Text = TongTien(maban).ToString();

            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {

            // LoadBill(table.Maban);

            try
            {
                int mahoadon = Convert.ToInt32(txtIdBill.Text);
                int tongtien = Convert.ToInt32(txtTotal.Text);
                int maban = Convert.ToInt32(txtIdTable.Text);
                DateTime ngaythanhtoan = Convert.ToDateTime(txtDate.Text);
                if (BillDAO.Instance.UpdateBill(mahoadon, ngaythanhtoan, tongtien) == true)
                {
                    BillDAO.Instance.Checkout(mahoadon);
                    TableDAO.Instance.ResetStatusById(maban);
                    MessageBox.Show("Thanh toán thành công");

                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Thông tin trống");
            }
            if (dtgvBill.Rows.Count > 0)
            {
                int mahoadon = Convert.ToInt32(txtIdBill.Text);
                int tongtien = Convert.ToInt32(txtTotal.Text);
                int maban = Convert.ToInt32(txtIdTable.Text);
                DateTime ngaythanhtoan = Convert.ToDateTime(txtDate.Text);
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Mahoadon-" + mahoadon + ".pdf";
                bool fileError = false;
                //Full path to the Unicode Arial file
                string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Arial.TTF");

                //Create a base font object making sure to specify IDENTITY-H
                BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                //Create a specific font object
                iTextSharp.text.Font f = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font f1 = new iTextSharp.text.Font(bf, 20, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font f2 = new iTextSharp.text.Font(bf, 15, iTextSharp.text.Font.BOLD);
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Không thể ghi dữ liệu tới ổ đĩa. Mô tả lỗi:" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dtgvBill.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;

                            // Thêm tên cột
                            foreach (DataGridViewColumn column in dtgvBill.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, f));
                                pdfTable.AddCell(cell);
                            }
                            // Thêm dữ liệu trong từng cột
                            foreach (DataGridViewRow row in dtgvBill.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value == null)
                                    {
                                        pdfTable.AddCell(new Phrase("", f));
                                    }
                                    else
                                        pdfTable.AddCell(new Phrase(cell.Value.ToString(), f));
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                Paragraph para3 = new Paragraph("NHÀ HÀNG ĐNL", f2);
                                Paragraph para4 = new Paragraph("Địa chỉ: số nhà 123, phường Đông Hòa, thị xã Dĩ An, tỉnh Bình Dương", f);
                                Paragraph para5 = new Paragraph("Điện thoại: 0388888888 - 0345678989", f);
                                Paragraph para6 = new Paragraph("Email: DNLrestaurant@gmail.com", f);
                                Paragraph para7 = new Paragraph("HÓA ĐƠN BÁN HÀNG", f1);
                                Paragraph para8 = new Paragraph("* * *", f1);
                                Paragraph para9 = new Paragraph("------------------------------------------------------------", f);
                                Paragraph para1 = new Paragraph("Bàn " + txtIdTable.Text, f2);
                                Paragraph para = new Paragraph("                        " + label2.Text + "" + txtIdBill.Text + "                                                                             " + label4.Text + "" + txtDate.Text, f);
                                Paragraph para2 = new Paragraph("                        " + label3.Text + "" + txtIdTable.Text + "                                                                                     " + label5.Text + "" + txtTotal.Text, f);
                                para3.Alignment = Element.ALIGN_CENTER;
                                para4.Alignment = Element.ALIGN_CENTER;
                                para5.Alignment = Element.ALIGN_CENTER;
                                para6.Alignment = Element.ALIGN_CENTER;
                                para1.Alignment = Element.ALIGN_CENTER;
                                para7.Alignment = Element.ALIGN_CENTER;
                                para8.Alignment = Element.ALIGN_CENTER;
                                para9.Alignment = Element.ALIGN_CENTER;
                                para2.Alignment = Element.ALIGN_LEFT;
                                para.Alignment = Element.ALIGN_LEFT;

                                pdfDoc.Add(para3);
                                pdfDoc.Add(para4);
                                pdfDoc.Add(para5);
                                pdfDoc.Add(para6);
                                pdfDoc.Add(para9);
                                pdfDoc.Add(para7);
                                pdfDoc.Add(new Phrase(" "));
                                pdfDoc.Add(para1);
                                pdfDoc.Add(new Phrase(""));
                                pdfDoc.Add(para);
                                pdfDoc.Add(para2);


                                pdfDoc.Add(new Phrase(" "));
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Add(new Phrase("     "));
                                pdfDoc.Add(para8);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Xuất hóa đơn thành công!!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Mô tả lỗi :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có hóa đơn nào được xuất!!!", "Info");
            }
            this.Close();



        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dtgvBill_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvBill.Rows[e.RowIndex];
                txtFoodName.Text = row.Cells["Tên món ăn"].Value.ToString();
                txtUnitPrice.Text = row.Cells["Giá"].Value.ToString();
                txtCount.Text = row.Cells["Số lượng"].Value.ToString();
                txtPrice.Text = row.Cells["Thành tiền"].Value.ToString();




            }
        }
        private void txtpaymentcustomers_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int tienthoi = Convert.ToInt32(txtpaymentcustomers.Text) - Convert.ToInt32(txtTotal.Text);
                txtChange.Text = tienthoi.ToString();
            }
            catch
            {
                MessageBox.Show("Thông tin không đúng định dạng");
            }

        }
        int TongTien(int MABAN)
        {

            List<Menu> menus = MenuDAO.Instance.GetListMenusById(MABAN);


            int tongtien = 0;
            foreach (var i in menus)
            {
                tongtien += i.Thanhtien;
            }
            return tongtien;


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dtgvBill.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Mahoadon-" + txtIdBill.Text + ".pdf";
                bool fileError = false;
                //Full path to the Unicode Arial file
                string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Arial.TTF");

                //Create a base font object making sure to specify IDENTITY-H
                BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                //Create a specific font object
                iTextSharp.text.Font f = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font f1 = new iTextSharp.text.Font(bf, 20, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font f2 = new iTextSharp.text.Font(bf, 15, iTextSharp.text.Font.BOLD);
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Không thể ghi dữ liệu tới ổ đĩa. Mô tả lỗi:" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dtgvBill.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;

                            // Thêm tên cột
                            foreach (DataGridViewColumn column in dtgvBill.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, f));
                                pdfTable.AddCell(cell);
                            }
                            // Thêm dữ liệu trong từng cột
                            foreach (DataGridViewRow row in dtgvBill.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value == null)
                                    {
                                        pdfTable.AddCell(new Phrase("", f));
                                    }
                                    else
                                        pdfTable.AddCell(new Phrase(cell.Value.ToString(), f));
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                Paragraph para3 = new Paragraph("NHÀ HÀNG ĐNL", f2);
                                Paragraph para4 = new Paragraph("Địa chỉ: số nhà 123, phường Đông Hòa, thị xã Dĩ An, tỉnh Bình Dương", f);
                                Paragraph para5 = new Paragraph("Điện thoại: 0388888888 - 0345678989", f);
                                Paragraph para6 = new Paragraph("Email: DNLrestaurant@gmail.com", f);
                                Paragraph para7 = new Paragraph("HÓA ĐƠN BÁN HÀNG", f1);
                                Paragraph para8 = new Paragraph("* * *", f1);
                                Paragraph para9 = new Paragraph("------------------------------------------------------------", f);
                                Paragraph para1 = new Paragraph("Bàn " + txtIdTable.Text, f2);
                                Paragraph para = new Paragraph("                        " + label2.Text + "" + txtIdBill.Text + "                                                                             " + label4.Text + "" + txtDate.Text, f);
                                Paragraph para2 = new Paragraph("                        " + label3.Text + "" + txtIdTable.Text + "                                                                                     " + label5.Text + "" + txtTotal.Text, f);
                                para3.Alignment = Element.ALIGN_CENTER;
                                para4.Alignment = Element.ALIGN_CENTER;
                                para5.Alignment = Element.ALIGN_CENTER;
                                para6.Alignment = Element.ALIGN_CENTER;
                                para1.Alignment = Element.ALIGN_CENTER;
                                para7.Alignment = Element.ALIGN_CENTER;
                                para8.Alignment = Element.ALIGN_CENTER;
                                para9.Alignment = Element.ALIGN_CENTER;
                                para2.Alignment = Element.ALIGN_LEFT;
                                para.Alignment = Element.ALIGN_LEFT;

                                pdfDoc.Add(para3);
                                pdfDoc.Add(para4);
                                pdfDoc.Add(para5);
                                pdfDoc.Add(para6);
                                pdfDoc.Add(para9);
                                pdfDoc.Add(para7);
                                pdfDoc.Add(new Phrase(" "));
                                pdfDoc.Add(para1);
                                pdfDoc.Add(new Phrase(""));
                                pdfDoc.Add(para);
                                pdfDoc.Add(para2);


                                pdfDoc.Add(new Phrase(" "));
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Add(new Phrase("     "));
                                pdfDoc.Add(para8);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Xuất hóa đơn thành công!!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Mô tả lỗi :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có hóa đơn nào được xuất!!!", "Info");
            }
        }

        private void fInvoice_Load(object sender, EventArgs e)
        {
            this.Height = 724;
            this.Width = 1426;

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
