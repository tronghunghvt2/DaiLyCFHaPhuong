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
            GroupBox groupBox = new GroupBox()
            {
                Font = new Font(Font.FontFamily, 10, FontStyle.Bold),
                Text = "CÀ PHÊ NHÂN",
                Location = new Point(20, 380),
                Size = new Size(1000, 600),
            };
            Controls.Add(groupBox);

            DataGridView CafeDataGridView = new DataGridView()
            {
                Location = new Point(8, 20),
                Size = new Size(860, 570)
            };            
            groupBox.Controls.Add(CafeDataGridView); 

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
                column.HeaderCell.Style.Font = new Font(CafeDataGridView.Font, System.Drawing.FontStyle.Bold); // In đậm hàng tiêu đề
            }
            CafeDataGridView.Columns[CafeDataGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Đặt cột cuối cùng tự động điều chỉnh kích thước để lấp đầy không gian trống

            // Ngày tháng năm + thông tin tổng quát
            #region DateTime
            Label StartDate = new Label();
            StartDate.Location = new Point(880, 20);
            StartDate.Text = "Từ ngày: ";
            //StartDate.Font = new Font(StartDate.Font, FontStyle.Bold);
            StartDate.AutoSize = false;
            StartDate.Size = new Size(70, 20); // Kích thước phù hợp
            groupBox.Controls.Add(StartDate);

            DateTimePicker DateStart = new DateTimePicker();
            DateStart.Location = new Point(880, 40);
            DateStart.Format = DateTimePickerFormat.Custom;
            DateStart.CustomFormat = "dd/MM/yyyy"; // Định dạng ngày tháng theo số và tiếng Việt            
            DateStart.Value = DateTime.Now; // Đặt ngày hiện tại            
            DateStart.AutoSize = false;
            DateStart.Size = new Size(100, 30);
            groupBox.Controls.Add(DateStart);

            Label EndDate = new Label();
            EndDate.Location = new Point(880, 70);
            EndDate.Text = "Đến ngày: ";
           // EndDate.Font = new Font(StartDate.Font, FontStyle.Bold);
            EndDate.AutoSize = false;
            EndDate.Size = new Size(70, 20); // Kích thước phù hợp
            groupBox.Controls.Add(EndDate);

            DateTimePicker DateEnd = new DateTimePicker();
            DateEnd.Location = new Point(880, 90);
            DateEnd.Format = DateTimePickerFormat.Custom;
            DateEnd.CustomFormat = "dd/MM/yyyy"; // Định dạng ngày tháng theo số và tiếng Việt            
            DateEnd.Value = DateTime.Now; // Đặt ngày hiện tại            
            DateEnd.AutoSize = false;
            DateEnd.Size = new Size(100, 30);
            groupBox.Controls.Add(DateEnd);

            Label TongKGMua = new Label();
            TongKGMua.Location = new Point(880, 120);
            TongKGMua.Text = "Tổng trọng lượng: ";
            //TongKGMua.Font = new Font(StartDate.Font, FontStyle.Bold);
            TongKGMua.AutoSize = false;
            TongKGMua.Size = new Size(110, 20); // Kích thước phù hợp
            groupBox.Controls.Add(TongKGMua);

            TextBox TongKGMua1 = new TextBox();
            TongKGMua1.Location = new Point(880, 140);
            TongKGMua1.Text = "1000";
            TongKGMua1.ReadOnly = true; // Đặt TextBox là chỉ đọc
            TongKGMua1.AutoSize = false;
            TongKGMua1.Size = new Size(100, 20); // Kích thước phù hợp
            groupBox.Controls.Add(TongKGMua1);

            Label TongTien = new Label();
            TongTien.Location = new Point(880, 170);
            TongTien.Text = "Tổng tiền: ";
            //TongTien.Font = new Font(StartDate.Font, FontStyle.Bold);
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
            editButton.Location = new Point(880, 320);
            //editButton.Click += EditCaNhanButton_Click; // Đăng ký sự kiện Click cho Button            
            groupBox.Controls.Add(editButton);
            #endregion

            #region Tim kiem
            Label TimKiem = new Label()
            {
                Text = "Tìm kiếm:",
                Location = new Point(880, 220),
                AutoSize = true,


            };
            groupBox.Controls.Add(TimKiem);

            TextBox TimKiemTextBox = new TextBox()
            {
                Location = new Point(880, 240),
                Size = new Size(100, 20),

            };
            groupBox.Controls.Add(TimKiemTextBox);
            #endregion
        }

        //CafeTuoi
        private void CafeTuoiDataGridViews()
        {
            // Tạo GroupBox để đóng khung các cột
            System.Windows.Forms.GroupBox groupBox = new System.Windows.Forms.GroupBox();
            groupBox.Font = new Font(groupBox.Font, FontStyle.Bold); // Thiết lập font in đậm
            groupBox.Font = new Font(groupBox.Font.FontFamily, 10, FontStyle.Bold); // Thiết lập font in đậm và tăng cỡ chữ
            groupBox.Text = "CÀ PHÊ TƯƠI";
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

            Button editButton = new Button();
            editButton.Text = "CHỌN";
            editButton.AutoSize = true;
            editButton.Font = new Font(editButton.Font.FontFamily, editButton.Font.Size + 5, FontStyle.Bold);
            editButton.Location = new Point(680, 220);
            //editButton.Click += EditCaNhanButton_Click; // Đăng ký sự kiện Click cho Button            
            groupBox.Controls.Add(editButton);
            #endregion
        }

        //CafeKho
        private void CafeKhoDataGridViews()
        {
            // Tạo GroupBox để đóng khung các cột
            System.Windows.Forms.GroupBox groupBox = new System.Windows.Forms.GroupBox();
            groupBox.Font = new Font(groupBox.Font, FontStyle.Bold); // Thiết lập font in đậm
            groupBox.Font = new Font(groupBox.Font.FontFamily, 10, FontStyle.Bold); // Thiết lập font in đậm và tăng cỡ chữ
            groupBox.Text = "CÀ PHÊ KHÔ";
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

            Button editButton = new Button();
            editButton.Text = "CHỌN";
            editButton.AutoSize = true;
            editButton.Font = new Font(editButton.Font.FontFamily, editButton.Font.Size + 5, FontStyle.Bold);
            editButton.Location = new Point(680, 220);
            //editButton.Click += EditCaNhanButton_Click; // Đăng ký sự kiện Click cho Button            
            groupBox.Controls.Add(editButton);
            #endregion
        }

        private void MuaCafeBox()
        {
            GroupBox groupBox = new GroupBox();
            groupBox.Location = new Point(1050, 380);
            groupBox.Size = new Size(590, 600);
            groupBox.Text = "Mua bán";
            Controls.Add(groupBox);

            Label LoaiHangLabel = new Label();
            LoaiHangLabel.Location = new Point(10, 22);
            LoaiHangLabel.Text = "Loại hàng: ";
            LoaiHangLabel.Font = new Font(LoaiHangLabel.Font.FontFamily, 12, FontStyle.Bold);
            LoaiHangLabel.AutoSize = true;
            groupBox.Controls.Add(LoaiHangLabel);

            ComboBox LoaiHangComboBox = new ComboBox()
            {
                Font = new Font(Font.FontFamily, 12, FontStyle.Bold),
                AutoSize = false,
                Size = new Size(300, 20),
                Location = new Point(170, 20),                
            };
            LoaiHangComboBox.Items.Add("Cà phê nhân");
            LoaiHangComboBox.Items.Add("Cà phê tươi");
            LoaiHangComboBox.Items.Add("Cà phê khô");
            groupBox.Controls.Add(LoaiHangComboBox);

            

            Label NguoiBanLabel = new Label();
            NguoiBanLabel.Location = new Point(10, 62);
            NguoiBanLabel.Text = "Người bán: ";
            NguoiBanLabel.Font = new Font(NguoiBanLabel.Font.FontFamily, 12, FontStyle.Bold);
            NguoiBanLabel.AutoSize = true;
            groupBox.Controls.Add(NguoiBanLabel);

            TextBox NguoiBanTextbox = new TextBox();
            NguoiBanTextbox.Font = new Font(NguoiBanTextbox.Font.FontFamily, 12, FontStyle.Bold);
            NguoiBanTextbox.AutoSize = false;
            NguoiBanTextbox.Size = new Size(300, 30);
            NguoiBanTextbox.Location = new Point(170, 60);
            groupBox.Controls.Add(NguoiBanTextbox);

            Label TrongLuongLabel = new Label();
            TrongLuongLabel.Location = new Point(10, 102);
            TrongLuongLabel.Text = "Trọng lượng cân: ";
            TrongLuongLabel.Font = new Font(TrongLuongLabel.Font.FontFamily, 12, FontStyle.Bold);
            TrongLuongLabel.AutoSize = true;
            groupBox.Controls.Add(TrongLuongLabel);

            TextBox TrongLuongTextbox = new TextBox();
            TrongLuongTextbox.Font = new Font(TrongLuongTextbox.Font.FontFamily, 12, FontStyle.Bold);
            TrongLuongTextbox.AutoSize = false;
            TrongLuongTextbox.Size = new Size(300, 30);
            TrongLuongTextbox.Location = new Point(170, 100);
            groupBox.Controls.Add(TrongLuongTextbox);

            Label DoAmLabel = new Label()
            {
                Location = new Point(10, 142),
                Text = "Độ ẩm: ",
                Font = new Font(Font.FontFamily, 12, FontStyle.Bold),
                AutoSize = true
            };            
            groupBox.Controls.Add(DoAmLabel);

            TextBox DoAmTextbox = new TextBox()
            {
                Font = new Font(Font.FontFamily, 12, FontStyle.Bold),
                AutoSize = false,
                Size = new Size(300, 30),
                Location = new Point(170, 140)
            };
            groupBox.Controls.Add(DoAmTextbox);            

            Label TrongLuongEndLabel = new Label();
            TrongLuongEndLabel.Location = new   Point(10, 182);
            TrongLuongEndLabel.Text = "Trọng lượng mua: ";
            TrongLuongEndLabel.Font = new Font(DoAmLabel.Font.FontFamily, 12, FontStyle.Bold);
            TrongLuongEndLabel.AutoSize = true;
            groupBox.Controls.Add(TrongLuongEndLabel);

            TextBox TrongLuongEndTextbox = new TextBox();
            TrongLuongEndTextbox.Font = new Font(TrongLuongEndTextbox.Font.FontFamily, 12, FontStyle.Bold);
            TrongLuongEndTextbox.AutoSize = false;
            TrongLuongEndTextbox.Size = new Size(300, 30);
            TrongLuongEndTextbox.Location = new Point(170, 180);
            groupBox.Controls.Add(TrongLuongEndTextbox);

            Label MucGiaLabel = new Label();
            MucGiaLabel.Location = new Point(10, 222);
            MucGiaLabel.Text = "Mức giá: ";
            MucGiaLabel.Font = new Font(MucGiaLabel.Font.FontFamily, 12, FontStyle.Bold);
            MucGiaLabel.AutoSize = true;
            groupBox.Controls.Add(MucGiaLabel);

            TextBox MucGiaTextbox = new TextBox();
            MucGiaTextbox.Font = new Font(MucGiaTextbox.Font.FontFamily, 12, FontStyle.Bold);
            MucGiaTextbox.AutoSize = false;
            MucGiaTextbox.Size = new Size(300, 30);
            MucGiaTextbox.Location = new Point(170, 220);
            groupBox.Controls.Add(MucGiaTextbox);

            Label ThanhTienLabel = new Label();
            ThanhTienLabel.Location = new Point(10, 262);
            ThanhTienLabel.Text = "Thành tiền: ";
            ThanhTienLabel.Font = new Font(ThanhTienLabel.Font.FontFamily, 12, FontStyle.Bold);
            ThanhTienLabel.AutoSize = true;
            groupBox.Controls.Add(ThanhTienLabel);

            TextBox ThanhTienTextbox = new TextBox();
            ThanhTienTextbox.Font = new Font(TrongLuongTextbox.Font.FontFamily, 12, FontStyle.Bold);
            ThanhTienTextbox.AutoSize = false;
            ThanhTienTextbox.Size = new Size(300, 30);
            ThanhTienTextbox.Location = new Point(170, 260);
            groupBox.Controls.Add(ThanhTienTextbox);

            Label DateLabel = new Label();
            DateLabel.Location = new    Point(10, 302);
            DateLabel.Text = "Ngày tháng: ";
            DateLabel.Font = new Font(DateLabel.Font.FontFamily, 12, FontStyle.Bold);
            DateLabel.AutoSize = true;
            groupBox.Controls.Add(DateLabel);

            DateTimePicker DateTime = new DateTimePicker();
            DateTime.Font = new Font(DateTime.Font.FontFamily, 12, FontStyle.Bold);
            DateTime.Format = DateTimePickerFormat.Custom;
            DateTime.CustomFormat = "dd/MM/yyyy";
            DateTime.AutoSize = false;
            DateTime.Size = new Size(150, 30);
            DateTime.Location = new Point(170, 300);
            groupBox.Controls.Add(DateTime);

            Label GhiChuLabel = new Label();
            GhiChuLabel.Location = new Point(10, 342);
            GhiChuLabel.Text = "Ghi chú: ";
            GhiChuLabel.Font = new Font(GhiChuLabel.Font.FontFamily, 12, FontStyle.Bold);
            GhiChuLabel.AutoSize = true;
            groupBox.Controls.Add(GhiChuLabel);

            TextBox GhiChuTextbox = new TextBox();
            GhiChuTextbox.Font = new Font(GhiChuTextbox.Font.FontFamily, 12, FontStyle.Bold);
            GhiChuTextbox.AutoSize = false;
            GhiChuTextbox.Size = new Size(300, 150);
            GhiChuTextbox.Location = new Point(170, 340);
            groupBox.Controls.Add(GhiChuTextbox);

            LoaiHangComboBox.SelectedIndexChanged += (sender, e) =>
            {
                // Kiểm tra giá trị được chọn trong ComboBox
                if (LoaiHangComboBox.SelectedItem != null)
                {
                    if (LoaiHangComboBox.SelectedItem.ToString() == "Cà phê nhân")
                    {
                        TrongLuongTextbox.Enabled = true;
                        DoAmTextbox.Enabled = true; // Khi chọn Cà phê nhân, cho phép điền vào TextBox
                    }
                    else
                    {
                        TrongLuongTextbox.Enabled = false;
                        TrongLuongTextbox.Text = "";
                        DoAmTextbox.Enabled = false; // Khi chọn các lựa chọn khác, vô hiệu hóa TextBox
                        DoAmTextbox.Text = ""; // Xóa nội dung của TextBox
                    }
                }
            };

            Button Them = new Button();
            Them.Text = "THÊM";
            Them.AutoSize = true;
            Them.Font = new Font(Them.Font.FontFamily, Them.Font.Size + 5, FontStyle.Bold);
            Them.Location = new Point(87, 510);
            //Them.Click += ThemButton_Click(); // Đăng ký sự kiện Click cho Button            
            groupBox.Controls.Add(Them);

            Button Sua = new Button();
            Sua.Text = "SỬA";
            Sua.AutoSize = true;
            Sua.Font = new Font(Sua.Font.FontFamily, Sua.Font.Size + 5, FontStyle.Bold);
            Sua.Location = new Point(187, 510);
            //Sua.Click += ThemButton_Click(); // Đăng ký sự kiện Click cho Button            
            groupBox.Controls.Add(Sua);

            Button Xoa = new Button();
            Xoa.Text = "XÓA";
            Xoa.AutoSize = true;
            Xoa.Font = new Font(Xoa.Font.FontFamily, Xoa.Font.Size + 5, FontStyle.Bold);
            Xoa.Location = new Point(287, 510);
            //Xoa.Click += ThemButton_Click(); // Đăng ký sự kiện Click cho Button            
            groupBox.Controls.Add(Xoa);

            Button XuatHang = new Button()
            {
                Text = "XUẤT HÀNG",
                AutoSize = true,
                Font = new Font(Font.FontFamily, 13, FontStyle.Bold),
                Location = new Point(240, 555),
            };
            groupBox.Controls.Add(XuatHang);

            Button InHoaDon = new Button()
            {
                Text = "IN HÓA ĐƠN",
                AutoSize = true,
                Font = new Font(Font.FontFamily, 13, FontStyle.Bold),
                Location = new Point(387, 510),
            };
            groupBox.Controls.Add(InHoaDon);

        }  
        


    }

}
