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
                Size = new Size(500,500),
                Font = new Font(Font.FontFamily, 12, FontStyle.Bold),                
            };
            Controls.Add(HoGiaDinh);

            DataGridView HoGiaDinhDataGridView = new DataGridView()
            {
                Font = new Font(Font.FontFamily, 10, FontStyle.Bold),
                Location = new Point(20, 40),
                Size = new Size(400, 440),
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
        }

        private void ChiTietHoGiaDinh()
        {
            GroupBox ChiTietHoGiaDinhGrB = new GroupBox()
            {
                Text = "CHI TIẾT HỘ GIA ĐÌNH",
                Location = new Point(540, 40),
                Size = new Size(1000, 500),
                Font = new Font(Font.FontFamily, 12, FontStyle.Bold),

            };
            Controls.Add(ChiTietHoGiaDinhGrB);

            DataGridView ChiTietHoGiaDinhDataGridView = new DataGridView()
            {
                Font = new Font(Font.FontFamily, 10, FontStyle.Bold),
                Location = new Point(20, 40),
                Size = new Size(850, 440),
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



            Label TongTien = new Label()
            {
                Text = "Tổng tiền: ",
            };
        }
    }
}