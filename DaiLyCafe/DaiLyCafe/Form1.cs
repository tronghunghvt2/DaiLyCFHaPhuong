using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DaiLyCafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //InitializeDataGridViews();
            CafeDataGridViews();
            PhanBonDataGridViews();
        }
        private void CafeDataGridViews()
        {
            // Tạo GroupBox để đóng khung các cột
            System.Windows.Forms.GroupBox groupBox = new System.Windows.Forms.GroupBox();
            groupBox.Text = "Cà phê nhân";
            groupBox.Location = new System.Drawing.Point(20, 40);
            groupBox.Size = new System.Drawing.Size(680, 320); // Kích thước phù hợp với DataGridView
            Controls.Add(groupBox);

            DataGridView CafeDataGridView = new DataGridView();
            CafeDataGridView.Location = new System.Drawing.Point(8, 20);
            CafeDataGridView.Size = new System.Drawing.Size(660, 290); // Kích thước phù hợp với Form
            groupBox.Controls.Add(CafeDataGridView); // Thêm DataGridView vào GroupBox

            // Thêm các cột vào DataGridView
            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
            sttColumn.HeaderText = "STT";
            sttColumn.Width = 40;
            CafeDataGridView.Columns.Add(sttColumn);

            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.HeaderText = "Ngày";
            dateColumn.Width = 70;
            CafeDataGridView.Columns.Add(dateColumn);

            DataGridViewTextBoxColumn nguoiBanColumn = new DataGridViewTextBoxColumn();
            nguoiBanColumn.HeaderText = "Người bán";
            CafeDataGridView.Columns.Add(nguoiBanColumn);

            DataGridViewTextBoxColumn trongLuongColumn = new DataGridViewTextBoxColumn();
            trongLuongColumn.HeaderText = "Trọng\nlượng";
            trongLuongColumn.Width = 50;
            CafeDataGridView.Columns.Add(trongLuongColumn);

            DataGridViewTextBoxColumn nhietDoColumn = new DataGridViewTextBoxColumn();
            nhietDoColumn.HeaderText = "Nhiệt\ndộ";
            nhietDoColumn.Width = 50;
            CafeDataGridView.Columns.Add(nhietDoColumn);

            DataGridViewTextBoxColumn trongLuongSauTruColumn = new DataGridViewTextBoxColumn();
            trongLuongSauTruColumn.HeaderText = "Trọng lượng\nsau trừ";
            trongLuongSauTruColumn.Width = 90;
            CafeDataGridView.Columns.Add(trongLuongSauTruColumn);

            DataGridViewTextBoxColumn giaCaColumn = new DataGridViewTextBoxColumn();
            giaCaColumn.HeaderText = "Giá\ncả";
            giaCaColumn.Width = 50;
            CafeDataGridView.Columns.Add(giaCaColumn);

            DataGridViewTextBoxColumn thanhTienColumn = new DataGridViewTextBoxColumn();
            thanhTienColumn.HeaderText = "Thành\ntiền";
            thanhTienColumn.Width = 60;
            CafeDataGridView.Columns.Add(thanhTienColumn);

            DataGridViewTextBoxColumn ghiChuColumn = new DataGridViewTextBoxColumn();
            ghiChuColumn.HeaderText = "Ghi\nchú";
            CafeDataGridView.Columns.Add(ghiChuColumn);
            

            //DATA-------------------------------------------FAKE

            CafeDataGridView.Rows.Add("1","29/2/2024", "Người Bán A", "100", "25", "5", "10000", "50000000");
            CafeDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100", "25", "5", "10000", "50000000");
            CafeDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100", "25", "5", "10000", "5000000");
            CafeDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100", "25", "5", "10000", "50000000");
            CafeDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100", "25", "5", "10000", "50000000");
            CafeDataGridView.Rows.Add("1", "29/2/2024", "Người Bán A", "100", "25", "5", "10000", "50000000");

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
        }

        private void PhanBonDataGridViews()
        {
            // Tạo GroupBox để đóng khung các cột
            System.Windows.Forms.GroupBox groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox2.Text = "Phân bón";            
            groupBox2.Location = new System.Drawing.Point(20, 370);
            groupBox2.Size = new System.Drawing.Size(800, 320); // Kích thước phù hợp với DataGridView            
            Controls.Add(groupBox2);

            DataGridView PhanBonDataGridView = new DataGridView();
            PhanBonDataGridView.Location = new System.Drawing.Point(8, 20);
            PhanBonDataGridView.Size = new System.Drawing.Size(780, 290); // Kích thước phù hợp với Form
            groupBox2.Controls.Add(PhanBonDataGridView);

            // Thêm các cột vào DataGridView
            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
            sttColumn.HeaderText = "STT";
            sttColumn.Width = 40;
            PhanBonDataGridView.Columns.Add(sttColumn);

            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.HeaderText = "Ngày";
            dateColumn.Width = 70;
            PhanBonDataGridView.Columns.Add(dateColumn);

            DataGridViewTextBoxColumn nguoiMuaColumn = new DataGridViewTextBoxColumn();
            nguoiMuaColumn.HeaderText = "Người mua";
            PhanBonDataGridView.Columns.Add(nguoiMuaColumn);

            DataGridViewTextBoxColumn loaiPhanColumn = new DataGridViewTextBoxColumn();
            loaiPhanColumn.HeaderText = "Loại phân";
            PhanBonDataGridView.Columns.Add(loaiPhanColumn);

            DataGridViewTextBoxColumn soLuongColumn = new DataGridViewTextBoxColumn();
            soLuongColumn.HeaderText = "Số\nlượng";
            soLuongColumn.Width = 50;
            PhanBonDataGridView.Columns.Add(soLuongColumn);

            DataGridViewTextBoxColumn trongLuongColumn = new DataGridViewTextBoxColumn();
            trongLuongColumn.HeaderText = "Trọng\nlượng";
            trongLuongColumn.Width=50;
            PhanBonDataGridView.Columns.Add(trongLuongColumn);

            DataGridViewTextBoxColumn mucGiaColumn = new DataGridViewTextBoxColumn();
            mucGiaColumn.HeaderText = "Mức\ngiá";
            mucGiaColumn.Width = 50;
            PhanBonDataGridView.Columns.Add(mucGiaColumn);

            DataGridViewTextBoxColumn thanhTienColumn = new DataGridViewTextBoxColumn();
            thanhTienColumn.HeaderText = "Thành\ntiền";
            thanhTienColumn.Width = 60;
            PhanBonDataGridView.Columns.Add(thanhTienColumn);

            DataGridViewTextBoxColumn ghiChuColumn = new DataGridViewTextBoxColumn();
            ghiChuColumn.HeaderText = "Ghi\nchú";
            PhanBonDataGridView.Columns.Add(ghiChuColumn);

            //Căn chỉnh lề
            PhanBonDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            PhanBonDataGridView.ColumnHeadersHeight = 40; // Đặt chiều cao cho hàng tiêu đề

            foreach (DataGridViewColumn column in PhanBonDataGridView.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn lề giữa
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn lề giữa hàng tiêu đề
                column.HeaderCell.Style.Font = new System.Drawing.Font(PhanBonDataGridView.Font, System.Drawing.FontStyle.Bold); // In đậm hàng tiêu đề
            }
            PhanBonDataGridView.Columns[PhanBonDataGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Đặt cột cuối cùng tự động điều chỉnh kích thước để lấp đầy không gian trống
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
            CafeDataGridViews();
            PhanBonDataGridViews();
        }       
        


    }
}
