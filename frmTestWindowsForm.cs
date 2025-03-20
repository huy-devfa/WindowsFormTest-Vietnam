using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWindowsForm_VietNam
{
    public partial class frmTestWindowsForm : Form
    {
        public frmTestWindowsForm()
        {
            InitializeComponent();
        }

        private void btnVaoBaiKiemTra_Click(object sender, EventArgs e)
        {
            switch (cmbChonChuong.Text)
            {
                case "Chương 1":
                    frmChuong1 frmChuong1 = new frmChuong1();
                    frmChuong1.Show();
                    break;
                case "Chương 2":
                    frmChuong2 frmChuong2 = new frmChuong2();
                    frmChuong2.Show();
                    break;
                case "Chương 3":
                    frmChuong3 frmChuong3 = new frmChuong3();
                    frmChuong3.Show();
                    break;
                case "Chương 4":
                    frmChuong4 frmChuong4 = new frmChuong4();
                    frmChuong4.Show();
                    break;
                case "Chương 5":
                    frmChuong5 frmChuong5 = new frmChuong5();
                    frmChuong5.Show();
                    break;
                case "Chương 6":
                    frmChuong6 frmChuong6 = new frmChuong6();
                    frmChuong6.Show();
                    break;
                case "Chương 7":
                    frmChuong7 frmChuong7 = new frmChuong7();
                    frmChuong7.Show();
                    break;
                case "Chương 8":
                    frmChuong8 frmChuong8 = new frmChuong8();
                    frmChuong8.Show();
                    break;
                default:
                    MessageBox.Show("Vui lòng chọn chương muốn kiểm tra!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

            }

        }
    }
}
