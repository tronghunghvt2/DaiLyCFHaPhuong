using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Text;
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
            Title();
            KhungCafe();
            KhungTieu();
            KhungPhanBon();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;            
        }

        ////////////// Click StripMenu
        //HomClick
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
            Title();
            KhungCafe();
            KhungTieu();
            KhungPhanBon();
        }

        //CafeClick
        private void cafeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
            CafeDataGridViews();
            CafeTuoiDataGridViews();
            CafeKhoDataGridViews();
            MuaCafeBox();
        }

        //TieuClick
        private void tieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
        }
        
        //PhanBonCLick
        private void PhanBonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
            PhanBonDataGridViews();
        }

        private void ManagerGiaDinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
            ViewHoGiaDinh();
            ChiTietHoGiaDinh();
        }
    }
}
