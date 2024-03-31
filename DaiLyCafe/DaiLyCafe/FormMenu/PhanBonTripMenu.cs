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
            trongLuongColumn.Width = 50;
            PhanBonDataGridView.Columns.Add(trongLuongColumn);

            DataGridViewTextBoxColumn mucGiaColumn = new DataGridViewTextBoxColumn();
            mucGiaColumn.HeaderText = "Mức\ngiá";
            mucGiaColumn.Width = 50;
            PhanBonDataGridView.Columns.Add(mucGiaColumn);

            DataGridViewTextBoxColumn thanhTienColumn = new DataGridViewTextBoxColumn();
            thanhTienColumn.HeaderText = "Thành\ntiền";
            thanhTienColumn.Width = 100;
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


    }
}