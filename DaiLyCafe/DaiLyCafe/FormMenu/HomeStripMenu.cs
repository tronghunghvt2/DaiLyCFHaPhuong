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
        private void Title()
        {
            Label Home = new Label();
            Home.Text = "Trang Chủ";
            Home.Font = new Font(Home.Font.FontFamily, 15, FontStyle.Bold);
            Home.Location = new Point(20, 40);
            Home.AutoSize = true;
            Controls.Add(Home);

            Label DateStartLabel = new Label();
            DateStartLabel.Text = "Từ: ";
            DateStartLabel.Font = new Font(DateStartLabel.Font.FontFamily, 12, FontStyle.Bold);
            DateStartLabel.Location = new Point(1200, 42);
            DateStartLabel.AutoSize = true;
            Controls.Add(DateStartLabel);

            Label DateEndLabel = new Label();
            DateEndLabel.Text = "Đến: ";
            DateEndLabel.Font = new Font(DateEndLabel.Font.FontFamily, 12, FontStyle.Bold);
            DateEndLabel.Location = new Point(1400, 42);
            DateEndLabel.AutoSize = true;
            Controls.Add(DateEndLabel);

            DateTimePicker DateStartPicker = new DateTimePicker();
            DateStartPicker.Font = new Font(DateStartPicker.Font.FontFamily, 12, FontStyle.Bold);
            DateStartPicker.Format = DateTimePickerFormat.Custom;
            DateStartPicker.CustomFormat = "dd/MM/yyyy";
            DateStartPicker.AutoSize = false;
            DateStartPicker.Size = new Size(150, 30);
            DateStartPicker.Location = new System.Drawing.Point(1240, 40);
            Controls.Add(DateStartPicker);

            DateTimePicker DateEndPicker = new DateTimePicker();
            DateEndPicker.Font = new Font(DateEndPicker.Font.FontFamily, 12, FontStyle.Bold);
            DateEndPicker.Format = DateTimePickerFormat.Custom;
            DateEndPicker.CustomFormat = "dd/MM/yyyy";
            DateEndPicker.AutoSize = false;
            DateEndPicker.Size = new Size(150, 30);
            DateEndPicker.Location = new System.Drawing.Point(1460, 40);
            Controls.Add(DateEndPicker);
        }

        private void KhungCafe()
        {
            GroupBox groupBox = new GroupBox()
            {                
                Font = new Font(Font.FontFamily, 12, FontStyle.Bold),
                Text = "Cà phê",
                Location = new Point(30, 80),
                Size = new Size(520, 300),
            };           
            Controls.Add(groupBox);

            Label CafeNhan = new Label()
            {
                Text = "Tổng khối lượng Cà phê nhân mua (KG): ",
                Font = new Font(Font.FontFamily, 12),
                Location = new Point(20, 40),
                AutoSize = true,            
            };
            groupBox.Controls.Add(CafeNhan);

            Label CafeTuoi = new Label()
            {
                Text = "Tổng khối lượng Cà phê tươi mua (KG): ",
                Font = new Font(Font.FontFamily, 12),
                Location = new Point(20, 80),
                AutoSize = true,
            };            
            groupBox.Controls.Add(CafeTuoi);

            Label CafeKho = new Label()
            {
                Text = "Tổng khối lượng Cà phê khô mua (KG): ",
                Font = new Font(Font.FontFamily, 12),
                Location = new Point(20, 120),
                AutoSize = true,
            };            
            groupBox.Controls.Add(CafeKho);

            Label NgayXuatHangGanNhat = new Label()
            {
                Text = "Ngày xuất hàng gần nhất: ",
                Font = new Font(Font.FontFamily, 12),
                Location = new Point(20, 160),
                AutoSize = true,
            };
            groupBox.Controls.Add(NgayXuatHangGanNhat);

            Label TrongLuongXuatHangGanNhat = new Label()
            {
                Text = "Trọng lượng xuất hàng gần nhất (KG): ",
                Font = new Font(Font.FontFamily, 12),
                Location = new Point(20, 200),
                AutoSize = true,
            };
            groupBox.Controls.Add(TrongLuongXuatHangGanNhat);

            //Chua xong ne
            TextBox CafeNhanTextBox = new TextBox()
            {
                ReadOnly = true,
                Location = new Point(320, 38),
            };
            groupBox.Controls.Add(CafeNhanTextBox);

            TextBox CafeTuoiTextBox = new TextBox()
            {
                ReadOnly = true,
                Location = new Point(320, 78),
            };
            groupBox.Controls.Add(CafeTuoiTextBox);

            TextBox CafeKhoTextBox = new TextBox()
            {
                ReadOnly = true,
                Location = new Point(320, 118),
            };
            groupBox.Controls.Add(CafeKhoTextBox);

            TextBox NgayXuatHangTextBox = new TextBox()
            {
                ReadOnly = true,
                Location = new Point(320, 158),
                Text = "31/03/2024",
            };
            groupBox.Controls.Add(NgayXuatHangTextBox);

            TextBox TrongLuongXuatHangTextBox = new TextBox()
            {
                ReadOnly = true,
                Location = new Point(320, 198),
                Text = "10000"
            };
            groupBox.Controls.Add(TrongLuongXuatHangTextBox);


        }

        private void KhungTieu()
        {
            GroupBox groupBox = new GroupBox()
            {                
                Font = new Font(Font.FontFamily, 12, FontStyle.Bold),
                Text = "Tiêu",
                Location = new Point(570, 80),
                Size = new Size(520, 300),
            };                        
            Controls.Add(groupBox);

            Label TieuLabel = new Label()
            {
                Text = "Tổng khối lượng Tiêu mua (KG): ",
                Font = new Font(Font.FontFamily, 12),
                Location = new Point(20, 40),
                AutoSize = true,
            };
            groupBox.Controls.Add(TieuLabel);

            Label TieuLepLabel = new Label()
            {
                Text = "Tổng khối lượng Tiêu lép mua (KG): ",
                Font = new Font(Font.FontFamily, 12),
                Location = new Point(20, 80),
                AutoSize = true,
            };
            groupBox.Controls.Add(TieuLepLabel);

            //Chua xong ne
            TextBox TieuTextBox = new TextBox()
            {
                ReadOnly = true,
                Location = new Point(300, 38),
            };
            groupBox.Controls.Add(TieuTextBox);

            TextBox TieuLepTextBox = new TextBox()
            {
                ReadOnly = true,
                Location = new Point(300, 78),
            };
            groupBox.Controls.Add(TieuLepTextBox);
        }

        private void KhungPhanBon()
        {
            GroupBox groupBox = new GroupBox()
            {
                Font = new Font(Font.FontFamily, 12, FontStyle.Bold),
                Text = "Phân bón",
                Location = new Point(1110, 80),
                Size = new Size(520, 300),
            };            
            Controls.Add(groupBox);

            Label Phan1 = new Label() 
            { 
                Text = "Khối lượng phân 1 còn (KG): ",
                Font = new Font(Font.FontFamily, 12),
                Location = new Point(20, 40),
                AutoSize = true,

            };
            groupBox.Controls.Add(Phan1);

            Label Phan2 = new Label()
            {
                Text = "Khối lượng phân 2 còn (KG): ",
                Font = new Font(Font.FontFamily, 12),
                Location = new Point(20, 80),
                AutoSize = true,

            };
            groupBox.Controls.Add(Phan2);

            Label Phan3 = new Label()
            {
                Text = "Khối lượng phân 3 còn (KG): ",
                Font = new Font(Font.FontFamily, 12),
                Location = new Point(20, 120),
                AutoSize = true,

            };
            groupBox.Controls.Add(Phan3);

            Label Phan4 = new Label()
            {
                Text = "Khối lượng phân 4 còn (KG): ",
                Font = new Font(Font.FontFamily, 12),
                Location = new Point(20, 160),
                AutoSize = true,

            };
            groupBox.Controls.Add(Phan4);

            Label Phan5 = new Label()
            {
                Text = "Khối lượng phân 5 còn (KG): ",
                Font = new Font(Font.FontFamily, 12),
                Location = new Point(20, 200),
                AutoSize = true,

            };
            groupBox.Controls.Add(Phan5);

            Label Phan6 = new Label()
            {
                Text = "Khối lượng phân 6 còn (KG): ",
                Font = new Font(Font.FontFamily, 12),
                Location = new Point(20, 240),
                AutoSize = true,
            };
            groupBox.Controls.Add(Phan6);

            TextBox Phan1TextBox = new TextBox()
            {
                ReadOnly = true,
                Location = new Point(300, 38),
                Text = "100"
            };
            groupBox.Controls.Add(Phan1TextBox);

            TextBox Phan2TextBox = new TextBox()
            {
                ReadOnly = true,
                Location = new Point(300, 78),
                Text = "200"
            };
            groupBox.Controls.Add(Phan2TextBox);

            TextBox Phan3TextBox = new TextBox()
            {
                ReadOnly = true,
                Location = new Point(300, 118),
                Text = "300"
            };
            groupBox.Controls.Add(Phan3TextBox);

            TextBox Phan4TextBox = new TextBox()
            {
                ReadOnly = true,
                Location = new Point(300, 158),
                Text = "400"
            };
            groupBox.Controls.Add(Phan4TextBox);

            TextBox Phan5TextBox = new TextBox()
            {
                ReadOnly = true,
                Location = new Point(300, 198),
                Text = "500"
            };
            groupBox.Controls.Add(Phan5TextBox);

            TextBox Phan6TextBox = new TextBox()
            {
                ReadOnly = true,
                Location = new Point(300, 238),
                Text = "600",
            };
            groupBox.Controls.Add(Phan6TextBox);            
        }
    }
}