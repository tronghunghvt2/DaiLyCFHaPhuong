using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaiLyCafe
{
    public partial class Form1 : Form
    {
        private void ViewHoGiaDinh()
        {
            GroupBox HoGiaDinh = new GroupBox()
            {
                Text = "QUẢN LÝ HỘ GIA ĐÌNH",
                Location = new Point(20,40),
                Size = new Size(570,500),
                Font = new Font(Font.FontFamily, 12, FontStyle.Bold),                
            };
            Controls.Add(HoGiaDinh);

            DataGridView HoGiaDinhDataGridView = new DataGridView()
            {
                Font = new Font(Font.FontFamily, 10, FontStyle.Bold),
                Location = new Point(8, 20),
                Size = new Size(400, 470),
                ColumnHeadersHeight = 40,
                AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None,
            };
            HoGiaDinh.Controls.Add(HoGiaDinhDataGridView);

            //Them cac cot vao DTGRV
            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn()
            {
                HeaderText = "STT",
                Width = 50,
            };
            HoGiaDinhDataGridView.Columns.Add(sttColumn);

            DataGridViewTextBoxColumn NameColumn = new DataGridViewTextBoxColumn()
            {
                HeaderText = "Tên hộ gia đình",
                Width = 200,
            };
            HoGiaDinhDataGridView.Columns.Add(NameColumn);

            DataGridViewTextBoxColumn ThonColumn = new DataGridViewTextBoxColumn()
            {
                HeaderText = "Thôn",                
            };
            HoGiaDinhDataGridView.Columns.Add(ThonColumn);


            //DATA-------------------------------------------FAKE
            HoGiaDinhDataGridView.Rows.Add("1", "Hà Phương", "Thôn 14");
            HoGiaDinhDataGridView.Rows.Add("2", "Hà Phương 2", "Thôn 14");
            HoGiaDinhDataGridView.Rows.Add("3", "Hà Phương 3", "Thôn 14");
            HoGiaDinhDataGridView.Rows.Add("4", "Hà Phương 4", "Thôn 14");
            HoGiaDinhDataGridView.Rows.Add("5", "Hà Phương 5", "Thôn 14");


            foreach (DataGridViewColumn column in HoGiaDinhDataGridView.Columns)
            {                
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn lề giữa hàng tiêu đề                
            }
            HoGiaDinhDataGridView.Columns[HoGiaDinhDataGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Fill size DataGridView

            Label ThonLabel = new Label()
            {
                Text = "THÔN:",
                Location = new Point(430, 40),
                AutoSize = true,
                Font = new Font(Font.FontFamily, 13, FontStyle.Bold)
            };
            HoGiaDinh.Controls.Add(ThonLabel);

            ComboBox ThonComboBox = new ComboBox()
            {
                Text = "Thôn 1",
                Location = new Point(430, 70),
                Size = new Size(130, 40),
                Font = new Font(Font.FontFamily, 13, FontStyle.Bold)
            };
            HoGiaDinh.Controls.Add(ThonComboBox);

            Label TimKiemLabel = new Label()
            {
                Text = "Tìm kiếm:",
                Location = new Point(430, 130),
                AutoSize = true,
                Font = new Font(Font.FontFamily, 13, FontStyle.Bold)
            };
            HoGiaDinh.Controls.Add(TimKiemLabel);

            TextBox TimKiemTexBox = new TextBox()
            {
                Location = new Point(430, 160),
                Size = new Size(130,40)
            };
            HoGiaDinh.Controls.Add(TimKiemTexBox);

            Button ChonButton = new Button()
            {
                Text = "CHỌN",
                Location = new Point(455, 220),
                AutoSize = true,
                Font = new Font(Font.FontFamily, 13, FontStyle.Bold),

            };
            HoGiaDinh.Controls.Add(ChonButton);

        }

        private void ChiTietHoGiaDinh()
        {
            GroupBox ChiTietHoGiaDinhGrB = new GroupBox()
            {
                Text = "CHI TIẾT HỘ GIA ĐÌNH",
                
                Location = new Point(20, 570),
                Size = new Size(1330, 415),
                Font = new Font(Font.FontFamily, 12, FontStyle.Bold),

            };
            Controls.Add(ChiTietHoGiaDinhGrB);

            DataGridView ChiTietHoGiaDinhDataGridView = new DataGridView()
            {
                Font = new Font(Font.FontFamily, 10, FontStyle.Bold),
                Location = new Point(8, 20),
                Size = new Size(1150, 385),
                ColumnHeadersHeight = 40,
                AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None,
            };
            ChiTietHoGiaDinhGrB.Controls.Add(ChiTietHoGiaDinhDataGridView);

            //Them cac cot vao DTGRV
            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn()
            {
                HeaderText = "STT",
                Width = 50,
            };
            ChiTietHoGiaDinhDataGridView.Columns.Add(sttColumn);
            
            DataGridViewTextBoxColumn NameColumn = new DataGridViewTextBoxColumn()
            {
                HeaderText = "Tên hộ gia đình",
                Width = 150,
            };
            ChiTietHoGiaDinhDataGridView.Columns.Add(NameColumn);

            DataGridViewTextBoxColumn DateColumn = new DataGridViewTextBoxColumn()
            {
                HeaderText = "Ngày",
                Width = 100,
            };
            ChiTietHoGiaDinhDataGridView.Columns.Add(DateColumn);

            DataGridViewTextBoxColumn LyDoColumn = new DataGridViewTextBoxColumn()
            {
                HeaderText = "Lý do",
                Width = 200,
            };
            ChiTietHoGiaDinhDataGridView.Columns.Add(LyDoColumn);

            DataGridViewTextBoxColumn TrongLuongColumn = new DataGridViewTextBoxColumn()
            {
                HeaderText = "Trọng lượng",
                Width = 80,
            };
            ChiTietHoGiaDinhDataGridView.Columns.Add(TrongLuongColumn);

            DataGridViewTextBoxColumn ThanhTienColumn = new DataGridViewTextBoxColumn()
            {
                HeaderText = "Thành tiền",
                Width = 120,
            };
            ChiTietHoGiaDinhDataGridView.Columns.Add(ThanhTienColumn);

            DataGridViewTextBoxColumn VaoRaColumn = new DataGridViewTextBoxColumn()
            {
                HeaderText = "Mục đích",
                Width = 100,
            };
            ChiTietHoGiaDinhDataGridView.Columns.Add(VaoRaColumn);

            DataGridViewTextBoxColumn NguoiGuiColumn = new DataGridViewTextBoxColumn()
            {
                HeaderText = "Người thực hiện",
                Width = 100,
            };
            ChiTietHoGiaDinhDataGridView.Columns.Add(NguoiGuiColumn);

            DataGridViewTextBoxColumn GhiChuColumn = new DataGridViewTextBoxColumn()
            {
                HeaderText = "Ghi chú",
                
            };
            ChiTietHoGiaDinhDataGridView.Columns.Add(GhiChuColumn);


            //DATA-------------------------------------------FAKE
            ChiTietHoGiaDinhDataGridView.Rows.Add("1", "Hà Phương", "01/03/2024", "Vay Tiền", "300.000.000", "Vay nợ");
            ChiTietHoGiaDinhDataGridView.Rows.Add("2", "Hà Phương", "02/03/2024", "Mua gạo", "250.000", "Vay nợ");
            ChiTietHoGiaDinhDataGridView.Rows.Add("3", "Hà Phương", "03/03/2024", "Mua gạo", "250.000", "Vay nợ");
            ChiTietHoGiaDinhDataGridView.Rows.Add("4", "Hà Phương", "04/03/2024", "Mua gạo", "250.000", "Vay nợ");
            ChiTietHoGiaDinhDataGridView.Rows.Add("5", "Hà Phương", "15/03/2024", "Mua gạo", "250.000", "Vay nợ");
            ChiTietHoGiaDinhDataGridView.Rows.Add("6", "Hà Phương", "15/03/2024", "Gửi tiêu", "250.000.000", "Gửi vào");


            foreach (DataGridViewColumn column in ChiTietHoGiaDinhDataGridView.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn lề giữa hàng tiêu đề                
            }
            ChiTietHoGiaDinhDataGridView.Columns[ChiTietHoGiaDinhDataGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Fill size DataGridView

            Label DateStartLabel = new Label()
            {
                Text = "Từ: ",
                Location = new Point(1190, 40),
                Font = new Font(Font.FontFamily, 13, FontStyle.Bold),
                AutoSize = true,
            };
            ChiTietHoGiaDinhGrB.Controls.Add(DateStartLabel);

            DateTimePicker DateStartPicker = new DateTimePicker()
            {
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "dd/MM/yyyy",
                Size = new Size(120,40),
                Value = DateTime.Now.AddYears(-1),
                Location = new Point(1190, 70)
            };
            ChiTietHoGiaDinhGrB.Controls.Add(DateStartPicker);

            Label DateEndLabel = new Label()
            {
                Text = "Đến: ",
                Location = new Point(1190, 120),
                Font = new Font(Font.FontFamily, 13, FontStyle.Bold),
                AutoSize = true,
            };
            ChiTietHoGiaDinhGrB.Controls.Add(DateEndLabel);

            DateTimePicker DateEndPicker = new DateTimePicker()
            {
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "dd/MM/yyyy",
                Size = new Size(120, 40),
                Value = DateTime.Now,
                Location = new Point(1190, 150)
            };
            ChiTietHoGiaDinhGrB.Controls.Add(DateEndPicker);

            Label TongTienLabel = new Label()
            {
                Text = "Tổng tiền: ",
                Location = new Point(1190, 210),
                Font = new Font(Font.FontFamily, 13, FontStyle.Bold),
                AutoSize = true,
            };
            ChiTietHoGiaDinhGrB.Controls.Add(TongTienLabel);

            TextBox TongTienTextBox = new TextBox()
            {
                ReadOnly = true,
                Location = new Point(1190,240),
                Size = new Size(120,40)
            };
            ChiTietHoGiaDinhGrB.Controls.Add(TongTienTextBox);

            Button ChonChiTietHGDButton = new Button()
            {
                Text = "CHỌN",
                Location = new Point(1215, 300),
                AutoSize = true,
                Font = new Font(Font.FontFamily, 13, FontStyle.Bold),

            };
            ChiTietHoGiaDinhGrB.Controls.Add(ChonChiTietHGDButton);
        }

        private void HoGiaDinh()
        {
            GroupBox NhapHoGiaDinhGrB = new GroupBox()
            {
                Text = "HỘ GIA ĐÌNH",
                Size = new Size(410,250),
                Location = new Point(610, 40),
                Font = new Font(Font.FontFamily, 12, FontStyle.Bold),
                
            };
            Controls.Add(NhapHoGiaDinhGrB);

            Label TenHoGiaDinhLabel = new Label()
            {
                Text = "Tên hộ gia đình:",
                AutoSize = true,
                Font = new Font(Font.FontFamily, 13, FontStyle.Bold),
                Location = new Point(20,40)
            };
            NhapHoGiaDinhGrB.Controls.Add(TenHoGiaDinhLabel);

            Label ThonHoGiaDinhLabel = new Label()
            {
                Text = "Thôn:",
                AutoSize = true,
                Font = new Font(Font.FontFamily, 13, FontStyle.Bold),
                Location = new Point(20, 80)
            };
            NhapHoGiaDinhGrB.Controls.Add(ThonHoGiaDinhLabel);

            TextBox TenHoGiaDinhTextBox = new TextBox()
            {
                Font = new Font(Font.FontFamily, 13, FontStyle.Bold),
                Size = new Size(200,40),
                Location = new Point(200, 40)
            };
            NhapHoGiaDinhGrB.Controls.Add(TenHoGiaDinhTextBox);

            TextBox ThonHoGiaDinhTextBox = new TextBox()
            {
                Font = new Font(Font.FontFamily, 13, FontStyle.Bold),
                Size = new Size(200, 40),
                Location = new Point(200, 80)

            };
            NhapHoGiaDinhGrB.Controls.Add(ThonHoGiaDinhTextBox);
            


            Button ThemHoGDButton = new Button()
            {
                Text = "THÊM",
                Font = new Font(Font.FontFamily, 13, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(20, 120)
            };
            NhapHoGiaDinhGrB.Controls.Add(ThemHoGDButton);

            Button SuaHoGDButton = new Button()
            {
                Text = "SỬA",
                Font = new Font(Font.FontFamily, 13, FontStyle.Bold),
                AutoSize = true,                
                Location = new Point(120, 120)
            };
            NhapHoGiaDinhGrB.Controls.Add(SuaHoGDButton);

            Button XoaHoGDButton = new Button()
            {
                Text = "XÓA",
                Font = new Font(Font.FontFamily, 13, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(220,120)
            };
            NhapHoGiaDinhGrB.Controls.Add(XoaHoGDButton);


        }

        private void ChiTietHoGD()
        {
            GroupBox NhapChiTietHoGiaDinhGrB = new GroupBox()
            {
                Text = "CHI TIẾT HỘ GIA ĐÌNH",
                Size = new Size(580, 500),
                Location = new Point(1040, 40),
                Font = new Font(Font.FontFamily, 12, FontStyle.Bold),

            };
            Controls.Add(NhapChiTietHoGiaDinhGrB);

        }

    }
}