using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaiLyCafe
{
    public partial class Form1 : Form
    {
        //CafeNhan
        private void CafeDataGridViews()
        {
            // Tạo GroupBox để đóng khung các cột
            System.Windows.Forms.GroupBox groupBox = new System.Windows.Forms.GroupBox();
            groupBox.Font = new Font(groupBox.Font, FontStyle.Bold); // Thiết lập font in đậm và nghiêng
            groupBox.Font = new Font(groupBox.Font.FontFamily, 10, FontStyle.Bold); // Thiết lập font in đậm và tăng cỡ chữ
            groupBox.Text = "Cà phê nhân";
            groupBox.Location = new System.Drawing.Point(20, 380);
            groupBox.Size = new System.Drawing.Size(1000, 600); // Kích thước phù hợp với DataGridView
            Controls.Add(groupBox);

            DataGridView CafeDataGridView = new DataGridView();
            CafeDataGridView.Location = new System.Drawing.Point(8, 20);
            CafeDataGridView.Size = new System.Drawing.Size(860, 570); // Kích thước phù hợp với Form
            groupBox.Controls.Add(CafeDataGridView); // Thêm DataGridView vào GroupBox

            // Thêm các cột vào DataGridView
            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
            sttColumn.HeaderText = "STT";
            sttColumn.Width = 40;
            CafeDataGridView.Columns.Add(sttColumn);

            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.HeaderText = "Ngày";
            dateColumn.Width = 100;
            CafeDataGridView.Columns.Add(dateColumn);

            DataGridViewTextBoxColumn nguoiBanColumn = new DataGridViewTextBoxColumn();
            nguoiBanColumn.HeaderText = "Người bán";
            nguoiBanColumn.Width = 150;
            CafeDataGridView.Columns.Add(nguoiBanColumn);

            DataGridViewTextBoxColumn trongLuongColumn = new DataGridViewTextBoxColumn();
            trongLuongColumn.HeaderText = "Trọng\nlượng";
            trongLuongColumn.Width = 70;
            CafeDataGridView.Columns.Add(trongLuongColumn);

            DataGridViewTextBoxColumn nhietDoColumn = new DataGridViewTextBoxColumn();
            nhietDoColumn.HeaderText = "Độ\nẩm";
            nhietDoColumn.Width = 70;
            CafeDataGridView.Columns.Add(nhietDoColumn);

            DataGridViewTextBoxColumn trongLuongSauTruColumn = new DataGridViewTextBoxColumn();
            trongLuongSauTruColumn.HeaderText = "Trọng lượng\nsau trừ";
            trongLuongSauTruColumn.Width = 110;
            CafeDataGridView.Columns.Add(trongLuongSauTruColumn);

            DataGridViewTextBoxColumn giaCaColumn = new DataGridViewTextBoxColumn();
            giaCaColumn.HeaderText = "Giá\ncả";
            giaCaColumn.Width = 70;
            CafeDataGridView.Columns.Add(giaCaColumn);

            DataGridViewTextBoxColumn thanhTienColumn = new DataGridViewTextBoxColumn();
            thanhTienColumn.HeaderText = "Thành\ntiền";
            thanhTienColumn.Width = 120;
            CafeDataGridView.Columns.Add(thanhTienColumn);

            DataGridViewTextBoxColumn ghiChuColumn = new DataGridViewTextBoxColumn();
            ghiChuColumn.HeaderText = "Ghi\nchú";
            CafeDataGridView.Columns.Add(ghiChuColumn);

            //DATA-------------------------------------------FAKE
            CafeDataGridView.Rows.Add("1", "29/12/2024", "Người Bán Afdsfds", "100", "25", "5", "10000", "50.000.000");
            CafeDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100", "25", "5", "10000", "50.000.000");
            CafeDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100", "25", "5", "10000", "5.000.000");
            CafeDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100", "25", "5", "10000", "50.000.000");
            CafeDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100", "25", "5", "10000", "50.000.000");
            CafeDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100", "25", "5", "10000", "50.000.000");
            CafeDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100", "25", "5", "10000", "50.000.000");
            CafeDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100", "25", "5", "10000", "50.000.000");
            CafeDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100", "25", "5", "10000", "5.000.000");
            CafeDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100", "25", "5", "10000", "50.000.000");
            CafeDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100", "25", "5", "10000", "50.000.000");
            CafeDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100", "25", "5", "10000", "50.000.000");
            CafeDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100", "25", "5", "10000", "50.000.000");
            CafeDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100", "25", "5", "10000", "50.000.000");
            CafeDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100", "25", "5", "10000", "5.000.000");
            CafeDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100", "25", "5", "10000", "50.000.000");
            CafeDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100", "25", "5", "10000", "50.000.000");
            CafeDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100", "25", "5", "10000", "50.000.000");

            //Căn chỉnh lề
            CafeDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            CafeDataGridView.ColumnHeadersHeight = 40; // Đặt chiều cao cho hàng tiêu đề

            foreach (DataGridViewColumn column in CafeDataGridView.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn lề giữa
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn lề giữa hàng tiêu đề
                column.HeaderCell.Style.Font = new System.Drawing.Font(CafeDataGridView.Font, System.Drawing.FontStyle.Bold); // In đậm hàng tiêu đề
            }
            CafeDataGridView.Columns[CafeDataGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Đặt cột cuối cùng tự động điều chỉnh kích thước để lấp đầy không gian trống

            // Ngày tháng năm + thông tin tổng quát
            #region DateTime
            Label StartDate = new Label();
            StartDate.Location = new System.Drawing.Point(880, 20);
            StartDate.Text = "Từ ngày: ";
            StartDate.Font = new Font(StartDate.Font, FontStyle.Bold);
            StartDate.AutoSize = false;
            StartDate.Size = new Size(70, 20); // Kích thước phù hợp
            groupBox.Controls.Add(StartDate);

            DateTimePicker DateStart = new DateTimePicker();
            DateStart.Location = new System.Drawing.Point(880, 40);
            DateStart.Format = DateTimePickerFormat.Custom;
            DateStart.CustomFormat = "dd/MM/yyyy"; // Định dạng ngày tháng theo số và tiếng Việt            
            DateStart.Value = DateTime.Now; // Đặt ngày hiện tại            
            DateStart.AutoSize = false;
            DateStart.Size = new Size(100, 30);
            groupBox.Controls.Add(DateStart);

            Label EndDate = new Label();
            EndDate.Location = new System.Drawing.Point(880, 70);
            EndDate.Text = "Đến ngày: ";
            EndDate.Font = new Font(StartDate.Font, FontStyle.Bold);
            EndDate.AutoSize = false;
            EndDate.Size = new Size(70, 20); // Kích thước phù hợp
            groupBox.Controls.Add(EndDate);

            DateTimePicker DateEnd = new DateTimePicker();
            DateEnd.Location = new System.Drawing.Point(880, 90);
            DateEnd.Format = DateTimePickerFormat.Custom;
            DateEnd.CustomFormat = "dd/MM/yyyy"; // Định dạng ngày tháng theo số và tiếng Việt            
            DateEnd.Value = DateTime.Now; // Đặt ngày hiện tại            
            DateEnd.AutoSize = false;
            DateEnd.Size = new Size(100, 30);
            groupBox.Controls.Add(DateEnd);

            Label TongKGMua = new Label();
            TongKGMua.Location = new System.Drawing.Point(880, 120);
            TongKGMua.Text = "Tổng trọng lượng: ";
            TongKGMua.Font = new Font(StartDate.Font, FontStyle.Bold);
            TongKGMua.AutoSize = false;
            TongKGMua.Size = new Size(110, 20); // Kích thước phù hợp
            groupBox.Controls.Add(TongKGMua);

            TextBox TongKGMua1 = new TextBox();
            TongKGMua1.Location = new System.Drawing.Point(880, 140);
            TongKGMua1.Text = "1000";
            TongKGMua1.ReadOnly = true; // Đặt TextBox là chỉ đọc
            TongKGMua1.AutoSize = false;
            TongKGMua1.Size = new Size(100, 20); // Kích thước phù hợp
            groupBox.Controls.Add(TongKGMua1);

            Label TongTien = new Label();
            TongTien.Location = new System.Drawing.Point(880, 170);
            TongTien.Text = "Tổng tiền: ";
            TongTien.Font = new Font(StartDate.Font, FontStyle.Bold);
            TongTien.AutoSize = false;
            TongTien.Size = new Size(110, 20); // Kích thước phù hợp
            groupBox.Controls.Add(TongTien);

            /*decimal totalThanhTien = 0;
            foreach (DataGridViewRow row in CafeDataGridView.Rows)
            {
                // Kiểm tra nếu cell không phải là hàng header và có giá trị
                if (!row.IsNewRow && row.Cells["thanhTienColumn"].Value != null)
                {
                    // Lấy giá trị từ cell và cộng vào tổng
                    totalThanhTien += Convert.ToDecimal(row.Cells["thanhTienColumn"].Value);
                }
            }*/
            TextBox TongTien1 = new TextBox();
            TongTien1.Location = new Point(880, 190);
            TongTien1.Text = "10000";
            TongTien1.ReadOnly = true; //Đặt TextBox là chỉ đọc
            TongTien1.AutoSize = false;
            TongTien1.Size = new Size(100, 20); 
            groupBox.Controls.Add(TongTien1);            

            Button editButton = new Button();
            editButton.Text = "CHỌN";
            editButton.AutoSize = true;
            editButton.Font = new Font(editButton.Font.FontFamily, editButton.Font.Size + 5, FontStyle.Bold); 
            editButton.Location = new Point(880, 220);
            editButton.Click += EditCaNhanButton_Click; // Đăng ký sự kiện Click cho Button            
            groupBox.Controls.Add(editButton);
            #endregion
        }

        //CafeTuoi
        private void CafeTuoiDataGridViews()
        {
            // Tạo GroupBox để đóng khung các cột
            System.Windows.Forms.GroupBox groupBox = new System.Windows.Forms.GroupBox();
            groupBox.Font = new Font(groupBox.Font, FontStyle.Bold); // Thiết lập font in đậm
            groupBox.Font = new Font(groupBox.Font.FontFamily, 10, FontStyle.Bold); // Thiết lập font in đậm và tăng cỡ chữ
            groupBox.Text = "Cà phê tươi";
            groupBox.Location = new System.Drawing.Point(20, 40);
            groupBox.Size = new System.Drawing.Size(800, 320); // Kích thước phù hợp với DataGridView
            Controls.Add(groupBox);

            DataGridView CafeTuoiDataGridView = new DataGridView();
            CafeTuoiDataGridView.Location = new System.Drawing.Point(8, 20);
            CafeTuoiDataGridView.Size = new System.Drawing.Size(660, 290); // Kích thước phù hợp với Form
            groupBox.Controls.Add(CafeTuoiDataGridView); // Thêm DataGridView vào GroupBox

            // Thêm các cột vào DataGridView
            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
            sttColumn.HeaderText = "STT";
            sttColumn.Width = 40;
            CafeTuoiDataGridView.Columns.Add(sttColumn);

            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.HeaderText = "Ngày";
            dateColumn.Width = 100;
            CafeTuoiDataGridView.Columns.Add(dateColumn);

            DataGridViewTextBoxColumn nguoiBanColumn = new DataGridViewTextBoxColumn();
            nguoiBanColumn.HeaderText = "Người bán";
            CafeTuoiDataGridView.Columns.Add(nguoiBanColumn);

            DataGridViewTextBoxColumn trongLuongColumn = new DataGridViewTextBoxColumn();
            trongLuongColumn.HeaderText = "Trọng\nlượng";
            trongLuongColumn.Width = 90;
            CafeTuoiDataGridView.Columns.Add(trongLuongColumn);

            DataGridViewTextBoxColumn giaCaColumn = new DataGridViewTextBoxColumn();
            giaCaColumn.HeaderText = "Giá\ncả";
            giaCaColumn.Width = 70;
            CafeTuoiDataGridView.Columns.Add(giaCaColumn);

            DataGridViewTextBoxColumn thanhTienColumn = new DataGridViewTextBoxColumn();
            thanhTienColumn.HeaderText = "Thành\ntiền";
            thanhTienColumn.Width = 120;
            CafeTuoiDataGridView.Columns.Add(thanhTienColumn);

            DataGridViewTextBoxColumn ghiChuColumn = new DataGridViewTextBoxColumn();
            ghiChuColumn.HeaderText = "Ghi\nchú";
            CafeTuoiDataGridView.Columns.Add(ghiChuColumn);

            //DATA-------------------------------------------FAKE
            CafeTuoiDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25000", "50.000.000");
            CafeTuoiDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25", "50.000.000");
            CafeTuoiDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25", "50.000.000");
            CafeTuoiDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25", "50.000.000");
            CafeTuoiDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25000", "50.000.000");
            CafeTuoiDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25", "50.000.000");
            CafeTuoiDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25", "50.000.000");
            CafeTuoiDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25", "50.000.000");
            CafeTuoiDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25000", "50.000.000");
            CafeTuoiDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25", "50.000.000");
            CafeTuoiDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25", "50.000.000");
            CafeTuoiDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25", "50.000.000");
            CafeTuoiDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25000", "50.000.000");
            CafeTuoiDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25", "50.000.000");
            CafeTuoiDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25", "50.000.000");
            CafeTuoiDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25", "50.000.000");

            //Căn chỉnh lề
            CafeTuoiDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            CafeTuoiDataGridView.ColumnHeadersHeight = 40; // Đặt chiều cao cho hàng tiêu đề

            foreach (DataGridViewColumn column in CafeTuoiDataGridView.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn lề giữa
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn lề giữa hàng tiêu đề
                column.HeaderCell.Style.Font = new System.Drawing.Font(CafeTuoiDataGridView.Font, System.Drawing.FontStyle.Bold); // In đậm hàng tiêu đề
            }
            CafeTuoiDataGridView.Columns[CafeTuoiDataGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Đặt cột cuối cùng tự động điều chỉnh kích thước để lấp đầy không gian trống

            #region DateTime
            Label StartDate = new Label();
            StartDate.Location = new System.Drawing.Point(680, 20);
            StartDate.Text = "Từ ngày: ";
            StartDate.Font = new Font(StartDate.Font, FontStyle.Bold);
            StartDate.AutoSize = false;
            StartDate.Size = new Size(70, 20); // Kích thước phù hợp
            groupBox.Controls.Add(StartDate);

            DateTimePicker DateStart = new DateTimePicker();
            DateStart.Location = new System.Drawing.Point(680, 40);
            DateStart.Format = DateTimePickerFormat.Custom;
            DateStart.CustomFormat = "dd/MM/yyyy"; // Định dạng ngày tháng theo số và tiếng Việt            
            DateStart.Value = DateTime.Now; // Đặt ngày hiện tại            
            DateStart.AutoSize = false;
            DateStart.Size = new Size(100, 30);
            groupBox.Controls.Add(DateStart);

            Label EndDate = new Label();
            EndDate.Location = new System.Drawing.Point(680, 70);
            EndDate.Text = "Đến ngày: ";
            EndDate.Font = new Font(StartDate.Font, FontStyle.Bold);
            EndDate.AutoSize = false;
            EndDate.Size = new Size(70, 20); // Kích thước phù hợp
            groupBox.Controls.Add(EndDate);

            DateTimePicker DateEnd = new DateTimePicker();
            DateEnd.Location = new System.Drawing.Point(680, 90);
            DateEnd.Format = DateTimePickerFormat.Custom;
            DateEnd.CustomFormat = "dd/MM/yyyy"; // Định dạng ngày tháng theo số và tiếng Việt            
            DateEnd.Value = DateTime.Now; // Đặt ngày hiện tại            
            DateEnd.AutoSize = false;
            DateEnd.Size = new Size(100, 30);
            groupBox.Controls.Add(DateEnd);

            Label TongKGMua = new Label();
            TongKGMua.Location = new System.Drawing.Point(680, 120);
            TongKGMua.Text = "Tổng trọng lượng: ";
            TongKGMua.Font = new Font(StartDate.Font, FontStyle.Bold);
            TongKGMua.AutoSize = false;
            TongKGMua.Size = new Size(110, 20); // Kích thước phù hợp
            groupBox.Controls.Add(TongKGMua);

            TextBox TongKGMua1 = new TextBox();
            TongKGMua1.Location = new System.Drawing.Point(680, 140);
            TongKGMua1.Text = "1000";
            TongKGMua1.ReadOnly = true; // Đặt TextBox là chỉ đọc
            TongKGMua1.AutoSize = false;
            TongKGMua1.Size = new Size(100, 20); // Kích thước phù hợp
            groupBox.Controls.Add(TongKGMua1);

            Label TongTien = new Label();
            TongTien.Location = new System.Drawing.Point(680, 170);
            TongTien.Text = "Tổng tiền: ";
            TongTien.Font = new Font(StartDate.Font, FontStyle.Bold);
            TongTien.AutoSize = false;
            TongTien.Size = new Size(110, 20); // Kích thước phù hợp
            groupBox.Controls.Add(TongTien);

            /*decimal totalThanhTien = 0;
            foreach (DataGridViewRow row in CafeDataGridView.Rows)
            {
                // Kiểm tra nếu cell không phải là hàng header và có giá trị
                if (!row.IsNewRow && row.Cells["thanhTienColumn"].Value != null)
                {
                    // Lấy giá trị từ cell và cộng vào tổng
                    totalThanhTien += Convert.ToDecimal(row.Cells["thanhTienColumn"].Value);
                }
            }*/
            TextBox TongTien1 = new TextBox();
            TongTien1.Location = new System.Drawing.Point(680, 190);
            TongTien1.Text = "10000";
            TongTien1.ReadOnly = true; // Đặt TextBox là chỉ đọc
            TongTien1.AutoSize = false;
            TongTien1.Size = new Size(100, 20); // Kích thước phù hợp
            groupBox.Controls.Add(TongTien1);
            #endregion
        }

        //CafeKho
        private void CafeKhoDataGridViews()
        {
            // Tạo GroupBox để đóng khung các cột
            System.Windows.Forms.GroupBox groupBox = new System.Windows.Forms.GroupBox();
            groupBox.Font = new Font(groupBox.Font, FontStyle.Bold); // Thiết lập font in đậm
            groupBox.Font = new Font(groupBox.Font.FontFamily, 10, FontStyle.Bold); // Thiết lập font in đậm và tăng cỡ chữ
            groupBox.Text = "Cà phê khô";
            groupBox.Location = new System.Drawing.Point(840, 40);
            groupBox.Size = new System.Drawing.Size(800, 320); // Kích thước phù hợp với DataGridView
            Controls.Add(groupBox);

            DataGridView CafeKhoDataGridView = new DataGridView();
            CafeKhoDataGridView.Location = new System.Drawing.Point(8, 20);
            CafeKhoDataGridView.Size = new System.Drawing.Size(660, 290); // Kích thước phù hợp với Form
            groupBox.Controls.Add(CafeKhoDataGridView); // Thêm DataGridView vào GroupBox

            // Thêm các cột vào DataGridView
            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
            sttColumn.HeaderText = "STT";
            sttColumn.Width = 40;
            CafeKhoDataGridView.Columns.Add(sttColumn);

            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.HeaderText = "Ngày";
            dateColumn.Width = 100;
            CafeKhoDataGridView.Columns.Add(dateColumn);

            DataGridViewTextBoxColumn nguoiBanColumn = new DataGridViewTextBoxColumn();
            nguoiBanColumn.HeaderText = "Người bán";
            CafeKhoDataGridView.Columns.Add(nguoiBanColumn);

            DataGridViewTextBoxColumn trongLuongColumn = new DataGridViewTextBoxColumn();
            trongLuongColumn.HeaderText = "Trọng lượng";
            trongLuongColumn.Width = 90;
            CafeKhoDataGridView.Columns.Add(trongLuongColumn);

            DataGridViewTextBoxColumn giaCaColumn = new DataGridViewTextBoxColumn();
            giaCaColumn.HeaderText = "Giá\ncả";
            giaCaColumn.Width = 70;
            CafeKhoDataGridView.Columns.Add(giaCaColumn);

            DataGridViewTextBoxColumn thanhTienColumn = new DataGridViewTextBoxColumn();
            thanhTienColumn.HeaderText = "Thành\ntiền";
            thanhTienColumn.Width = 120;
            CafeKhoDataGridView.Columns.Add(thanhTienColumn);

            DataGridViewTextBoxColumn ghiChuColumn = new DataGridViewTextBoxColumn();
            ghiChuColumn.HeaderText = "Ghi\nchú";
            CafeKhoDataGridView.Columns.Add(ghiChuColumn);

            //DATA-------------------------------------------FAKE
            CafeKhoDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25000", "1.500.000.000");
            CafeKhoDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25", "50.000.000");
            CafeKhoDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25", "50.000.000");
            CafeKhoDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25", "50.000.000");
            CafeKhoDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25000", "50.000.000");
            CafeKhoDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25", "50.000.000");
            CafeKhoDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25", "50.000.000");
            CafeKhoDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25", "50.000.000");
            CafeKhoDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25000", "50.000.000");
            CafeKhoDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25", "50.000.000");
            CafeKhoDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25", "50.000.000");
            CafeKhoDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25", "50.000.000");
            CafeKhoDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25000", "50.000.000");
            CafeKhoDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25", "50.000.000");
            CafeKhoDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25", "50.000.000");
            CafeKhoDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100000", "25", "50.000.000");

            //Căn chỉnh lề
            CafeKhoDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            CafeKhoDataGridView.ColumnHeadersHeight = 40; // Đặt chiều cao cho hàng tiêu đề

            foreach (DataGridViewColumn column in CafeKhoDataGridView.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn lề giữa
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn lề giữa hàng tiêu đề
                column.HeaderCell.Style.Font = new System.Drawing.Font(CafeKhoDataGridView.Font, System.Drawing.FontStyle.Bold); // In đậm hàng tiêu đề
            }
            CafeKhoDataGridView.Columns[CafeKhoDataGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Đặt cột cuối cùng tự động điều chỉnh kích thước để lấp đầy không gian trống

            #region DateTime
            Label StartDate = new Label();
            StartDate.Location = new System.Drawing.Point(680, 20);
            StartDate.Text = "Từ ngày: ";
            StartDate.Font = new Font(StartDate.Font, FontStyle.Bold);
            StartDate.AutoSize = false;
            StartDate.Size = new Size(70, 20); // Kích thước phù hợp
            groupBox.Controls.Add(StartDate);

            DateTimePicker DateStart = new DateTimePicker();
            DateStart.Location = new System.Drawing.Point(680, 40);
            DateStart.Format = DateTimePickerFormat.Custom;
            DateStart.CustomFormat = "dd/MM/yyyy"; // Định dạng ngày tháng theo số và tiếng Việt            
            DateStart.Value = DateTime.Now; // Đặt ngày hiện tại            
            DateStart.AutoSize = false;
            DateStart.Size = new Size(100, 30);
            groupBox.Controls.Add(DateStart);

            Label EndDate = new Label();
            EndDate.Location = new System.Drawing.Point(680, 70);
            EndDate.Text = "Đến ngày: ";
            EndDate.Font = new Font(StartDate.Font, FontStyle.Bold);
            EndDate.AutoSize = false;
            EndDate.Size = new Size(70, 20); // Kích thước phù hợp
            groupBox.Controls.Add(EndDate);

            DateTimePicker DateEnd = new DateTimePicker();
            DateEnd.Location = new System.Drawing.Point(680, 90);
            DateEnd.Format = DateTimePickerFormat.Custom;
            DateEnd.CustomFormat = "dd/MM/yyyy"; // Định dạng ngày tháng theo số và tiếng Việt            
            DateEnd.Value = DateTime.Now; // Đặt ngày hiện tại            
            DateEnd.AutoSize = false;
            DateEnd.Size = new Size(100, 30);
            groupBox.Controls.Add(DateEnd);

            Label TongKGMua = new Label();
            TongKGMua.Location = new System.Drawing.Point(680, 120);
            TongKGMua.Text = "Tổng trọng lượng: ";
            TongKGMua.Font = new Font(StartDate.Font, FontStyle.Bold);
            TongKGMua.AutoSize = false;
            TongKGMua.Size = new Size(110, 20); // Kích thước phù hợp
            groupBox.Controls.Add(TongKGMua);

            TextBox TongKGMua1 = new TextBox();
            TongKGMua1.Location = new System.Drawing.Point(680, 140);
            TongKGMua1.Text = "1000";
            TongKGMua1.ReadOnly = true; // Đặt TextBox là chỉ đọc
            TongKGMua1.AutoSize = false;
            TongKGMua1.Size = new Size(100, 20); // Kích thước phù hợp
            groupBox.Controls.Add(TongKGMua1);

            Label TongTien = new Label();
            TongTien.Location = new System.Drawing.Point(680, 170);
            TongTien.Text = "Tổng tiền: ";
            TongTien.Font = new Font(StartDate.Font, FontStyle.Bold);
            TongTien.AutoSize = false;
            TongTien.Size = new Size(110, 20); // Kích thước phù hợp
            groupBox.Controls.Add(TongTien);

            /*decimal totalThanhTien = 0;
            foreach (DataGridViewRow row in CafeDataGridView.Rows)
            {
                // Kiểm tra nếu cell không phải là hàng header và có giá trị
                if (!row.IsNewRow && row.Cells["thanhTienColumn"].Value != null)
                {
                    // Lấy giá trị từ cell và cộng vào tổng
                    totalThanhTien += Convert.ToDecimal(row.Cells["thanhTienColumn"].Value);
                }
            }*/
            TextBox TongTien1 = new TextBox();
            TongTien1.Location = new System.Drawing.Point(680, 190);
            TongTien1.Text = "10000";
            TongTien1.ReadOnly = true; // Đặt TextBox là chỉ đọc
            TongTien1.AutoSize = false;
            TongTien1.Size = new Size(100, 20); // Kích thước phù hợp
            groupBox.Controls.Add(TongTien1);
            #endregion
        }
        
        private void MuaCafeBox()
        {
            System.Windows.Forms.GroupBox groupBox = new System.Windows.Forms.GroupBox();
            groupBox.Location = new System.Drawing.Point(1050, 380);
            groupBox.Size = new System.Drawing.Size(590, 600);
            groupBox.Text = "Mua bán";
            Controls.Add(groupBox);

            Label LoaiHangLabel = new Label();
            LoaiHangLabel.Location = new System.Drawing.Point(10, 22);
            LoaiHangLabel.Text = "Loại hàng: ";
            LoaiHangLabel.Font = new Font(LoaiHangLabel.Font.FontFamily, 12, FontStyle.Bold);
            LoaiHangLabel.AutoSize = true;            
            groupBox.Controls.Add(LoaiHangLabel);

            ComboBox LoaiHangComboBox = new ComboBox();
            LoaiHangComboBox.Text = "Cà phê nhân";
            LoaiHangComboBox.Font = new Font(LoaiHangComboBox.Font.FontFamily, 12, FontStyle.Bold);
            LoaiHangComboBox.AutoSize = false;
            LoaiHangComboBox.Size = new Size(200,20);
            LoaiHangComboBox.Location = new System.Drawing.Point(150, 20);
            groupBox.Controls.Add(LoaiHangComboBox);

            Label NguoiBanLabel = new Label();
            NguoiBanLabel.Location = new System.Drawing.Point(10, 62);
            NguoiBanLabel.Text = "Người bán: ";
            NguoiBanLabel.Font = new Font(NguoiBanLabel.Font.FontFamily, 12, FontStyle.Bold);
            NguoiBanLabel.AutoSize = true;
            groupBox.Controls.Add(NguoiBanLabel);

            TextBox NguoiBanTextbox = new TextBox();            
            NguoiBanTextbox.Font = new Font(NguoiBanTextbox.Font.FontFamily, 12, FontStyle.Bold);
            NguoiBanTextbox.AutoSize = false;
            NguoiBanTextbox.Size = new Size(200, 30);
            NguoiBanTextbox.Location = new System.Drawing.Point(150, 60);
            groupBox.Controls.Add(NguoiBanTextbox);

            Label TrongLuongLabel = new Label();
            TrongLuongLabel.Location = new System.Drawing.Point(10, 102);
            TrongLuongLabel.Text = "Trọng lượng: ";
            TrongLuongLabel.Font = new Font(TrongLuongLabel.Font.FontFamily, 12, FontStyle.Bold);
            TrongLuongLabel.AutoSize = true;
            groupBox.Controls.Add(TrongLuongLabel);

            TextBox TrongLuongTextbox = new TextBox();
            TrongLuongTextbox.Font = new Font(TrongLuongTextbox.Font.FontFamily, 12, FontStyle.Bold);
            TrongLuongTextbox.AutoSize = false;
            TrongLuongTextbox.Size = new Size(200, 30);
            TrongLuongTextbox.Location = new System.Drawing.Point(150, 100);
            groupBox.Controls.Add(TrongLuongTextbox);

            Label DoAmLabel = new Label();
            TextBox DoAmTextbox = new TextBox();

            Label TrongLuongEndLabel = new Label();
            TextBox TrongLuongEndTextbox = new TextBox();

            Label MucGiaLabel = new Label();
            TextBox MucGiaTextbox = new TextBox();

            Label ThanhTienLabel = new Label();
            TextBox ThanhTienTextbox = new TextBox();

            Label DateLabel = new Label();
            TextBox DateTextbox = new TextBox();

            Label GhiChuLabel = new Label();
            TextBox GhiChuTextbox = new TextBox();
        }


        ////////// Click
        //EditCaPheNhan
        private void EditCaNhanButton_Click(object sender, EventArgs e)
        {
            
        }

    }

}
