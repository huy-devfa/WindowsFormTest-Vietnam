using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWindowsForm_VietNam
{
    public partial class frmKetquakiemtra : Form
    {
        public frmKetquakiemtra(string ketqua, int caudung, int causai, int socaudalam)
        {
            InitializeComponent();
            lblketqua.Text = ketqua;
            lblcaudung.Text = "Câu đúng: " + caudung.ToString();
            lblcausai.Text = "Câu sai: " + causai.ToString();
            lblsocaudalam.Text = "Số câu đã làm : " + socaudalam.ToString();
        }

        private void frmKetquakiemtra_Load(object sender, EventArgs e)
        {

        }
    }
}
